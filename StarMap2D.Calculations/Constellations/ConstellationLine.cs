using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class to hold constellation line data in right ascension/declination coordinates.
    /// </summary>
    public class ConstellationLine: IConstellationLine
    {
        /// <inheritdoc cref="IConstellationLine.RightAscensionStart"/>
        public double RightAscensionStart { get; init; }

        /// <inheritdoc cref="IConstellationLine.RightAscensionEnd"/>
        public double RightAscensionEnd { get; init; }

        /// <inheritdoc cref="IConstellationLine.DeclinationStart"/>
        public double DeclinationStart { get; set; }

        /// <inheritdoc cref="IConstellationLine.DeclinationEnd"/>
        public double DeclinationEnd { get; set; }
    }
}
