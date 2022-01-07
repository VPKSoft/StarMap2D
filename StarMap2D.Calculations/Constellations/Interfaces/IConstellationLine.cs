namespace StarMap2D.Calculations.Constellations.Interfaces
{
    /// <summary>
    /// An interface for constellation line data.
    /// </summary>
    public interface IConstellationLine
    {
        /// <summary>
        /// Gets or sets the right ascension start coordinate of the line.
        /// </summary>
        /// <value>The right ascension start coordinate of the line.</value>
        public double RightAscensionStart { get; init; }

        /// <summary>
        /// Gets or sets the right ascension end coordinate of the line.
        /// </summary>
        /// <value>The right ascension end coordinate of the line.</value>
        public double RightAscensionEnd { get; init; }

        /// <summary>
        /// Gets or sets the declination start coordinate of the line.
        /// </summary>
        /// <value>The declination start coordinate of the line.</value>
        public double DeclinationStart { get; set; }

        /// <summary>
        /// Gets or sets the declination end coordinate of the line.
        /// </summary>
        /// <value>The declination end coordinate of the line.</value>
        public double DeclinationEnd { get; set; }
    }
}
