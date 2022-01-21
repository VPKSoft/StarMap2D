#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using StarMap2D.Calculations.Constellations.Enumerations;

namespace StarMap2D.Calculations.Constellations.StaticData;

/// <summary>
/// A class containing the constellation star data mapped with three letter IAU identifier.
/// </summary>
public class ConstellationStars
{
    /// <summary>
    /// Gets the constellation star collection based on the <see cref="ConstellationLines.FigureFlavor"/> value.
    /// </summary>
    /// <value>The stars.</value>
    public static ConstellationStar[] Stars
    {
        get
        {
            if (ConstellationLines.FigureFlavor == ConstellationFigureFlavor.SMap)
            {
                return ConstellationStarsSMap;
            }

            if (ConstellationLines.FigureFlavor == ConstellationFigureFlavor.LinesDf)
            {
                return ConstellationStarsDf;
            }

            return ConstellationStarsSMap;
        }
    }

    /// <summary>
    /// The constellation star data.
    /// </summary>
    // These values are from the SMap software created in the start 2005. The copyright is unknown.
    // http://www.vpksoft.net/2015-03-31-13-33-28/starmap
    private static readonly ConstellationStar[] ConstellationStarsSMap =
    {
        new()
        {
            Identifier = "AND", RightAscension = 0.13976888, Declination = 29.09082805, Name = "21 Alp And",
            ProperName = "Alpheratz", Rah = 0, Ram = 8, Ras = 23.1679680000001, InternalId = 1,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.65544371, Declination = 30.86122579, Name = "31 Del And",
            ProperName = "", Rah = 0, Ram = 39, Ras = 19.597356, InternalId = 2,
        },
        new()
        {
            Identifier = "AND", RightAscension = 1.16216599, Declination = 35.62083048, Name = "43 Bet And",
            ProperName = "Mirach", Rah = 1, Ram = 9, Ras = 43.7975640000004, InternalId = 3,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.83023048, Declination = 41.07895474, Name = "35 Nu And",
            ProperName = "", Rah = 0, Ram = 49, Ras = 48.829728, InternalId = 4,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.94586046, Declination = 38.49925513, Name = "37 Mu And",
            ProperName = "", Rah = 0, Ram = 56, Ras = 45.097656, InternalId = 5,
        },
        new()
        {
            Identifier = "AND", RightAscension = 1.61332694, Declination = 41.40638491, Name = "50 Ups And",
            ProperName = "", Rah = 1, Ram = 36, Ras = 47.9769840000004, InternalId = 6,
        },
        new()
        {
            Identifier = "AND", RightAscension = 1.6331951, Declination = 48.62848641, Name = "51 And",
            ProperName = "", Rah = 1, Ram = 37, Ras = 59.5023599999999, InternalId = 7,
        },
        new()
        {
            Identifier = "AND", RightAscension = 2.06497752, Declination = 42.32984832, Name = "57 Gam 1 And",
            ProperName = "", Rah = 2, Ram = 3, Ras = 53.9190719999992, InternalId = 8,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 10.4525433, Declination = -31.06780228, Name = "Alp Ant",
            ProperName = "", Rah = 10, Ram = 27, Ras = 9.15588000000109, InternalId = 9,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 10.94527675, Declination = -37.1374629, Name = "Iot Ant",
            ProperName = "", Rah = 10, Ram = 56, Ras = 42.9962999999987, InternalId = 10,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 9.48742707, Declination = -35.9513478, Name = "Eps Ant",
            ProperName = "", Rah = 9, Ram = 29, Ras = 14.7374520000026, InternalId = 11,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 9.73670284, Declination = -27.76956287, Name = "The Ant",
            ProperName = "", Rah = 9, Ram = 44, Ras = 12.1302239999985, InternalId = 12,
        },
        new()
        {
            Identifier = "APS", RightAscension = 14.79770171, Declination = -79.04471242, Name = "Alp Aps",
            ProperName = "", Rah = 14, Ram = 47, Ras = 51.7261560000005, InternalId = 13,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.33912085, Declination = -78.69565609, Name = "Del 1 Aps",
            ProperName = "", Rah = 16, Ram = 20, Ras = 20.8350600000018, InternalId = 14,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.55762893, Declination = -78.89695917, Name = "Gam Aps",
            ProperName = "", Rah = 16, Ram = 33, Ras = 27.4641479999995, InternalId = 15,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.71817212, Declination = -77.51657182, Name = "Bet Aps",
            ProperName = "", Rah = 16, Ram = 43, Ras = 5.41963199999427, InternalId = 16,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 18.99371922, Declination = 15.06847757, Name = "13 Eps Aql",
            ProperName = "", Rah = 18, Ram = 59, Ras = 37.389191999997, InternalId = 17,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.09017012, Declination = 13.86370983, Name = "17 Zet Aql",
            ProperName = "", Rah = 19, Ram = 5, Ras = 24.6124319999993, InternalId = 18,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.02801149, Declination = -5.73901832, Name = "12 Aql",
            ProperName = "", Rah = 19, Ram = 1, Ras = 40.8413640000029, InternalId = 19,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.10415275, Declination = -4.88233456, Name = "16 Lam Aql",
            ProperName = "", Rah = 19, Ram = 6, Ras = 14.9499000000028, InternalId = 20,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.77099171, Declination = 10.61326869, Name = "50 Gam Aql",
            ProperName = "Tarazed", Rah = 19, Ram = 46, Ras = 15.5701560000018, InternalId = 21,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.42493129, Declination = 3.11457923, Name = "30 Del Aql",
            ProperName = "", Rah = 19, Ram = 25, Ras = 29.7526439999998, InternalId = 22,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.84630057, Declination = 8.86738491, Name = "53 Alp Aql",
            ProperName = "Altair", Rah = 19, Ram = 50, Ras = 46.6820520000012, InternalId = 23,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.92187948, Declination = 6.40793334, Name = "60 Bet Aql",
            ProperName = "", Rah = 19, Ram = 55, Ras = 18.7661280000044, InternalId = 24,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.8745455, Declination = 1.00567827, Name = "55 Eta Aql",
            ProperName = "", Rah = 19, Ram = 52, Ras = 28.3637999999998, InternalId = 25,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 20.18840688, Declination = -0.82147569, Name = "65 The Aql",
            ProperName = "", Rah = 20, Ram = 11, Ras = 18.2647679999954, InternalId = 26,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 20.79459238, Declination = -9.49568988, Name = "2 Eps Aqr",
            ProperName = "", Rah = 20, Ram = 47, Ras = 40.5325680000036, InternalId = 27,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 20.87755716, Declination = -8.98323782, Name = "6 Mu Aqr",
            ProperName = "", Rah = 20, Ram = 52, Ras = 39.2057759999945, InternalId = 28,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 21.52597796, Declination = -5.57115593, Name = "22 Bet Aqr",
            ProperName = "", Rah = 21, Ram = 31, Ras = 33.5206559999953, InternalId = 29,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.09639591, Declination = -0.31982656, Name = "34 Alp Aqr",
            ProperName = "", Rah = 22, Ram = 5, Ras = 47.0252759999937, InternalId = 30,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.28054621, Declination = -7.78323706, Name = "43 The Aqr",
            ProperName = "", Rah = 22, Ram = 16, Ras = 49.9663560000025, InternalId = 31,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.36091665, Declination = -1.38735315, Name = "48 Gam Aqr",
            ProperName = "", Rah = 22, Ram = 21, Ras = 39.2999400000003, InternalId = 32,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.10727926, Declination = -13.86954013, Name = "33 Iot Aqr",
            ProperName = "", Rah = 22, Ram = 6, Ras = 26.2053359999947, InternalId = 33,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.48050015, Declination = -0.02006304, Name = "55 Zet 1 Aqr",
            ProperName = "", Rah = 22, Ram = 28, Ras = 49.8005400000036, InternalId = 34,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 23.23870347, Declination = -6.0485268, Name = "90 Phi Aqr",
            ProperName = "", Rah = 23, Ram = 14, Ras = 19.3324920000029, InternalId = 35,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.8265305, Declination = -13.59253756, Name = "71 Tau 2 Aqr",
            ProperName = "", Rah = 22, Ram = 49, Ras = 35.5098000000019, InternalId = 36,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.91084423, Declination = -15.82075994, Name = "76 Del Aqr",
            ProperName = "", Rah = 22, Ram = 54, Ras = 39.0392279999948, InternalId = 37,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.87690679, Declination = -7.57967878, Name = "73 Lam Aqr",
            ProperName = "", Rah = 22, Ram = 52, Ras = 36.8644439999985, InternalId = 38,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 23.15743391, Declination = -21.17248555, Name = "88 Aqr",
            ProperName = "", Rah = 23, Ram = 9, Ras = 26.7620760000063, InternalId = 39,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.82975317, Declination = -59.04131648, Name = "Eta Ara",
            ProperName = "", Rah = 16, Ram = 49, Ras = 47.1114120000002, InternalId = 40,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.97700854, Declination = -55.99005508, Name = "Zet Ara",
            ProperName = "", Rah = 16, Ram = 58, Ras = 37.2307439999997, InternalId = 41,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.99306851, Declination = -53.16049005, Name = "Eps 1 Ara",
            ProperName = "", Rah = 16, Ram = 59, Ras = 35.046636000002, InternalId = 42,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.42323884, Declination = -56.37768824, Name = "Gam Ara",
            ProperName = "", Rah = 17, Ram = 25, Ras = 23.6598239999992, InternalId = 43,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.53070044, Declination = -49.87598159, Name = "Alp Ara",
            ProperName = "", Rah = 17, Ram = 31, Ras = 50.5215840000012, InternalId = 44,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.42166588, Declination = -55.52982397, Name = "Bet Ara",
            ProperName = "", Rah = 17, Ram = 25, Ras = 17.9971679999965, InternalId = 45,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.51832693, Declination = -60.68360667, Name = "Del Ara",
            ProperName = "", Rah = 17, Ram = 31, Ras = 5.97694800000208, InternalId = 46,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 1.892157, Declination = 19.29409264, Name = "5 Gam 2 Ari",
            ProperName = "", Rah = 1, Ram = 53, Ras = 31.7652000000004, InternalId = 47,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 1.91065251, Declination = 20.80829949, Name = "6 Bet Ari",
            ProperName = "", Rah = 1, Ram = 54, Ras = 38.349036, InternalId = 48,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 2.11952383, Declination = 23.46277743, Name = "13 Alp Ari",
            ProperName = "Hamal", Rah = 2, Ram = 7, Ras = 10.2857879999996, InternalId = 49,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 2.8330526, Declination = 27.26079044, Name = "41 Ari",
            ProperName = "", Rah = 2, Ram = 49, Ras = 58.9893599999994, InternalId = 50,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.10857473, Declination = 41.23464074, Name = "10 Eta Aur",
            ProperName = "", Rah = 5, Ram = 6, Ras = 30.8690279999998, InternalId = 51,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.27813767, Declination = 45.99902927, Name = "13 Alp Aur",
            ProperName = "Capella", Rah = 5, Ram = 16, Ras = 41.2956119999984, InternalId = 52,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.99215817, Declination = 44.94743492, Name = "34 Bet Aur",
            ProperName = "", Rah = 5, Ram = 59, Ras = 31.7694119999992, InternalId = 53,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 13.78778795, Declination = 17.45677436, Name = "4 Tau Boo",
            ProperName = "", Rah = 13, Ram = 47, Ras = 16.0366200000009, InternalId = 54,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 13.91142116, Declination = 18.39858742, Name = "8 Eta Boo",
            ProperName = "", Rah = 13, Ram = 54, Ras = 41.116175999999, InternalId = 55,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 13.82463829, Declination = 15.79780583, Name = "5 Ups Boo",
            ProperName = "", Rah = 13, Ram = 49, Ras = 28.6978439999976, InternalId = 56,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.2612076, Declination = 19.18726997, Name = "16 Alp Boo",
            ProperName = "Arcturus", Rah = 14, Ram = 15, Ras = 40.3473600000019, InternalId = 57,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.53051606, Declination = 30.37114497, Name = "25 Rho Boo",
            ProperName = "", Rah = 14, Ram = 31, Ras = 49.8578160000001, InternalId = 58,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.74979191, Declination = 27.07417383, Name = "36 Eps Boo",
            ProperName = "Izar", Rah = 14, Ram = 44, Ras = 59.250876000003, InternalId = 59,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.27310454, Declination = 46.08791894, Name = "19 Lam Boo",
            ProperName = "", Rah = 14, Ram = 16, Ras = 23.176344000001, InternalId = 60,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.22437444, Declination = 51.78787676, Name = "17 Kap 1 Boo",
            ProperName = "", Rah = 14, Ram = 13, Ras = 27.7479840000002, InternalId = 61,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.53465494, Declination = 38.30788348, Name = "27 Gam Boo",
            ProperName = "", Rah = 14, Ram = 32, Ras = 4.75778399999771, InternalId = 62,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.67876693, Declination = 16.4183013, Name = "29 Pi 1 Boo",
            ProperName = "", Rah = 14, Ram = 40, Ras = 43.5609480000005, InternalId = 63,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.68581121, Declination = 13.72833113, Name = "30 Zet Boo",
            ProperName = "", Rah = 14, Ram = 41, Ras = 8.92035600000236, InternalId = 64,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 15.25836216, Declination = 33.31510222, Name = "49 Del Boo",
            ProperName = "", Rah = 15, Ram = 15, Ras = 30.1037760000028, InternalId = 65,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 15.03244253, Declination = 40.39063671, Name = "42 Bet Boo",
            ProperName = "", Rah = 15, Ram = 1, Ras = 56.7931080000031, InternalId = 66,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 15.4082045, Declination = 37.37696091, Name = "51 Mu 1 Boo",
            ProperName = "", Rah = 15, Ram = 24, Ras = 29.5362000000002, InternalId = 67,
        },
        new()
        {
            Identifier = "CAE", RightAscension = 4.67606197, Declination = -41.86357034, Name = "Alp Cae",
            ProperName = "", Rah = 4, Ram = 40, Ras = 33.8230920000006, InternalId = 68,
        },
        new()
        {
            Identifier = "CAE", RightAscension = 4.7009573, Declination = -37.14476616, Name = "Bet Cae",
            ProperName = "", Rah = 4, Ram = 42, Ras = 3.44627999999938, InternalId = 69,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 4.90083628, Declination = 66.34266029, Name = "9 Alp Cam",
            ProperName = "", Rah = 4, Ram = 54, Ras = 3.01060800000008, InternalId = 70,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 3.83929883, Declination = 71.33236777, Name = "Gam Cam",
            ProperName = "", Rah = 3, Ram = 50, Ras = 21.4757880000004, InternalId = 71,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 4.95478345, Declination = 53.75208289, Name = "7 Cam",
            ProperName = "", Rah = 4, Ram = 57, Ras = 17.2204199999997, InternalId = 72,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 5.05697146, Declination = 60.44228144, Name = "10 Bet Cam",
            ProperName = "", Rah = 5, Ram = 3, Ras = 25.0972559999991, InternalId = 73,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.29412669, Declination = -12.50821403, Name = "5 Alp 1 Cap",
            ProperName = "", Rah = 20, Ram = 17, Ras = 38.8560839999957, InternalId = 74,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.35017956, Declination = -14.78140119, Name = "9 Bet Cap",
            ProperName = "", Rah = 20, Ram = 21, Ras = 0.646416000003081, InternalId = 75,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.76826836, Declination = -25.27051682, Name = "16 Psi Cap",
            ProperName = "", Rah = 20, Ram = 46, Ras = 5.76609600000135, InternalId = 76,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.86369338, Declination = -26.91912642, Name = "18 Ome Cap",
            ProperName = "", Rah = 20, Ram = 51, Ras = 49.2961680000031, InternalId = 77,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.11880151, Declination = -25.00574796, Name = "24 Cap",
            ProperName = "", Rah = 21, Ram = 7, Ras = 7.68543600000299, InternalId = 78,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.09910538, Declination = -17.23271095, Name = "23 The Cap",
            ProperName = "", Rah = 21, Ram = 5, Ras = 56.7793680000037, InternalId = 79,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.44445214, Declination = -22.41137838, Name = "34 Zet Cap",
            ProperName = "", Rah = 21, Ram = 26, Ras = 40.0277039999971, InternalId = 80,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.3707715, Declination = -16.83455521, Name = "32 Iot Cap",
            ProperName = "", Rah = 21, Ram = 22, Ras = 14.7774000000002, InternalId = 81,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.61800632, Declination = -19.46601352, Name = "39 Eps Cap",
            ProperName = "", Rah = 21, Ram = 37, Ras = 4.82275199999709, InternalId = 82,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.78396813, Declination = -16.12656595, Name = "49 Del Cap",
            ProperName = "", Rah = 21, Ram = 47, Ras = 2.28526800000597, InternalId = 83,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.66815062, Declination = -16.66225343, Name = "40 Gam Cap",
            ProperName = "", Rah = 21, Ram = 40, Ras = 5.34223199999544, InternalId = 84,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.22896636, Declination = -70.03792169, Name = "Ome Car",
            ProperName = "", Rah = 10, Ram = 13, Ras = 44.2788959999977, InternalId = 85,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 9.22006688, Declination = -69.71747245, Name = "Bet Car",
            ProperName = "", Rah = 9, Ram = 13, Ras = 12.240767999997, InternalId = 86,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.28472369, Declination = -61.33231977, Name = "",
            ProperName = "", Rah = 10, Ram = 17, Ras = 5.00528399999953, InternalId = 87,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.5337455, Declination = -61.68536031, Name = "", ProperName = "",
            Rah = 10, Ram = 32, Ras = 1.48380000000077, InternalId = 87,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.71595186, Declination = -64.39447937, Name = "The Car",
            ProperName = "", Rah = 10, Ram = 42, Ras = 57.4266960000021, InternalId = 88,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 6.39919184, Declination = -52.69571799, Name = "Alp Car",
            ProperName = "Canopus", Rah = 6, Ram = 23, Ras = 57.090624000001, InternalId = 89,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 7.94631715, Declination = -52.98240062, Name = "Chi Car",
            ProperName = "", Rah = 7, Ram = 56, Ras = 46.7417399999985, InternalId = 90,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 8.37524019, Declination = -59.50953829, Name = "Eps Car",
            ProperName = "", Rah = 8, Ram = 22, Ras = 30.8646839999984, InternalId = 91,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 9.28484122, Declination = -59.27526115, Name = "Iot Car",
            ProperName = "", Rah = 9, Ram = 17, Ras = 5.42839200000205, InternalId = 92,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 9.78503822, Declination = -65.07201888, Name = "Ups Car",
            ProperName = "", Rah = 9, Ram = 47, Ras = 6.13759200000206, InternalId = 93,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 0.67510756, Declination = 56.53740928, Name = "18 Alp Cas",
            ProperName = "Shedir", Rah = 0, Ram = 40, Ras = 30.3872160000003, InternalId = 94,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 0.15280269, Declination = 59.15021814, Name = "11 Bet Cas",
            ProperName = "Caph", Rah = 0, Ram = 9, Ras = 10.089684, InternalId = 95,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 0.9451392, Declination = 60.71674966, Name = "27 Gam Cas",
            ProperName = "", Rah = 0, Ram = 56, Ras = 42.5011199999998, InternalId = 96,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 1.43016751, Declination = 60.23540347, Name = "37 Del Cas",
            ProperName = "", Rah = 1, Ram = 25, Ras = 48.6030359999998, InternalId = 97,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 1.90657873, Declination = 63.67014686, Name = "45 Eps Cas",
            ProperName = "", Rah = 1, Ram = 54, Ras = 23.6834280000003, InternalId = 98,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 11.35012284, Declination = -54.49101395, Name = "Pi Cen",
            ProperName = "", Rah = 11, Ram = 21, Ras = 0.442223999997049, InternalId = 99,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 11.59636896, Declination = -63.01982488, Name = "Lam Cen",
            ProperName = "", Rah = 11, Ram = 35, Ras = 46.9282559999981, InternalId = 100,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.13931767, Declination = -50.72240999, Name = "Del Cen",
            ProperName = "", Rah = 12, Ram = 8, Ras = 21.5436120000018, InternalId = 101,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.19420872, Declination = -52.36841559, Name = "Rho Cen",
            ProperName = "", Rah = 12, Ram = 11, Ras = 39.1513920000025, InternalId = 102,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.2340908, Declination = -45.72393011, Name = "", ProperName = "",
            Rah = 12, Ram = 14, Ras = 2.72688000000214, InternalId = 103,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.82508261, Declination = -41.68765971, Name = "Nu Cen",
            ProperName = "", Rah = 13, Ram = 49, Ras = 30.297396000003, InternalId = 104,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.46733655, Declination = -50.2306048, Name = "Sig Cen",
            ProperName = "", Rah = 12, Ram = 28, Ras = 2.41158000000223, InternalId = 105,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.69200138, Declination = -48.95988553, Name = "Gam Cen",
            ProperName = "", Rah = 12, Ram = 41, Ras = 31.2049680000023, InternalId = 106,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.34335154, Declination = -36.71208109, Name = "Iot Cen",
            ProperName = "", Rah = 13, Ram = 20, Ras = 36.0655440000017, InternalId = 107,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.66479797, Declination = -53.46636269, Name = "Eps Cen",
            ProperName = "", Rah = 13, Ram = 39, Ras = 53.2726920000014, InternalId = 108,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.06373459, Declination = -60.3729784, Name = "Bet Cen",
            ProperName = "Hadar", Rah = 14, Ram = 3, Ras = 49.4445239999973, InternalId = 109,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.92567635, Declination = -47.28826634, Name = "Zet Cen",
            ProperName = "", Rah = 13, Ram = 55, Ras = 32.4348599999995, InternalId = 110,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.5917921, Declination = -42.15774562, Name = "Eta Cen",
            ProperName = "", Rah = 14, Ram = 35, Ras = 30.4515599999972, InternalId = 111,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.11147907, Declination = -36.36869575, Name = "5 The Cen",
            ProperName = "", Rah = 14, Ram = 6, Ras = 41.3246519999988, InternalId = 112,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.9860275, Declination = -42.10414199, Name = "Kap Cen",
            ProperName = "", Rah = 14, Ram = 59, Ras = 9.69900000000199, InternalId = 113,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.66136068, Declination = -60.83514707, Name = "Alp 1 Cen",
            ProperName = "", Rah = 14, Ram = 39, Ras = 40.8984479999984, InternalId = 114,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.66479797, Declination = -53.46636269, Name = "urus A",
            ProperName = "", Rah = 13, Ram = 39, Ras = 53.2726920000014, InternalId = 115,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 20.75479684, Declination = 61.83679404, Name = "3 Eta Cep",
            ProperName = "", Rah = 20, Ram = 45, Ras = 17.2686240000033, InternalId = 116,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 20.49300758, Declination = 62.99413722, Name = "2 The Cep",
            ProperName = "", Rah = 20, Ram = 29, Ras = 34.8272880000016, InternalId = 117,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 21.30960598, Declination = 62.58545529, Name = "5 Alp Cep",
            ProperName = "Alderamin", Rah = 21, Ram = 18, Ras = 34.5815280000023, InternalId = 118,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 21.47765973, Declination = 70.56069481, Name = "8 Bet Cep",
            ProperName = "", Rah = 21, Ram = 28, Ras = 39.575027999997, InternalId = 119,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.18090608, Declination = 58.20124992, Name = "21 Zet Cep",
            ProperName = "", Rah = 22, Ram = 10, Ras = 51.2618879999991, InternalId = 120,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.82803115, Declination = 66.20071089, Name = "32 Iot Cep",
            ProperName = "", Rah = 22, Ram = 49, Ras = 40.9121400000038, InternalId = 121,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.25046638, Declination = 57.04346522, Name = "23 Eps Cep",
            ProperName = "", Rah = 22, Ram = 15, Ras = 1.67896799999596, InternalId = 122,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.48617998, Declination = 58.4151899, Name = "27 Del Cep",
            ProperName = "", Rah = 22, Ram = 29, Ras = 10.2479279999974, InternalId = 123,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 23.65582834, Declination = 77.63196681, Name = "35 Gam Cep",
            ProperName = "", Rah = 23, Ram = 39, Ras = 20.9820239999976, InternalId = 124,
        },
        new()
        {
            Identifier = "CET", RightAscension = 0.32380084, Declination = -8.82382948, Name = "8 Iot Cet",
            ProperName = "", Rah = 0, Ram = 19, Ras = 25.683024, InternalId = 125,
        },
        new()
        {
            Identifier = "CET", RightAscension = 0.7264523, Declination = -17.9866841, Name = "16 Bet Cet",
            ProperName = "Diphda", Rah = 0, Ram = 43, Ras = 35.2282800000002, InternalId = 126,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.73475762, Declination = -15.93955597, Name = "52 Tau Cet",
            ProperName = "", Rah = 1, Ram = 44, Ras = 5.12743199999979, InternalId = 127,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.14312879, Declination = -10.181928, Name = "31 Eta Cet",
            ProperName = "", Rah = 1, Ram = 8, Ras = 35.263644, InternalId = 128,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.40040311, Declination = -8.18275372, Name = "45 The Cet",
            ProperName = "", Rah = 1, Ram = 24, Ras = 1.45119600000014, InternalId = 129,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.85766961, Declination = -10.33494526, Name = "55 Zet Cet",
            ProperName = "", Rah = 1, Ram = 51, Ras = 27.6105960000004, InternalId = 130,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.32244073, Declination = -2.97706055, Name = "68 Omi Cet",
            ProperName = "", Rah = 2, Ram = 19, Ras = 20.7866279999995, InternalId = 131,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.46931052, Declination = 8.4600887, Name = "73 Xi 2 Cet",
            ProperName = "", Rah = 2, Ram = 28, Ras = 9.5178720000002, InternalId = 132,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.7489926, Declination = 10.11421979, Name = "87 Mu Cet",
            ProperName = "", Rah = 2, Ram = 44, Ras = 56.3733599999994, InternalId = 133,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.59791361, Declination = 5.59330163, Name = "78 Nu Cet",
            ProperName = "", Rah = 2, Ram = 35, Ras = 52.4889959999998, InternalId = 134,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.65804119, Declination = 0.3285168, Name = "82 Del Cet",
            ProperName = "", Rah = 2, Ram = 39, Ras = 28.9482840000001, InternalId = 135,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.72170126, Declination = 3.23617162, Name = "86 Gam Cet",
            ProperName = "", Rah = 2, Ram = 43, Ras = 18.1245360000004, InternalId = 136,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.99524897, Declination = 8.90740111, Name = "91 Lam Cet",
            ProperName = "", Rah = 2, Ram = 59, Ras = 42.8962920000002, InternalId = 137,
        },
        new()
        {
            Identifier = "CET", RightAscension = 3.03799418, Declination = 4.08992539, Name = "92 Alp Cet",
            ProperName = "Menkar", Rah = 3, Ram = 2, Ras = 16.7790480000004, InternalId = 138,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 10.59117177, Declination = -78.60781379, Name = "Gam Cha",
            ProperName = "", Rah = 10, Ram = 35, Ras = 28.2183720000026, InternalId = 139,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 12.30581775, Declination = -79.31226899, Name = "Bet Cha",
            ProperName = "", Rah = 12, Ram = 18, Ras = 20.9438999999972, InternalId = 140,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 10.75454864, Declination = -80.4695233, Name = "Del 1 Cha",
            ProperName = "", Rah = 10, Ram = 45, Ras = 16.375103999998, InternalId = 141,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 8.34413553, Declination = -77.4845764, Name = "The Cha",
            ProperName = "", Rah = 8, Ram = 20, Ras = 38.8879080000031, InternalId = 142,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 8.30868523, Declination = -76.91998251, Name = "Alp Cha",
            ProperName = "", Rah = 8, Ram = 18, Ras = 31.2668280000002, InternalId = 143,
        },
        new()
        {
            Identifier = "CIR", RightAscension = 14.70852362, Declination = -64.97456957, Name = "Alp Cir",
            ProperName = "", Rah = 14, Ram = 42, Ras = 30.6850319999978, InternalId = 144,
        },
        new()
        {
            Identifier = "CIR", RightAscension = 15.29193339, Declination = -58.80087882, Name = "Bet Cir",
            ProperName = "", Rah = 15, Ram = 17, Ras = 30.9602040000019, InternalId = 145,
        },
        new()
        {
            Identifier = "CIR", RightAscension = 15.38962715, Declination = -59.32069839, Name = "Gam Cir",
            ProperName = "", Rah = 15, Ram = 23, Ras = 22.6577400000028, InternalId = 146,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.33855198, Declination = -30.06337656, Name = "1 Zet CMa",
            ProperName = "", Rah = 6, Ram = 20, Ras = 18.7871280000004, InternalId = 147,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.9770963, Declination = -28.97208931, Name = "21 Eps CMa",
            ProperName = "Adhara", Rah = 6, Ram = 58, Ras = 37.5466800000013, InternalId = 148,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.7525694, Declination = -16.71314306, Name = "9 Alp CMa",
            ProperName = "Sirius", Rah = 6, Ram = 45, Ras = 9.2498399999986, InternalId = 149,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.37832983, Declination = -17.95591658, Name = "2 Bet CMa",
            ProperName = "", Rah = 6, Ram = 22, Ras = 41.9873880000008, InternalId = 150,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.90318908, Declination = -12.03859273, Name = "14 The CMa",
            ProperName = "", Rah = 6, Ram = 54, Ras = 11.480687999999, InternalId = 151,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.06263699, Declination = -15.63325876, Name = "23 Gam CMa",
            ProperName = "", Rah = 7, Ram = 3, Ras = 45.4931639999988, InternalId = 152,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.93561842, Declination = -17.05424675, Name = "20 Iot CMa",
            ProperName = "", Rah = 6, Ram = 56, Ras = 8.22631199999977, InternalId = 153,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.02865325, Declination = -27.93484165, Name = "22 Sig CMa",
            ProperName = "", Rah = 7, Ram = 1, Ras = 43.1516999999987, InternalId = 154,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.13985723, Declination = -26.39320776, Name = "25 Del CMa",
            ProperName = "", Rah = 7, Ram = 8, Ras = 23.4860279999986, InternalId = 155,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.05040932, Declination = -23.83330131, Name = "24 Omi 2 CMa",
            ProperName = "", Rah = 7, Ram = 3, Ras = 1.47355199999992, InternalId = 156,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.24685045, Declination = -26.77268601, Name = "28 Ome CMa",
            ProperName = "", Rah = 7, Ram = 14, Ras = 48.6616200000006, InternalId = 157,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.31180218, Declination = -24.95438447, Name = "30 Tau CMa",
            ProperName = "", Rah = 7, Ram = 18, Ras = 42.4878479999998, InternalId = 158,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.40158473, Declination = -29.30311979, Name = "31 Eta CMa",
            ProperName = "", Rah = 7, Ram = 24, Ras = 5.70502799999892, InternalId = 159,
        },
        new()
        {
            Identifier = "CMI", RightAscension = 7.45252008, Declination = 8.28940893, Name = "3 Bet CMi",
            ProperName = "", Rah = 7, Ram = 27, Ras = 9.07228800000073, InternalId = 160,
        },
        new()
        {
            Identifier = "CMI", RightAscension = 7.65514946, Declination = 5.22750767, Name = "10 Alp CMi",
            ProperName = "Procyon", Rah = 7, Ram = 39, Ras = 18.5380559999986, InternalId = 161,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.72144808, Declination = 21.46859609, Name = "43 Gam Cnc",
            ProperName = "", Rah = 8, Ram = 43, Ras = 17.2130880000001, InternalId = 162,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.7447528, Declination = 18.15486399, Name = "47 Del Cnc",
            ProperName = "", Rah = 8, Ram = 44, Ras = 41.1100800000022, InternalId = 163,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.2752634, Declination = 9.18566295, Name = "17 Bet Cnc",
            ProperName = "", Rah = 8, Ram = 16, Ras = 30.9482400000002, InternalId = 164,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.97477693, Declination = 11.85777198, Name = "65 Alp Cnc",
            ProperName = "", Rah = 8, Ram = 58, Ras = 29.1969480000031, InternalId = 165,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.77777674, Declination = 28.76516551, Name = "48 Iot Cnc",
            ProperName = "", Rah = 8, Ram = 46, Ras = 39.9962640000005, InternalId = 166,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.5202043, Declination = -35.47043592, Name = "Eps Col",
            ProperName = "", Rah = 5, Ram = 31, Ras = 12.7354799999984, InternalId = 167,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.66081665, Declination = -34.07404941, Name = "Alp Col",
            ProperName = "", Rah = 5, Ram = 39, Ras = 38.9399400000003, InternalId = 168,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.84932022, Declination = -35.76929225, Name = "Bet Col",
            ProperName = "", Rah = 5, Ram = 50, Ras = 57.5527920000001, InternalId = 169,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.95894774, Declination = -35.28330688, Name = "Gam Col",
            ProperName = "", Rah = 5, Ram = 57, Ras = 32.2118640000007, InternalId = 170,
        },
        new()
        {
            Identifier = "COL", RightAscension = 6.27587093, Declination = -35.14073157, Name = "Kap Col",
            ProperName = "", Rah = 6, Ram = 16, Ras = 33.1353479999999, InternalId = 171,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.98577514, Declination = -42.81510761, Name = "Eta Col",
            ProperName = "", Rah = 5, Ram = 59, Ras = 8.79050400000136, InternalId = 172,
        },
        new()
        {
            Identifier = "COL", RightAscension = 6.36856809, Declination = -33.43627251, Name = "Del Col",
            ProperName = "", Rah = 6, Ram = 22, Ras = 6.84512400000055, InternalId = 173,
        },
        new()
        {
            Identifier = "COM", RightAscension = 12.44897988, Declination = 28.26861975, Name = "15 Gam Com",
            ProperName = "", Rah = 12, Ram = 26, Ras = 56.3275679999983, InternalId = 174,
        },
        new()
        {
            Identifier = "COM", RightAscension = 13.19803407, Declination = 27.87603769, Name = "43 Bet Com",
            ProperName = "", Rah = 13, Ram = 11, Ras = 52.9226520000011, InternalId = 175,
        },
        new()
        {
            Identifier = "COM", RightAscension = 13.1665415, Declination = 17.52911621, Name = "42 Alp Com",
            ProperName = "", Rah = 13, Ram = 9, Ras = 59.5493999999973, InternalId = 176,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 18.97874276, Declination = -37.10708855, Name = "Eps CrA",
            ProperName = "", Rah = 18, Ram = 58, Ras = 43.4739359999977, InternalId = 177,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.10695543, Declination = -37.06275714, Name = "Gam CrA",
            ProperName = "", Rah = 19, Ram = 6, Ras = 25.0395479999974, InternalId = 178,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.15785508, Declination = -37.90423953, Name = "Alp CrA",
            ProperName = "", Rah = 19, Ram = 9, Ras = 28.2782880000034, InternalId = 179,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.13914805, Declination = -40.4966376, Name = "Del CrA",
            ProperName = "", Rah = 19, Ram = 8, Ras = 20.9329799999975, InternalId = 180,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.05189794, Declination = -42.09499443, Name = "Zet CrA",
            ProperName = "", Rah = 19, Ram = 3, Ras = 6.8325839999997, InternalId = 181,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.16715345, Declination = -39.34070677, Name = "Bet CrA",
            ProperName = "", Rah = 19, Ram = 10, Ras = 1.75242000000256, InternalId = 182,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.46384775, Declination = 29.10549164, Name = "3 Bet CrB",
            ProperName = "", Rah = 15, Ram = 27, Ras = 49.8518999999976, InternalId = 183,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.57810819, Declination = 26.71491041, Name = "5 Alp CrB",
            ProperName = "Alphekka", Rah = 15, Ram = 34, Ras = 41.1894840000001, InternalId = 184,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.5488322, Declination = 31.35915517, Name = "4 The CrB",
            ProperName = "", Rah = 15, Ram = 32, Ras = 55.7959199999988, InternalId = 185,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.71239951, Declination = 26.29551419, Name = "8 Gam CrB",
            ProperName = "", Rah = 15, Ram = 42, Ras = 44.638235999997, InternalId = 186,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.82658278, Declination = 26.06854936, Name = "10 Del CrB",
            ProperName = "", Rah = 15, Ram = 49, Ras = 35.6980080000027, InternalId = 187,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.95980608, Declination = 26.87802632, Name = "13 Eps CrB",
            ProperName = "", Rah = 15, Ram = 57, Ras = 35.3018879999998, InternalId = 188,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 16.02405295, Declination = 29.85107821, Name = "14 Iot CrB",
            ProperName = "", Rah = 16, Ram = 1, Ras = 26.5906200000055, InternalId = 189,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 10.9963191, Declination = -18.29909723, Name = "7 Alp Crt",
            ProperName = "", Rah = 10, Ram = 59, Ras = 46.748759999997, InternalId = 190,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.19430174, Declination = -22.82560642, Name = "11 Bet Crt",
            ProperName = "", Rah = 11, Ram = 11, Ras = 39.4862640000009, InternalId = 191,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.41471755, Declination = -17.68401748, Name = "15 Gam Crt",
            ProperName = "", Rah = 11, Ram = 24, Ras = 52.9831800000023, InternalId = 192,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.3223674, Declination = -14.77904358, Name = "12 Del Crt",
            ProperName = "", Rah = 11, Ram = 19, Ras = 20.5226399999971, InternalId = 193,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.41016816, Declination = -10.85938276, Name = "14 Eps Crt",
            ProperName = "", Rah = 11, Ram = 24, Ras = 36.6053759999983, InternalId = 194,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.74604415, Declination = -18.35061467, Name = "27 Zet Crt",
            ProperName = "", Rah = 11, Ram = 44, Ras = 45.7589399999982, InternalId = 195,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.61137458, Declination = -9.80225368, Name = "21 The Crt",
            ProperName = "", Rah = 11, Ram = 36, Ras = 40.9484879999989, InternalId = 196,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.93360653, Declination = -17.15080863, Name = "30 Eta Crt",
            ProperName = "", Rah = 11, Ram = 56, Ras = 0.983508000001709, InternalId = 197,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.44331705, Declination = -63.09905586, Name = "Alp 1 Cru",
            ProperName = "Acrux", Rah = 12, Ram = 26, Ras = 35.9413799999971, InternalId = 198,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.5194248, Declination = -57.11256922, Name = "Gam Cru",
            ProperName = "", Rah = 12, Ram = 31, Ras = 9.92927999999789, InternalId = 199,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.79536635, Declination = -59.68873246, Name = "Bet Cru",
            ProperName = "", Rah = 12, Ram = 47, Ras = 43.3188600000004, InternalId = 200,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.25243248, Declination = -58.74890179, Name = "Del Cru",
            ProperName = "", Rah = 12, Ram = 15, Ras = 8.75692799999825, InternalId = 201,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.14020907, Declination = -24.72877993, Name = "1 Alp Crv",
            ProperName = "", Rah = 12, Ram = 8, Ras = 24.752651999997, InternalId = 202,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.16875718, Declination = -22.61979211, Name = "2 Eps Crv",
            ProperName = "", Rah = 12, Ram = 10, Ras = 7.52584800000026, InternalId = 203,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.26346329, Declination = -17.5419837, Name = "4 Gam Crv",
            ProperName = "", Rah = 12, Ram = 15, Ras = 48.4678440000025, InternalId = 204,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.4977731, Declination = -16.51509397, Name = "7 Del Crv",
            ProperName = "", Rah = 12, Ram = 29, Ras = 51.9831599999995, InternalId = 205,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.57312057, Declination = -23.39662306, Name = "9 Bet Crv",
            ProperName = "", Rah = 12, Ram = 34, Ras = 23.2340520000014, InternalId = 206,
        },
        new()
        {
            Identifier = "CVN", RightAscension = 12.9338447, Declination = 38.31824617, Name = "12 Alp 2 CVn",
            ProperName = "", Rah = 12, Ram = 56, Ras = 1.84091999999945, InternalId = 207,
        },
        new()
        {
            Identifier = "CVN", RightAscension = 12.5625257, Declination = 41.35676779, Name = "8 Bet CVn",
            ProperName = "", Rah = 12, Ram = 33, Ras = 45.0925200000003, InternalId = 208,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.28503052, Declination = 53.36816064, Name = "1 Kap Cyg",
            ProperName = "", Rah = 19, Ram = 17, Ras = 6.10987199999786, InternalId = 209,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.49509425, Declination = 51.72946747, Name = "10 Iot 2 Cyg",
            ProperName = "", Rah = 19, Ram = 29, Ras = 42.3393000000038, InternalId = 210,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.60737289, Declination = 50.22046347, Name = "13 The Cyg",
            ProperName = "", Rah = 19, Ram = 36, Ras = 26.5424040000023, InternalId = 211,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.74956725, Declination = 45.13069195, Name = "18 Del Cyg",
            ProperName = "", Rah = 19, Ram = 44, Ras = 58.4420999999943, InternalId = 212,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.37047223, Declination = 40.2566815, Name = "37 Gam Cyg",
            ProperName = "", Rah = 20, Ram = 22, Ras = 13.7000280000027, InternalId = 213,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.93844337, Declination = 35.08349079, Name = "21 Eta Cyg",
            ProperName = "", Rah = 19, Ram = 56, Ras = 18.3961320000059, InternalId = 214,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.51261019, Declination = 27.9652789, Name = "6 Bet 2 Cyg",
            ProperName = "", Rah = 19, Ram = 30, Ras = 45.3966840000007, InternalId = 215,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.77012006, Declination = 33.96945334, Name = "53 Eps Cyg",
            ProperName = "", Rah = 20, Ram = 46, Ras = 12.4322159999998, InternalId = 216,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.69053151, Declination = 45.28033423, Name = "50 Alp Cyg",
            ProperName = "Deneb", Rah = 20, Ram = 41, Ras = 25.9134359999984, InternalId = 217,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 21.21560598, Declination = 30.22708128, Name = "64 Zet Cyg",
            ProperName = "", Rah = 21, Ram = 12, Ras = 56.1815279999979, InternalId = 218,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.55354577, Declination = 11.30333217, Name = "2 Eps Del",
            ProperName = "", Rah = 20, Ram = 33, Ras = 12.764771999998, InternalId = 219,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.62579715, Declination = 14.59520289, Name = "6 Bet Del",
            ProperName = "", Rah = 20, Ram = 37, Ras = 32.8697400000012, InternalId = 220,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.66062626, Declination = 15.9120527, Name = "9 Alp Del",
            ProperName = "", Rah = 20, Ram = 39, Ras = 38.2545360000028, InternalId = 221,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.77764388, Declination = 16.12477326, Name = "12 Gam 2 Del",
            ProperName = "", Rah = 20, Ram = 46, Ras = 39.5179679999977, InternalId = 222,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.72431825, Declination = 15.07468224, Name = "11 Del Del",
            ProperName = "", Rah = 20, Ram = 43, Ras = 27.5456999999986, InternalId = 223,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 4.26708095, Declination = -51.48709578, Name = "Gam Dor",
            ProperName = "", Rah = 4, Ram = 16, Ras = 1.49142000000155, InternalId = 224,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 4.56658845, Declination = -55.04500559, Name = "Alp Dor",
            ProperName = "", Rah = 4, Ram = 33, Ras = 59.7184200000007, InternalId = 225,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.09185843, Declination = -57.47298928, Name = "Zet Dor",
            ProperName = "", Rah = 5, Ram = 5, Ras = 30.690348000001, InternalId = 226,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.5604212, Declination = -62.48985585, Name = "Bet Dor",
            ProperName = "", Rah = 5, Ram = 33, Ras = 37.5163200000013, InternalId = 227,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.74622751, Declination = -65.7355408, Name = "Del Dor",
            ProperName = "", Rah = 5, Ram = 44, Ras = 46.4190359999993, InternalId = 228,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 11.52341346, Declination = 69.33112161, Name = "1 Lam Dra",
            ProperName = "", Rah = 11, Ram = 31, Ras = 24.2884560000014, InternalId = 229,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 12.55806736, Declination = 69.78820992, Name = "5 Kap Dra",
            ProperName = "", Rah = 12, Ram = 33, Ras = 29.0424960000027, InternalId = 230,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 14.07317389, Declination = 64.37580873, Name = "11 Alp Dra",
            ProperName = "", Rah = 14, Ram = 4, Ras = 23.4260039999987, InternalId = 231,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 15.41549558, Declination = 58.96602354, Name = "12 Iot Dra",
            ProperName = "", Rah = 15, Ram = 24, Ras = 55.7840879999998, InternalId = 232,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 16.03158437, Declination = 58.56443739, Name = "13 The Dra",
            ProperName = "", Rah = 16, Ram = 1, Ras = 53.7037320000033, InternalId = 233,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 16.39986301, Declination = 61.51407536, Name = "14 Eta Dra",
            ProperName = "", Rah = 16, Ram = 23, Ras = 59.5068360000024, InternalId = 234,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.1464514, Declination = 65.71463676, Name = "22 Zet Dra",
            ProperName = "", Rah = 17, Ram = 8, Ras = 47.2250400000004, InternalId = 235,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 18.35064971, Declination = 72.73369763, Name = "44 Chi Dra",
            ProperName = "", Rah = 18, Ram = 21, Ras = 2.33895599999649, InternalId = 236,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.5072158, Declination = 52.30135901, Name = "23 Bet Dra",
            ProperName = "", Rah = 17, Ram = 30, Ras = 25.9768800000032, InternalId = 237,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.94343829, Declination = 51.48895101, Name = "33 Gam Dra",
            ProperName = "Etamin", Rah = 17, Ram = 56, Ras = 36.3778439999984, InternalId = 238,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.53622721, Declination = 55.18411077, Name = "24 Nu 1 Dra",
            ProperName = "", Rah = 17, Ram = 32, Ras = 10.4179559999995, InternalId = 239,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.8921193, Declination = 56.87245216, Name = "32 Xi Dra",
            ProperName = "", Rah = 17, Ram = 53, Ras = 31.6294800000035, InternalId = 240,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 19.8028371, Declination = 70.26783533, Name = "63 Eps Dra",
            ProperName = "", Rah = 19, Ram = 48, Ras = 10.2135600000049, InternalId = 241,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 19.20920972, Declination = 67.66131695, Name = "57 Del Dra",
            ProperName = "", Rah = 19, Ram = 12, Ras = 33.1549920000017, InternalId = 242,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.17235307, Declination = 10.13194861, Name = "5 Gam Equ",
            ProperName = "", Rah = 21, Ram = 10, Ras = 20.4710519999992, InternalId = 243,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.26372131, Declination = 5.2480739, Name = "8 Alp Equ",
            ProperName = "", Rah = 21, Ram = 15, Ras = 49.3967160000039, InternalId = 244,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.38155049, Declination = 6.81111338, Name = "10 Bet Equ",
            ProperName = "", Rah = 21, Ram = 22, Ras = 53.5817639999952, InternalId = 245,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.24133058, Declination = 10.00771855, Name = "7 Del Equ",
            ProperName = "", Rah = 21, Ram = 14, Ras = 28.7900879999986, InternalId = 246,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 1.93245347, Declination = -51.60958673, Name = "Chi Eri",
            ProperName = "", Rah = 1, Ram = 55, Ras = 56.8324920000002, InternalId = 247,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 1.62854213, Declination = -57.23666007, Name = "Alp Eri",
            ProperName = "Achernar", Rah = 1, Ram = 37, Ras = 42.751668, InternalId = 248,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.27513896, Declination = -51.51211145, Name = "Phi Eri",
            ProperName = "", Rah = 2, Ram = 16, Ras = 30.5002560000002, InternalId = 249,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.44975138, Declination = -47.70382692, Name = "Kap Eri",
            ProperName = "", Rah = 2, Ram = 26, Ras = 59.1049679999997, InternalId = 250,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.66331092, Declination = -42.89163328, Name = "", ProperName = "",
            Rah = 2, Ram = 39, Ras = 47.9193119999992, InternalId = 251,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.6777588, Declination = -39.85530905, Name = "Iot Eri",
            ProperName = "", Rah = 2, Ram = 40, Ras = 39.9316799999997, InternalId = 252,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.75166151, Declination = -18.57265077, Name = "1 Tau 1 Eri",
            ProperName = "", Rah = 2, Ram = 45, Ras = 5.98143599999972, InternalId = 253,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.85065164, Declination = -21.0039789, Name = "2 Tau 2 Eri",
            ProperName = "", Rah = 2, Ram = 51, Ras = 2.34590400000063, InternalId = 254,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.03988697, Declination = -23.62433613, Name = "11 Tau 3 Eri",
            ProperName = "", Rah = 3, Ram = 2, Ras = 23.5930919999999, InternalId = 255,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.94044549, Declination = -8.89760976, Name = "3 Eta Eri",
            ProperName = "", Rah = 2, Ram = 56, Ras = 25.6037640000003, InternalId = 256,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.97103212, Declination = -40.30473491, Name = "The 1 Eri",
            ProperName = "", Rah = 2, Ram = 58, Ras = 15.7156319999994, InternalId = 257,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.32526935, Declination = -21.7579421, Name = "16 Tau 4 Eri",
            ProperName = "", Rah = 3, Ram = 19, Ras = 30.9696600000005, InternalId = 258,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.56312442, Declination = -21.63281597, Name = "19 Tau 5 Eri",
            ProperName = "", Rah = 3, Ram = 33, Ras = 47.2479119999993, InternalId = 259,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.33145134, Declination = -43.07154929, Name = "",
            ProperName = "82 G. Eri", Rah = 3, Ram = 19, Ras = 53.2248240000004, InternalId = 260,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.549006, Declination = -9.45830584, Name = "18 Eps Eri",
            ProperName = "", Rah = 3, Ram = 32, Ras = 56.4215999999996, InternalId = 261,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.78083028, Declination = -23.248438, Name = "27 Tau 6 Eri",
            ProperName = "", Rah = 3, Ram = 46, Ras = 50.9890079999998, InternalId = 262,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.72082113, Declination = -9.76519868, Name = "23 Del Eri",
            ProperName = "", Rah = 3, Ram = 43, Ras = 14.9560680000001, InternalId = 263,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.76902844, Declination = -12.1017353, Name = "26 Pi Eri",
            ProperName = "", Rah = 3, Ram = 46, Ras = 8.50238399999994, InternalId = 264,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.99874336, Declination = -24.01625677, Name = "36 Tau 9 Eri",
            ProperName = "", Rah = 3, Ram = 59, Ras = 55.4760960000009, InternalId = 265,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.82424469, Declination = -36.2001125, Name = "", ProperName = "",
            Rah = 3, Ram = 49, Ras = 27.2808840000001, InternalId = 251,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.96714724, Declination = -13.50824471, Name = "34 Gam Eri",
            ProperName = "", Rah = 3, Ram = 58, Ras = 1.73006400000024, InternalId = 266,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.55850819, Declination = -29.76583186, Name = "50 Ups 1 Eri",
            ProperName = "", Rah = 4, Ram = 33, Ras = 30.6294840000013, InternalId = 267,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.19775922, Declination = -6.8377787, Name = "38 Omi 1 Eri",
            ProperName = "", Rah = 4, Ram = 11, Ras = 51.9331920000001, InternalId = 268,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.29822737, Declination = -33.79833145, Name = "41 Ups 4 Eri",
            ProperName = "", Rah = 4, Ram = 17, Ras = 53.6185320000008, InternalId = 269,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.40060148, Declination = -34.01698632, Name = "43 Eri",
            ProperName = "", Rah = 4, Ram = 24, Ras = 2.16532799999896, InternalId = 270,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.59251991, Declination = -30.56231049, Name = "52 Ups 2 Eri",
            ProperName = "", Rah = 4, Ram = 35, Ras = 33.071676, InternalId = 271,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.60531682, Declination = -3.352448, Name = "48 Nu Eri",
            ProperName = "", Rah = 4, Ram = 36, Ras = 19.1405519999988, InternalId = 272,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.7583725, Declination = -3.25462465, Name = "57 Mu Eri",
            ProperName = "", Rah = 4, Ram = 45, Ras = 30.1410000000004, InternalId = 273,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.88157788, Declination = -5.45275591, Name = "61 Ome Eri",
            ProperName = "", Rah = 4, Ram = 52, Ras = 53.680368, InternalId = 274,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 5.13084276, Declination = -5.08626282, Name = "67 Bet Eri",
            ProperName = "", Rah = 5, Ram = 7, Ras = 51.0339360000006, InternalId = 275,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 5.15243971, Declination = -8.75407607, Name = "69 Lam Eri",
            ProperName = "", Rah = 5, Ram = 9, Ras = 8.78295600000124, InternalId = 276,
        },
        new()
        {
            Identifier = "FOR", RightAscension = 2.8181554, Declination = -32.40628403, Name = "Bet For",
            ProperName = "", Rah = 2, Ram = 49, Ras = 5.35944000000077, InternalId = 277,
        },
        new()
        {
            Identifier = "FOR", RightAscension = 2.07484168, Declination = -29.29683966, Name = "Nu For",
            ProperName = "", Rah = 2, Ram = 4, Ras = 29.4300480000001, InternalId = 278,
        },
        new()
        {
            Identifier = "FOR", RightAscension = 3.20118888, Declination = -28.98910623, Name = "Alp For",
            ProperName = "", Rah = 3, Ram = 12, Ras = 4.27996800000041, InternalId = 279,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.06867126, Declination = 23.26363207, Name = "1 Gem",
            ProperName = "", Rah = 6, Ram = 4, Ras = 7.21653600000124, InternalId = 280,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.2479713, Declination = 22.50682376, Name = "7 Eta Gem",
            ProperName = "", Rah = 6, Ram = 14, Ras = 52.6966799999988, InternalId = 281,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.3826642, Declination = 22.51385027, Name = "13 Mu Gem",
            ProperName = "", Rah = 6, Ram = 22, Ras = 57.5911199999993, InternalId = 282,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.73220272, Declination = 25.13115531, Name = "27 Eps Gem",
            ProperName = "", Rah = 6, Ram = 43, Ras = 55.9297920000003, InternalId = 283,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.48271957, Declination = 20.2121672, Name = "18 Nu Gem",
            ProperName = "", Rah = 6, Ram = 28, Ras = 57.7904520000015, InternalId = 284,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.18566433, Declination = 30.24528065, Name = "46 Tau Gem",
            ProperName = "", Rah = 7, Ram = 11, Ras = 8.39158799999941, InternalId = 285,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.87981668, Declination = 33.96136985, Name = "34 The Gem",
            ProperName = "", Rah = 6, Ram = 52, Ras = 47.3400480000008, InternalId = 286,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.06848205, Declination = 20.57029939, Name = "43 Zet Gem",
            ProperName = "", Rah = 7, Ram = 4, Ras = 6.53538000000026, InternalId = 287,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.62852842, Declination = 16.39941482, Name = "24 Gam Gem",
            ProperName = "Alhena", Rah = 6, Ram = 37, Ras = 42.702312000001, InternalId = 288,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.42879891, Declination = 27.79828561, Name = "60 Iot Gem",
            ProperName = "", Rah = 7, Ram = 25, Ras = 43.6760760000009, InternalId = 289,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.48516936, Declination = 31.78407932, Name = "62 Rho Gem",
            ProperName = "", Rah = 7, Ram = 29, Ras = 6.60969600000156, InternalId = 290,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.22285194, Declination = 16.15906775, Name = "51 Gem",
            ProperName = "", Rah = 7, Ram = 13, Ras = 22.2669839999999, InternalId = 291,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.75484265, Declination = 12.89605513, Name = "31 Xi Gem",
            ProperName = "", Rah = 6, Ram = 45, Ras = 17.4335399999986, InternalId = 292,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.30155744, Declination = 16.54047526, Name = "54 Lam Gem",
            ProperName = "", Rah = 7, Ram = 18, Ras = 5.60678399999948, InternalId = 293,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.33538592, Declination = 21.98233941, Name = "55 Del Gem",
            ProperName = "", Rah = 7, Ram = 20, Ras = 7.38931200000088, InternalId = 294,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.59871452, Declination = 26.89600343, Name = "69 Ups Gem",
            ProperName = "", Rah = 7, Ram = 35, Ras = 55.3722719999988, InternalId = 295,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.57666793, Declination = 31.88863645, Name = "66 Alp Gem",
            ProperName = "Castor", Rah = 7, Ram = 34, Ras = 36.0045480000006, InternalId = 296,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.74079682, Declination = 24.39812929, Name = "77 Kap Gem",
            ProperName = "", Rah = 7, Ram = 44, Ras = 26.8685519999999, InternalId = 297,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.75537884, Declination = 28.02631031, Name = "78 Bet Gem",
            ProperName = "Pollux", Rah = 7, Ram = 45, Ras = 19.3638239999988, InternalId = 298,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 21.8987928, Declination = -37.3648229, Name = "Gam Gru",
            ProperName = "", Rah = 21, Ram = 53, Ras = 55.6540799999963, InternalId = 299,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.10191767, Declination = -39.54304903, Name = "Lam Gru",
            ProperName = "", Rah = 22, Ram = 6, Ras = 6.90361199999584, InternalId = 300,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.26024577, Declination = -41.34675029, Name = "Mu 1 Gru",
            ProperName = "", Rah = 22, Ram = 15, Ras = 36.8847720000034, InternalId = 301,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.13718789, Declination = -46.96061593, Name = "Alp Gru",
            ProperName = "Alnair", Rah = 22, Ram = 8, Ras = 13.8764039999995, InternalId = 302,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.71109302, Declination = -46.88456594, Name = "Bet Gru",
            ProperName = "", Rah = 22, Ram = 42, Ras = 39.9348719999996, InternalId = 303,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.48782057, Declination = -43.49555433, Name = "Del 1 Gru",
            ProperName = "", Rah = 22, Ram = 29, Ras = 16.1540520000008, InternalId = 304,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.80922142, Declination = -51.31670354, Name = "Eps Gru",
            ProperName = "", Rah = 22, Ram = 48, Ras = 33.1971120000001, InternalId = 305,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 23.17261887, Declination = -45.24664747, Name = "Iot Gru",
            ProperName = "", Rah = 23, Ram = 10, Ras = 21.4279320000032, InternalId = 306,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 23.01468731, Declination = -52.75410562, Name = "Zet Gru",
            ProperName = "", Rah = 23, Ram = 0, Ras = 52.8743159999976, InternalId = 307,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 23.1146579, Declination = -43.52032436, Name = "The Gru",
            ProperName = "", Rah = 23, Ram = 6, Ras = 52.7684400000035, InternalId = 308,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.36534546, Declination = 19.15302185, Name = "20 Gam Her",
            ProperName = "", Rah = 16, Ram = 21, Ras = 55.2436560000013, InternalId = 309,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.50368379, Declination = 21.4896485, Name = "27 Bet Her",
            ProperName = "", Rah = 16, Ram = 30, Ras = 13.2616440000007, InternalId = 310,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.68818808, Declination = 31.60188695, Name = "40 Zet Her",
            ProperName = "", Rah = 16, Ram = 41, Ras = 17.4770879999991, InternalId = 311,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.24412845, Declination = 14.39025314, Name = "64 Alp 1 Her",
            ProperName = "Rasalgethi", Rah = 17, Ram = 14, Ras = 38.8624200000058, InternalId = 312,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.5683859, Declination = 42.43689565, Name = "35 Sig Her",
            ProperName = "", Rah = 16, Ram = 34, Ras = 6.18923999999685, InternalId = 313,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.14616647, Declination = 44.93481883, Name = "11 Phi Her",
            ProperName = "", Rah = 16, Ram = 8, Ras = 46.1992920000026, InternalId = 314,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.71492737, Declination = 38.92246103, Name = "44 Eta Her",
            ProperName = "", Rah = 16, Ram = 42, Ras = 53.738532000006, InternalId = 315,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.00483505, Declination = 30.92633926, Name = "58 Eps Her",
            ProperName = "", Rah = 17, Ram = 0, Ras = 17.4061800000018, InternalId = 316,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.25079285, Declination = 36.80915527, Name = "67 Pi Her",
            ProperName = "", Rah = 17, Ram = 15, Ras = 2.85425999999944, InternalId = 317,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.25053449, Declination = 24.83958739, Name = "65 Del Her",
            ProperName = "", Rah = 17, Ram = 15, Ras = 1.924163999999, InternalId = 318,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.512305, Declination = 26.1106045, Name = "76 Lam Her",
            ProperName = "", Rah = 17, Ram = 30, Ras = 44.2980000000048, InternalId = 319,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.39471468, Declination = 37.14592396, Name = "75 Rho Her",
            ProperName = "", Rah = 17, Ram = 23, Ras = 40.9728479999995, InternalId = 320,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.93754959, Declination = 37.25052158, Name = "91 The Her",
            ProperName = "", Rah = 17, Ram = 56, Ras = 15.1785239999989, InternalId = 321,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.77436636, Declination = 27.72249917, Name = "86 Mu Her",
            ProperName = "", Rah = 17, Ram = 46, Ras = 27.7188959999939, InternalId = 322,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.96273073, Declination = 29.24792527, Name = "92 Xi Her",
            ProperName = "", Rah = 17, Ram = 57, Ras = 45.8306280000021, InternalId = 323,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.65774789, Declination = 46.00632216, Name = "85 Iot Her",
            ProperName = "", Rah = 17, Ram = 39, Ras = 27.8924039999983, InternalId = 324,
        },
        new()
        {
            Identifier = "HER", RightAscension = 18.12570854, Declination = 28.76247025, Name = "103 Omi Her",
            ProperName = "", Rah = 18, Ram = 7, Ras = 32.5507440000055, InternalId = 325,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.97504159, Declination = 30.18926892, Name = "94 Nu Her",
            ProperName = "", Rah = 17, Ram = 58, Ras = 30.149724, InternalId = 326,
        },
        new()
        {
            Identifier = "HER", RightAscension = 18.39493521, Declination = 21.77034249, Name = "109 Her",
            ProperName = "", Rah = 18, Ram = 23, Ras = 41.7667559999994, InternalId = 327,
        },
        new()
        {
            Identifier = "HER", RightAscension = 18.14597017, Declination = 20.81457203, Name = "102 Her",
            ProperName = "", Rah = 18, Ram = 8, Ras = 45.4926119999936, InternalId = 328,
        },
        new()
        {
            Identifier = "HER", RightAscension = 18.76103644, Declination = 20.54712356, Name = "110 Her",
            ProperName = "", Rah = 18, Ram = 45, Ras = 39.7311840000057, InternalId = 329,
        },
        new()
        {
            Identifier = "HER", RightAscension = 18.78367287, Declination = 18.18122968, Name = "111 Her",
            ProperName = "", Rah = 18, Ram = 47, Ras = 1.2223320000007, InternalId = 330,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.6234069, Declination = -52.54308845, Name = "Eta Hor",
            ProperName = "", Rah = 2, Ram = 37, Ras = 24.2648399999998, InternalId = 331,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.70921068, Declination = -50.80082665, Name = "Iot Hor",
            ProperName = "", Rah = 2, Ram = 42, Ras = 33.1584480000001, InternalId = 332,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.67766108, Declination = -54.54992422, Name = "Zet Hor",
            ProperName = "", Rah = 2, Ram = 40, Ras = 39.5798880000002, InternalId = 333,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 4.23335592, Declination = -42.29387294, Name = "Alp Hor",
            ProperName = "", Rah = 4, Ram = 14, Ras = 0.0813120000005663, InternalId = 334,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.979935, Declination = -64.07129717, Name = "Bet Hor",
            ProperName = "", Rah = 2, Ram = 58, Ras = 47.7659999999992, InternalId = 335,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 3.06025103, Declination = -59.73761994, Name = "Mu Hor",
            ProperName = "", Rah = 3, Ram = 3, Ras = 36.9037079999995, InternalId = 336,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.17649919, Declination = -12.35383921, Name = "41 Lam Hya",
            ProperName = "", Rah = 10, Ram = 10, Ras = 35.3970839999981, InternalId = 337,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.85796735, Declination = -14.84654997, Name = "39 Ups 1 Hya",
            ProperName = "", Rah = 9, Ram = 51, Ras = 28.6824599999969, InternalId = 338,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.43486251, Declination = -16.83609584, Name = "42 Mu Hya",
            ProperName = "", Rah = 10, Ram = 26, Ras = 5.50503600000107, InternalId = 339,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.82706446, Declination = -16.19413208, Name = "Nu Hya",
            ProperName = "", Rah = 10, Ram = 49, Ras = 37.4320560000029, InternalId = 340,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 11.55007195, Declination = -31.85752405, Name = "Xi Hya",
            ProperName = "", Rah = 11, Ram = 33, Ras = 0.259019999998156, InternalId = 341,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 11.88182257, Declination = -33.90813014, Name = "Bet Hya",
            ProperName = "", Rah = 11, Ram = 52, Ras = 54.5612520000022, InternalId = 342,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 13.31534816, Declination = -23.17141246, Name = "46 Gam Hya",
            ProperName = "", Rah = 13, Ram = 18, Ras = 55.2533759999972, InternalId = 343,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 14.10618582, Declination = -26.68201883, Name = "49 Pi Hya",
            ProperName = "", Rah = 14, Ram = 6, Ras = 22.2689520000011, InternalId = 344,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.62761315, Declination = 5.70379868, Name = "4 Del Hya",
            ProperName = "", Rah = 8, Ram = 37, Ras = 39.4073400000005, InternalId = 345,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.64595799, Declination = 3.34147477, Name = "5 Sig Hya",
            ProperName = "", Rah = 8, Ram = 38, Ras = 45.448763999998, InternalId = 346,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.72041287, Declination = 3.39866539, Name = "7 Eta Hya",
            ProperName = "", Rah = 8, Ram = 43, Ras = 13.4863320000019, InternalId = 347,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.92324579, Declination = 5.9455277, Name = "16 Zet Hya",
            ProperName = "", Rah = 8, Ram = 55, Ras = 23.6848439999976, InternalId = 348,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.77962395, Declination = 6.41890691, Name = "11 Eps Hya",
            ProperName = "", Rah = 8, Ram = 46, Ras = 46.6462199999981, InternalId = 349,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.23938701, Declination = 2.31502422, Name = "22 The Hya",
            ProperName = "", Rah = 9, Ram = 14, Ras = 21.793235999999, InternalId = 350,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.45979217, Declination = -8.65868335, Name = "30 Alp Hya",
            ProperName = "Alphard", Rah = 9, Ram = 27, Ras = 35.2518120000002, InternalId = 351,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.66425943, Declination = -1.14265722, Name = "35 Iot Hya",
            ProperName = "", Rah = 9, Ram = 39, Ras = 51.3339479999983, InternalId = 352,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 0.42755612, Declination = -77.25503511, Name = "Bet Hyi",
            ProperName = "", Rah = 0, Ram = 25, Ras = 39.2020319999999, InternalId = 353,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 3.78728653, Declination = -74.23924251, Name = "Gam Hyi",
            ProperName = "", Rah = 3, Ram = 47, Ras = 14.2315079999994, InternalId = 354,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 1.97940884, Declination = -61.56992444, Name = "Alp Hyi",
            ProperName = "", Rah = 1, Ram = 58, Ras = 45.8718240000002, InternalId = 355,
        },
        new()
        {
            Identifier = "IND", RightAscension = 20.91349433, Declination = -58.4540947, Name = "Bet Ind",
            ProperName = "", Rah = 20, Ram = 54, Ras = 48.579587999996, InternalId = 356,
        },
        new()
        {
            Identifier = "IND", RightAscension = 21.33107883, Declination = -53.44926434, Name = "The Ind",
            ProperName = "", Rah = 21, Ram = 19, Ras = 51.883787999997, InternalId = 357,
        },
        new()
        {
            Identifier = "IND", RightAscension = 20.62610824, Declination = -47.29166239, Name = "Alp Ind",
            ProperName = "", Rah = 20, Ram = 37, Ras = 33.9896640000022, InternalId = 358,
        },
        new()
        {
            Identifier = "IND", RightAscension = 21.96528638, Declination = -54.9925666, Name = "Del Ind",
            ProperName = "", Rah = 21, Ram = 57, Ras = 55.0309679999946, InternalId = 359,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.26615838, Declination = 37.74873483, Name = "1 Lac",
            ProperName = "", Rah = 22, Ram = 15, Ras = 58.1701680000009, InternalId = 360,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.50812822, Declination = 43.12338985, Name = "6 Lac",
            ProperName = "", Rah = 22, Ram = 30, Ras = 29.2615919999989, InternalId = 361,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.35042452, Declination = 46.53656484, Name = "2 Lac",
            ProperName = "", Rah = 22, Ram = 21, Ras = 1.52827200000254, InternalId = 362,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.49217298, Declination = 47.70689488, Name = "5 Lac",
            ProperName = "", Rah = 22, Ram = 29, Ras = 31.8227279999979, InternalId = 363,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.40860992, Declination = 49.47640074, Name = "4 Lac",
            ProperName = "", Rah = 22, Ram = 24, Ras = 30.9957119999998, InternalId = 364,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.52149326, Declination = 50.28244976, Name = "7 Alp Lac",
            ProperName = "", Rah = 22, Ram = 31, Ras = 17.3757359999989, InternalId = 365,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.39267678, Declination = 52.22949951, Name = "3 Bet Lac",
            ProperName = "", Rah = 22, Ram = 23, Ras = 33.6364079999949, InternalId = 366,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.12220929, Declination = 16.76266572, Name = "30 Eta Leo",
            ProperName = "", Rah = 10, Ram = 7, Ras = 19.9534440000025, InternalId = 367,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.13957205, Declination = 11.96719513, Name = "32 Alp Leo",
            ProperName = "Regulus", Rah = 10, Ram = 8, Ras = 22.4593799999998, InternalId = 368,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.23734469, Declination = 15.4297631, Name = "70 The Leo",
            ProperName = "", Rah = 11, Ram = 14, Ras = 14.4408840000017, InternalId = 369,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.27816787, Declination = 23.4173284, Name = "36 Zet Leo",
            ProperName = "", Rah = 10, Ram = 16, Ras = 41.4043320000028, InternalId = 370,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 9.87943268, Declination = 26.00708498, Name = "24 Mu Leo",
            ProperName = "", Rah = 9, Ram = 52, Ras = 45.9576480000026, InternalId = 371,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.3328227, Declination = 19.84186032, Name = "41 Gam 1 Leo",
            ProperName = "Algieba", Rah = 10, Ram = 19, Ras = 58.1617199999982, InternalId = 372,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.23511447, Declination = 20.52403384, Name = "68 Del Leo",
            ProperName = "", Rah = 11, Ram = 14, Ras = 6.41209199999706, InternalId = 373,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.81774398, Declination = 14.57233687, Name = "94 Bet Leo",
            ProperName = "Denebola", Rah = 11, Ram = 49, Ras = 3.87832799999819, InternalId = 374,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.35229115, Declination = 6.02935289, Name = "77 Sig Leo",
            ProperName = "", Rah = 11, Ram = 21, Ras = 8.24813999999727, InternalId = 375,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.39871355, Declination = 10.52969772, Name = "78 Iot Leo",
            ProperName = "", Rah = 11, Ram = 23, Ras = 55.3687800000002, InternalId = 376,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 9.68586607, Declination = 9.89239902, Name = "14 Omi Leo",
            ProperName = "", Rah = 9, Ram = 41, Ras = 9.11785199999793, InternalId = 377,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 9.76419511, Declination = 23.77427792, Name = "17 Eps Leo",
            ProperName = "", Rah = 9, Ram = 45, Ras = 51.1023959999974, InternalId = 378,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.47075731, Declination = -20.75923214, Name = "9 Bet Lep",
            ProperName = "Nihal", Rah = 5, Ram = 28, Ras = 14.7263159999991, InternalId = 379,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.09101447, Declination = -22.37085673, Name = "2 Eps Lep",
            ProperName = "", Rah = 5, Ram = 5, Ras = 27.6520920000007, InternalId = 380,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.54550386, Declination = -17.82229227, Name = "11 Alp Lep",
            ProperName = "Arneb", Rah = 5, Ram = 32, Ras = 43.8138960000007, InternalId = 381,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.2155203, Declination = -16.20542901, Name = "5 Mu Lep",
            ProperName = "", Rah = 5, Ram = 12, Ras = 55.8730799999988, InternalId = 382,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.74110416, Declination = -22.44748663, Name = "13 Gam Lep",
            ProperName = "", Rah = 5, Ram = 44, Ras = 27.9749759999998, InternalId = 383,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.78259715, Declination = -14.82194717, Name = "14 Zet Lep",
            ProperName = "", Rah = 5, Ram = 46, Ras = 57.3497399999997, InternalId = 384,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.85532022, Declination = -20.87751376, Name = "15 Del Lep",
            ProperName = "", Rah = 5, Ram = 51, Ras = 19.1527920000011, InternalId = 385,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.94008841, Declination = -14.16803805, Name = "16 Eta Lep",
            ProperName = "", Rah = 5, Ram = 56, Ras = 24.3182760000015, InternalId = 386,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 14.84479547, Declination = -15.99709226, Name = "8 Alp 1 Lib",
            ProperName = "", Rah = 14, Ram = 50, Ras = 41.2636919999974, InternalId = 387,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.06785052, Declination = -25.28185602, Name = "20 Sig Lib",
            ProperName = "", Rah = 15, Ram = 4, Ras = 4.26187200000129, InternalId = 388,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.61707183, Declination = -28.13507099, Name = "39 Ups Lib",
            ProperName = "", Rah = 15, Ram = 37, Ras = 1.45858800000145, InternalId = 389,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.28346439, Declination = -9.38286694, Name = "27 Bet Lib",
            ProperName = "", Rah = 15, Ram = 17, Ras = 0.471804000002463, InternalId = 390,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.59209426, Declination = -14.78955365, Name = "38 Gam Lib",
            ProperName = "", Rah = 15, Ram = 35, Ras = 31.5393359999986, InternalId = 391,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.64427343, Declination = -29.77768935, Name = "40 Tau Lib",
            ProperName = "", Rah = 15, Ram = 38, Ras = 39.3843480000006, InternalId = 392,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.89707695, Declination = -16.7296223, Name = "46 The Lib",
            ProperName = "", Rah = 15, Ram = 53, Ras = 49.4770200000024, InternalId = 393,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.96982674, Declination = -14.27931773, Name = "48 Lib",
            ProperName = "", Rah = 15, Ram = 58, Ras = 11.3762640000008, InternalId = 394,
        },
        new()
        {
            Identifier = "LMI", RightAscension = 10.12381254, Declination = 35.24469176, Name = "21 LMi",
            ProperName = "", Rah = 10, Ram = 7, Ras = 25.7251439999979, InternalId = 395,
        },
        new()
        {
            Identifier = "LMI", RightAscension = 10.46474791, Declination = 36.70747818, Name = "31 Bet LMi",
            ProperName = "", Rah = 10, Ram = 27, Ras = 53.0924759999993, InternalId = 396,
        },
        new()
        {
            Identifier = "LMI", RightAscension = 10.88851107, Declination = 34.21556641, Name = "46 LMi",
            ProperName = "", Rah = 10, Ram = 53, Ras = 18.6398519999996, InternalId = 397,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 14.69882606, Declination = -47.38814127, Name = "Alp Lup",
            ProperName = "", Rah = 14, Ram = 41, Ras = 55.773816, InternalId = 398,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.20477865, Declination = -52.09907465, Name = "Zet Lup",
            ProperName = "", Rah = 15, Ram = 12, Ras = 17.203139999999, InternalId = 399,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 14.97554279, Declination = -43.13386699, Name = "Bet Lup",
            ProperName = "", Rah = 14, Ram = 58, Ras = 31.9540440000015, InternalId = 400,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.19893362, Declination = -48.73770212, Name = "Kap 1 Lup",
            ProperName = "", Rah = 15, Ram = 11, Ras = 56.1610320000002, InternalId = 401,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.37802431, Declination = -44.68957314, Name = "Eps Lup",
            ProperName = "", Rah = 15, Ram = 22, Ras = 40.8875160000026, InternalId = 402,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.35620455, Declination = -40.64745946, Name = "Del Lup",
            ProperName = "", Rah = 15, Ram = 21, Ras = 22.3363799999975, InternalId = 403,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.58568343, Declination = -41.16669497, Name = "Gam Lup",
            ProperName = "", Rah = 15, Ram = 35, Ras = 8.46034799999829, InternalId = 404,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.36345457, Declination = -36.26116729, Name = "Phi 1 Lup",
            ProperName = "", Rah = 15, Ram = 21, Ras = 48.4364520000002, InternalId = 405,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 16.00203902, Declination = -38.39664079, Name = "Eta Lup",
            ProperName = "", Rah = 16, Ram = 0, Ras = 7.3404720000056, InternalId = 406,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.84931715, Declination = -33.62710488, Name = "5 Chi Lup",
            ProperName = "", Rah = 15, Ram = 50, Ras = 57.5417399999969, InternalId = 407,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 16.10987675, Declination = -36.80221297, Name = "The Lup",
            ProperName = "", Rah = 16, Ram = 6, Ras = 35.5563000000055, InternalId = 408,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 6.9546107, Declination = 58.42305973, Name = "15 Lyn",
            ProperName = "", Rah = 6, Ram = 57, Ras = 16.5985199999999, InternalId = 409,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 6.32705299, Declination = 59.01090518, Name = "2 Lyn",
            ProperName = "", Rah = 6, Ram = 19, Ras = 37.3907640000012, InternalId = 410,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 7.44523915, Declination = 49.21164489, Name = "21 Lyn",
            ProperName = "", Rah = 7, Ram = 26, Ras = 42.8609399999996, InternalId = 411,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 8.38059169, Declination = 43.18837233, Name = "31 Lyn",
            ProperName = "", Rah = 8, Ram = 22, Ras = 50.1300839999974, InternalId = 412,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 9.31407426, Declination = 36.80289763, Name = "38 Lyn",
            ProperName = "", Rah = 9, Ram = 18, Ras = 50.6673359999998, InternalId = 413,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 9.35096077, Declination = 34.39252592, Name = "40 Alp Lyn",
            ProperName = "", Rah = 9, Ram = 21, Ras = 3.4587720000014, InternalId = 414,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.33103366, Declination = 36.06444696, Name = "1 Kap Lyr",
            ProperName = "", Rah = 18, Ram = 19, Ras = 51.7211759999973, InternalId = 415,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.61560722, Declination = 38.78299311, Name = "3 Alp Lyr",
            ProperName = "Vega", Rah = 18, Ram = 36, Ras = 56.1859920000041, InternalId = 416,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.7462044, Declination = 37.60505025, Name = "6 Zet 1 Lyr",
            ProperName = "", Rah = 18, Ram = 44, Ras = 46.3358399999997, InternalId = 417,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.73965995, Declination = 39.61259557, Name = "5 Eps 2 Lyr",
            ProperName = "", Rah = 18, Ram = 44, Ras = 22.7758200000004, InternalId = 418,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.83466497, Declination = 33.36267788, Name = "10 Bet Lyr",
            ProperName = "", Rah = 18, Ram = 50, Ras = 4.79389199999489, InternalId = 419,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.98239571, Declination = 32.68955312, Name = "14 Gam Lyr",
            ProperName = "", Rah = 18, Ram = 58, Ras = 56.6245559999953, InternalId = 420,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.89543292, Declination = 36.97172755, Name = "11 Del 1 Lyr",
            ProperName = "", Rah = 18, Ram = 53, Ras = 43.558512000004, InternalId = 421,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.74671939, Declination = 37.59456466, Name = "7 Zet 2 Lyr",
            ProperName = "", Rah = 18, Ram = 44, Ras = 48.1898039999969, InternalId = 422,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 4.91976102, Declination = -74.93700232, Name = "Eta Men",
            ProperName = "", Rah = 4, Ram = 55, Ras = 11.1396720000007, InternalId = 423,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 5.53129495, Declination = -76.3416634, Name = "Gam Men",
            ProperName = "", Rah = 5, Ram = 31, Ras = 52.6618200000012, InternalId = 424,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 5.04527913, Declination = -71.31432608, Name = "Bet Men",
            ProperName = "", Rah = 5, Ram = 2, Ras = 43.0048679999998, InternalId = 425,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 6.17061203, Declination = -74.7525279, Name = "Alp Men",
            ProperName = "", Rah = 6, Ram = 10, Ras = 14.2033080000001, InternalId = 426,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 20.83279986, Declination = -33.7796732, Name = "Alp Mic",
            ProperName = "", Rah = 20, Ram = 49, Ras = 58.0794960000055, InternalId = 427,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 21.02151713, Declination = -32.25776681, Name = "Gam Mic",
            ProperName = "", Rah = 21, Ram = 1, Ras = 17.461667999998, InternalId = 428,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 21.29895737, Declination = -32.17248551, Name = "Eps Mic",
            ProperName = "", Rah = 21, Ram = 17, Ras = 56.2465320000004, InternalId = 429,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 21.34599543, Declination = -40.80950852, Name = "The 1 Mic",
            ProperName = "", Rah = 21, Ram = 20, Ras = 45.5835479999948, InternalId = 430,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.24759346, Declination = -6.27472737, Name = "5 Gam Mon",
            ProperName = "", Rah = 6, Ram = 14, Ras = 51.3364560000001, InternalId = 431,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.48029836, Declination = -7.03305042, Name = "11 Bet Mon",
            ProperName = "", Rah = 6, Ram = 28, Ras = 49.0740959999997, InternalId = 432,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.39613824, Declination = 4.59283881, Name = "8 Eps Mon",
            ProperName = "", Rah = 6, Ram = 23, Ras = 46.0976639999998, InternalId = 433,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.5483971, Declination = 7.33297921, Name = "13 Mon",
            ProperName = "", Rah = 6, Ram = 32, Ras = 54.2295599999995, InternalId = 434,
        },
        new()
        {
            Identifier = "MON", RightAscension = 7.19773899, Declination = -0.49278056, Name = "22 Del Mon",
            ProperName = "", Rah = 7, Ram = 11, Ras = 51.8603640000015, InternalId = 435,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.79768245, Declination = 2.41218914, Name = "18 Mon",
            ProperName = "", Rah = 6, Ram = 47, Ras = 51.6568199999998, InternalId = 436,
        },
        new()
        {
            Identifier = "MON", RightAscension = 7.68746574, Declination = -9.55108315, Name = "26 Alp Mon",
            ProperName = "", Rah = 7, Ram = 41, Ras = 14.8766640000013, InternalId = 437,
        },
        new()
        {
            Identifier = "MON", RightAscension = 8.14323824, Declination = -2.98377649, Name = "29 Zet Mon",
            ProperName = "", Rah = 8, Ram = 8, Ras = 35.6576640000019, InternalId = 438,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 11.80402484, Declination = -66.81487085, Name = "Mu Mus",
            ProperName = "", Rah = 11, Ram = 48, Ras = 14.4894240000009, InternalId = 439,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.29295453, Declination = -67.96067161, Name = "Eps Mus",
            ProperName = "", Rah = 12, Ram = 17, Ras = 34.6363079999978, InternalId = 440,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.61974547, Declination = -69.13553358, Name = "Alp Mus",
            ProperName = "", Rah = 12, Ram = 37, Ras = 11.0836919999992, InternalId = 441,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.54114193, Declination = -72.1329759, Name = "Gam Mus",
            ProperName = "", Rah = 12, Ram = 32, Ras = 28.1109480000008, InternalId = 442,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.77135267, Declination = -68.10809405, Name = "Bet Mus",
            ProperName = "", Rah = 12, Ram = 46, Ras = 16.8696120000021, InternalId = 443,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 13.03771597, Declination = -71.54879865, Name = "Del Mus",
            ProperName = "", Rah = 13, Ram = 2, Ras = 15.7774920000026, InternalId = 444,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.05357227, Declination = -49.22972074, Name = "Eta Nor",
            ProperName = "", Rah = 16, Ram = 3, Ras = 12.8601720000003, InternalId = 445,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.33071322, Declination = -50.15537923, Name = "Gam 2 Nor",
            ProperName = "", Rah = 16, Ram = 19, Ras = 50.5675919999994, InternalId = 446,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.28359319, Declination = -50.06811224, Name = "Gam 1 Nor",
            ProperName = "", Rah = 16, Ram = 17, Ras = 0.935484000004605, InternalId = 447,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.45306883, Declination = -47.5547359, Name = "Eps Nor",
            ProperName = "", Rah = 16, Ram = 27, Ras = 11.0477879999979, InternalId = 448,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 14.44881687, Declination = -83.66785308, Name = "Del Oct",
            ProperName = "", Rah = 14, Ram = 26, Ras = 55.7407319999997, InternalId = 449,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 22.76770092, Declination = -81.38161731, Name = "Bet Oct",
            ProperName = "", Rah = 22, Ram = 46, Ras = 3.72331199999745, InternalId = 450,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 22.3337445, Declination = -80.43964301, Name = "Eps Oct",
            ProperName = "", Rah = 22, Ram = 20, Ras = 1.48020000000606, InternalId = 451,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 21.69124253, Declination = -77.38946215, Name = "Nu Oct",
            ProperName = "", Rah = 21, Ram = 41, Ras = 28.4731080000008, InternalId = 452,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.23910173, Declination = -3.69397562, Name = "1 Del Oph",
            ProperName = "", Rah = 16, Ram = 14, Ras = 20.7662280000056, InternalId = 453,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.96118627, Declination = 9.37505626, Name = "27 Kap Oph",
            ProperName = "", Rah = 16, Ram = 57, Ras = 40.2705719999962, InternalId = 454,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.30534466, Declination = -4.69260809, Name = "2 Eps Oph",
            ProperName = "", Rah = 16, Ram = 18, Ras = 19.2407759999978, InternalId = 455,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.61931389, Declination = -10.5671518, Name = "13 Zet Oph",
            ProperName = "", Rah = 16, Ram = 37, Ras = 9.53000400000281, InternalId = 456,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.58222354, Declination = 12.56057584, Name = "55 Alp Oph",
            ProperName = "Rasalhague", Rah = 17, Ram = 34, Ras = 56.004744000004, InternalId = 457,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.17296177, Declination = -15.72514757, Name = "35 Eta Oph",
            ProperName = "", Rah = 17, Ram = 10, Ras = 22.6623720000021, InternalId = 458,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.35005841, Declination = -21.11243499, Name = "40 Xi Oph",
            ProperName = "", Rah = 17, Ram = 21, Ras = 0.210275999996634, InternalId = 459,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.36682891, Declination = -24.99948797, Name = "42 The Oph",
            ProperName = "", Rah = 17, Ram = 22, Ras = 0.584075999995926, InternalId = 460,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.43950482, Declination = -24.17502346, Name = "44 Oph",
            ProperName = "", Rah = 17, Ram = 26, Ras = 22.2173519999992, InternalId = 461,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.45590667, Declination = -29.86669942, Name = "45 Oph",
            ProperName = "", Rah = 17, Ram = 27, Ras = 21.2640120000034, InternalId = 462,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.72454914, Declination = 4.56691684, Name = "60 Bet Oph",
            ProperName = "", Rah = 17, Ram = 43, Ras = 28.3769040000021, InternalId = 463,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.79821501, Declination = 2.70745875, Name = "62 Gam Oph",
            ProperName = "", Rah = 17, Ram = 47, Ras = 53.5740359999994, InternalId = 464,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.9837771, Declination = -9.77334973, Name = "64 Nu Oph",
            ProperName = "", Rah = 17, Ram = 59, Ras = 1.59756000000404, InternalId = 465,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 18.01075431, Declination = 2.93158759, Name = "67 Oph",
            ProperName = "", Rah = 18, Ram = 0, Ras = 38.7155159999978, InternalId = 466,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 18.09089245, Declination = 2.50243928, Name = "70 Oph",
            ProperName = "", Rah = 18, Ram = 5, Ras = 27.2128199999941, InternalId = 467,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.83059395, Declination = 6.96124744, Name = "1 Pi 3 Ori",
            ProperName = "", Rah = 4, Ram = 49, Ras = 50.1382199999997, InternalId = 468,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.853435, Declination = 5.60510146, Name = "3 Pi 4 Ori",
            ProperName = "", Rah = 4, Ram = 51, Ras = 12.3660000000007, InternalId = 469,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.41885227, Declination = 6.34973451, Name = "24 Gam Ori",
            ProperName = "Bellatrix", Rah = 5, Ram = 25, Ras = 7.86817200000123, InternalId = 470,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.84353396, Declination = 8.90025258, Name = "2 Pi 2 Ori",
            ProperName = "", Rah = 4, Ram = 50, Ras = 36.7222560000008, InternalId = 471,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.90419323, Declination = 2.44067149, Name = "8 Pi 5 Ori",
            ProperName = "", Rah = 4, Ram = 54, Ras = 15.095627999999, InternalId = 472,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.97580635, Declination = 1.71403506, Name = "10 Pi 6 Ori",
            ProperName = "", Rah = 4, Ram = 58, Ras = 32.9028600000001, InternalId = 473,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.91491781, Declination = 10.15114511, Name = "7 Pi 1 Ori",
            ProperName = "", Rah = 4, Ram = 54, Ras = 53.7041160000013, InternalId = 474,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.24229756, Declination = -8.20163919, Name = "19 Bet Ori",
            ProperName = "Rigel", Rah = 5, Ram = 14, Ras = 32.2712159999997, InternalId = 475,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.79594109, Declination = -9.66960186, Name = "53 Kap Ori",
            ProperName = "Saiph", Rah = 5, Ram = 47, Ras = 45.3879240000013, InternalId = 476,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.53344437, Declination = -0.2990934, Name = "34 Del Ori",
            ProperName = "", Rah = 5, Ram = 32, Ras = 0.399731999999231, InternalId = 477,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.58563269, Declination = 9.93416294, Name = "39 Lam Ori",
            ProperName = "", Rah = 5, Ram = 35, Ras = 8.27768399999891, InternalId = 478,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.67931244, Declination = -1.94257841, Name = "50 Zet Ori",
            ProperName = "Alnitak", Rah = 5, Ram = 40, Ras = 45.5247840000014, InternalId = 479,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.91952477, Declination = 7.40703634, Name = "58 Alp Ori",
            ProperName = "Betelgeuse", Rah = 5, Ram = 55, Ras = 10.2891719999993, InternalId = 480,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.03971954, Declination = 9.64736756, Name = "61 Mu Ori",
            ProperName = "", Rah = 6, Ram = 2, Ras = 22.9903440000004, InternalId = 481,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.1989991, Declination = 14.20881425, Name = "70 Xi Ori",
            ProperName = "", Rah = 6, Ram = 11, Ras = 56.39676, InternalId = 482,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.12620051, Declination = 14.76852318, Name = "67 Nu Ori",
            ProperName = "", Rah = 6, Ram = 7, Ras = 34.3218360000011, InternalId = 483,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.06532876, Declination = 20.13845865, Name = "62 Chi 2 Ori",
            ProperName = "", Rah = 6, Ram = 3, Ras = 55.1835359999995, InternalId = 484,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.20037193, Declination = 19.79057155, Name = "68 Ori",
            ProperName = "", Rah = 6, Ram = 12, Ras = 1.33894800000067, InternalId = 485,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 17.76222289, Declination = -64.7237345, Name = "Eta Pav",
            ProperName = "", Rah = 17, Ram = 45, Ras = 44.0024040000011, InternalId = 486,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.14299745, Declination = -63.66804844, Name = "Pi Pav",
            ProperName = "", Rah = 18, Ram = 8, Ras = 34.7908199999975, InternalId = 487,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.38711682, Declination = -61.49390506, Name = "Xi Pav",
            ProperName = "", Rah = 18, Ram = 23, Ras = 13.6205519999972, InternalId = 488,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.87028792, Declination = -62.18756062, Name = "Lam Pav",
            ProperName = "", Rah = 18, Ram = 52, Ras = 13.0365119999967, InternalId = 489,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.71725939, Declination = -71.42772867, Name = "Zet Pav",
            ProperName = "", Rah = 18, Ram = 43, Ras = 2.13380399999576, InternalId = 490,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.14496114, Declination = -66.17932101, Name = "Del Pav",
            ProperName = "", Rah = 20, Ram = 8, Ras = 41.8601039999982, InternalId = 491,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.00983148, Declination = -72.91018443, Name = "Eps Pav",
            ProperName = "", Rah = 20, Ram = 0, Ras = 35.3933279999964, InternalId = 492,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.74932102, Declination = -66.20323826, Name = "Bet Pav",
            ProperName = "", Rah = 20, Ram = 44, Ras = 57.5556720000002, InternalId = 493,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.42745823, Declination = -56.73488071, Name = "Alp Pav",
            ProperName = "", Rah = 20, Ram = 25, Ras = 38.8496279999969, InternalId = 494,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 21.44069225, Declination = -65.36814438, Name = "Gam Pav",
            ProperName = "", Rah = 21, Ram = 26, Ras = 26.4921000000052, InternalId = 495,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.73642787, Declination = 9.87500791, Name = "8 Eps Peg",
            ProperName = "Enif", Rah = 21, Ram = 44, Ras = 11.1403320000001, InternalId = 496,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.16994993, Declination = 6.197789, Name = "26 The Peg",
            ProperName = "", Rah = 22, Ram = 10, Ras = 11.8197480000049, InternalId = 497,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.11679848, Declination = 25.3450461, Name = "24 Iot Peg",
            ProperName = "", Rah = 22, Ram = 7, Ras = 0.47452799999973, InternalId = 498,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.7440845, Declination = 25.64500284, Name = "10 Kap Peg",
            ProperName = "", Rah = 21, Ram = 44, Ras = 38.7041999999987, InternalId = 499,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.69102078, Declination = 10.83139111, Name = "42 Zet Peg",
            ProperName = "", Rah = 22, Ram = 41, Ras = 27.6748079999956, InternalId = 500,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.77817819, Declination = 12.17408381, Name = "46 Xi Peg",
            ProperName = "", Rah = 22, Ram = 46, Ras = 41.4414839999942, InternalId = 501,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.71670238, Declination = 30.22130866, Name = "44 Eta Peg",
            ProperName = "", Rah = 22, Ram = 43, Ras = 0.128568000003471, InternalId = 502,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.77551177, Declination = 23.56567939, Name = "47 Lam Peg",
            ProperName = "", Rah = 22, Ram = 46, Ras = 31.8423720000048, InternalId = 503,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.74185847, Declination = 17.35004352, Name = "9 Peg",
            ProperName = "", Rah = 21, Ram = 44, Ras = 30.6904920000016, InternalId = 504,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.07933801, Declination = 15.20536786, Name = "54 Alp Peg",
            ProperName = "Markab", Rah = 23, Ram = 4, Ras = 45.6168360000026, InternalId = 505,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.8333612, Declination = 24.60168486, Name = "48 Mu Peg",
            ProperName = "", Rah = 22, Ram = 50, Ras = 0.100319999995557, InternalId = 506,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.06287038, Declination = 28.08245462, Name = "53 Bet Peg",
            ProperName = "Scheat", Rah = 23, Ram = 3, Ras = 46.3333679999988, InternalId = 507,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 0.22059721, Declination = 15.18361593, Name = "88 Gam Peg",
            ProperName = "Algenib", Rah = 0, Ram = 13, Ras = 14.1499559999999, InternalId = 508,
        },
        new()
        {
            Identifier = "PER", RightAscension = 2.8951606, Declination = 38.33767914, Name = "20 Per",
            ProperName = "", Rah = 2, Ram = 53, Ras = 42.5781600000004, InternalId = 509,
        },
        new()
        {
            Identifier = "PER", RightAscension = 2.84303172, Declination = 38.31890838, Name = "16 Per",
            ProperName = "", Rah = 2, Ram = 50, Ras = 34.9141919999996, InternalId = 510,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.07994173, Declination = 53.50645031, Name = "23 Gam Per",
            ProperName = "", Rah = 3, Ram = 4, Ras = 47.7902279999994, InternalId = 511,
        },
        new()
        {
            Identifier = "PER", RightAscension = 2.84494243, Declination = 55.89552955, Name = "15 Eta Per",
            ProperName = "", Rah = 2, Ram = 50, Ras = 41.7927480000003, InternalId = 512,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.08624916, Declination = 38.84053298, Name = "25 Rho Per",
            ProperName = "", Rah = 3, Ram = 5, Ras = 10.4969759999998, InternalId = 513,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.13614714, Declination = 40.9556512, Name = "26 Bet Per",
            ProperName = "Algol", Rah = 3, Ram = 8, Ras = 10.1297039999994, InternalId = 514,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.1508009, Declination = 49.61350009, Name = "Iot Per",
            ProperName = "", Rah = 3, Ram = 9, Ras = 2.88324000000048, InternalId = 515,
        },
        new()
        {
            Identifier = "PER", RightAscension = 2.73657999, Declination = 49.22866639, Name = "13 The Per",
            ProperName = "", Rah = 2, Ram = 44, Ras = 11.6879640000005, InternalId = 516,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.1582303, Declination = 44.85788896, Name = "27 Kap Per",
            ProperName = "", Rah = 3, Ram = 9, Ras = 29.6290800000002, InternalId = 517,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.40537459, Declination = 49.86124281, Name = "33 Alp Per",
            ProperName = "Mirphak", Rah = 3, Ram = 24, Ras = 19.3485240000002, InternalId = 518,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.60815558, Declination = 48.19270068, Name = "37 Psi Per",
            ProperName = "", Rah = 3, Ram = 36, Ras = 29.3600880000002, InternalId = 519,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.71541169, Declination = 47.7876533, Name = "39 Del Per",
            ProperName = "", Rah = 3, Ram = 42, Ras = 55.4820839999995, InternalId = 520,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.73864623, Declination = 32.28827325, Name = "38 Omi Per",
            ProperName = "", Rah = 3, Ram = 44, Ras = 19.1264280000004, InternalId = 521,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.90219957, Declination = 31.88365776, Name = "44 Zet Per",
            ProperName = "", Rah = 3, Ram = 54, Ras = 7.91845200000014, InternalId = 522,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.75323428, Declination = 42.57854437, Name = "41 Nu Per",
            ProperName = "", Rah = 3, Ram = 45, Ras = 11.6434080000001, InternalId = 523,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.98274992, Declination = 35.79102701, Name = "46 Xi Per",
            ProperName = "", Rah = 3, Ram = 58, Ras = 57.8997119999994, InternalId = 524,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.96422809, Declination = 40.01027315, Name = "45 Eps Per",
            ProperName = "", Rah = 3, Ram = 57, Ras = 51.2211240000009, InternalId = 525,
        },
        new()
        {
            Identifier = "PER", RightAscension = 4.10973758, Declination = 50.35135022, Name = "47 Lam Per",
            ProperName = "", Rah = 4, Ram = 6, Ras = 35.055288, InternalId = 526,
        },
        new()
        {
            Identifier = "PER", RightAscension = 4.24829381, Declination = 48.40937312, Name = "51 Mu Per",
            ProperName = "", Rah = 4, Ram = 14, Ras = 53.8577159999994, InternalId = 527,
        },
        new()
        {
            Identifier = "PER", RightAscension = 4.14435368, Declination = 47.71259359, Name = "48 Per",
            ProperName = "", Rah = 4, Ram = 8, Ras = 39.6732480000002, InternalId = 528,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 0.15681663, Declination = -45.74698836, Name = "Eps Phe",
            ProperName = "", Rah = 0, Ram = 9, Ras = 24.5398680000001, InternalId = 529,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 0.72256778, Declination = -57.46309763, Name = "Eta Phe",
            ProperName = "", Rah = 0, Ram = 43, Ras = 21.2440079999999, InternalId = 530,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 0.43801871, Declination = -42.30512197, Name = "Alp Phe",
            ProperName = "Ankaa", Rah = 0, Ram = 26, Ras = 16.8673559999999, InternalId = 531,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.10141847, Declination = -46.71849042, Name = "Bet Phe",
            ProperName = "", Rah = 1, Ram = 6, Ras = 5.10649200000012, InternalId = 532,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.25293547, Declination = -45.53209717, Name = "Nu Phe",
            ProperName = "", Rah = 1, Ram = 15, Ras = 10.5676919999998, InternalId = 533,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.47276157, Declination = -43.31772906, Name = "Gam Phe",
            ProperName = "", Rah = 1, Ram = 28, Ras = 21.9416520000002, InternalId = 534,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.5208282, Declination = -49.07307701, Name = "Del Phe",
            ProperName = "", Rah = 1, Ram = 31, Ras = 14.9815199999997, InternalId = 535,
        },
        new()
        {
            Identifier = "PIC", RightAscension = 5.7880787, Declination = -51.06671329, Name = "Bet Pic",
            ProperName = "", Rah = 5, Ram = 47, Ras = 17.0833199999993, InternalId = 536,
        },
        new()
        {
            Identifier = "PIC", RightAscension = 5.83043799, Declination = -56.1664886, Name = "Gam Pic",
            ProperName = "", Rah = 5, Ram = 49, Ras = 49.5767640000003, InternalId = 537,
        },
        new()
        {
            Identifier = "PIC", RightAscension = 6.80320475, Declination = -61.94197988, Name = "Alp Pic",
            ProperName = "", Rah = 6, Ram = 48, Ras = 11.5370999999995, InternalId = 538,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 21.74910772, Declination = -33.02555306, Name = "9 Iot PsA",
            ProperName = "", Rah = 21, Ram = 44, Ras = 56.7877920000051, InternalId = 539,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 21.79560369, Declination = -30.89830582, Name = "10 The PsA",
            ProperName = "", Rah = 21, Ram = 47, Ras = 44.1732840000003, InternalId = 540,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.23853786, Declination = -27.76691218, Name = "16 Lam PsA",
            ProperName = "", Rah = 22, Ram = 14, Ras = 18.7362960000035, InternalId = 541,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.13970922, Declination = -32.98839827, Name = "14 Mu PsA",
            ProperName = "", Rah = 22, Ram = 8, Ras = 22.9531920000011, InternalId = 542,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.67759043, Declination = -27.0436148, Name = "18 Eps PsA",
            ProperName = "", Rah = 22, Ram = 40, Ras = 39.3255479999952, InternalId = 543,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.52508043, Declination = -32.34602798, Name = "17 Bet PsA",
            ProperName = "", Rah = 22, Ram = 31, Ras = 30.2895479999968, InternalId = 544,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.96078488, Declination = -29.62183701, Name = "24 Alp PsA",
            ProperName = "Fomalhaut", Rah = 22, Ram = 57, Ras = 38.8255679999948, InternalId = 545,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.87543275, Declination = -32.87545019, Name = "22 Gam PsA",
            ProperName = "", Rah = 22, Ram = 52, Ras = 31.5579000000058, InternalId = 546,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.93247, Declination = -32.53970196, Name = "23 Del PsA",
            ProperName = "", Rah = 22, Ram = 55, Ras = 56.891999999995, InternalId = 547,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 0.81135982, Declination = 7.58520186, Name = "63 Del Psc",
            ProperName = "", Rah = 0, Ram = 48, Ras = 40.8953519999997, InternalId = 548,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.98850066, Declination = 6.86359373, Name = "28 Ome Psc",
            ProperName = "", Rah = 23, Ram = 59, Ras = 18.6023759999991, InternalId = 549,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.04907107, Declination = 7.89007256, Name = "71 Eps Psc",
            ProperName = "", Rah = 1, Ram = 2, Ras = 56.6558520000004, InternalId = 550,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.19432964, Declination = 30.08972962, Name = "83 Tau Psc",
            ProperName = "", Rah = 1, Ram = 11, Ras = 39.5867040000003, InternalId = 551,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.3244383, Declination = 27.26408682, Name = "90 Ups Psc",
            ProperName = "", Rah = 1, Ram = 19, Ras = 27.9778799999999, InternalId = 552,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.22914867, Declination = 24.58376482, Name = "85 Phi Psc",
            ProperName = "", Rah = 1, Ram = 13, Ras = 44.9352120000002, InternalId = 553,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.52472051, Declination = 15.34583101, Name = "99 Eta Psc",
            ProperName = "", Rah = 1, Ram = 31, Ras = 28.9938360000001, InternalId = 554,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.50303973, Declination = 6.14393314, Name = "98 Mu Psc",
            ProperName = "", Rah = 1, Ram = 30, Ras = 10.9430280000001, InternalId = 555,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.75655241, Declination = 9.15764102, Name = "110 Omi Psc",
            ProperName = "", Rah = 1, Ram = 45, Ras = 23.5886760000002, InternalId = 556,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.69052987, Declination = 5.48760445, Name = "106 Nu Psc",
            ProperName = "", Rah = 1, Ram = 41, Ras = 25.9075319999999, InternalId = 557,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 2.03411128, Declination = 2.76376048, Name = "113 Alp Psc",
            ProperName = "", Rah = 2, Ram = 2, Ras = 2.80060799999948, InternalId = 558,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.28597045, Declination = 3.28224524, Name = "6 Gam Psc",
            ProperName = "", Rah = 23, Ram = 17, Ras = 9.49362000000238, InternalId = 559,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.44886258, Declination = 1.25583758, Name = "8 Kap Psc",
            ProperName = "", Rah = 23, Ram = 26, Ras = 55.9052880000004, InternalId = 560,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.70080049, Declination = 1.7804172, Name = "18 Lam Psc",
            ProperName = "", Rah = 23, Ram = 42, Ras = 2.88176399999616, InternalId = 561,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.46615772, Declination = 6.37909727, Name = "10 The Psc",
            ProperName = "", Rah = 23, Ram = 27, Ras = 58.1677920000063, InternalId = 562,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.66578342, Declination = 5.62735374, Name = "17 Iot Psc",
            ProperName = "", Rah = 23, Ram = 39, Ras = 56.8203120000012, InternalId = 563,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 6.62935324, Declination = -43.19592394, Name = "Nu Pup",
            ProperName = "", Rah = 6, Ram = 37, Ras = 45.6716640000012, InternalId = 564,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 6.83226023, Declination = -50.61439973, Name = "Tau Pup",
            ProperName = "", Rah = 6, Ram = 49, Ras = 56.1368280000006, InternalId = 565,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.48718842, Declination = -43.30189129, Name = "Sig Pup",
            ProperName = "", Rah = 7, Ram = 29, Ras = 13.8783119999994, InternalId = 566,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.28571226, Declination = -37.09748689, Name = "Pi Pup",
            ProperName = "", Rah = 7, Ram = 17, Ras = 8.56413600000141, InternalId = 567,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 8.0597417, Declination = -40.00318846, Name = "Zet Pup",
            ProperName = "", Rah = 8, Ram = 3, Ras = 35.07012, InternalId = 568,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.82157187, Declination = -24.85978401, Name = "7 Xi Pup",
            ProperName = "", Rah = 7, Ram = 49, Ras = 17.6587319999988, InternalId = 569,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.94765507, Declination = -22.88014849, Name = "11 Pup",
            ProperName = "", Rah = 7, Ram = 56, Ras = 51.5582519999989, InternalId = 570,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 8.12575059, Declination = -24.30443677, Name = "15 Rho Pup",
            ProperName = "", Rah = 8, Ram = 7, Ras = 32.7021240000032, InternalId = 571,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 8.15045651, Declination = -19.24500094, Name = "16 Pup",
            ProperName = "", Rah = 8, Ram = 9, Ras = 1.64343599999898, InternalId = 572,
        },
        new()
        {
            Identifier = "PYX", RightAscension = 8.66837126, Declination = -35.30830091, Name = "Bet Pyx",
            ProperName = "", Rah = 8, Ram = 40, Ras = 6.13653600000261, InternalId = 573,
        },
        new()
        {
            Identifier = "PYX", RightAscension = 8.72654096, Declination = -33.18641133, Name = "Alp Pyx",
            ProperName = "", Rah = 8, Ram = 43, Ras = 35.547455999998, InternalId = 574,
        },
        new()
        {
            Identifier = "PYX", RightAscension = 8.84222536, Declination = -27.71005869, Name = "Gam Pyx",
            ProperName = "", Rah = 8, Ram = 50, Ras = 32.0112960000016, InternalId = 575,
        },
        new()
        {
            Identifier = "RET", RightAscension = 3.73654302, Declination = -64.80709398, Name = "Bet Ret",
            ProperName = "", Rah = 3, Ram = 44, Ras = 11.5548720000004, InternalId = 576,
        },
        new()
        {
            Identifier = "RET", RightAscension = 3.97909374, Declination = -61.40015059, Name = "Del Ret",
            ProperName = "", Rah = 3, Ram = 58, Ras = 44.7374640000005, InternalId = 577,
        },
        new()
        {
            Identifier = "RET", RightAscension = 4.27474542, Declination = -59.30174841, Name = "Eps Ret",
            ProperName = "", Rah = 4, Ram = 16, Ras = 29.0835120000013, InternalId = 578,
        },
        new()
        {
            Identifier = "RET", RightAscension = 4.24039753, Declination = -62.47397888, Name = "Alp Ret",
            ProperName = "", Rah = 4, Ram = 14, Ras = 25.4311080000003, InternalId = 579,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 23.31372966, Declination = -32.53183574, Name = "Gam Scl",
            ProperName = "", Rah = 23, Ram = 18, Ras = 49.4267759999997, InternalId = 580,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 23.81541108, Declination = -28.1300148, Name = "Del Scl",
            ProperName = "", Rah = 23, Ram = 48, Ras = 55.4798880000017, InternalId = 581,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 23.5494967, Declination = -37.81835895, Name = "Bet Scl",
            ProperName = "", Rah = 23, Ram = 32, Ras = 58.1881199999958, InternalId = 582,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 0.97676274, Declination = -29.35746436, Name = "Alp Scl",
            ProperName = "", Rah = 0, Ram = 58, Ras = 36.3458639999998, InternalId = 583,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 15.98086685, Declination = -26.1140428, Name = "6 Pi Sco",
            ProperName = "", Rah = 15, Ram = 58, Ras = 51.1206599999998, InternalId = 584,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 15.94807962, Declination = -29.21401221, Name = "5 Rho Sco",
            ProperName = "", Rah = 15, Ram = 56, Ras = 53.0866319999988, InternalId = 585,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.00555881, Declination = -22.62162024, Name = "7 Del Sco",
            ProperName = "", Rah = 16, Ram = 0, Ras = 20.0117160000005, InternalId = 586,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.09071534, Declination = -19.80184191, Name = "8 Bet 2 Sco",
            ProperName = "", Rah = 16, Ram = 5, Ras = 26.5752239999969, InternalId = 587,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.12678906, Declination = -12.74534315, Name = "11 Sco",
            ProperName = "", Rah = 16, Ram = 7, Ras = 36.4406160000004, InternalId = 588,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.11345346, Declination = -20.66913479, Name = "9 Ome 1 Sco",
            ProperName = "", Rah = 16, Ram = 6, Ras = 48.4324559999956, InternalId = 589,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.19992791, Declination = -19.46064684, Name = "14 Nu Sco",
            ProperName = "", Rah = 16, Ram = 11, Ras = 59.7404759999984, InternalId = 590,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.35314514, Declination = -25.59275259, Name = "20 Sig Sco",
            ProperName = "", Rah = 16, Ram = 21, Ras = 11.3225039999956, InternalId = 591,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.49012986, Declination = -26.43194608, Name = "21 Alp Sco",
            ProperName = "Antares", Rah = 16, Ram = 29, Ras = 24.4674959999989, InternalId = 592,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.59804428, Declination = -28.21596156, Name = "23 Tau Sco",
            ProperName = "", Rah = 16, Ram = 35, Ras = 52.9594079999994, InternalId = 593,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.83617915, Declination = -34.29260982, Name = "26 Eps Sco",
            ProperName = "", Rah = 16, Ram = 50, Ras = 10.2449399999982, InternalId = 594,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.86451079, Declination = -38.04732717, Name = "Mu 1 Sco",
            ProperName = "", Rah = 16, Ram = 51, Ras = 52.2388440000024, InternalId = 595,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.89992424, Declination = -42.36201968, Name = "Zet 1 Sco",
            ProperName = "", Rah = 16, Ram = 53, Ras = 59.7272640000027, InternalId = 596,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.20254886, Declination = -43.23849039, Name = "Eta Sco",
            ProperName = "", Rah = 17, Ram = 12, Ras = 9.17589600000095, InternalId = 597,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.62197938, Declination = -42.99782155, Name = "The Sco",
            ProperName = "", Rah = 17, Ram = 37, Ras = 19.1257679999966, InternalId = 598,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.70813327, Declination = -39.02992092, Name = "Kap Sco",
            ProperName = "", Rah = 17, Ram = 42, Ras = 29.2797720000043, InternalId = 599,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.56014624, Declination = -37.10374835, Name = "35 Lam Sco",
            ProperName = "Shaula", Rah = 17, Ram = 33, Ras = 36.5264640000059, InternalId = 600,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.79307809, Declination = -40.12698197, Name = "Iot 1 Sco",
            ProperName = "", Rah = 17, Ram = 47, Ras = 35.0811240000059, InternalId = 601,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.83095867, Declination = -37.04337105, Name = "",
            ProperName = "", Rah = 17, Ram = 49, Ras = 51.4512120000041, InternalId = 602,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.58678829, Declination = -8.24330819, Name = "Alp Sct",
            ProperName = "", Rah = 18, Ram = 35, Ras = 12.4378440000042, InternalId = 603,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.3943205, Declination = -8.93451038, Name = "Zet Sct",
            ProperName = "", Rah = 18, Ram = 23, Ras = 39.553799999997, InternalId = 604,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.48662553, Declination = -14.56580499, Name = "Gam Sct",
            ProperName = "", Rah = 18, Ram = 29, Ras = 11.8519080000047, InternalId = 605,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.7862437, Declination = -4.74782871, Name = "Bet Sct",
            ProperName = "", Rah = 18, Ram = 47, Ras = 10.47732, InternalId = 606,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 17.62645145, Declination = -15.39840835, Name = "55 Xi Ser",
            ProperName = "", Rah = 17, Ram = 37, Ras = 35.225220000004, InternalId = 607,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 17.34712098, Declination = -12.846882, Name = "53 Nu Ser",
            ProperName = "", Rah = 17, Ram = 20, Ras = 49.6355279999989, InternalId = 608,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 17.69025458, Declination = -12.87517268, Name = "56 Omi Ser",
            ProperName = "", Rah = 17, Ram = 41, Ras = 24.9164880000046, InternalId = 609,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 18.35525571, Declination = -2.897122, Name = "58 Eta Ser",
            ProperName = "", Rah = 18, Ram = 21, Ras = 18.9205560000057, InternalId = 610,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 18.93698898, Declination = 4.20352956, Name = "63 The 1 Ser",
            ProperName = "", Rah = 18, Ram = 56, Ras = 13.1603279999958, InternalId = 611,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.58005284, Declination = 10.53885916, Name = "13 Del Ser",
            ProperName = "", Rah = 15, Ram = 34, Ras = 48.1902240000017, InternalId = 612,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.76978191, Declination = 15.42192602, Name = "28 Bet Ser",
            ProperName = "", Rah = 15, Ram = 46, Ras = 11.2148760000025, InternalId = 613,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.7377766, Declination = 6.42551971, Name = "24 Alp Ser",
            ProperName = "Unukalhai", Rah = 15, Ram = 44, Ras = 15.9957600000006, InternalId = 614,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.81233572, Declination = 18.1417793, Name = "35 Kap Ser",
            ProperName = "", Rah = 15, Ram = 48, Ras = 44.4085920000002, InternalId = 615,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.94083173, Declination = 15.66473327, Name = "41 Gam Ser",
            ProperName = "", Rah = 15, Ram = 56, Ras = 26.9942279999975, InternalId = 616,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.82701825, Declination = -3.43014112, Name = "32 Mu Ser",
            ProperName = "", Rah = 15, Ram = 49, Ras = 37.2657000000003, InternalId = 617,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.83820259, Declination = 2.19662489, Name = "34 Ome Ser",
            ProperName = "", Rah = 15, Ram = 50, Ras = 17.5293239999994, InternalId = 618,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.84691422, Declination = 4.4775798, Name = "37 Eps Ser",
            ProperName = "", Rah = 15, Ram = 50, Ras = 48.8911920000012, InternalId = 619,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 10.13230432, Declination = -0.37162786, Name = "15 Alp Sex",
            ProperName = "", Rah = 10, Ram = 7, Ras = 56.2955519999977, InternalId = 620,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 9.8751308, Declination = -8.10491559, Name = "8 Gam Sex",
            ProperName = "", Rah = 9, Ram = 52, Ras = 30.470880000003, InternalId = 621,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 10.50486195, Declination = -0.63697208, Name = "30 Bet Sex",
            ProperName = "", Rah = 10, Ram = 30, Ras = 17.5030200000016, InternalId = 622,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.66827292, Declination = 18.01393839, Name = "5 Alp Sge",
            ProperName = "", Rah = 19, Ram = 40, Ras = 5.78251199999911, InternalId = 623,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.78979589, Declination = 18.53425912, Name = "7 Del Sge",
            ProperName = "", Rah = 19, Ram = 47, Ras = 23.2652040000022, InternalId = 624,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.68414825, Declination = 17.47612356, Name = "6 Bet Sge",
            ProperName = "", Rah = 19, Ram = 41, Ras = 2.9336999999992, InternalId = 625,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.97927434, Declination = 19.49209287, Name = "12 Gam Sge",
            ProperName = "", Rah = 19, Ram = 58, Ras = 45.3876239999996, InternalId = 626,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 20.08596517, Declination = 19.99087704, Name = "16 Eta Sge",
            ProperName = "", Rah = 20, Ram = 5, Ras = 9.47461200000534, InternalId = 627,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 17.79267418, Declination = -27.83076255, Name = "3 Sgr",
            ProperName = "", Rah = 17, Ram = 47, Ras = 33.6270479999957, InternalId = 628,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.09681239, Declination = -30.42365007, Name = "10 Gam 2 Sgr",
            ProperName = "", Rah = 18, Ram = 5, Ras = 48.5246040000007, InternalId = 629,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.34989489, Declination = -29.82803914, Name = "19 Del Sgr",
            ProperName = "", Rah = 18, Ram = 20, Ras = 59.6216040000059, InternalId = 630,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.40287397, Declination = -34.3843146, Name = "20 Eps Sgr",
            ProperName = "Kaus Australis", Rah = 18, Ram = 24, Ras = 10.346292000006, InternalId = 631,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.2293913, Declination = -21.05883031, Name = "13 Mu Sgr",
            ProperName = "", Rah = 18, Ram = 13, Ras = 45.8086799999986, InternalId = 632,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.46618597, Declination = -25.42124732, Name = "22 Lam Sgr",
            ProperName = "", Rah = 18, Ram = 27, Ras = 58.2694920000054, InternalId = 633,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.76093138, Declination = -26.9907794, Name = "27 Phi Sgr",
            ProperName = "", Rah = 18, Ram = 45, Ras = 39.3529679999958, InternalId = 634,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.40287397, Declination = -34.3843146, Name = "20 Eps Sgr",
            ProperName = "", Rah = 18, Ram = 24, Ras = 10.346292000006, InternalId = 635,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.29381366, Declination = -36.76128103, Name = "lis",
            ProperName = "", Rah = 18, Ram = 17, Ras = 37.7291760000051, InternalId = 636,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.34989489, Declination = -29.82803914, Name = "lis",
            ProperName = "", Rah = 18, Ram = 20, Ras = 59.6216040000059, InternalId = 636,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.92108797, Declination = -26.29659428, Name = "34 Sig Sgr",
            ProperName = "Nunki", Rah = 18, Ram = 55, Ras = 15.9166919999949, InternalId = 637,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.04353428, Declination = -29.88011429, Name = "38 Zet Sgr",
            ProperName = "", Rah = 19, Ram = 2, Ras = 36.7234079999977, InternalId = 638,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.07803717, Declination = -21.74135451, Name = "39 Omi Sgr",
            ProperName = "", Rah = 19, Ram = 4, Ras = 40.9338120000064, InternalId = 639,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.11567841, Declination = -27.66981416, Name = "40 Tau Sgr",
            ProperName = "", Rah = 19, Ram = 6, Ras = 56.4422760000036, InternalId = 640,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.1627316, Declination = -21.02352534, Name = "41 Pi Sgr",
            ProperName = "", Rah = 19, Ram = 9, Ras = 45.8337600000027, InternalId = 641,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.66373763, Declination = -23.42761, Name = "53 Sgr",
            ProperName = "", Rah = 19, Ram = 39, Ras = 49.4554679999998, InternalId = 642,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.25899921, Declination = -25.25660677, Name = "42 Psi Sgr",
            ProperName = "", Rah = 19, Ram = 15, Ras = 32.3971559999961, InternalId = 643,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.38696127, Declination = -44.79964788, Name = "Bet 2 Sgr",
            ProperName = "", Rah = 19, Ram = 23, Ras = 13.0605720000016, InternalId = 644,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.92102196, Declination = -41.8684135, Name = "Iot Sgr",
            ProperName = "", Rah = 19, Ram = 55, Ras = 15.6790560000034, InternalId = 645,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.61177473, Declination = -24.88356664, Name = "52 Sgr",
            ProperName = "", Rah = 19, Ram = 36, Ras = 42.3890280000018, InternalId = 646,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.36121535, Declination = -17.84725155, Name = "44 Rho 1 Sgr",
            ProperName = "", Rah = 19, Ram = 21, Ras = 40.3752599999942, InternalId = 647,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.3980976, Declination = -40.61564629, Name = "Alp Sgr",
            ProperName = "", Rah = 19, Ram = 23, Ras = 53.1513599999993, InternalId = 648,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 20.04429424, Declination = -27.70987972, Name = "62 Sgr",
            ProperName = "", Rah = 20, Ram = 2, Ras = 39.4592639999973, InternalId = 649,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 3.45281136, Declination = 9.7327724, Name = "2 Xi Tau",
            ProperName = "", Rah = 3, Ram = 27, Ras = 10.1208960000003, InternalId = 650,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 3.413566, Declination = 9.02906504, Name = "1 Omi Tau",
            ProperName = "", Rah = 3, Ram = 24, Ras = 48.8375999999995, InternalId = 651,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 3.51454638, Declination = 12.93668186, Name = "5 Tau",
            ProperName = "", Rah = 3, Ram = 30, Ras = 52.3669680000003, InternalId = 652,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.01133906, Declination = 12.49037571, Name = "35 Lam Tau",
            ProperName = "", Rah = 4, Ram = 0, Ras = 40.8206160000002, InternalId = 653,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.32987052, Declination = 15.62770031, Name = "54 Gam Tau",
            ProperName = "", Rah = 4, Ram = 19, Ras = 47.5338720000003, InternalId = 654,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.05260466, Declination = 5.98930909, Name = "38 Nu Tau",
            ProperName = "", Rah = 4, Ram = 3, Ras = 9.37677600000028, InternalId = 655,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.25890144, Declination = 8.89240989, Name = "49 Mu Tau",
            ProperName = "", Rah = 4, Ram = 15, Ras = 32.0451839999993, InternalId = 656,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.38222981, Declination = 17.5425843, Name = "61 Del 1 Tau",
            ProperName = "", Rah = 4, Ram = 22, Ras = 56.0273160000005, InternalId = 657,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.42481039, Declination = 17.92798917, Name = "68 Del 3 Tau",
            ProperName = "", Rah = 4, Ram = 25, Ras = 29.3174040000007, InternalId = 658,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.47692591, Declination = 19.18052092, Name = "74 Eps Tau",
            ProperName = "", Rah = 4, Ram = 28, Ras = 36.933276000001, InternalId = 659,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.4762312, Declination = 15.96221721, Name = "77 The 1 Tau",
            ProperName = "", Rah = 4, Ram = 28, Ras = 34.4323199999998, InternalId = 660,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.7040843, Declination = 22.95697545, Name = "94 Tau Tau",
            ProperName = "", Rah = 4, Ram = 42, Ras = 14.7034799999997, InternalId = 661,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.59866679, Declination = 16.50976164, Name = "87 Alp Tau",
            ProperName = "Aldebaran", Rah = 4, Ram = 35, Ras = 55.2004440000007, InternalId = 662,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 5.43819386, Declination = 28.60787346, Name = "112 Bet Tau",
            ProperName = "Alnath", Rah = 5, Ram = 26, Ras = 17.4978960000005, InternalId = 663,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 5.62741229, Declination = 21.14259299, Name = "123 Zet Tau",
            ProperName = "", Rah = 5, Ram = 37, Ras = 38.6842439999986, InternalId = 664,
        },
        new()
        {
            Identifier = "TEL", RightAscension = 18.48048221, Declination = -49.07003097, Name = "Zet Tel",
            ProperName = "", Rah = 18, Ram = 28, Ras = 49.735956000006, InternalId = 665,
        },
        new()
        {
            Identifier = "TEL", RightAscension = 18.44956396, Declination = -45.96832919, Name = "Alp Tel",
            ProperName = "", Rah = 18, Ram = 26, Ras = 58.4302559999963, InternalId = 666,
        },
        new()
        {
            Identifier = "TEL", RightAscension = 18.18716006, Declination = -45.95432704, Name = "Eps Tel",
            ProperName = "", Rah = 18, Ram = 11, Ras = 13.7762160000003, InternalId = 667,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 15.31519133, Declination = -68.67946723, Name = "Gam TrA",
            ProperName = "", Rah = 15, Ram = 18, Ras = 54.6887879999976, InternalId = 668,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 15.91911334, Declination = -63.42974973, Name = "Bet TrA",
            ProperName = "", Rah = 15, Ram = 55, Ras = 8.80802399999694, InternalId = 669,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 16.81107382, Declination = -69.02763503, Name = "Alp TrA",
            ProperName = "", Rah = 16, Ram = 48, Ras = 39.8657520000024, InternalId = 670,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 1.88469439, Declination = 29.57939727, Name = "2 Alp Tri",
            ProperName = "", Rah = 1, Ram = 53, Ras = 4.8998039999999, InternalId = 671,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 2.04943523, Declination = 33.28415151, Name = "3 Eps Tri",
            ProperName = "", Rah = 2, Ram = 2, Ras = 57.9668279999994, InternalId = 672,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 2.15903358, Declination = 34.98739204, Name = "4 Bet Tri",
            ProperName = "", Rah = 2, Ram = 9, Ras = 32.520888, InternalId = 673,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 2.28856547, Declination = 33.84732099, Name = "9 Gam Tri",
            ProperName = "", Rah = 2, Ram = 17, Ras = 18.835692, InternalId = 674,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 0.33386505, Declination = -64.8776232, Name = "Zet Tuc",
            ProperName = "", Rah = 0, Ram = 20, Ras = 1.91418000000005, InternalId = 675,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 23.99858613, Declination = -65.57707774, Name = "Eps Tuc",
            ProperName = "", Rah = 23, Ram = 59, Ras = 54.9100679999988, InternalId = 676,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 0.525932, Declination = -62.96544985, Name = "Bet 2 Tuc",
            ProperName = "", Rah = 0, Ram = 31, Ras = 33.3551999999997, InternalId = 677,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 22.30838283, Declination = -60.25949486, Name = "Alp Tuc",
            ProperName = "", Rah = 22, Ram = 18, Ras = 30.1781879999976, InternalId = 678,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 23.29050334, Declination = -58.23592762, Name = "Gam Tuc",
            ProperName = "", Rah = 23, Ram = 17, Ras = 25.8120240000028, InternalId = 679,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 22.4555203, Declination = -64.96637927, Name = "Del Tuc",
            ProperName = "", Rah = 22, Ram = 27, Ras = 19.8730799999995, InternalId = 680,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.0306641, Declination = 56.38234478, Name = "48 Bet UMa",
            ProperName = "Merak", Rah = 11, Ram = 1, Ras = 50.3907599999971, InternalId = 681,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.89715035, Declination = 53.69473296, Name = "64 Gam UMa",
            ProperName = "Phad", Rah = 11, Ram = 53, Ras = 49.7412600000017, InternalId = 682,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.06217691, Declination = 61.75111888, Name = "50 Alp UMa",
            ProperName = "Dubhe", Rah = 11, Ram = 3, Ras = 43.8368759999993, InternalId = 683,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 12.25706919, Declination = 57.03259792, Name = "69 Del UMa",
            ProperName = "", Rah = 12, Ram = 15, Ras = 25.4490839999974, InternalId = 684,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 12.9004536, Declination = 55.95984301, Name = "77 Eps UMa",
            ProperName = "Alioth", Rah = 12, Ram = 54, Ras = 1.63296000000179, InternalId = 685,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 13.39872773, Declination = 54.92541525, Name = "79 Zet UMa",
            ProperName = "Mizar", Rah = 13, Ram = 23, Ras = 55.4198279999969, InternalId = 686,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 13.79237392, Declination = 49.31330288, Name = "85 Eta UMa",
            ProperName = "Alkaid", Rah = 13, Ram = 47, Ras = 32.5461119999975, InternalId = 687,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 14.84510983, Declination = 74.15547596, Name = "7 Bet UMi",
            ProperName = "Kochab", Rah = 14, Ram = 50, Ras = 42.3953880000005, InternalId = 688,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 15.34548589, Declination = 71.83397308, Name = "13 Gam UMi",
            ProperName = "", Rah = 15, Ram = 20, Ras = 43.7492040000031, InternalId = 689,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 16.29180584, Declination = 75.75470385, Name = "21 Eta UMi",
            ProperName = "", Rah = 16, Ram = 17, Ras = 30.5010239999948, InternalId = 690,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 15.73429554, Declination = 77.79449901, Name = "16 Zet UMi",
            ProperName = "", Rah = 15, Ram = 44, Ras = 3.46394399999927, InternalId = 691,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 16.76615597, Declination = 82.03725071, Name = "22 Eps UMi",
            ProperName = "", Rah = 16, Ram = 45, Ras = 58.1614919999993, InternalId = 692,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 17.53691588, Declination = 86.58632924, Name = "23 Del UMi",
            ProperName = "", Rah = 17, Ram = 32, Ras = 12.8971679999953, InternalId = 693,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 2.52974312, Declination = 89.26413805, Name = "1 Alp UMi",
            ProperName = "Polaris", Rah = 2, Ram = 31, Ras = 47.0752319999999, InternalId = 694,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 10.14895935, Declination = -51.81126187, Name = "",
            ProperName = "", Rah = 10, Ram = 8, Ras = 56.2536600000006, InternalId = 695,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.13327141, Declination = -43.43262406, Name = "Lam Vel",
            ProperName = "", Rah = 9, Ram = 7, Ras = 59.7770760000027, InternalId = 696,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 10.77947836, Declination = -49.42012517, Name = "Mu Vel",
            ProperName = "", Rah = 10, Ram = 46, Ras = 46.1220960000019, InternalId = 697,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.51169804, Declination = -40.46688763, Name = "Psi Vel",
            ProperName = "", Rah = 9, Ram = 30, Ras = 42.1129440000023, InternalId = 698,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.15887648, Declination = -47.33661177, Name = "Gam 2 Vel",
            ProperName = "", Rah = 8, Ram = 9, Ras = 31.955328, InternalId = 699,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.7450548, Declination = -54.70856797, Name = "Del Vel",
            ProperName = "", Rah = 8, Ram = 44, Ras = 42.1972800000006, InternalId = 700,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.62740038, Declination = -42.98910371, Name = "", ProperName = "",
            Rah = 8, Ram = 37, Ras = 38.641367999997, InternalId = 695,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.72785444, Declination = -49.82281081, Name = "", ProperName = "",
            Rah = 8, Ram = 43, Ras = 40.2759839999991, InternalId = 695,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.36856367, Declination = -55.01069531, Name = "Kap Vel",
            ProperName = "", Rah = 9, Ram = 22, Ras = 6.82921200000133, InternalId = 701,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.94770968, Declination = -54.5677973, Name = "Phi Vel",
            ProperName = "", Rah = 9, Ram = 56, Ras = 51.7548480000031, InternalId = 702,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 11.8448017, Declination = 1.76537705, Name = "5 Bet Vir",
            ProperName = "", Rah = 11, Ram = 50, Ras = 41.2861199999986, InternalId = 703,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.33177539, Declination = -0.66674709, Name = "15 Eta Vir",
            ProperName = "", Rah = 12, Ram = 19, Ras = 54.3914040000025, InternalId = 704,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.69444503, Declination = -1.44952231, Name = "29 Gam Vir",
            ProperName = "", Rah = 12, Ram = 41, Ras = 40.0021080000024, InternalId = 705,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.16583667, Declination = -5.53892987, Name = "51 The Vir",
            ProperName = "", Rah = 13, Ram = 9, Ras = 57.0120119999969, InternalId = 706,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.92680091, Declination = 3.39759862, Name = "43 Del Vir",
            ProperName = "", Rah = 12, Ram = 55, Ras = 36.4832760000029, InternalId = 707,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.03632237, Declination = 10.95910186, Name = "47 Eps Vir",
            ProperName = "Vindemiatrix", Rah = 13, Ram = 2, Ras = 10.7605320000022, InternalId = 708,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.41989015, Declination = -11.16124491, Name = "67 Alp Vir",
            ProperName = "Spica", Rah = 13, Ram = 25, Ras = 11.6045400000018, InternalId = 709,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.21492805, Declination = -10.274044, Name = "98 Kap Vir",
            ProperName = "", Rah = 14, Ram = 12, Ras = 53.7409799999973, InternalId = 710,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.5782652, Declination = -0.59593821, Name = "79 Zet Vir",
            ProperName = "", Rah = 13, Ram = 34, Ras = 41.7547200000022, InternalId = 711,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.02743976, Declination = 1.54458338, Name = "93 Tau Vir",
            ProperName = "", Rah = 14, Ram = 1, Ras = 38.7831360000001, InternalId = 712,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.26691247, Declination = -5.99952622, Name = "99 Iot Vir",
            ProperName = "", Rah = 14, Ram = 16, Ras = 0.884891999997861, InternalId = 713,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.71765618, Declination = -5.6574291, Name = "107 Mu Vir",
            ProperName = "", Rah = 14, Ram = 43, Ras = 3.56224800000189, InternalId = 714,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.77083106, Declination = 1.8929383, Name = "109 Vir",
            ProperName = "", Rah = 14, Ram = 46, Ras = 14.9918160000027, InternalId = 715,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 7.14578458, Declination = -70.49919435, Name = "Gam 2 Vol",
            ProperName = "", Rah = 7, Ram = 8, Ras = 44.8244879999998, InternalId = 716,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 7.28050856, Declination = -67.95717248, Name = "Del Vol",
            ProperName = "", Rah = 7, Ram = 16, Ras = 49.8308160000013, InternalId = 717,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 8.13217799, Declination = -68.61713647, Name = "Eps Vol",
            ProperName = "", Rah = 8, Ram = 7, Ras = 55.8407640000023, InternalId = 718,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 7.69699889, Declination = -72.60613528, Name = "Zet Vol",
            ProperName = "", Rah = 7, Ram = 41, Ras = 49.1960039999989, InternalId = 719,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 8.42895729, Declination = -66.13652042, Name = "Bet Vol",
            ProperName = "", Rah = 8, Ram = 25, Ras = 44.2462439999985, InternalId = 720,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 9.04077745, Declination = -66.39584369, Name = "Alp Vol",
            ProperName = "", Rah = 9, Ram = 2, Ras = 26.7988200000008, InternalId = 721,
        },
        new()
        {
            Identifier = "VUL", RightAscension = 19.4784475, Declination = 24.66516482, Name = "6 Alp Vul",
            ProperName = "", Rah = 19, Ram = 28, Ras = 42.4110000000053, InternalId = 722,
        },
        new()
        {
            Identifier = "VUL", RightAscension = 19.27028877, Declination = 21.39044277, Name = "1 Vul",
            ProperName = "", Rah = 19, Ram = 16, Ras = 13.0395720000019, InternalId = 723,
        },
        new()
        {
            Identifier = "VUL", RightAscension = 19.89102245, Declination = 24.07952568, Name = "13 Vul",
            ProperName = "", Rah = 19, Ram = 53, Ras = 27.6808200000046, InternalId = 724,
        },
    };

    /// <summary>
    /// The constellation star data.
    /// </summary>
    /// <remarks>Copyright (C) Dominic Ford 2015 - 2019. Gnu General Public License.</remarks>
    // These values are from "Constellation stick figures" repository in GitHub licensed
    // under the terms of the Gnu General Public License:
    // https://github.com/dcf21/constellation-stick-figures
    private static readonly ConstellationStar[] ConstellationStarsDf =
    {
        new()
        {
            Identifier = "AND", RightAscension = 1.633205, Declination = 48.628213, Name = "51 And",
            ProperName = "", Rah = 1, Ram = 37, Ras = 59.537999999999954, InternalId = 1,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.945885, Declination = 38.499345, Name = "37 Mu And",
            ProperName = "", Rah = 0, Ram = 56, Ras = 45.18599999999986, InternalId = 2,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.61468, Declination = 33.719344, Name = "29 Pi And",
            ProperName = "", Rah = 0, Ram = 36, Ras = 52.8480000000001, InternalId = 3,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.139791, Declination = 29.090432, Name = "21 Alp And",
            ProperName = "Alpheratz", Rah = 0, Ram = 8, Ras = 23.247600000000002, InternalId = 4,
        },
        new()
        {
            Identifier = "AND", RightAscension = 0.655462, Declination = 30.861024, Name = "31 Del And",
            ProperName = "", Rah = 0, Ram = 39, Ras = 19.663199999999883, InternalId = 5,
        },
        new()
        {
            Identifier = "AND", RightAscension = 1.162194, Declination = 35.620558, Name = "43 Bet And",
            ProperName = "Mirach", Rah = 1, Ram = 9, Ras = 43.89839999999984, InternalId = 6,
        },
        new()
        {
            Identifier = "AND", RightAscension = 2.064984, Declination = 42.329725, Name = "57 Gam 1 And",
            ProperName = "Almaak", Rah = 2, Ram = 3, Ras = 53.94239999999974, InternalId = 7,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 10.945289, Declination = -37.137765, Name = "Iot Ant",
            ProperName = "", Rah = 10, Ram = 56, Ras = 43.040400000002506, InternalId = 8,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 10.45253, Declination = -31.067779, Name = "Alp Ant",
            ProperName = "", Rah = 10, Ram = 27, Ras = 9.107999999997919, InternalId = 9,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 9.736694, Declination = -27.769471, Name = "The Ant",
            ProperName = "", Rah = 9, Ram = 44, Ras = 12.098400000000042, InternalId = 10,
        },
        new()
        {
            Identifier = "ANT", RightAscension = 9.487423, Declination = -35.951335, Name = "Eps Ant",
            ProperName = "", Rah = 9, Ram = 29, Ras = 14.72279999999897, InternalId = 11,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.339119, Declination = -78.695745, Name = "Del 1 Aps",
            ProperName = "", Rah = 16, Ram = 20, Ras = 20.82840000000068, InternalId = 12,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.718126, Declination = -77.517435, Name = "Bet Aps",
            ProperName = "", Rah = 16, Ram = 43, Ras = 5.25360000000572, InternalId = 13,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.557609, Declination = -78.897148, Name = "Gam Aps",
            ProperName = "", Rah = 16, Ram = 33, Ras = 27.39239999999752, InternalId = 14,
        },
        new()
        {
            Identifier = "APS", RightAscension = 16.339119, Declination = -78.695745, Name = "Del 1 Aps",
            ProperName = "", Rah = 16, Ram = 20, Ras = 20.82840000000068, InternalId = 12,
        },
        new()
        {
            Identifier = "APS", RightAscension = 14.797701, Declination = -79.044751, Name = "Alp Aps",
            ProperName = "", Rah = 14, Ram = 47, Ras = 51.723600000000005, InternalId = 15,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 20.794598, Declination = -9.495776, Name = "2 Eps Aqr",
            ProperName = "", Rah = 20, Ram = 47, Ras = 40.55280000000212, InternalId = 16,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 21.525982, Declination = -5.571172, Name = "22 Bet Aqr",
            ProperName = "Sadalsuud", Rah = 21, Ram = 31, Ras = 33.535199999996436, InternalId = 17,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.096399, Declination = -0.319851, Name = "34 Alp Aqr",
            ProperName = "Sadalmelik", Rah = 22, Ram = 5, Ras = 47.036400000006054, InternalId = 18,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.280565, Declination = -7.78329, Name = "43 The Aqr",
            ProperName = "", Rah = 22, Ram = 16, Ras = 50.03399999999745, InternalId = 19,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.107286, Declination = -13.869679, Name = "33 Iot Aqr",
            ProperName = "", Rah = 22, Ram = 6, Ras = 26.229599999994356, InternalId = 20,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.096399, Declination = -0.319851, Name = "34 Alp Aqr",
            ProperName = "Sadalmelik", Rah = 22, Ram = 5, Ras = 47.036400000006054, InternalId = 18,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.360938, Declination = -1.387331, Name = "48 Gam Aqr",
            ProperName = "", Rah = 22, Ram = 21, Ras = 39.37680000000321, InternalId = 21,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.480531, Declination = -0.019972, Name = "55 Zet 1 Aqr",
            ProperName = "", Rah = 22, Ram = 28, Ras = 49.91159999999692, InternalId = 22,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.589272, Declination = -0.117498, Name = "62 Eta Aqr",
            ProperName = "", Rah = 22, Ram = 35, Ras = 21.379200000003927, InternalId = 23,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 23.238711, Declination = -6.049003, Name = "90 Phi Aqr",
            ProperName = "", Rah = 23, Ram = 14, Ras = 19.359599999994813, InternalId = 24,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.87691, Declination = -7.579599, Name = "73 Lam Aqr",
            ProperName = "", Rah = 22, Ram = 52, Ras = 36.87599999999538, InternalId = 25,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 22.826528, Declination = -13.592632, Name = "71 Tau 2 Aqr",
            ProperName = "", Rah = 22, Ram = 49, Ras = 35.500799999999, InternalId = 26,
        },
        new()
        {
            Identifier = "AQR", RightAscension = 23.157443, Declination = -21.17241, Name = "88 Aqr",
            ProperName = "", Rah = 23, Ram = 9, Ras = 26.794800000002418, InternalId = 27,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.028008, Declination = -5.739115, Name = "12 Aql",
            ProperName = "", Rah = 19, Ram = 1, Ras = 40.82879999999932, InternalId = 28,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.10415, Declination = -4.882554, Name = "16 Lam Aql",
            ProperName = "", Rah = 19, Ram = 6, Ras = 14.940000000002252, InternalId = 29,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.424972, Declination = 3.114775, Name = "30 Del Aql",
            ProperName = "", Rah = 19, Ram = 25, Ras = 29.89920000000119, InternalId = 30,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.090169, Declination = 13.863478, Name = "17 Zet Aql",
            ProperName = "", Rah = 19, Ram = 5, Ras = 24.608399999998216, InternalId = 31,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 18.993711, Declination = 15.068298, Name = "13 Eps Aql",
            ProperName = "", Rah = 18, Ram = 59, Ras = 37.35960000000422, InternalId = 32,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.090169, Declination = 13.863478, Name = "17 Zet Aql",
            ProperName = "", Rah = 19, Ram = 5, Ras = 24.608399999998216, InternalId = 31,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.770994, Declination = 10.613261, Name = "50 Gam Aql",
            ProperName = "Tarazed", Rah = 19, Ram = 46, Ras = 15.578400000006054, InternalId = 33,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.846388, Declination = 8.868322, Name = "53 Alp Aql",
            ProperName = "Altair", Rah = 19, Ram = 50, Ras = 46.99680000000357, InternalId = 34,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.921887, Declination = 6.406763, Name = "60 Bet Aql",
            ProperName = "Alshain", Rah = 19, Ram = 55, Ras = 18.793200000006173, InternalId = 35,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 20.188413, Declination = -0.821461, Name = "65 The Aql",
            ProperName = "", Rah = 20, Ram = 11, Ras = 18.286800000002234, InternalId = 36,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.874547, Declination = 1.005661, Name = "55 Eta Aql",
            ProperName = "", Rah = 19, Ram = 52, Ras = 28.369199999998962, InternalId = 37,
        },
        new()
        {
            Identifier = "AQL", RightAscension = 19.424972, Declination = 3.114775, Name = "30 Del Aql",
            ProperName = "", Rah = 19, Ram = 25, Ras = 29.89920000000119, InternalId = 30,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 18.11052, Declination = -50.091477, Name = "The Ara",
            ProperName = "", Rah = 18, Ram = 6, Ras = 37.8720000000038, InternalId = 38,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.530695, Declination = -49.876145, Name = "Alp Ara",
            ProperName = "", Rah = 17, Ram = 31, Ras = 50.50200000000511, InternalId = 39,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.421665, Declination = -55.529884, Name = "Bet Ara",
            ProperName = "", Rah = 17, Ram = 25, Ras = 17.994000000002973, InternalId = 40,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.423239, Declination = -56.377727, Name = "Gam Ara",
            ProperName = "", Rah = 17, Ram = 25, Ras = 23.66039999999565, InternalId = 41,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.518318, Declination = -60.683848, Name = "Del Ara",
            ProperName = "", Rah = 17, Ram = 31, Ras = 5.944800000002415, InternalId = 42,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.423239, Declination = -56.377727, Name = "Gam Ara",
            ProperName = "", Rah = 17, Ram = 25, Ras = 23.66039999999565, InternalId = 41,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.977006, Declination = -55.990141, Name = "Zet Ara",
            ProperName = "", Rah = 16, Ram = 58, Ras = 37.22159999999772, InternalId = 43,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.82976, Declination = -59.041378, Name = "Eta Ara",
            ProperName = "", Rah = 16, Ram = 49, Ras = 47.13600000000105, InternalId = 44,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.977006, Declination = -55.990141, Name = "Zet Ara",
            ProperName = "", Rah = 16, Ram = 58, Ras = 37.22159999999772, InternalId = 43,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 16.993069, Declination = -53.160438, Name = "Eps 1 Ara",
            ProperName = "", Rah = 16, Ram = 59, Ras = 35.048399999994515, InternalId = 45,
        },
        new()
        {
            Identifier = "ARA", RightAscension = 17.530695, Declination = -49.876145, Name = "Alp Ara",
            ProperName = "", Rah = 17, Ram = 31, Ras = 50.50200000000511, InternalId = 39,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 2.833063, Declination = 27.260507, Name = "41 Ari",
            ProperName = "", Rah = 2, Ram = 49, Ras = 59.02680000000045, InternalId = 46,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 2.119555, Declination = 23.462423, Name = "13 Alp Ari",
            ProperName = "Hamal", Rah = 2, Ram = 7, Ras = 10.398000000000273, InternalId = 47,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 1.910668, Declination = 20.808035, Name = "6 Bet Ari",
            ProperName = "Sheratan", Rah = 1, Ram = 54, Ras = 38.40480000000004, InternalId = 48,
        },
        new()
        {
            Identifier = "ARI", RightAscension = 1.89217, Declination = 19.293852, Name = "5 Gam 2 Ari",
            ProperName = "", Rah = 1, Ram = 53, Ras = 31.811999999999774, InternalId = 49,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.27815, Declination = 45.997991, Name = "13 Alp Aur",
            ProperName = "Capella", Rah = 5, Ram = 16, Ras = 41.340000000000444, InternalId = 50,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.032815, Declination = 43.823308, Name = "7 Eps Aur",
            ProperName = "", Rah = 5, Ram = 1, Ras = 58.13400000000094, InternalId = 51,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.10858, Declination = 41.234474, Name = "10 Eta Aur",
            ProperName = "", Rah = 5, Ram = 6, Ras = 30.887999999999614, InternalId = 52,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 4.949894, Declination = 33.16609, Name = "3 Iot Aur",
            ProperName = "Hassaleh", Rah = 4, Ram = 56, Ras = 59.6183999999984, InternalId = 53,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.438198, Declination = 28.60745, Name = "112 Bet Tau",
            ProperName = "Alnath", Rah = 5, Ram = 26, Ras = 17.512799999999462, InternalId = 54,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.995351, Declination = 37.212585, Name = "37 The Aur",
            ProperName = "", Rah = 5, Ram = 59, Ras = 43.26360000000133, InternalId = 55,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.992149, Declination = 44.947433, Name = "34 Bet Aur",
            ProperName = "Menkalinan", Rah = 5, Ram = 59, Ras = 31.736400000001595, InternalId = 56,
        },
        new()
        {
            Identifier = "AUR", RightAscension = 5.27815, Declination = 45.997991, Name = "13 Alp Aur",
            ProperName = "Capella", Rah = 5, Ram = 16, Ras = 41.340000000000444, InternalId = 50,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 13.911411, Declination = 18.397717, Name = "8 Eta Boo",
            ProperName = "Mufrid", Rah = 13, Ram = 54, Ras = 41.07959999999742, InternalId = 57,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.26103, Declination = 19.18241, Name = "16 Alp Boo",
            ProperName = "Arcturus", Rah = 14, Ram = 15, Ras = 39.707999999999544, InternalId = 58,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.5305, Declination = 30.371437, Name = "25 Rho Boo",
            ProperName = "", Rah = 14, Ram = 31, Ras = 49.79999999999971, InternalId = 59,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.534636, Declination = 38.308253, Name = "27 Gam Boo",
            ProperName = "", Rah = 14, Ram = 32, Ras = 4.689600000002825, InternalId = 60,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.273074, Declination = 46.088305, Name = "19 Lam Boo",
            ProperName = "", Rah = 14, Ram = 16, Ras = 23.066399999997756, InternalId = 61,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.419967, Declination = 51.850744, Name = "23 The Boo",
            ProperName = "", Rah = 14, Ram = 25, Ras = 11.881199999999058, InternalId = 62,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.534636, Declination = 38.308253, Name = "27 Gam Boo",
            ProperName = "", Rah = 14, Ram = 32, Ras = 4.689600000002825, InternalId = 60,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 15.032436, Declination = 40.390566, Name = "42 Bet Boo",
            ProperName = "", Rah = 15, Ram = 1, Ras = 56.76960000000207, InternalId = 63,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 15.258376, Declination = 33.314833, Name = "49 Del Boo",
            ProperName = "", Rah = 15, Ram = 15, Ras = 30.15360000000058, InternalId = 64,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.749784, Declination = 27.074222, Name = "36 Eps Boo",
            ProperName = "Izar", Rah = 14, Ram = 44, Ras = 59.222400000000206, InternalId = 65,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.26103, Declination = 19.18241, Name = "16 Alp Boo",
            ProperName = "Arcturus", Rah = 14, Ram = 15, Ras = 39.707999999999544, InternalId = 58,
        },
        new()
        {
            Identifier = "BOO", RightAscension = 14.68582, Declination = 13.7283, Name = "30 Zet Boo",
            ProperName = "", Rah = 14, Ram = 41, Ras = 8.951999999998694, InternalId = 66,
        },
        new()
        {
            Identifier = "CAE", RightAscension = 4.700965, Declination = -37.144297, Name = "Bet Cae",
            ProperName = "", Rah = 4, Ram = 42, Ras = 3.474000000000377, InternalId = 67,
        },
        new()
        {
            Identifier = "CAE", RightAscension = 4.676039, Declination = -41.863752, Name = "Alp Cae",
            ProperName = "", Rah = 4, Ram = 40, Ras = 33.74040000000114, InternalId = 68,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 3.484482, Declination = 59.94033, Name = "", ProperName = "",
            Rah = 3, Ram = 29, Ras = 4.135199999999473, InternalId = 69,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 3.839302, Declination = 71.332266, Name = "Gam Cam",
            ProperName = "", Rah = 3, Ram = 50, Ras = 21.487199999999838, InternalId = 70,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 4.900836, Declination = 66.342678, Name = "9 Alp Cam",
            ProperName = "", Rah = 4, Ram = 54, Ras = 3.0095999999998124, InternalId = 71,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 5.05697, Declination = 60.442245, Name = "10 Bet Cam",
            ProperName = "", Rah = 5, Ram = 3, Ras = 25.091999999999064, InternalId = 72,
        },
        new()
        {
            Identifier = "CAM", RightAscension = 4.95478, Declination = 53.752101, Name = "7 Cam", ProperName = "",
            Rah = 4, Ram = 57, Ras = 17.208000000001622, InternalId = 73,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.778284, Declination = 28.759898, Name = "48 Iot Cnc",
            ProperName = "", Rah = 8, Ram = 46, Ras = 41.82239999999733, InternalId = 74,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.721431, Declination = 21.468501, Name = "43 Gam Cnc",
            ProperName = "", Rah = 8, Ram = 43, Ras = 17.15160000000293, InternalId = 75,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.74475, Declination = 18.154309, Name = "47 Del Cnc",
            ProperName = "", Rah = 8, Ram = 44, Ras = 41.09999999999947, InternalId = 76,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.974784, Declination = 11.857701, Name = "65 Alp Cnc",
            ProperName = "", Rah = 8, Ram = 58, Ras = 29.222399999998714, InternalId = 77,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.74475, Declination = 18.154309, Name = "47 Del Cnc",
            ProperName = "", Rah = 8, Ram = 44, Ras = 41.09999999999947, InternalId = 76,
        },
        new()
        {
            Identifier = "CNC", RightAscension = 8.275256, Declination = 9.185545, Name = "17 Bet Cnc",
            ProperName = "", Rah = 8, Ram = 16, Ras = 30.921600000002215, InternalId = 78,
        },
        new()
        {
            Identifier = "CVN", RightAscension = 12.562411, Declination = 41.35748, Name = "8 Bet CVn",
            ProperName = "", Rah = 12, Ram = 33, Ras = 44.67960000000302, InternalId = 79,
        },
        new()
        {
            Identifier = "CVN", RightAscension = 12.933807, Declination = 38.31838, Name = "12 Alp 2 CVn",
            ProperName = "Cor Caroli", Rah = 12, Ram = 56, Ras = 1.7051999999993406, InternalId = 80,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.401584, Declination = -29.303104, Name = "31 Eta CMa",
            ProperName = "Aludra", Rah = 7, Ram = 24, Ras = 5.702399999998908, InternalId = 81,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.276387, Declination = -27.881179, Name = "", ProperName = "",
            Rah = 7, Ram = 16, Ras = 34.99319999999899, InternalId = 82,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.139857, Declination = -26.3932, Name = "25 Del CMa",
            ProperName = "Wezen", Rah = 7, Ram = 8, Ras = 23.48520000000044, InternalId = 83,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.977097, Declination = -28.972084, Name = "21 Eps CMa",
            ProperName = "Adhara", Rah = 6, Ram = 58, Ras = 37.54919999999875, InternalId = 84,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.139857, Declination = -26.3932, Name = "25 Del CMa",
            ProperName = "Wezen", Rah = 7, Ram = 8, Ras = 23.48520000000044, InternalId = 83,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 7.050409, Declination = -23.833291, Name = "24 Omi 2 CMa",
            ProperName = "", Rah = 7, Ram = 3, Ras = 1.4724000000005233, InternalId = 85,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.752481, Declination = -16.716116, Name = "9 Alp CMa",
            ProperName = "Sirius", Rah = 6, Ram = 45, Ras = 8.931600000001438, InternalId = 86,
        },
        new()
        {
            Identifier = "CMA", RightAscension = 6.378329, Declination = -17.955918, Name = "2 Bet CMa",
            ProperName = "Mirzam", Rah = 6, Ram = 22, Ras = 41.98439999999979, InternalId = 87,
        },
        new()
        {
            Identifier = "CMI", RightAscension = 7.655033, Declination = 5.224993, Name = "10 Alp CMi",
            ProperName = "Procyon", Rah = 7, Ram = 39, Ras = 18.118800000001436, InternalId = 88,
        },
        new()
        {
            Identifier = "CMI", RightAscension = 7.452512, Declination = 8.289315, Name = "3 Bet CMi",
            ProperName = "Gomeisa", Rah = 7, Ram = 27, Ras = 9.043199999998453, InternalId = 89,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.300904, Declination = -12.544852, Name = "6 Alp 2 Cap",
            ProperName = "", Rah = 20, Ram = 18, Ras = 3.2543999999970596, InternalId = 90,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.350187, Declination = -14.781367, Name = "9 Bet Cap",
            ProperName = "", Rah = 20, Ram = 21, Ras = 0.6731999999937788, InternalId = 91,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.76826, Declination = -25.270898, Name = "16 Psi Cap",
            ProperName = "", Rah = 20, Ram = 46, Ras = 5.736000000005204, InternalId = 92,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.863692, Declination = -26.919133, Name = "18 Ome Cap",
            ProperName = "", Rah = 20, Ram = 51, Ras = 49.29120000000133, InternalId = 93,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.444452, Declination = -22.411332, Name = "34 Zet Cap",
            ProperName = "", Rah = 21, Ram = 26, Ras = 40.0271999999938, InternalId = 94,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.784011, Declination = -16.127286, Name = "49 Del Cap",
            ProperName = "", Rah = 21, Ram = 47, Ras = 2.4395999999984763, InternalId = 95,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.370776, Declination = -16.834542, Name = "32 Iot Cap",
            ProperName = "", Rah = 21, Ram = 22, Ras = 14.793599999997674, InternalId = 96,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 21.099118, Declination = -17.232861, Name = "23 The Cap",
            ProperName = "", Rah = 21, Ram = 5, Ras = 56.824800000002554, InternalId = 97,
        },
        new()
        {
            Identifier = "CAP", RightAscension = 20.350187, Declination = -14.781367, Name = "9 Bet Cap",
            ProperName = "", Rah = 20, Ram = 21, Ras = 0.6731999999937788, InternalId = 91,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 6.399195, Declination = -52.69566, Name = "Alp Car",
            ProperName = "Canopus", Rah = 6, Ram = 23, Ras = 57.10199999999899, InternalId = 98,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 7.946313, Declination = -52.98236, Name = "Chi Car",
            ProperName = "", Rah = 7, Ram = 56, Ras = 46.7267999999998, InternalId = 99,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 8.375236, Declination = -59.509483, Name = "Eps Car",
            ProperName = "Avior", Rah = 8, Ram = 22, Ras = 30.849599999997345, InternalId = 100,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 9.284838, Declination = -59.275229, Name = "Iot Car",
            ProperName = "Tureis", Rah = 9, Ram = 17, Ras = 5.416800000002153, InternalId = 101,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.28472, Declination = -61.332304, Name = "", ProperName = "",
            Rah = 10, Ram = 17, Ras = 4.9920000000003295, InternalId = 102,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.715949, Declination = -64.39445, Name = "The Car",
            ProperName = "", Rah = 10, Ram = 42, Ras = 57.41640000000076, InternalId = 103,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 10.228961, Declination = -70.037903, Name = "Ome Car",
            ProperName = "", Rah = 10, Ram = 13, Ras = 44.259599999999864, InternalId = 104,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 9.220041, Declination = -69.717208, Name = "Bet Car",
            ProperName = "Miaplacidus", Rah = 9, Ram = 13, Ras = 12.147600000000525, InternalId = 105,
        },
        new()
        {
            Identifier = "CAR", RightAscension = 9.785036, Declination = -65.072007, Name = "Ups Car",
            ProperName = "", Rah = 9, Ram = 47, Ras = 6.129599999999469, InternalId = 106,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 1.906584, Declination = 63.670101, Name = "45 Eps Cas",
            ProperName = "", Rah = 1, Ram = 54, Ras = 23.702400000000125, InternalId = 107,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 1.430216, Declination = 60.235283, Name = "37 Del Cas",
            ProperName = "Ruchbah", Rah = 1, Ram = 25, Ras = 48.77759999999969, InternalId = 108,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 0.945143, Declination = 60.71674, Name = "27 Gam Cas",
            ProperName = "Cih", Rah = 0, Ram = 56, Ras = 42.51479999999979, InternalId = 109,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 0.675116, Declination = 56.537331, Name = "18 Alp Cas",
            ProperName = "Shedir", Rah = 0, Ram = 40, Ras = 30.417600000000313, InternalId = 110,
        },
        new()
        {
            Identifier = "CAS", RightAscension = 0.152887, Declination = 59.14978, Name = "11 Bet Cas",
            ProperName = "Caph", Rah = 0, Ram = 9, Ras = 10.393200000000002, InternalId = 111,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 11.596363, Declination = -63.019841, Name = "Lam Cen",
            ProperName = "", Rah = 11, Ram = 35, Ras = 46.90680000000058, InternalId = 112,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 11.350117, Declination = -54.491019, Name = "Pi Cen",
            ProperName = "", Rah = 11, Ram = 21, Ras = 0.42119999999692403, InternalId = 113,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.194202, Declination = -52.36846, Name = "Rho Cen",
            ProperName = "", Rah = 12, Ram = 11, Ras = 39.1272000000024, InternalId = 114,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.13931, Declination = -50.722425, Name = "Del Cen",
            ProperName = "", Rah = 12, Ram = 8, Ras = 21.51600000000017, InternalId = 115,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.467331, Declination = -50.230635, Name = "Sig Cen",
            ProperName = "", Rah = 12, Ram = 28, Ras = 2.3915999999989612, InternalId = 116,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 12.691971, Declination = -48.959888, Name = "Gam Cen",
            ProperName = "", Rah = 12, Ram = 41, Ras = 31.095600000001955, InternalId = 117,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.664796, Declination = -53.466394, Name = "Eps Cen",
            ProperName = "", Rah = 13, Ram = 39, Ras = 53.26560000000291, InternalId = 118,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.063729, Declination = -60.373039, Name = "Bet Cen",
            ProperName = "Hadar", Rah = 14, Ram = 3, Ras = 49.42440000000132, InternalId = 119,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.664796, Declination = -53.466394, Name = "Eps Cen",
            ProperName = "", Rah = 13, Ram = 39, Ras = 53.26560000000291, InternalId = 118,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.660765, Declination = -60.833976, Name = "Alp 1 Cen",
            ProperName = "Rigil Kentaurus", Rah = 14, Ram = 39, Ras = 38.75399999999849, InternalId = 120,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.664796, Declination = -53.466394, Name = "Eps Cen",
            ProperName = "", Rah = 13, Ram = 39, Ras = 53.26560000000291, InternalId = 118,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.925667, Declination = -47.288375, Name = "Zet Cen",
            ProperName = "", Rah = 13, Ram = 55, Ras = 32.401200000002596, InternalId = 121,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.826943, Declination = -42.473732, Name = "Mu Cen",
            ProperName = "", Rah = 13, Ram = 49, Ras = 36.9948, InternalId = 122,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.825078, Declination = -41.687709, Name = "Nu Cen",
            ProperName = "", Rah = 13, Ram = 49, Ras = 30.280799999998376, InternalId = 123,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.343296, Declination = -36.712295, Name = "Iot Cen",
            ProperName = "", Rah = 13, Ram = 20, Ras = 35.86560000000183, InternalId = 124,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.825078, Declination = -41.687709, Name = "Nu Cen",
            ProperName = "", Rah = 13, Ram = 49, Ras = 30.280799999998376, InternalId = 123,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.111395, Declination = -36.369954, Name = "5 The Cen",
            ProperName = "Menkent", Rah = 14, Ram = 6, Ras = 41.02199999999966, InternalId = 125,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 13.825078, Declination = -41.687709, Name = "Nu Cen",
            ProperName = "", Rah = 13, Ram = 49, Ras = 30.280799999998376, InternalId = 123,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.591786, Declination = -42.157824, Name = "Eta Cen",
            ProperName = "", Rah = 14, Ram = 35, Ras = 30.429600000002786, InternalId = 126,
        },
        new()
        {
            Identifier = "CEN", RightAscension = 14.986025, Declination = -42.104194, Name = "Kap Cen",
            ProperName = "", Rah = 14, Ram = 59, Ras = 9.689999999999133, InternalId = 127,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 20.493015, Declination = 62.994105, Name = "2 The Cep",
            ProperName = "", Rah = 20, Ram = 29, Ras = 34.85399999999912, InternalId = 128,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 20.754811, Declination = 61.838782, Name = "3 Eta Cep",
            ProperName = "", Rah = 20, Ram = 45, Ras = 17.319600000000435, InternalId = 129,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 21.30963, Declination = 62.585573, Name = "5 Alp Cep",
            ProperName = "Alderamin", Rah = 21, Ram = 18, Ras = 34.667999999994706, InternalId = 130,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 21.477662, Declination = 70.560716, Name = "8 Bet Cep",
            ProperName = "", Rah = 21, Ram = 28, Ras = 39.58319999999529, InternalId = 131,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 23.65582, Declination = 77.632276, Name = "35 Gam Cep",
            ProperName = "", Rah = 23, Ram = 39, Ras = 20.951999999994577, InternalId = 132,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.82802, Declination = 66.200408, Name = "32 Iot Cep",
            ProperName = "", Rah = 22, Ram = 49, Ras = 40.87199999999518, InternalId = 133,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.180908, Declination = 58.201261, Name = "21 Zet Cep",
            ProperName = "", Rah = 22, Ram = 10, Ras = 51.26879999999549, InternalId = 134,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.250544, Declination = 57.043587, Name = "23 Eps Cep",
            ProperName = "", Rah = 22, Ram = 15, Ras = 1.958400000005156, InternalId = 135,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.486183, Declination = 58.415198, Name = "27 Del Cep",
            ProperName = "", Rah = 22, Ram = 29, Ras = 10.258800000001699, InternalId = 136,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 22.180908, Declination = 58.201261, Name = "21 Zet Cep",
            ProperName = "", Rah = 22, Ram = 10, Ras = 51.26879999999549, InternalId = 134,
        },
        new()
        {
            Identifier = "CEP", RightAscension = 21.30963, Declination = 62.585573, Name = "5 Alp Cep",
            ProperName = "Alderamin", Rah = 21, Ram = 18, Ras = 34.667999999994706, InternalId = 130,
        },
        new()
        {
            Identifier = "CET", RightAscension = 3.037992, Declination = 4.089734, Name = "92 Alp Cet",
            ProperName = "Menkar", Rah = 3, Ram = 2, Ras = 16.771200000000093, InternalId = 137,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.99525, Declination = 8.907365, Name = "91 Lam Cet",
            ProperName = "", Rah = 2, Ram = 59, Ras = 42.90000000000007, InternalId = 138,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.749039, Declination = 10.114146, Name = "87 Mu Cet",
            ProperName = "", Rah = 2, Ram = 44, Ras = 56.54039999999942, InternalId = 139,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.469317, Declination = 8.460054, Name = "73 Xi 2 Cet",
            ProperName = "", Rah = 2, Ram = 28, Ras = 9.541200000000716, InternalId = 140,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.721678, Declination = 3.235818, Name = "86 Gam Cet",
            ProperName = "", Rah = 2, Ram = 43, Ras = 18.040799999999322, InternalId = 141,
        },
        new()
        {
            Identifier = "CET", RightAscension = 3.037992, Declination = 4.089734, Name = "92 Alp Cet",
            ProperName = "Menkar", Rah = 3, Ram = 2, Ras = 16.771200000000093, InternalId = 137,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.721678, Declination = 3.235818, Name = "86 Gam Cet",
            ProperName = "", Rah = 2, Ram = 43, Ras = 18.040799999999322, InternalId = 141,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.658044, Declination = 0.328511, Name = "82 Del Cet",
            ProperName = "", Rah = 2, Ram = 39, Ras = 28.958399999999386, InternalId = 142,
        },
        new()
        {
            Identifier = "CET", RightAscension = 2.37011, Declination = -0.884852, Name = "70 Cet", ProperName = "",
            Rah = 2, Ram = 22, Ras = 12.395999999999873, InternalId = 143,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.857676, Declination = -10.335038, Name = "55 Zet Cet",
            ProperName = "", Rah = 1, Ram = 51, Ras = 27.633600000000456, InternalId = 144,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.734479, Declination = -15.93748, Name = "52 Tau Cet",
            ProperName = "", Rah = 1, Ram = 44, Ras = 4.124400000000561, InternalId = 145,
        },
        new()
        {
            Identifier = "CET", RightAscension = 0.72649, Declination = -17.986605, Name = "16 Bet Cet",
            ProperName = "Diphda", Rah = 0, Ram = 43, Ras = 35.36399999999986, InternalId = 146,
        },
        new()
        {
            Identifier = "CET", RightAscension = 0.323799, Declination = -8.823921, Name = "8 Iot Cet",
            ProperName = "", Rah = 0, Ram = 19, Ras = 25.676400000000065, InternalId = 147,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.143164, Declination = -10.182264, Name = "31 Eta Cet",
            ProperName = "", Rah = 1, Ram = 8, Ras = 35.390400000000255, InternalId = 148,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.40039, Declination = -8.183257, Name = "45 The Cet",
            ProperName = "", Rah = 1, Ram = 24, Ras = 1.4040000000000052, InternalId = 149,
        },
        new()
        {
            Identifier = "CET", RightAscension = 1.857676, Declination = -10.335038, Name = "55 Zet Cet",
            ProperName = "", Rah = 1, Ram = 51, Ras = 27.633600000000456, InternalId = 144,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 10.591166, Declination = -78.607786, Name = "Gam Cha",
            ProperName = "", Rah = 10, Ram = 35, Ras = 28.197599999997756, InternalId = 150,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 12.305812, Declination = -79.31224, Name = "Bet Cha",
            ProperName = "", Rah = 12, Ram = 18, Ras = 20.923199999998342, InternalId = 151,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 10.763087, Declination = -80.540188, Name = "Del 2 Cha",
            ProperName = "", Rah = 10, Ram = 45, Ras = 47.113200000001854, InternalId = 152,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 10.591166, Declination = -78.607786, Name = "Gam Cha",
            ProperName = "", Rah = 10, Ram = 35, Ras = 28.197599999997756, InternalId = 150,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 8.308703, Declination = -76.919722, Name = "Alp Cha",
            ProperName = "", Rah = 8, Ram = 18, Ras = 31.33079999999826, InternalId = 153,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 8.344115, Declination = -77.484477, Name = "The Cha",
            ProperName = "", Rah = 8, Ram = 20, Ras = 38.81400000000148, InternalId = 154,
        },
        new()
        {
            Identifier = "CHA", RightAscension = 9.40268, Declination = -80.786876, Name = "Iot Cha",
            ProperName = "", Rah = 9, Ram = 24, Ras = 9.648000000000456, InternalId = 155,
        },
        new()
        {
            Identifier = "CIR", RightAscension = 15.291917, Declination = -58.801208, Name = "Bet Cir",
            ProperName = "", Rah = 15, Ram = 17, Ras = 30.901199999999164, InternalId = 156,
        },
        new()
        {
            Identifier = "CIR", RightAscension = 14.708492, Declination = -64.975138, Name = "Alp Cir",
            ProperName = "", Rah = 14, Ram = 42, Ras = 30.571199999999, InternalId = 157,
        },
        new()
        {
            Identifier = "CIR", RightAscension = 15.389625, Declination = -59.320787, Name = "Gam Cir",
            ProperName = "", Rah = 15, Ram = 23, Ras = 22.650000000001903, InternalId = 158,
        },
        new()
        {
            Identifier = "COL", RightAscension = 6.368564, Declination = -33.4364, Name = "Del Col",
            ProperName = "", Rah = 6, Ram = 22, Ras = 6.830400000000503, InternalId = 159,
        },
        new()
        {
            Identifier = "COL", RightAscension = 6.275871, Declination = -35.140519, Name = "Kap Col",
            ProperName = "", Rah = 6, Ram = 16, Ras = 33.13560000000153, InternalId = 160,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.958947, Declination = -35.28328, Name = "Gam Col",
            ProperName = "", Rah = 5, Ram = 57, Ras = 32.20920000000093, InternalId = 161,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.849329, Declination = -35.768309, Name = "Bet Col",
            ProperName = "", Rah = 5, Ram = 50, Ras = 57.58439999999987, InternalId = 162,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.660817, Declination = -34.074108, Name = "Alp Col",
            ProperName = "Phakt", Rah = 5, Ram = 39, Ras = 38.94119999999908, InternalId = 163,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.520209, Declination = -35.470519, Name = "Eps Col",
            ProperName = "", Rah = 5, Ram = 31, Ras = 12.75240000000113, InternalId = 164,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.849329, Declination = -35.768309, Name = "Bet Col",
            ProperName = "", Rah = 5, Ram = 50, Ras = 57.58439999999987, InternalId = 162,
        },
        new()
        {
            Identifier = "COL", RightAscension = 5.985778, Declination = -42.815135, Name = "Eta Col",
            ProperName = "", Rah = 5, Ram = 59, Ras = 8.800799999999542, InternalId = 165,
        },
        new()
        {
            Identifier = "COM", RightAscension = 13.166469, Declination = 17.529431, Name = "42 Alp Com",
            ProperName = "", Rah = 13, Ram = 9, Ras = 59.288399999997544, InternalId = 166,
        },
        new()
        {
            Identifier = "COM", RightAscension = 13.197904, Declination = 27.878183, Name = "43 Bet Com",
            ProperName = "", Rah = 13, Ram = 11, Ras = 52.45439999999794, InternalId = 167,
        },
        new()
        {
            Identifier = "COM", RightAscension = 12.448966, Declination = 28.268423, Name = "15 Gam Com",
            ProperName = "", Rah = 12, Ram = 26, Ras = 56.277600000001456, InternalId = 168,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 18.814024, Declination = -43.680047, Name = "Eta 1 CrA",
            ProperName = "", Rah = 18, Ram = 48, Ras = 50.486399999999335, InternalId = 169,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.051907, Declination = -42.095105, Name = "Zet CrA",
            ProperName = "", Rah = 19, Ram = 3, Ras = 6.865199999999722, InternalId = 170,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.139156, Declination = -40.496703, Name = "Del CrA",
            ProperName = "", Rah = 19, Ram = 8, Ras = 20.961599999999414, InternalId = 171,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.167154, Declination = -39.340796, Name = "Bet CrA",
            ProperName = "", Rah = 19, Ram = 10, Ras = 1.7544000000001225, InternalId = 172,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.157869, Declination = -37.904474, Name = "Alp CrA",
            ProperName = "", Rah = 19, Ram = 9, Ras = 28.32840000000575, InternalId = 173,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 19.106971, Declination = -37.063437, Name = "Gam CrA",
            ProperName = "", Rah = 19, Ram = 6, Ras = 25.095600000005312, InternalId = 174,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 18.978721, Declination = -37.107357, Name = "Eps CrA",
            ProperName = "", Rah = 18, Ram = 58, Ras = 43.3956000000006, InternalId = 175,
        },
        new()
        {
            Identifier = "CRA", RightAscension = 18.729706, Declination = -38.323441, Name = "Lam CrA",
            ProperName = "", Rah = 18, Ram = 43, Ras = 46.94160000000065, InternalId = 176,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.548829, Declination = 31.359133, Name = "4 The CrB",
            ProperName = "", Rah = 15, Ram = 32, Ras = 55.78439999999847, InternalId = 177,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.463818, Declination = 29.105703, Name = "3 Bet CrB",
            ProperName = "", Rah = 15, Ram = 27, Ras = 49.74479999999939, InternalId = 178,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.578128, Declination = 26.714693, Name = "5 Alp CrB",
            ProperName = "Alphekka", Rah = 15, Ram = 34, Ras = 41.26079999999837, InternalId = 179,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.712381, Declination = 26.295637, Name = "8 Gam CrB",
            ProperName = "", Rah = 15, Ram = 42, Ras = 44.571600000002306, InternalId = 180,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 15.959794, Declination = 26.87788, Name = "13 Eps CrB",
            ProperName = "", Rah = 15, Ram = 57, Ras = 35.258400000001885, InternalId = 181,
        },
        new()
        {
            Identifier = "CRB", RightAscension = 16.024047, Declination = 29.851061, Name = "14 Iot CrB",
            ProperName = "", Rah = 16, Ram = 1, Ras = 26.569199999998148, InternalId = 182,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.140225, Declination = -24.728875, Name = "1 Alp Crv",
            ProperName = "", Rah = 12, Ram = 8, Ras = 24.80999999999697, InternalId = 183,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.168746, Declination = -22.619766, Name = "2 Eps Crv",
            ProperName = "", Rah = 12, Ram = 10, Ras = 7.485600000001858, InternalId = 184,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.573121, Declination = -23.396759, Name = "9 Bet Crv",
            ProperName = "Kraz", Rah = 12, Ram = 34, Ras = 23.23560000000162, InternalId = 185,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.497739, Declination = -16.515432, Name = "7 Del Crv",
            ProperName = "Algorab", Rah = 12, Ram = 29, Ras = 51.86039999999734, InternalId = 186,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.263437, Declination = -17.541929, Name = "4 Gam Crv",
            ProperName = "Gienah Ghurab", Rah = 12, Ram = 15, Ras = 48.37319999999892, InternalId = 187,
        },
        new()
        {
            Identifier = "CRV", RightAscension = 12.168746, Declination = -22.619766, Name = "2 Eps Crv",
            ProperName = "", Rah = 12, Ram = 10, Ras = 7.485600000001858, InternalId = 184,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.933599, Declination = -17.150829, Name = "30 Eta Crt",
            ProperName = "", Rah = 11, Ram = 56, Ras = 0.956399999996993, InternalId = 188,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.746049, Declination = -18.350674, Name = "27 Zet Crt",
            ProperName = "", Rah = 11, Ram = 44, Ras = 45.77639999999765, InternalId = 189,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.414702, Declination = -17.68401, Name = "15 Gam Crt",
            ProperName = "", Rah = 11, Ram = 24, Ras = 52.927200000000376, InternalId = 190,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.194302, Declination = -22.825847, Name = "11 Bet Crt",
            ProperName = "", Rah = 11, Ram = 11, Ras = 39.48720000000156, InternalId = 191,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 10.996244, Declination = -18.298783, Name = "7 Alp Crt",
            ProperName = "", Rah = 10, Ram = 59, Ras = 46.47840000000305, InternalId = 192,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.322347, Declination = -14.778541, Name = "12 Del Crt",
            ProperName = "", Rah = 11, Ram = 19, Ras = 20.449200000002232, InternalId = 193,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.414702, Declination = -17.68401, Name = "15 Gam Crt",
            ProperName = "", Rah = 11, Ram = 24, Ras = 52.927200000000376, InternalId = 190,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.322347, Declination = -14.778541, Name = "12 Del Crt",
            ProperName = "", Rah = 11, Ram = 19, Ras = 20.449200000002232, InternalId = 193,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.410164, Declination = -10.859323, Name = "14 Eps Crt",
            ProperName = "", Rah = 11, Ram = 24, Ras = 36.590399999999825, InternalId = 194,
        },
        new()
        {
            Identifier = "CRT", RightAscension = 11.611365, Declination = -9.802247, Name = "21 The Crt",
            ProperName = "", Rah = 11, Ram = 36, Ras = 40.91399999999745, InternalId = 195,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.443311, Declination = -63.099092, Name = "Alp 1 Cru",
            ProperName = "Acrux", Rah = 12, Ram = 26, Ras = 35.91959999999838, InternalId = 196,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.519429, Declination = -57.113212, Name = "Gam Cru",
            ProperName = "Gacrux", Rah = 12, Ram = 31, Ras = 9.944400000001918, InternalId = 197,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.252427, Declination = -58.748928, Name = "Del Cru",
            ProperName = "", Rah = 12, Ram = 15, Ras = 8.737200000003043, InternalId = 198,
        },
        new()
        {
            Identifier = "CRU", RightAscension = 12.795359, Declination = -59.688764, Name = "Bet Cru",
            ProperName = "Becrux", Rah = 12, Ram = 47, Ras = 43.29239999999817, InternalId = 199,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 21.215607, Declination = 30.226916, Name = "64 Zet Cyg",
            ProperName = "", Rah = 21, Ram = 12, Ras = 56.18519999999474, InternalId = 200,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.770178, Declination = 33.970256, Name = "53 Eps Cyg",
            ProperName = "Gienah", Rah = 20, Ram = 46, Ras = 12.640800000004715, InternalId = 201,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.370473, Declination = 40.256679, Name = "37 Gam Cyg",
            ProperName = "Sadr", Rah = 20, Ram = 22, Ras = 13.70280000000188, InternalId = 202,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.749574, Declination = 45.13081, Name = "18 Del Cyg",
            ProperName = "", Rah = 19, Ram = 44, Ras = 58.46639999999685, InternalId = 203,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.607372, Declination = 50.221103, Name = "13 The Cyg",
            ProperName = "", Rah = 19, Ram = 36, Ras = 26.539200000005756, InternalId = 204,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.495098, Declination = 51.729779, Name = "10 Iot 2 Cyg",
            ProperName = "", Rah = 19, Ram = 29, Ras = 42.35279999999533, InternalId = 205,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.28504, Declination = 53.368459, Name = "1 Kap Cyg",
            ProperName = "", Rah = 19, Ram = 17, Ras = 6.143999999995087, InternalId = 206,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.690532, Declination = 45.280338, Name = "50 Alp Cyg",
            ProperName = "Deneb", Rah = 20, Ram = 41, Ras = 25.91520000000367, InternalId = 207,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 20.370473, Declination = 40.256679, Name = "37 Gam Cyg",
            ProperName = "Sadr", Rah = 20, Ram = 22, Ras = 13.70280000000188, InternalId = 202,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.938438, Declination = 35.083424, Name = "21 Eta Cyg",
            ProperName = "", Rah = 19, Ram = 56, Ras = 18.376800000005122, InternalId = 208,
        },
        new()
        {
            Identifier = "CYG", RightAscension = 19.512023, Declination = 27.959681, Name = "6 Bet 1 Cyg",
            ProperName = "Albireo", Rah = 19, Ram = 30, Ras = 43.28279999999722, InternalId = 209,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.553547, Declination = 11.303263, Name = "2 Eps Del",
            ProperName = "", Rah = 20, Ram = 33, Ras = 12.769199999993486, InternalId = 210,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.625816, Declination = 14.595087, Name = "6 Bet Del",
            ProperName = "", Rah = 20, Ram = 37, Ras = 32.93760000000123, InternalId = 211,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.660635, Declination = 15.912072, Name = "9 Alp Del",
            ProperName = "", Rah = 20, Ram = 39, Ras = 38.285999999997024, InternalId = 212,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.77764, Declination = 16.124296, Name = "12 Gam 2 Del",
            ProperName = "", Rah = 20, Ram = 46, Ras = 39.5040000000058, InternalId = 213,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.724315, Declination = 15.074581, Name = "11 Del Del",
            ProperName = "", Rah = 20, Ram = 43, Ras = 27.53400000000252, InternalId = 214,
        },
        new()
        {
            Identifier = "DEL", RightAscension = 20.625816, Declination = 14.595087, Name = "6 Bet Del",
            ProperName = "", Rah = 20, Ram = 37, Ras = 32.93760000000123, InternalId = 211,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 4.267097, Declination = -51.486648, Name = "Gam Dor",
            ProperName = "", Rah = 4, Ram = 16, Ras = 1.549199999998918, InternalId = 215,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 4.566598, Declination = -55.044975, Name = "Alp Dor",
            ProperName = "", Rah = 4, Ram = 33, Ras = 59.75279999999961, InternalId = 216,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.091853, Declination = -57.472704, Name = "Zet Dor",
            ProperName = "", Rah = 5, Ram = 5, Ras = 30.67080000000148, InternalId = 217,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.560421, Declination = -62.489825, Name = "Bet Dor",
            ProperName = "", Rah = 5, Ram = 33, Ras = 37.51559999999925, InternalId = 218,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.901658, Declination = -63.089627, Name = "", ProperName = "",
            Rah = 5, Ram = 54, Ras = 5.968800000000973, InternalId = 219,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.560421, Declination = -62.489825, Name = "Bet Dor",
            ProperName = "", Rah = 5, Ram = 33, Ras = 37.51559999999925, InternalId = 218,
        },
        new()
        {
            Identifier = "DOR", RightAscension = 5.746223, Declination = -65.735526, Name = "Del Dor",
            ProperName = "", Rah = 5, Ram = 44, Ras = 46.40279999999888, InternalId = 220,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.943437, Declination = 51.488895, Name = "33 Gam Dra",
            ProperName = "Etamin", Rah = 17, Ram = 56, Ras = 36.37319999999784, InternalId = 221,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.507213, Declination = 52.301387, Name = "23 Bet Dra",
            ProperName = "Rastaban", Rah = 17, Ram = 30, Ras = 25.96680000000049, InternalId = 222,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.537767, Declination = 55.172958, Name = "25 Nu 2 Dra",
            ProperName = "", Rah = 17, Ram = 32, Ras = 15.961199999995612, InternalId = 223,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.892134, Declination = 56.872643, Name = "32 Xi Dra",
            ProperName = "", Rah = 17, Ram = 53, Ras = 31.682399999995248, InternalId = 224,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.943437, Declination = 51.488895, Name = "33 Gam Dra",
            ProperName = "Etamin", Rah = 17, Ram = 56, Ras = 36.37319999999784, InternalId = 221,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.892134, Declination = 56.872643, Name = "32 Xi Dra",
            ProperName = "", Rah = 17, Ram = 53, Ras = 31.682399999995248, InternalId = 224,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 19.209225, Declination = 67.661541, Name = "57 Del Dra",
            ProperName = "", Rah = 19, Ram = 12, Ras = 33.20999999999994, InternalId = 225,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 19.80285, Declination = 70.26793, Name = "63 Eps Dra",
            ProperName = "", Rah = 19, Ram = 48, Ras = 10.259999999997671, InternalId = 226,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 19.259229, Declination = 73.355468, Name = "60 Tau Dra",
            ProperName = "", Rah = 19, Ram = 15, Ras = 33.22440000000455, InternalId = 227,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 18.350736, Declination = 72.732843, Name = "44 Chi Dra",
            ProperName = "", Rah = 18, Ram = 21, Ras = 2.6496000000046482, InternalId = 228,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.698978, Declination = 72.148843, Name = "31 Psi 1 Dra",
            ProperName = "", Rah = 17, Ram = 41, Ras = 56.3208000000011, InternalId = 229,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 17.146448, Declination = 65.714683, Name = "22 Zet Dra",
            ProperName = "", Rah = 17, Ram = 8, Ras = 47.21279999999809, InternalId = 230,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 16.39986, Declination = 61.514213, Name = "14 Eta Dra",
            ProperName = "", Rah = 16, Ram = 23, Ras = 59.49600000000108, InternalId = 231,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 16.031532, Declination = 58.565251, Name = "13 The Dra",
            ProperName = "", Rah = 16, Ram = 1, Ras = 53.51519999999482, InternalId = 232,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 15.415494, Declination = 58.966065, Name = "12 Iot Dra",
            ProperName = "", Rah = 15, Ram = 24, Ras = 55.77840000000243, InternalId = 233,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 14.073165, Declination = 64.37585, Name = "11 Alp Dra",
            ProperName = "Thuban", Rah = 14, Ram = 4, Ras = 23.393999999998133, InternalId = 234,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 12.558058, Declination = 69.788238, Name = "5 Kap Dra",
            ProperName = "", Rah = 12, Ram = 33, Ras = 29.008800000002832, InternalId = 235,
        },
        new()
        {
            Identifier = "DRA", RightAscension = 11.523407, Declination = 69.331076, Name = "1 Lam Dra",
            ProperName = "", Rah = 11, Ram = 31, Ras = 24.265200000002054, InternalId = 236,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.263731, Declination = 5.247845, Name = "8 Alp Equ",
            ProperName = "", Rah = 21, Ram = 15, Ras = 49.431599999999776, InternalId = 237,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.381559, Declination = 6.81114, Name = "10 Bet Equ",
            ProperName = "", Rah = 21, Ram = 22, Ras = 53.61239999999763, InternalId = 238,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.241337, Declination = 10.006981, Name = "7 Del Equ",
            ProperName = "", Rah = 21, Ram = 14, Ras = 28.813200000005267, InternalId = 239,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.172361, Declination = 10.131579, Name = "5 Gam Equ",
            ProperName = "", Rah = 21, Ram = 10, Ras = 20.499599999995187, InternalId = 240,
        },
        new()
        {
            Identifier = "EQU", RightAscension = 21.263731, Declination = 5.247845, Name = "8 Alp Equ",
            ProperName = "", Rah = 21, Ram = 15, Ras = 49.431599999999776, InternalId = 237,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 5.15244, Declination = -8.754081, Name = "69 Lam Eri",
            ProperName = "", Rah = 5, Ram = 9, Ras = 8.78400000000129, InternalId = 241,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 5.130829, Declination = -5.086446, Name = "67 Bet Eri",
            ProperName = "Cursa", Rah = 5, Ram = 7, Ras = 50.984400000001095, InternalId = 242,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.881575, Declination = -5.452695, Name = "61 Ome Eri",
            ProperName = "", Rah = 4, Ram = 52, Ras = 53.669999999999085, InternalId = 243,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.605317, Declination = -3.352459, Name = "48 Nu Eri",
            ProperName = "", Rah = 4, Ram = 36, Ras = 19.141200000001255, InternalId = 244,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.197761, Declination = -6.837581, Name = "38 Omi 1 Eri",
            ProperName = "", Rah = 4, Ram = 11, Ras = 51.93959999999952, InternalId = 245,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.967157, Declination = -13.508515, Name = "34 Gam Eri",
            ProperName = "Zaurak", Rah = 3, Ram = 58, Ras = 1.765199999999334, InternalId = 246,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.769037, Declination = -12.101589, Name = "26 Pi Eri",
            ProperName = "", Rah = 3, Ram = 46, Ras = 8.533199999999708, InternalId = 247,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.720806, Declination = -9.763395, Name = "23 Del Eri",
            ProperName = "", Rah = 3, Ram = 43, Ras = 14.901600000000181, InternalId = 248,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.548848, Declination = -9.458262, Name = "18 Eps Eri",
            ProperName = "", Rah = 3, Ram = 32, Ras = 55.85280000000004, InternalId = 249,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.940458, Declination = -8.898144, Name = "3 Eta Eri",
            ProperName = "", Rah = 2, Ram = 56, Ras = 25.648800000000005, InternalId = 250,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.751715, Declination = -18.572563, Name = "1 Tau 1 Eri",
            ProperName = "", Rah = 2, Ram = 45, Ras = 6.17399999999968, InternalId = 251,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.039863, Declination = -23.624472, Name = "11 Tau 3 Eri",
            ProperName = "", Rah = 3, Ram = 2, Ras = 23.506799999999934, InternalId = 252,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.325278, Declination = -21.757864, Name = "16 Tau 4 Eri",
            ProperName = "", Rah = 3, Ram = 19, Ras = 31.000799999999895, InternalId = 253,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.563132, Declination = -21.632883, Name = "19 Tau 5 Eri",
            ProperName = "", Rah = 3, Ram = 33, Ras = 47.275199999999714, InternalId = 254,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.780804, Declination = -23.249723, Name = "27 Tau 6 Eri",
            ProperName = "", Rah = 3, Ram = 46, Ras = 50.89439999999921, InternalId = 255,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.895195, Declination = -24.61223, Name = "33 Tau 8 Eri",
            ProperName = "", Rah = 3, Ram = 53, Ras = 42.70200000000077, InternalId = 256,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.998745, Declination = -24.016215, Name = "36 Tau 9 Eri",
            ProperName = "", Rah = 3, Ram = 59, Ras = 55.48200000000016, InternalId = 257,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.55849, Declination = -29.766492, Name = "50 Ups 1 Eri",
            ProperName = "", Rah = 4, Ram = 33, Ras = 30.56399999999959, InternalId = 258,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.592512, Declination = -30.562341, Name = "52 Ups 2 Eri",
            ProperName = "", Rah = 4, Ram = 35, Ras = 33.043200000000404, InternalId = 259,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.400613, Declination = -34.016846, Name = "43 Eri",
            ProperName = "", Rah = 4, Ram = 24, Ras = 2.206799999999509, InternalId = 260,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 4.298237, Declination = -33.798348, Name = "41 Ups 4 Eri",
            ProperName = "", Rah = 4, Ram = 17, Ras = 53.653200000001135, InternalId = 261,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.824237, Declination = -36.20025, Name = "", ProperName = "",
            Rah = 3, Ram = 49, Ras = 27.253200000000444, InternalId = 262,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.809963, Declination = -37.620155, Name = "", ProperName = "",
            Rah = 3, Ram = 48, Ras = 35.866800000000595, InternalId = 262,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 3.331944, Declination = -43.069784, Name = "",
            ProperName = "82 G. Eri", Rah = 3, Ram = 19, Ras = 54.99840000000012, InternalId = 263,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.971023, Declination = -40.304672, Name = "The 1 Eri",
            ProperName = "Acamar", Rah = 2, Ram = 58, Ras = 15.682800000000663, InternalId = 264,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.677781, Declination = -39.855375, Name = "Iot Eri",
            ProperName = "", Rah = 2, Ram = 40, Ras = 40.011600000000016, InternalId = 265,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.449755, Declination = -47.70384, Name = "Kap Eri",
            ProperName = "", Rah = 2, Ram = 26, Ras = 59.11800000000041, InternalId = 266,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 2.275154, Declination = -51.512165, Name = "Phi Eri",
            ProperName = "", Rah = 2, Ram = 16, Ras = 30.55440000000045, InternalId = 267,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 1.932564, Declination = -51.608896, Name = "Chi Eri",
            ProperName = "", Rah = 1, Ram = 55, Ras = 57.230399999999946, InternalId = 268,
        },
        new()
        {
            Identifier = "ERI", RightAscension = 1.628556, Declination = -57.236757, Name = "Alp Eri",
            ProperName = "Achernar", Rah = 1, Ram = 37, Ras = 42.80159999999951, InternalId = 269,
        },
        new()
        {
            Identifier = "FOR", RightAscension = 3.201249, Declination = -28.987618, Name = "Alp For",
            ProperName = "", Rah = 3, Ram = 12, Ras = 4.496399999999201, InternalId = 270,
        },
        new()
        {
            Identifier = "FOR", RightAscension = 2.818169, Declination = -32.405898, Name = "Bet For",
            ProperName = "", Rah = 2, Ram = 49, Ras = 5.408400000000579, InternalId = 271,
        },
        new()
        {
            Identifier = "FOR", RightAscension = 2.074844, Declination = -29.296819, Name = "Nu For",
            ProperName = "", Rah = 2, Ram = 4, Ras = 29.43840000000048, InternalId = 272,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.754824, Declination = 12.895591, Name = "31 Xi Gem",
            ProperName = "", Rah = 6, Ram = 45, Ras = 17.36640000000058, InternalId = 273,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.628528, Declination = 16.399252, Name = "24 Gam Gem",
            ProperName = "Alhena", Rah = 6, Ram = 37, Ras = 42.700800000000605, InternalId = 274,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.068481, Declination = 20.570297, Name = "43 Zet Gem",
            ProperName = "", Rah = 7, Ram = 4, Ras = 6.531600000000854, InternalId = 275,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.335383, Declination = 21.98232, Name = "55 Del Gem",
            ProperName = "", Rah = 7, Ram = 20, Ras = 7.378800000000818, InternalId = 276,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.740793, Declination = 24.397993, Name = "77 Kap Gem",
            ProperName = "", Rah = 7, Ram = 44, Ras = 26.85480000000031, InternalId = 277,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.755277, Declination = 28.026199, Name = "78 Bet Gem",
            ProperName = "Pollux", Rah = 7, Ram = 45, Ras = 18.997200000001513, InternalId = 278,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.576634, Declination = 31.888276, Name = "66 Alp Gem",
            ProperName = "Castor", Rah = 7, Ram = 34, Ras = 35.882400000001184, InternalId = 279,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.485195, Declination = 31.78455, Name = "62 Rho Gem",
            ProperName = "", Rah = 7, Ram = 29, Ras = 6.702000000000141, InternalId = 280,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 7.185659, Declination = 30.245163, Name = "46 Tau Gem",
            ProperName = "", Rah = 7, Ram = 11, Ras = 8.372400000000912, InternalId = 281,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.732202, Declination = 25.131124, Name = "27 Eps Gem",
            ProperName = "", Rah = 6, Ram = 43, Ras = 55.92720000000004, InternalId = 282,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.382673, Declination = 22.513586, Name = "13 Mu Gem",
            ProperName = "", Rah = 6, Ram = 22, Ras = 57.62279999999864, InternalId = 283,
        },
        new()
        {
            Identifier = "GEM", RightAscension = 6.247961, Declination = 22.506799, Name = "7 Eta Gem",
            ProperName = "", Rah = 6, Ram = 14, Ras = 52.65960000000034, InternalId = 284,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 23.014677, Declination = -52.754137, Name = "Zet Gru",
            ProperName = "", Rah = 23, Ram = 0, Ras = 52.83719999999619, InternalId = 285,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.809239, Declination = -51.316864, Name = "Eps Gru",
            ProperName = "", Rah = 22, Ram = 48, Ras = 33.26040000000559, InternalId = 286,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.711115, Declination = -46.884577, Name = "Bet Gru",
            ProperName = "", Rah = 22, Ram = 42, Ras = 40.01399999999835, InternalId = 287,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.487825, Declination = -43.495565, Name = "Del 1 Gru",
            ProperName = "", Rah = 22, Ram = 29, Ras = 16.170000000003014, InternalId = 288,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.260253, Declination = -41.3467, Name = "Mu 1 Gru",
            ProperName = "", Rah = 22, Ram = 15, Ras = 36.91079999999545, InternalId = 289,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.101914, Declination = -39.543353, Name = "Lam Gru",
            ProperName = "", Rah = 22, Ram = 6, Ras = 6.890400000002595, InternalId = 290,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 21.898808, Declination = -37.364852, Name = "Gam Gru",
            ProperName = "", Rah = 21, Ram = 53, Ras = 55.708799999996295, InternalId = 291,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 23.11465, Declination = -43.520358, Name = "The Gru",
            ProperName = "", Rah = 23, Ram = 6, Ras = 52.74000000000368, InternalId = 292,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 23.17264, Declination = -45.246711, Name = "Iot Gru",
            ProperName = "", Rah = 23, Ram = 10, Ras = 21.504000000004485, InternalId = 293,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.711115, Declination = -46.884577, Name = "Bet Gru",
            ProperName = "", Rah = 22, Ram = 42, Ras = 40.01399999999835, InternalId = 287,
        },
        new()
        {
            Identifier = "GRU", RightAscension = 22.137209, Declination = -46.960975, Name = "Alp Gru",
            ProperName = "Alnair", Rah = 22, Ram = 8, Ras = 13.952399999994903, InternalId = 294,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.657747, Declination = 46.006332, Name = "85 Iot Her",
            ProperName = "", Rah = 17, Ram = 39, Ras = 27.889200000001814, InternalId = 295,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.93755, Declination = 37.250539, Name = "91 The Her",
            ProperName = "", Rah = 17, Ram = 56, Ras = 15.180000000005922, InternalId = 296,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.394708, Declination = 37.145946, Name = "75 Rho Her",
            ProperName = "", Rah = 17, Ram = 23, Ras = 40.948800000004915, InternalId = 297,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.250788, Declination = 36.809162, Name = "67 Pi Her",
            ProperName = "", Rah = 17, Ram = 15, Ras = 2.8368000000000393, InternalId = 298,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.714933, Declination = 38.922254, Name = "44 Eta Her",
            ProperName = "", Rah = 16, Ram = 42, Ras = 53.75879999999471, InternalId = 299,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.568384, Declination = 42.437041, Name = "35 Sig Her",
            ProperName = "", Rah = 16, Ram = 34, Ras = 6.18239999999366, InternalId = 300,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.329011, Declination = 46.313366, Name = "22 Tau Her",
            ProperName = "", Rah = 16, Ram = 19, Ras = 44.439600000004646, InternalId = 301,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.146162, Declination = 44.934906, Name = "11 Phi Her",
            ProperName = "", Rah = 16, Ram = 8, Ras = 46.18320000000126, InternalId = 302,
        },
        new()
        {
            Identifier = "HER", RightAscension = 18.125708, Declination = 28.762488, Name = "103 Omi Her",
            ProperName = "", Rah = 18, Ram = 7, Ras = 32.548799999998145, InternalId = 303,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.962744, Declination = 29.24788, Name = "92 Xi Her",
            ProperName = "", Rah = 17, Ram = 57, Ras = 45.87840000000271, InternalId = 304,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.774319, Declination = 27.720676, Name = "86 Mu Her",
            ProperName = "", Rah = 17, Ram = 46, Ras = 27.548399999994146, InternalId = 305,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.512308, Declination = 26.110645, Name = "76 Lam Her",
            ProperName = "", Rah = 17, Ram = 30, Ras = 44.308800000003146, InternalId = 306,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.250531, Declination = 24.839204, Name = "65 Del Her",
            ProperName = "", Rah = 17, Ram = 15, Ras = 1.911599999995417, InternalId = 307,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.004827, Declination = 30.926405, Name = "58 Eps Her",
            ProperName = "", Rah = 17, Ram = 0, Ras = 17.377199999995696, InternalId = 308,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.688113, Declination = 31.602726, Name = "40 Zet Her",
            ProperName = "", Rah = 16, Ram = 41, Ras = 17.20680000000465, InternalId = 309,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.503668, Declination = 21.489613, Name = "27 Bet Her",
            ProperName = "Kornephoros", Rah = 16, Ram = 30, Ras = 13.204800000004013, InternalId = 310,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.365338, Declination = 19.15313, Name = "20 Gam Her",
            ProperName = "", Rah = 16, Ram = 21, Ras = 55.21680000000466, InternalId = 311,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.503668, Declination = 21.489613, Name = "27 Bet Her",
            ProperName = "Kornephoros", Rah = 16, Ram = 30, Ras = 13.204800000004013, InternalId = 310,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.244127, Declination = 14.390333, Name = "64 Alp 1 Her",
            ProperName = "Rasalgethi", Rah = 17, Ram = 14, Ras = 38.85719999999593, InternalId = 312,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.250788, Declination = 36.809162, Name = "67 Pi Her",
            ProperName = "", Rah = 17, Ram = 15, Ras = 2.8368000000000393, InternalId = 298,
        },
        new()
        {
            Identifier = "HER", RightAscension = 17.004827, Declination = 30.926405, Name = "58 Eps Her",
            ProperName = "", Rah = 17, Ram = 0, Ras = 17.377199999995696, InternalId = 308,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.714933, Declination = 38.922254, Name = "44 Eta Her",
            ProperName = "", Rah = 16, Ram = 42, Ras = 53.75879999999471, InternalId = 299,
        },
        new()
        {
            Identifier = "HER", RightAscension = 16.688113, Declination = 31.602726, Name = "40 Zet Her",
            ProperName = "", Rah = 16, Ram = 41, Ras = 17.20680000000465, InternalId = 309,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 4.233363, Declination = -42.294368, Name = "Alp Hor",
            ProperName = "", Rah = 4, Ram = 14, Ras = 0.10679999999914092, InternalId = 313,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.709265, Declination = -50.800294, Name = "Iot Hor",
            ProperName = "", Rah = 2, Ram = 42, Ras = 33.35399999999949, InternalId = 314,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.623425, Declination = -52.543086, Name = "Eta Hor",
            ProperName = "", Rah = 2, Ram = 37, Ras = 24.330000000000318, InternalId = 315,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.677666, Declination = -54.549911, Name = "Zet Hor",
            ProperName = "", Rah = 2, Ram = 40, Ras = 39.5975999999997, InternalId = 316,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 3.060239, Declination = -59.737775, Name = "Mu Hor",
            ProperName = "", Rah = 3, Ram = 3, Ras = 36.860400000000546, InternalId = 317,
        },
        new()
        {
            Identifier = "HOR", RightAscension = 2.979939, Declination = -64.071284, Name = "Bet Hor",
            ProperName = "", Rah = 2, Ram = 58, Ras = 47.78039999999959, InternalId = 318,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.92323, Declination = 5.945563, Name = "16 Zet Hya",
            ProperName = "", Rah = 8, Ram = 55, Ras = 23.628000000000917, InternalId = 319,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.72041, Declination = 3.398662, Name = "7 Eta Hya",
            ProperName = "", Rah = 8, Ram = 43, Ras = 13.475999999997557, InternalId = 320,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.645955, Declination = 3.341435, Name = "5 Sig Hya",
            ProperName = "", Rah = 8, Ram = 38, Ras = 45.43800000000271, InternalId = 321,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.627602, Declination = 5.703782, Name = "4 Del Hya",
            ProperName = "", Rah = 8, Ram = 37, Ras = 39.36719999999827, InternalId = 322,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.779587, Declination = 6.418809, Name = "11 Eps Hya",
            ProperName = "", Rah = 8, Ram = 46, Ras = 46.513199999997525, InternalId = 323,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 8.92323, Declination = 5.945563, Name = "16 Zet Hya",
            ProperName = "", Rah = 8, Ram = 55, Ras = 23.628000000000917, InternalId = 319,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.239405, Declination = 2.31428, Name = "22 The Hya",
            ProperName = "", Rah = 9, Ram = 14, Ras = 21.85799999999871, InternalId = 324,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.664267, Declination = -1.14281, Name = "35 Iot Hya",
            ProperName = "", Rah = 9, Ram = 39, Ras = 51.36120000000211, InternalId = 325,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.45979, Declination = -8.658603, Name = "30 Alp Hya",
            ProperName = "Alphard", Rah = 9, Ram = 27, Ras = 35.24399999999967, InternalId = 326,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 9.85797, Declination = -14.846603, Name = "39 Ups 1 Hya",
            ProperName = "", Rah = 9, Ram = 51, Ras = 28.691999999999716, InternalId = 327,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.085408, Declination = -13.064626, Name = "40 Ups 2 Hya",
            ProperName = "", Rah = 10, Ram = 5, Ras = 7.468799999997361, InternalId = 328,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.176467, Declination = -12.354083, Name = "41 Lam Hya",
            ProperName = "", Rah = 10, Ram = 10, Ras = 35.28120000000218, InternalId = 329,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.434842, Declination = -16.83629, Name = "42 Mu Hya",
            ProperName = "", Rah = 10, Ram = 26, Ras = 5.43119999999897, InternalId = 330,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 10.827079, Declination = -16.193648, Name = "Nu Hya",
            ProperName = "", Rah = 10, Ram = 49, Ras = 37.48439999999809, InternalId = 331,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 11.550038, Declination = -31.857625, Name = "Xi Hya",
            ProperName = "", Rah = 11, Ram = 33, Ras = 0.13680000000233505, InternalId = 332,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 11.881813, Declination = -33.908124, Name = "Bet Hya",
            ProperName = "", Rah = 11, Ram = 52, Ras = 54.526799999997344, InternalId = 333,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 13.315359, Declination = -23.171512, Name = "46 Gam Hya",
            ProperName = "", Rah = 13, Ram = 18, Ras = 55.29240000000304, InternalId = 334,
        },
        new()
        {
            Identifier = "HYA", RightAscension = 14.106193, Declination = -26.682361, Name = "49 Pi Hya",
            ProperName = "", Rah = 14, Ram = 6, Ras = 22.294799999997515, InternalId = 335,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 0.427916, Declination = -77.254247, Name = "Bet Hyi",
            ProperName = "", Rah = 0, Ram = 25, Ras = 40.4976, InternalId = 336,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 3.787295, Declination = -74.238962, Name = "Gam Hyi",
            ProperName = "", Rah = 3, Ram = 47, Ras = 14.261999999999508, InternalId = 337,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 2.659799, Declination = -68.266946, Name = "Eps Hyi",
            ProperName = "", Rah = 2, Ram = 39, Ras = 35.27640000000001, InternalId = 338,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 2.362498, Declination = -68.659418, Name = "Del Hyi",
            ProperName = "", Rah = 2, Ram = 21, Ras = 44.99280000000003, InternalId = 339,
        },
        new()
        {
            Identifier = "HYI", RightAscension = 1.979451, Declination = -61.569859, Name = "Alp Hyi",
            ProperName = "", Rah = 1, Ram = 58, Ras = 46.02360000000023, InternalId = 340,
        },
        new()
        {
            Identifier = "IND", RightAscension = 20.626116, Declination = -47.291502, Name = "Alp Ind",
            ProperName = "", Rah = 20, Ram = 37, Ras = 34.017599999998716, InternalId = 341,
        },
        new()
        {
            Identifier = "IND", RightAscension = 21.331096, Declination = -53.449427, Name = "The Ind",
            ProperName = "", Rah = 21, Ram = 19, Ras = 51.945599999995466, InternalId = 342,
        },
        new()
        {
            Identifier = "IND", RightAscension = 21.965293, Declination = -54.992575, Name = "Del Ind",
            ProperName = "", Rah = 21, Ram = 57, Ras = 55.0547999999968, InternalId = 343,
        },
        new()
        {
            Identifier = "IND", RightAscension = 21.331096, Declination = -53.449427, Name = "The Ind",
            ProperName = "", Rah = 21, Ram = 19, Ras = 51.945599999995466, InternalId = 342,
        },
        new()
        {
            Identifier = "IND", RightAscension = 20.913498, Declination = -58.454155, Name = "Bet Ind",
            ProperName = "", Rah = 20, Ram = 54, Ras = 48.592800000002036, InternalId = 344,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.26616, Declination = 37.748737, Name = "1 Lac", ProperName = "",
            Rah = 22, Ram = 15, Ras = 58.17599999999743, InternalId = 345,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.231312, Declination = 39.714927, Name = "", ProperName = "",
            Rah = 22, Ram = 13, Ras = 52.72319999999664, InternalId = 346,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.508128, Declination = 43.123376, Name = "6 Lac",
            ProperName = "", Rah = 22, Ram = 30, Ras = 29.26079999999729, InternalId = 347,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.350428, Declination = 46.536569, Name = "2 Lac",
            ProperName = "", Rah = 22, Ram = 21, Ras = 1.5408000000031397, InternalId = 348,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.492173, Declination = 47.706887, Name = "5 Lac",
            ProperName = "", Rah = 22, Ram = 29, Ras = 31.82280000000388, InternalId = 349,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.408609, Declination = 49.476392, Name = "4 Lac",
            ProperName = "", Rah = 22, Ram = 24, Ras = 30.992399999994326, InternalId = 350,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.521515, Declination = 50.282491, Name = "7 Alp Lac",
            ProperName = "", Rah = 22, Ram = 31, Ras = 17.454000000002836, InternalId = 351,
        },
        new()
        {
            Identifier = "LAC", RightAscension = 22.392675, Declination = 52.229046, Name = "3 Bet Lac",
            ProperName = "", Rah = 22, Ram = 23, Ras = 33.63000000000189, InternalId = 352,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.237335, Declination = 15.42957, Name = "70 The Leo",
            ProperName = "", Rah = 11, Ram = 14, Ras = 14.405999999999452, InternalId = 353,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.235138, Declination = 20.523717, Name = "68 Del Leo",
            ProperName = "Zosma", Rah = 11, Ram = 14, Ras = 6.496799999997038, InternalId = 354,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.817663, Declination = 14.57206, Name = "94 Bet Leo",
            ProperName = "Denebola", Rah = 11, Ram = 49, Ras = 3.586799999998558, InternalId = 355,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 11.237335, Declination = 15.42957, Name = "70 The Leo",
            ProperName = "", Rah = 11, Ram = 14, Ras = 14.405999999999452, InternalId = 353,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.139532, Declination = 11.967207, Name = "32 Alp Leo",
            ProperName = "Regulus", Rah = 10, Ram = 8, Ras = 22.315200000003166, InternalId = 356,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.122209, Declination = 16.762664, Name = "30 Eta Leo",
            ProperName = "", Rah = 10, Ram = 7, Ras = 19.952399999999237, InternalId = 357,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.332873, Declination = 19.841489, Name = "41 Gam 1 Leo",
            ProperName = "Algieba", Rah = 10, Ram = 19, Ras = 58.34279999999757, InternalId = 358,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 10.278171, Declination = 23.417311, Name = "36 Zet Leo",
            ProperName = "", Rah = 10, Ram = 16, Ras = 41.41560000000142, InternalId = 359,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 9.879398, Declination = 26.006951, Name = "24 Mu Leo",
            ProperName = "", Rah = 9, Ram = 52, Ras = 45.83280000000034, InternalId = 360,
        },
        new()
        {
            Identifier = "LEO", RightAscension = 9.764188, Declination = 23.774255, Name = "17 Eps Leo",
            ProperName = "Ras Elased Australis", Rah = 9, Ram = 45, Ras = 51.07680000000272, InternalId = 361,
        },
        new()
        {
            Identifier = "LMI", RightAscension = 10.888526, Declination = 34.214871, Name = "46 LMi",
            ProperName = "", Rah = 10, Ram = 53, Ras = 18.69360000000224, InternalId = 362,
        },
        new()
        {
            Identifier = "LMI", RightAscension = 10.464727, Declination = 36.707212, Name = "31 Bet LMi",
            ProperName = "", Rah = 10, Ram = 27, Ras = 53.01719999999956, InternalId = 363,
        },
        new()
        {
            Identifier = "LMI", RightAscension = 10.123821, Declination = 35.244693, Name = "21 LMi",
            ProperName = "", Rah = 10, Ram = 7, Ras = 25.755599999998246, InternalId = 364,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.940082, Declination = -14.1677, Name = "16 Eta Lep",
            ProperName = "", Rah = 5, Ram = 56, Ras = 24.29520000000105, InternalId = 365,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.782595, Declination = -14.82195, Name = "14 Zet Lep",
            ProperName = "", Rah = 5, Ram = 46, Ras = 57.34199999999876, InternalId = 366,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.545504, Declination = -17.822289, Name = "11 Alp Lep",
            ProperName = "Arneb", Rah = 5, Ram = 32, Ras = 43.81440000000079, InternalId = 367,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.215528, Declination = -16.205468, Name = "5 Mu Lep",
            ProperName = "", Rah = 5, Ram = 12, Ras = 55.90079999999975, InternalId = 368,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.855357, Declination = -20.879089, Name = "15 Del Lep",
            ProperName = "", Rah = 5, Ram = 51, Ras = 19.285199999999, InternalId = 369,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.741057, Declination = -22.448382, Name = "13 Gam Lep",
            ProperName = "", Rah = 5, Ram = 44, Ras = 27.805199999998862, InternalId = 370,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.470756, Declination = -20.759441, Name = "9 Bet Lep",
            ProperName = "Nihal", Rah = 5, Ram = 28, Ras = 14.721599999999002, InternalId = 371,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.091018, Declination = -22.371032, Name = "2 Eps Lep",
            ProperName = "", Rah = 5, Ram = 5, Ras = 27.664800000000174, InternalId = 372,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.545504, Declination = -17.822289, Name = "11 Alp Lep",
            ProperName = "Arneb", Rah = 5, Ram = 32, Ras = 43.81440000000079, InternalId = 367,
        },
        new()
        {
            Identifier = "LEP", RightAscension = 5.470756, Declination = -20.759441, Name = "9 Bet Lep",
            ProperName = "Nihal", Rah = 5, Ram = 28, Ras = 14.721599999999002, InternalId = 371,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.64427, Declination = -29.777754, Name = "40 Tau Lib",
            ProperName = "", Rah = 15, Ram = 38, Ras = 39.37200000000214, InternalId = 373,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.61707, Declination = -28.135079, Name = "39 Ups Lib",
            ProperName = "", Rah = 15, Ram = 37, Ras = 1.45199999999992, InternalId = 374,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.067839, Declination = -25.281965, Name = "20 Sig Lib",
            ProperName = "", Rah = 15, Ram = 4, Ras = 4.220399999997543, InternalId = 375,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 14.847977, Declination = -16.041778, Name = "9 Alp 2 Lib",
            ProperName = "Zubenelgenubi", Rah = 14, Ram = 50, Ras = 52.717200000000595, InternalId = 376,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.283449, Declination = -9.382917, Name = "27 Bet Lib",
            ProperName = "Zubeneschemali", Rah = 15, Ram = 17, Ras = 0.41639999999705246, InternalId = 377,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.592105, Declination = -14.789537, Name = "38 Gam Lib",
            ProperName = "", Rah = 15, Ram = 35, Ras = 31.578000000000237, InternalId = 378,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.897093, Declination = -16.729293, Name = "46 The Lib",
            ProperName = "", Rah = 15, Ram = 53, Ras = 49.53479999999981, InternalId = 379,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.283449, Declination = -9.382917, Name = "27 Bet Lib",
            ProperName = "Zubeneschemali", Rah = 15, Ram = 17, Ras = 0.41639999999705246, InternalId = 377,
        },
        new()
        {
            Identifier = "LIB", RightAscension = 15.067839, Declination = -25.281965, Name = "20 Sig Lib",
            ProperName = "", Rah = 15, Ram = 4, Ras = 4.220399999997543, InternalId = 375,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 16.109874, Declination = -36.802288, Name = "The Lup",
            ProperName = "", Rah = 16, Ram = 6, Ras = 35.54640000000487, InternalId = 380,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 16.002036, Declination = -38.396706, Name = "Eta Lup",
            ProperName = "", Rah = 16, Ram = 0, Ras = 7.329600000001335, InternalId = 381,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.585681, Declination = -41.166757, Name = "Gam Lup",
            ProperName = "", Rah = 15, Ram = 35, Ras = 8.451599999997095, InternalId = 382,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.378021, Declination = -44.689622, Name = "Eps Lup",
            ProperName = "", Rah = 15, Ram = 22, Ras = 40.87560000000148, InternalId = 383,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.198918, Declination = -48.737819, Name = "Kap 1 Lup",
            ProperName = "", Rah = 15, Ram = 11, Ras = 56.10480000000299, InternalId = 384,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.20476, Declination = -52.099247, Name = "Zet Lup",
            ProperName = "", Rah = 15, Ram = 12, Ras = 17.13600000000095, InternalId = 385,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 14.698823, Declination = -47.3882, Name = "Alp Lup",
            ProperName = "", Rah = 14, Ram = 41, Ras = 55.76280000000304, InternalId = 386,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 14.975537, Declination = -43.13396, Name = "Bet Lup",
            ProperName = "", Rah = 14, Ram = 58, Ras = 31.93319999999713, InternalId = 387,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.356201, Declination = -40.647518, Name = "Del Lup",
            ProperName = "", Rah = 15, Ram = 21, Ras = 22.32360000000164, InternalId = 388,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.36344, Declination = -36.261376, Name = "Phi 1 Lup",
            ProperName = "", Rah = 15, Ram = 21, Ras = 48.38400000000242, InternalId = 389,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.849316, Declination = -33.627165, Name = "5 Chi Lup",
            ProperName = "", Rah = 15, Ram = 50, Ras = 57.53759999999972, InternalId = 390,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.585681, Declination = -41.166757, Name = "Gam Lup",
            ProperName = "", Rah = 15, Ram = 35, Ras = 8.451599999997095, InternalId = 382,
        },
        new()
        {
            Identifier = "LUP", RightAscension = 15.356201, Declination = -40.647518, Name = "Del Lup",
            ProperName = "", Rah = 15, Ram = 21, Ras = 22.32360000000164, InternalId = 388,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 9.350925, Declination = 34.392562, Name = "40 Alp Lyn",
            ProperName = "", Rah = 9, Ram = 21, Ras = 3.3300000000006325, InternalId = 391,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 9.314069, Declination = 36.802597, Name = "38 Lyn",
            ProperName = "", Rah = 9, Ram = 18, Ras = 50.648399999999796, InternalId = 392,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 9.010685, Declination = 41.782911, Name = "", ProperName = "",
            Rah = 9, Ram = 0, Ras = 38.4660000000018, InternalId = 393,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 8.380588, Declination = 43.188131, Name = "31 Lyn",
            ProperName = "", Rah = 8, Ram = 22, Ras = 50.11679999999823, InternalId = 394,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 7.445237, Declination = 49.211527, Name = "21 Lyn",
            ProperName = "", Rah = 7, Ram = 26, Ras = 42.85319999999872, InternalId = 395,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 6.954612, Declination = 58.422759, Name = "15 Lyn",
            ProperName = "", Rah = 6, Ram = 57, Ras = 16.603200000000218, InternalId = 396,
        },
        new()
        {
            Identifier = "LYN", RightAscension = 6.327052, Declination = 59.010964, Name = "2 Lyn", ProperName = "",
            Rah = 6, Ram = 19, Ras = 37.38720000000049, InternalId = 397,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.331031, Declination = 36.064547, Name = "1 Kap Lyr",
            ProperName = "", Rah = 18, Ram = 19, Ras = 51.71159999999793, InternalId = 398,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.61564, Declination = 38.783692, Name = "3 Alp Lyr",
            ProperName = "Vega", Rah = 18, Ram = 36, Ras = 56.303999999996755, InternalId = 399,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.739661, Declination = 39.612721, Name = "5 Eps 2 Lyr",
            ProperName = "", Rah = 18, Ram = 44, Ras = 22.779600000006226, InternalId = 400,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.746209, Declination = 37.605115, Name = "6 Zet 1 Lyr",
            ProperName = "", Rah = 18, Ram = 44, Ras = 46.352400000001424, InternalId = 401,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.834665, Declination = 33.362667, Name = "10 Bet Lyr",
            ProperName = "Sheliak", Rah = 18, Ram = 50, Ras = 4.7940000000038285, InternalId = 402,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.982395, Declination = 32.689557, Name = "14 Gam Lyr",
            ProperName = "", Rah = 18, Ram = 58, Ras = 56.622000000001236, InternalId = 403,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.908412, Declination = 36.898613, Name = "12 Del 2 Lyr",
            ProperName = "", Rah = 18, Ram = 54, Ras = 30.283199999994316, InternalId = 404,
        },
        new()
        {
            Identifier = "LYR", RightAscension = 18.746209, Declination = 37.605115, Name = "6 Zet 1 Lyr",
            ProperName = "", Rah = 18, Ram = 44, Ras = 46.352400000001424, InternalId = 401,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 5.045279, Declination = -71.3143, Name = "Bet Men",
            ProperName = "", Rah = 5, Ram = 2, Ras = 43.00439999999945, InternalId = 405,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 4.919765, Declination = -74.936852, Name = "Eta Men",
            ProperName = "", Rah = 4, Ram = 55, Ras = 11.15399999999993, InternalId = 406,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 5.531318, Declination = -76.340964, Name = "Gam Men",
            ProperName = "", Rah = 5, Ram = 31, Ras = 52.74479999999886, InternalId = 407,
        },
        new()
        {
            Identifier = "MEN", RightAscension = 6.170632, Declination = -74.753045, Name = "Alp Men",
            ProperName = "", Rah = 6, Ram = 10, Ras = 14.275200000001254, InternalId = 408,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 21.346008, Declination = -40.809465, Name = "The 1 Mic",
            ProperName = "", Rah = 21, Ram = 20, Ras = 45.6288000000044, InternalId = 409,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 21.298966, Declination = -32.172539, Name = "Eps Mic",
            ProperName = "", Rah = 21, Ram = 17, Ras = 56.27760000000026, InternalId = 410,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 21.021517, Declination = -32.257767, Name = "Gam Mic",
            ProperName = "", Rah = 21, Ram = 1, Ras = 17.461199999997632, InternalId = 411,
        },
        new()
        {
            Identifier = "MIC", RightAscension = 20.8328, Declination = -33.779722, Name = "Alp Mic",
            ProperName = "", Rah = 20, Ram = 49, Ras = 58.079999999996005, InternalId = 412,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.247592, Declination = -6.274776, Name = "5 Gam Mon",
            ProperName = "", Rah = 6, Ram = 14, Ras = 51.33120000000011, InternalId = 413,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.480297, Declination = -7.033062, Name = "11 Bet Mon",
            ProperName = "", Rah = 6, Ram = 28, Ras = 49.06920000000068, InternalId = 414,
        },
        new()
        {
            Identifier = "MON", RightAscension = 7.197739, Declination = -0.492764, Name = "22 Del Mon",
            ProperName = "", Rah = 7, Ram = 11, Ras = 51.86040000000124, InternalId = 415,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.79768, Declination = 2.412159, Name = "18 Mon", ProperName = "",
            Rah = 6, Ram = 47, Ras = 51.64799999999903, InternalId = 416,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.396135, Declination = 4.592865, Name = "8 Eps Mon",
            ProperName = "", Rah = 6, Ram = 23, Ras = 46.08600000000036, InternalId = 417,
        },
        new()
        {
            Identifier = "MON", RightAscension = 6.548396, Declination = 7.332965, Name = "13 Mon", ProperName = "",
            Rah = 6, Ram = 32, Ras = 54.22560000000121, InternalId = 418,
        },
        new()
        {
            Identifier = "MON", RightAscension = 7.197739, Declination = -0.492764, Name = "22 Del Mon",
            ProperName = "", Rah = 7, Ram = 11, Ras = 51.86040000000124, InternalId = 415,
        },
        new()
        {
            Identifier = "MON", RightAscension = 7.687454, Declination = -9.551131, Name = "26 Alp Mon",
            ProperName = "", Rah = 7, Ram = 41, Ras = 14.834399999999182, InternalId = 419,
        },
        new()
        {
            Identifier = "MON", RightAscension = 8.143236, Declination = -2.983786, Name = "29 Zet Mon",
            ProperName = "", Rah = 8, Ram = 8, Ras = 35.649599999999715, InternalId = 420,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 11.760141, Declination = -66.728763, Name = "Lam Mus",
            ProperName = "", Rah = 11, Ram = 45, Ras = 36.50760000000304, InternalId = 421,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.292917, Declination = -67.960736, Name = "Eps Mus",
            ProperName = "", Rah = 12, Ram = 17, Ras = 34.50119999999717, InternalId = 422,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.619739, Declination = -69.135564, Name = "Alp Mus",
            ProperName = "", Rah = 12, Ram = 37, Ras = 11.06039999999684, InternalId = 423,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.771346, Declination = -68.108119, Name = "Bet Mus",
            ProperName = "", Rah = 12, Ram = 46, Ras = 16.84559999999773, InternalId = 424,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.619739, Declination = -69.135564, Name = "Alp Mus",
            ProperName = "", Rah = 12, Ram = 37, Ras = 11.06039999999684, InternalId = 423,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 13.037759, Declination = -71.548855, Name = "Del Mus",
            ProperName = "", Rah = 13, Ram = 2, Ras = 15.932399999997957, InternalId = 425,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.619739, Declination = -69.135564, Name = "Alp Mus",
            ProperName = "", Rah = 12, Ram = 37, Ras = 11.06039999999684, InternalId = 423,
        },
        new()
        {
            Identifier = "MUS", RightAscension = 12.541134, Declination = -72.132988, Name = "Gam Mus",
            ProperName = "", Rah = 12, Ram = 32, Ras = 28.082399999998444, InternalId = 426,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.453067, Declination = -47.554786, Name = "Eps Nor",
            ProperName = "", Rah = 16, Ram = 27, Ras = 11.04120000000275, InternalId = 427,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.330687, Declination = -50.155508, Name = "Gam 2 Nor",
            ProperName = "", Rah = 16, Ram = 19, Ras = 50.473200000003885, InternalId = 428,
        },
        new()
        {
            Identifier = "NOR", RightAscension = 16.053579, Declination = -49.229695, Name = "Eta Nor",
            ProperName = "", Rah = 16, Ram = 3, Ras = 12.884399999996948, InternalId = 429,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 21.691253, Declination = -77.390046, Name = "Nu Oct",
            ProperName = "", Rah = 21, Ram = 41, Ras = 28.51079999999877, InternalId = 430,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 22.767692, Declination = -81.381615, Name = "Bet Oct",
            ProperName = "", Rah = 22, Ram = 46, Ras = 3.6912000000007605, InternalId = 431,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 14.448801, Declination = -83.667884, Name = "Del Oct",
            ProperName = "", Rah = 14, Ram = 26, Ras = 55.683599999998364, InternalId = 432,
        },
        new()
        {
            Identifier = "OCT", RightAscension = 21.691253, Declination = -77.390046, Name = "Nu Oct",
            ProperName = "", Rah = 21, Ram = 41, Ras = 28.51079999999877, InternalId = 430,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.455909, Declination = -29.867033, Name = "45 Oph",
            ProperName = "", Rah = 17, Ram = 27, Ras = 21.272399999993997, InternalId = 433,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.366827, Declination = -24.999545, Name = "42 The Oph",
            ProperName = "", Rah = 17, Ram = 22, Ras = 0.5772000000025423, InternalId = 434,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.439504, Declination = -24.175309, Name = "44 Oph",
            ProperName = "", Rah = 17, Ram = 26, Ras = 22.21439999999797, InternalId = 435,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.350101, Declination = -21.112933, Name = "40 Xi Oph",
            ProperName = "", Rah = 17, Ram = 21, Ras = 0.3635999999952677, InternalId = 436,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.172968, Declination = -15.72491, Name = "35 Eta Oph",
            ProperName = "", Rah = 17, Ram = 10, Ras = 22.684800000003268, InternalId = 437,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.619316, Declination = -10.56709, Name = "13 Zet Oph",
            ProperName = "", Rah = 16, Ram = 37, Ras = 9.537600000004609, InternalId = 438,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.305358, Declination = -4.692511, Name = "2 Eps Oph",
            ProperName = "", Rah = 16, Ram = 18, Ras = 19.28879999999371, InternalId = 439,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.239094, Declination = -3.694323, Name = "1 Del Oph",
            ProperName = "", Rah = 16, Ram = 14, Ras = 20.738400000005285, InternalId = 440,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 16.961139, Declination = 9.375033, Name = "27 Kap Oph",
            ProperName = "", Rah = 16, Ram = 57, Ras = 40.100399999997634, InternalId = 441,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.582241, Declination = 12.560035, Name = "55 Alp Oph",
            ProperName = "Rasalhague", Rah = 17, Ram = 34, Ras = 56.06759999999929, InternalId = 442,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.724543, Declination = 4.567303, Name = "60 Bet Oph",
            ProperName = "Cebalrai", Rah = 17, Ram = 43, Ras = 28.354800000002143, InternalId = 443,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.172968, Declination = -15.72491, Name = "35 Eta Oph",
            ProperName = "", Rah = 17, Ram = 10, Ras = 22.684800000003268, InternalId = 437,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.724543, Declination = 4.567303, Name = "60 Bet Oph",
            ProperName = "Cebalrai", Rah = 17, Ram = 43, Ras = 28.354800000002143, InternalId = 443,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.798211, Declination = 2.707276, Name = "62 Gam Oph",
            ProperName = "", Rah = 17, Ram = 47, Ras = 53.55959999999445, InternalId = 444,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 18.010754, Declination = 2.931568, Name = "67 Oph",
            ProperName = "", Rah = 18, Ram = 0, Ras = 38.71439999999495, InternalId = 445,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 18.090913, Declination = 2.500099, Name = "70 Oph",
            ProperName = "", Rah = 18, Ram = 5, Ras = 27.286800000001694, InternalId = 446,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.798211, Declination = 2.707276, Name = "62 Gam Oph",
            ProperName = "", Rah = 17, Ram = 47, Ras = 53.55959999999445, InternalId = 444,
        },
        new()
        {
            Identifier = "OPH", RightAscension = 17.983775, Declination = -9.773632, Name = "64 Nu Oph",
            ProperName = "", Rah = 17, Ram = 59, Ras = 1.5900000000052206, InternalId = 447,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.242298, Declination = -8.20164, Name = "19 Bet Ori",
            ProperName = "Rigel", Rah = 5, Ram = 14, Ras = 32.272799999999634, InternalId = 448,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.795941, Declination = -9.669605, Name = "53 Kap Ori",
            ProperName = "Saiph", Rah = 5, Ram = 47, Ras = 45.38760000000006, InternalId = 449,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.679313, Declination = -1.942572, Name = "50 Zet Ori",
            ProperName = "Alnitak", Rah = 5, Ram = 40, Ras = 45.52679999999874, InternalId = 450,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.919529, Declination = 7.407063, Name = "58 Alp Ori",
            ProperName = "Betelgeuse", Rah = 5, Ram = 55, Ras = 10.30439999999948, InternalId = 451,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.039722, Declination = 9.647276, Name = "61 Mu Ori",
            ProperName = "", Rah = 6, Ram = 2, Ras = 22.999200000000926, InternalId = 452,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.198999, Declination = 14.208765, Name = "70 Xi Ori",
            ProperName = "", Rah = 6, Ram = 11, Ras = 56.396399999998984, InternalId = 453,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.065329, Declination = 20.138452, Name = "62 Chi 2 Ori",
            ProperName = "", Rah = 6, Ram = 3, Ras = 55.184400000000686, InternalId = 454,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.198999, Declination = 14.208765, Name = "70 Xi Ori",
            ProperName = "", Rah = 6, Ram = 11, Ras = 56.396399999998984, InternalId = 453,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 6.126201, Declination = 14.768472, Name = "67 Nu Ori",
            ProperName = "", Rah = 6, Ram = 7, Ras = 34.32360000000002, InternalId = 455,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.906386, Declination = 20.276174, Name = "54 Chi 1 Ori",
            ProperName = "", Rah = 5, Ram = 54, Ras = 22.98960000000121, InternalId = 456,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.919529, Declination = 7.407063, Name = "58 Alp Ori",
            ProperName = "Betelgeuse", Rah = 5, Ram = 55, Ras = 10.30439999999948, InternalId = 451,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.585633, Declination = 9.934158, Name = "39 Lam Ori",
            ProperName = "", Rah = 5, Ram = 35, Ras = 8.27879999999852, InternalId = 457,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.418851, Declination = 6.349702, Name = "24 Gam Ori",
            ProperName = "Bellatrix", Rah = 5, Ram = 25, Ras = 7.863600000000237, InternalId = 458,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.830669, Declination = 6.961276, Name = "1 Pi 3 Ori",
            ProperName = "", Rah = 4, Ram = 49, Ras = 50.40840000000122, InternalId = 459,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.843534, Declination = 8.900176, Name = "2 Pi 2 Ori",
            ProperName = "", Rah = 4, Ram = 50, Ras = 36.72239999999989, InternalId = 460,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.914924, Declination = 10.150833, Name = "7 Pi 1 Ori",
            ProperName = "", Rah = 4, Ram = 54, Ras = 53.726400000000176, InternalId = 461,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.830669, Declination = 6.961276, Name = "1 Pi 3 Ori",
            ProperName = "", Rah = 4, Ram = 49, Ras = 50.40840000000122, InternalId = 459,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.853434, Declination = 5.605104, Name = "3 Pi 4 Ori",
            ProperName = "", Rah = 4, Ram = 51, Ras = 12.362400000000173, InternalId = 462,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.904193, Declination = 2.440672, Name = "8 Pi 5 Ori",
            ProperName = "", Rah = 4, Ram = 54, Ras = 15.094800000000808, InternalId = 463,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 4.975806, Declination = 1.714016, Name = "10 Pi 6 Ori",
            ProperName = "", Rah = 4, Ram = 58, Ras = 32.901600000001395, InternalId = 464,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.418851, Declination = 6.349702, Name = "24 Gam Ori",
            ProperName = "Bellatrix", Rah = 5, Ram = 25, Ras = 7.863600000000237, InternalId = 458,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.533445, Declination = -0.299092, Name = "34 Del Ori",
            ProperName = "Mintaka", Rah = 5, Ram = 32, Ras = 0.40200000000143454, InternalId = 465,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.293442, Declination = -6.844409, Name = "20 Tau Ori",
            ProperName = "", Rah = 5, Ram = 17, Ras = 36.39119999999916, InternalId = 466,
        },
        new()
        {
            Identifier = "ORI", RightAscension = 5.242298, Declination = -8.20164, Name = "19 Bet Ori",
            ProperName = "Rigel", Rah = 5, Ram = 14, Ras = 32.272799999999634, InternalId = 448,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.749314, Declination = -66.203212, Name = "Bet Pav",
            ProperName = "", Rah = 20, Ram = 44, Ras = 57.53039999999392, InternalId = 467,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 21.440705, Declination = -65.366198, Name = "Gam Pav",
            ProperName = "", Rah = 21, Ram = 26, Ras = 26.53800000000439, InternalId = 468,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.749314, Declination = -66.203212, Name = "Bet Pav",
            ProperName = "", Rah = 20, Ram = 44, Ras = 57.53039999999392, InternalId = 467,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.427459, Declination = -56.73509, Name = "Alp Pav",
            ProperName = "Peacock", Rah = 20, Ram = 25, Ras = 38.85239999999606, InternalId = 469,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.749314, Declination = -66.203212, Name = "Bet Pav",
            ProperName = "", Rah = 20, Ram = 44, Ras = 57.53039999999392, InternalId = 467,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.145157, Declination = -66.182068, Name = "Del Pav",
            ProperName = "", Rah = 20, Ram = 8, Ras = 42.565200000003934, InternalId = 470,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.870288, Declination = -62.187593, Name = "Lam Pav",
            ProperName = "", Rah = 18, Ram = 52, Ras = 13.03679999999492, InternalId = 471,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.387117, Declination = -61.493901, Name = "Xi Pav",
            ProperName = "", Rah = 18, Ram = 23, Ras = 13.621199999999668, InternalId = 472,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.143, Declination = -63.668553, Name = "Pi Pav", ProperName = "",
            Rah = 18, Ram = 8, Ras = 34.80000000000246, InternalId = 473,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 17.762221, Declination = -64.723871, Name = "Eta Pav",
            ProperName = "", Rah = 17, Ram = 45, Ras = 43.995600000000934, InternalId = 474,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 18.71726, Declination = -71.428113, Name = "Zet Pav",
            ProperName = "", Rah = 18, Ram = 43, Ras = 2.135999999998406, InternalId = 475,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.009845, Declination = -72.910504, Name = "Eps Pav",
            ProperName = "", Rah = 20, Ram = 0, Ras = 35.44199999999478, InternalId = 476,
        },
        new()
        {
            Identifier = "PAV", RightAscension = 20.749314, Declination = -66.203212, Name = "Bet Pav",
            ProperName = "", Rah = 20, Ram = 44, Ras = 57.53039999999392, InternalId = 467,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 0.139791, Declination = 29.090432, Name = "21 Alp And",
            ProperName = "Alpheratz", Rah = 0, Ram = 8, Ras = 23.247600000000002, InternalId = 477,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 0.220598, Declination = 15.183596, Name = "88 Gam Peg",
            ProperName = "Algenib", Rah = 0, Ram = 13, Ras = 14.152799999999932, InternalId = 478,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.079348, Declination = 15.205264, Name = "54 Alp Peg",
            ProperName = "Markab", Rah = 23, Ram = 4, Ras = 45.65279999999831, InternalId = 479,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.062901, Declination = 28.082789, Name = "53 Bet Peg",
            ProperName = "Scheat", Rah = 23, Ram = 3, Ras = 46.44360000000034, InternalId = 480,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 0.139791, Declination = 29.090432, Name = "21 Alp And",
            ProperName = "Alpheratz", Rah = 0, Ram = 8, Ras = 23.247600000000002, InternalId = 477,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.062901, Declination = 28.082789, Name = "53 Bet Peg",
            ProperName = "Scheat", Rah = 23, Ram = 3, Ras = 46.44360000000034, InternalId = 480,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.716704, Declination = 30.221245, Name = "44 Eta Peg",
            ProperName = "Matar", Rah = 22, Ram = 43, Ras = 0.13440000000000119, InternalId = 481,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.116847, Declination = 25.345112, Name = "24 Iot Peg",
            ProperName = "", Rah = 22, Ram = 7, Ras = 0.6491999999997167, InternalId = 482,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.744092, Declination = 25.645036, Name = "10 Kap Peg",
            ProperName = "", Rah = 21, Ram = 44, Ras = 38.7311999999945, InternalId = 483,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.062901, Declination = 28.082789, Name = "53 Bet Peg",
            ProperName = "Scheat", Rah = 23, Ram = 3, Ras = 46.44360000000034, InternalId = 480,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.833385, Declination = 24.601579, Name = "48 Mu Peg",
            ProperName = "", Rah = 22, Ram = 50, Ras = 0.18599999999922012, InternalId = 484,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.775521, Declination = 23.565654, Name = "47 Lam Peg",
            ProperName = "", Rah = 22, Ram = 46, Ras = 31.87560000000427, InternalId = 485,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.74186, Declination = 17.350017, Name = "9 Peg", ProperName = "",
            Rah = 21, Ram = 44, Ras = 30.695999999996857, InternalId = 486,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.36811, Declination = 19.804508, Name = "1 Peg", ProperName = "",
            Rah = 21, Ram = 22, Ras = 5.196000000005463, InternalId = 487,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 23.079348, Declination = 15.205264, Name = "54 Alp Peg",
            ProperName = "Markab", Rah = 23, Ram = 4, Ras = 45.65279999999831, InternalId = 479,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.778216, Declination = 12.172888, Name = "46 Xi Peg",
            ProperName = "", Rah = 22, Ram = 46, Ras = 41.57760000000148, InternalId = 488,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.691033, Declination = 10.831364, Name = "42 Zet Peg",
            ProperName = "", Rah = 22, Ram = 41, Ras = 27.718800000003174, InternalId = 489,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 22.169996, Declination = 6.197865, Name = "26 The Peg",
            ProperName = "", Rah = 22, Ram = 10, Ras = 11.98560000000416, InternalId = 490,
        },
        new()
        {
            Identifier = "PEG", RightAscension = 21.736433, Declination = 9.875011, Name = "8 Eps Peg",
            ProperName = "Enif", Rah = 21, Ram = 44, Ras = 11.158800000006197, InternalId = 491,
        },
        new()
        {
            Identifier = "PER", RightAscension = 1.727675, Declination = 50.688732, Name = "Phi Per",
            ProperName = "", Rah = 1, Ram = 43, Ras = 39.63000000000023, InternalId = 492,
        },
        new()
        {
            Identifier = "PER", RightAscension = 2.844945, Declination = 55.895496, Name = "15 Eta Per",
            ProperName = "", Rah = 2, Ram = 50, Ras = 41.80200000000007, InternalId = 493,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.079942, Declination = 53.50644, Name = "23 Gam Per",
            ProperName = "", Rah = 3, Ram = 4, Ras = 47.79119999999985, InternalId = 494,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.405378, Declination = 49.86118, Name = "33 Alp Per",
            ProperName = "Mirphak", Rah = 3, Ram = 24, Ras = 19.36079999999918, InternalId = 495,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.715416, Declination = 47.787551, Name = "39 Del Per",
            ProperName = "", Rah = 3, Ram = 42, Ras = 55.49759999999955, InternalId = 496,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.96423, Declination = 40.010215, Name = "45 Eps Per",
            ProperName = "", Rah = 3, Ram = 57, Ras = 51.22800000000068, InternalId = 497,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.98275, Declination = 35.791033, Name = "46 Xi Per",
            ProperName = "", Rah = 3, Ram = 58, Ras = 57.89999999999922, InternalId = 498,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.9022, Declination = 31.883635, Name = "44 Zet Per",
            ProperName = "", Rah = 3, Ram = 54, Ras = 7.920000000000327, InternalId = 499,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.738648, Declination = 32.288248, Name = "38 Omi Per",
            ProperName = "", Rah = 3, Ram = 44, Ras = 19.13280000000008, InternalId = 500,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.405378, Declination = 49.86118, Name = "33 Alp Per",
            ProperName = "Mirphak", Rah = 3, Ram = 24, Ras = 19.36079999999918, InternalId = 495,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.158258, Declination = 44.857544, Name = "27 Kap Per",
            ProperName = "", Rah = 3, Ram = 9, Ras = 29.728800000000057, InternalId = 501,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.136148, Declination = 40.955648, Name = "26 Bet Per",
            ProperName = "Algol", Rah = 3, Ram = 8, Ras = 10.132799999999776, InternalId = 502,
        },
        new()
        {
            Identifier = "PER", RightAscension = 3.08627, Declination = 38.840274, Name = "25 Rho Per",
            ProperName = "", Rah = 3, Ram = 5, Ras = 10.571999999999464, InternalId = 503,
        },
        new()
        {
            Identifier = "PER", RightAscension = 2.843063, Declination = 38.318644, Name = "16 Per",
            ProperName = "", Rah = 2, Ram = 50, Ras = 35.02679999999949, InternalId = 504,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.520851, Declination = -49.072702, Name = "Del Phe",
            ProperName = "", Rah = 1, Ram = 31, Ras = 15.063599999999644, InternalId = 505,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.472759, Declination = -43.318234, Name = "Gam Phe",
            ProperName = "", Rah = 1, Ram = 28, Ras = 21.932399999999717, InternalId = 506,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.101407, Declination = -46.718414, Name = "Bet Phe",
            ProperName = "", Rah = 1, Ram = 6, Ras = 5.06520000000007, InternalId = 507,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 0.438056, Declination = -42.305981, Name = "Alp Phe",
            ProperName = "Ankaa", Rah = 0, Ram = 26, Ras = 17.00159999999995, InternalId = 508,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 0.156836, Declination = -45.747426, Name = "Eps Phe",
            ProperName = "", Rah = 0, Ram = 9, Ras = 24.609600000000032, InternalId = 509,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 0.722567, Declination = -57.46306, Name = "Eta Phe",
            ProperName = "", Rah = 0, Ram = 43, Ras = 21.24119999999983, InternalId = 510,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.139742, Declination = -55.24576, Name = "Zet Phe",
            ProperName = "", Rah = 1, Ram = 8, Ras = 23.071200000000125, InternalId = 511,
        },
        new()
        {
            Identifier = "PHE", RightAscension = 1.101407, Declination = -46.718414, Name = "Bet Phe",
            ProperName = "", Rah = 1, Ram = 6, Ras = 5.06520000000007, InternalId = 507,
        },
        new()
        {
            Identifier = "PIC", RightAscension = 5.788079, Declination = -51.066514, Name = "Bet Pic",
            ProperName = "", Rah = 5, Ram = 47, Ras = 17.084399999999135, InternalId = 512,
        },
        new()
        {
            Identifier = "PIC", RightAscension = 5.830451, Declination = -56.166663, Name = "Gam Pic",
            ProperName = "", Rah = 5, Ram = 49, Ras = 49.62360000000024, InternalId = 513,
        },
        new()
        {
            Identifier = "PIC", RightAscension = 6.803194, Declination = -61.941391, Name = "Alp Pic",
            ProperName = "", Rah = 6, Ram = 48, Ras = 11.498400000001308, InternalId = 514,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.194342, Declination = 30.089638, Name = "83 Tau Psc",
            ProperName = "", Rah = 1, Ram = 11, Ras = 39.6312000000001, InternalId = 515,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.324443, Declination = 27.264059, Name = "90 Ups Psc",
            ProperName = "", Rah = 1, Ram = 19, Ras = 27.994800000000186, InternalId = 516,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.229152, Declination = 24.583713, Name = "85 Phi Psc",
            ProperName = "", Rah = 1, Ram = 13, Ras = 44.94720000000005, InternalId = 517,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.524725, Declination = 15.345823, Name = "99 Eta Psc",
            ProperName = "", Rah = 1, Ram = 31, Ras = 29.010000000000204, InternalId = 518,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.756564, Declination = 9.157736, Name = "110 Omi Psc",
            ProperName = "", Rah = 1, Ram = 45, Ras = 23.63040000000005, InternalId = 519,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 2.034117, Declination = 2.763759, Name = "113 Alp Psc",
            ProperName = "", Rah = 2, Ram = 2, Ras = 2.8212000000006316, InternalId = 520,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.690526, Declination = 5.487613, Name = "106 Nu Psc",
            ProperName = "", Rah = 1, Ram = 41, Ras = 25.89359999999985, InternalId = 521,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.503087, Declination = 6.14382, Name = "98 Mu Psc",
            ProperName = "", Rah = 1, Ram = 30, Ras = 11.113200000000223, InternalId = 522,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 1.049058, Declination = 7.890135, Name = "71 Eps Psc",
            ProperName = "", Rah = 1, Ram = 2, Ras = 56.608800000000166, InternalId = 523,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 0.811373, Declination = 7.585079, Name = "63 Del Psc",
            ProperName = "", Rah = 0, Ram = 48, Ras = 40.94279999999988, InternalId = 524,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.988525, Declination = 6.863321, Name = "28 Ome Psc",
            ProperName = "", Rah = 23, Ram = 59, Ras = 18.68999999999734, InternalId = 525,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.665844, Declination = 5.626292, Name = "17 Iot Psc",
            ProperName = "", Rah = 23, Ram = 39, Ras = 57.03839999999949, InternalId = 526,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.466138, Declination = 6.378992, Name = "10 The Psc",
            ProperName = "", Rah = 23, Ram = 27, Ras = 58.09680000000294, InternalId = 527,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.339051, Declination = 5.381307, Name = "7 Psc", ProperName = "",
            Rah = 23, Ram = 20, Ras = 20.583600000004832, InternalId = 528,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.286094, Declination = 3.282289, Name = "6 Gam Psc",
            ProperName = "", Rah = 23, Ram = 17, Ras = 9.938399999994685, InternalId = 529,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.448876, Declination = 1.255608, Name = "8 Kap Psc",
            ProperName = "", Rah = 23, Ram = 26, Ras = 55.95359999999454, InternalId = 530,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.700779, Declination = 1.780041, Name = "18 Lam Psc",
            ProperName = "", Rah = 23, Ram = 42, Ras = 2.8044000000027047, InternalId = 531,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.773199, Declination = 3.486811, Name = "19 Psc",
            ProperName = "", Rah = 23, Ram = 46, Ras = 23.5164000000061, InternalId = 532,
        },
        new()
        {
            Identifier = "PSC", RightAscension = 23.665844, Declination = 5.626292, Name = "17 Iot Psc",
            ProperName = "", Rah = 23, Ram = 39, Ras = 57.03839999999949, InternalId = 526,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 21.749113, Declination = -33.025781, Name = "9 Iot PsA",
            ProperName = "", Rah = 21, Ram = 44, Ras = 56.806800000004685, InternalId = 533,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.139722, Declination = -32.988468, Name = "14 Mu PsA",
            ProperName = "", Rah = 22, Ram = 8, Ras = 22.999199999996456, InternalId = 534,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.52509, Declination = -32.346073, Name = "17 Bet PsA",
            ProperName = "", Rah = 22, Ram = 31, Ras = 30.323999999995223, InternalId = 535,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.875427, Declination = -32.875504, Name = "22 Gam PsA",
            ProperName = "", Rah = 22, Ram = 52, Ras = 31.537199999994137, InternalId = 536,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.932472, Declination = -32.539628, Name = "23 Del PsA",
            ProperName = "", Rah = 22, Ram = 55, Ras = 56.899200000002416, InternalId = 537,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.960838, Declination = -29.622236, Name = "24 Alp PsA",
            ProperName = "Fomalhaut", Rah = 22, Ram = 57, Ras = 39.01679999999645, InternalId = 538,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.677594, Declination = -27.043617, Name = "18 Eps PsA",
            ProperName = "", Rah = 22, Ram = 40, Ras = 39.338399999997044, InternalId = 539,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 22.013951, Declination = -28.453736, Name = "12 Eta PsA",
            ProperName = "", Rah = 22, Ram = 0, Ras = 50.22359999999537, InternalId = 540,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 21.795598, Declination = -30.898304, Name = "10 The PsA",
            ProperName = "", Rah = 21, Ram = 47, Ras = 44.15279999999373, InternalId = 541,
        },
        new()
        {
            Identifier = "PSA", RightAscension = 21.749113, Declination = -33.025781, Name = "9 Iot PsA",
            ProperName = "", Rah = 21, Ram = 44, Ras = 56.806800000004685, InternalId = 533,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 6.832266, Declination = -50.61456, Name = "Tau Pup",
            ProperName = "", Rah = 6, Ram = 49, Ras = 56.15759999999908, InternalId = 542,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.225637, Declination = -44.639739, Name = "", ProperName = "",
            Rah = 7, Ram = 13, Ras = 32.29319999999949, InternalId = 543,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.487179, Declination = -43.301432, Name = "Sig Pup",
            ProperName = "", Rah = 7, Ram = 29, Ras = 13.844400000000888, InternalId = 544,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 8.059737, Declination = -40.003148, Name = "Zet Pup",
            ProperName = "Naos", Rah = 8, Ram = 3, Ras = 35.05320000000054, InternalId = 545,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 8.125737, Declination = -24.304324, Name = "15 Rho Pup",
            ProperName = "", Rah = 8, Ram = 7, Ras = 32.653200000003146, InternalId = 546,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.821571, Declination = -24.859786, Name = "7 Xi Pup",
            ProperName = "", Rah = 7, Ram = 49, Ras = 17.65559999999864, InternalId = 547,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.647186, Declination = -26.803836, Name = "", ProperName = "",
            Rah = 7, Ram = 38, Ras = 49.86959999999865, InternalId = 543,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.589694, Declination = -28.369323, Name = "", ProperName = "",
            Rah = 7, Ram = 35, Ras = 22.89839999999885, InternalId = 543,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 7.285711, Declination = -37.09747, Name = "Pi Pup",
            ProperName = "", Rah = 7, Ram = 17, Ras = 8.5596000000002, InternalId = 548,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 6.629353, Declination = -43.195934, Name = "Nu Pup",
            ProperName = "", Rah = 6, Ram = 37, Ras = 45.67080000000008, InternalId = 549,
        },
        new()
        {
            Identifier = "PUP", RightAscension = 6.832266, Declination = -50.61456, Name = "Tau Pup",
            ProperName = "", Rah = 6, Ram = 49, Ras = 56.15759999999908, InternalId = 542,
        },
        new()
        {
            Identifier = "PYX", RightAscension = 8.842204, Declination = -27.709844, Name = "Gam Pyx",
            ProperName = "", Rah = 8, Ram = 50, Ras = 31.934400000002093, InternalId = 550,
        },
        new()
        {
            Identifier = "PYX", RightAscension = 8.726539, Declination = -33.186385, Name = "Alp Pyx",
            ProperName = "", Rah = 8, Ram = 43, Ras = 35.540400000002535, InternalId = 551,
        },
        new()
        {
            Identifier = "PYX", RightAscension = 8.668373, Declination = -35.308352, Name = "Bet Pyx",
            ProperName = "", Rah = 8, Ram = 40, Ras = 6.142800000002913, InternalId = 552,
        },
        new()
        {
            Identifier = "RET", RightAscension = 4.274738, Declination = -59.302156, Name = "Eps Ret",
            ProperName = "", Rah = 4, Ram = 16, Ras = 29.05680000000055, InternalId = 553,
        },
        new()
        {
            Identifier = "RET", RightAscension = 4.240404, Declination = -62.473858, Name = "Alp Ret",
            ProperName = "", Rah = 4, Ram = 14, Ras = 25.45439999999941, InternalId = 554,
        },
        new()
        {
            Identifier = "RET", RightAscension = 3.736593, Declination = -64.806903, Name = "Bet Ret",
            ProperName = "", Rah = 3, Ram = 44, Ras = 11.734800000000378, InternalId = 555,
        },
        new()
        {
            Identifier = "RET", RightAscension = 3.979095, Declination = -61.400185, Name = "Del Ret",
            ProperName = "", Rah = 3, Ram = 58, Ras = 44.74200000000015, InternalId = 556,
        },
        new()
        {
            Identifier = "RET", RightAscension = 4.274738, Declination = -59.302156, Name = "Eps Ret",
            ProperName = "", Rah = 4, Ram = 16, Ras = 29.05680000000055, InternalId = 553,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 20.08597, Declination = 19.991071, Name = "16 Eta Sge",
            ProperName = "", Rah = 20, Ram = 5, Ras = 9.491999999998784, InternalId = 557,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.979285, Declination = 19.492148, Name = "12 Gam Sge",
            ProperName = "", Rah = 19, Ram = 58, Ras = 45.42600000000303, InternalId = 558,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.816294, Declination = 19.142042, Name = "8 Zet Sge",
            ProperName = "", Rah = 19, Ram = 48, Ras = 58.65839999999692, InternalId = 559,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.68415, Declination = 17.476041, Name = "6 Bet Sge",
            ProperName = "", Rah = 19, Ram = 41, Ras = 2.939999999996079, InternalId = 560,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.816294, Declination = 19.142042, Name = "8 Zet Sge",
            ProperName = "", Rah = 19, Ram = 48, Ras = 58.65839999999692, InternalId = 559,
        },
        new()
        {
            Identifier = "SGE", RightAscension = 19.668275, Declination = 18.01389, Name = "5 Alp Sge",
            ProperName = "", Rah = 19, Ram = 40, Ras = 5.790000000004758, InternalId = 561,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.377303, Declination = -44.458965, Name = "Bet 1 Sgr",
            ProperName = "", Rah = 19, Ram = 22, Ras = 38.29080000000469, InternalId = 562,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.921026, Declination = -41.868288, Name = "Iot Sgr",
            ProperName = "", Rah = 19, Ram = 55, Ras = 15.69360000000457, InternalId = 563,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.398103, Declination = -40.61594, Name = "Alp Sgr",
            ProperName = "", Rah = 19, Ram = 23, Ras = 53.170799999996255, InternalId = 564,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.921026, Declination = -41.868288, Name = "Iot Sgr",
            ProperName = "", Rah = 19, Ram = 55, Ras = 15.69360000000457, InternalId = 563,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.995605, Declination = -35.276305, Name = "The 1 Sgr",
            ProperName = "", Rah = 19, Ram = 59, Ras = 44.178000000004445, InternalId = 565,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 20.044299, Declination = -27.709845, Name = "62 Sgr",
            ProperName = "", Rah = 20, Ram = 2, Ras = 39.47639999999552, InternalId = 566,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.611786, Declination = -24.883623, Name = "52 Sgr",
            ProperName = "", Rah = 19, Ram = 36, Ras = 42.42959999999507, InternalId = 567,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.11567, Declination = -27.670423, Name = "40 Tau Sgr",
            ProperName = "", Rah = 19, Ram = 6, Ras = 56.41200000000536, InternalId = 568,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.043532, Declination = -29.880105, Name = "38 Zet Sgr",
            ProperName = "", Rah = 19, Ram = 2, Ras = 36.71519999999646, InternalId = 569,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.76094, Declination = -26.990778, Name = "27 Phi Sgr",
            ProperName = "", Rah = 18, Ram = 45, Ras = 39.384000000005415, InternalId = 570,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.92109, Declination = -26.296722, Name = "34 Sig Sgr",
            ProperName = "Nunki", Rah = 18, Ram = 55, Ras = 15.923999999998406, InternalId = 571,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.11567, Declination = -27.670423, Name = "40 Tau Sgr",
            ProperName = "", Rah = 19, Ram = 6, Ras = 56.41200000000536, InternalId = 568,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.92109, Declination = -26.296722, Name = "34 Sig Sgr",
            ProperName = "Nunki", Rah = 18, Ram = 55, Ras = 15.923999999998406, InternalId = 571,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.07805, Declination = -21.741496, Name = "39 Omi Sgr",
            ProperName = "", Rah = 19, Ram = 4, Ras = 40.98000000000383, InternalId = 572,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.962167, Declination = -21.106654, Name = "37 Xi 2 Sgr",
            ProperName = "", Rah = 18, Ram = 57, Ras = 43.801200000003334, InternalId = 573,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.07805, Declination = -21.741496, Name = "39 Omi Sgr",
            ProperName = "", Rah = 19, Ram = 4, Ras = 40.98000000000383, InternalId = 572,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.162731, Declination = -21.023615, Name = "41 Pi Sgr",
            ProperName = "Albaldah", Rah = 19, Ram = 9, Ras = 45.83160000000307, InternalId = 574,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 19.361211, Declination = -17.847197, Name = "44 Rho 1 Sgr",
            ProperName = "", Rah = 19, Ram = 21, Ras = 40.35960000000309, InternalId = 575,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.76094, Declination = -26.990778, Name = "27 Phi Sgr",
            ProperName = "", Rah = 18, Ram = 45, Ras = 39.384000000005415, InternalId = 570,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.466179, Declination = -25.4217, Name = "22 Lam Sgr",
            ProperName = "Kaus Borealis", Rah = 18, Ram = 27, Ras = 58.24440000000119, InternalId = 576,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.229392, Declination = -21.058834, Name = "13 Mu Sgr",
            ProperName = "", Rah = 18, Ram = 13, Ras = 45.811200000002515, InternalId = 577,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.466179, Declination = -25.4217, Name = "22 Lam Sgr",
            ProperName = "Kaus Borealis", Rah = 18, Ram = 27, Ras = 58.24440000000119, InternalId = 576,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.3499, Declination = -29.828103, Name = "19 Del Sgr",
            ProperName = "Kaus Meridionalis", Rah = 18, Ram = 20, Ras = 59.64000000000602, InternalId = 578,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.096803, Declination = -30.424091, Name = "10 Gam 2 Sgr",
            ProperName = "Nash", Rah = 18, Ram = 5, Ras = 48.49080000000471, InternalId = 579,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 17.792674, Declination = -27.830788, Name = "3 Sgr",
            ProperName = "", Rah = 17, Ram = 47, Ras = 33.62640000000599, InternalId = 580,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.3499, Declination = -29.828103, Name = "19 Del Sgr",
            ProperName = "Kaus Meridionalis", Rah = 18, Ram = 20, Ras = 59.64000000000602, InternalId = 578,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.402868, Declination = -34.384616, Name = "20 Eps Sgr",
            ProperName = "Kaus Australis", Rah = 18, Ram = 24, Ras = 10.32480000000553, InternalId = 581,
        },
        new()
        {
            Identifier = "SGR", RightAscension = 18.293793, Declination = -36.761686, Name = "Eta Sgr",
            ProperName = "", Rah = 18, Ram = 17, Ras = 37.65480000000312, InternalId = 582,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.560145, Declination = -37.103821, Name = "35 Lam Sco",
            ProperName = "Shaula", Rah = 17, Ram = 33, Ras = 36.52199999999466, InternalId = 583,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.708132, Declination = -39.029983, Name = "Kap Sco",
            ProperName = "", Rah = 17, Ram = 42, Ras = 29.275199999996904, InternalId = 584,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.793078, Declination = -40.126997, Name = "Iot 1 Sco",
            ProperName = "", Rah = 17, Ram = 47, Ras = 35.08080000000464, InternalId = 585,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.62198, Declination = -42.997824, Name = "The Sco",
            ProperName = "Sargas", Rah = 17, Ram = 37, Ras = 19.12800000000221, InternalId = 586,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 17.202552, Declination = -43.239189, Name = "Eta Sco",
            ProperName = "", Rah = 17, Ram = 12, Ras = 9.187200000002594, InternalId = 587,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.909731, Declination = -42.361313, Name = "Zet 2 Sco",
            ProperName = "", Rah = 16, Ram = 54, Ras = 35.03160000000256, InternalId = 588,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.864509, Declination = -38.04738, Name = "Mu 1 Sco",
            ProperName = "", Rah = 16, Ram = 51, Ras = 52.23240000000637, InternalId = 589,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.83608, Declination = -34.293232, Name = "26 Eps Sco",
            ProperName = "", Rah = 16, Ram = 50, Ras = 9.887999999996433, InternalId = 590,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.598043, Declination = -28.216016, Name = "23 Tau Sco",
            ProperName = "", Rah = 16, Ram = 35, Ras = 52.95480000000183, InternalId = 591,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.490128, Declination = -26.432002, Name = "21 Alp Sco",
            ProperName = "Antares", Rah = 16, Ram = 29, Ras = 24.46079999999482, InternalId = 592,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.353143, Declination = -25.592796, Name = "20 Sig Sco",
            ProperName = "", Rah = 16, Ram = 21, Ras = 11.314799999997627, InternalId = 593,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.005557, Declination = -22.62171, Name = "7 Del Sco",
            ProperName = "Dschubba", Rah = 16, Ram = 0, Ras = 20.005199999998524, InternalId = 594,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.09062, Declination = -19.805453, Name = "8 Bet 1 Sco",
            ProperName = "Graffias", Rah = 16, Ram = 5, Ras = 26.232000000004536, InternalId = 595,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.199926, Declination = -19.460708, Name = "14 Nu Sco",
            ProperName = "", Rah = 16, Ram = 11, Ras = 59.73360000000502, InternalId = 596,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 16.005557, Declination = -22.62171, Name = "7 Del Sco",
            ProperName = "Dschubba", Rah = 16, Ram = 0, Ras = 20.005199999998524, InternalId = 594,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 15.980865, Declination = -26.114105, Name = "6 Pi Sco",
            ProperName = "", Rah = 15, Ram = 58, Ras = 51.113999999998725, InternalId = 597,
        },
        new()
        {
            Identifier = "SCO", RightAscension = 15.948077, Declination = -29.214073, Name = "5 Rho Sco",
            ProperName = "", Rah = 15, Ram = 56, Ras = 53.077199999998555, InternalId = 598,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 0.976766, Declination = -29.357449, Name = "Alp Scl",
            ProperName = "", Rah = 0, Ram = 58, Ras = 36.357600000000055, InternalId = 599,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 23.815427, Declination = -28.130268, Name = "Del Scl",
            ProperName = "", Rah = 23, Ram = 48, Ras = 55.53719999999869, InternalId = 600,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 23.313733, Declination = -32.532027, Name = "Gam Scl",
            ProperName = "", Rah = 23, Ram = 18, Ras = 49.43879999999699, InternalId = 601,
        },
        new()
        {
            Identifier = "SCL", RightAscension = 23.549512, Declination = -37.818268, Name = "Bet Scl",
            ProperName = "", Rah = 23, Ram = 32, Ras = 58.24320000000003, InternalId = 602,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.586785, Declination = -8.244073, Name = "Alp Sct",
            ProperName = "", Rah = 18, Ram = 35, Ras = 12.425999999996273, InternalId = 603,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.786242, Declination = -4.747867, Name = "Bet Sct",
            ProperName = "", Rah = 18, Ram = 47, Ras = 10.47120000000521, InternalId = 604,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.586785, Declination = -8.244073, Name = "Alp Sct",
            ProperName = "", Rah = 18, Ram = 35, Ras = 12.425999999996273, InternalId = 603,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.394329, Declination = -8.934383, Name = "Zet Sct",
            ProperName = "", Rah = 18, Ram = 23, Ras = 39.58439999999646, InternalId = 605,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.586785, Declination = -8.244073, Name = "Alp Sct",
            ProperName = "", Rah = 18, Ram = 35, Ras = 12.425999999996273, InternalId = 603,
        },
        new()
        {
            Identifier = "SCT", RightAscension = 18.486626, Declination = -14.565813, Name = "Gam Sct",
            ProperName = "", Rah = 18, Ram = 29, Ras = 11.853600000003993, InternalId = 606,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 17.347128, Declination = -12.846875, Name = "53 Nu Ser",
            ProperName = "", Rah = 17, Ram = 20, Ras = 49.66080000000523, InternalId = 607,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 17.626445, Declination = -15.398557, Name = "55 Xi Ser",
            ProperName = "", Rah = 17, Ram = 37, Ras = 35.2020000000012, InternalId = 608,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 17.690243, Declination = -12.875307, Name = "56 Omi Ser",
            ProperName = "", Rah = 17, Ram = 41, Ras = 24.874799999995734, InternalId = 609,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 18.355167, Declination = -2.898825, Name = "58 Eta Ser",
            ProperName = "", Rah = 18, Ram = 21, Ras = 18.60120000000571, InternalId = 610,
        },
        new()
        {
            Identifier = "SEC", RightAscension = 18.936995, Declination = 4.203595, Name = "63 The 1 Ser",
            ProperName = "", Rah = 18, Ram = 56, Ras = 13.181999999998428, InternalId = 611,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.827002, Declination = -3.430208, Name = "32 Mu Ser",
            ProperName = "", Rah = 15, Ram = 49, Ras = 37.20720000000091, InternalId = 612,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.846935, Declination = 4.47773, Name = "37 Eps Ser",
            ProperName = "", Rah = 15, Ram = 50, Ras = 48.96600000000064, InternalId = 613,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.737798, Declination = 6.425627, Name = "24 Alp Ser",
            ProperName = "Unukalhai", Rah = 15, Ram = 44, Ras = 16.07279999999922, InternalId = 614,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.580041, Declination = 10.538867, Name = "13 Del Ser",
            ProperName = "", Rah = 15, Ram = 34, Ras = 48.14759999999856, InternalId = 615,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.769793, Declination = 15.421826, Name = "28 Bet Ser",
            ProperName = "", Rah = 15, Ram = 46, Ras = 11.254799999999632, InternalId = 616,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.812327, Declination = 18.141564, Name = "35 Kap Ser",
            ProperName = "", Rah = 15, Ram = 48, Ras = 44.37719999999912, InternalId = 617,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.940882, Declination = 15.661617, Name = "41 Gam Ser",
            ProperName = "", Rah = 15, Ram = 56, Ras = 27.175200000000732, InternalId = 618,
        },
        new()
        {
            Identifier = "SER", RightAscension = 15.769793, Declination = 15.421826, Name = "28 Bet Ser",
            ProperName = "", Rah = 15, Ram = 46, Ras = 11.254799999999632, InternalId = 616,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 10.504855, Declination = -0.637026, Name = "30 Bet Sex",
            ProperName = "", Rah = 10, Ram = 30, Ras = 17.477999999996996, InternalId = 619,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 10.1323, Declination = -0.371637, Name = "15 Alp Sex",
            ProperName = "", Rah = 10, Ram = 7, Ras = 56.280000000002694, InternalId = 620,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 9.875121, Declination = -8.10503, Name = "8 Gam Sex",
            ProperName = "", Rah = 9, Ram = 52, Ras = 30.43560000000003, InternalId = 621,
        },
        new()
        {
            Identifier = "SEX", RightAscension = 10.504855, Declination = -0.637026, Name = "30 Bet Sex",
            ProperName = "", Rah = 10, Ram = 30, Ras = 17.477999999996996, InternalId = 619,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 3.413554, Declination = 9.02887, Name = "1 Omi Tau",
            ProperName = "", Rah = 3, Ram = 24, Ras = 48.79439999999984, InternalId = 622,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 3.45282, Declination = 9.73268, Name = "2 Xi Tau", ProperName = "",
            Rah = 3, Ram = 27, Ras = 10.151999999999962, InternalId = 623,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.011338, Declination = 12.490347, Name = "35 Lam Tau",
            ProperName = "", Rah = 4, Ram = 0, Ras = 40.81680000000105, InternalId = 624,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.329889, Declination = 15.627642, Name = "54 Gam Tau",
            ProperName = "", Rah = 4, Ram = 19, Ras = 47.600399999998814, InternalId = 625,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.477705, Declination = 15.870883, Name = "78 The 2 Tau",
            ProperName = "", Rah = 4, Ram = 28, Ras = 39.73800000000094, InternalId = 626,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.598677, Declination = 16.509301, Name = "87 Alp Tau",
            ProperName = "Aldebaran", Rah = 4, Ram = 35, Ras = 55.23720000000112, InternalId = 627,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 5.627413, Declination = 21.142549, Name = "123 Zet Tau",
            ProperName = "", Rah = 5, Ram = 37, Ras = 38.68679999999909, InternalId = 628,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.329889, Declination = 15.627642, Name = "54 Gam Tau",
            ProperName = "", Rah = 4, Ram = 19, Ras = 47.600399999998814, InternalId = 625,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.382247, Declination = 17.542514, Name = "61 Del 1 Tau",
            ProperName = "", Rah = 4, Ram = 22, Ras = 56.089199999998506, InternalId = 629,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.476943, Declination = 19.180431, Name = "74 Eps Tau",
            ProperName = "", Rah = 4, Ram = 28, Ras = 36.99480000000119, InternalId = 630,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 4.704084, Declination = 22.956926, Name = "94 Tau Tau",
            ProperName = "", Rah = 4, Ram = 42, Ras = 14.702399999999916, InternalId = 631,
        },
        new()
        {
            Identifier = "TAU", RightAscension = 5.438198, Declination = 28.60745, Name = "112 Bet Tau",
            ProperName = "Alnath", Rah = 5, Ram = 26, Ras = 17.512799999999462, InternalId = 632,
        },
        new()
        {
            Identifier = "TEL", RightAscension = 18.480505, Declination = -49.070588, Name = "Zet Tel",
            ProperName = "", Rah = 18, Ram = 28, Ras = 49.818000000003025, InternalId = 633,
        },
        new()
        {
            Identifier = "TEL", RightAscension = 18.449561, Declination = -45.968459, Name = "Alp Tel",
            ProperName = "", Rah = 18, Ram = 26, Ras = 58.419599999997104, InternalId = 634,
        },
        new()
        {
            Identifier = "TEL", RightAscension = 18.187157, Declination = -45.954418, Name = "Eps Tel",
            ProperName = "", Rah = 18, Ram = 11, Ras = 13.765199999996913, InternalId = 635,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 2.288573, Declination = 33.847194, Name = "9 Gam Tri",
            ProperName = "", Rah = 2, Ram = 17, Ras = 18.862799999999915, InternalId = 636,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 1.884696, Declination = 29.578829, Name = "2 Alp Tri",
            ProperName = "", Rah = 1, Ram = 53, Ras = 4.905599999999843, InternalId = 637,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 2.159058, Declination = 34.987297, Name = "4 Bet Tri",
            ProperName = "", Rah = 2, Ram = 9, Ras = 32.60879999999974, InternalId = 638,
        },
        new()
        {
            Identifier = "TRI", RightAscension = 2.288573, Declination = 33.847194, Name = "9 Gam Tri",
            ProperName = "", Rah = 2, Ram = 17, Ras = 18.862799999999915, InternalId = 636,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 16.811077, Declination = -69.027715, Name = "Alp TrA",
            ProperName = "Atria", Rah = 16, Ram = 48, Ras = 39.877200000003214, InternalId = 639,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 15.919083, Declination = -63.430727, Name = "Bet TrA",
            ProperName = "", Rah = 15, Ram = 55, Ras = 8.698800000002072, InternalId = 640,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 15.315181, Declination = -68.679545, Name = "Gam TrA",
            ProperName = "", Rah = 15, Ram = 18, Ras = 54.651600000003, InternalId = 641,
        },
        new()
        {
            Identifier = "TRA", RightAscension = 16.811077, Declination = -69.027715, Name = "Alp TrA",
            ProperName = "Atria", Rah = 16, Ram = 48, Ras = 39.877200000003214, InternalId = 639,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 0.525725, Declination = -62.958218, Name = "Bet 1 Tuc",
            ProperName = "", Rah = 0, Ram = 31, Ras = 32.60999999999981, InternalId = 642,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 0.334142, Declination = -64.874791, Name = "Zet Tuc",
            ProperName = "", Rah = 0, Ram = 20, Ras = 2.911200000000047, InternalId = 643,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 23.998594, Declination = -65.577132, Name = "Eps Tuc",
            ProperName = "", Rah = 23, Ram = 59, Ras = 54.93840000000252, InternalId = 644,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 23.290498, Declination = -58.235734, Name = "Gam Tuc",
            ProperName = "", Rah = 23, Ram = 17, Ras = 25.792799999998152, InternalId = 645,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 0.525725, Declination = -62.958218, Name = "Bet 1 Tuc",
            ProperName = "", Rah = 0, Ram = 31, Ras = 32.60999999999981, InternalId = 642,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 23.290498, Declination = -58.235734, Name = "Gam Tuc",
            ProperName = "", Rah = 23, Ram = 17, Ras = 25.792799999998152, InternalId = 645,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 22.308371, Declination = -60.259587, Name = "Alp Tuc",
            ProperName = "", Rah = 22, Ram = 18, Ras = 30.13560000000386, InternalId = 646,
        },
        new()
        {
            Identifier = "TUC", RightAscension = 22.455531, Declination = -64.966354, Name = "Del Tuc",
            ProperName = "", Rah = 22, Ram = 27, Ras = 19.91160000000203, InternalId = 647,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 13.792354, Declination = 49.313265, Name = "85 Eta UMa",
            ProperName = "Alkaid", Rah = 13, Ram = 47, Ras = 32.47439999999844, InternalId = 648,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 13.398747, Declination = 54.925362, Name = "79 Zet UMa",
            ProperName = "Mizar", Rah = 13, Ram = 23, Ras = 55.48920000000057, InternalId = 649,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 12.900472, Declination = 55.959821, Name = "77 Eps UMa",
            ProperName = "Alioth", Rah = 12, Ram = 54, Ras = 1.699200000002099, InternalId = 650,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 12.257086, Declination = 57.032617, Name = "69 Del UMa",
            ProperName = "Megrez", Rah = 12, Ram = 15, Ras = 25.509599999997334, InternalId = 651,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.897168, Declination = 53.69476, Name = "64 Gam UMa",
            ProperName = "Phad", Rah = 11, Ram = 53, Ras = 49.80480000000238, InternalId = 652,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.767515, Declination = 47.779406, Name = "63 Chi UMa",
            ProperName = "", Rah = 11, Ram = 46, Ras = 3.053999999998025, InternalId = 653,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.307983, Declination = 33.094306, Name = "54 Nu UMa",
            ProperName = "", Rah = 11, Ram = 18, Ras = 28.738800000000463, InternalId = 654,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.303118, Declination = 31.528783, Name = "53 Xi UMa",
            ProperName = "", Rah = 11, Ram = 18, Ras = 11.224799999998435, InternalId = 655,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.767515, Declination = 47.779406, Name = "63 Chi UMa",
            ProperName = "", Rah = 11, Ram = 46, Ras = 3.053999999998025, InternalId = 653,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.161062, Declination = 44.498487, Name = "52 Psi UMa",
            ProperName = "", Rah = 11, Ram = 9, Ras = 39.82319999999776, InternalId = 656,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 10.372155, Declination = 41.499516, Name = "34 Mu UMa",
            ProperName = "", Rah = 10, Ram = 22, Ras = 19.757999999997743, InternalId = 657,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 10.284952, Declination = 42.914365, Name = "33 Lam UMa",
            ProperName = "", Rah = 10, Ram = 17, Ras = 5.827200000001964, InternalId = 658,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 12.257086, Declination = 57.032617, Name = "69 Del UMa",
            ProperName = "Megrez", Rah = 12, Ram = 15, Ras = 25.509599999997334, InternalId = 651,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.062155, Declination = 61.751033, Name = "50 Alp UMa",
            ProperName = "Dubhe", Rah = 11, Ram = 3, Ras = 43.75800000000225, InternalId = 659,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.030677, Declination = 56.382427, Name = "48 Bet UMa",
            ProperName = "Merak", Rah = 11, Ram = 1, Ras = 50.43720000000263, InternalId = 660,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.897168, Declination = 53.69476, Name = "64 Gam UMa",
            ProperName = "Phad", Rah = 11, Ram = 53, Ras = 49.80480000000238, InternalId = 652,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.062155, Declination = 61.751033, Name = "50 Alp UMa",
            ProperName = "Dubhe", Rah = 11, Ram = 3, Ras = 43.75800000000225, InternalId = 659,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 9.525453, Declination = 63.061861, Name = "23 UMa",
            ProperName = "", Rah = 9, Ram = 31, Ras = 31.630800000002026, InternalId = 661,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 8.504431, Declination = 60.718169, Name = "1 Omi UMa",
            ProperName = "", Rah = 8, Ram = 30, Ras = 15.951600000001065, InternalId = 662,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 9.849867, Declination = 59.038735, Name = "29 Ups UMa",
            ProperName = "", Rah = 9, Ram = 50, Ras = 59.52119999999881, InternalId = 663,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 11.030677, Declination = 56.382427, Name = "48 Bet UMa",
            ProperName = "Merak", Rah = 11, Ram = 1, Ras = 50.43720000000263, InternalId = 660,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 9.849867, Declination = 59.038735, Name = "29 Ups UMa",
            ProperName = "", Rah = 9, Ram = 50, Ras = 59.52119999999881, InternalId = 663,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 9.547715, Declination = 51.6773, Name = "25 The UMa",
            ProperName = "", Rah = 9, Ram = 32, Ras = 51.774000000000655, InternalId = 664,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 8.986828, Declination = 48.041826, Name = "9 Iot UMa",
            ProperName = "", Rah = 8, Ram = 59, Ras = 12.580799999997128, InternalId = 665,
        },
        new()
        {
            Identifier = "UMA", RightAscension = 9.060427, Declination = 47.156525, Name = "12 Kap UMa",
            ProperName = "", Rah = 9, Ram = 3, Ras = 37.53720000000242, InternalId = 666,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 15.734299, Declination = 77.794493, Name = "16 Zet UMi",
            ProperName = "", Rah = 15, Ram = 44, Ras = 3.4764000000003126, InternalId = 667,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 16.291791, Declination = 75.75533, Name = "21 Eta UMi",
            ProperName = "", Rah = 16, Ram = 17, Ras = 30.44759999999971, InternalId = 668,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 15.345483, Declination = 71.834016, Name = "13 Gam UMi",
            ProperName = "", Rah = 15, Ram = 20, Ras = 43.73879999999921, InternalId = 669,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 14.845105, Declination = 74.155505, Name = "7 Bet UMi",
            ProperName = "Kochab", Rah = 14, Ram = 50, Ras = 42.37800000000065, InternalId = 670,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 15.734299, Declination = 77.794493, Name = "16 Zet UMi",
            ProperName = "", Rah = 15, Ram = 44, Ras = 3.4764000000003126, InternalId = 667,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 16.766159, Declination = 82.037262, Name = "22 Eps UMi",
            ProperName = "", Rah = 16, Ram = 45, Ras = 58.17239999999373, InternalId = 671,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 17.536918, Declination = 86.58646, Name = "23 Del UMi",
            ProperName = "", Rah = 17, Ram = 32, Ras = 12.90480000000005, InternalId = 672,
        },
        new()
        {
            Identifier = "UMI", RightAscension = 2.52975, Declination = 89.264109, Name = "1 Alp UMi",
            ProperName = "Polaris", Rah = 2, Ram = 31, Ras = 47.09999999999961, InternalId = 673,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 10.779488, Declination = -49.420255, Name = "Mu Vel",
            ProperName = "", Rah = 10, Ram = 46, Ras = 46.156800000002065, InternalId = 674,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 10.621717, Declination = -48.22562, Name = "", ProperName = "",
            Rah = 10, Ram = 37, Ras = 18.181200000000963, InternalId = 675,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 10.245607, Declination = -42.121942, Name = "", ProperName = "",
            Rah = 10, Ram = 14, Ras = 44.18519999999886, InternalId = 675,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.511674, Declination = -40.466769, Name = "Psi Vel",
            ProperName = "", Rah = 9, Ram = 30, Ras = 42.026399999997466, InternalId = 676,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.133268, Declination = -43.432589, Name = "Lam Vel",
            ProperName = "", Rah = 9, Ram = 7, Ras = 59.764799999997386, InternalId = 677,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.739987, Declination = -42.649276, Name = "", ProperName = "",
            Rah = 8, Ram = 44, Ras = 23.953199999997608, InternalId = 675,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.627399, Declination = -42.989081, Name = "", ProperName = "",
            Rah = 8, Ram = 37, Ras = 38.636400000001636, InternalId = 675,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.158876, Declination = -47.336588, Name = "Gam 2 Vel",
            ProperName = "", Rah = 8, Ram = 9, Ras = 31.953599999997685, InternalId = 678,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 8.745059, Declination = -54.708821, Name = "Del Vel",
            ProperName = "", Rah = 8, Ram = 44, Ras = 42.21239999999828, InternalId = 679,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.368562, Declination = -55.010668, Name = "Kap Vel",
            ProperName = "", Rah = 9, Ram = 22, Ras = 6.823200000002694, InternalId = 680,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 9.947708, Declination = -54.56779, Name = "Phi Vel",
            ProperName = "", Rah = 9, Ram = 56, Ras = 51.74880000000152, InternalId = 681,
        },
        new()
        {
            Identifier = "VEL", RightAscension = 10.779488, Declination = -49.420255, Name = "Mu Vel",
            ProperName = "", Rah = 10, Ram = 46, Ras = 46.156800000002065, InternalId = 674,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.214929, Declination = -10.273702, Name = "98 Kap Vir",
            ProperName = "", Rah = 14, Ram = 12, Ras = 53.74439999999889, InternalId = 682,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.419883, Declination = -11.161322, Name = "67 Alp Vir",
            ProperName = "Spica", Rah = 13, Ram = 25, Ras = 11.578800000001554, InternalId = 683,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.165831, Declination = -5.53901, Name = "51 The Vir",
            ProperName = "", Rah = 13, Ram = 9, Ras = 56.99160000000264, InternalId = 684,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.694345, Declination = -1.449375, Name = "29 Gam Vir",
            ProperName = "Porrima", Rah = 12, Ram = 41, Ras = 39.64200000000071, InternalId = 685,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.331766, Declination = -0.666803, Name = "15 Eta Vir",
            ProperName = "", Rah = 12, Ram = 19, Ras = 54.357600000000076, InternalId = 686,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 11.844922, Declination = 1.764718, Name = "5 Bet Vir",
            ProperName = "", Rah = 11, Ram = 50, Ras = 41.71920000000129, InternalId = 687,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.770812, Declination = 1.892885, Name = "109 Vir",
            ProperName = "", Rah = 14, Ram = 46, Ras = 14.923199999997605, InternalId = 688,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 14.027443, Declination = 1.544532, Name = "93 Tau Vir",
            ProperName = "", Rah = 14, Ram = 1, Ras = 38.79479999999958, InternalId = 689,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.57822, Declination = -0.59582, Name = "79 Zet Vir",
            ProperName = "", Rah = 13, Ram = 34, Ras = 41.5919999999999, InternalId = 690,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.926725, Declination = 3.39747, Name = "43 Del Vir",
            ProperName = "", Rah = 12, Ram = 55, Ras = 36.20999999999781, InternalId = 691,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.036278, Declination = 10.95915, Name = "47 Eps Vir",
            ProperName = "Vindemiatrix", Rah = 13, Ram = 2, Ras = 10.60079999999772, InternalId = 692,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.419883, Declination = -11.161322, Name = "67 Alp Vir",
            ProperName = "Spica", Rah = 13, Ram = 25, Ras = 11.578800000001554, InternalId = 683,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 13.57822, Declination = -0.59582, Name = "79 Zet Vir",
            ProperName = "", Rah = 13, Ram = 34, Ras = 41.5919999999999, InternalId = 690,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.694345, Declination = -1.449375, Name = "29 Gam Vir",
            ProperName = "Porrima", Rah = 12, Ram = 41, Ras = 39.64200000000071, InternalId = 685,
        },
        new()
        {
            Identifier = "VIR", RightAscension = 12.926725, Declination = 3.39747, Name = "43 Del Vir",
            ProperName = "", Rah = 12, Ram = 55, Ras = 36.20999999999781, InternalId = 691,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 9.040777, Declination = -66.396076, Name = "Alp Vol",
            ProperName = "", Rah = 9, Ram = 2, Ras = 26.797200000001027, InternalId = 693,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 8.428951, Declination = -66.13689, Name = "Bet Vol",
            ProperName = "", Rah = 8, Ram = 25, Ras = 44.22359999999863, InternalId = 694,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 8.132173, Declination = -68.617062, Name = "Eps Vol",
            ProperName = "", Rah = 8, Ram = 7, Ras = 55.82279999999954, InternalId = 695,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 7.697004, Declination = -72.606098, Name = "Zet Vol",
            ProperName = "", Rah = 7, Ram = 41, Ras = 49.21439999999899, InternalId = 696,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 7.145788, Declination = -70.498932, Name = "Gam 2 Vol",
            ProperName = "", Rah = 7, Ram = 8, Ras = 44.83679999999851, InternalId = 697,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 7.280508, Declination = -67.957152, Name = "Del Vol",
            ProperName = "", Rah = 7, Ram = 16, Ras = 49.82880000000074, InternalId = 698,
        },
        new()
        {
            Identifier = "VOL", RightAscension = 8.132173, Declination = -68.617062, Name = "Eps Vol",
            ProperName = "", Rah = 8, Ram = 7, Ras = 55.82279999999954, InternalId = 695,
        },
        new()
        {
            Identifier = "VUL", RightAscension = 19.891026, Declination = 24.079614, Name = "13 Vul",
            ProperName = "", Rah = 19, Ram = 53, Ras = 27.69360000000045, InternalId = 699,
        },
        new()
        {
            Identifier = "VUL", RightAscension = 19.478427, Declination = 24.664905, Name = "6 Alp Vul",
            ProperName = "", Rah = 19, Ram = 28, Ras = 42.33719999999974, InternalId = 700,
        },
        new()
        {
            Identifier = "VUL", RightAscension = 19.270289, Declination = 21.390428, Name = "1 Vul",
            ProperName = "", Rah = 19, Ram = 16, Ras = 13.040399999993625, InternalId = 701,
        },
    };
}