using StarMap2D.Calculations.Constellations.Interfaces;

namespace StarMap2D.Calculations.Constellations
{
    /// <summary>
    /// A class representing the Perseus constellation.
    /// Implements the <see cref="IConstellation{T,TLines}" />
    /// </summary>
    /// <seealso cref="IConstellation{T, TLines}" />
    public  class Perseus: IConstellation<ConstellationArea, ConstellationLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perseus"/> class.
        /// </summary>
        public Perseus()
        {
            Identifier = "PER";
            Name = nameof(Perseus);
            Stars = new[]
            {
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 50, Ras = 30.8112, RightAscension = 2.841892,
                    Declination = 31.1865025
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 50, Ras = 39.9523, RightAscension = 2.8444311944444447,
                    Declination = 34.5196762
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 41, Ras = 36.5719, RightAscension = 2.6934921944444445,
                    Declination = 34.5375137
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 41, Ras = 44.3181, RightAscension = 2.695643916666667,
                    Declination = 37.2873878
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 38, Ras = 43.0419, RightAscension = 2.6452894166666665,
                    Declination = 37.2931557
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 39, Ras = 32.5149, RightAscension = 2.6590319166666667,
                    Declination = 51.0423737
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 10, Ras = 41.7123, RightAscension = 2.1782534166666667,
                    Declination = 51.0925827
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 10, Ras = 29.1579, RightAscension = 2.174766083333333,
                    Declination = 47.5927505
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 1, Ram = 47, Ras = 43.5455, RightAscension = 1.7954293055555555,
                    Declination = 47.625843
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 1, Ram = 47, Ras = 52.4457, RightAscension = 1.7979015833333332,
                    Declination = 50.6257439
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 1, Ram = 29, Ras = 37.9047, RightAscension = 1.4938624166666667,
                    Declination = 50.6478767
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 1, Ram = 29, Ras = 49.4433, RightAscension = 1.4970675833333333,
                    Declination = 54.6477699
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 1, Ram = 50, Ras = 08.0739, RightAscension = 1.8355760833333334,
                    Declination = 54.6228828
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 1, Ram = 50, Ras = 22.8534, RightAscension = 1.8396815000000002,
                    Declination = 58.1227188
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 03, Ras = 05.6697, RightAscension = 2.0515749166666666,
                    Declination = 58.1046753
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 03, Ras = 10.9501, RightAscension = 2.053041694444444,
                    Declination = 59.1046104
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 35, Ras = 12.5653, RightAscension = 2.5868236944444445,
                    Declination = 59.0511551
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 35, Ras = 02.9609, RightAscension = 2.5841558055555556,
                    Declination = 57.5513
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 3, Ram = 15, Ras = 36.2232, RightAscension = 3.260062,
                    Declination = 57.4684982
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 3, Ram = 19, Ras = 39.2391, RightAscension = 3.3275664166666665,
                    Declination = 57.4593849
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 3, Ram = 19, Ras = 24.9654, RightAscension = 3.3236014999999997,
                    Declination = 55.4596519
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 3, Ram = 29, Ras = 31.6561, RightAscension = 3.4921266944444445,
                    Declination = 55.4362831
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 3, Ram = 29, Ras = 15.1407, RightAscension = 3.4875390833333335,
                    Declination = 52.9366074
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 4, Ram = 51, Ras = 21.6684, RightAscension = 4.856019,
                    Declination = 52.7196465
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 4, Ram = 49, Ras = 49.7625, RightAscension = 4.830489583333333,
                    Declination = 36.2218513
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 4, Ram = 38, Ras = 17.7219, RightAscension = 4.638256083333333,
                    Declination = 36.254715
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 4, Ram = 37, Ras = 56.8650, RightAscension = 4.632462500000001,
                    Declination = 30.921875
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 3, Ram = 29, Ras = 42.4003, RightAscension = 3.4951111944444446,
                    Declination = 31.1003609
                },
                new ConstellationArea
                {
                    Identifier = "PER", Rad = 2, Ram = 50, Ras = 30.8112, RightAscension = 2.841892,
                    Declination = 31.1865025
                },
            };

            ConstellationLines = new[]
            {
                new ConstellationLine
                {
                    RightAscensionStart = 2.8951606, DeclinationStart = 38.33767914, RightAscensionEnd = 2.84303172,
                    DeclinationEnd = 38.31890838
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.07994173, DeclinationStart = 53.50645031, RightAscensionEnd = 2.84494243,
                    DeclinationEnd = 55.89552955
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.08624916, DeclinationStart = 38.84053298, RightAscensionEnd = 2.8951606,
                    DeclinationEnd = 38.33767914
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.13614714, DeclinationStart = 40.9556512, RightAscensionEnd = 3.08624916,
                    DeclinationEnd = 38.84053298
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.1508009, DeclinationStart = 49.61350009, RightAscensionEnd = 2.73657999,
                    DeclinationEnd = 49.22866639
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.1508009, DeclinationStart = 49.61350009, RightAscensionEnd = 3.1582303,
                    DeclinationEnd = 44.85788896
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.1582303, DeclinationStart = 44.85788896, RightAscensionEnd = 3.13614714,
                    DeclinationEnd = 40.9556512
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.40537459, DeclinationStart = 49.86124281, RightAscensionEnd = 3.07994173,
                    DeclinationEnd = 53.50645031
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.40537459, DeclinationStart = 49.86124281, RightAscensionEnd = 3.1508009,
                    DeclinationEnd = 49.61350009
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.60815558, DeclinationStart = 48.19270068, RightAscensionEnd = 3.40537459,
                    DeclinationEnd = 49.86124281
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.71541169, DeclinationStart = 47.7876533, RightAscensionEnd = 3.60815558,
                    DeclinationEnd = 48.19270068
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.73864623, DeclinationStart = 32.28827325, RightAscensionEnd = 3.90219957,
                    DeclinationEnd = 31.88365776
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.75323428, DeclinationStart = 42.57854437, RightAscensionEnd = 3.71541169,
                    DeclinationEnd = 47.7876533
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.90219957, DeclinationStart = 31.88365776, RightAscensionEnd = 3.98274992,
                    DeclinationEnd = 35.79102701
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.96422809, DeclinationStart = 40.01027315, RightAscensionEnd = 3.75323428,
                    DeclinationEnd = 42.57854437
                },
                new ConstellationLine
                {
                    RightAscensionStart = 3.98274992, DeclinationStart = 35.79102701, RightAscensionEnd = 3.96422809,
                    DeclinationEnd = 40.01027315
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.10973758, DeclinationStart = 50.35135022, RightAscensionEnd = 4.24829381,
                    DeclinationEnd = 48.40937312
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.14435368, DeclinationStart = 47.71259359, RightAscensionEnd = 3.71541169,
                    DeclinationEnd = 47.7876533
                },
                new ConstellationLine
                {
                    RightAscensionStart = 4.24829381, DeclinationStart = 48.40937312, RightAscensionEnd = 4.14435368,
                    DeclinationEnd = 47.71259359
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