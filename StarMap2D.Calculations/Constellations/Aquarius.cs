using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Aquarius constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Aquarius: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Aquarius()
        {
            Identifier = "AQR";
            Name = nameof(Aquarius);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 20, Ram = 38, Ras = 23.7231, RightAscension = 20.639923083333333,
                    Declination = 0.4361772
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 20, Ram = 38, Ras = 19.1706, RightAscension = 20.6386585,
                    Declination = 2.4360874
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 20, Ram = 56, Ras = 19.4633, RightAscension = 20.938739805555556,
                    Declination = 2.4773185
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 26, Ras = 20.0331, RightAscension = 21.438898083333335,
                    Declination = 2.5393796
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 34, Ras = 20.2249, RightAscension = 21.572284694444445,
                    Declination = 2.5544112
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 34, Ras = 18.8997, RightAscension = 21.571916583333334,
                    Declination = 3.3043909
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 46, Ras = 19.2525, RightAscension = 21.772014583333334,
                    Declination = 3.3256676
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 46, Ras = 20.9007, RightAscension = 21.772472416666666,
                    Declination = 2.325691
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 22, Ram = 06, Ras = 21.3012, RightAscension = 22.105917,
                    Declination = 2.3576119
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 22, Ram = 06, Ras = 20.9441, RightAscension = 22.105817805555557,
                    Declination = 2.6076074
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 22, Ram = 51, Ras = 22.1321, RightAscension = 22.85614780555556,
                    Declination = 2.6622071
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 22, Ram = 51, Ras = 23.9310, RightAscension = 22.8566475,
                    Declination = 0.6622211
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 22, Ram = 51, Ras = 27.5289, RightAscension = 22.857646916666667,
                    Declination = -3.3377509
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 23, Ram = 56, Ras = 24.5307, RightAscension = 23.940147416666665,
                    Declination = -3.3042023
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 23, Ram = 56, Ras = 24.7917, RightAscension = 23.940219916666667,
                    Declination = -6.3042021
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 23, Ram = 56, Ras = 26.5355, RightAscension = 23.940704305555556,
                    Declination = -24.8042011
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 23, Ram = 06, Ras = 43.4319, RightAscension = 23.11206441666667,
                    Declination = -24.8250446
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 59, Ras = 04.8693, RightAscension = 21.984685916666667,
                    Declination = -24.9040413
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 58, Ras = 37.4790, RightAscension = 21.9770775,
                    Declination = -8.4043999
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 26, Ras = 40.4196, RightAscension = 21.444561,
                    Declination = -8.4602947
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 21, Ram = 26, Ras = 51.9483, RightAscension = 21.447763416666668,
                    Declination = -14.4601107
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 20, Ram = 38, Ras = 58.5363, RightAscension = 20.649593416666665,
                    Declination = -14.5631361
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 20, Ram = 38, Ras = 44.3155, RightAscension = 20.645643194444443,
                    Declination = -8.5634165
                },
                new ConstellationArea
                {
                    Identifier = "AQR", Rad = 20, Ram = 38, Ras = 23.7231, RightAscension = 20.639923083333333,
                    Declination = 0.4361772
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 20.79459238, DeclinationStart = -9.49568988, RightAscensionEnd = 20.87755716,
                    DeclinationEnd = -8.98323782
                },
                new ConstellationLine
                {
                    RightAscensionStart = 20.87755716, DeclinationStart = -8.98323782, RightAscensionEnd = 21.52597796,
                    DeclinationEnd = -5.57115593
                },
                new ConstellationLine
                {
                    RightAscensionStart = 21.52597796, DeclinationStart = -5.57115593, RightAscensionEnd = 22.09639591,
                    DeclinationEnd = -0.31982656
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.09639591, DeclinationStart = -0.31982656, RightAscensionEnd = 22.28054621,
                    DeclinationEnd = -7.78323706
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.09639591, DeclinationStart = -0.31982656, RightAscensionEnd = 22.36091665,
                    DeclinationEnd = -1.38735315
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.28054621, DeclinationStart = -7.78323706, RightAscensionEnd = 22.10727926,
                    DeclinationEnd = -13.86954013
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.36091665, DeclinationStart = -1.38735315, RightAscensionEnd = 22.48050015,
                    DeclinationEnd = -0.02006304
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.48050015, DeclinationStart = -0.02006304, RightAscensionEnd = 23.23870347,
                    DeclinationEnd = -6.0485268
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.8265305, DeclinationStart = -13.59253756, RightAscensionEnd = 22.91084423,
                    DeclinationEnd = -15.82075994
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.87690679, DeclinationStart = -7.57967878, RightAscensionEnd = 22.8265305,
                    DeclinationEnd = -13.59253756
                },
                new ConstellationLine
                {
                    RightAscensionStart = 22.91084423, DeclinationStart = -15.82075994, RightAscensionEnd = 23.15743391,
                    DeclinationEnd = -21.17248555
                },
                new ConstellationLine
                {
                    RightAscensionStart = 23.23870347, DeclinationStart = -6.0485268, RightAscensionEnd = 22.87690679,
                    DeclinationEnd = -7.57967878
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