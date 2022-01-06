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

namespace StarMap2D.Calculations.CatalogProvider.Interfaces
{
    /// <summary>
    /// An interface to provide star data.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStarDataProvider<T> where T: IStarData
    {
        /// <summary>
        /// Gets the star data.
        /// </summary>
        /// <value>The star data.</value>
        List<T> StarData { get; }

        /// <summary>
        /// Loads the star data.
        /// </summary>
        /// <param name="fileName">Name of the file to load the star data from.</param>
        void LoadData(string fileName);

        /// <summary>
        /// Gets the raw data of the star based by the data field name.
        /// </summary>
        /// <param name="rawDataEntry">The raw data entry.</param>
        /// <param name="dataName">Name of the data.</param>
        /// <returns>System.String.</returns>
        string GetDataRaw(string rawDataEntry, string dataName);

        /// <summary>
        /// Gets the raw data entries of the star data.
        /// </summary>
        /// <value>The raw data entries of the star data.</value>
        List<string> RawDataEntries { get; } 
    }
}
