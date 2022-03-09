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

namespace StarMap2D.EtoForms.Classes;

/// <summary>
/// A class to hold a <see cref="Enum"/> value and its describing name.
/// </summary>
/// <typeparam name="T">The type of the enum.</typeparam>
public class EnumStringItem<T> where T : Enum
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EnumStringItem{T}"/> class.
    /// </summary>
    /// <param name="enumValue">The enum value.</param>
    /// <param name="enumName">Name of the enum.</param>
    public EnumStringItem(T enumValue, string enumName)
    {
        EnumName = enumName;
        EnumValue = enumValue;
    }

    /// <summary>
    /// Gets or sets the enum value.
    /// </summary>
    /// <value>The enum value.</value>
    public T EnumValue { get; init; }

    /// <summary>
    /// Gets or sets the name of the enum.
    /// </summary>
    /// <value>The name of the enum.</value>
    public string EnumName { get; init; }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return EnumName;
    }
}