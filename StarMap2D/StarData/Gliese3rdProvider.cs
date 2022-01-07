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
using StarMap2D.Calculations.CatalogProvider.Interfaces;

namespace StarMap2D.StarData
{
    /// <summary>
    /// Class Gliese3rdProvider.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    // ReSharper disable once IdentifierTypo
    // ReSharper disable once InconsistentNaming
    public class Gliese3rdProvider : IStarDataProvider<Gliese3rdStarData>
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<Gliese3rdStarData> StarData { get; } = new();

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
        public List<string> RawDataEntries { get; } = new ();

        /// <summary>
        /// The field names of the star data of this provider.
        /// </summary>
        public static readonly string[] FieldNames = 
        {
            "Name",
            "Comp",
            "DistRel",
            "RAh",
            "RAm",
            "RAs",
            "DE-",
            "DEd",
            "DEm",
            "pm",
            "u_pm",
            "pmPA",
            "RV",
            "n_RV",
            "Sp",
            "r_Sp",
            "Vmag",
            "r_Vmag",
            "n_Vmag",
            "B-V",
            "r_B-V",
            "n_B-V",
            "U-B",
            "r_U-B",
            "n_U-B",
            "R-I",
            "r_R-I",
            "n_R-I",
            "trplx",
            "e_trplx",
            "plx",
            "e_plx",
            "n_plx",
            "Mv",
            "n_Mv",
            "q_Mv",
            "U",
            "V",
            "W",
            "HD",
            "DM",
            "Giclas",
            "LHS",
            "OtherName",
            "Remarks",
        };

        private static readonly (int start, int end)[] FieldPositions =
        {
            (1, 8),
            (9, 10),
            (11, 11),
            (13, 14),
            (16, 17),
            (19, 20),
            (22, 22),
            (23, 24),
            (26, 29),
            (31, 36),
            (37, 37),
            (38, 42),
            (44, 49),
            (51, 53),
            (55, 66),
            (67, 67),
            (68, 73),
            (74, 74),
            (75, 75),
            (76, 80),
            (81, 81),
            (82, 82),
            (83, 87),
            (88, 88),
            (89, 89),
            (90, 94),
            (95, 95),
            (96, 96),
            (97, 102),
            (103, 107),
            (109, 114),
            (115, 119),
            (120, 120),
            (122, 126),
            (127, 128),
            (129, 129),
            (132, 135),
            (137, 140),
            (142, 145),
            (147, 152),
            (154, 165),
            (167, 175),
            (177, 181),
            (183, 187),
            (189, 257),
        };

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

                var raHours = double.Parse(GetDataRaw(rawDataEntry, "RAh").Trim(), CultureInfo.InvariantCulture);
                var raMinutes = double.Parse(GetDataRaw(rawDataEntry, "RAm").Trim(), CultureInfo.InvariantCulture);
                var raSeconds = double.Parse(GetDataRaw(rawDataEntry, "RAs").Trim(), CultureInfo.InvariantCulture);
                var rightAscension = raHours + raMinutes / 60 + raSeconds / 3600;
                    //AASCoordinateTransformation.HoursToDegrees(raHours + raMinutes / 60 + raSeconds / 3600);

                var deDegrees = double.Parse(GetDataRaw(rawDataEntry, "DE-").Trim() + GetDataRaw(rawDataEntry, "DEd").Trim(), CultureInfo.InvariantCulture);
                var deMinutes = double.Parse(GetDataRaw(rawDataEntry, "DEm").Trim(), CultureInfo.InvariantCulture);

                var declination = AASCoordinateTransformation.DMSToDegrees(deDegrees, deMinutes, 0);

                var magnitude = double.Parse(GetDataRaw(rawDataEntry, "Vmag").Trim(), CultureInfo.InvariantCulture);


                StarData.Add(new Gliese3rdStarData
                {
                    Name = name, Declination = declination, RightAscension = rightAscension, Magnitude = magnitude
                });
            }
        }
    }
}
