using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// An class to combine constellation names and their identifiers.
    /// </summary>
    public class ConstellationNameIdentifier: IConstellationNameIdentifier
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
    }
}
