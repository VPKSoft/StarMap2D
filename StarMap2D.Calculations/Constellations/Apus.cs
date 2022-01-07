using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Apus constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Apus: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Apus()
        {
            Identifier = "APS";
            Name = nameof(Apus);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 13, Ram = 56, Ras = 26.6661, RightAscension = 13.940740583333334,
                    Declination = -83.1200714
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 18, Ram = 27, Ras = 27.8395, RightAscension = 18.457733194444444,
                    Declination = -82.4582748
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 18, Ram = 16, Ras = 46.8145, RightAscension = 18.279670694444444,
                    Declination = -74.9745178
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 18, Ram = 13, Ras = 07.2185, RightAscension = 18.218671805555555,
                    Declination = -67.4800797
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 17, Ram = 43, Ras = 06.1749, RightAscension = 17.718381916666665,
                    Declination = -67.571106
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 17, Ram = 12, Ras = 58.1958, RightAscension = 17.2161655,
                    Declination = -67.661087
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 17, Ram = 13, Ras = 52.9629, RightAscension = 17.23137858333333,
                    Declination = -70.1597443
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 14, Ram = 56, Ras = 39.9459, RightAscension = 14.944429416666667,
                    Declination = -70.5115433
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 13, Ram = 49, Ras = 50.6089, RightAscension = 13.830724694444445,
                    Declination = -70.6244431
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 13, Ram = 51, Ras = 07.5441, RightAscension = 13.852095583333332,
                    Declination = -75.6235962
                },
                new ConstellationArea
                {
                    Identifier = "APS", Rad = 13, Ram = 56, Ras = 26.6661, RightAscension = 13.940740583333334,
                    Declination = -83.1200714
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 14.79770171, DeclinationStart = -79.04471242, RightAscensionEnd = 16.33912085,
                    DeclinationEnd = -78.69565609
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.33912085, DeclinationStart = -78.69565609, RightAscensionEnd = 16.55762893,
                    DeclinationEnd = -78.89695917
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.55762893, DeclinationStart = -78.89695917, RightAscensionEnd = 16.71817212,
                    DeclinationEnd = -77.51657182
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