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

using Eto.Drawing;
using Newtonsoft.Json;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Controls.Utilities;
using VPKSoft.ApplicationSettingsJson;

namespace StarMap2D.EtoForms.ApplicationSettings;

/// <summary>
/// Settings for the StarMap2D software.
/// Implements the <see cref="VPKSoft.ApplicationSettingsJson.ApplicationJsonSettings" />
/// </summary>
/// <seealso cref="VPKSoft.ApplicationSettingsJson.ApplicationJsonSettings" />
public class Settings : ApplicationJsonSettings
{
    /// <summary>
    /// Gets or sets the latitude.
    /// </summary>
    /// <value>The latitude.</value>
    [Settings(Default = 60.17556337)]
    public double Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude.
    /// </summary>
    /// <value>The longitude.</value>
    [Settings(Default = 22.8782576)]
    public double Longitude { get; set; }

    /// <summary>
    /// Gets or sets the number formatting locale.
    /// </summary>
    /// <value>The number formatting locale.</value>
    [Settings(Default = "")]
    public string? FormattingLocale { get; set; }

    /// <summary>
    /// Gets or sets the default name of the location specified by the <see cref="Latitude"/> and <see cref="Longitude"/> values.
    /// </summary>
    /// <value>The default name of the location.</value>
    [Settings(Default = "N/A")]
    public string? DefaultLocationName { get; set; }

    /// <summary>
    /// Gets or sets the color of the constellation lines.
    /// </summary>
    /// <value>The color of the constellation lines.</value>
    [Settings(Default = "#00BFFF")]
    public string? ConstellationLineColor { get; set; }

    /// <summary>
    /// Gets or sets the color of the constellation border lines.
    /// </summary>
    /// <value>The color of the constellation border lines.</value>
    [Settings(Default = "#0D177F")]
    public string? ConstellationBorderLineColor { get; set; }

    /// <summary>
    /// Gets or sets the color of the map circle.
    /// </summary>
    /// <value>The color of the map circle.</value>
    [Settings(Default = "#000000")]
    public string? MapCircleColor { get; set; }

    /// <summary>
    /// Gets or sets the color of the map surroundings. I.e. the outer border from the circular area.
    /// </summary>
    /// <value>The color of the map surroundings.</value>
    [Settings(Default = "#272727")]
    public string? MapSurroundingsColor { get; set; }

    /// <summary>
    /// Gets or sets the star magnitude colors in a semicolon-separated HTML list from -10 to 10 magnitudes.
    /// </summary>
    /// <value>The star magnitude colors.</value>
    [Settings(Default = "#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff")]
    public string? StarMagnitudeColors { get; set; }

    /// <summary>
    /// Gets or sets the sizes for stars in points for magnitudes in a semicolon-separated list from -10 to 10.
    /// </summary>
    /// <value>The star magnitude sizes.</value>
    [Settings(Default = "10;10;10;10;10;10;9;8;7;6;5;4;3;3;3;3;3;3;3;3;2")]
    public string? StarMagnitudeSizes { get; set; }

    /// <summary>
    /// Gets or sets the maximum magnitude for stars. Less is more.
    /// </summary>
    /// <value>The magnitude maximum.</value>
    [Settings(Default = -500.0)]
    public double MagnitudeMaximum { get; set; }

    /// <summary>
    /// Gets or sets the minimum magnitude for stars. More is less.
    /// </summary>
    /// <value>The magnitude minimum.</value>
    [Settings(Default = 5.5)]
    public double MagnitudeMinimum { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to invert the star map along east-west axis.
    /// </summary>
    /// <value><c>true</c> if to invert the star map along east-west axis; otherwise, <c>false</c>.</value>
    [Settings(Default = false)]
    public bool InvertEastWest { get; set; }

    /// <summary>
    /// Gets or sets the color of the map text. I.e. constellation names, etc.
    /// </summary>
    /// <value>The color of the map text.</value>
    [Settings(Default = "#E717B4")]
    public string? MapTextColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to draw the constellation lines on the star map.
    /// </summary>
    /// <value><c>true</c> if to draw the constellation lines; otherwise, <c>false</c>.</value>
    [Settings(Default = true)]
    public bool DrawConstellationLines { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to draw the constellation labels on the star map.
    /// </summary>
    /// <value><c>true</c> if draw the constellation labels; otherwise, <c>false</c>.</value>
    [Settings(Default = true)]
    public bool DrawConstellationLabels { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to draw the constellation borders lines to the star map.
    /// </summary>
    /// <value><c>true</c> if draw the constellation borders; otherwise, <c>false</c>.</value>
    [Settings(Default = false)]
    public bool DrawConstellationBorders { get; set; }

    /// <summary>
    /// Gets or sets the locale for the UI localization.
    /// </summary>
    /// <value>The locale.</value>
    [Settings(Default = "en")]
    public string? Locale { get; set; }

    /// <summary>
    /// Gets or sets the solar system known object configuration serialized using the <see cref="SolarSystemObjectGraphics"/> class.
    /// </summary>
    /// <value>The solar system known objects configuration.</value>
    [Settings(Default = "")]
    public string? KnownObjects { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to draw cross hair on to the star map.
    /// </summary>
    /// <value><c>true</c> if to draw cross hair; otherwise, <c>false</c>.</value>
    [Settings(Default = true)]
    public bool DrawCrossHair { get; set; }

    /// <summary>
    /// Gets or sets the color of the cross hair.
    /// </summary>
    /// <value>The color of the cross hair.</value>
    [Settings(Default = "#00FF00")]
    public string? CrossHairColor { get; set; }

    /// <summary>
    /// Gets or sets the object details grid column settings. Size, width and visibility serialized in a string format.
    /// </summary>
    /// <value>The object details grid columns.</value>
    [Settings(Default = "")]
    public string? ColumnsGridObjectDetails { get; set; }

    /// <summary>
    /// Gets or sets the star catalog name to use with the software.
    /// </summary>
    /// <value>The star catalog to use with the software.</value>
    [Settings(Default = "")]
    public string? StarCatalog { get; set; }

    /// <summary>
    /// Gets or sets the date and time formatting culture.
    /// </summary>
    /// <value>The date and time formatting culture.</value>
    [Settings(Default = "")]
    public string? DateFormattingCulture { get; set; }

    /// <summary>
    /// Gets or sets the size of the cross hair on the star map.
    /// </summary>
    /// <value>The size of the cross hair.</value>
    [Settings(Default = 20)]
    public int CrossHairSize { get; set; }

    /// <summary>
    /// Gets or sets the font for normal text formatting.
    /// </summary>
    /// <value>The font for normal text.</value>
    [Settings]
    public SettingsFontData? Font { get; set; }

    /// <summary>
    /// Gets or sets the font for data formatting preferably a monospaced font.
    /// </summary>
    /// <value>The font for data text.</value>
    [Settings]
    public SettingsFontData? DataFont { get; set; }

    /// <summary>
    /// Gets or sets the main chart draw mode.
    /// <para>0. Always adjust.</para>
    /// <para>1. Adapt.</para>
    /// <para>2. Static minimum and maximum axes.</para>
    /// </summary>
    /// <value>The main chart draw mode.</value>
    [Settings(Default = 2)]
    public int? MainChartDrawMode { get; set; }

    /// <summary>
    /// Gets or sets the default color of the UI icons.
    /// </summary>
    /// <value>The default color of the UI icons.</value>
    [Settings(Default = "#4682B4", DefaultValueConverter = typeof(StringToColorDefault))]
    [JsonConverter(typeof(ColorStringConverter))]
    public Color? UiIconsDefaultColor { get; set; }

    /// <summary>
    /// Gets or sets the default color of the date text.
    /// </summary>
    /// <value>The default color of the date text.</value>
    [Settings(Default = "#4682B4", DefaultValueConverter = typeof(StringToColorDefault))]
    [JsonConverter(typeof(ColorStringConverter))]
    public Color? DateTextDefaultColor { get; set; }

}