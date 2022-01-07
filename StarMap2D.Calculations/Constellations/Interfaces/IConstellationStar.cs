namespace StarMap2D.Calculations.Constellations.Interfaces
{
    /// <summary>
    /// An interface for a single star in a constellation.
    /// </summary>
    public interface IConstellationStar
    {
        /// <summary>
        /// Gets or sets the constellation identifier.
        /// </summary>
        /// <value>The constellation identifier.</value>
        public string? Identifier { get; init; }

        /// <summary>
        /// Gets or sets the right ascension.
        /// </summary>
        /// <value>The right ascension.</value>
        public double RightAscension { get; init; }

        /// <summary>
        /// Gets or sets the declination.
        /// </summary>
        /// <value>The declination.</value>
        public double Declination { get; init; }

        /// <summary>
        /// Gets or sets the right ascension degrees.
        /// </summary>
        /// <value>The right ascension degrees.</value>
        public double Rad { get; init; }

        /// <summary>
        /// Gets or sets the right ascension minutes.
        /// </summary>
        /// <value>The right ascension minutes.</value>
        public double Ram { get; init; }

        /// <summary>
        /// Gets or sets the right ascension seconds.
        /// </summary>
        /// <value>The right ascension seconds.</value>
        public double Ras { get; init; }
    }
}
