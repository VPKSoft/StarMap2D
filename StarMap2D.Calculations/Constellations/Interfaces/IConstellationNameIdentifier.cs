using StarMap2D.Calculations.Constellations.StaticData;

namespace StarMap2D.Calculations.Constellations.Interfaces
{
    /// <summary>
    /// An interface to combine constellation names and their identifiers.
    /// </summary>
    public interface IConstellationNameIdentifier
    {
        /// <summary>
        /// Gets or sets the constellation identifier.
        /// </summary>
        /// <value>The constellation identifier.</value>
        string? Identifier { get; init; }

        /// <summary>
        /// Gets or sets the constellation name.
        /// </summary>
        /// <value>The constellation name.</value>
        string? Name { get; init; }

        /// <summary>
        /// Gets or sets the identifier of to constellation with character casing.
        /// </summary>
        /// <value>The identifier of to constellation with character casing.</value>
        string? IdentifierCased { get; init; }

        /// <summary>
        /// Gets or sets the <see cref="ConstellationValue"/> enumeration value for the constellation.
        /// </summary>
        /// <value>The <see cref="ConstellationValue"/> enumeration value for the constellation.</value>
        ConstellationValue IdentifierValue { get; init; }
    }
}
