#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using AASharp;
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.Plotting;

/// <summary>
/// A class for 2D projection methods.
/// </summary>
public class Projection
{
    /// <summary>
    /// Projects the specified horizontal coordinate to 2D coordinate.
    /// </summary>
    /// <param name="coordinate">The coordinate to project.</param>
    /// <param name="invertEastWest">A value indicating whether to invert to projection in east-west direction.</param>
    /// <param name="diameter">The diameter in points of the 2D star map.</param>
    /// <param name="zoomPanPointX">The zoom pan X-point.</param>
    /// <param name="zoomPanPointY">The zoom pan Y-point.</param>
    /// <param name="zoom">The zoom multiplier.</param>
    /// <returns>An instance to the <see cref="AAS2DCoordinate"/> class containing the projected 2D point.</returns>
    // This formula derived from (C): https://astronomy.stackexchange.com/questions/35882/how-to-make-projection-from-altitude-and-azimuth-to-screen-with-screen-coordinat
    public static AAS2DCoordinate Project2D(AAS2DCoordinate coordinate, bool invertEastWest, double diameter, double zoomPanPointX, double zoomPanPointY, double zoom)
    {
        var azimuth = ((coordinate.X + 180) % 360).ToRadians();
        var altitude = (coordinate.Y).ToRadians();

        var x = Math.Sin(azimuth) * Math.Cos(altitude);
        var y = Math.Cos(azimuth) * Math.Cos(altitude);
        var z = Math.Sin(altitude);

        var x1 = x / (z + 1);
        var y1 = y / (z + 1);

        var r = (diameter * zoom) / 2;
        var xR = r * (1 - x1);
        var yR = r * (1 - y1);

        xR -= zoomPanPointX;
        yR -= zoomPanPointY;

        return new AAS2DCoordinate { X = invertEastWest ? diameter - xR : xR, Y = yR, };
    }

    /// <summary>
    /// Inverts the specified projection into horizontal coordinates.
    /// </summary>
    /// <param name="coordinate">The coordinate which stereographic projection to invert.</param>
    /// <param name="invertEastWest">A value indicating whether to invert to projection in east-west direction.</param>
    /// <param name="diameter">The diameter of the map area in points.</param>
    /// <param name="zoomPanPointX">The zoom pan X-point.</param>
    /// <param name="zoomPanPointY">The zoom pan Y-point.</param>
    /// <param name="zoom">The zoom multiplier.</param>
    /// <returns>An instance of the <see cref="AAS2DCoordinate"/> class.</returns>
    public static AAS2DCoordinate Invert2DProjection(AAS2DCoordinate coordinate, bool invertEastWest, double diameter, double zoomPanPointX, double zoomPanPointY, double zoom)
    {
        var xR = coordinate.X + zoomPanPointX;
        var yR = coordinate.Y + zoomPanPointY;

        xR = invertEastWest ? diameter - xR : xR;

        var r = (diameter * zoom) / 2;

        var x1 = 1 - (xR / r);
        var y1 = 1 - (yR / r);

        var azimuth = Math.Atan(x1 / y1) + Math.PI;

        var a = Math.Pow(x1, 2) + Math.Pow(y1, 2);
        var divisor = 1 + a;
        var dividend = 1 - a;

        var altitude = Math.Asin(dividend / divisor);

        var azimuthDegrees = azimuth.ToDegrees() % 360;
        var altitudeDegrees = altitude.ToDegrees();

        // This weird rule, circle quarter 3 starting from left top "corner" or xR @ first corner & degrees < 180:
        //               |
        //       (xR)    |
        //   az < 180°   |
        //               |
        // --------------|--------------
        //               |
        //               |
        //               |   (xR,yR)
        //               |
        if ((azimuthDegrees - 180 < 0 && xR < r) || (xR > r && yR > r))
        {
            azimuthDegrees -= 180;
            azimuthDegrees = (360 + azimuthDegrees) % 360;
        }

        return new AAS2DCoordinate { X = azimuthDegrees, Y = altitudeDegrees, };
    }
}