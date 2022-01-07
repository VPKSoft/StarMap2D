using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class for a single point in a constellation area.
    /// Implements the <see cref="IConstellationStar" />
    /// </summary>
    /// <seealso cref="IConstellationStar" />
    public class ConstellationArea: IConstellationStar
    {
        /// <inheritdoc cref="IConstellationStar.Identifier"/>
        public string? Identifier { get; init; }

        /// <inheritdoc cref="IConstellationStar.Identifier"/>
        public double RightAscension { get; init; }

        /// <inheritdoc cref="IConstellationStar.Identifier"/>
        public double Declination { get; init; }

        /// <inheritdoc cref="IConstellationStar.Identifier"/>
        public double Rad { get; init; }

        /// <inheritdoc cref="IConstellationStar.Identifier"/>
        public double Ram { get; init; }

        /// <inheritdoc cref="IConstellationStar.Identifier"/>
        public double Ras { get; init; }
    }
}
