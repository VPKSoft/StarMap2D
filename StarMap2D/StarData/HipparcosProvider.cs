using System.Globalization;
using AASharp;
using StarMap2D.Calculations.CatalogProvider.Interfaces;

namespace StarMap2D.StarData
{
    internal class HipparcosProvider : IStarDataProvider<HipparcosStarData>
    {
        public List<HipparcosStarData> StarData { get; } = new();

        /// <inheritdoc cref="IStarDataProvider{T}.LoadData"/>
        public void LoadData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            RawDataEntries.AddRange(lines);

            foreach (var rawDataEntry in RawDataEntries)
            {
                var name = GetDataRaw(rawDataEntry, "Name");

                // We don't need the sun (in this case).
                if (name.Trim() == "Sun")
                {
                    continue;
                }

                var hip = int.Parse(GetDataRaw(rawDataEntry, "HIP"));

                var raData = GetDataRaw(rawDataEntry, "RAhms").Split(' ');

                var raHours = double.Parse(raData[0], CultureInfo.InvariantCulture);
                var raMinutes = double.Parse(raData[1], CultureInfo.InvariantCulture);
                var raSeconds = double.Parse(raData[2], CultureInfo.InvariantCulture);
                var rightAscension = raHours + raMinutes / 60 + raSeconds / 3600;
                    //AASCoordinateTransformation.HoursToDegrees(raHours + raMinutes / 60 + raSeconds / 3600);

                var deData = GetDataRaw(rawDataEntry, "DEdms").Split(' ');

                var deDegrees = double.Parse(deData[0], CultureInfo.InvariantCulture);
                var deMinutes = double.Parse(deData[1], CultureInfo.InvariantCulture);
                var deSeconds = double.Parse(deData[2], CultureInfo.InvariantCulture);

                var declination = AASCoordinateTransformation.DMSToDegrees(deDegrees, deMinutes, deSeconds);

                var mag = GetDataRaw(rawDataEntry, "Vmag").Trim();

                mag = string.IsNullOrWhiteSpace(mag) ? "0" : mag;

                var magnitude = double.Parse(mag, CultureInfo.InvariantCulture);

                StarData.Add(new HipparcosStarData
                {
                    HIP = hip, Declination = declination, RightAscension = rightAscension, Magnitude = magnitude, 
                });
            }
        }

        private string ReadRaw(string lineEntry, int index, int end)
        {
            end += 1;
            var result = lineEntry.Substring(index - 1, end - index);
            return result;
        }

        /// <inheritdoc cref="IStarDataProvider{T}.GetDataRaw"/>
        public string GetDataRaw(string rawDataEntry, string dataName)
        {
            if (!FieldNames.Contains(dataName))
            {
                return string.Empty;
            }

            var index = new List<string>(FieldNames).IndexOf(dataName);

            return ReadRaw(rawDataEntry, FieldPositions[index].start, FieldPositions[index].end);
        }


        /// <inheritdoc cref="IStarDataProvider{T}.RawDataEntries"/>
        public List<string> RawDataEntries { get; } = new();


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
    }
}
