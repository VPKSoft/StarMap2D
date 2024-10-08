﻿#region License
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

namespace StarMap2D.Common.Utilities;

/// <summary>
/// A class for metadata for user trackable object.
/// </summary>
public class MapObjectMetadata
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the X-coordinate of the object.
    /// </summary>
    /// <value>The X-coordinate of the object.</value>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y-coordinate of the object.
    /// </summary>
    /// <value>The Y-coordinate of the object.</value>
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the radius of the object.
    /// </summary>
    /// <value>The radius of the object.</value>
    public double Radius { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the object.
    /// </summary>
    /// <value>The object identifier.</value>
    public object? Identifier { get; set; }

    /// <summary>
    /// Gets the <see cref="Identifier" /> cast to specified type.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Identifier" />.</typeparam>
    /// <returns>A System.Nullable&lt;T&gt; value with the <see cref="Identifier"/> data.</returns>
    public T? GetIdentifier<T>()
    {
        return (T?)Identifier;
    }
}