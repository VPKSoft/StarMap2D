using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers
{
    /// <summary>
    /// A class for the PPM Star Catalog data.
    /// Implements the <see cref="VPKSoft.StarCatalogs.Interfaces.IStarData" />
    /// </summary>
    /// <seealso cref="VPKSoft.StarCatalogs.Interfaces.IStarData" />
    public class PpmStarData: IStarData
    {
        /// <inheritdoc cref="IStarData.RightAscension"/>
        public double RightAscension { get; set; }

        /// <inheritdoc cref="IStarData.Declination"/>
        public double Declination { get; set; }

        /// <inheritdoc cref="IStarData.Magnitude"/>
        public double Magnitude { get; set; }

        /// <inheritdoc cref="IStarData.RawData"/>
        public string? RawData { get; set; }

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
}
