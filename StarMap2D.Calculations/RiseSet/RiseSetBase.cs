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
public abstract class RiseSetBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RiseSetBase"/> class
    /// with the <see cref="StartTimeUtc"/> set to start of the current day and the <see cref="EndTimeUtc"/> set to the start of the next day.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    protected RiseSetBase(double latitude, double longitude)
    {
        SuspendCalculation = true;
        StartTimeUtc = DateTime.Now;
        var offset = DateTimeOffset.Now.Offset.TotalHours;
        EndTimeUtc = StartTimeUtc.AddDays(1).AddHours(offset);

        Latitude = latitude;
        Longitude = longitude;
        SuspendCalculation = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RiseSetBase"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    /// <param name="starTimeLocal">The star time in local time.</param>
    /// <param name="endTimeLocal">The end time in local time.</param>
    protected RiseSetBase(double latitude, double longitude, DateTime starTimeLocal, DateTime endTimeLocal) : this(latitude, longitude)
    {
        SuspendCalculation = true;
        StartTimeLocal = starTimeLocal;
        EndTimeLocal = endTimeLocal;
        SuspendCalculation = false;
    }

    /// <summary>
    /// Adds the specified amount of days to the <see cref="StartTimeLocal"/> and <see cref="EndTimeLocal"/>.
    /// </summary>
    /// <param name="days">The number of days to add.</param>
    public void AddDays(double days)
    {
        var addValue = (int)days <= 0 ? 1 : (int)days;
        SuspendCalculation = true;
        StartTimeLocal = StartTimeLocal.AddDays(addValue);
        EndTimeLocal = StartTimeLocal.AddDays(addValue);
        SuspendCalculation = false;
    }

    private bool suspendCalculation;

    internal bool SuspendCalculation
    {
        get => suspendCalculation;

        set
        {
            if (suspendCalculation != value)
            {
                suspendCalculation = value;

                if (!suspendCalculation)
                {
                    CalculateRiseSetTransform();
                }
            }
        }
    }

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
            if (!suspendCalculation)
            {
                CalculateRiseSetTransform();
            }
        }
    }

    private DateTime startTimeUtc;
    private DateTime startTimeLocal;

    /// <summary>
    /// Gets or sets the start time in universal coordinated time (UTC).
    /// </summary>
    /// <value>The start time local in universal coordinated time (UTC) time.</value>
    /// <remarks>When the value is set, the time value (hour, minutes and seconds) is automatically removed and a local time value is converted into UTC at offset <c>0</c>.</remarks>
    public DateTime StartTimeUtc
    {
        get => startTimeUtc;

        set
        {
            var offset = DateTimeOffset.Now.Offset.TotalHours;
            var adjustedDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

            startTimeLocal = value;

            if (startTimeUtc != adjustedDate)
            {
                startTimeUtc = adjustedDate;
                CalculateRiseSetTransform();
            }
        }
    }

    /// <summary>
    /// Gets or sets the local start time.
    /// </summary>
    /// <value>The local start time.</value>
    public DateTime StartTimeLocal
    {
        get => startTimeLocal;

        set
        {
            if (value != startTimeLocal)
            {
                startTimeLocal = value;
                StartTimeUtc = value;
            }
        }
    }

    private DateTime endTimeUtc;
    private DateTime endTimeLocal;

    /// <summary>
    /// Gets or sets the end time in universal coordinated time (UTC).
    /// </summary>
    /// <value>The end time in universal coordinated time (UTC).</value>
    /// <remarks>When the value is set, the time value (hour, minutes and seconds) is automatically removed and a local time value is converted into UTC at offset <c>0</c>.</remarks>
    public DateTime EndTimeUtc
    {
        get => endTimeUtc;

        set
        {
            var offset = DateTimeOffset.Now.Offset.TotalHours;
            var adjustedDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

            endTimeLocal = value;

            if (endTimeUtc != adjustedDate)
            {
                endTimeUtc = adjustedDate;
                CalculateRiseSetTransform();
            }
        }
    }

    /// <summary>
    /// Gets or sets the local end time.
    /// </summary>
    /// <value>The local end time.</value>
    public DateTime EndTimeLocal
    {
        get => endTimeLocal;

        set
        {
            if (value != endTimeLocal)
            {
                endTimeLocal = value;
                EndTimeUtc = value;
            }
        }
    }

    private double latitude;

    /// <summary>
    /// Gets or sets the latitude in degrees.
    /// </summary>
    /// <value>The latitude.</value>
    public double Latitude
    {
        get => latitude;

        set
        {
            if (Math.Abs(latitude - value) > Globals.FloatingPointTolerance)
            {
                latitude = value;
                CalculateRiseSetTransform();
            }
        }
    }

    private double longitude;

    /// <summary>
    /// Gets or sets the longitude in degrees.
    /// </summary>
    /// <value>The longitude.</value>
    public double Longitude
    {
        get => longitude;

        set
        {
            if (Math.Abs(longitude - value) > Globals.FloatingPointTolerance)
            {
                longitude = value;
                CalculateRiseSetTransform();
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
    /// Calculates the rise, set and transform times.
    /// </summary>
    public abstract void CalculateRiseSetTransform();

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
}