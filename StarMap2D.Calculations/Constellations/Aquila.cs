using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Aquarius constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Aquila: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Aquila()
        {
            Identifier = "AQL";
            Name = nameof(Aquila);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 41, Ras = 24.0501, RightAscension = 18.69001391666667,
                    Declination = 0.1154895
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 41, Ras = 18.2958, RightAscension = 18.6884155,
                    Declination = 2.115346
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 58, Ras = 18.3421, RightAscension = 18.971761694444442,
                    Declination = 2.1659052
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 58, Ras = 06.2364, RightAscension = 18.968398999999998,
                    Declination = 6.4156075
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 45, Ras = 50.0565, RightAscension = 18.763904583333332,
                    Declination = 6.3791943
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 45, Ras = 33.1308, RightAscension = 18.759203,
                    Declination = 12.1287737
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 57, Ras = 49.5029, RightAscension = 18.963750805555556,
                    Declination = 12.1651964
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 57, Ras = 29.6727, RightAscension = 18.958242416666668,
                    Declination = 18.6647091
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 19, Ram = 05, Ras = 30.1185, RightAscension = 19.091699583333334,
                    Declination = 18.6882229
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 19, Ram = 05, Ras = 37.3146, RightAscension = 19.0936985,
                    Declination = 16.3550682
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 19, Ram = 55, Ras = 41.0797, RightAscension = 19.928077694444447,
                    Declination = 16.4957294
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 19, Ram = 55, Ras = 42.2400, RightAscension = 19.9284,
                    Declination = 16.0790844
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 14, Ras = 14.1594, RightAscension = 20.2372665,
                    Declination = 16.1275158
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 14, Ras = 32.8020, RightAscension = 20.242445,
                    Declination = 8.8779116
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 24, Ras = 03.3495, RightAscension = 20.400930416666665,
                    Declination = 8.901824
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 24, Ras = 18.9843, RightAscension = 20.405273416666667,
                    Declination = 2.4021468
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 38, Ras = 19.1706, RightAscension = 20.6386585,
                    Declination = 2.4360874
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 38, Ras = 23.7231, RightAscension = 20.639923083333333,
                    Declination = 0.4361772
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 38, Ras = 44.3155, RightAscension = 20.645643194444443,
                    Declination = -8.5634165
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 06, Ras = 46.4871, RightAscension = 20.112913083333336,
                    Declination = -8.643075
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 20, Ram = 06, Ras = 54.3287, RightAscension = 20.115091305555556,
                    Declination = -11.6762342
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 58, Ras = 58.5729, RightAscension = 18.982936916666667,
                    Declination = -11.866436
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 58, Ras = 35.3503, RightAscension = 18.976486194444444,
                    Declination = -3.8336766
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 41, Ras = 35.5650, RightAscension = 18.6932125,
                    Declination = -3.884223
                },
                new ConstellationArea
                {
                    Identifier = "AQL", Rad = 18, Ram = 41, Ras = 24.0501, RightAscension = 18.69001391666667,
                    Declination = 0.1154895
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 18.99371922, DeclinationStart = 15.06847757, RightAscensionEnd = 19.09017012,
                    DeclinationEnd = 13.86370983
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.02801149, DeclinationStart = -5.73901832, RightAscensionEnd = 19.10415275,
                    DeclinationEnd = -4.88233456
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.09017012, DeclinationStart = 13.86370983, RightAscensionEnd = 19.77099171,
                    DeclinationEnd = 10.61326869
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.10415275, DeclinationStart = -4.88233456, RightAscensionEnd = 19.42493129,
                    DeclinationEnd = 3.11457923
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.42493129, DeclinationStart = 3.11457923, RightAscensionEnd = 19.09017012,
                    DeclinationEnd = 13.86370983
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.77099171, DeclinationStart = 10.61326869, RightAscensionEnd = 19.84630057,
                    DeclinationEnd = 8.86738491
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.84630057, DeclinationStart = 8.86738491, RightAscensionEnd = 19.92187948,
                    DeclinationEnd = 6.40793334
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.8745455, DeclinationStart = 1.00567827, RightAscensionEnd = 19.42493129,
                    DeclinationEnd = 3.11457923
                },
                new ConstellationLine
                {
                    RightAscensionStart = 19.92187948, DeclinationStart = 6.40793334, RightAscensionEnd = 20.18840688,
                    DeclinationEnd = -0.82147569
                },
                new ConstellationLine
                {
                    RightAscensionStart = 20.18840688, DeclinationStart = -0.82147569, RightAscensionEnd = 19.8745455,
                    DeclinationEnd = 1.00567827
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