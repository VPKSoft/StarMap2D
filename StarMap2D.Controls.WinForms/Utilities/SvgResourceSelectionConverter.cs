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

using System.ComponentModel;
using System.Reflection;

namespace StarMap2D.Controls.WinForms.Utilities;

/// <summary>
/// A class to populate the SVG images to the WinForms designer.
/// Implements the <see cref="System.ComponentModel.StringConverter" />
/// </summary>
/// <seealso cref="System.ComponentModel.StringConverter" />
public class SvgResourceSelectionConverter: StringConverter
{
    /// <summary>
    /// Returns whether this object supports a standard set of values that can be picked from a list, using the specified context.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
    /// <returns><see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, <see langword="false" />.</returns>
    public override bool GetStandardValuesSupported(ITypeDescriptorContext? context)
    {
        return true;
    }

    /// <summary>
    /// Returns whether the collection of standard values returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exclusive list of possible values, using the specified context.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
    /// <returns><see langword="true" /> if the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exhaustive list of possible values; <see langword="false" /> if other values are possible.</returns>
    public override bool GetStandardValuesExclusive(ITypeDescriptorContext? context)
    {
        return true;
    }

    /// <summary>
    /// Gets a collection of standard values for the data type this type converter is designed for.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns>System.ComponentModel.TypeConverter.StandardValuesCollection.</returns>
    public override StandardValuesCollection 
        GetStandardValues(ITypeDescriptorContext? context)
    {
        var properties = typeof(Properties.Resources).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
        return new (properties.Where(f => f.PropertyType == typeof(byte[])).Select(f => f.Name).ToList());
    }
}