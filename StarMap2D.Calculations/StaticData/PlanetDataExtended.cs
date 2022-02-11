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

using StarMap2D.Calculations.Classes;
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
public class PlanetDataExtended: PlanetData, IObjectDetails
{
    /// <inheritdoc cref="IObjectDetails.ObjectName"/>
    public string? ObjectName { get; set; }

    /// <inheritdoc cref="IObjectDetails.RightAscension"/>
    public double RightAscension { get; set; }

    /// <inheritdoc cref="IObjectDetails.Declination"/>
    public double Declination { get; set; }

    /// <inheritdoc cref="IObjectDetails.AboveHorizon"/>
    public bool AboveHorizon { get; set; }

    /// <inheritdoc cref="IObjectDetails.HorizontalDegreesX"/>
    public double HorizontalDegreesX { get; set; }

    /// <inheritdoc cref="IObjectDetails.HorizontalDegreesY"/>
    public double HorizontalDegreesY { get; set; }

    private double latitude { get; set; }

    /// <summary>
    /// Gets or sets the latitude of the object.
    /// </summary>
    /// <value>The object latitude.</value>
    public double Latitude
    {
        get => latitude;

        set
        {
            if (latitude != value)
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
    public double Longitude
    {
        get => longitude;

        set
        {
            if (value != longitude)
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
}