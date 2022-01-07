using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Auriga constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Auriga: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstellationTemplate"/> class.
        /// </summary>
        public Auriga()
        {
            Identifier = "AUR";
            Name = nameof(Auriga);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 37, Ras = 56.8650, RightAscension = 4.632462500000001,
                    Declination = 30.921875
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 38, Ras = 17.7219, RightAscension = 4.638256083333333,
                    Declination = 36.254715
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 49, Ras = 49.7625, RightAscension = 4.830489583333333,
                    Declination = 36.2218513
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 51, Ras = 21.6684, RightAscension = 4.856019,
                    Declination = 52.7196465
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 5, Ram = 09, Ras = 56.3429, RightAscension = 5.165650805555556,
                    Declination = 52.665554
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 5, Ram = 10, Ras = 25.6235, RightAscension = 5.1737843055555555,
                    Declination = 56.1648331
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 16, Ras = 31.4613, RightAscension = 6.275405916666666,
                    Declination = 55.9658089
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 16, Ras = 13.7679, RightAscension = 6.270491083333333,
                    Declination = 53.9662552
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 40, Ras = 11.0475, RightAscension = 6.669735416666667,
                    Declination = 53.8938293
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 39, Ras = 40.6703, RightAscension = 6.661297305555556,
                    Declination = 49.8945885
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 57, Ras = 37.5261, RightAscension = 6.960423916666667,
                    Declination = 49.8410034
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 57, Ras = 03.6727, RightAscension = 6.951020194444444,
                    Declination = 44.3418388
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 7, Ram = 30, Ras = 56.1899, RightAscension = 7.515608305555555,
                    Declination = 44.2435493
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 7, Ram = 30, Ras = 14.5725, RightAscension = 7.504047916666667,
                    Declination = 35.2445297
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 40, Ras = 21.6663, RightAscension = 6.6726850833333335,
                    Declination = 35.390564
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 39, Ras = 51.7579, RightAscension = 6.6643771944444445,
                    Declination = 27.8913116
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 00, Ras = 53.0571, RightAscension = 6.0147380833333335,
                    Declination = 28.0092907
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 6, Ram = 00, Ras = 54.9367, RightAscension = 6.015260194444444,
                    Declination = 28.509243
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 52, Ras = 50.9941, RightAscension = 4.880831694444445,
                    Declination = 28.7124405
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 52, Ras = 56.4823, RightAscension = 4.882356194444445,
                    Declination = 30.2123089
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 37, Ras = 54.4293, RightAscension = 4.631785916666667,
                    Declination = 30.2552605
                },
                new ConstellationArea
                {
                    Identifier = "AUR", Rad = 4, Ram = 37, Ras = 56.8650, RightAscension = 4.632462500000001,
                    Declination = 30.921875
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 5.10857473, DeclinationStart = 41.23464074, RightAscensionEnd = 5.27813767,
                    DeclinationEnd = 45.99902927
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.27813767, DeclinationStart = 45.99902927, RightAscensionEnd = 5.99215817,
                    DeclinationEnd = 44.94743492
                },
                new ConstellationLine
                {
                    RightAscensionStart = 5.99215817, DeclinationStart = 44.94743492, RightAscensionEnd = 5.10857473,
                    DeclinationEnd = 41.23464074
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