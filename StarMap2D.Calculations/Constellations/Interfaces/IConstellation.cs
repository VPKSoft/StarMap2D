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

namespace StarMap2D.Calculations.Constellations.Interfaces;

/// <summary>
/// An interface for a constellation of stars.
/// </summary>
/// <typeparam name="T">The type of the class implementing the <see cref="IConstellationStar"/> interface.</typeparam>
/// <typeparam name="TLines">The type of the class implementing the <see cref="IConstellationLine"/> interface.</typeparam>
public interface IConstellation<T, TLines> where T: IConstellationStar where TLines: IConstellationLine
{
    /// <summary>
    /// Gets or sets the identifier of the constellation. I.e. "ORI".
    /// </summary>
    /// <value>The identifier.</value>
    string Identifier { get; init; }

    /// <summary>
    /// Gets or sets the name of the constellation.
    /// </summary>
    /// <value>The name of the constellation.</value>
    string Name { get; set; }

    /// <summary>
    /// Gets the constellation boundary.
    /// </summary>
    /// <value>The constellation boundary.</value>
    IReadOnlyList<IConstellationStar> Boundary { get; }

    /// <summary>
    /// Gets or sets the constellation lines.
    /// </summary>
    /// <value>The constellation lines.</value>
    public IReadOnlyList<TLines> ConstellationLines { get; init; }
}