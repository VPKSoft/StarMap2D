﻿#region License
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
    /// Star data entry for the Gliese 3rd database.
    /// Implements the <see cref="IStarData" />
    /// </summary>
    /// <seealso cref="IStarData" />
    // ReSharper disable once IdentifierTypo
    // ReSharper disable once InconsistentNaming
    public class Gliese3rdStarData : StarData
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public string? Name { get; set; }

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

        public static readonly (int start, int end)[] FieldPositions =
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

            if (!Gliese3rdStarData.FieldNames.Contains(dataName))
            {
                return string.Empty;
            }

            var index = new List<string>(Gliese3rdStarData.FieldNames).IndexOf(dataName);

            return ReadRaw(rawDataEntry, Gliese3rdStarData.FieldPositions[index].start,
                Gliese3rdStarData.FieldPositions[index].end);
        }

        private static string ReadRaw(string lineEntry, int index, int end)
        {
            end += 1;
            var result = lineEntry.Substring(index - 1, end - index);
            return result;
        }
    }
}
