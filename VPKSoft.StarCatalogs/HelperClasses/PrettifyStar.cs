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
