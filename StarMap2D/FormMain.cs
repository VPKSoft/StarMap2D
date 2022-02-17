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

using System.Diagnostics;
using System.Globalization;
using AASharp;
using ScottPlot.Plottable;
using StarMap2D.Calculations.Compass;
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Forms;
using StarMap2D.Forms.Dialogs;
using StarMap2D.Localization;
using VPKSoft.DBLocalization;
using VPKSoft.LangLib;

namespace StarMap2D;

/// <summary>
/// The main form of the application.
/// Implements the <see cref="System.Windows.Forms.Form" />
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class FormMain : DBLangEngineWinforms
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormMain"/> class.
    /// </summary>
    public FormMain()
    {
        InitializeComponent();

        DBLangEngine.DBName = "lang.sqlite"; // Do the VPKSoft.LangLib == translation..

        if (Utils.ShouldLocalize() != null)
        {
            DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages", Utils.ShouldLocalize(), false);
            return; // After localization don't do anything more..
        }

        // initialize the language/localization database..
        DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages");

        CompassDirection.GetNameFunc = LocalizeCompassDirection.LocalizeCompassDirectionFunc;

        PlotSunMoon();

        DisplayRiseSet();

        //Properties.Settings.Default.Reset();
    }

    private void button2_Click(object sender, EventArgs ee)
    {
        FormSkyMap2D.Display();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        new FormSolarSystemObjectsTable().Show();
    }

    private void mnuLocalize_Click(object sender, EventArgs e)
    {
        try
        {
            LocalizeRunner.RunLocalizeWindow(
                // ReSharper disable once StringLiteralTypo
                Program.GetSettingFile("lang.sqlite"));
        }
        catch
        {
            // The localization failed.
        }
    }

    private void mnuDumpLanguage_Click(object sender, EventArgs e)
    {
        try
        {
            Process.Start(Application.ExecutablePath, "--dblang");
        }
        catch
        {
            // The localization dumping failed.
        }
    }

    private void mnuSettings_Click(object sender, EventArgs e)
    {
        FormDialogSettings.Display(this);
    }

    private void mnuSkyMap_Click(object sender, EventArgs e)
    {
        FormSkyMap2D.Display();
    }

    private void mnuObjectDetails_Click(object sender, EventArgs e)
    {
        new FormSolarSystemObjectsTable().Show();
    }

    private void DisplayRiseSet()
    {
        var date1 = DateTime.Now.ToAASDateTruncated();
        var date2 = date1.AddDays(1);

        var longitude = Properties.Settings.Default.Longitude;
        var latitude = Properties.Settings.Default.Latitude;

        var riseSet = AASRiseTransitSet2.Calculate(date1.Julian, date2.Julian, AASRiseTransitSet2.Objects.MOON, -longitude, latitude,
            -0.8333);

        var jdRise = riseSet.FirstOrDefault(f => f.type == AASRiseTransitSetDetails2.Type.Rise)?.JD ?? 0;
        var jdSet = riseSet.FirstOrDefault(f => f.type == AASRiseTransitSetDetails2.Type.Set)?.JD ?? 0;
        tbMoonRiseValue.Text = new AASDate(jdRise, true).ToDateTime().ToLocalTime().ToString("g", CultureInfo.CurrentCulture);
        tbMoonSetValue.Text = new AASDate(jdSet, true).ToDateTime().ToLocalTime().ToString("g", CultureInfo.CurrentCulture);

        riseSet = AASRiseTransitSet2.Calculate(date1.Julian, date2.Julian, AASRiseTransitSet2.Objects.SUN, -longitude, latitude,
            -0.8333);
        jdRise = riseSet.FirstOrDefault(f => f.type == AASRiseTransitSetDetails2.Type.Rise)?.JD ?? 0;
        jdSet = riseSet.FirstOrDefault(f => f.type == AASRiseTransitSetDetails2.Type.Set)?.JD ?? 0;
        tblbSunRiseValue.Text = new AASDate(jdRise, true).ToDateTime().ToLocalTime().ToString("g", CultureInfo.CurrentCulture);
        tbSunSetValue.Text = new AASDate(jdSet, true).ToDateTime().ToLocalTime().ToString("g", CultureInfo.CurrentCulture);
    }

    private Crosshair? sunCrossHair;
    private Crosshair? moonCrossHair;

    private ScatterPlot? sunPlot;
    private ScatterPlot? moonPlot;

    private void PlotSunMoon()
    {
        var xSunDoubles = new double[60 * 24];
        var ySunDoubles = new double[60 * 24];

        var xMoonDoubles = new double[60 * 24];
        var yMoonDoubles = new double[60 * 24];

        var dateTime = DateTime.UtcNow;

        var offset = DateTimeOffset.Now.Offset.TotalHours;

        dateTime =
            new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

        var date = dateTime.ToAASDate();

        var longitude = Properties.Settings.Default.Longitude;
        var latitude = Properties.Settings.Default.Latitude;

        for (int i = 0; i < 60 * 24; i++)
        {
            date = date.AddSecondsFast(60);
            var x = date.Hours(offset);
            xSunDoubles[i] = x;
            xMoonDoubles[i] = x;

            var position = SolarSystemObjectPositions.GetObjectPosition(AASEllipticalObject.SUN, date, false, longitude, latitude);
            ySunDoubles[i] = position.Y;

            position = SolarSystemObjectPositions.GetMoonPosition(date, true, longitude, latitude);
            yMoonDoubles[i] = position.Y;
        }

        sunPlot = sunMoonPlot.Plot.AddScatterLines(xSunDoubles, ySunDoubles);
        sunPlot.XAxisIndex = 0;
        sunPlot.YAxisIndex = 0;
        sunMoonPlot.Plot.XAxis.Color(sunPlot.Color);
        sunMoonPlot.Plot.YAxis.Color(sunPlot.Color);

        moonPlot = sunMoonPlot.Plot.AddScatterLines(xMoonDoubles, yMoonDoubles);
        moonPlot.XAxisIndex = 1;
        moonPlot.YAxisIndex = 1;
        sunMoonPlot.Plot.XAxis2.Color(moonPlot.Color);
        sunMoonPlot.Plot.YAxis2.Color(moonPlot.Color);


        sunCrossHair = sunMoonPlot.Plot.AddCrosshair(0, 0);
        sunCrossHair.VerticalLine.PositionFormatter = hours => TimeSpan.FromHours(hours).ToString(@"hh\:mm\:ss");
        sunCrossHair.Color = sunPlot.Color;

        moonCrossHair = sunMoonPlot.Plot.AddCrosshair(0, 0);
        moonCrossHair.VerticalLine.PositionFormatter = hours => TimeSpan.FromHours(hours).ToString(@"hh\:mm\:ss");
        moonCrossHair.Color = moonPlot.Color;
        moonCrossHair.HorizontalLine.PositionLabelOppositeAxis = true;
        moonCrossHair.VerticalLine.PositionLabelOppositeAxis = true;

        sunMoonPlot.Plot.XAxis.Label("Sun time");
        sunMoonPlot.Plot.YAxis.Label("Sun degrees");

        sunMoonPlot.Plot.XAxis2.Label("Moon time");
        sunMoonPlot.Plot.YAxis2.Label("Moon degrees");

        sunMoonPlot.Refresh();

        sunMoonPlot.Plot.YAxis2.LockLimits();
        sunMoonPlot.Plot.YAxis.LockLimits();
        sunMoonPlot.Plot.XAxis.LockLimits();
        sunMoonPlot.Plot.XAxis2.LockLimits();
    }

    private void formsPlot1_MouseMove(object sender, MouseEventArgs e)
    {
        if (sunPlot != null && sunCrossHair != null && moonCrossHair != null && moonPlot != null)
        {
            var (mouseCoordinateX, mouseCoordinateY) = sunMoonPlot.GetMouseCoordinates();
            var xyRatio = sunMoonPlot.Plot.XAxis.Dims.PxPerUnit / sunMoonPlot.Plot.YAxis.Dims.PxPerUnit;
            var (pointX, pointY, pointIndex) = sunPlot.GetPointNearestX(mouseCoordinateX);

            //Text = $"Point index {pointIndex} at ({pointX}, {pointY})";

            var coordinates = sunMoonPlot.GetMouseCoordinates();

            //        Debug.WriteLine(coordinates);

            sunCrossHair.X = pointX;
            sunCrossHair.Y = pointY;
            (pointX, pointY, _) = moonPlot.GetPointNearestX(mouseCoordinateX);
            moonCrossHair.X = pointX;
            moonCrossHair.Y = pointY;
        }

        sunMoonPlot.Render();
    }
}