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
/// A class for the PPM Star Catalog data.
/// Implements the <see cref="VPKSoft.StarCatalogs.Interfaces.IStarData" />
/// </summary>
/// <seealso cref="VPKSoft.StarCatalogs.Interfaces.IStarData" />
public class PpmStarData: StarData
{
    /// <summary>
    /// Gets or sets the Catalog number of star.
    /// </summary>
    /// <value>The Catalog number of star.</value>
    public float? CatalogStarNumber { get; set; }

    /// <summary>
    /// B1950 Right Ascension (radians)
    /// </summary>
    /// <value>The B1950 Right Ascension (radians).</value>
    public double Sra0 { get; set; }

    /// <summary>
    /// Gets or sets the B1950 Declination (radians).
    /// </summary>
    /// <value>The B1950 Declination (radians).</value>
    public double Sdec0 { get; set; }

    /// <summary>
    /// Gets or sets the type of the spectral.
    /// </summary>
    /// <value>The type of the spectral.</value>
    public string SpectralType { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the V Magnitude * 100.
    /// </summary>
    /// <value>The V Magnitude * 100.</value>
    public short Mag { get; set; }

    /// <summary>
    /// Gets or sets the R.A. proper motion (radians per year).
    /// </summary>
    /// <value>The R.A. proper motion (radians per year).</value>
    public float Xrpm { get; set; }

    /// <summary>
    /// Gets or sets the Dec. proper motion (radians per year).
    /// </summary>
    /// <value>The Dec. proper motion (radians per year).</value>
    public float Xdpm { get; set; }
}