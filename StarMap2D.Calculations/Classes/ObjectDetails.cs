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

namespace StarMap2D.Calculations.Classes;

/// <summary>
/// Details of a sky object of any kind.
/// </summary>
public class ObjectDetails : IObjectDetails
{
    /// <inheritdoc cref="IObjectDetails.ObjectName"/>
    public string? ObjectName { get; set; }

    /// <inheritdoc cref="IObjectDetails.RightAscension"/>
    public double RightAscension { get; set; }

    /// <inheritdoc cref="IObjectDetails.Declination"/>
    public double Declination { get; set; }

    /// <inheritdoc cref="IObjectDetails.AboveHorizon"/>
    public bool AboveHorizon { get; set; }

    /// <inheritdoc cref="IObjectDetails.HorizontalDegreesX"/>
    public double HorizontalDegreesX { get; set; }

    /// <inheritdoc cref="IObjectDetails.HorizontalDegreesY"/>
    public double HorizontalDegreesY { get; set; }

    /// <inheritdoc cref="IObjectDetails.DetailDateTime"/>
    public DateTime DetailDateTime { get; set; }

    /// <summary>
    /// Gets or sets the distance from earth.
    /// </summary>
    /// <value>The distance from earth.</value>
    public double DistanceFromEarth { get; set; }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return
            @$"{{ RightAscension = {RightAscension.ToString(Globals.FormattingCulture)}, 
Declination = {Declination.ToString(Globals.FormattingCulture)}, 
AboveHorizon = {(AboveHorizon ? "true" : "false")}, 
HorizontalDegreesX = {HorizontalDegreesX.ToString(Globals.FormattingCulture)}, 
HorizontalDegreesY = {HorizontalDegreesY.ToString(Globals.FormattingCulture)}, 
DetailDateTime = {DetailDateTime.ToString(Globals.FormattingCulture)},}},";
    }

    /// <summary>
    /// Deconstructs the class data.
    /// </summary>
    /// <param name="objectName">The <see cref="ObjectName"/> value.</param>
    /// <param name="rightAscension">The <see cref="RightAscension"/> value.</param>
    /// <param name="declination">The <see cref="Declination"/> value.</param>
    /// <param name="aboveHorizon">The <see cref="AboveHorizon"/> value.</param>
    /// <param name="horizontalDegreesX">The <see cref="HorizontalDegreesX"/> value..</param>
    /// <param name="horizontalDegreesY">The <see cref="HorizontalDegreesY"/> value..</param>
    public void Deconstruct(out string? objectName, out double rightAscension, out double declination, out bool aboveHorizon, out double horizontalDegreesX, out double horizontalDegreesY)
    {
        objectName = ObjectName;
        rightAscension = RightAscension;
        declination = Declination;
        aboveHorizon = AboveHorizon;
        horizontalDegreesX = HorizontalDegreesX;
        horizontalDegreesY = HorizontalDegreesY;
    }
}