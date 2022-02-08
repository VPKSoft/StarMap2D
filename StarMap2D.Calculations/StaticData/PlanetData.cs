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

using StarMap2D.Calculations.Enumerations;

namespace StarMap2D.Calculations.StaticData;

// Derived from the NASA Planetary Fact Sheet - Metric:
// https://nssdc.gsfc.nasa.gov/planetary/factsheet/
// Dwarf planets:
// https://ssd.jpl.nasa.gov/planets/phys_par.html
// Sun:
// https://en.wikipedia.org/wiki/Sun
// https://nssdc.gsfc.nasa.gov/planetary/factsheet/sunfact.html
/// <summary>
/// A class for static planet data.
/// </summary>
public class PlanetData
{
    /// <summary>
    /// Gets or sets the name of the planet.
    /// </summary>
    /// <value>The name of the planet.</value>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the mass in kilograms.
    /// </summary>
    /// <value>The mass.</value>
    public double Mass { get; set; }

    /// <summary>
    /// Gets or sets the diameter in kilometers.
    /// </summary>
    /// <value>The diameter.</value>
    public double Diameter { get; set; }

    /// <summary>
    /// Gets or sets the density in kg/m³.
    /// </summary>
    /// <value>The density.</value>
    public double Density { get; set; }

    /// <summary>
    /// Gets or sets the gravity in m/s².
    /// </summary>
    /// <value>The gravity.</value>
    public double Gravity { get; set; }

    /// <summary>
    /// Gets or sets the escape velocity in km/s.
    /// </summary>
    /// <value>The escape velocity.</value>
    public double EscapeVelocity { get; set; }

    /// <summary>
    /// Gets or sets the rotation period in hours.
    /// </summary>
    /// <value>The rotation period.</value>
    public double RotationPeriod { get; set; }

    /// <summary>
    /// Gets or sets the length of day in hours.
    /// </summary>
    /// <value>The length of day.</value>
    public double LengthOfDay { get; set; }

    /// <summary>
    /// Gets or sets the distance from sun in 10⁶ kilometers.
    /// </summary>
    /// <value>The distance from sun.</value>
    public double DistanceFromSun { get; set; }

    /// <summary>
    /// Gets or sets the perihelion in 10⁶ kilometers.
    /// </summary>
    /// <value>The perihelion.</value>
    public double Perihelion { get; set; }

    /// <summary>
    /// Gets or sets the aphelion in 10⁶ kilometers.
    /// </summary>
    /// <value>The aphelion.</value>
    public double Aphelion { get; set; }

    /// <summary>
    /// Gets or sets the orbital period in days.
    /// </summary>
    /// <value>The orbital period.</value>
    public double? OrbitalPeriod { get; set; }

    /// <summary>
    /// Gets or sets the orbital velocity in km/s.
    /// </summary>
    /// <value>The orbital velocity.</value>
    public double? OrbitalVelocity { get; set; }

    /// <summary>
    /// Gets or sets the orbital inclination in degrees.
    /// </summary>
    /// <value>The orbital inclination.</value>
    public double? OrbitalInclination { get; set; }

    /// <summary>
    /// Gets or sets the orbital eccentricity.
    /// </summary>
    /// <value>The orbital eccentricity.</value>
    public double? OrbitalEccentricity { get; set; }

    /// <summary>
    /// Gets or sets the obliquity to orbit in degrees.
    /// </summary>
    /// <value>The obliquity to orbit.</value>
    public double? ObliquityToOrbit { get; set; }

    /// <summary>
    /// Gets or sets the mean temperature in °C.
    /// </summary>
    /// <value>The mean temperature.</value>
    public double? MeanTemperature { get; set; }

    /// <summary>
    /// Gets or sets the surface pressure in bars.
    /// </summary>
    /// <value>The surface pressure.</value>
    public double? SurfacePressure { get; set; }

    /// <summary>
    /// Gets or sets the number of moons.
    /// </summary>
    /// <value>The number of moons.</value>
    public int? NumberOfMoons { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether planet has a ring system.
    /// </summary>
    /// <value><c>true</c> if the planet has a ring system; otherwise, <c>false</c>.</value>
    public bool RingSystem { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the planet has a global magnetic field.
    /// </summary>
    /// <value><c>null</c> if unknown contains no value, <c>true</c> if the planet has a global magnetic field; otherwise, <c>false</c>.</value>
    public bool? GlobalMagneticField { get; set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    public ObjectsWithPositions ObjectType { get; set; }

    /// <summary>
    /// Gets or sets the data URL for the physical parameters.
    /// </summary>
    /// <value>The data URL.</value>
    public string? DataUrl { get; set; }

    /// <summary>
    /// The static planet data.
    /// </summary>
    public static PlanetData[] Data = {
        // LibreOffice concatenate used to generate this: =CONCATENATE("new PlanetData {Name=";CHAR(34);B1;CHAR(34);",Mass=";B2; ", Diameter = ";B3; ", Density = ";B4; ", Gravity = "; B5; ", EscapeVelocity = ";B6; ", RotationPeriod ="; B7; ", LengthOfDay = ";B8; ", DistanceFromSun = ";B9; ", Perihelion = "; B10; ", Aphelion = ";B11; ", OrbitalPeriod = ";B12; ", OrbitalVelocity = ";B13; ", OrbitalInclination = ";B14; ", OrbitalEccentricity = "; B15; ", ObliquityToOrbit = ";B16; ", MeanTemperature = ";B17; ", SurfacePressure = ";B18; ", NumberOfMoons = ";B19; ", RingSystem = "; B20; ", GlobalMagneticField = ";B21; "},")
        new()
        {
            Name = "Mercury", Mass = 0.330, Diameter = 4879, Density = 5429, Gravity = 3.7, EscapeVelocity = 4.3,
            RotationPeriod = 1407.6, LengthOfDay = 4222.6, DistanceFromSun = 57.9, Perihelion = 46.0,
            Aphelion = 69.8, OrbitalPeriod = 88.0, OrbitalVelocity = 47.4, OrbitalInclination = 7.0,
            OrbitalEccentricity = 0.206, ObliquityToOrbit = 0.034, MeanTemperature = 167, SurfacePressure = 0,
            NumberOfMoons = 0, RingSystem = false, GlobalMagneticField = true, ObjectType = ObjectsWithPositions.Mercury,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Venus", Mass = 4.87, Diameter = 12104, Density = 5243, Gravity = 8.9, EscapeVelocity = 10.4,
            RotationPeriod = -5832.5, LengthOfDay = 2802.0, DistanceFromSun = 108.2, Perihelion = 107.5,
            Aphelion = 108.9, OrbitalPeriod = 224.7, OrbitalVelocity = 35.0, OrbitalInclination = 3.4,
            OrbitalEccentricity = 0.007, ObliquityToOrbit = 177.4, MeanTemperature = 464, SurfacePressure = 92,
            NumberOfMoons = 0, RingSystem = false, GlobalMagneticField = false, ObjectType = ObjectsWithPositions.Venus,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Earth", Mass = 5.97, Diameter = 12756, Density = 5514, Gravity = 9.8, EscapeVelocity = 11.2,
            RotationPeriod = 23.9, LengthOfDay = 24.0, DistanceFromSun = 149.6, Perihelion = 147.1,
            Aphelion = 152.1, OrbitalPeriod = 365.2, OrbitalVelocity = 29.8, OrbitalInclination = 0.0,
            OrbitalEccentricity = 0.017, ObliquityToOrbit = 23.4, MeanTemperature = 15, SurfacePressure = 1,
            NumberOfMoons = 1, RingSystem = false, GlobalMagneticField = true, ObjectType = ObjectsWithPositions.Earth,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Moon", Mass = 0.073, Diameter = 3475, Density = 3340, Gravity = 1.6, EscapeVelocity = 2.4,
            RotationPeriod = 655.7, LengthOfDay = 708.7, DistanceFromSun = 0.384, Perihelion = 0.363,
            Aphelion = 0.406, OrbitalPeriod = 27.3, OrbitalVelocity = 1.0, OrbitalInclination = 5.1,
            OrbitalEccentricity = 0.055, ObliquityToOrbit = 6.7, MeanTemperature = -20, SurfacePressure = 0,
            NumberOfMoons = 0, RingSystem = false, GlobalMagneticField = false, ObjectType = ObjectsWithPositions.Moon,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Mars", Mass = 0.642, Diameter = 6792, Density = 3934, Gravity = 3.7, EscapeVelocity = 5.0,
            RotationPeriod = 24.6, LengthOfDay = 24.7, DistanceFromSun = 228.0, Perihelion = 206.7,
            Aphelion = 249.3, OrbitalPeriod = 687.0, OrbitalVelocity = 24.1, OrbitalInclination = 1.8,
            OrbitalEccentricity = 0.094, ObliquityToOrbit = 25.2, MeanTemperature = -65, SurfacePressure = 0.01,
            NumberOfMoons = 2, RingSystem = false, GlobalMagneticField = false, ObjectType = ObjectsWithPositions.Mars,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Jupiter", Mass = 1898, Diameter = 142984, Density = 1326, Gravity = 23.1,
            EscapeVelocity = 59.5, RotationPeriod = 9.9, LengthOfDay = 9.9, DistanceFromSun = 778.5,
            Perihelion = 740.6, Aphelion = 816.4, OrbitalPeriod = 4331, OrbitalVelocity = 13.1,
            OrbitalInclination = 1.3, OrbitalEccentricity = 0.049, ObliquityToOrbit = 3.1, MeanTemperature = -110,
            NumberOfMoons = 79, RingSystem = true, GlobalMagneticField = true, ObjectType = ObjectsWithPositions.Jupiter,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Saturn", Mass = 568, Diameter = 120536, Density = 687, Gravity = 9.0, EscapeVelocity = 35.5,
            RotationPeriod = 10.7, LengthOfDay = 10.7, DistanceFromSun = 1432.0, Perihelion = 1357.6,
            Aphelion = 1506.5, OrbitalPeriod = 10747, OrbitalVelocity = 9.7, OrbitalInclination = 2.5,
            OrbitalEccentricity = 0.052, ObliquityToOrbit = 26.7, MeanTemperature = -140, NumberOfMoons = 82,
            RingSystem = true, GlobalMagneticField = true, ObjectType = ObjectsWithPositions.Saturn,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Uranus", Mass = 86.8, Diameter = 51118, Density = 1270, Gravity = 8.7, EscapeVelocity = 21.3,
            RotationPeriod = -17.2, LengthOfDay = 17.2, DistanceFromSun = 2867.0, Perihelion = 2732.7,
            Aphelion = 3001.4, OrbitalPeriod = 30589, OrbitalVelocity = 6.8, OrbitalInclination = 0.8,
            OrbitalEccentricity = 0.047, ObliquityToOrbit = 97.8, MeanTemperature = -195, NumberOfMoons = 27,
            RingSystem = true, GlobalMagneticField = true, ObjectType = ObjectsWithPositions.Uranus,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Neptune", Mass = 102, Diameter = 49528, Density = 1638, Gravity = 11.0, EscapeVelocity = 23.5,
            RotationPeriod = 16.1, LengthOfDay = 16.1, DistanceFromSun = 4515.0, Perihelion = 4471.1,
            Aphelion = 4558.9, OrbitalPeriod = 598, OrbitalVelocity = 5.4, OrbitalInclination = 1.8,
            OrbitalEccentricity = 0.010, ObliquityToOrbit = 28.3, MeanTemperature = -200, NumberOfMoons = 14,
            RingSystem = true, GlobalMagneticField = true, ObjectType = ObjectsWithPositions.Neptune,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Pluto", Mass = 0.0130, Diameter = 2376, Density = 1850, Gravity = 0.7, EscapeVelocity = 1.3,
            RotationPeriod = -153.3, LengthOfDay = 153.3, DistanceFromSun = 5906.4, Perihelion = 4436.8,
            Aphelion = 7375.9, OrbitalPeriod = 9056, OrbitalVelocity = 4.7, OrbitalInclination = 17.2,
            OrbitalEccentricity = 0.244, ObliquityToOrbit = 122.5, MeanTemperature = -225,
            SurfacePressure = 0.00001, NumberOfMoons = 5, RingSystem = false, ObjectType = ObjectsWithPositions.Pluto,
            DataUrl = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/", 
        },
        new()
        {
            Name = "Sun", Mass = 1988500, Diameter = 695700, Density = 1408, Gravity = 274.0, EscapeVelocity = 617.6,
            RotationPeriod = 609.12, LengthOfDay = 609.12, DistanceFromSun = 0, Perihelion = 0,
            Aphelion = 0, MeanTemperature = 5505,
            SurfacePressure = 868000, RingSystem = false, ObjectType = ObjectsWithPositions.Sun,
            DataUrl = "https://en.wikipedia.org/wiki/Sun",
        },
        new()
        {
            Name = "Ceres", Mass = 938.416 / 1000000, Diameter = 469.7 * 2, Density = 2.162 * 1000, Gravity = 0.27, EscapeVelocity = 0.51, 
            RotationPeriod = 0.378 * 24, LengthOfDay = 0.378 * 24,
            OrbitalPeriod = 4.61 * 365.2425,
            ObjectType = ObjectsWithPositions.Ceres,
            DataUrl = "https://ssd.jpl.nasa.gov/planets/phys_par.html",
        },
        new()
        {
            Name = "Eris", Mass = 16600.0 / 1000000, Diameter = 1200 * 2, Density = 2.3 * 1000, Gravity = 0.77, EscapeVelocity = 1.36, 
            RotationPeriod = 1.079 * 24, LengthOfDay = 1.079 * 24,
            OrbitalPeriod = 557.56 * 365.2425,
            ObjectType = ObjectsWithPositions.Eris,
            DataUrl = "https://ssd.jpl.nasa.gov/planets/phys_par.html",
        },
        new()
        {
            Name = "Makemake", Mass = 3100.0 / 1000000, Diameter = 714 * 2, Density = 2.1 * 1000, Gravity = 0.40, EscapeVelocity = 0.76, 
            RotationPeriod = 0.937 * 24, LengthOfDay = 0.937 * 24,
            OrbitalPeriod = 307.54 * 365.2425,
            ObjectType = ObjectsWithPositions.Makemake,
            DataUrl = "https://ssd.jpl.nasa.gov/planets/phys_par.html",
        },
        new()
        {
            Name = "Haumea", Mass = 4006.0 / 1000000, Diameter = 717 * 2, Density = 2.6 * 1000, Gravity = 0.37, EscapeVelocity = 0.78, 
            RotationPeriod = 0.1631 * 24, LengthOfDay = 0.1631 * 24,
            OrbitalPeriod = 284.81 * 365.2425,
            ObjectType = ObjectsWithPositions.Haumea,
            DataUrl = "https://ssd.jpl.nasa.gov/planets/phys_par.html",
        }
    };
}