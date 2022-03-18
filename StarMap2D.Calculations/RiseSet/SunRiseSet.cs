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
/// A class to calculate sun rise, set and transit times.
/// Implements the <see cref="StarMap2D.Calculations.RiseSet.RiseSetBase" />
/// </summary>
/// <seealso cref="StarMap2D.Calculations.RiseSet.RiseSetBase" />
public class SunRiseSet : RiseSetBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SunRiseSet"/> class.
    /// </summary>
    public SunRiseSet(double latitude, double longitude) : base(latitude, longitude)
    {
        Object = ObjectsWithPositions.Sun;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SunRiseSet"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    /// <param name="starTimeUtc">The star time in local time.</param>
    /// <param name="endTimeUtc">The end time in local time.</param>
    public SunRiseSet(double latitude, double longitude, DateTime starTimeUtc, DateTime endTimeUtc) : base(
        latitude, longitude, starTimeUtc, endTimeUtc)
    {
        Object = ObjectsWithPositions.Sun;
    }

    /// <summary>
    /// Calculates the rise, set and transform times.
    /// </summary>
    public override void CalculateRiseSetTransform()
    {
        if (SuspendCalculation)
        {
            return;
        }

        var starJd = StartTimeUtc.ToUniversalTime().ToAASDate().GetJD();
        var endJd = EndTimeUtc.ToUniversalTime().ToAASDate().GetJD();
        var results = AASRiseTransitSet2.Calculate(starJd, endJd, ToAASharp(Object), -Longitude,
            Latitude, Constants.RiseSet.SunH0, bHighPrecision: Globals.HighPrecisionCalculations);

        var resultArray = results.ToArray();

        var resultPairs = resultArray.Select(f =>
            new KeyValuePair<AASRiseTransitSetDetails2.Type, DateTime>(f.type,
                new AASDate(f.JD, true).ToDateTime().ToLocalTime())).ToList();

        RiseSetTransitTimes.Clear();
        RiseSetTransitTimes.AddRange(resultPairs);
    }
}