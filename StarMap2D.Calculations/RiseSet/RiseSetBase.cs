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

namespace StarMap2D.Calculations.RiseSet;

/// <summary>
/// A base class for rise, set and transit time calculations.
/// </summary>
public abstract class RiseSetBase : LatLonDateCalculation
{
    private readonly ObjectsWithPositions @object = ObjectsWithPositions.Sun;

    /// <summary>
    /// Gets the object which rise and set to calculate.
    /// </summary>
    /// <value>The object.</value>
    public ObjectsWithPositions Object
    {
        get => @object;

        init
        {
            @object = value;
            if (!SuspendCalculation)
            {
                Calculate();
            }
        }
    }

    /// <summary>
    /// Gets the rise, set and transit times for the calculation period.
    /// </summary>
    /// <value>The rise, set and transit times.</value>
    public List<KeyValuePair<AASRiseTransitSetDetails2.Type, DateTime>> RiseSetTransitTimes { get; } = new();

    private static T? NullIfDefault<T>(T value) where T : struct
    {
        if (Equals(value, default(T)))
        {
            return null;
        }

        return value;
    }

    /// <summary>
    /// Gets the first set time in local time.
    /// </summary>
    /// <value>The first set time.</value>
    /// <remarks>Set is defined when the apparent top edge of the object is exactly on the horizon and the altitude of the object is decreasing.</remarks>
    public DateTime? Set =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.Set).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first rise time in local time.
    /// </summary>
    /// <value>The first rise time.</value>
    /// <remarks>Civil Dusk is defined when the geometric center of the Sun is 6 degrees below the horizon and the altitude of the Sun is decreasing (i.e. in the local evening time after the Sun has set).</remarks>
    public DateTime? Rise =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.Rise).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first civil dusk time in local time.
    /// </summary>
    /// <value>The first civil dusk time.</value>
    /// <remarks>Civil Dusk is defined when the geometric center of the Sun is 6 degrees below the horizon and the altitude of the Sun is decreasing (i.e. in the local evening time after the Sun has set).</remarks>
    public DateTime? CivilDusk =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.StartCivilTwilight).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first nautical dusk time in local time.
    /// </summary>
    /// <value>The first nautical dusk time.</value>
    /// <remarks>Nautical Dusk is defined when the geometric center of the Sun is 12 degrees below the horizon and the altitude of the Sun is decreasing (i.e. in the local evening time after the Sun has set).</remarks>
    public DateTime? NauticalDusk =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.StartNauticalTwilight).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first astronomical dusk time in local time.
    /// </summary>
    /// <value>The first astronomical dusk time.</value>
    /// <remarks>Astronomical Dusk is defined when the geometric center of the Sun is 18 degrees below the horizon and the altitude of the Sun is decreasing (i.e. in the local evening time after the Sun has set).</remarks>
    public DateTime? AstronomicalDusk =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.StartAstronomicalTwilight).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first civil dawn time in local time.
    /// </summary>
    /// <value>The first civil dawn time.</value>
    /// <remarks>Civil Dawn is defined when the geometric center of the Sun is 6 degrees below the horizon and the altitude of the Sun is increasing (i.e. in the local morning time before the Sun has risen).</remarks>
    public DateTime? CivilDawn =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.EndCivilTwilight).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first nautical dawn time in local time.
    /// </summary>
    /// <value>The first nautical dawn time.</value>
    /// <remarks>Nautical Dawn is defined when the geometric center of the Sun is 12 degrees below the horizon and the altitude of the Sun is increasing (i.e. in the local morning time before the Sun has risen).</remarks>
    public DateTime? NauticalDawn =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.EndNauticalTwilight).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the first astronomical dawn time in local time.
    /// </summary>
    /// <value>The first astronomical dawn time.</value>
    /// <remarks>Astronomical Dawn is defined when the geometric center of the Sun is 18 degrees below the horizon and the altitude of the Sun is increasing (i.e. in the local morning time before the Sun has risen).</remarks>
    public DateTime? AstronomicalDawn =>
        NullIfDefault(RiseSetTransitTimes.Where(f => f.Key == AASRiseTransitSetDetails2.Type.EndAstronomicalTwilight).OrderBy(f => f.Value)
            .FirstOrDefault().Value);

    /// <summary>
    /// Gets the <see cref="TimeSpan"/> between the <see cref="Rise"/> and <see cref="Set"/> times.
    /// </summary>
    /// <value>The rise set span.</value>
    public TimeSpan? RiseSetSpan
    {
        get
        {
            if (Rise == null || Set == null)
            {
                return null;
            }

            return Rise > Set ? Rise - Set : Set - Rise;
        }
    }

    /// <summary>
    /// Converts the <see cref="ObjectsWithPositions"/> enumeration value into AASharp <see cref="AASRiseTransitSet2.Objects"/> enumeration value.
    /// </summary>
    /// <param name="objectsWithPositions">The value to convert.</param>
    /// <returns>The converted value.</returns>
    /// <exception cref="NotImplementedException">The conversion failed.</exception>
    // ReSharper disable once InconsistentNaming, The library name is AASharp
    public static AASRiseTransitSet2.Objects ToAASharp(ObjectsWithPositions objectsWithPositions)
    {
        return objectsWithPositions switch
        {
            ObjectsWithPositions.Sun => AASRiseTransitSet2.Objects.SUN,
            ObjectsWithPositions.Moon => AASRiseTransitSet2.Objects.MOON,
            ObjectsWithPositions.Mercury => AASRiseTransitSet2.Objects.MERCURY,
            ObjectsWithPositions.Venus => AASRiseTransitSet2.Objects.VENUS,
            ObjectsWithPositions.Mars => AASRiseTransitSet2.Objects.MARS,
            ObjectsWithPositions.Jupiter => AASRiseTransitSet2.Objects.JUPITER,
            ObjectsWithPositions.Saturn => AASRiseTransitSet2.Objects.SATURN,
            ObjectsWithPositions.Uranus => AASRiseTransitSet2.Objects.URANUS,
            ObjectsWithPositions.Neptune => AASRiseTransitSet2.Objects.NEPTUNE,
            ObjectsWithPositions.Pluto => AASRiseTransitSet2.Objects.PLUTO,
            _ => throw new NotImplementedException(nameof(AASRiseTransitSet2.Objects)),
        };
    }

    /// <summary>
    /// Converts the AASharp <see cref="AASRiseTransitSet2.Objects" /> enumeration value into <see cref="ObjectsWithPositions" /> enumeration value.
    /// </summary>
    /// <param name="objects">The value to convert.</param>
    /// <returns>The converted value.</returns>
    /// <exception cref="NotImplementedException">The conversion failed.</exception>
    // ReSharper disable once InconsistentNaming, The library name is AASharp
    public static ObjectsWithPositions FromAASharp(AASRiseTransitSet2.Objects objects)
    {
        return objects switch
        {
            AASRiseTransitSet2.Objects.SUN => ObjectsWithPositions.Sun,
            AASRiseTransitSet2.Objects.MOON => ObjectsWithPositions.Moon,
            AASRiseTransitSet2.Objects.MERCURY => ObjectsWithPositions.Mercury,
            AASRiseTransitSet2.Objects.VENUS => ObjectsWithPositions.Venus,
            AASRiseTransitSet2.Objects.MARS => ObjectsWithPositions.Mars,
            AASRiseTransitSet2.Objects.JUPITER => ObjectsWithPositions.Jupiter,
            AASRiseTransitSet2.Objects.SATURN => ObjectsWithPositions.Saturn,
            AASRiseTransitSet2.Objects.URANUS => ObjectsWithPositions.Uranus,
            AASRiseTransitSet2.Objects.NEPTUNE => ObjectsWithPositions.Neptune,
            AASRiseTransitSet2.Objects.PLUTO => ObjectsWithPositions.Pluto,
            _ => throw new NotImplementedException(nameof(ObjectsWithPositions)),
        };
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RiseSetBase"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    protected RiseSetBase(double latitude, double longitude) : base(latitude, longitude)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RiseSetBase"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    /// <param name="starTimeLocal">The star time in local time.</param>
    /// <param name="endTimeLocal">The end time in local time.</param>
    protected RiseSetBase(double latitude, double longitude, DateTime starTimeLocal, DateTime endTimeLocal) : base(latitude, longitude, starTimeLocal, endTimeLocal)
    {
    }
}