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

namespace StarMap2D.Common.EventsAndDelegates;

/// <summary>
/// Event arguments for map coordinates change on mouse move.
/// Implements the <see cref="System.EventArgs" />
/// </summary>
/// <seealso cref="System.EventArgs" />
public class CoordinatesChangedEventArgs : EventArgs
{
    /// <summary>
    /// Gets or sets the horizontal altitude coordinate in degrees.
    /// </summary>
    /// <value>The horizontal altitude in degrees.</value>
    public double Altitude { get; set; }

    /// <summary>
    /// Gets or sets the horizontal azimuth coordinate in degrees.
    /// </summary>
    /// <value>The horizontal azimuth in degrees.</value>
    public double Azimuth { get; set; }

    /// <summary>
    /// Gets or sets the right ascension in decimal hours.
    /// </summary>
    /// <value>The right ascension.</value>
    public double RightAscension { get; set; }

    /// <summary>
    /// Gets or sets the declination in degrees.
    /// </summary>
    /// <value>The declination.</value>
    public double Declination { get; set; }

    /// <summary>
    /// Gets or sets the mouse X-coordinate.
    /// </summary>
    /// <value>The mouse X-coordinate.</value>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the mouse Y-coordinate.
    /// </summary>
    /// <value>The mouse Y-coordinate.</value>
    public double Y { get; set; }
}