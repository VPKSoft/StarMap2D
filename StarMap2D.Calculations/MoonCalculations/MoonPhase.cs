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
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.MoonCalculations;

/// <summary>
/// A class to calculate moon phase data.
/// Implements the <see cref="StarMap2D.Calculations.LatLonDateCalculation" />
/// </summary>
/// <seealso cref="StarMap2D.Calculations.LatLonDateCalculation" />
public class MoonPhase : LatLonDateCalculation
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MoonPhase"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    public MoonPhase(double latitude, double longitude) : base(latitude, longitude)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MoonPhase"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    /// <param name="starTimeLocal">The star time in local time.</param>
    /// <param name="endTimeLocal">The end time in local time.</param>
    public MoonPhase(double latitude, double longitude, DateTime starTimeLocal, DateTime endTimeLocal) : base(latitude, longitude, starTimeLocal, endTimeLocal)
    {
    }

    /// <summary>
    /// Performs the calculations required by this class if the <see cref="LatLonDateCalculation.SuspendCalculation" /> property is not defined.
    /// </summary>
    public override void Calculate()
    {
        if (SuspendCalculation)
        {
            return;
        }

        if (StartTimeLocal == default || EndTimeLocal == default)
        {
            return;
        }

        var now = StartTimeLocal.ToUniversalTime();

        var moonPosition = SolarSystemObjectPositions.GetDetails(
            ObjectsWithPositions.Moon, now.ToAASDate(),
            Globals.HighPrecisionCalculations,
            Latitude, Longitude);

        var sunPosition = SolarSystemObjectPositions.GetDetails(
            ObjectsWithPositions.Sun, now.ToAASDate(),
            Globals.HighPrecisionCalculations,
            Latitude, Longitude);

        var elongation = AASMoonIlluminatedFraction.GeocentricElongation(
            moonPosition.RightAscension, moonPosition.Declination,
            sunPosition.RightAscension, sunPosition.Declination);

        var phaseAngle = AASMoonIlluminatedFraction.PhaseAngle(elongation, 368410, 149971520);

        var pa = AASMoonIlluminatedFraction.PositionAngle(sunPosition.RightAscension, sunPosition.Declination,
            moonPosition.RightAscension, moonPosition.Declination);

        var phase = PhaseFromPositionAngle(pa, phaseAngle);

        MoonPhaseValue = MoonPhaseConstants.GetMoonPhase(phase);
        MoonDiscTiltAngle = CalculateDiscTiltAngle(now, Latitude, Longitude, moonPosition.RightAscension,
            moonPosition.Declination, pa);

        MoonIlluminatedPercentage = AASMoonIlluminatedFraction.IlluminatedFraction(phaseAngle);
    }

    /// <summary>
    /// Gets the moon phase value.
    /// </summary>
    /// <value>The moon phase value.</value>
    public MoonPhases MoonPhaseValue { get; internal set; }

    /// <summary>
    /// Gets the moon disc illuminated percentage.
    /// </summary>
    /// <value>The moon illuminated percentage.</value>
    public double MoonIlluminatedPercentage { get; internal set; }

    /// <summary>
    /// Calculates the moon phase from specified position and phase angles.
    /// </summary>
    /// <param name="positionAngle">The position angle.</param>
    /// <param name="phaseAngle">The phase angle.</param>
    /// <returns>A value for the moon phase within range from 0 to 1.</returns>
    public static double PhaseFromPositionAngle(double positionAngle, double phaseAngle)
    {
        var result = positionAngle < 180 ? phaseAngle + 180 : 180 - phaseAngle;
        return result / 360.0;
    }

    /// <summary>
    /// Calculates the moon disc tilt angle relative to the horizontal line of a circle increasing counter-clockwise.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <param name="latitude">The geographical latitude for the calculation.</param>
    /// <param name="longitude">The geographical longitude for the calculation.</param>
    /// <param name="rightAscension">The right ascension of the moon.</param>
    /// <param name="declination">The declination of the moon.</param>
    /// <param name="positionAngle">The position angle of the moon.</param>
    /// <returns>The moon disc tilt angle relative to the horizontal line of a circle.</returns>
    public static double CalculateDiscTiltAngle(DateTime dateTime, double latitude, double longitude, double rightAscension, double declination, double positionAngle)
    {
        var meanGreenwichSiderealTime = AASSidereal.MeanGreenwichSiderealTime(dateTime.ToAASDate().Julian);
        var meanLocalSiderealTime = meanGreenwichSiderealTime + AASCoordinateTransformation.DegreesToHours(longitude);
        var localHourAngleMoon = meanLocalSiderealTime - rightAscension;

        var q = AASParallactic.ParallacticAngle(localHourAngleMoon, latitude, declination);

        return positionAngle - q;
    }

    /// <summary>
    /// Gets the moon disc tilt angle relative to the horizontal line of a circle increasing counter-clockwise.
    /// </summary>
    /// <value>The moon disc tilt angle.</value>
    public double MoonDiscTiltAngle { get; internal set; }

}