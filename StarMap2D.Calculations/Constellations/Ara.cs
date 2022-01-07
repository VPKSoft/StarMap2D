using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Ara constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Ara
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Ara()
        {
            Identifier = "ARA";
            Name = nameof(Ara);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 36, Ras = 08.3235, RightAscension = 16.602312083333334,
                    Declination = -60.2644577
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 34, Ras = 16.9497, RightAscension = 16.571374916666667,
                    Declination = -45.7670517
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 17, Ram = 59, Ras = 14.2281, RightAscension = 17.987285583333335,
                    Declination = -45.516346
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 18, Ram = 09, Ras = 14.1642, RightAscension = 18.1539345,
                    Declination = -45.4859734
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 18, Ram = 10, Ras = 41.3407, RightAscension = 18.178150194444445,
                    Declination = -56.9837723
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 17, Ram = 40, Ras = 40.3655, RightAscension = 17.677879305555557,
                    Declination = -57.0747757
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 17, Ram = 43, Ras = 06.1749, RightAscension = 17.718381916666665,
                    Declination = -67.571106
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 17, Ram = 12, Ras = 58.1958, RightAscension = 17.2161655,
                    Declination = -67.661087
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 17, Ram = 02, Ras = 53.9959, RightAscension = 17.048332194444445,
                    Declination = -67.6905823
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 17, Ram = 02, Ras = 10.1742, RightAscension = 17.0361595,
                    Declination = -65.1916428
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 57, Ras = 08.0435, RightAscension = 16.952234305555553,
                    Declination = -65.2062531
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 56, Ras = 46.8330, RightAscension = 16.9463425,
                    Declination = -63.7900925
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 46, Ras = 42.3171, RightAscension = 16.778421416666667,
                    Declination = -63.8189964
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 46, Ras = 09.0833, RightAscension = 16.769189805555555,
                    Declination = -61.2364578
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 36, Ras = 19.5912, RightAscension = 16.605442,
                    Declination = -61.2641945
                },
                new ConstellationArea
                {
                    Identifier = "ARA", Rad = 16, Ram = 36, Ras = 08.3235, RightAscension = 16.602312083333334,
                    Declination = -60.2644577
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 16.82975317, DeclinationStart = -59.04131648, RightAscensionEnd = 16.97700854,
                    DeclinationEnd = -55.99005508
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.97700854, DeclinationStart = -55.99005508, RightAscensionEnd = 16.99306851,
                    DeclinationEnd = -53.16049005
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.97700854, DeclinationStart = -55.99005508, RightAscensionEnd = 17.42323884,
                    DeclinationEnd = -56.37768824
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.99306851, DeclinationStart = -53.16049005, RightAscensionEnd = 17.53070044,
                    DeclinationEnd = -49.87598159
                },
                new ConstellationLine
                {
                    RightAscensionStart = 17.42166588, DeclinationStart = -55.52982397, RightAscensionEnd = 17.42323884,
                    DeclinationEnd = -56.37768824
                },
                new ConstellationLine
                {
                    RightAscensionStart = 17.42323884, DeclinationStart = -56.37768824, RightAscensionEnd = 17.51832693,
                    DeclinationEnd = -60.68360667
                },
                new ConstellationLine
                {
                    RightAscensionStart = 17.53070044, DeclinationStart = -49.87598159, RightAscensionEnd = 17.42166588,
                    DeclinationEnd = -55.52982397
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