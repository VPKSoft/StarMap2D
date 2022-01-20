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
    /// A data provider of the HYG v.3.0 bright star catalog data.
    /// Implements the <see cref="IStarDataProvider{T}" />
    /// </summary>
    /// <seealso cref="IStarDataProvider{T}" />
    public class HygV3Provider: IStarDataProvider<HygV3StartData>, ILoadDataLines
    {
        /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
        public List<HygV3StartData> StarData { get; } = new();

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
                StarData.Add(new HygV3StartData
                {
                    GetStarData = HygV3StartData.GetDataRaw,
                    RawData = rawDataEntry,
                });
            }
        }

        /// <summary>
        /// A static method to test the <see cref="HygV3Provider"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file containing the HYG v.3.0 bright star catalog data.</param>
        /// <returns><c>true</c> if data was successfully loaded, <c>false</c> otherwise.</returns>
        public static bool TestProvider(string fileName)
        {
            try
            {
                var provider = new HygV3Provider();
                provider.LoadData(fileName);

                // Enumerate one set of lazy nullable doubles.
                _ = provider.StarData.Where(f => f.HIP == null).ToList();

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
