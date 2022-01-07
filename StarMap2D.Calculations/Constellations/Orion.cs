using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Plotting;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Orion constellation.
    /// Implements the <see cref="IConstellation{T, TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Orion: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orion"/> class.
        /// </summary>
        public Orion()
        {
            Identifier = "ORI";
            Name = nameof(Orion);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 4, Ram = 43, Ras = 24.5665, RightAscension = 4.723490694444444,
                    Declination = 0.2375014
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 4, Ram = 44, Ras = 08.1669, RightAscension = 4.735601916666667,
                    Declination = 15.7364635
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 05, Ras = 09.3423, RightAscension = 5.0859284166666665,
                    Declination = 15.6755352
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 05, Ras = 10.8669, RightAscension = 5.086351916666667,
                    Declination = 16.175499
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 27, Ras = 11.6910, RightAscension = 5.4532475,
                    Declination = 16.1101055
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 27, Ras = 10.1358, RightAscension = 5.4528155,
                    Declination = 15.6101446
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 43, Ras = 10.4751, RightAscension = 5.7195764166666665,
                    Declination = 15.5619202
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 43, Ras = 01.2137, RightAscension = 5.717003805555556,
                    Declination = 12.5621548
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 53, Ras = 01.2887, RightAscension = 5.883691305555555,
                    Declination = 12.5318508
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 53, Ras = 18.5201, RightAscension = 5.888477805555555,
                    Declination = 18.0314159
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 49, Ras = 18.4757, RightAscension = 5.821798805555555,
                    Declination = 18.0435486
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 49, Ras = 34.5105, RightAscension = 5.826252916666666,
                    Declination = 22.8764725
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 00, Ras = 34.5690, RightAscension = 6.0096025,
                    Declination = 22.8430862
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 00, Ras = 30.0373, RightAscension = 6.008343694444444,
                    Declination = 21.5098724
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 20, Ras = 29.7906, RightAscension = 6.3416084999999995,
                    Declination = 21.4491768
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 20, Ras = 16.6981, RightAscension = 6.337971694444444,
                    Declination = 17.4495068
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 25, Ras = 46.5402, RightAscension = 6.4295945,
                    Declination = 17.4328651
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 25, Ras = 29.4633, RightAscension = 6.424850916666667,
                    Declination = 11.9332972
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 25, Ras = 23.4397, RightAscension = 6.423177694444445,
                    Declination = 9.9334478
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 21, Ras = 23.5275, RightAscension = 6.3565354166666665,
                    Declination = 9.9455481
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 20, Ras = 54.1633, RightAscension = 6.3483786944444445,
                    Declination = -0.0537102
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 6, Ram = 20, Ras = 42.5141, RightAscension = 6.345142805555556,
                    Declination = -4.0534163
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 56, Ras = 12.5693, RightAscension = 5.936824805555556,
                    Declination = -3.9790573
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 55, Ras = 51.7897, RightAscension = 5.931052694444444,
                    Declination = -10.9785318
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 10, Ras = 52.8075, RightAscension = 5.181335416666667,
                    Declination = -10.8432293
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 5, Ram = 11, Ras = 13.0549, RightAscension = 5.186959694444445,
                    Declination = -3.8437285
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 4, Ram = 46, Ras = 13.5261, RightAscension = 4.770423916666666,
                    Declination = -3.7708201
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 4, Ram = 46, Ras = 24.5553, RightAscension = 4.773487583333333,
                    Declination = 0.2289162
                },
                new ConstellationArea
                {
                    Identifier = "ORI", Rad = 4, Ram = 43, Ras = 24.5665, RightAscension = 4.723490694444444,
                    Declination = 0.2375014
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 4.83059395, DeclinationStart = 06.96124744, RightAscensionEnd = 4.853435,
                    DeclinationEnd = 05.60510146
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.83059395, DeclinationStart = 06.96124744, RightAscensionEnd = 5.41885227,
                    DeclinationEnd = 06.34973451
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.84353396, DeclinationStart = 08.90025258, RightAscensionEnd = 4.83059395,
                    DeclinationEnd = 06.96124744
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.853435, DeclinationStart = 05.60510146, RightAscensionEnd = 4.90419323,
                    DeclinationEnd = 02.44067149
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.90419323, DeclinationStart = 02.44067149, RightAscensionEnd = 4.97580635,
                    DeclinationEnd = 01.71403506
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.91491781, DeclinationStart = 10.15114511, RightAscensionEnd = 4.84353396,
                    DeclinationEnd = 08.90025258
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.24229756, DeclinationStart = -08.20163919, RightAscensionEnd = 5.79594109,
                    DeclinationEnd = -09.66960186
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.41885227, DeclinationStart = 06.34973451, RightAscensionEnd = 5.53344437,
                    DeclinationEnd = -00.29909340
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.53344437, DeclinationStart = -00.29909340, RightAscensionEnd = 5.24229756,
                    DeclinationEnd = -08.20163919
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.58563269, DeclinationStart = 09.93416294, RightAscensionEnd = 5.41885227,
                    DeclinationEnd = 06.34973451
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.67931244, DeclinationStart = -01.94257841, RightAscensionEnd = 5.91952477,
                    DeclinationEnd = 07.40703634
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.79594109, DeclinationStart = -09.66960186, RightAscensionEnd = 5.67931244,
                    DeclinationEnd = -01.94257841
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.91952477, DeclinationStart = 07.40703634, RightAscensionEnd = 5.58563269,
                    DeclinationEnd = 09.93416294
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.91952477, DeclinationStart = 07.40703634, RightAscensionEnd = 6.03971954,
                    DeclinationEnd = 09.64736756
                },
                new ConstellationLine
                {
                    RightAscensionStart = 6.03971954, DeclinationStart = 09.64736756, RightAscensionEnd = 6.1989991,
                    DeclinationEnd = 14.20881425
                },
                new ConstellationLine
                {
                    RightAscensionStart = 6.12620051, DeclinationStart = 14.76852318, RightAscensionEnd = 6.06532876,
                    DeclinationEnd = 20.13845865
                },
                new ConstellationLine
                {
                    RightAscensionStart = 6.1989991, DeclinationStart = 14.20881425, RightAscensionEnd = 6.12620051,
                    DeclinationEnd = 14.76852318
                },
                new ConstellationLine
                {
                    RightAscensionStart = 6.1989991, DeclinationStart = 14.20881425, RightAscensionEnd = 6.20037193,
                    DeclinationEnd = 19.79057155
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
