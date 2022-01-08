using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the CONSTELLATIONTEMPLATE constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class ConstellationTemplate: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public ConstellationTemplate()
        {

            Boundary = ConstellationBoundary.ConstellationBoundaries.Where(f => f.Identifier == Identifier).ToList();
            ConstellationLines = StaticData.ConstellationLines.Lines
                .Where(f => f.Identifier == Identifier).ToList();

        }

        /// <inheritdoc cref="IConstellation{T, TLines}.Identifier"/>
        public string Identifier { get; init; }

        /// <inheritdoc cref="IConstellation{T, TLines}.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="IConstellation{T,TLines}.Boundary"/>
        public IReadOnlyList<IConstellationStar> Boundary { get; }

        /// <inheritdoc cref="IConstellation{T, TLines}.ConstellationLines"/>
        public IReadOnlyList<ConstellationLine> ConstellationLines { get; init; }
    }
}
