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

namespace StarMap2D.Calculations;

/// <summary>
/// A base class for calculations requiring latitude, longitude, date and time data.
/// </summary>
public abstract class LatLonDateCalculation
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LatLonDateCalculation"/> class
    /// with the <see cref="StartTimeUtc"/> set to start of the current day and the <see cref="EndTimeUtc"/> set to the start of the next day.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    protected LatLonDateCalculation(double latitude, double longitude)
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
    /// Initializes a new instance of the <see cref="LatLonDateCalculation"/> class.
    /// </summary>
    /// <param name="latitude">The latitude of the observer in degrees.</param>
    /// <param name="longitude">The longitude of the observer in degrees.</param>
    /// <param name="starTimeLocal">The star time in local time.</param>
    /// <param name="endTimeLocal">The end time in local time.</param>
    protected LatLonDateCalculation(double latitude, double longitude, DateTime starTimeLocal,
        DateTime endTimeLocal) : this(latitude, longitude)
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
                    Calculate();
                }
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
            var adjustedDate =
                new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

            startTimeLocal = value;

            if (startTimeUtc != adjustedDate)
            {
                startTimeUtc = adjustedDate;
                Calculate();
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
                Calculate();
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
            var adjustedDate =
                new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

            endTimeLocal = value;

            if (endTimeUtc != adjustedDate)
            {
                endTimeUtc = adjustedDate;
                Calculate();
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
                Calculate();
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
                Calculate();
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
                Calculate();
            }
        }
    }

    /// <summary>
    /// Performs the calculations required by this class if the <see cref="SuspendCalculation"/> property is not defined.
    /// </summary>
    public abstract void Calculate();
}