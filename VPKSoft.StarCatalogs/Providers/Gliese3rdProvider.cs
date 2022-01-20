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
    /// Class Gliese3rdProvider.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    // ReSharper disable once IdentifierTypo
    // ReSharper disable once InconsistentNaming
    public class Gliese3rdProvider : IStarDataProvider<Gliese3rdStarData>, ILoadDataLines
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<Gliese3rdStarData> StarData { get; } = new();

        /// <inheritdoc cref="ILoadDataLines.LoadData(string[])"/>
        public void LoadData(string[] lines)
        {
            var dataEntries = new List<string>();

            for (int i = 2; i < lines.Length; i++)
            {
                dataEntries.Add(lines[i]);
            }

            foreach (var rawDataEntry in dataEntries)
            {
                var name = Interfaces.StarData.ToPrimitive<string>(Gliese3rdStarData.GetDataRaw(rawDataEntry, "Name"));

                // We don't need the sun (in this case).
                if (name?.Trim() == "Sun")
                {
                    continue;
                }

                var raHours = Interfaces.StarData.ToPrimitive<double?>(Gliese3rdStarData.GetDataRaw(rawDataEntry, "RAh")) ?? 0;
                var raMinutes = Interfaces.StarData.ToPrimitive<double?>(Gliese3rdStarData.GetDataRaw(rawDataEntry, "RAm")) ?? 0;
                var raSeconds = Interfaces.StarData.ToPrimitive<double?>(Gliese3rdStarData.GetDataRaw(rawDataEntry, "RAs")) ?? 0;
                var rightAscension = raHours + raMinutes / 60 + raSeconds / 3600;

                var deDegrees = double.Parse(Gliese3rdStarData.GetDataRaw(rawDataEntry, "DE-")?.Trim() + Gliese3rdStarData.GetDataRaw(rawDataEntry, "DEd")?.Trim(), CultureInfo.InvariantCulture);


                var deMinutes = Interfaces.StarData.ToPrimitive<double?>(Gliese3rdStarData.GetDataRaw(rawDataEntry, "DEm")) ?? 0;

                var declination = AASCoordinateTransformation.DMSToDegrees(deDegrees, deMinutes, 0);

                var magnitude = Interfaces.StarData.ToPrimitive<double?>(Gliese3rdStarData.GetDataRaw(rawDataEntry, "Vmag")) ?? 0;

                StarData.Add(new Gliese3rdStarData
                {
                    Name = name, Declination = declination, RightAscension = rightAscension, Magnitude = magnitude, RawData = rawDataEntry, 
                    GetStarData = Gliese3rdStarData.GetDataRaw,
                });
            }
        }

        /// <summary>
        /// A static method to test the <see cref="Gliese3rdProvider"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file containing the Gliese 3rd data.</param>
        /// <returns><c>true</c> if data was successfully loaded, <c>false</c> otherwise.</returns>
        public static bool TestProvider(string fileName)
        {
            try
            {
                var provider = new Gliese3rdProvider();
                provider.LoadData(fileName);
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
