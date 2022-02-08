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

namespace StarMap2D.Calculations.Plotting;

/// <summary>
/// A class for plotting star data to a 2D projection.
/// </summary>
public class Plot2D
{
    private DateTime dateTimeUtc = DateTime.UtcNow;
    private AASDate aaDate;

    /// <summary>
    /// Initializes a new instance of the <see cref="Plot2D"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    public Plot2D(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
        DateTimeUtc = DateTime.UtcNow;
        aaDate = new AASDate(dateTimeUtc.Year, dateTimeUtc.Month, dateTimeUtc.Day, dateTimeUtc.Hour,
            dateTimeUtc.Minute, dateTimeUtc.Second, true);
    }

    private double longitude;

    /// <summary>
    /// Gets or sets the longitude of the observer in degrees.
    /// </summary>
    /// <value>The longitude of the observer in degrees.</value>
    public double Longitude 
    { 
        get => longitude;

        set
        {
            if (value != longitude)
            {
                longitude = value;
                ResetZoomPan();
            }
        }
    }

    private double latitude;

    /// <summary>
    /// Gets or sets the latitude of the observer in degrees.
    /// </summary>
    /// <value>The latitude of the observer in degrees.</value>
    public double Latitude
    {
        get => latitude;

        set
        {
            if (value != latitude)
            {
                latitude = value;
                ResetZoomPan();
            }
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to use high precision on calculations with the AASharp library.
    /// </summary>
    /// <value><c>true</c> if to use high precision on calculations with the AASharp library; otherwise, <c>false</c>.</value>
    public bool HighPrecision { get; set; } = Globals.HighPrecisionCalculations;

    private double diameter = 500;

    /// <summary>
    /// Resets the zoom panning to the center of the map.
    /// </summary>
    public void ResetZoomPan()
    {
        zoomPanPointX = Diameter * (Zoom - 1) / 2;
        zoomPanPointY = Diameter * (Zoom - 1) / 2;
    }

    /// <summary>
    /// Gets or sets the diameter of the 2D plot area.
    /// </summary>
    /// <value>The diameter of the 2D plot area.</value>
    public double Diameter
    {
        get => diameter;

        set
        {
            if (value != diameter && value > 0)
            {
                diameter = value;
                ResetZoomPan();
            }
        }
    }

    private double zoomPanPointX;

    /// <summary>
    /// Gets or sets the zoom pan X-coordinate offset.
    /// </summary>
    /// <value>The zoom pan X-coordinate offset.</value>
    public double ZoomPanPointX
    {
        get => zoomPanPointX;

        set
        {
            if (value != zoomPanPointX)
            {
                if (Math.Abs(zoom - 1) < 0.00001)
                {
                    zoomPanPointX = 0;
                    return;
                }

                if (value < Diameter / 2)
                {
                    zoomPanPointX = Diameter / 2;
                }

                if (value > Diameter * zoom - Diameter)
                {
                    zoomPanPointX = Diameter * zoom - Diameter;
                }

                zoomPanPointX = value;
            }
        }
    }

    private double zoomPanPointY;

    /// <summary>
    /// Gets or sets the zoom pan Y-coordinate offset.
    /// </summary>
    /// <value>The zoom pan Y-coordinate offset.</value>
    public double ZoomPanPointY
    {
        get => zoomPanPointY;

        set
        {
            if (value != zoomPanPointY)
            {
                if (Math.Abs(zoom - 1) < 0.00001)
                {
                    zoomPanPointY = 0;
                    return;
                }

                if (value < Diameter / 2)
                {
                    zoomPanPointY = Diameter / 2;
                }
                else if (value > Diameter * zoom - Diameter)
                {
                    zoomPanPointY = Diameter * zoom - Diameter;
                }
                else
                {
                    zoomPanPointY = value;
                }
            }
        }
    }

    private double zoom = 1.0;

    /// <summary>
    /// Gets or sets the zoom of the 2D projection.
    /// </summary>
    /// <value>The zoom.</value>
    public double Zoom
    {
        get => zoom;

        set
        {
            if (zoom != value)
            {
                zoom = value;
                ResetZoomPan();
            }
        }
    }

    /// <summary>
    /// Gets a value indicating whether this <see cref="Plot2D"/> is zoomed.
    /// </summary>
    /// <value><c>true</c> if zoomed; otherwise, <c>false</c>.</value>
    public bool Zoomed => Math.Abs(zoom - 1) > 0.00001;

    /// <summary>
    /// Determines whether the zoomed map area can be panned by specified X- and/or Y-coordinate offset.
    /// </summary>
    /// <param name="xChange">The X-coordinate panning change.</param>
    /// <param name="yChange">The Y-coordinate panning change.</param>
    /// <returns><c>true</c> if the zoomed map area can be panned by the specified coordinate change; otherwise, <c>false</c>.</returns>
    public bool CanPanBy(double xChange, double yChange)
    {
        if (!Zoomed)
        {
            return false;
        }

        var canXPan = (zoomPanPointX + xChange > Diameter / 2) || zoomPanPointY + xChange < Diameter * zoom - Diameter;

        var canYPan = (zoomPanPointY + yChange > Diameter / 2) || zoomPanPointY + yChange < Diameter * zoom - Diameter;

        return canYPan || canXPan;
    }

    /// <summary>
    /// Gets or sets the date and time in UTC.
    /// </summary>
    /// <value>The date and time in UTC.</value>
    public DateTime DateTimeUtc
    {
        get => dateTimeUtc;

        set
        {
            if (value != dateTimeUtc)
            {
                dateTimeUtc = value;
                aaDate = new AASDate(dateTimeUtc.Year, dateTimeUtc.Month, dateTimeUtc.Day, dateTimeUtc.Hour,
                    dateTimeUtc.Minute, dateTimeUtc.Second, true);
            }
        } 
    }

    /// <summary>
    /// Projects the specified horizontal coordinate to 2D coordinate.
    /// </summary>
    /// <param name="coordinate">The coordinate to project.</param>
    /// <param name="invertEastWest">A value indicating whether to invert to projection in east-west direction.</param>
    /// <returns>The 2D coordinate.</returns>
    // This formula derived from (C): https://astronomy.stackexchange.com/questions/35882/how-to-make-projection-from-altitude-and-azimuth-to-screen-with-screen-coordinat
    public AAS2DCoordinate Project2D(AAS2DCoordinate coordinate, bool invertEastWest)
    {
        return Projection.Project2D(coordinate, invertEastWest, Diameter, ZoomPanPointX, zoomPanPointY, Zoom);
    }

    /// <summary>
    /// Inverts the specified projection into horizontal coordinates.
    /// </summary>
    /// <param name="coordinate">The coordinate which stereographic projection to invert.</param>
    /// <param name="invertEastWest">A value indicating whether to invert to projection in east-west direction.</param>
    /// <returns>AASharp.AAS2DCoordinate.</returns>
    public AAS2DCoordinate Invert2DProjection(AAS2DCoordinate coordinate, bool invertEastWest)
    {
        var result = Projection.Invert2DProjection(coordinate, invertEastWest, diameter, ZoomPanPointX, ZoomPanPointY, Zoom);
        if (result.X is > 180 and < 270)
        {
            result.X -= 180;
        }
        else if (result.X is > 270 and < 360)
        {
            result.X -= 180;
        }
        else if (result.X is > 0 and < 90)
        {
            result.X += 180;
        }
        else if (result.X is > 90 and < 180)
        {
            result.X += 180;
        }

        return result;
    }

    /// <summary>
    /// Gets the date as known by the AASharp library.
    /// </summary>
    /// <value>The date as known by the AASharp library.</value>
    public AASDate AaDate => aaDate;
}