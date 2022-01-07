using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Antilia constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Antilia: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Antilia()
        {
            Identifier = "ANT";
            Name = nameof(Antilia);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 9, Ram = 27, Ras = 37.0404, RightAscension = 9.460289,
                    Declination = -24.5425186
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 9, Ram = 27, Ras = 05.1837, RightAscension = 9.451439916666667,
                    Declination = -37.2920151
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 9, Ram = 26, Ras = 56.1747, RightAscension = 9.448937416666666,
                    Declination = -40.2918739
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 11, Ram = 05, Ras = 49.5611, RightAscension = 11.097100305555555,
                    Declination = -40.4246216
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 11, Ram = 05, Ras = 55.0471, RightAscension = 11.098624194444445,
                    Declination = -35.6746559
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 10, Ram = 55, Ras = 50.0437, RightAscension = 10.930567694444443,
                    Declination = -35.6664963
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 10, Ram = 55, Ras = 54.6924, RightAscension = 10.931859,
                    Declination = -31.8332005
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 10, Ram = 40, Ras = 48.3309, RightAscension = 10.680091916666665,
                    Declination = -31.8185863
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 10, Ram = 40, Ras = 51.0945, RightAscension = 10.680859583333334,
                    Declination = -29.8186131
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 10, Ram = 20, Ras = 43.5185, RightAscension = 10.345421805555556,
                    Declination = -29.7947845
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 10, Ram = 20, Ras = 47.8410, RightAscension = 10.3466225,
                    Declination = -27.1281624
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 9, Ram = 50, Ras = 38.2279, RightAscension = 9.843952194444444,
                    Declination = -27.0835037
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 9, Ram = 50, Ras = 43.1235, RightAscension = 9.845312083333335,
                    Declination = -24.5835705
                },
                new ConstellationArea
                {
                    Identifier = "ANT", Rad = 9, Ram = 27, Ras = 37.0404, RightAscension = 9.460289,
                    Declination = -24.5425186
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 10.4525433, DeclinationStart = -31.06780228, RightAscensionEnd = 10.94527675,
                    DeclinationEnd = -37.1374629
                },
                new ConstellationLine
                {
                    RightAscensionStart = 9.48742707, DeclinationStart = -35.9513478, RightAscensionEnd = 9.73670284,
                    DeclinationEnd = -27.76956287
                },
                new ConstellationLine
                {
                    RightAscensionStart = 9.73670284, DeclinationStart = -27.76956287, RightAscensionEnd = 10.4525433,
                    DeclinationEnd = -31.06780228
                },
            };
        }

        /// <inheritdoc cref="IConstellation{T, TLines}.Identifier"/>
        public string Identifier { get; init; }

        /// <inheritdoc cref="IConstellation{T, TLines}.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="IConstellation{T, TLines}.Stars"/>
        public IReadOnlyList<IConstellationStar> Stars { get; }

        /// <inheritdoc cref="IConstellation{T, TLines}.ConstellationLines"/>
        public IReadOnlyList<ConstellationLine> ConstellationLines { get; init; }
    }
}