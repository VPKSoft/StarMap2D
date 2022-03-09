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

namespace StarMap2D.Calculations.Compass;

/// <summary>
/// A class to indicate compass direction using specified amount of degrees as a base value.
/// </summary>
public class CompassDirection
{
    /// <summary>
    /// Creates a new instance of the <see cref="CompassDirection"/> class using the specified degrees.
    /// </summary>
    /// <param name="degrees">The degrees.</param>
    /// <returns>A new instance of the <seealso cref="CompassDirection"/> class.</returns>
    public static CompassDirection FromDegrees(double degrees)
    {
        return new CompassDirection
        {
            Degrees = degrees,
        };
    }

    /// <summary>
    /// Gets or sets the direction point value of the compass.
    /// </summary>
    /// <value>The point value.</value>
    public CompassPoint Point { get; private set; }

    private double degrees;

    /// <summary>
    /// Gets or sets the compass degrees.
    /// </summary>
    /// <value>The degrees.</value>
    public double Degrees
    {
        get => degrees;

        set
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (degrees != value)
            {
                degrees = value;

                var points = Enum.GetValues(typeof(CompassPoint)).Cast<int>().ToList();

                points.Add(3600);

                var nearestPoint = points.OrderBy(f => Math.Abs(f - degrees * 10)).First();

                var point = nearestPoint != 3600 ? (CompassPoint)nearestPoint : CompassPoint.North;

                // A bit complex logic for the north where 360 == 0.
                var degreeOffset = degrees - (point == CompassPoint.North && degrees > 315 ? 3600.0 : (double)point) / 10.0;

                PointOffset = degreeOffset;
                Point = point;
            }
        }
    }

    /// <summary>
    /// Gets or sets the degrees to add to the <see cref="Point"/> to get the exact amount of degrees.
    /// </summary>
    /// <value>The point offset.</value>
    public double PointOffset { get; private set; }

    /// <summary>
    /// A function to localize the <see cref="Point"/> value.
    /// </summary>
    public static Func<CompassPoint, string> GetNameFunc { get; set; } = point => point.ToString();

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return
            @$"{{ {nameof(Point)} = {Point}, {nameof(Degrees)} = {Degrees.ToString(Globals.FormattingCulture)}, {nameof(PointOffset)} = {PointOffset.ToString(Globals.FormattingCulture)}, }}";
    }

    /// <summary>
    /// Gets the compass direction value string.
    /// </summary>
    /// <value>The compass direction value string.</value>
    public string ValueString =>
        $"{GetNameFunc(Point)} {(PointOffset < 0 ? "-" : "+")} {Math.Abs(PointOffset).ToString("F1", Globals.FormattingCulture)}°, {Degrees.ToString("F1", Globals.FormattingCulture)}";
}