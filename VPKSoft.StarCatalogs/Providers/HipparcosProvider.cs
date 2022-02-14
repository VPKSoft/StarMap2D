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

namespace VPKSoft.StarCatalogs.Providers;

/// <summary>
/// A data provider of Hipparcos ESA 1997 star catalog data.
/// Implements the <see cref="IStarDataProvider{T}" />
/// </summary>
/// <seealso cref="IStarDataProvider{T}" />
public class HipparcosProvider : IStarDataProvider<IStarData>, ILoadDataLines
{
    /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
    public List<IStarData> StarData { get; } = new();

    /// <inheritdoc cref="ILoadDataLines.LoadData(string[])"/>
    public void LoadData(string[] lines)
    {
        LoadData(lines, 1000);
    }

    /// <inheritdoc cref="ILoadDataLines.LoadData(string[],double)"/>
    public void LoadData(string[] lines, double magnitudeLimit)
    {
        var dataEntries = new List<string>();

        dataEntries.AddRange(lines);

        foreach (var rawDataEntry in dataEntries)
        {
            var data = new HipparcosStarData
            {
                RawData = rawDataEntry,
                GetStarData = HipparcosStarData.GetDataRaw,
            };

            if (data.Magnitude > magnitudeLimit)
            {
                continue;
            }

            // We don't need the sun (in this case).
            if (data.Name == "Sun")
            {
                continue;
            }

            StarData.Add(data);
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

            // Enumerate one set of lazy nullable doubles.
            _ = provider.StarData.Where(f => f.Declination != 0);

            // Enumerate second set of lazy nullable doubles.
            _ = provider.StarData.Where(f => f.RightAscension != 0);

            // Enumerate third set of lazy nullable doubles.
            _ = provider.StarData.Where(f => f.Magnitude < 0).ToList();

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

    /// <inheritdoc cref="IStarDataProvider{T}.LoadData(string,double)"/>
    public void LoadData(string fileName, double magnitudeLimit)
    {
        var lines = File.ReadAllLines(fileName);
        LoadData(lines, magnitudeLimit);
    }
}