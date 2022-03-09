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

using System.Globalization;
using Eto.Forms;
using StarMap2D.Calculations.StaticData;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Forms;

/// <summary>
/// A form to display detailed information of known celestial objects.
/// Implements the <see cref="Eto.Forms.Form" />
/// </summary>
/// <seealso cref="Eto.Forms.Form" />
public partial class FormCelestialObjectData
{
    private void CreateColumns()
    {
        gridView!.Columns.Add(new GridColumn
        {
            HeaderText = Units.Name,
            DataCell = new TextBoxCell(nameof(PlanetDataExtended.Name)),
            //                Sortable = true,
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.RightAscensionHours,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.RightAscension)
                    .Convert(f => f.ToString("F10", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.DeclinationDegrees,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Declination)
                    .Convert(f => f.ToString("F10", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.HorizontalAltitudeDegrees,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.HorizontalDegreesY)
                    .Convert(f => f.ToString("F10", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.HorizontalAzimuthDegrees,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.HorizontalDegreesX)
                    .Convert(f => f.ToString("F10", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.AboveHorizon,
            DataCell = new CheckBoxCell(nameof(PlanetDataExtended.AboveHorizon)),
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.MassKg_10_24,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Mass)
                    .Convert(f => f.ToString("F0", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.DiameterKm,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Diameter)
                    .Convert(f => f.ToString("F0", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.DensityKgPerM3,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Density)
                    .Convert(f => f.ToString("F0", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.GravityMPerS2,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Gravity)
                    .Convert(f => f.ToString("F3", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.EscapeVelocityKmPerS,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.EscapeVelocity)
                    .Convert(f => f.ToString("F1", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.RotationPeriodHours,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.RotationPeriod)
                    .Convert(f => f.ToString("F2", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.LengthOfDayHours,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.LengthOfDay)
                    .Convert(f => f.ToString("F3", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.DistanceFromSun_10_6_Km,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.DistanceFromSun)
                    .Convert(f => f.ToString("F2", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.Perihelion_10_6_Km,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Perihelion)
                    .Convert(f => f.ToString("F3", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.Aphelion_10_6_Km,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Aphelion)
                    .Convert(f => f.ToString("F3", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.OrbitalPeriodDays,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.OrbitalPeriod)
                    .Convert(f => f?.ToString("F3", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.OrbitalVelocityKmPerS,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.OrbitalVelocity)
                    .Convert(f => f?.ToString("F1", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.OrbitalInclinationDegrees,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.OrbitalInclination)
                    .Convert(f => f?.ToString("F1", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.OrbitalEccentricity,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.OrbitalEccentricity)
                    .Convert(f => f?.ToString("F4", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.ObliquityToOrbitDegrees,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.ObliquityToOrbit)
                    .Convert(f => f?.ToString("F4", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.MeanTemperatureDegreesC,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.MeanTemperature)
                    .Convert(f => f?.ToString("F1", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.SurfacePressureBars,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.SurfacePressure)
                    .Convert(f => f?.ToString("F2", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.NumberOfMoons,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.NumberOfMoons)
                    .Convert(f => f?.ToString("F0", Globals.FormattingCulture) ?? Units.ValueUnknown),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.RingSystem,
            DataCell = new CheckBoxCell(nameof(PlanetDataExtended.RingSystem)),
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = Units.GlobalMagneticField,
            DataCell = new CheckBoxCell(nameof(PlanetDataExtended.GlobalMagneticField)),
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.Latitude,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Latitude)
                    .Convert(f => f.ToString("F0", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.Longitude,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.Longitude)
                    .Convert(f => f.ToString("F0", Globals.FormattingCulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.DateAndTime,
            DataCell = new TextBoxCell
            {
                Binding = Binding.Property((PlanetDataExtended e) => e.DetailDateTime)
                    .Convert(f => f.ToString(CultureInfo.CurrentUICulture)),
                TextAlignment = TextAlignment.Right,
            },
        });

        gridView.Columns.Add(new GridColumn
        {
            HeaderText = UI.DataURL,
            DataCell = new TextBoxCell(nameof(PlanetDataExtended.DataUrl)),
        });

    }
}