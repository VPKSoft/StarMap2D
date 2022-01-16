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

using System.Globalization;
using AASharp;
using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers
{
    /// <summary>
    /// A data provider of Tycho ESA 1997 star catalog data.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    public class TychoProvider: IStarDataProvider<TychoStarData>, ILoadDataLines
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<TychoStarData> StarData { get; } = new();

        /// <inheritdoc cref="ILoadDataLines.LoadData(string[])"/>
        public void LoadData(string[] lines)
        {
            RawDataEntries.AddRange(lines);

            foreach (var rawDataEntry in RawDataEntries)
            {
                var name = GetDataRaw(rawDataEntry, "Name");

                // We don't need the sun (in this case).
                if (name.Trim() == "Sun")
                {
                    continue;
                }

                var tyc = GetDataRaw(rawDataEntry, "TYC").Trim();

                var raData = GetDataRaw(rawDataEntry, "RAhms").Split(' ');

                var raHours = double.Parse(raData[0], CultureInfo.InvariantCulture);
                var raMinutes = double.Parse(raData[1], CultureInfo.InvariantCulture);
                var raSeconds = double.Parse(raData[2], CultureInfo.InvariantCulture);
                var rightAscension = raHours + raMinutes / 60 + raSeconds / 3600;

                var deData = GetDataRaw(rawDataEntry, "DEdms").Split(' ');

                var deDegrees = double.Parse(deData[0], CultureInfo.InvariantCulture);
                var deMinutes = double.Parse(deData[1], CultureInfo.InvariantCulture);
                var deSeconds = double.Parse(deData[2], CultureInfo.InvariantCulture);

                var declination = AASCoordinateTransformation.DMSToDegrees(deDegrees, deMinutes, deSeconds);

                var mag = GetDataRaw(rawDataEntry, "Vmag").Trim();

                mag = string.IsNullOrWhiteSpace(mag) ? "0" : mag;

                var magnitude = double.Parse(mag, CultureInfo.InvariantCulture);

                StarData.Add(new TychoStarData
                {
                    TYC = tyc, Declination = declination, RightAscension = rightAscension, Magnitude = magnitude, 
                });
            }
        }

        /// <inheritdoc cref="IStarDataProvider{T}.LoadData(string)"/>
        public void LoadData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            LoadData(lines);
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

        private string ReadRaw(string lineEntry, int index, int end)
        {
            end += 1;
            var result = lineEntry.Substring(index - 1, end - index);
            return result;
        }

        /// <inheritdoc cref="IStarDataProvider{T}.RawDataEntries"/>
        public List<string> RawDataEntries { get; } = new();

        /// <summary>
        /// The field names of the star data of this provider.
        /// </summary>
        public static readonly string[] FieldNames =
        {
            "Catalog",
            "TYC",
            "Proxy",
            "RAhms",
            "DEdms",
            "Vmag",
            "---N/A_1", // Reserved field.
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
            "Nastro",
            "F2",
            "HIP",
            "BTmag",
            "e_BTmag",
            "VTmag",
            "e_VTmag",
            "r_BTmag",
            "B-V",
            "e_B-V",
            "---N/A_2", // Reserved field.
            "Q",
            "Fs",
            "Source",
            "Nphoto",
            "VTscat",
            "VTmax",
            "VTmin",
            "Var",
            "VarFlag",
            "MultFlag",
            "morePhoto",
            "m_HIP",
            "PPM",
            "HD",
            "BD",
            "CoD",
            "CPD",
            "Remark",
        };

        private static readonly (int start, int end)[] FieldPositions =
        {
            (1, 1),
            (3, 14),
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
            (261, 261),
            (263, 266),
            (268, 268),
            (270, 272),
            (274, 278),
            (280, 284),
            (286, 290),
            (292, 292),
            (294, 294),
            (296, 296),
            (298, 298),
            (300, 301),
            (303, 308),
            (310, 315),
            (317, 326),
            (328, 337),
            (339, 348),
            (350, 350),
        };
    }
}
