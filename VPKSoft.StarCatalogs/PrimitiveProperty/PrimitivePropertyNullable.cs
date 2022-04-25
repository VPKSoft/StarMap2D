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

namespace VPKSoft.StarCatalogs.PrimitiveProperty;

/// <summary>
/// A class representing a nullable primitive property.
/// </summary>
/// <remarks>The <typeparamref name="T"/> type is expected to be not nullable.</remarks>
/// <typeparam name="T">The type of the primitive property.</typeparam>
public class PrimitivePropertyNullable<T> where T:  struct
{
    private T? value;

    /// <summary>
    /// Performs an implicit conversion from <see cref="System.Nullable{T}"/> to <see cref="PrimitivePropertyNullable{T}"/>.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>An instance of the <see cref="PrimitivePropertyNullable{T}"/> class.</returns>
    public static implicit operator PrimitivePropertyNullable<T>(T? value)
    {
        var result = new PrimitivePropertyNullable<T>
        {
            value = value,
        };
        return result;
    }

    /// <summary>
    /// Performs an implicit conversion from <see cref="PrimitivePropertyNullable{T}"/> to <see cref="System.Nullable{T}"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>A value of type of <typeparamref name="T"/>.</returns>
    public static implicit operator T?(PrimitivePropertyNullable<T> value)
    {
        return value.value;
    }

    /// <summary>
    /// Performs an implicit conversion from <see cref="string"/>? to <see cref="PrimitivePropertyNullable{T}"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>An instance of the <see cref="PrimitivePropertyNullable{T}"/> class.</returns>
    public static implicit operator PrimitivePropertyNullable<T>(string? value)
    {
        var result = new PrimitivePropertyNullable<T>
        {
            value = StringToPrimitiveConvert.ToPrimitiveNullable<T>(value),
        };
        return result;
    }
}