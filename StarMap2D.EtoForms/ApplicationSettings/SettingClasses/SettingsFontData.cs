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

using System;
using System.Globalization;
using Eto.Drawing;
using Newtonsoft.Json;
using VPKSoft.ApplicationSettingsJson;

namespace StarMap2D.EtoForms.ApplicationSettings.SettingClasses
{
    /// <summary>
    /// A class to store font data into the settings.
    /// </summary>
    public struct SettingsFontData
    {
        /// <summary>
        /// Gets or sets the font family.
        /// </summary>
        /// <value>The font family.</value>
        public string FontFamily { get; set; } = "Sans";

        /// <summary>
        /// Gets or sets the size of the font.
        /// </summary>
        /// <value>The size of the font.</value>
        public float FontSize { get; set; } = 9;

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        /// <value>The font style.</value>
        public FontStyle FontStyle { get; set; }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Font"/> to <see cref="SettingsFontData"/>.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <returns>A new instance of the <see cref="SettingsFontData"/> class.</returns>
        public static implicit operator SettingsFontData(Font font)
        {
            return new SettingsFontData
            {
                FontFamily = font.FamilyName,
                FontSize = font.Size,
                FontStyle = font.FontStyle,
            };
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="SettingsFontData"/> to <see cref="Font"/>.
        /// </summary>
        /// <param name="fontData">The font data.</param>
        /// <returns>A new instance of the <see cref="Font"/> class.</returns>
        public static implicit operator Font(SettingsFontData fontData)
        {
            return new Font(fontData.FontFamily, fontData.FontSize, fontData.FontStyle);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="SettingsFontData"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A new instance of the <see cref="SettingsFontData"/> class.</returns>
        public static implicit operator SettingsFontData(string value)
        {
            var dataStrings = value.Split(';');

            return new SettingsFontData
            {
                FontFamily = dataStrings[0],
                FontSize = float.Parse(dataStrings[0], CultureInfo.InvariantCulture),
                FontStyle = Enum.Parse<FontStyle>(dataStrings[2]),
            };
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"{FontFamily};{FontSize.ToString(CultureInfo.InvariantCulture)};{FontStyle}";
        }

        /// <summary>
        /// Gets or sets the empty <see cref="SettingsFontData"/> value.
        /// </summary>
        /// <value>The empty value.</value>
        public static SettingsFontData Empty = new();
    }
}