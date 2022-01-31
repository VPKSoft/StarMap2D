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

namespace StarMap2D.Controls.WinForms.Utilities
{
    /// <summary>
    /// A class to provide localization for specific object(s).
    /// </summary>
    public class LocalizationProvider
    {
        /// <summary>
        /// Gets the solar system object localization.
        /// </summary>
        /// <value>The solar system object localization.</value>
        public static TabDeliLocalization SolarSystemObjectLocalization
        {
            get
            {
                var result = new TabDeliLocalization();
                result.GetLocalizedTexts(Properties.Resources.SolarSystemObjects);
                return result;
            }
        }

        /// <summary>
        /// Gets the constellation localization.
        /// </summary>
        /// <value>The constellation localization.</value>
        public static TabDeliLocalization ConstellationLocalization
        {
            get
            {
                var result = new TabDeliLocalization();
                result.GetLocalizedTexts(Properties.Resources.Constellations);
                return result;
            }
        }
    }
}
