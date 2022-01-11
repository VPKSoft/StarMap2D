using AASharp;
using StarMap2D.Calculations.Enumerations;

namespace StarMap2D.Calculations.Constellations.StaticData
{
    /// <summary>
    /// Provides static orbital elements for dwarf planets.
    /// </summary>
    /// <remarks>Pluto is not included as there is a formula to calculate its position.</remarks>
    public class DwarfPlanetElements
    {
        /// <summary>
        /// Gets the orbital elements of the dwarf planet Ceres.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Ceres.</returns>
        public static AASEllipticalObjectElements CeresOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Apr-13 11:04:44
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=1
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.07582276595896797,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 2.766043062222408,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 10.59338616262872,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 73.63703979153577,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 80.26859547732911,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2459920.804393927769,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Orcus.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Orcus.</returns>
        public static AASEllipticalObjectElements OrcusOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Aug-25 18:16:22
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Orcus
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.2293187662064105,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 39.09771828840471,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 20.57910141624415,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 72.96730132393112,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 268.6646722294771,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2503419.781784388302,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Haumea.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Haumea.</returns>
        public static AASEllipticalObjectElements HaumeaOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Oct-08 05:09:41
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Haumea
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.1989259118299011,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 42.99174275360999,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 28.21247549329155,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 239.7142658841597,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 122.1260181381822,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2499960.282547090661,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Quaoar.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Quaoar.</returns>
        public static AASEllipticalObjectElements QuaoarOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Oct-08 04:34:48
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Quaoar
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.04136496390059789,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 43.54596239720973,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 7.991017167951827,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 152.9024722797061,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 189.0617700349773,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2477724.375047183858,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Makemake.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Makemake.</returns>
        public static AASEllipticalObjectElements MakemakeOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Oct-08 05:09:48
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Makemake
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.1653844023888644,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 45.28012069603869,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 29.00208051909517,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 295.2063755887006,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 79.47665085889463,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2407972.184906341856,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Gonggong.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Gonggong.</returns>
        public static AASEllipticalObjectElements GonggongOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Nov-10 02:22:56
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Gonggong
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.4979496579281204,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 67.42840417547148,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 30.60574134546534,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 207.523240463533,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 336.8596602030082,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2399112.958107959392,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Eris.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Eris.</returns>
        public static AASEllipticalObjectElements ErisOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Nov-10 01:28:03
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Eris
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.4325369238160404,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 68.067982347956,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 43.84483111192672,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 151.2967172284478,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 36.03492459560232,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2546498.396958965866,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the orbital elements of the dwarf planet Sedna.
        /// </summary>
        /// <returns>The orbital elements of the dwarf planet Sedna.</returns>
        public static AASEllipticalObjectElements SednaOrbitalElements()
        {
            // Data © Nasa / Jet Propulsion Laboratory / Small-Body Database
            // solution date: 2021-Nov-10 11:29:23
            // https://ssd.jpl.nasa.gov/tools/sbdb_lookup.html#/?sstr=Sedna
            var elements = new AASEllipticalObjectElements
            {
                // The eccentricity of the orbit. JPL(e): eccentricity
                e = 0.8503603897311801,

                // The semi major axis in astronomical units. JPL(a): semi-major axis
                a = 510.3561263112496,

                // The inclination of the plane of the orbit in degrees. JPL(i): inclination; angle with respect to x-y ecliptic plane
                i = 11.93112319620501,

                // The argument of the perihelion in degrees. JPL(peri): argument of the perihelion
                w = 311.0197866418557,

                // The longitude of the ascending node in degrees. JPL(node): longitude of the ascending node
                omega = 144.2114501747823,

                //  The Julian date of the time of passage in perihelion. JPL(tp): time of perihelion passage
                T = 2479157.744045111049,

                // The Julian day for which equatorial coordinates should be calculated for. JPL(Epoch xxx TDB), The data grid (Osculating Orbital Elements) header.
                JDEquinox = 2459600.5
            };

            return elements;
        }

        /// <summary>
        /// Gets the dwarf planet orbital elements to calculate its position.
        /// </summary>
        /// <param name="planets">A <see cref="DwarfPlanets"/> enumeration value to specify the planet to get.</param>
        /// <returns>An instance to a <see cref="AASEllipticalObjectElements"/> containing the orbital elements of the dwarf planet.</returns>
        /// <remarks>Pluto is not included as there is a formula to calculate its position.</remarks>
        public static AASEllipticalObjectElements GetDwarfPlanet(DwarfPlanets planets)
        {
            switch (planets)
            {
                case DwarfPlanets.Ceres:
                    return CeresOrbitalElements();

                case DwarfPlanets.Orcus:
                    return OrcusOrbitalElements();

                case DwarfPlanets.Haumea:
                    return HaumeaOrbitalElements();

                case DwarfPlanets.Quaoar:
                    return QuaoarOrbitalElements();

                case DwarfPlanets.Makemake:
                    return MakemakeOrbitalElements();

                case DwarfPlanets.Gonggong:
                    return GonggongOrbitalElements();

                case DwarfPlanets.Eris:
                    return ErisOrbitalElements();

                case DwarfPlanets.Sedna:
                    return SednaOrbitalElements();

                default:
                    return new AASEllipticalObjectElements();
            }
        }
    }
}
