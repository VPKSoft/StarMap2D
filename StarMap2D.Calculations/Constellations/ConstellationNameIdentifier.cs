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
    }
}
