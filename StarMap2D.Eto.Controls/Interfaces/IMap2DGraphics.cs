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

namespace StarMap2D.Eto.Controls.Interfaces;

/// <summary>
/// Interface for the objects in the <see cref="Map2D"/> star map control.
/// </summary>
public interface IMap2DGraphics
{
    /// <summary>
    /// A delegate to provide an image for a specified diameter of the 2D star map.
    /// </summary>
    /// <param name="diameter">The diameter of the 2D star map.</param>
    /// <param name="magnitude">An optional magnitude of the 2D star map object.</param>
    /// <returns>An image suitable to be used in a 2D star map of diameter of the <paramref name="diameter"/>.</returns>
    public delegate Image GetImageDelegate(double diameter, double? magnitude);

    /// <summary>
    /// A delegate to get an image for the 2D graphics object.
    /// </summary>
    GetImageDelegate? GetImage { get; set; }
}