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

namespace StarMap2D.Calculations.Constellations.StaticData
{
    /// <summary>
    /// Provides static orbital elements for centaurs.
    /// </summary>
    public class Centaurs
    {
        /// <summary>
        /// Gets the orbital elements of the centaur Chiron.
        /// </summary>
        /// <returns>The orbital elements of the centaur Chiron.</returns>
        public static AASEllipticalObjectElements ChironOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Nov-09 15:07:45
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=chiron
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.3766452224400019,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 13.70695392054987,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 6.924915441061916,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 339.6211704482337,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 209.2887997936708,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2468621.073694782242,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }
    }
}
