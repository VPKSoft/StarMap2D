using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Ursa Major constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public  class UrsaMajor: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrsaMajor"/> class.
        /// </summary>
        public UrsaMajor()
        {
            Identifier = "UMA";
            Name = nameof(UrsaMajor);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 9, Ram = 42, Ras = 50.2171, RightAscension = 9.713949194444444,
                    Declination = 41.431675
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 9, Ram = 18, Ras = 02.9977, RightAscension = 9.300832694444445,
                    Declination = 41.4785957
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 9, Ram = 18, Ras = 21.7707, RightAscension = 9.306047416666667,
                    Declination = 46.4782791
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 8, Ram = 33, Ras = 45.6249, RightAscension = 8.562673583333334,
                    Declination = 46.5777283
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 8, Ram = 35, Ras = 11.7921, RightAscension = 8.586608916666668,
                    Declination = 59.5759888
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 8, Ram = 08, Ras = 30.9843, RightAscension = 8.141940083333333,
                    Declination = 59.6433983
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 8, Ram = 12, Ras = 20.6949, RightAscension = 8.205748583333333,
                    Declination = 73.1383743
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 9, Ram = 22, Ras = 27.7137, RightAscension = 9.374364916666668,
                    Declination = 72.9741364
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 11, Ram = 27, Ras = 50.7287, RightAscension = 11.464091305555554,
                    Declination = 72.8125
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 11, Ram = 27, Ras = 23.8431, RightAscension = 11.456623083333332,
                    Declination = 65.8126068
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 06, Ras = 19.0213, RightAscension = 12.105283694444443,
                    Declination = 65.8039627
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 06, Ras = 19.5743, RightAscension = 12.105437305555554,
                    Declination = 63.3039627
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 13, Ram = 34, Ras = 12.1293, RightAscension = 13.570035916666667,
                    Declination = 63.3593445
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 13, Ram = 34, Ras = 17.6739, RightAscension = 13.571576083333333,
                    Declination = 62.3593979
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 14, Ram = 28, Ras = 10.8609, RightAscension = 14.469683583333333,
                    Declination = 62.4414825
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 14, Ram = 29, Ras = 00.2997, RightAscension = 14.483416583333332,
                    Declination = 54.9422379
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 14, Ram = 06, Ras = 20.2539, RightAscension = 14.105626083333332,
                    Declination = 54.9035759
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 14, Ram = 06, Ras = 47.6957, RightAscension = 14.113248805555555,
                    Declination = 47.9039383
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 13, Ram = 35, Ras = 10.8273, RightAscension = 13.586340916666668,
                    Declination = 47.8599281
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 13, Ram = 34, Ras = 58.1757, RightAscension = 13.582826583333333,
                    Declination = 52.3598061
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 11, Ras = 16.4454, RightAscension = 12.1879015,
                    Declination = 52.3043365
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 11, Ras = 18.3441, RightAscension = 12.188428916666666,
                    Declination = 44.3043365
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 06, Ras = 21.9399, RightAscension = 12.106094416666666,
                    Declination = 44.3039627
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 06, Ras = 22.6815, RightAscension = 12.106300416666667,
                    Declination = 33.3039627
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 12, Ram = 06, Ras = 22.9593, RightAscension = 12.106377583333334,
                    Declination = 28.3039627
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 11, Ram = 58, Ras = 26.1459, RightAscension = 11.973929416666667,
                    Declination = 28.3040466
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 11, Ram = 06, Ras = 46.5595, RightAscension = 11.112933194444444,
                    Declination = 28.3250256
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 11, Ram = 06, Ras = 51.4141, RightAscension = 11.114281694444443,
                    Declination = 33.3249931
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 10, Ram = 53, Ras = 57.4581, RightAscension = 10.899293916666666,
                    Declination = 33.3356781
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 10, Ram = 54, Ras = 05.5605, RightAscension = 10.901544583333333,
                    Declination = 39.3356133
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 10, Ram = 17, Ras = 26.2590, RightAscension = 10.2906275,
                    Declination = 39.3774109
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 10, Ram = 17, Ras = 30.7737, RightAscension = 10.291881583333334,
                    Declination = 41.3773613
                },
                new ConstellationArea
                {
                    Identifier = "UMA", Rad = 9, Ram = 42, Ras = 50.2171, RightAscension = 9.713949194444444,
                    Declination = 41.431675
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 11.0306641, DeclinationStart = 56.38234478, RightAscensionEnd = 11.89715035,
                    DeclinationEnd = 53.69473296
                },
                new ConstellationLine
                {
                    RightAscensionStart = 11.06217691, DeclinationStart = 61.75111888, RightAscensionEnd = 11.0306641,
                    DeclinationEnd = 56.38234478
                },
                new ConstellationLine
                {
                    RightAscensionStart = 11.89715035, DeclinationStart = 53.69473296, RightAscensionEnd = 12.25706919,
                    DeclinationEnd = 57.03259792
                },
                new ConstellationLine
                {
                    RightAscensionStart = 12.25706919, DeclinationStart = 57.03259792, RightAscensionEnd = 11.06217691,
                    DeclinationEnd = 61.75111888
                },
                new ConstellationLine
                {
                    RightAscensionStart = 12.9004536, DeclinationStart = 55.95984301, RightAscensionEnd = 12.25706919,
                    DeclinationEnd = 57.03259792
                },
                new ConstellationLine
                {
                    RightAscensionStart = 13.39872773, DeclinationStart = 54.92541525, RightAscensionEnd = 12.9004536,
                    DeclinationEnd = 55.95984301
                },
                new ConstellationLine
                {
                    RightAscensionStart = 13.79237392, DeclinationStart = 49.31330288, RightAscensionEnd = 13.39872773,
                    DeclinationEnd = 54.92541525
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