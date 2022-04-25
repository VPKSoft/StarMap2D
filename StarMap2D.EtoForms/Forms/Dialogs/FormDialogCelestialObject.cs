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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.StaticData;
using StarMap2D.Common.SvgColorization;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Classes;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;
using CO = StarMap2D.Localization.CelestialObjects;


namespace StarMap2D.EtoForms.Forms.Dialogs;

/// <summary>
/// A dialog to display celestial object detail data.
/// Implements the <see cref="Eto.Forms.Dialog" />
/// </summary>
/// <seealso cref="Eto.Forms.Dialog" />
public class FormDialogCelestialObject : Dialog
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StarMap2D.EtoForms.Forms.Dialogs.FormDialogCelestialObject"/> class.
    /// </summary>
    public FormDialogCelestialObject()
    {
        MinimumSize = new Size(600, 300);

        Title = UI.CelestialObjects;

        // Set the icon for the form.
        EtoHelpers.SetIcon(this, EtoForms.Properties.Resources.StarMap2D);

        InitializeView();
        DisplayObjectData();
    }

    /// <summary>
    /// Shows the dialog modally, blocking the current thread until it is closed.
    /// </summary>
    /// <param name="displayObject">The object which data to display in the dialog initially.</param>
    /// <param name="owner">The owner control that is showing the form</param>
    /// <remarks>The <paramref name="owner" /> specifies the control on the window that will be blocked from user input until
    /// the dialog is closed.
    /// Calling this method is identical to setting the <see cref="P:Eto.Forms.Window.Owner" /> property and calling <see cref="M:Eto.Forms.Dialog.ShowModal" />.</remarks>
    /// <param name="dateTime">The date and time to calculate the object coordinates.</param>
    /// <param name="latitude">The latitude of the observer.</param>
    /// <param name="longitude">The longitude of the observer.</param>
    public static void ShowModal(Control? owner, ObjectsWithPositions displayObject, DateTime dateTime, double latitude, double longitude)
    {
        if (!SupportedObjects.Contains(displayObject))
        {
            return;
        }

        var form = new FormDialogCelestialObject
        {
            ActiveObject = displayObject,
        };

        form.nsLongitude!.Value = longitude;
        form.nsLatitude!.Value = latitude;

        form.cmbObjectSelect!.SelectedValue =
            form.objectsWithPositions.FirstOrDefault(f => f.EnumValue == displayObject);

        if (owner == null)
        {
            form.ShowModal();
        }
        else
        {
            form.ShowModal(owner);
        }
    }

    /// <summary>
    /// Shows the dialog modally, blocking the current thread until it is closed.
    /// </summary>
    /// <param name="displayObject">The object which data to display in the dialog initially.</param>
    /// <param name="dateTime">The date and time to calculate the object coordinates.</param>
    /// <param name="latitude">The latitude of the observer.</param>
    /// <param name="longitude">The longitude of the observer.</param>
    public static void ShowModal(ObjectsWithPositions displayObject, DateTime dateTime, double latitude, double longitude)
    {
        ShowModal(null, displayObject, dateTime, latitude, longitude);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private ObjectsWithPositions activeObject = ObjectsWithPositions.Sun;

    private ObjectsWithPositions ActiveObject
    {
        get => activeObject;

        set
        {
            if (value != activeObject)
            {
                activeObject = value;
                if (cmbObjectSelect != null && objectsWithPositions.Count > 0)
                {
                    cmbObjectSelect.SelectedValue =
                        objectsWithPositions.FirstOrDefault(f => f.EnumValue == activeObject);
                }

                DisplayObjectData();
            }
        }
    }

    private TableLayout? tlMain;
    private TableLayout? tlTopControls;
    private TableLayout? tlBottomControls;
    private TableLayout? tlExtraData;
    private ComboBox? cmbObjectSelect;
    private NumericStepper? nsLatitude;
    private NumericStepper? nsLongitude;
    private DateTimePicker? dateTimePickerJump;
    private ComboBox? cmbJumpLocation;
    private Button? btnCopyToClipboard;

    private Label? lbAboveHorizon;
    private Label? lbAdditionalDataLink;
    private Label? lbConstellation;

    private Label? lbRightAscensionHours;
    private Label? lbDeclinationDegrees;
    private Label? lbHorizontalX;
    private Label? lbHorizontalY;

    private Label? lbMassKg;
    private Label? lbDiameter;
    private Label? lbDensity;
    private Label? lbGravity;

    private Label? lbEscapeVelocity;
    private Label? lbRotationPeriod;
    private Label? lbLengthOfDay;
    private Label? lbDistanceFromSun;

    private Label? lbPerihelion;
    private Label? lbAphelion;
    private Label? lbOrbitalPeriod;
    private Label? lbOrbitalVelocity;

    private Label? lbOrbitalInclination;
    private Label? lbOrbitalEccentricity;
    private Label? lbObliquityToOrbit;
    private Label? lbMeanTemperature;

    private Label? lbSurfacePressure;
    private Label? lbNumberOfMoons;
    private Label? lbRingSystem;
    private Label? lbGlobalMagneticField;

    private readonly List<EnumStringItem<ObjectsWithPositions>> objectsWithPositions = new();

    private Label CreateLabel()
    {
        var labelWidth = 135;
        var labelColor = Globals.Settings.DateTextDefaultColor!.Value;
        return new Label
        {
            Width = labelWidth,
            TextAlignment = TextAlignment.Left,
            Font = Globals.Settings.DataFont ?? SettingsFontData.Empty,
            TextColor = labelColor,
        };
    }

    private void DisplayObjectData()
    {
        var detail = PlanetData.Data.First(f =>
            f.ObjectType == ((EnumStringItem<ObjectsWithPositions>)cmbObjectSelect!.SelectedValue).EnumValue);

        if (lbDensity != null)
        {
            lbMassKg!.Text = DisplayFloating(detail.Mass, 2);
            lbDiameter!.Text = DisplayFloating(detail.Diameter, 2);
            lbDensity.Text = DisplayFloating(detail.Density, 2);
            lbGravity!.Text = DisplayFloating(detail.Gravity, 3);

            lbEscapeVelocity!.Text = DisplayFloating(detail.EscapeVelocity, 3);
            lbRotationPeriod!.Text = DisplayFloating(detail.RotationPeriod, 3);
            lbLengthOfDay!.Text = DisplayFloating(detail.LengthOfDay, 4);
            lbDistanceFromSun!.Text = DisplayFloating(detail.DistanceFromSun, 2);

            lbPerihelion!.Text = DisplayFloating(detail.Perihelion, 4);
            lbAphelion!.Text = DisplayFloating(detail.Aphelion, 4);
            lbOrbitalPeriod!.Text = DisplayFloating(detail.OrbitalPeriod, 4);
            lbOrbitalVelocity!.Text = DisplayFloating(detail.OrbitalVelocity, 4);

            lbOrbitalInclination!.Text = DisplayFloating(detail.OrbitalInclination, 4);
            lbOrbitalEccentricity!.Text = DisplayFloating(detail.OrbitalEccentricity, 4);
            lbObliquityToOrbit!.Text = DisplayFloating(detail.ObliquityToOrbit, 4);
            lbMeanTemperature!.Text = DisplayFloating(detail.MeanTemperature, 4);

            lbSurfacePressure!.Text = DisplayFloating(detail.SurfacePressure, 4);
            lbNumberOfMoons!.Text = DisplayInteger(detail.NumberOfMoons);
            lbRingSystem!.Text = DisplayBoolean(detail.RingSystem);
            lbGlobalMagneticField!.Text = DisplayBoolean(detail.GlobalMagneticField);

            lbAdditionalDataLink!.Text = detail.DataUrl;
        }

        DisplayCalculatedData();

        ActiveObject = detail.ObjectType;
    }

    private void DisplayCalculatedData()
    {
        if (nsLongitude == null)
        {
            return;
        }

        var details = SolarSystemObjectPositions.GetDetails(ActiveObject,
            dateTimePickerJump!.Value!.Value.ToUniversalTime().ToAASDate(), Globals.HighPrecisionCalculations,
            nsLatitude!.Value, nsLongitude!.Value);

        lbRightAscensionHours!.Text = DisplayFloating(details.RightAscension, 8);
        lbDeclinationDegrees!.Text = DisplayFloating(details.Declination, 8);
        lbHorizontalX!.Text = DisplayFloating(details.HorizontalDegreesX, 8);
        lbHorizontalY!.Text = DisplayFloating(details.HorizontalDegreesY, 8);
        lbAboveHorizon!.Text = DisplayBoolean(details.AboveHorizon);

        var constellation = PointInConstellation.GetConstellationForPoint(details.RightAscension, details.Declination);

        lbConstellation!.Text = ConstellationClassEnumNameMap.ConstellationClassesEnumsNames
            .FirstOrDefault(f => f.Constellation == constellation)?.Name;
    }

    private Dictionary<Label, string> ValueControls { get; set; } = new();

    private void InitializeView()
    {
        tlMain = new TableLayout();

        tlTopControls = new TableLayout();
        cmbObjectSelect = new ComboBox { AutoComplete = true, Width = 150, };
        cmbObjectSelect.SelectedValueChanged += delegate { DisplayObjectData(); };
        ListObjects();

        nsLatitude = new NumericStepper { DecimalPlaces = 10, MinValue = -90, MaxValue = 90, Width = 150, };
        nsLongitude = new NumericStepper { DecimalPlaces = 10, MinValue = -180, MaxValue = 180, Width = 150, };
        nsLatitude.ValueChanged += LatLonDateOnValueChanged;
        nsLongitude.ValueChanged += LatLonDateOnValueChanged;

        dateTimePickerJump = new DateTimePicker { Mode = DateTimePickerMode.DateTime, Value = DateTime.Now, };
        dateTimePickerJump.ValueChanged += LatLonDateOnValueChanged;

        tlTopControls.Rows.Add(new TableRow(
            EtoHelpers.LabelWrap(UI.CelestialObject, cmbObjectSelect),
            EtoHelpers.LabelWrap(UI.Latitude, nsLatitude),
            EtoHelpers.LabelWrap(UI.Longitude, nsLongitude),
            new TableCell { ScaleWidth = true, }
        ));

        cmbJumpLocation = new ComboBox { AutoComplete = true, };
        cmbJumpLocation.DataStore = Cities.CitiesList;
        cmbJumpLocation.ItemTextBinding = new PropertyBinding<string>(nameof(CityLatLonCoordinate.CityName));
        cmbJumpLocation.SelectedValueChanged += CmbJumpLocation_SelectedValueChanged;

        btnCopyToClipboard = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_copy_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 6, (_, _) =>
            {
            }, UI.CopyToClipboard);

        btnCopyToClipboard.Click += BtnCopyToClipboard_Click;

        tlTopControls.Rows.Add(new TableRow(
            EtoHelpers.LabelWrap(UI.SpecifyDateTimeTitle, dateTimePickerJump),
            EtoHelpers.LabelWrap(UI.JumpToLcation, cmbJumpLocation),
            EtoHelpers.HeightLimitWrap(EtoHelpers.PaddingWrap(btnCopyToClipboard, Globals.DefaultPadding), false),
            new TableCell { ScaleWidth = true, }
        ));

        lbRightAscensionHours = CreateLabel();
        lbDeclinationDegrees = CreateLabel();
        lbHorizontalX = CreateLabel();
        lbHorizontalY = CreateLabel();

        lbMassKg = CreateLabel();
        lbDiameter = CreateLabel();
        lbDensity = CreateLabel();
        lbGravity = CreateLabel();

        lbEscapeVelocity = CreateLabel();
        lbRotationPeriod = CreateLabel();
        lbLengthOfDay = CreateLabel();
        lbDistanceFromSun = CreateLabel();

        lbPerihelion = CreateLabel();
        lbAphelion = CreateLabel();
        lbOrbitalPeriod = CreateLabel();
        lbOrbitalVelocity = CreateLabel();

        lbOrbitalInclination = CreateLabel();
        lbOrbitalEccentricity = CreateLabel();
        lbObliquityToOrbit = CreateLabel();
        lbMeanTemperature = CreateLabel();

        lbSurfacePressure = CreateLabel();
        lbNumberOfMoons = CreateLabel();
        lbRingSystem = CreateLabel();
        lbGlobalMagneticField = CreateLabel();

        lbAboveHorizon = CreateLabel();
        lbConstellation = CreateLabel();


        lbAdditionalDataLink = CreateLabel();
        lbAdditionalDataLink.Width = MinimumSize.Width - 50;
        lbAdditionalDataLink.Cursor = Cursors.Pointer;
        lbAdditionalDataLink.MouseDown += (_, _) =>
        {
            Application.Instance.Open(lbAdditionalDataLink.Text);
        };

        tlBottomControls = new TableLayout
        {
            Rows =
            {
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(UI.AboveHorizon, lbAboveHorizon)),
                        new TableCell(),
                        new TableCell(),
                        new TableCell(EtoHelpers.LabelWrap(UI.Constellation, lbConstellation)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(UI.RightAscensionHours, lbRightAscensionHours)),
                        new TableCell(EtoHelpers.LabelWrap(UI.DeclinationDegrees, lbDeclinationDegrees)),
                        new TableCell(EtoHelpers.LabelWrap(UI.HorizontalAltitudeDegrees, lbHorizontalY)),
                        new TableCell(EtoHelpers.LabelWrap(Units.HorizontalAzimuthDegrees, lbHorizontalX)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(Units.MassKg_10_24, lbMassKg)),
                        new TableCell(EtoHelpers.LabelWrap(Units.DiameterKm, lbDiameter)),
                        new TableCell(EtoHelpers.LabelWrap(Units.DensityKgPerM3, lbDensity)),
                        new TableCell(EtoHelpers.LabelWrap(Units.GravityMPerS2, lbGravity)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(Units.EscapeVelocityKmPerS, lbEscapeVelocity)),
                        new TableCell(EtoHelpers.LabelWrap(Units.RotationPeriodHours, lbRotationPeriod)),
                        new TableCell(EtoHelpers.LabelWrap(Units.LengthOfDayHours, lbLengthOfDay)),
                        new TableCell(EtoHelpers.LabelWrap(Units.DistanceFromSun_10_6_Km, lbDistanceFromSun)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(Units.Perihelion_10_6_Km, lbPerihelion)),
                        new TableCell(EtoHelpers.LabelWrap(Units.Aphelion_10_6_Km, lbAphelion)),
                        new TableCell(EtoHelpers.LabelWrap(Units.OrbitalPeriodDays, lbOrbitalPeriod)),
                        new TableCell(EtoHelpers.LabelWrap(Units.OrbitalVelocityKmPerS, lbOrbitalVelocity)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(Units.OrbitalInclinationDegrees, lbOrbitalInclination)),
                        new TableCell(EtoHelpers.LabelWrap(Units.OrbitalEccentricity, lbOrbitalEccentricity)),
                        new TableCell(EtoHelpers.LabelWrap(Units.ObliquityToOrbitDegrees, lbObliquityToOrbit)),
                        new TableCell(EtoHelpers.LabelWrap(Units.MeanTemperatureDegreesC, lbMeanTemperature)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(Units.SurfacePressureBars, lbSurfacePressure)),
                        new TableCell(EtoHelpers.LabelWrap(Units.NumberOfMoons, lbNumberOfMoons)),
                        new TableCell(EtoHelpers.LabelWrap(Units.RingSystem, lbRingSystem)),
                        new TableCell(EtoHelpers.LabelWrap(Units.GlobalMagneticField, lbGlobalMagneticField)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
            },
        };

        tlExtraData = new TableLayout
        {
            Rows =
            {
                new TableRow
                {
                    Cells =
                    {
                        new TableCell(EtoHelpers.LabelWrap(UI.AdditionalData, lbAdditionalDataLink)),
                        new TableCell { ScaleWidth = true, },
                    },
                },
            },
        };

        tlMain.Rows.Add(tlTopControls);
        tlMain.Rows.Add(tlBottomControls);
        tlMain.Rows.Add(tlExtraData);

        tlMain.Rows.Add(new TableRow { ScaleHeight = true, });

        Content = tlMain;

        ValueControls = new Dictionary<Label, string>
        {
            { lbAboveHorizon, UI.AboveHorizon },
            { lbRightAscensionHours, UI.RightAscensionHours },
            { lbDeclinationDegrees, UI.DeclinationDegrees },
            { lbHorizontalX, Units.HorizontalAzimuthDegrees },
            { lbHorizontalY, UI.HorizontalAltitudeDegrees },
            { lbMassKg, Units.MassKg_10_24 },
            { lbDiameter, Units.DiameterKm },
            { lbDensity, Units.DensityKgPerM3 },
            { lbGravity, Units.GravityMPerS2 },
            { lbEscapeVelocity, Units.EscapeVelocityKmPerS },
            { lbRotationPeriod, Units.RotationPeriodHours },
            { lbLengthOfDay, Units.LengthOfDayHours },
            { lbDistanceFromSun, Units.DistanceFromSun_10_6_Km },
            { lbPerihelion, Units.Perihelion_10_6_Km },
            { lbAphelion, Units.Aphelion_10_6_Km },
            { lbOrbitalPeriod, Units.OrbitalPeriodDays },
            { lbOrbitalVelocity, Units.OrbitalVelocityKmPerS },
            { lbOrbitalInclination, Units.OrbitalInclinationDegrees },
            { lbOrbitalEccentricity, Units.OrbitalEccentricity },
            { lbObliquityToOrbit, Units.ObliquityToOrbitDegrees },
            { lbMeanTemperature, Units.MeanTemperatureDegreesC },
            { lbSurfacePressure, Units.SurfacePressureBars },
            { lbNumberOfMoons, Units.NumberOfMoons },
            { lbRingSystem, Units.RingSystem },
            { lbGlobalMagneticField, Units.GlobalMagneticField },
            { lbAdditionalDataLink, UI.AdditionalData },
        };
    }

    private void BtnCopyToClipboard_Click(object? sender, EventArgs e)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"{UI.CelestialObject} = {((EnumStringItem<ObjectsWithPositions>)cmbObjectSelect!.SelectedValue).EnumName}");
        builder.AppendLine($"{UI.SpecifyDateTimeTitle} = {dateTimePickerJump!.Value!.Value}");
        builder.AppendLine($"{UI.Latitude} = {DisplayFloating(nsLatitude!.Value, 10)}");
        builder.AppendLine($"{UI.Longitude} = {DisplayFloating(nsLongitude!.Value, 10)}");
        foreach (var valueControl in ValueControls)
        {
            builder.AppendLine($"{valueControl.Value} = {valueControl.Key.Text}");
        }

        Clipboard.Instance.Text = builder.ToString();
    }

    private void LatLonDateOnValueChanged(object? sender, EventArgs e)
    {
        DisplayObjectData();
    }

    private void CmbJumpLocation_SelectedValueChanged(object? sender, EventArgs e)
    {
        if (cmbJumpLocation!.SelectedValue == null)
        {
            return;
        }

        var value = (CityLatLonCoordinate)cmbJumpLocation.SelectedValue;
        nsLatitude!.Value = value.Latitude;
        nsLongitude!.Value = value.Longitude;
        DisplayObjectData();
    }

    /// <summary>
    /// Creates a collection of celestial objects currently supported by the view.
    /// </summary>
    private static List<ObjectsWithPositions> SupportedObjects { get; } = new(new[]
    {
        ObjectsWithPositions.Mercury,
        ObjectsWithPositions.Venus,
        ObjectsWithPositions.Earth,
        ObjectsWithPositions.Mars,
        ObjectsWithPositions.Jupiter,
        ObjectsWithPositions.Saturn,
        ObjectsWithPositions.Uranus,
        ObjectsWithPositions.Neptune,
        ObjectsWithPositions.Pluto,
        ObjectsWithPositions.Moon,
        ObjectsWithPositions.Sun,
        ObjectsWithPositions.Ceres,
        ObjectsWithPositions.Eris,
        ObjectsWithPositions.Makemake,
        ObjectsWithPositions.Haumea,
    });

    /// <summary>
    /// Creates a collection of celestial objects currently supported by the view with their localized names.
    /// </summary>
    private void ListObjects()
    {
        objectsWithPositions.Clear();
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Mercury, CO.Mercury));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Venus, CO.Venus));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Earth, CO.Earth));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Mars, CO.Mars));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Jupiter, CO.Jupiter));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Saturn, CO.Saturn));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Uranus, CO.Uranus));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Neptune, CO.Neptune));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Pluto, CO.Pluto));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Moon, CO.Moon));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Sun, CO.Sun));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Ceres, CO.Ceres));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Eris, CO.Eris));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Makemake, CO.Makemake));
        objectsWithPositions.Add(new EnumStringItem<ObjectsWithPositions>(ObjectsWithPositions.Haumea, CO.Haumea));

        cmbObjectSelect!.DataStore = objectsWithPositions;
        cmbObjectSelect.ItemTextBinding =
            new PropertyBinding<string>(nameof(EnumStringItem<ObjectsWithPositions>.EnumName));

        cmbObjectSelect.SelectedIndex = 0;
    }

    /// <summary>
    /// Displays a nullable floating point value.
    /// </summary>
    /// <param name="value">The value of the floating point.</param>
    /// <param name="decimals">The number of decimals to display in the string representation.</param>
    /// <returns>A <see cref="System.String"/> representing the floating point value.</returns>
    private string DisplayFloating(double? value, int decimals)
    {
        if (value == null)
        {
            return Units.ValueUnknown;
        }

        return value.Value.ToString($"F{decimals}", Globals.FormattingCulture);
    }

    /// <summary>
    /// Displays a nullable integer value.
    /// </summary>
    /// <param name="value">The value of the integer.</param>
    /// <returns>A <see cref="System.String"/> representing the integer value.</returns>
    private string DisplayInteger(int? value)
    {
        if (value == null)
        {
            return Units.ValueUnknown;
        }

        return value.Value.ToString(Globals.FormattingCulture);
    }

    /// <summary>
    /// Displays a nullable boolean value.
    /// </summary>
    /// <param name="value">The value of the boolean.</param>
    /// <returns>A <see cref="System.String"/> representing the boolean value.</returns>
    private string DisplayBoolean(bool? value)
    {
        if (value == null)
        {
            return Units.ValueUnknown;
        }

        return value.Value ? Units.ValueYes : Units.ValueNo;
    }
}