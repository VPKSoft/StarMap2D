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

using StarMap2D.Calculations.Attributes;
using StarMap2D.Calculations.Classes;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Constellations.Enumerations;
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.StaticData;

/// <summary>
/// Extended version of the <see cref="PlanetData"/> class with non-static calculated data.
/// Implements the <see cref="StarMap2D.Calculations.StaticData.PlanetData" />
/// Implements the <see cref="StarMap2D.Calculations.Classes.IObjectDetails" />
/// </summary>
/// <seealso cref="StarMap2D.Calculations.StaticData.PlanetData" />
/// <seealso cref="StarMap2D.Calculations.Classes.IObjectDetails" />
public class PlanetDataExtended : PlanetData, IObjectDetails
{
    /// <inheritdoc cref="PlanetData.Name"/>
    [DataTableConfig(ColumnOrder = 0)]
    public override string Name { get; set; } = string.Empty;

    /// <inheritdoc cref="PlanetData.Mass"/>
    [DataTableConfig(ColumnOrder = 6, NumberFormat = "F0")]
    public override double Mass { get; set; }

    /// <inheritdoc cref="PlanetData.Diameter"/>
    [DataTableConfig(ColumnOrder = 7, NumberFormat = "F0")]
    public override double Diameter { get; set; }

    /// <inheritdoc cref="PlanetData.Density"/>
    [DataTableConfig(ColumnOrder = 8, NumberFormat = "F0")]
    public override double Density { get; set; }

    /// <inheritdoc cref="PlanetData.Gravity"/>
    [DataTableConfig(ColumnOrder = 9, NumberFormat = "F3")]
    public override double Gravity { get; set; }

    /// <inheritdoc cref="PlanetData.EscapeVelocity"/>
    [DataTableConfig(ColumnOrder = 10, NumberFormat = "F1")]
    public override double EscapeVelocity { get; set; }

    /// <inheritdoc cref="PlanetData.RotationPeriod"/>
    [DataTableConfig(ColumnOrder = 11, NumberFormat = "F2")]
    public override double RotationPeriod { get; set; }

    /// <inheritdoc cref="PlanetData.LengthOfDay"/>
    [DataTableConfig(ColumnOrder = 12, NumberFormat = "F3")]
    public override double LengthOfDay { get; set; }

    /// <inheritdoc cref="PlanetData.DistanceFromSun"/>
    [DataTableConfig(ColumnOrder = 13, NumberFormat = "F2")]
    public override double DistanceFromSun { get; set; }

    /// <inheritdoc cref="PlanetData.Perihelion"/>
    [DataTableConfig(ColumnOrder = 14, NumberFormat = "F3")]
    public override double Perihelion { get; set; }

    /// <inheritdoc cref="PlanetData.Aphelion"/>
    [DataTableConfig(ColumnOrder = 15, NumberFormat = "F3")]
    public override double Aphelion { get; set; }

    /// <inheritdoc cref="PlanetData.OrbitalPeriod"/>
    [DataTableConfig(ColumnOrder = 16, NumberFormat = "F3")]
    public override double? OrbitalPeriod { get; set; }

    /// <inheritdoc cref="PlanetData.OrbitalVelocity"/>
    [DataTableConfig(ColumnOrder = 17, NumberFormat = "F1")]
    public override double? OrbitalVelocity { get; set; }

    /// <inheritdoc cref="PlanetData.OrbitalInclination"/>
    [DataTableConfig(ColumnOrder = 18, NumberFormat = "F1")]
    public override double? OrbitalInclination { get; set; }

    /// <inheritdoc cref="PlanetData.OrbitalEccentricity"/>
    [DataTableConfig(ColumnOrder = 19, NumberFormat = "F4")]
    public override double? OrbitalEccentricity { get; set; }

    /// <inheritdoc cref="PlanetData.ObliquityToOrbit"/>
    [DataTableConfig(ColumnOrder = 20, NumberFormat = "F3")]
    public override double? ObliquityToOrbit { get; set; }

    /// <inheritdoc cref="PlanetData.MeanTemperature"/>
    [DataTableConfig(ColumnOrder = 21, NumberFormat = "F1")]
    public override double? MeanTemperature { get; set; }

    /// <inheritdoc cref="PlanetData.SurfacePressure"/>
    [DataTableConfig(ColumnOrder = 22, NumberFormat = "F2")]
    public override double? SurfacePressure { get; set; }

    /// <inheritdoc cref="PlanetData.NumberOfMoons"/>
    [DataTableConfig(ColumnOrder = 23, NumberFormat = "F0")]
    public override int? NumberOfMoons { get; set; }

    /// <inheritdoc cref="PlanetData.RingSystem"/>
    [DataTableConfig(ColumnOrder = 24)]
    public override bool RingSystem { get; set; }

    /// <inheritdoc cref="PlanetData.GlobalMagneticField"/>
    [DataTableConfig(ColumnOrder = 25)]
    public override bool? GlobalMagneticField { get; set; }

    /// <inheritdoc cref="PlanetData.DataUrl"/>
    [DataTableConfig(ColumnOrder = 30)]
    public override string? DataUrl { get; set; }

    /// <inheritdoc cref="IObjectDetails.ObjectName"/>
    public string? ObjectName { get; set; }

    /// <inheritdoc cref="IObjectDetails.RightAscension"/>
    [DataTableConfig(ColumnOrder = 1, NumberFormat = "F10")]
    public double RightAscension { get; set; }

    /// <inheritdoc cref="IObjectDetails.Declination"/>
    [DataTableConfig(ColumnOrder = 2, NumberFormat = "F10")]
    public double Declination { get; set; }

    /// <inheritdoc cref="IObjectDetails.AboveHorizon"/>
    [DataTableConfig(ColumnOrder = 5)]
    public bool AboveHorizon { get; set; }

    /// <inheritdoc cref="IObjectDetails.HorizontalDegreesX"/>
    [DataTableConfig(ColumnOrder = 4, NumberFormat = "F10")]
    public double HorizontalDegreesX { get; set; }

    /// <inheritdoc cref="IObjectDetails.HorizontalDegreesY"/>
    [DataTableConfig(ColumnOrder = 3, NumberFormat = "F10")]
    public double HorizontalDegreesY { get; set; }

    private double latitude;

    /// <summary>
    /// Gets or sets the latitude of the object.
    /// </summary>
    /// <value>The object latitude.</value>
    [DataTableConfig(ColumnOrder = 26, NumberFormat = "F10")]
    public double Latitude
    {
        get => latitude;

        set
        {
            if (Math.Abs(latitude - value) > Globals.FloatingPointTolerance)
            {
                latitude = value;
                RecalculateDynamicData();
            }
        }
    }

    private double longitude;

    /// <summary>
    /// Gets or sets the longitude of the object.
    /// </summary>
    /// <value>The object longitude.</value>
    [DataTableConfig(ColumnOrder = 27, NumberFormat = "F10")]
    public double Longitude
    {
        get => longitude;

        set
        {
            if (Math.Abs(value - longitude) > Globals.FloatingPointTolerance)
            {
                longitude = value;
                RecalculateDynamicData();
            }
        }

    }

    private DateTime detailDateTime = DateTime.UtcNow;

    /// <summary>
    /// Recalculates the dynamic data.
    /// </summary>
    public void RecalculateDynamicData()
    {
        var details = SolarSystemObjectPositions.GetDetails(ObjectType, detailDateTime.ToAASDate(),
            Globals.HighPrecisionCalculations, Latitude, Longitude);

        (ObjectName, RightAscension, Declination, AboveHorizon, HorizontalDegreesX, HorizontalDegreesY) =
            details;
    }

    /// <inheritdoc cref="IObjectDetails.DetailDateTime"/>
    [DataTableConfig(ColumnOrder = 29)]
    public DateTime DetailDateTime
    {
        get => detailDateTime;

        set
        {
            if (detailDateTime.ToUniversalTime() != value)
            {
                detailDateTime = value.ToUniversalTime();
                RecalculateDynamicData();
            }
        }
    }

    /// <summary>
    /// Gets the constellation of the object.
    /// </summary>
    /// <value>The constellation of the object.</value>
    [DataTableConfig(ColumnOrder = 30)]
    public ConstellationValue? Constellation => PointInConstellation.GetConstellationForPoint(RightAscension, Declination);
}