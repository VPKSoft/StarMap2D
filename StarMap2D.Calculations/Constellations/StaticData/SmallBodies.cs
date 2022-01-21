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

using AASharp;
using StarMap2D.Calculations.Enumerations;

namespace StarMap2D.Calculations.Constellations.StaticData;

/// <summary>
/// A class to provide orbital element information of the solar system small-body objects.
/// </summary>
public class SmallBodies
{
    /// <summary>
    /// Gets the <see cref="AASEllipticalObjectElements"/> with the specified <see cref="SolarSystemSmallBodies"/> value.
    /// </summary>
    /// <param name="body">The <see cref="SolarSystemSmallBodies"/> enumeration value.</param>
    /// <returns>An instance of the <see cref="AASEllipticalObjectElements"/> class containing the the orbital elements of the requested small-body object.</returns>
    public AASEllipticalObjectElements this[SolarSystemSmallBodies body]
    {
        get
        {
            return body switch
            {
                SolarSystemSmallBodies.Ceres => DwarfPlanetElements.CeresOrbitalElements(),
                SolarSystemSmallBodies.Orcus => DwarfPlanetElements.OrcusOrbitalElements(),
                SolarSystemSmallBodies.Haumea => DwarfPlanetElements.HaumeaOrbitalElements(),
                SolarSystemSmallBodies.Quaoar => DwarfPlanetElements.QuaoarOrbitalElements(),
                SolarSystemSmallBodies.Makemake => DwarfPlanetElements.MakemakeOrbitalElements(),
                SolarSystemSmallBodies.Gonggong => DwarfPlanetElements.GonggongOrbitalElements(),
                SolarSystemSmallBodies.Eris => DwarfPlanetElements.ErisOrbitalElements(),
                SolarSystemSmallBodies.Sedna => DwarfPlanetElements.SednaOrbitalElements(),
                SolarSystemSmallBodies.Juno => MainBeltAsteroids.JunoOrbitalElements(),
                SolarSystemSmallBodies.Vesta => MainBeltAsteroids.VestaOrbitalElements(),
                SolarSystemSmallBodies.Pallas => MainBeltAsteroids.PallasOrbitalElements(),
                SolarSystemSmallBodies.Chiron => Centaurs.ChironOrbitalElements(),
                SolarSystemSmallBodies.Pluto => new AASEllipticalObjectElements(),
                _ => new AASEllipticalObjectElements()
            };
        }
    }
}