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

namespace StarMap2D.Calculations.RiseSet;

/// <summary>
/// A class to calculate rise, transit and set times for the planets, pluto, sun and moon.
/// Implements the <see cref="StarMap2D.Calculations.RiseSet.RiseSetBase" />
/// </summary>
/// <seealso cref="StarMap2D.Calculations.RiseSet.RiseSetBase" />
public class RiseSetPlanetsSunMoon : RiseSetBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RiseSetPlanetsSunMoon"/> class.
    /// </summary>
    /// <param name="object">The object which rise, transit and set to calculate.</param>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    public RiseSetPlanetsSunMoon(ObjectsWithPositions @object, double latitude, double longitude) : base(latitude, longitude)
    {
        _ = ToAASharp(@object);
        Object = @object;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RiseSetPlanetsSunMoon"/> class.
    /// </summary>
    /// <param name="object">The object which rise, transit and set to calculate.</param>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    /// <param name="starTimeLocal">The star time in local time.</param>
    /// <param name="endTimeLocal">The end time in local time.</param>
    public RiseSetPlanetsSunMoon(ObjectsWithPositions @object, double latitude, double longitude, DateTime starTimeLocal, DateTime endTimeLocal) : base(latitude, longitude, starTimeLocal, endTimeLocal)
    {
        _ = ToAASharp(@object);
        Object = @object;
    }

    /// <summary>
    /// Calculates the rise, set and transform times.
    /// </summary>
    public override void Calculate()
    {
        if (SuspendCalculation)
        {
            return;
        }

        var starJd = StartTimeUtc.ToUniversalTime().ToAASDate().GetJD();
        var endJd = EndTimeUtc.ToUniversalTime().ToAASDate().GetJD();

        double h0;

        if (Object == ObjectsWithPositions.Moon)
        {
            h0 = Constants.RiseSet.MoonH0;
        }
        else if (Object == ObjectsWithPositions.Sun)
        {
            h0 = Constants.RiseSet.SunH0;
        }
        else
        {
            h0 = Constants.RiseSet.StarsPlanetsH0;
        }

        var results = AASRiseTransitSet2.Calculate(starJd, endJd, ToAASharp(Object), -Longitude,
            Latitude, h0, bHighPrecision: Globals.HighPrecisionCalculations);

        var resultArray = results.ToArray();

        var resultPairs = resultArray.Select(f =>
            new KeyValuePair<AASRiseTransitSetDetails2.Type, DateTime>(f.type,
                new AASDate(f.JD, true).ToDateTime().ToLocalTime())).ToList();

        RiseSetTransitTimes.Clear();
        RiseSetTransitTimes.AddRange(resultPairs);
    }
}