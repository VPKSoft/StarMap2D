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

namespace StarMap2D.Calculations.Constellations.StaticData
{
    /// <summary>
    /// A collection of the 88 constellation names and their identifiers.
    /// </summary>
    public class ConstellationCollection
    {
        /// <summary>
        /// A list of constellations defined by IAU.
        /// </summary>
        public static IReadOnlyList<ConstellationNameIdentifier> Constellations { get; } = new ConstellationNameIdentifier[]
        {
            new()
            {
                Identifier = "HYA", Name = "Hydra", IdentifierCased = "Hya", IdentifierValue = ConstellationValue.Hydra,
                IAURank = 1,
            },
            new()
            {
                Identifier = "VIR", Name = "Virgo", IdentifierCased = "Vir", IdentifierValue = ConstellationValue.Virgo,
                IAURank = 2,
            },
            new()
            {
                Identifier = "UMA", Name = "Ursa Major", IdentifierCased = "UMa",
                IdentifierValue = ConstellationValue.UrsaMajor, IAURank = 3,
            },
            new()
            {
                Identifier = "CET", Name = "Cetus", IdentifierCased = "Cet", IdentifierValue = ConstellationValue.Cetus,
                IAURank = 4,
            },
            new()
            {
                Identifier = "HER", Name = "Hercules", IdentifierCased = "Her",
                IdentifierValue = ConstellationValue.Hercules, IAURank = 5,
            },
            new()
            {
                Identifier = "ERI", Name = "Eridanus", IdentifierCased = "Eri",
                IdentifierValue = ConstellationValue.Eridanus, IAURank = 6,
            },
            new()
            {
                Identifier = "PEG", Name = "Pegasus", IdentifierCased = "Peg",
                IdentifierValue = ConstellationValue.Pegasus, IAURank = 7,
            },
            new()
            {
                Identifier = "DRA", Name = "Draco", IdentifierCased = "Dra", IdentifierValue = ConstellationValue.Draco,
                IAURank = 8,
            },
            new()
            {
                Identifier = "CEN", Name = "Centaurus", IdentifierCased = "Cen",
                IdentifierValue = ConstellationValue.Centaurus, IAURank = 9,
            },
            new()
            {
                Identifier = "AQR", Name = "Aquarius", IdentifierCased = "Aqr",
                IdentifierValue = ConstellationValue.Aquarius, IAURank = 10,
            },
            new()
            {
                Identifier = "OPH", Name = "Ophiuchus", IdentifierCased = "Oph",
                IdentifierValue = ConstellationValue.Ophiuchus, IAURank = 11,
            },
            new()
            {
                Identifier = "LEO", Name = "Leo", IdentifierCased = "Leo", IdentifierValue = ConstellationValue.Leo,
                IAURank = 12,
            },
            new()
            {
                Identifier = "BOO", Name = "Boötes", IdentifierCased = "Boo",
                IdentifierValue = ConstellationValue.Boötes, IAURank = 13,
            },
            new()
            {
                Identifier = "PSC", Name = "Pisces", IdentifierCased = "Psc",
                IdentifierValue = ConstellationValue.Pisces, IAURank = 14,
            },
            new()
            {
                Identifier = "SGR", Name = "Sagittarius", IdentifierCased = "Sgr",
                IdentifierValue = ConstellationValue.Sagittarius, IAURank = 15,
            },
            new()
            {
                Identifier = "CYG", Name = "Cygnus", IdentifierCased = "Cyg",
                IdentifierValue = ConstellationValue.Cygnus, IAURank = 16,
            },
            new()
            {
                Identifier = "TAU", Name = "Taurus", IdentifierCased = "Tau",
                IdentifierValue = ConstellationValue.Taurus, IAURank = 17,
            },
            new()
            {
                Identifier = "CAM", Name = "Camelopardalis", IdentifierCased = "Cam",
                IdentifierValue = ConstellationValue.Camelopardalis, IAURank = 18,
            },
            new()
            {
                Identifier = "AND", Name = "Andromeda", IdentifierCased = "And",
                IdentifierValue = ConstellationValue.Andromeda, IAURank = 19,
            },
            new()
            {
                Identifier = "PUP", Name = "Puppis", IdentifierCased = "Pup",
                IdentifierValue = ConstellationValue.Puppis, IAURank = 20,
            },
            new()
            {
                Identifier = "AUR", Name = "Auriga", IdentifierCased = "Aur",
                IdentifierValue = ConstellationValue.Auriga, IAURank = 21,
            },
            new()
            {
                Identifier = "AQL", Name = "Aquila", IdentifierCased = "Aql",
                IdentifierValue = ConstellationValue.Aquila, IAURank = 22,
            },
            new()
            {
                Identifier = "SER", Name = "Serpens", IdentifierCased = "Ser",
                IdentifierValue = ConstellationValue.SerpensCaput, IAURank = 23,
            },
            new()
            {
                Identifier = "SEC", Name = "Serpens", IdentifierCased = "Ser",
                IdentifierValue = ConstellationValue.SerpensCauda, IAURank = 23,
            },
            new()
            {
                Identifier = "PER", Name = "Perseus", IdentifierCased = "Per",
                IdentifierValue = ConstellationValue.Perseus, IAURank = 24,
            },
            new()
            {
                Identifier = "CAS", Name = "Cassiopeia", IdentifierCased = "Cas",
                IdentifierValue = ConstellationValue.Cassiopeia, IAURank = 25,
            },
            new()
            {
                Identifier = "ORI", Name = "Orion", IdentifierCased = "Ori", IdentifierValue = ConstellationValue.Orion,
                IAURank = 26,
            },
            new()
            {
                Identifier = "CEP", Name = "Cepheus", IdentifierCased = "Cep",
                IdentifierValue = ConstellationValue.Cepheus, IAURank = 27,
            },
            new()
            {
                Identifier = "LYN", Name = "Lynx", IdentifierCased = "Lyn", IdentifierValue = ConstellationValue.Lynx,
                IAURank = 28,
            },
            new()
            {
                Identifier = "LIB", Name = "Libra", IdentifierCased = "Lib", IdentifierValue = ConstellationValue.Libra,
                IAURank = 29,
            },
            new()
            {
                Identifier = "GEM", Name = "Gemini", IdentifierCased = "Gem",
                IdentifierValue = ConstellationValue.Gemini, IAURank = 30,
            },
            new()
            {
                Identifier = "CNC", Name = "Cancer", IdentifierCased = "Cnc",
                IdentifierValue = ConstellationValue.Cancer, IAURank = 31,
            },
            new()
            {
                Identifier = "VEL", Name = "Vela", IdentifierCased = "Vel", IdentifierValue = ConstellationValue.Vela,
                IAURank = 32,
            },
            new()
            {
                Identifier = "SCO", Name = "Scorpius", IdentifierCased = "Sco",
                IdentifierValue = ConstellationValue.Scorpius, IAURank = 33,
            },
            new()
            {
                Identifier = "CAR", Name = "Carina", IdentifierCased = "Car",
                IdentifierValue = ConstellationValue.Carina, IAURank = 34,
            },
            new()
            {
                Identifier = "MON", Name = "Monoceros", IdentifierCased = "Mon",
                IdentifierValue = ConstellationValue.Monoceros, IAURank = 35,
            },
            new()
            {
                Identifier = "SCL", Name = "Sculptor", IdentifierCased = "Scl",
                IdentifierValue = ConstellationValue.Sculptor, IAURank = 36,
            },
            new()
            {
                Identifier = "PHE", Name = "Phoenix", IdentifierCased = "Phe",
                IdentifierValue = ConstellationValue.Phoenix, IAURank = 37,
            },
            new()
            {
                Identifier = "CVN", Name = "Canes Venatici", IdentifierCased = "CVn",
                IdentifierValue = ConstellationValue.CanesVenatici, IAURank = 38,
            },
            new()
            {
                Identifier = "ARI", Name = "Aries", IdentifierCased = "Ari", IdentifierValue = ConstellationValue.Aries,
                IAURank = 39,
            },
            new()
            {
                Identifier = "CAP", Name = "Capricornus", IdentifierCased = "Cap",
                IdentifierValue = ConstellationValue.Capricornus, IAURank = 40,
            },
            new()
            {
                Identifier = "FOR", Name = "Fornax", IdentifierCased = "For",
                IdentifierValue = ConstellationValue.Fornax, IAURank = 41,
            },
            new()
            {
                Identifier = "COM", Name = "Coma Berenices", IdentifierCased = "Com",
                IdentifierValue = ConstellationValue.ComaBerenices, IAURank = 42,
            },
            new()
            {
                Identifier = "CMA", Name = "Canis Major", IdentifierCased = "CMa",
                IdentifierValue = ConstellationValue.CanisMajor, IAURank = 43,
            },
            new()
            {
                Identifier = "PAV", Name = "Pavo", IdentifierCased = "Pav", IdentifierValue = ConstellationValue.Pavo,
                IAURank = 44,
            },
            new()
            {
                Identifier = "GRU", Name = "Grus", IdentifierCased = "Gru", IdentifierValue = ConstellationValue.Grus,
                IAURank = 45,
            },
            new()
            {
                Identifier = "LUP", Name = "Lupus", IdentifierCased = "Lup", IdentifierValue = ConstellationValue.Lupus,
                IAURank = 46,
            },
            new()
            {
                Identifier = "SEX", Name = "Sextans", IdentifierCased = "Sex",
                IdentifierValue = ConstellationValue.Sextans, IAURank = 47,
            },
            new()
            {
                Identifier = "TUC", Name = "Tucana", IdentifierCased = "Tuc",
                IdentifierValue = ConstellationValue.Tucana, IAURank = 48,
            },
            new()
            {
                Identifier = "IND", Name = "Indus", IdentifierCased = "Ind", IdentifierValue = ConstellationValue.Indus,
                IAURank = 49,
            },
            new()
            {
                Identifier = "OCT", Name = "Octans", IdentifierCased = "Oct",
                IdentifierValue = ConstellationValue.Octans, IAURank = 50,
            },
            new()
            {
                Identifier = "LEP", Name = "Lepus", IdentifierCased = "Lep", IdentifierValue = ConstellationValue.Lepus,
                IAURank = 51,
            },
            new()
            {
                Identifier = "LYR", Name = "Lyra", IdentifierCased = "Lyr", IdentifierValue = ConstellationValue.Lyra,
                IAURank = 52,
            },
            new()
            {
                Identifier = "CRT", Name = "Crater", IdentifierCased = "Crt",
                IdentifierValue = ConstellationValue.Crater, IAURank = 53,
            },
            new()
            {
                Identifier = "COL", Name = "Columba", IdentifierCased = "Col",
                IdentifierValue = ConstellationValue.Columba, IAURank = 54,
            },
            new()
            {
                Identifier = "VUL", Name = "Vulpecula", IdentifierCased = "Vul",
                IdentifierValue = ConstellationValue.Vulpecula, IAURank = 55,
            },
            new()
            {
                Identifier = "UMI", Name = "Ursa Minor", IdentifierCased = "UMi",
                IdentifierValue = ConstellationValue.UrsaMinor, IAURank = 56,
            },
            new()
            {
                Identifier = "TEL", Name = "Telescopium", IdentifierCased = "Tel",
                IdentifierValue = ConstellationValue.Telescopium, IAURank = 57,
            },
            new()
            {
                Identifier = "HOR", Name = "Horologium", IdentifierCased = "Hor",
                IdentifierValue = ConstellationValue.Horologium, IAURank = 58,
            },
            new()
            {
                Identifier = "PIC", Name = "Pictor", IdentifierCased = "Pic",
                IdentifierValue = ConstellationValue.Pictor, IAURank = 59,
            },
            new()
            {
                Identifier = "PSA", Name = "Piscis Austrinus", IdentifierCased = "PsA",
                IdentifierValue = ConstellationValue.PiscisAustrinus, IAURank = 60,
            },
            new()
            {
                Identifier = "HYI", Name = "Hydrus", IdentifierCased = "Hyi",
                IdentifierValue = ConstellationValue.Hydrus, IAURank = 61,
            },
            new()
            {
                Identifier = "ANT", Name = "Antlia", IdentifierCased = "Ant",
                IdentifierValue = ConstellationValue.Antlia, IAURank = 62,
            },
            new()
            {
                Identifier = "ARA", Name = "Ara", IdentifierCased = "Ara", IdentifierValue = ConstellationValue.Ara,
                IAURank = 63,
            },
            new()
            {
                Identifier = "LMI", Name = "Leo Minor", IdentifierCased = "LMi",
                IdentifierValue = ConstellationValue.LeoMinor, IAURank = 64,
            },
            new()
            {
                Identifier = "PYX", Name = "Pyxis", IdentifierCased = "Pyx", IdentifierValue = ConstellationValue.Pyxis,
                IAURank = 65,
            },
            new()
            {
                Identifier = "MIC", Name = "Microscopium", IdentifierCased = "Mic",
                IdentifierValue = ConstellationValue.Microscopium, IAURank = 66,
            },
            new()
            {
                Identifier = "APS", Name = "Apus", IdentifierCased = "Aps", IdentifierValue = ConstellationValue.Apus,
                IAURank = 67,
            },
            new()
            {
                Identifier = "LAC", Name = "Lacerta", IdentifierCased = "Lac",
                IdentifierValue = ConstellationValue.Lacerta, IAURank = 68,
            },
            new()
            {
                Identifier = "DEL", Name = "Delphinus", IdentifierCased = "Del",
                IdentifierValue = ConstellationValue.Delphinus, IAURank = 69,
            },
            new()
            {
                Identifier = "CRV", Name = "Corvus", IdentifierCased = "Crv",
                IdentifierValue = ConstellationValue.Corvus, IAURank = 70,
            },
            new()
            {
                Identifier = "CMI", Name = "Canis Minor", IdentifierCased = "CMi",
                IdentifierValue = ConstellationValue.CanisMinor, IAURank = 71,
            },
            new()
            {
                Identifier = "DOR", Name = "Dorado", IdentifierCased = "Dor",
                IdentifierValue = ConstellationValue.Dorado, IAURank = 72,
            },
            new()
            {
                Identifier = "CRB", Name = "Corona Borealis", IdentifierCased = "CrB",
                IdentifierValue = ConstellationValue.CoronaBorealis, IAURank = 73,
            },
            new()
            {
                Identifier = "NOR", Name = "Norma", IdentifierCased = "Nor", IdentifierValue = ConstellationValue.Norma,
                IAURank = 74,
            },
            new()
            {
                Identifier = "MEN", Name = "Mensa", IdentifierCased = "Men", IdentifierValue = ConstellationValue.Mensa,
                IAURank = 75,
            },
            new()
            {
                Identifier = "VOL", Name = "Volans", IdentifierCased = "Vol",
                IdentifierValue = ConstellationValue.Volans, IAURank = 76,
            },
            new()
            {
                Identifier = "MUS", Name = "Musca", IdentifierCased = "Mus", IdentifierValue = ConstellationValue.Musca,
                IAURank = 77,
            },
            new()
            {
                Identifier = "TRI", Name = "Triangulum", IdentifierCased = "Tri",
                IdentifierValue = ConstellationValue.Triangulum, IAURank = 78,
            },
            new()
            {
                Identifier = "CHA", Name = "Chamaeleon", IdentifierCased = "Cha",
                IdentifierValue = ConstellationValue.Chamaeleon, IAURank = 79,
            },
            new()
            {
                Identifier = "CRA", Name = "Corona Australis", IdentifierCased = "CrA",
                IdentifierValue = ConstellationValue.CoronaAustralis, IAURank = 80,
            },
            new()
            {
                Identifier = "CAE", Name = "Caelum", IdentifierCased = "Cae",
                IdentifierValue = ConstellationValue.Caelum, IAURank = 81,
            },
            new()
            {
                Identifier = "RET", Name = "Reticulum", IdentifierCased = "Ret",
                IdentifierValue = ConstellationValue.Reticulum, IAURank = 82,
            },
            new()
            {
                Identifier = "TRA", Name = "Triangulum Australe", IdentifierCased = "TrA",
                IdentifierValue = ConstellationValue.TriangulumAustrale, IAURank = 83,
            },
            new()
            {
                Identifier = "SCT", Name = "Scutum", IdentifierCased = "Sct",
                IdentifierValue = ConstellationValue.Scutum, IAURank = 84,
            },
            new()
            {
                Identifier = "CIR", Name = "Circinus", IdentifierCased = "Cir",
                IdentifierValue = ConstellationValue.Circinus, IAURank = 85,
            },
            new()
            {
                Identifier = "SGE", Name = "Sagitta", IdentifierCased = "Sge",
                IdentifierValue = ConstellationValue.Sagitta, IAURank = 86,
            },
            new()
            {
                Identifier = "EQU", Name = "Equuleus", IdentifierCased = "Equ",
                IdentifierValue = ConstellationValue.Equuleus, IAURank = 87,
            },
            new()
            {
                Identifier = "CRU", Name = "Crux", IdentifierCased = "Cru", IdentifierValue = ConstellationValue.Crux,
                IAURank = 88,
            },
        };
    }
}
