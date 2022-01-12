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
    /// Provides static orbital elements for main-belt asteroids.
    /// </summary>
    public class MainBeltAsteroids
    {
        /// <summary>
        /// Gets the orbital elements of the main-belt asteroid Pallas.
        /// </summary>
        /// <returns>The orbital elements of the main-belt asteroid Pallas.</returns>
        public static AASEllipticalObjectElements PallasOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Nov-10 04:32:18
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=1
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.2299929743044128,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 2.771106905653514,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 34.92530443013783,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 310.6972479100214,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 172.9165730682058,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2460010.122235846004,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the main-belt asteroid Juno.
        /// </summary>
        /// <returns>The orbital elements of the main-belt asteroid Juno.</returns>
        public static AASEllipticalObjectElements JunoOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Nov-10 04:32:18
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=1
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.2568870154103846,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 2.668791059736416,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 12.99185572265956,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 247.9417261893294,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 169.8477991708865,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2460037.107263453041,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }
        
        /// <summary>
        /// Gets the orbital elements of the main-belt asteroid Vesta.
        /// </summary>
        /// <returns>The orbital elements of the main-belt asteroid Vesta.</returns>
        public static AASEllipticalObjectElements VestaOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Apr-13 11:15:57
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=1
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.08823417531213737,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 2.361266458114362,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 7.141717168552266,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 151.0909385501822,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 103.8039247181175,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2459574.614128453124,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }
    }
}
