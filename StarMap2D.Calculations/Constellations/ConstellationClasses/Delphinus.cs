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

using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;

namespace StarMap2D.Calculations.Constellations.ConstellationClasses;

/// <summary>
/// A class representing the Delphinus constellation.
/// Implements the <see cref="IConstellation{T,TLines}" />
/// </summary>
/// <seealso cref="IConstellation{T, TLines}" />
public class Delphinus: IConstellation<ConstellationArea, ConstellationLine>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Delphinus"/> class.
    /// </summary>
    public Delphinus()
    {
        Identifier = "DEL";
        Name = "Delphinus";
        Boundary = ConstellationBoundary.ConstellationBoundaries.Where(f => f.Identifier == Identifier).ToList();
        ConstellationLines = StaticData.ConstellationLines.Lines
            .Where(f => f.Identifier == Identifier).ToList();

    }

    /// <inheritdoc cref="IConstellation{T, TLines}.Identifier"/>
    public string Identifier { get; init; }

    /// <inheritdoc cref="IConstellation{T, TLines}.Name"/>
    public string Name { get; set; }

    /// <inheritdoc cref="IConstellation{T,TLines}.Boundary"/>
    public IReadOnlyList<IConstellationStar> Boundary { get; }

    /// <inheritdoc cref="IConstellation{T, TLines}.ConstellationLines"/>
    public IReadOnlyList<ConstellationLine> ConstellationLines { get; init; }
}