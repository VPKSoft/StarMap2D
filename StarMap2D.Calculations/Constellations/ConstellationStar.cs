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

namespace StarMap2D.Calculations.Constellations;

/// <summary>
/// A class for a single star in a constellation.
/// Implements the <see cref="IConstellationStar" />
/// </summary>
/// <seealso cref="IConstellationStar" />
public class ConstellationStar: IConstellationStar
{
    /// <inheritdoc cref="IConstellationStar.Identifier"/>
    public string Identifier { get; set; } = string.Empty;

    /// <inheritdoc cref="IConstellationStar.ProperName"/>
    public string ProperName { get; set; } = string.Empty;

    /// <inheritdoc cref="IConstellationStar.Name"/>
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc cref="IConstellationStar.RightAscension"/>
    public double RightAscension { get; init; }

    /// <inheritdoc cref="IConstellationStar.Declination"/>
    public double Declination { get; init; }

    /// <inheritdoc cref="IConstellationStar.Rah"/>
    public double Rah { get; init; }

    /// <inheritdoc cref="IConstellationStar.Ram"/>
    public double Ram { get; init; }

    /// <inheritdoc cref="IConstellationStar.Ras"/>
    public double Ras { get; init; }

    /// <summary>
    /// Gets or sets the internal identifier for the star.
    /// </summary>
    /// <value>The internal identifier for the star.</value>
    public int InternalId { get; set; }
}