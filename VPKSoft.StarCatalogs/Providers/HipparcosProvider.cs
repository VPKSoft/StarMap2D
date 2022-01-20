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
    /// A data provider of Hipparcos ESA 1997 star catalog data.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    public class HipparcosProvider : IStarDataProvider<HipparcosStarData>, ILoadDataLines
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<HipparcosStarData> StarData { get; } = new();

        /// <inheritdoc cref="ILoadDataLines.LoadData(string[])"/>
        public void LoadData(string[] lines)
        {
            var dataEntries = new List<string>();

            dataEntries.AddRange(lines);

            foreach (var rawDataEntry in dataEntries)
            {
                var name = HipparcosStarData.GetDataRaw(rawDataEntry, "Name");

                // We don't need the sun (in this case).
                if (name.Trim() == "Sun")
                {
                    continue;
                }

                var raData = HipparcosStarData.GetDataRaw(rawDataEntry, "RAhms").Split(' ');

                var raHours = double.Parse(raData[0], CultureInfo.InvariantCulture);
                var raMinutes = double.Parse(raData[1], CultureInfo.InvariantCulture);
                var raSeconds = double.Parse(raData[2], CultureInfo.InvariantCulture);
                var rightAscension = raHours + raMinutes / 60 + raSeconds / 3600;

                var deData = HipparcosStarData.GetDataRaw(rawDataEntry, "DEdms").Split(' ');

                var deDegrees = double.Parse(deData[0], CultureInfo.InvariantCulture);
                var deMinutes = double.Parse(deData[1], CultureInfo.InvariantCulture);
                var deSeconds = double.Parse(deData[2], CultureInfo.InvariantCulture);

                var declination = AASCoordinateTransformation.DMSToDegrees(deDegrees, deMinutes, deSeconds);

                var mag = HipparcosStarData.GetDataRaw(rawDataEntry, "Vmag").Trim();

                mag = string.IsNullOrWhiteSpace(mag) ? "0" : mag;

                var magnitude = double.Parse(mag, CultureInfo.InvariantCulture);

                StarData.Add(new HipparcosStarData
                {
                    Declination = declination, RightAscension = rightAscension, Magnitude = magnitude, RawData = rawDataEntry,
                    GetStarData = HipparcosStarData.GetDataRaw,
                });
            }
        }

        /// <summary>
        /// A static method to test the <see cref="HipparcosProvider"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file containing the Hipparcos data.</param>
        /// <returns><c>true</c> if data was successfully loaded, <c>false</c> otherwise.</returns>
        public static bool TestProvider(string fileName)
        {
            try
            {
                var provider = new HipparcosProvider();
                provider.LoadData(fileName);

                var count = provider.StarData.Count(f => f.HIP != null);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <inheritdoc cref="IStarDataProvider{T}.LoadData(string)"/>
        public void LoadData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            LoadData(lines);
        }
    }
}
