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

using System.Globalization;

namespace StarMap2D.Calculations.Classes;

/// <summary>
/// Details of a sky object of any kind.
/// </summary>
public class ObjectDetails
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    public string? ObjectName { get; set; }

    /// <summary>
    /// Gets or sets the right ascension of the object.
    /// </summary>
    /// <value>The right ascension.</value>
    public double RightAscension { get; set; }

    /// <summary>
    /// Gets or sets the declination of the object.
    /// </summary>
    /// <value>The declination.</value>
    public double Declination { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the object is above horizon at the <see cref="DetailDateTime"/> date and time.
    /// </summary>
    /// <value><c>true</c> if the object is above horizon at the <see cref="DetailDateTime"/>; otherwise, <c>false</c>.</value>
    public bool AboveHorizon { get; set; }

    /// <summary>
    /// Gets or sets the horizontal X-coordinate in degrees.
    /// </summary>
    /// <value>The horizontal X-coordinate in degrees.</value>
    public double HorizontalDegreesX { get; set; }

    /// <summary>
    /// Gets or sets the horizontal Y-coordinate in degrees.
    /// </summary>
    /// <value>The horizontal Y-coordinate in degrees.</value>
    public double HorizontalDegreesY { get; set; }

    /// <summary>
    /// Gets or sets the date and time of the calculation of these object details.
    /// </summary>
    /// <value>The calculation date time of the details.</value>
    public DateTime DetailDateTime { get; set; }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return
            @$"{{ RightAscension = {RightAscension.ToString(CultureInfo.InvariantCulture)}, 
Declination = {Declination.ToString(CultureInfo.InvariantCulture)}, 
AboveHorizon = {(AboveHorizon ? "true" : "false")}, 
HorizontalDegreesX = {HorizontalDegreesX.ToString(CultureInfo.InvariantCulture)}, 
HorizontalDegreesY = {HorizontalDegreesY.ToString(CultureInfo.InvariantCulture)}, 
DetailDateTime = {DetailDateTime.ToString(CultureInfo.InvariantCulture)},}},";
    }
}