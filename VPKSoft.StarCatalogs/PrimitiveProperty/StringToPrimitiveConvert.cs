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
using System.Text.RegularExpressions;

namespace VPKSoft.StarCatalogs.PrimitiveProperty
{
    /// <summary>
    /// A class for conversions from string to primitive types.
    /// </summary>
    public class StringToPrimitiveConvert
    {
        /// <summary>
        /// A compiled <see cref="Regex"/> to check whether a string represents a number.
        /// </summary>
        /// <remarks>See: https://regexland.com/regex-decimal-numbers/</remarks>
        public static readonly Regex
            NumberRegex = new(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)", RegexOptions.Compiled);

        /// <summary>
        /// Converts a specified string value to primitive type of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The primitive type to convert to string value into.</typeparam>
        /// <param name="value">The value to convert to type of <typeparamref name="T"/>.</param>
        /// <returns>The value converted to type of <typeparamref name="T"/>.</returns>
        /// <exception cref="System.NullReferenceException">value</exception>
        public static T ToPrimitive<T>(string value)
        {
            var result = ToPrimitiveNullable<T>(value);
            if (result == null)
            {
                throw new NullReferenceException(nameof(value));
            }

            return result;
        }

        /// <summary>
        /// Converts a specified string value to primitive type of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The primitive type to convert to string value into.</typeparam>
        /// <param name="value">The value to convert to type of <typeparamref name="T"/>.</param>
        /// <returns>The value converted to type of <typeparamref name="T"/> if the operation was successful; <c>null</c> otherwise.</returns>
        public static T? ToPrimitiveNullable<T>(string? value)
        {
            if (value == null)
            {
                return default;
            }

            try
            {
                var type = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);

                if (type == typeof(byte) || 
                    type == typeof(sbyte) || 
                    type == typeof(short) || 
                    type == typeof(ushort) ||
                    type == typeof(int) || 
                    type == typeof(uint) || 
                    type == typeof(long) || 
                    type == typeof(ulong) ||
                    type == typeof(float) || 
                    type == typeof(double) || 
                    type == typeof(decimal) || 
                    type == typeof(nint) || 
                    type == typeof(nuint))
                {
                    value = value.Trim();

                    if (NumberRegex.IsMatch(value))
                    {
                        return (T)Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
                    }

                    return default;
                }

                return (T)Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
            }
            catch
            {
                return default;
            }
        }
    }
}
