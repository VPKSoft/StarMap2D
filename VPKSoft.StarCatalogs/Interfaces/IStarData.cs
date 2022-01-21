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

namespace VPKSoft.StarCatalogs.Interfaces;

/// <summary>
/// An interface for the star data entry.
/// </summary>
public interface IStarData
{
    /// <summary>
    /// Gets or sets the right ascension of the star.
    /// </summary>
    /// <value>The right ascension of the star.</value>
    double RightAscension { get; set; }

    /// <summary>
    /// Gets or sets the declination of the star.
    /// </summary>
    /// <value>The declination of the star.</value>
    double Declination { get; set; }

    /// <summary>
    /// Gets or sets the magnitude of the star.
    /// </summary>
    /// <value>The magnitude of the star.</value>
    double Magnitude { get; set; }

    /// <summary>
    /// Gets or sets the raw star data of the catalog.
    /// </summary>
    /// <value>The raw star data of the catalog.</value>
    string? RawData { get; set; }

    /// <summary>
    /// A delegate to read the <see cref="IStarData.RawData"/> data.
    /// </summary>
    /// <param name="rawDataEntry">The raw data value which named data part to read.</param>
    /// <param name="dataName">Name of the data to read.</param>
    /// <returns>A string? containing the read data..</returns>
    public delegate string? GetStarDataDelegate(string? rawDataEntry, string dataName);

    /// <summary>
    /// Gets or sets the get a delegate which returns <see cref="RawData"/> portions indexed by their header names.
    /// </summary>
    /// <value>The get star data.</value>
    public GetStarDataDelegate? GetStarData { get; set; }
}