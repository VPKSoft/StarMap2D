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

using StarMap2D.Calculations.MoonCalculations;

namespace StarMap2D.EtoForms.Utility;

/// <summary>
/// A class to localize moon phases.
/// </summary>
public class MoonPhaseLocalization
{
    /// <summary>
    /// Gets the the name of the moon phase.
    /// </summary>
    /// <param name="moonPhase">The moon phase value.</param>
    /// <returns>A localized moon phase value string.</returns>
    public static string MoonPhaseName(MoonPhases moonPhase)
    {
        return moonPhase switch
        {
            MoonPhases.NewMoon => Localization.MoonData.MoonNewMoon,
            MoonPhases.WaxingCrescent => Localization.MoonData.MoonWaxingCrescent,
            MoonPhases.FirstQuarter => Localization.MoonData.MoonFirstQuarter,
            MoonPhases.WaxingGibbous => Localization.MoonData.MoonWaxingGibbous,
            MoonPhases.FullMoon => Localization.MoonData.MoonFullMoon,
            MoonPhases.WaningGibbous => Localization.MoonData.MoonWaningGibbous,
            MoonPhases.LastQuarter => Localization.MoonData.MoonLastQuarter,
            MoonPhases.WaningCrescent => Localization.MoonData.MoonWaningCrescent,
            _ => Localization.MoonData.MoonNewMoon,
        };
    }
}