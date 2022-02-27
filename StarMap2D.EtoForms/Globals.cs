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
using StarMap2D.EtoForms.ApplicationSettings;

namespace StarMap2D.EtoForms;

/// <summary>
/// A class containing the global static parameters.
/// </summary>
public class Globals
{
    /// <summary>
    /// Gets or sets the application settings.
    /// </summary>
    /// <value>The application settings.</value>
    public static Settings Settings { get; set; } = new();

    /// <summary>
    /// Gets or sets the locale for UI localization.
    /// </summary>
    /// <value>The UI localization locale.</value>
    public static CultureInfo Locale
    {
        get

        {
            try // Can not allow this to crash the program.
            {
                return new(string.IsNullOrWhiteSpace(Settings.Locale)
                    ? CultureInfo.CurrentUICulture.Name.Split('-')[0]
                    : Settings.Locale.Split('-')[0]);
            }
            catch
            {
                return CultureInfo.CurrentUICulture;
            }
        }
    }

    /// <summary>
    /// Gets or sets the string formatting culture.
    /// </summary>
    /// <value>The string formatting culture.</value>
    public static CultureInfo FormattingCulture { get; set; } = CultureInfo.InvariantCulture;

    /// <summary>
    /// Saves the application settings.
    /// </summary>
    public static void SaveSettings()
    {
        Settings.Save(Settings.GetApplicationSettingsFile("VPKSoft", nameof(StarMap2D)));
    }

    /// <summary>
    /// Gets or sets the default padding for the control layout.
    /// </summary>
    /// <value>The default padding.</value>
    public static int DefaultPadding { get; set; } = 5;

    /// <summary>
    /// Gets or sets a value indicating whether to use the full VSOP87 theory instead of the truncated version as provided in Meeus's book. 
    /// </summary>
    /// <seealso cref="AASharp"/>
    /// <value><c>true</c> if to use the full VSOP87 theory in calculations; otherwise, <c>false</c>.</value>
    public static bool HighPrecisionCalculations { get; set; }
}