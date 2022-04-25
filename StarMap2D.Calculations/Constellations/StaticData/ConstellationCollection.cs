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
using StarMap2D.Calculations.Enumerations;

namespace StarMap2D.Calculations.Constellations.StaticData;

/// <summary>
/// A collection of the 88 constellation names and their identifiers.
/// </summary>
public class ConstellationCollection
{
    // The constellation locations (C) Wikipedia 2022: https://en.wikipedia.org/wiki/IAU_designated_constellations_by_area

    /// <summary>
    /// A list of constellations defined by IAU.
    /// </summary>
    public static IReadOnlyList<ConstellationNameIdentifier> Constellations { get; } = new ConstellationNameIdentifier[]
    {
        new()
        {
            Identifier = "HYA", Name = "Hydra", IdentifierCased = "Hya", IdentifierValue = ConstellationValue.Hydra,
            IAURank = 1, Quadrant = Quadrant.Sq2, RightAscension = 11.612166666666667,
            Declination = -14.531833333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "AQR", Name = "Aquarius", IdentifierCased = "Aqr",
            IdentifierValue = ConstellationValue.Aquarius, IAURank = 10, Quadrant = Quadrant.Sq4,
            RightAscension = 22.289666666666665, Declination = -10.789166666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "OPH", Name = "Ophiuchus", IdentifierCased = "Oph",
            IdentifierValue = ConstellationValue.Ophiuchus, IAURank = 11, Quadrant = Quadrant.Sq3,
            RightAscension = 17.394833333333334, Declination = -7.912333333333334, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LEO", Name = "Leo", IdentifierCased = "Leo", IdentifierValue = ConstellationValue.Leo,
            IAURank = 12, Quadrant = Quadrant.Nq2, RightAscension = 10.667166666666667,
            Declination = 13.138666666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "BOO", Name = "Boötes", IdentifierCased = "Boo", IdentifierValue = ConstellationValue.Boötes,
            IAURank = 13, Quadrant = Quadrant.Nq3, RightAscension = 14.710666666666667,
            Declination = 31.202666666666666, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PSC", Name = "Pisces", IdentifierCased = "Psc", IdentifierValue = ConstellationValue.Pisces,
            IAURank = 14, Quadrant = Quadrant.Nq1, RightAscension = 0, Declination = 13.687166666666666,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SGR", Name = "Sagittarius", IdentifierCased = "Sgr",
            IdentifierValue = ConstellationValue.Sagittarius, IAURank = 15, Quadrant = Quadrant.Sq4,
            RightAscension = 19.099, Declination = -28.47683333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CYG", Name = "Cygnus", IdentifierCased = "Cyg", IdentifierValue = ConstellationValue.Cygnus,
            IAURank = 16, Quadrant = Quadrant.Nq4, RightAscension = 20.588, Declination = 44.545,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "TAU", Name = "Taurus", IdentifierCased = "Tau", IdentifierValue = ConstellationValue.Taurus,
            IAURank = 17, Quadrant = Quadrant.Nq1, RightAscension = 4.702166666666667, Declination = 14.877166666666668,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CAM", Name = "Camelopardalis", IdentifierCased = "Cam",
            IdentifierValue = ConstellationValue.Camelopardalis, IAURank = 18, Quadrant = Quadrant.Nq2,
            RightAscension = 8.856166666666667, Declination = 69.3815, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "AND", Name = "Andromeda", IdentifierCased = "And",
            IdentifierValue = ConstellationValue.Andromeda, IAURank = 19, Quadrant = Quadrant.Nq1, RightAscension = 0,
            Declination = 37.43183333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "VIR", Name = "Virgo", IdentifierCased = "Vir", IdentifierValue = ConstellationValue.Virgo,
            IAURank = 2, Quadrant = Quadrant.Sq3, RightAscension = 13.4065, Declination = -4.1585,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PUP", Name = "Puppis", IdentifierCased = "Pup", IdentifierValue = ConstellationValue.Puppis,
            IAURank = 20, Quadrant = Quadrant.Sq2, RightAscension = 7.258, Declination = -31.177333333333333,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "AUR", Name = "Auriga", IdentifierCased = "Aur", IdentifierValue = ConstellationValue.Auriga,
            IAURank = 21, Quadrant = Quadrant.Nq2, RightAscension = 6.073666666666667, Declination = 42.028,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "AQL", Name = "Aquila", IdentifierCased = "Aql", IdentifierValue = ConstellationValue.Aquila,
            IAURank = 22, Quadrant = Quadrant.Nq4, RightAscension = 19.667, Declination = 3.410833333333333,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SEC", Name = "Serpens Cauda", IdentifierCased = "Sec",
            IdentifierValue = ConstellationValue.SerpensCauda, IAURank = 23, Quadrant = Quadrant.Nq3,
            RightAscension = 18.126666666666665, Declination = -4.851166666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SER", Name = "Serpens Caput", IdentifierCased = "Ser",
            IdentifierValue = ConstellationValue.SerpensCaput, IAURank = 23, Quadrant = Quadrant.Nq3,
            RightAscension = 15.774833333333333, Declination = 10.97, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SER", Name = "Serpens", IdentifierCased = "Ser",
            IdentifierValue = ConstellationValue.Serpens, IAURank = 23, Quadrant = Quadrant.Nq3,
            RightAscension = 16.950666666666667, Declination = 6.122, SerpensOfficial = true,
        },
        new()
        {
            Identifier = "PER", Name = "Perseus", IdentifierCased = "Per", IdentifierValue = ConstellationValue.Perseus,
            IAURank = 24, Quadrant = Quadrant.Nq1, RightAscension = 3.175, Declination = 45.01316666666666,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CAS", Name = "Cassiopeia", IdentifierCased = "Cas",
            IdentifierValue = ConstellationValue.Cassiopeia, IAURank = 25, Quadrant = Quadrant.Nq1,
            RightAscension = 1.3193333333333332, Declination = 62.184, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "ORI", Name = "Orion", IdentifierCased = "Ori", IdentifierValue = ConstellationValue.Orion,
            IAURank = 26, Quadrant = Quadrant.Nq1, RightAscension = 5.5765, Declination = 5.949,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CEP", Name = "Cepheus", IdentifierCased = "Cep", IdentifierValue = ConstellationValue.Cepheus,
            IAURank = 27, Quadrant = Quadrant.Nq4, RightAscension = 2.544, Declination = 71.0085,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LYN", Name = "Lynx", IdentifierCased = "Lyn", IdentifierValue = ConstellationValue.Lynx,
            IAURank = 28, Quadrant = Quadrant.Nq2, RightAscension = 7.992166666666667, Declination = 47.46666666666667,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LIB", Name = "Libra", IdentifierCased = "Lib", IdentifierValue = ConstellationValue.Libra,
            IAURank = 29, Quadrant = Quadrant.Sq3, RightAscension = 15.199333333333334,
            Declination = -15.234666666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "UMA", Name = "Ursa Major", IdentifierCased = "UMa",
            IdentifierValue = ConstellationValue.UrsaMajor, IAURank = 3, Quadrant = Quadrant.Nq2,
            RightAscension = 11.312666666666667, Declination = 50.72116666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "GEM", Name = "Gemini", IdentifierCased = "Gem", IdentifierValue = ConstellationValue.Gemini,
            IAURank = 30, Quadrant = Quadrant.Nq2, RightAscension = 7.070666666666667, Declination = 22.600166666666667,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CNC", Name = "Cancer", IdentifierCased = "Cnc", IdentifierValue = ConstellationValue.Cancer,
            IAURank = 31, Quadrant = Quadrant.Nq2, RightAscension = 8.649333333333333, Declination = 19.805833333333332,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "VEL", Name = "Vela", IdentifierCased = "Vel", IdentifierValue = ConstellationValue.Vela,
            IAURank = 32, Quadrant = Quadrant.Sq2, RightAscension = 9.577333333333334, Declination = -47.16716666666667,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SCO", Name = "Scorpius", IdentifierCased = "Sco",
            IdentifierValue = ConstellationValue.Scorpius, IAURank = 33, Quadrant = Quadrant.Sq3,
            RightAscension = 16.887333333333334, Declination = -27.0315, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CAR", Name = "Carina", IdentifierCased = "Car", IdentifierValue = ConstellationValue.Carina,
            IAURank = 34, Quadrant = Quadrant.Sq2, RightAscension = 8.695, Declination = -63.21933333333333,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "MON", Name = "Monoceros", IdentifierCased = "Mon",
            IdentifierValue = ConstellationValue.Monoceros, IAURank = 35, Quadrant = Quadrant.Nq2,
            RightAscension = 7.0605, Declination = 0, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SCL", Name = "Sculptor", IdentifierCased = "Scl",
            IdentifierValue = ConstellationValue.Sculptor, IAURank = 36, Quadrant = Quadrant.Sq1, RightAscension = 0,
            Declination = -32.08833333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PHE", Name = "Phoenix", IdentifierCased = "Phe", IdentifierValue = ConstellationValue.Phoenix,
            IAURank = 37, Quadrant = Quadrant.Sq1, RightAscension = 0, Declination = -48.580666666666666,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CVN", Name = "Canes Venatici", IdentifierCased = "CVn",
            IdentifierValue = ConstellationValue.CanesVenatici, IAURank = 38, Quadrant = Quadrant.Nq3,
            RightAscension = 13.116, Declination = 40.10183333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "ARI", Name = "Aries", IdentifierCased = "Ari", IdentifierValue = ConstellationValue.Aries,
            IAURank = 39, Quadrant = Quadrant.Nq1, RightAscension = 2.636, Declination = 20.792333333333332,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CET", Name = "Cetus", IdentifierCased = "Cet", IdentifierValue = ConstellationValue.Cetus,
            IAURank = 4, Quadrant = Quadrant.Sq1, RightAscension = 1.6683333333333334, Declination = -7.179333333333333,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CAP", Name = "Capricornus", IdentifierCased = "Cap",
            IdentifierValue = ConstellationValue.Capricornus, IAURank = 40, Quadrant = Quadrant.Sq4,
            RightAscension = 21.048833333333334, Declination = -18.02316666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "FOR", Name = "Fornax", IdentifierCased = "For", IdentifierValue = ConstellationValue.Fornax,
            IAURank = 41, Quadrant = Quadrant.Sq1, RightAscension = 2.798, Declination = -31.6345,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "COM", Name = "Coma Berenices", IdentifierCased = "Com",
            IdentifierValue = ConstellationValue.ComaBerenices, IAURank = 42, Quadrant = Quadrant.Nq3,
            RightAscension = 12.787833333333333, Declination = 23.305666666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CMA", Name = "Canis Major", IdentifierCased = "CMa",
            IdentifierValue = ConstellationValue.CanisMajor, IAURank = 43, Quadrant = Quadrant.Sq2,
            RightAscension = 6.829, Declination = -22.140333333333334, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PAV", Name = "Pavo", IdentifierCased = "Pav", IdentifierValue = ConstellationValue.Pavo,
            IAURank = 44, Quadrant = Quadrant.Sq4, RightAscension = 19.611833333333333, Declination = -65.7815,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "GRU", Name = "Grus", IdentifierCased = "Gru", IdentifierValue = ConstellationValue.Grus,
            IAURank = 45, Quadrant = Quadrant.Sq4, RightAscension = 22.4565, Declination = -46.35183333333333,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LUP", Name = "Lupus", IdentifierCased = "Lup", IdentifierValue = ConstellationValue.Lupus,
            IAURank = 46, Quadrant = Quadrant.Sq3, RightAscension = 15.220166666666668,
            Declination = -42.70883333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SEX", Name = "Sextans", IdentifierCased = "Sex", IdentifierValue = ConstellationValue.Sextans,
            IAURank = 47, Quadrant = Quadrant.Sq2, RightAscension = 10.2715, Declination = -2.6146666666666665,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "TUC", Name = "Tucana", IdentifierCased = "Tuc", IdentifierValue = ConstellationValue.Tucana,
            IAURank = 48, Quadrant = Quadrant.Sq4, RightAscension = 23.777333333333335, Declination = -65.83,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "IND", Name = "Indus", IdentifierCased = "Ind", IdentifierValue = ConstellationValue.Indus,
            IAURank = 49, Quadrant = Quadrant.Sq4, RightAscension = 21.972166666666666,
            Declination = -59.70666666666666, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "HER", Name = "Hercules", IdentifierCased = "Her",
            IdentifierValue = ConstellationValue.Hercules, IAURank = 5, Quadrant = Quadrant.Nq3,
            RightAscension = 17.386, Declination = 27.498833333333334, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "OCT", Name = "Octans", IdentifierCased = "Oct", IdentifierValue = ConstellationValue.Octans,
            IAURank = 50, Quadrant = Quadrant.Sq4, RightAscension = 23, Declination = -82.152, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LEP", Name = "Lepus", IdentifierCased = "Lep", IdentifierValue = ConstellationValue.Lepus,
            IAURank = 51, Quadrant = Quadrant.Sq1, RightAscension = 5.565833333333334,
            Declination = -19.046333333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LYR", Name = "Lyra", IdentifierCased = "Lyr", IdentifierValue = ConstellationValue.Lyra,
            IAURank = 52, Quadrant = Quadrant.Nq4, RightAscension = 18.852833333333333, Declination = 36.68933333333333,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CRT", Name = "Crater", IdentifierCased = "Crt", IdentifierValue = ConstellationValue.Crater,
            IAURank = 53, Quadrant = Quadrant.Sq2, RightAscension = 11.395833333333334, Declination = -15.929,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "COL", Name = "Columba", IdentifierCased = "Col", IdentifierValue = ConstellationValue.Columba,
            IAURank = 54, Quadrant = Quadrant.Sq1, RightAscension = 5.862666666666667, Declination = -35.0945,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "VUL", Name = "Vulpecula", IdentifierCased = "Vul",
            IdentifierValue = ConstellationValue.Vulpecula, IAURank = 55, Quadrant = Quadrant.Nq4,
            RightAscension = 20.231333333333332, Declination = 24.442666666666668, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "UMI", Name = "Ursa Minor", IdentifierCased = "UMi",
            IdentifierValue = ConstellationValue.UrsaMinor, IAURank = 56, Quadrant = Quadrant.Nq3, RightAscension = 15,
            Declination = 77.69983333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "TEL", Name = "Telescopium", IdentifierCased = "Tel",
            IdentifierValue = ConstellationValue.Telescopium, IAURank = 57, Quadrant = Quadrant.Sq4,
            RightAscension = 19.325666666666667, Declination = -51.036833333333334, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "HOR", Name = "Horologium", IdentifierCased = "Hor",
            IdentifierValue = ConstellationValue.Horologium, IAURank = 58, Quadrant = Quadrant.Sq1,
            RightAscension = 3.276, Declination = -53.336333333333336, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PIC", Name = "Pictor", IdentifierCased = "Pic", IdentifierValue = ConstellationValue.Pictor,
            IAURank = 59, Quadrant = Quadrant.Sq1, RightAscension = 5.707666666666666, Declination = -53.47416666666667,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "ERI", Name = "Eridanus", IdentifierCased = "Eri",
            IdentifierValue = ConstellationValue.Eridanus, IAURank = 6, Quadrant = Quadrant.Sq1,
            RightAscension = 3.3003333333333336, Declination = -28.756166666666665, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PSA", Name = "Piscis Austrinus", IdentifierCased = "PsA",
            IdentifierValue = ConstellationValue.PiscisAustrinus, IAURank = 60, Quadrant = Quadrant.Sq4,
            RightAscension = 22.2845, Declination = -30.642166666666668, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "HYI", Name = "Hydrus", IdentifierCased = "Hyi", IdentifierValue = ConstellationValue.Hydrus,
            IAURank = 61, Quadrant = Quadrant.Sq1, RightAscension = 2.3441666666666667, Declination = -69.9565,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "ANT", Name = "Antlia", IdentifierCased = "Ant", IdentifierValue = ConstellationValue.Antlia,
            IAURank = 62, Quadrant = Quadrant.Sq2, RightAscension = 10.273833333333334, Declination = -32.4835,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "ARA", Name = "Ara", IdentifierCased = "Ara", IdentifierValue = ConstellationValue.Ara,
            IAURank = 63, Quadrant = Quadrant.Sq3, RightAscension = 17.374833333333335,
            Declination = -56.58833333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LMI", Name = "Leo Minor", IdentifierCased = "LMi",
            IdentifierValue = ConstellationValue.LeoMinor, IAURank = 64, Quadrant = Quadrant.Nq2,
            RightAscension = 10.245333333333333, Declination = 32.13466666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PYX", Name = "Pyxis", IdentifierCased = "Pyx", IdentifierValue = ConstellationValue.Pyxis,
            IAURank = 65, Quadrant = Quadrant.Sq2, RightAscension = 8.952666666666667,
            Declination = -27.351666666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "MIC", Name = "Microscopium", IdentifierCased = "Mic",
            IdentifierValue = ConstellationValue.Microscopium, IAURank = 66, Quadrant = Quadrant.Sq4,
            RightAscension = 20.964666666666666, Declination = -36.27483333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "APS", Name = "Apus", IdentifierCased = "Aps", IdentifierValue = ConstellationValue.Apus,
            IAURank = 67, Quadrant = Quadrant.Sq3, RightAscension = 16.144166666666667, Declination = -75.3,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "LAC", Name = "Lacerta", IdentifierCased = "Lac", IdentifierValue = ConstellationValue.Lacerta,
            IAURank = 68, Quadrant = Quadrant.Nq4, RightAscension = 22.461333333333332, Declination = 46.04183333333334,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "DEL", Name = "Delphinus", IdentifierCased = "Del",
            IdentifierValue = ConstellationValue.Delphinus, IAURank = 69, Quadrant = Quadrant.Nq4,
            RightAscension = 20.6935, Declination = 11.671, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "PEG", Name = "Pegasus", IdentifierCased = "Peg", IdentifierValue = ConstellationValue.Pegasus,
            IAURank = 7, Quadrant = Quadrant.Nq4, RightAscension = 22.697333333333333, Declination = 19.466333333333335,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CRV", Name = "Corvus", IdentifierCased = "Crv", IdentifierValue = ConstellationValue.Corvus,
            IAURank = 70, Quadrant = Quadrant.Sq3, RightAscension = 12.442, Declination = -18.436666666666667,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CMI", Name = "Canis Minor", IdentifierCased = "CMi",
            IdentifierValue = ConstellationValue.CanisMinor, IAURank = 71, Quadrant = Quadrant.Nq2,
            RightAscension = 7.652833333333334, Declination = 6.4271666666666665, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "DOR", Name = "Dorado", IdentifierCased = "Dor", IdentifierValue = ConstellationValue.Dorado,
            IAURank = 72, Quadrant = Quadrant.Sq1, RightAscension = 5.241833333333333, Declination = -59.387,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CRB", Name = "Corona Borealis", IdentifierCased = "CrB",
            IdentifierValue = ConstellationValue.CoronaBorealis, IAURank = 73, Quadrant = Quadrant.Nq3,
            RightAscension = 15.843166666666667, Declination = 32.624833333333335, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "NOR", Name = "Norma", IdentifierCased = "Nor", IdentifierValue = ConstellationValue.Norma,
            IAURank = 74, Quadrant = Quadrant.Sq3, RightAscension = 15.903, Declination = -51.3515,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "MEN", Name = "Mensa", IdentifierCased = "Men", IdentifierValue = ConstellationValue.Mensa,
            IAURank = 75, Quadrant = Quadrant.Sq1, RightAscension = 5.415, Declination = -77.504,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "VOL", Name = "Volans", IdentifierCased = "Vol", IdentifierValue = ConstellationValue.Volans,
            IAURank = 76, Quadrant = Quadrant.Sq2, RightAscension = 7.7955, Declination = -69.80116666666666,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "MUS", Name = "Musca", IdentifierCased = "Mus", IdentifierValue = ConstellationValue.Musca,
            IAURank = 77, Quadrant = Quadrant.Sq3, RightAscension = 12.588, Declination = -70.161,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "TRI", Name = "Triangulum", IdentifierCased = "Tri",
            IdentifierValue = ConstellationValue.Triangulum, IAURank = 78, Quadrant = Quadrant.Nq1,
            RightAscension = 2.1845, Declination = 31.476, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CHA", Name = "Chamaeleon", IdentifierCased = "Cha",
            IdentifierValue = ConstellationValue.Chamaeleon, IAURank = 79, Quadrant = Quadrant.Sq2,
            RightAscension = 10.692166666666667, Declination = -79.205, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "DRA", Name = "Draco", IdentifierCased = "Dra", IdentifierValue = ConstellationValue.Draco,
            IAURank = 8, Quadrant = Quadrant.Nq3, RightAscension = 15.144, Declination = 67.00666666666666,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CRA", Name = "Corona Australis", IdentifierCased = "CrA",
            IdentifierValue = ConstellationValue.CoronaAustralis, IAURank = 80, Quadrant = Quadrant.Sq4,
            RightAscension = 18.6465, Declination = -41.1475, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CAE", Name = "Caelum", IdentifierCased = "Cae", IdentifierValue = ConstellationValue.Caelum,
            IAURank = 81, Quadrant = Quadrant.Sq1, RightAscension = 4.7045, Declination = -37.88166666666667,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "RET", Name = "Reticulum", IdentifierCased = "Ret",
            IdentifierValue = ConstellationValue.Reticulum, IAURank = 82, Quadrant = Quadrant.Sq1,
            RightAscension = 3.9211666666666667, Declination = -59.9975, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "TRA", Name = "Triangulum Australe", IdentifierCased = "TrA",
            IdentifierValue = ConstellationValue.TriangulumAustrale, IAURank = 83, Quadrant = Quadrant.Sq3,
            RightAscension = 16.0825, Declination = -65.388, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SCT", Name = "Scutum", IdentifierCased = "Sct", IdentifierValue = ConstellationValue.Scutum,
            IAURank = 84, Quadrant = Quadrant.Sq4, RightAscension = 18.673166666666667,
            Declination = -9.888666666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CIR", Name = "Circinus", IdentifierCased = "Cir",
            IdentifierValue = ConstellationValue.Circinus, IAURank = 85, Quadrant = Quadrant.Sq3,
            RightAscension = 14.575666666666667, Declination = -63.03033333333333, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "SGE", Name = "Sagitta", IdentifierCased = "Sge", IdentifierValue = ConstellationValue.Sagitta,
            IAURank = 86, Quadrant = Quadrant.Nq4, RightAscension = 19.650833333333335,
            Declination = 18.861333333333334, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "EQU", Name = "Equuleus", IdentifierCased = "Equ",
            IdentifierValue = ConstellationValue.Equuleus, IAURank = 87, Quadrant = Quadrant.Nq4,
            RightAscension = 21.187666666666665, Declination = 7.758166666666667, SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CRU", Name = "Crux", IdentifierCased = "Cru", IdentifierValue = ConstellationValue.Crux,
            IAURank = 88, Quadrant = Quadrant.Sq3, RightAscension = 12.449833333333334, Declination = -60.1865,
            SerpensOfficial = false,
        },
        new()
        {
            Identifier = "CEN", Name = "Centaurus", IdentifierCased = "Cen",
            IdentifierValue = ConstellationValue.Centaurus, IAURank = 9, Quadrant = Quadrant.Sq3,
            RightAscension = 13.071166666666667, Declination = -47.345333333333336, SerpensOfficial = false,
        },
    };
}