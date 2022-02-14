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

using System.Text;
using StarMap2D.Calculations.Helpers.Math;
using VPKSoft.StarCatalogs.Interfaces;
using VPKSoft.StarCatalogs.Utilities;

namespace VPKSoft.StarCatalogs.Providers;

/// <summary>
/// Star data provider for the PPM Star Catalog.
/// Implements the <see cref="VPKSoft.StarCatalogs.Interfaces.IStarDataProvider{T}" />
/// </summary>
/// <seealso cref="VPKSoft.StarCatalogs.Interfaces.IStarDataProvider{T}" />
public class PpmProvider : IStarDataProvider<IStarData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PpmProvider"/> class.
    /// </summary>
    /// <param name="isPpmRa">if set to <c>true</c> if the data is in PPMra format.</param>
    public PpmProvider(bool isPpmRa)
    {
        IsPpmRa = isPpmRa;
    }

    /// <inheritdoc cref="IStarDataProvider{T}.StarData"/>
    public List<IStarData> StarData { get; } = new();

    /// <summary>
    /// Gets or sets a value indicating whether the file format is PPMRa or PPM.
    /// </summary>
    /// <remarks>See: http://tdc-www.harvard.edu/catalogs/ppm.entry.html</remarks>
    public bool IsPpmRa { get; set; }

    /// <summary>
    /// Subtract from star number to get sequence number.
    /// </summary>
    public int Star0 { get; set; }

    /// <summary>
    /// Gets or sets the First star number in file.
    /// </summary>
    /// <value>The First star number in file.</value>
    public int Star1 { get; set; }

    /// <summary>
    /// Gets or sets the Number of stars in file.
    /// </summary>
    /// <value>The Number of stars in file.</value>
    public int StarN { get; set; }

    /// <summary>
    /// 0 if no star ID numbers are present.
    /// 1 if star ID numbers are in catalog file.
    /// 2 if star ID numbers are region nnnn (GSC).
    /// 3 if star ID numbers are region nnnnn (Tycho).
    /// 4 if star ID numbers are integer*4 not real*4.
    /// &lt;0 No ID number, but object name of -STNUM characters at end of entry.
    /// </summary>
    public int Stnum { get; set; }

    /// <summary>
    /// True if proper motion is included.
    /// False if no proper motion is included.
    /// </summary>
    /// <value><c>true</c> if proper motion is included; <c>false</c> if no proper motion is included.</value>
    public bool Mprop { get; set; }

    /// <summary>
    /// Gets or sets the Number of magnitudes present.
    /// </summary>
    /// <value>The Number of magnitudes present.</value>
    public int Nmag { get; set; }

    /// <summary>
    /// Gets or sets the Number of bytes per star entry.
    /// </summary>
    /// <value>The Number of bytes per star entry.</value>
    public int Nbent { get; set; }

    /// <inheritdoc cref="IStarDataProvider{T}.LoadData"/>
    public void LoadData(string fileName)
    {
        LoadData(fileName, 1000);
    }

    /// <summary>
    /// Loads the star data.
    /// </summary>
    /// <param name="fileName">Name of the file to load the star data from.</param>
    /// <param name="magnitudeLimit">The magnitude limit of smallest magnitude to not to load into the memory.</param>
    public void LoadData(string fileName, double magnitudeLimit)
    {
        using var fileStream = new FileStream(fileName, FileMode.Open,
            FileAccess.Read, FileShare.ReadWrite);

        using var reader = new BinaryReaderEndian(fileStream);

        // Header, see: http://tdc-www.harvard.edu/software/catalogs/ppm.header.html

        Star0 = reader.ReadInt32BigEndian(); // Subtract from star number to get sequence number.
        Star1 = reader.ReadInt32BigEndian(); // First star number in file.
        StarN = reader.ReadInt32BigEndian(); // Number of stars in file.

        /*
         * 0 if no star i.d. numbers are present
         * 1 if star i.d. numbers are in catalog file
         * 2 if star i.d. numbers are  in file
        */
        Stnum = reader.ReadInt32BigEndian();

        Mprop = reader.ReadInt32BigEndian() != -1; // True if proper motion is included. False if no proper motion is included.

        Nmag = reader.ReadInt32BigEndian(); // Number of magnitudes present.
        Nbent = reader.ReadInt32BigEndian(); // Number of bytes per star entry.

        var count = 0;

        while (count++ < StarN)
        {
            var data = new PpmStarData
            {
                CatalogStarNumber = IsPpmRa ? reader.ReadSingleBigEndian() : null, // Catalog number of star.
                Sra0 = reader.ReadDoubleBigEndian(), // B1950 Right Ascension (radians).
                Sdec0 = reader.ReadDoubleBigEndian(), // B1950 Declination (radians).
                SpectralType = Encoding.ASCII.GetString(reader.ReadBytes(2)), // Spectral type (2 characters).
                Mag = reader.ReadInt16BigEndian(), // V Magnitude * 100.
                Xrpm = reader.ReadSingleBigEndian(), // R.A. proper motion (radians per year).
                Xdpm = reader.ReadSingleBigEndian(), // Dec. proper motion (radians per year).
            };

            if (data.Magnitude > magnitudeLimit)
            {
                continue;
            }

            data.Magnitude = data.Mag / 100.0;

            var ra = data.Sra0 * MathDegrees.RadiansDegrees;
            var dec = data.Sdec0 * MathDegrees.RadiansDegrees;
            if (double.IsInfinity(dec))
            {
                continue;
            }

            var result = Epochs.ChangeEpochB1950ToJ2000Degrees(ra, dec);

            data.RightAscension = result.RightAscension;
            data.Declination = result.Declination;

            StarData.Add(data);
        }
    }

    /// <summary>
    /// A static method to test the <see cref="PpmProvider"/> class.
    /// </summary>
    /// <param name="fileName">Name of the file containing the  PPM Star Catalog data.</param>
    /// <param name="isPpmRa">if set to <c>true</c> if the data is in PPMra format.</param>
    /// <returns><c>true</c> if data was successfully loaded, <c>false</c> otherwise.</returns>
    public static bool TestProvider(string fileName, bool isPpmRa)
    {
        try
        {
            var provider = new PpmProvider(isPpmRa);
            provider.LoadData(fileName);

            return true;
        }
        catch
        {
            return false;
        }
    }
}