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
    /// A class to provide star data from the Yale Bright Star Catalog 5th edition.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    public class YaleBrightProvider: IStarDataProvider<YaleBrightStarData>
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<YaleBrightStarData> StarData { get; } = new();

        /// <inheritdoc cref="IStarDataProvider{T}.LoadData"/>
        public void LoadData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            RawDataEntries.AddRange(lines);

            foreach (var rawDataEntry in RawDataEntries)
            {
                try
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

                    var deDegrees =
                        double.Parse(GetDataRaw(rawDataEntry, "DE-").Trim() + GetDataRaw(rawDataEntry, "DEd").Trim(),
                            CultureInfo.InvariantCulture);
                    var deMinutes = double.Parse(GetDataRaw(rawDataEntry, "DEm").Trim(), CultureInfo.InvariantCulture);
                    var deSeconds = double.Parse(GetDataRaw(rawDataEntry, "DEs").Trim(), CultureInfo.InvariantCulture);

                    var declination = AASCoordinateTransformation.DMSToDegrees(deDegrees, deMinutes, deSeconds);

                    var magnitude = double.Parse(GetDataRaw(rawDataEntry, "Vmag").Trim(), CultureInfo.InvariantCulture);


                    StarData.Add(new YaleBrightStarData
                    {
                        Name = name, Declination = declination, RightAscension = rightAscension, Magnitude = magnitude
                    });
                }
                catch
                {
                    // Erroneous record.
                }
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
            if (FieldNameList.Count == 0)
            {
                FieldNameList.AddRange(FieldNames);
            }

            var dataIndex = FieldNameList.IndexOf(dataName);

            if (dataIndex != -1)
            {
                return ReadRaw(rawDataEntry, FieldPositions[dataIndex].start, FieldPositions[dataIndex].end);
            }

            return string.Empty;
        }

        /// <inheritdoc cref="IStarDataProvider{T}.RawDataEntries"/>
        public List<string> RawDataEntries { get; } = new();

        private List<string> FieldNameList { get; } = new();

        private static readonly (int start, int end)[] FieldPositions =
        {
            (1, 4),
            (5, 14),
            (15, 25),
            (26, 31),
            (32, 37),
            (38, 41),
            (42, 42),
            (43, 43),
            (44, 44),
            (45, 49),
            (50, 51),
            (52, 60),
            (61, 62),
            (63, 64),
            (65, 68),
            (69, 69),
            (70, 71),
            (72, 73),
            (74, 75),
            (76, 77),
            (78, 79),
            (80, 83),
            (84, 84),
            (85, 86),
            (87, 88),
            (89, 90),
            (91, 96),
            (97, 102),
            (103, 107),
            (108, 108),
            (109, 109),
            (110, 114),
            (115, 115),
            (116, 120),
            (121, 121),
            (122, 126),
            (127, 127),
            (128, 147),
            (148, 148),
            (149, 154),
            (155, 160),
            (161, 161),
            (162, 166),
            (167, 170),
            (171, 174),
            (175, 176),
            (177, 179),
            (180, 180),
            (181, 184),
            (185, 190),
            (191, 194),
            (195, 196),
            (197, 197),
        };

        /// <summary>
        /// The field names of the star data of this provider.
        /// </summary>
        public static readonly string[] FieldNames =
        {
            "HR",
            "Name",
            "DM",
            "HD",
            "SAO",
            "FK5",
            "IRflag",
            "r_IRflag",
            "Multiple",
            "ADS",
            "ADScomp",
            "VarID",
            "RAh1900",
            "RAm1900",
            "RAs1900",
            "DE-1900",
            "DEd1900",
            "DEm1900",
            "DEs1900",
            "RAh",
            "RAm",
            "RAs",
            "DE-",
            "DEd",
            "DEm",
            "DEs",
            "GLON",
            "GLAT",
            "Vmag",
            "n_Vmag",
            "u_Vmag",
            "B-V",
            "u_B-V",
            "U-B",
            "u_U-B",
            "R-I",
            "n_R-I",
            "SpType",
            "n_SpType",
            "pmRA",
            "pmDE",
            "n_Parallax",
            "Parallax",
            "RadVel",
            "n_RadVel",
            "l_RotVel",
            "RotVel",
            "u_RotVel",
            "Dmag",
            "Sep",
            "MultID",
            "MultCnt",
            "NoteFlag1",
        };
    }
}
