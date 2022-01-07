using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Andromeda constellation.
    /// Implements the <see cref="IConstellation{T, TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public class Andromeda: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Andromeda"/> class.
        /// </summary>
        public Andromeda()
        {
            Identifier = "AND";
            Name = nameof(Andromeda);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 22, Ram = 57, Ras = 51.6729, RightAscension = 22.96435358333333,
                    Declination = 35.1682358
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 22, Ram = 57, Ras = 22.2843, RightAscension = 22.956190083333333,
                    Declination = 53.1680298
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 25, Ras = 48.6945, RightAscension = 23.43019291666667,
                    Declination = 53.1870041
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 25, Ras = 51.7638, RightAscension = 23.4310455,
                    Declination = 50.6870193
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 41, Ras = 04.9337, RightAscension = 23.684703805555557,
                    Declination = 50.6929131
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 41, Ras = 06.2589, RightAscension = 23.68507191666667,
                    Declination = 48.6929169
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 16, Ras = 35.1282, RightAscension = 0.2764245,
                    Declination = 48.6949348
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 16, Ras = 34.3869, RightAscension = 0.2762185833333333,
                    Declination = 46.6949348
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 59, Ras = 06.2585, RightAscension = 0.9850718055555555,
                    Declination = 46.6757545
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 59, Ras = 09.3282, RightAscension = 0.9859245,
                    Declination = 48.6757393
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 14, Ras = 21.2179, RightAscension = 1.2392271944444444,
                    Declination = 48.663269
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 14, Ras = 25.4169, RightAscension = 1.2403935833333335,
                    Declination = 50.6632347
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 29, Ras = 37.9047, RightAscension = 1.4938624166666667,
                    Declination = 50.6478767
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 47, Ras = 52.4457, RightAscension = 1.7979015833333332,
                    Declination = 50.6257439
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 47, Ras = 43.5455, RightAscension = 1.7954293055555555,
                    Declination = 47.625843
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 2, Ram = 10, Ras = 29.1579, RightAscension = 2.174766083333333,
                    Declination = 47.5927505
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 2, Ram = 10, Ras = 41.7123, RightAscension = 2.1782534166666667,
                    Declination = 51.0925827
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 2, Ram = 39, Ras = 32.5149, RightAscension = 2.6590319166666667,
                    Declination = 51.0423737
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 2, Ram = 38, Ras = 43.0419, RightAscension = 2.6452894166666665,
                    Declination = 37.2931557
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 2, Ram = 07, Ras = 29.0619, RightAscension = 2.124739416666667,
                    Declination = 37.347084
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 2, Ram = 07, Ras = 25.0201, RightAscension = 2.1236166944444443,
                    Declination = 35.5971375
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 31, Ras = 38.6004, RightAscension = 1.5273889999999999,
                    Declination = 35.6453362
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 1, Ram = 31, Ras = 35.3823, RightAscension = 1.5264950833333333,
                    Declination = 33.6453705
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 49, Ras = 46.3353, RightAscension = 0.8295375833333333,
                    Declination = 33.6818962
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 49, Ras = 39.2379, RightAscension = 0.8275660833333334,
                    Declination = 24.4319324
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 57, Ras = 41.7755, RightAscension = 0.9616043055555555,
                    Declination = 24.4266243
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 57, Ras = 39.5557, RightAscension = 0.9609876944444444,
                    Declination = 21.6766376
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 14, Ras = 57.5811, RightAscension = 0.24932808333333334,
                    Declination = 21.6951923
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 14, Ras = 57.7547, RightAscension = 0.24937630555555557,
                    Declination = 22.6951923
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 10, Ras = 26.4039, RightAscension = 0.17400108333333333,
                    Declination = 22.6957588
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 10, Ras = 27.0822, RightAscension = 0.1741895,
                    Declination = 28.6957588
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 06, Ras = 25.4919, RightAscension = 0.10708108333333334,
                    Declination = 28.6960354
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 0, Ram = 06, Ras = 25.6745, RightAscension = 0.10713180555555556,
                    Declination = 32.0293655
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 51, Ras = 18.8979, RightAscension = 23.85524941666667,
                    Declination = 32.0285034
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 51, Ras = 18.7398, RightAscension = 23.8552055,
                    Declination = 32.7785072
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 36, Ras = 11.7979, RightAscension = 23.603277194444445,
                    Declination = 32.7746468
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 23, Ram = 36, Ras = 10.6031, RightAscension = 23.602945305555558,
                    Declination = 35.1913109
                },
                new ConstellationArea
                {
                    Identifier = "AND", Rad = 22, Ram = 57, Ras = 51.6729, RightAscension = 22.96435358333333,
                    Declination = 35.1682358
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 0.13976888, DeclinationStart = 29.09082805, RightAscensionEnd = 0.65544371,
                    DeclinationEnd = 30.86122579
                },
                new ConstellationLine
                {
                    RightAscensionStart = 0.65544371, DeclinationStart = 30.86122579, RightAscensionEnd = 1.16216599,
                    DeclinationEnd = 35.62083048
                },
                new ConstellationLine
                {
                    RightAscensionStart = 0.83023048, DeclinationStart = 41.07895474, RightAscensionEnd = 0.94586046,
                    DeclinationEnd = 38.49925513
                },
                new ConstellationLine
                {
                    RightAscensionStart = 0.94586046, DeclinationStart = 38.49925513, RightAscensionEnd = 1.16216599,
                    DeclinationEnd = 35.62083048
                },
                new ConstellationLine
                {
                    RightAscensionStart = 1.16216599, DeclinationStart = 35.62083048, RightAscensionEnd = 1.61332694,
                    DeclinationEnd = 41.40638491
                },
                new ConstellationLine
                {
                    RightAscensionStart = 1.61332694, DeclinationStart = 41.40638491, RightAscensionEnd = 1.6331951,
                    DeclinationEnd = 48.62848641
                },
                new ConstellationLine
                {
                    RightAscensionStart = 2.06497752, DeclinationStart = 42.32984832, RightAscensionEnd = 1.61332694,
                    DeclinationEnd = 41.40638491
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
