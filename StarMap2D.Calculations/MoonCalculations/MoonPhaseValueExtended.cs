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

namespace StarMap2D.Calculations.MoonCalculations;

/// <summary>
/// A class to for a single moon phase value data.
/// </summary>
public class MoonPhaseValueExtended : MoonPhaseValue
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MoonPhaseValue"/> class.
    /// </summary>
    /// <param name="moonPhase">The moon phase.</param>
    /// <param name="minimumValue">The minimum value of the moon phase.</param>
    /// <param name="maximumValue">The maximum value of the moon phase.</param>
    /// <param name="minimumIllumination">The minimum disc illumination fraction.</param>
    /// <param name="maximumIllumination">The maximum disc illumination fraction.</param>
    public MoonPhaseValueExtended(MoonPhases moonPhase, double minimumValue, double maximumValue,
        double minimumIllumination, double maximumIllumination) : base(moonPhase, minimumValue, maximumValue)
    {
        MinimumIllumination = minimumIllumination;
        MaximumIllumination = maximumIllumination;
    }

    /// <summary>
    /// Gets the minimum disc illumination fraction.
    /// </summary>
    /// <value>The minimum illumination fraction.</value>
    public double MinimumIllumination { get; internal set; }

    /// <summary>
    /// Gets the maximum disc illumination fraction.
    /// </summary>
    /// <value>The maximum illumination fraction.</value>
    public double MaximumIllumination { get; internal set; }
}