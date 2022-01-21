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
/// An interface for a single star in a constellation.
/// </summary>
public interface IConstellationStar
{
    /// <summary>
    /// Gets or sets the constellation identifier.
    /// </summary>
    /// <value>The constellation identifier.</value>
    string Identifier { get; set; }

    /// <summary>
    /// Gets or sets the proper of the star.
    /// </summary>
    /// <value>The proper of the star.</value>
    string ProperName { get; set; }

    /// <summary>
    /// Gets or sets the name of the star.
    /// </summary>
    /// <value>The name of the star.</value>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the right ascension.
    /// </summary>
    /// <value>The right ascension.</value>
    double RightAscension { get; init; }

    /// <summary>
    /// Gets or sets the declination.
    /// </summary>
    /// <value>The declination.</value>
    double Declination { get; init; }

    /// <summary>
    /// Gets or sets the right ascension hours.
    /// </summary>
    /// <value>The right ascension hours.</value>
    double Rah { get; init; }

    /// <summary>
    /// Gets or sets the right ascension minutes.
    /// </summary>
    /// <value>The right ascension minutes.</value>
    double Ram { get; init; }

    /// <summary>
    /// Gets or sets the right ascension seconds.
    /// </summary>
    /// <value>The right ascension seconds.</value>
    double Ras { get; init; }
}