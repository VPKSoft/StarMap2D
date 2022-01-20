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

using System.Text.RegularExpressions;

namespace VPKSoft.StarCatalogs.HelperClasses
{
    /// <summary>
    /// A helper class for star names.
    /// </summary>
    public static class PrettifyStar
    {
        /// <summary>
        /// Prettifies the name of the star. I.e. '12Alp2CVn' --> '12 Alp 2 CVn'.
        /// </summary>
        /// <param name="value">The name of the star to prettify.</param>
        /// <returns>The name of the star after prettifying.</returns>
        public static string PrettifyStarName(this string value)
        {
            try
            {
                var regex = new Regex(@"\d{1,3}[a-zA-Z]{1}");

                var matches = regex.Matches(value);
                while (matches.Count > 0)
                {
                    var match = matches[0];
                    value = value.Remove(match.Index, match.Length - 1);
                    value = value.Insert(match.Index, match.Value.Substring(0, match.Length - 1) + " ");
                    matches = regex.Matches(value);
                }

                regex = new Regex(@"[a-zA-Z]\d{1,2}");

                matches = regex.Matches(value);
                while (matches.Count > 0)
                {
                    var match = matches[0];
                    value = value.Remove(match.Index + 1, match.Length - 1);
                    value = value.Insert(match.Index + 1, " " + match.Value.Substring(1, match.Length - 1));
                    matches = regex.Matches(value);
                }

                value = Regex.Replace(value, @"\s+", " ");

                return value;
            }
            catch
            {
                return value;
            }
        }
    }
}
