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
/// A constant data class for the moon calculations.
/// </summary>
public class MoonPhaseConstants
{
    /// <summary>
    /// The moon phase values and their illuminated fraction minimum and maximum values.
    /// </summary>
    public static readonly MoonPhaseValue[] MoonPhaseValues = {
        new(MoonPhases.NewMoon, 0.000, 0.125),
        new(MoonPhases.WaxingCrescent, 0.125, 0.250),
        new(MoonPhases.FirstQuarter, 0.250, 0.375),
        new(MoonPhases.WaxingGibbous, 0.375, 0.500),
        new(MoonPhases.FullMoon, 0.500, 0.675),
        new(MoonPhases.WaningGibbous, 0.675, 0.750),
        new(MoonPhases.LastQuarter, 0.750, 0.875),
        new(MoonPhases.WaningCrescent, 0.875, 1.000),
    };

    /// <summary>
    /// Gets the moon phase.
    /// </summary>
    /// <param name="illuminatedFraction">The illuminated fraction.</param>
    /// <returns>A <see cref="MoonPhases"/> enumeration value for the moon phase..</returns>
    /// <exception cref="System.InvalidOperationException">Failed to get the moon phase.</exception>
    public static MoonPhases GetMoonPhase(double illuminatedFraction)
    {
        var value = MoonPhaseValues.FirstOrDefault(f =>
            illuminatedFraction >= f.MinimumValue && illuminatedFraction < f.MaximumValue) ?? throw new InvalidOperationException("Failed to get the moon phase.");

        return value.MoonPhase;
    }
}