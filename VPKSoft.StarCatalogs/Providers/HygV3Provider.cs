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
using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers
{
    /// <summary>
    /// A data provider of the HYG v.3.0 bright star catalog data.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    public class HygV3Provider: IStarDataProvider<HygV3StartData>
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<HygV3StartData> StarData { get; } = new();

        /// <summary>
        /// The field names of the star data of this provider.
        /// </summary>
        public static readonly string[] FieldNames =
        {
            "id",
            "hip",
            "hd",
            "hr",
            "gl",
            "bf",
            "proper",
            "ra",
            "dec",
            "dist",
            "pmra",
            "pmdec",
            "rv",
            "mag",
            "absmag",
            "spect",
            "ci",
            "x",
            "y",
            "z",
            "vx",
            "vy",
            "vz",
            "rarad",
            "decrad",
            "pmrarad",
            "pmdecrad",
            "bayer",
            "flam",
            "con",
            "comp",
            "comp_primary",
            "base",
            "lum",
            "var",
            "var_min",
            "var_max",
        };

        /// <inheritdoc cref="IStarDataProvider{T}.LoadData(string[])"/>
        public void LoadData(string[] lines)
        {
            for (int i = 2; i < lines.Length; i++)
            {
                RawDataEntries.Add(lines[i]);
            }

            foreach (var rawDataEntry in RawDataEntries)
            {
                StarData.Add(new HygV3StartData
                {
                    Declination = double.Parse(GetDataRaw(rawDataEntry, "dec"), CultureInfo.InvariantCulture),
                    RightAscension = double.Parse(GetDataRaw(rawDataEntry, "ra"), CultureInfo.InvariantCulture),
                    Magnitude = double.Parse(GetDataRaw(rawDataEntry, "mag"), CultureInfo.InvariantCulture),
                });
            }
        }

        /// <inheritdoc cref="IStarDataProvider{T}.LoadData(string)"/>
        public void LoadData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            LoadData(lines);
        }

        private List<string> FieldNameList { get; } = new();

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
                return rawDataEntry.Split(',')[dataIndex];
            }

            return string.Empty;
        }

        /// <inheritdoc cref="IStarDataProvider{T}.RawDataEntries"/>
        public List<string> RawDataEntries { get; } = new();
    }
}
