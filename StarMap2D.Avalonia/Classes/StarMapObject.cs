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

using StarMap2D.Avalonia.Interfaces;
using VPKSoft.StarCatalogs.Interfaces;

namespace StarMap2D.Avalonia.Classes;

/// <summary>
/// A class to indicate a single object in the <see cref="Map2D"/> star map.
/// Implements the <see cref="IStarMapObject2D{T}" />
/// </summary>
/// <seealso cref="IStarMapObject2D{T}" />
public class StarMapObject: IStarMapObject2D<IMap2DGraphics>
{
    /// <inheritdoc cref="IStarMapObject2D{T}.IsLocationCalculated"/>
    public bool IsLocationCalculated { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.CalculatePosition"/>
    public IStarMapObject2D<IMap2DGraphics>.CalculatePositionDelegate? CalculatePosition { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.RightAscension"/>
    public double RightAscension { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.Declination"/>
    public double Declination { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.ObjectGraphics"/>
    public IMap2DGraphics? ObjectGraphics { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.Magnitude"/>
    public double Magnitude { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.SkipObject"/>
    public bool SkipObject { get; set; }

    /// <inheritdoc cref="IStarMapObject2D{T}.Identifier"/>
    public ulong Identifier { get; set; }
}