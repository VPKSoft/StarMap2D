using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{

    /// <summary>
    /// A class representing the Orion constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class UrsaMinor: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orion"/> class.
        /// </summary>
        public UrsaMinor()
        {
            Identifier = "UMI";
            Name = "Ursa Minor";
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 13, Ram = 03, Ras = 16.9470, RightAscension = 13.054707500000001,
                    Declination = 76.3289108
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 13, Ram = 04, Ras = 23.3937, RightAscension = 13.073164916666666,
                    Declination = 69.329361
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 14, Ram = 02, Ras = 36.1947, RightAscension = 14.043387416666667,
                    Declination = 69.3991165
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 14, Ram = 03, Ras = 16.9333, RightAscension = 14.054703694444445,
                    Declination = 65.3996506
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 15, Ram = 41, Ras = 19.0957, RightAscension = 15.688637694444445,
                    Declination = 65.6023483
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 15, Ram = 40, Ras = 12.1512, RightAscension = 15.670041999999999,
                    Declination = 69.6009445
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 16, Ram = 31, Ras = 21.8550, RightAscension = 16.522737499999998,
                    Declination = 69.7383041
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 16, Ram = 28, Ras = 52.9698, RightAscension = 16.481380499999997,
                    Declination = 74.734787
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 17, Ram = 26, Ras = 08.7929, RightAscension = 17.435775805555554,
                    Declination = 74.9033127
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 17, Ram = 20, Ras = 52.2971, RightAscension = 17.347860305555553,
                    Declination = 79.8953476
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 17, Ram = 50, Ras = 37.4449, RightAscension = 17.843734694444443,
                    Declination = 79.9857483
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 17, Ram = 26, Ras = 53.3353, RightAscension = 17.448148694444445,
                    Declination = 85.9495697
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 20, Ram = 34, Ras = 53.0328, RightAscension = 20.581398,
                    Declination = 86.4656219
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 20, Ram = 33, Ras = 19.5253, RightAscension = 20.555423694444446,
                    Declination = 86.6306305
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 22, Ram = 54, Ras = 02.5599, RightAscension = 22.90071108333333,
                    Declination = 86.8368912
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 22, Ram = 37, Ras = 02.6371, RightAscension = 22.617399194444445,
                    Declination = 88.663887
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 9, Ram = 03, Ras = 19.7931, RightAscension = 9.055498083333333,
                    Declination = 87.5689163
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 8, Ram = 41, Ras = 36.6601, RightAscension = 8.693516694444444,
                    Declination = 86.0975418
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 14, Ram = 12, Ras = 05.5098, RightAscension = 14.201530499999999,
                    Declination = 85.930809
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 14, Ram = 27, Ras = 07.8855, RightAscension = 14.452190416666665,
                    Declination = 79.4449844
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 13, Ram = 35, Ras = 14.2055, RightAscension = 13.587279305555557,
                    Declination = 79.3629303
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 13, Ram = 36, Ras = 37.6845, RightAscension = 13.610467916666666,
                    Declination = 76.3638153
                },
                new ConstellationArea
                {
                    Identifier = "UMI", Rad = 13, Ram = 03, Ras = 16.9470, RightAscension = 13.054707500000001,
                    Declination = 76.3289108
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 14.84510983, DeclinationStart = 74.15547596, RightAscensionEnd = 15.34548589,
                    DeclinationEnd = 71.83397308
                },
                new ConstellationLine
                {
                    RightAscensionStart = 15.34548589, DeclinationStart = 71.83397308, RightAscensionEnd = 16.29180584,
                    DeclinationEnd = 75.75470385
                },
                new ConstellationLine
                {
                    RightAscensionStart = 15.73429554, DeclinationStart = 77.79449901, RightAscensionEnd = 14.84510983,
                    DeclinationEnd = 74.15547596
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.29180584, DeclinationStart = 75.75470385, RightAscensionEnd = 15.73429554,
                    DeclinationEnd = 77.79449901
                },
                new ConstellationLine
                {
                    RightAscensionStart = 16.76615597, DeclinationStart = 82.03725071, RightAscensionEnd = 15.73429554,
                    DeclinationEnd = 77.79449901
                },
                new ConstellationLine
                {
                    RightAscensionStart = 17.53691588, DeclinationStart = 86.58632924, RightAscensionEnd = 16.76615597,
                    DeclinationEnd = 82.03725071
                },
                new ConstellationLine
                {
                    RightAscensionStart = 2.52974312, DeclinationStart = 89.26413805, RightAscensionEnd = 17.53691588,
                    DeclinationEnd = 86.58632924
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
