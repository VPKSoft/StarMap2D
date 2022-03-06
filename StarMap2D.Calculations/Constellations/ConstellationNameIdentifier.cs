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
using StarMap2D.Calculations.Enumerations;

namespace StarMap2D.Calculations.Constellations;

/// <summary>
/// An class to combine constellation names and their identifiers.
/// </summary>
public class ConstellationNameIdentifier : IConstellationNameIdentifier
{
    /// <inheritdoc cref="IConstellationNameIdentifier.Identifier"/>
    public string? Identifier { get; init; }

    /// <inheritdoc cref="IConstellationNameIdentifier.Name"/>
    public string? Name { get; init; }

    /// <inheritdoc cref="IConstellationNameIdentifier.IdentifierCased"/>
    public string? IdentifierCased { get; init; }

    /// <inheritdoc cref="IConstellationNameIdentifier.IdentifierValue"/>
    public ConstellationValue IdentifierValue { get; init; }

    /// <summary>
    /// Gets or sets the IAU rank of the constellation.
    /// </summary>
    /// <value>The IAU rank of the constellation.</value>
    /// <remarks>See: https://en.wikipedia.org/wiki/IAU_designated_constellations_by_area</remarks>
    // ReSharper disable once InconsistentNaming, The IAU is written in upper case.
    public int IAURank { get; init; }

    /// <summary>
    /// Gets or sets the quadrant in the sky.
    /// </summary>
    /// <value>The quadrant in the sky.</value>
    public Quadrant Quadrant { get; set; }

    /// <summary>
    /// Gets or sets the right ascension.
    /// </summary>
    /// <value>The right ascension.</value>
    public double RightAscension { get; set; }

    /// <summary>
    /// Gets or sets the declination.
    /// </summary>
    /// <value>The declination.</value>
    public double Declination { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this serpens is the whole Serpens constellation with head and tail.
    /// </summary>
    public bool SerpensOfficial { get; set; }

    /// <summary>
    /// Gets the constellation name without white space character(s).
    /// </summary>
    /// <value>The name without white space character(s).</value>
    public string NameNoWhiteSpace => Name?.Replace(" ", "") ?? IdentifierValue.ToString();

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return
            $"{{ {nameof(Identifier)} = \"{Identifier}\", {nameof(Name)} = \"{Name}\", {nameof(IdentifierCased)} = \"{IdentifierCased}\", {nameof(IdentifierValue)} = {nameof(ConstellationValue)}.{IdentifierValue}, {nameof(IAURank)} = {IAURank}, {nameof(Quadrant)} = {nameof(Quadrant)}.{Quadrant}, {nameof(RightAscension)} = {RightAscension.ToString(Globals.FormattingCulture)}, {nameof(Declination)} = {Declination.ToString(Globals.FormattingCulture)}, {nameof(SerpensOfficial)} = {(SerpensOfficial ? "true" : "false")}, }},";
    }
}