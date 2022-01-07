using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Aries constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Aries: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Aries()
        {
            Identifier = "ARI";
            Name = nameof(Aries);
            Stars = new[] {
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 06, Ras = 39.6594, RightAscension = 2.1110165000000003, Declination = 10.5143948 },
                new ConstellationArea { Identifier = "ARI", Rad = 1, Ram = 46, Ras = 37.3761, RightAscension = 1.7770489166666665, Declination = 10.5432396 },
                new ConstellationArea { Identifier = "ARI", Rad = 1, Ram = 46, Ras = 58.7219, RightAscension = 1.7829783055555555, Declination = 25.6263351 },
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 02, Ras = 03.2907, RightAscension = 2.0342474166666666, Declination = 25.6050701 },
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 02, Ras = 07.3479, RightAscension = 2.0353744166666665, Declination = 27.8550186 },
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 32, Ras = 16.8357, RightAscension = 2.5380099166666668, Declination = 27.8047638 },
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 32, Ras = 24.7665, RightAscension = 2.5402129166666665, Declination = 31.2213154 },
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 50, Ras = 30.8112, RightAscension = 2.841892, Declination = 31.1865025 },
                new ConstellationArea { Identifier = "ARI", Rad = 3, Ram = 29, Ras = 42.4003, RightAscension = 3.4951111944444446, Declination = 31.1003609 },
                new ConstellationArea { Identifier = "ARI", Rad = 3, Ram = 29, Ras = 09.7494, RightAscension = 3.4860415000000002, Declination = 19.4343338 },
                new ConstellationArea { Identifier = "ARI", Rad = 3, Ram = 24, Ras = 08.9363, RightAscension = 3.4024823055555555, Declination = 19.4461136 },
                new ConstellationArea { Identifier = "ARI", Rad = 3, Ram = 23, Ras = 47.1387, RightAscension = 3.3964274166666666, Declination = 10.3632069 },
                new ConstellationArea { Identifier = "ARI", Rad = 2, Ram = 06, Ras = 39.6594, RightAscension = 2.1110165000000003, Declination = 10.5143948 },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine { RightAscensionStart = 1.892157, DeclinationStart = 19.29409264, RightAscensionEnd = 1.91065251, DeclinationEnd = 20.80829949 }, 
                new ConstellationLine { RightAscensionStart = 1.91065251, DeclinationStart = 20.80829949, RightAscensionEnd = 2.11952383, DeclinationEnd = 23.46277743 }, 
                new ConstellationLine { RightAscensionStart = 2.11952383, DeclinationStart = 23.46277743, RightAscensionEnd = 2.8330526, DeclinationEnd = 27.26079044 },
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