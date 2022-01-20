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

using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers
{
    /// <summary>
    /// Star data entry for the Hipparcos catalog.
    /// Implements the <see cref="IStarData" />
    /// </summary>
    /// <seealso cref="IStarData" />
    public class HipparcosStarData : StarData
    {
        private int? hip;

        /// <summary>
        /// Identifier (HIP number).
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? HIP
        {
            get
            {
                if (!FetchMemory["HIP"])
                {
                    hip = GetEntryByName<int?>("HIP");
                    FetchMemory["HIP"] = true;
                }
                
                return hip;
            }
            
            set
            {
                FetchMemory["HIP"] = true;
                hip = value;
            }
        }

        /// <summary>
        /// The field names of the star data of this provider.
        /// </summary>
        public static readonly string[] FieldNames =
        {
            "Catalog",
            "HIP",
            "Proxy",
            "RAhms",
            "DEdms",
            "Vmag",
            "VarFlag",
            "r_Vmag",
            "RAdeg",
            "DEdeg",
            "AstroRef",
            "Plx",
            "pmRA",
            "pmDE",
            "e_RAdeg",
            "e_DEdeg",
            "e_Plx",
            "e_pmRA",
            "e_pmDE",
            "DE:RA",
            "Plx:RA",
            "Plx:DE",
            "pmRA:RA",
            "pmRA:DE",
            "pmRA:Plx",
            "pmDE:RA",
            "pmDE:DE",
            "pmDE:Plx",
            "pmDE:pmRA",
            "F1",
            "F2",
            "HIPr",
            "BTmag",
            "e_BTmag",
            "VTmag",
            "e_VTmag",
            "m_BTmag",
            "B-V",
            "e_B-V",
            "r_B-V",
            "V-I",
            "e_V-I",
            "r_V-I",
            "CombMag",
            "Hpmag",
            "e_Hpmag",
            "Hpscat",
            "o_Hpmag",
            "m_Hpmag",
            "Hpmax",
            "HPmin",
            "Period",
            "HvarType",
            "moreVar",
            "morePhoto",
            "CCDM",
            "n_CCDM",
            "Nsys",
            "Ncomp",
            "MultFlag",
            "Source",
            "Qual",
            "m_HIP",
            "theta",
            "rho",
            "e_rho",
            "dHp",
            "e_dHp",
            "Survey",
            "Chart",
            "Notes",
            "HD",
            "BD",
            "CoD",
            "CPD",
            "(V-I)red",
            "SpType",
            "r_SpType",
        };

        private static readonly (int start, int end)[] FieldPositions =
        {
            (1, 1),
            (9, 14),
            (16, 16),
            (18, 28),
            (30, 40),
            (42, 46),
            (48, 48),
            (50, 50),
            (52, 63),
            (65, 76),
            (78, 78),
            (80, 86),
            (88, 95),
            (97, 104),
            (106, 111),
            (113, 118),
            (120, 125),
            (127, 132),
            (134, 139),
            (141, 145),
            (147, 151),
            (153, 157),
            (159, 163),
            (165, 169),
            (171, 175),
            (177, 181),
            (183, 187),
            (189, 193),
            (195, 199),
            (201, 203),
            (205, 209),
            (211, 216),
            (218, 223),
            (225, 229),
            (231, 236),
            (238, 242),
            (244, 244),
            (246, 251),
            (253, 257),
            (259, 259),
            (261, 264),
            (266, 269),
            (271, 271),
            (273, 273),
            (275, 281),
            (283, 288),
            (290, 294),
            (296, 298),
            (300, 300),
            (302, 306),
            (308, 312),
            (314, 320),
            (322, 322),
            (324, 324),
            (326, 326),
            (328, 337),
            (339, 339),
            (341, 342),
            (344, 345),
            (347, 347),
            (349, 349),
            (351, 351),
            (353, 354),
            (356, 358),
            (360, 366),
            (368, 372),
            (374, 378),
            (380, 383),
            (385, 385),
            (387, 387),
            (389, 389),
            (391, 396),
            (398, 407),
            (409, 418),
            (420, 429),
            (431, 434),
            (436, 447),
            (449, 449),
        };

        private static string ReadRaw(string lineEntry, int index, int end)
        {
            end += 1;
            var result = lineEntry.Substring(index - 1, end - index);
            return result;
        }

        private static List<string> FieldNameList { get; } = new();

        /// <summary>
        /// Gets the raw data of the star based by the data field name.
        /// </summary>
        /// <param name="rawDataEntry">The raw data entry.</param>
        /// <param name="dataName">Name of the data.</param>
        /// <returns>System.String.</returns>
        public static string? GetDataRaw(string? rawDataEntry, string dataName)
        {
            if (rawDataEntry == null)
            {
                return null;
            }

            if (FieldNameList.Count == 0)
            {
                FieldNameList.AddRange(FieldNames);
            }

            if (!FieldNames.Contains(dataName))
            {
                return string.Empty;
            }

            var index = new List<string>(FieldNames).IndexOf(dataName);

            return ReadRaw(rawDataEntry, FieldPositions[index].start, FieldPositions[index].end);
        }
    }
}
