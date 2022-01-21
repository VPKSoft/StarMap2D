namespace VPKSoft.StarCatalogs.Interfaces;

/// <summary>
/// An interface for star data with declination in dms format.
/// </summary>
public interface IDeclinationDms
{    
    /// <summary>
    /// Gets or sets the declination degrees.
    /// </summary>
    /// <value>The declination degrees.</value>
    public double DeD { get; set; }

    /// <summary>
    /// Gets or sets the declination minutes.
    /// </summary>
    /// <value>The declination minutes.</value>
    public double Dem { get; set; }

    /// <summary>
    /// Gets or sets the declination seconds.
    /// </summary>
    /// <value>The declination seconds.</value>
    public double Des { get; set; }
}