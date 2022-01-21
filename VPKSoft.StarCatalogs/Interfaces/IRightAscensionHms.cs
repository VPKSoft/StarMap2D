namespace VPKSoft.StarCatalogs.Interfaces;

/// <summary>
/// An interface for star data with right ascension in hms format.
/// </summary>
public interface IRightAscensionHms
{
    /// <summary>
    /// Gets or sets the right ascension hours.
    /// </summary>
    /// <value>The right ascension hours.</value>
    public double RAh { get; set; }
    
    /// <summary>
    /// Gets or sets the right ascension minutes.
    /// </summary>
    /// <value>The right ascension minutes.</value>
    public double RAm { get; set; }
    
    /// <summary>
    /// Gets or sets the right ascension seconds.
    /// </summary>
    /// <value>The right ascension seconds.</value>
    public double RAs { get; set; }
}