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

using StarMap2D.EtoForms.Controls.Enumerations;

namespace StarMap2D.EtoForms.Utility;

/// <summary>
/// A class to localize the different twilights.
/// </summary>
public class TwilightLocalization
{
    /// <summary>
    /// Twilights the name.
    /// </summary>
    /// <param name="twilightType">Type of the twilight.</param>
    /// <returns>The localized name of the specified twilight type.</returns>
    public static string TwilightName(TwilightType twilightType)
    {
        return twilightType switch
        {
            TwilightType.Night => Localization.UI.Night,
            TwilightType.Astronomical => Localization.UI.AstronomicalTwilight,
            TwilightType.Nautical => Localization.UI.NauticalTwilight,
            TwilightType.Civil => Localization.UI.CivilTwilight,
            TwilightType.Day => Localization.UI.Day,
            _ => Localization.UI.Day,
        };
    }
}