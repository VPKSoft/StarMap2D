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
using System.Globalization;
using System.IO;
using System.Linq;
using AASharp;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using StarMap2D.Avalonia.Classes;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Helpers;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.Plotting;
using VPKSoft.StarCatalogs;
using VPKSoft.StarCatalogs.Providers;
using Color = Avalonia.Media.Color;
using Pen = Avalonia.Media.Pen;
using Point = Avalonia.Point;
using Size = Avalonia.Size;

namespace StarMap2D.Avalonia.Controls;

public partial class Map2D : UserControl
{
    public Map2D()
    {
        InitializeComponent();

        var yaleBrightProvider = new YaleBrightProvider();

        using var reader = new StreamReader(new MemoryStream(Resource.YaleBrightStars));

        yaleBrightProvider.LoadData(reader.ReadAllLines());

        foreach (var yaleBrightStar in yaleBrightProvider.StarData)
        {
            StarMapObjects.Add(new StarMapObject
            {
                RightAscension = yaleBrightStar.RightAscension, Declination = yaleBrightStar.Declination,
                Magnitude = yaleBrightStar.Magnitude
            });
        }

        foreach (var constellationClassEnumMap in ConstellationClassEnumMap.ConstellationClassesEnums)
        {
            var constellation = Activator.CreateInstance(constellationClassEnumMap.ConstellationClassType);
            constellations.Add((IConstellation<ConstellationArea, ConstellationLine>)constellation!);
        }

        constellationNames.GetLocalizedTexts(Resource.Constellations);
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    #region PrivateFields
    private int[] starSizes = Array.Empty<int>();
    private Color[] starColors = Array.Empty<Color>();
    private Plot2D plot2D = new(60.17556337, 24.93412634); // Helsinki (Finland).
    private Color mapBorderColor = Color.FromRgb(39, 39, 39);
    private Color mapCircleColor = Colors.Black;
    private readonly List<IConstellation<ConstellationArea, ConstellationLine>> constellations = new();
    private Color constellationBorderLineColor = Color.FromRgb(13, 23, 125);
    private Color constellationLineColor = Colors.DeepSkyBlue;
    TabDeliLocalization constellationNames = new();

    #endregion

    #region PrivateProperties

    private Rect DrawArea
    {
        get
        {
            Rect drawArea;

            if (Width > Height)
            {
                drawArea = new Rect((Width - Height) / 2.0, 0, Height - 1, Height - 1);
            }
            else
            {
                drawArea = new Rect(0, (Height - Width) / 2.0, Width - 1, Width - 1);
            }

            return drawArea;
        }
    }

    private double OffsetX => Width > Height ? (Width - Height) / 2 : 0;

    private double OffsetY => Height > Width ? (Height - Width) / 2 : 0;

    private double Diameter => Math.Min(Width, Height);

    #endregion

    #region PrivateMethods

    public override void Render(DrawingContext context)
    {
//            base.Render(context);
        DrawMapImage(context);
    }

    /// <summary>
    /// Gets the star drawing arguments.
    /// </summary>
    /// <param name="magnitude">The magnitude of the star to draw.</param>
    /// <returns>A System.ValueTuple&lt;Color, System.Int32&gt; containing the star drawing arguments.</returns>
    private (Color starColor, int starSize) GetStarDrawArguments(double magnitude)
    {
        var index = (int)magnitude + 10;

        var starSize = 3;
        var starColor = Colors.White;

        if (index >= 0 && index < starSizes.Length)
        {
            starSize = starSizes[index];
        }

        if (index >= 0 && index < starColors.Length)
        {
            starColor = starColors[index];
        }

        return (starColor, starSize);
    }

    private Point GetDrawPoint(IImage image, AAS2DCoordinate centerPoint)
    {
        return new Point(centerPoint.X - image.Size.Width / 2 + OffsetX,
            centerPoint.Y - image.Size.Height / 2 + OffsetY);
    }

    /// <inheritdoc cref="ValidDrawPoint(PointDouble)"/>
    private bool ValidDrawPoint(Point point)
    {
        return ValidDrawPoint(new PointDouble { X = point.X, Y = point.Y });
    }

    /// <summary>
    /// Checks if the specified draw point is valid for the star map.
    /// </summary>
    /// <param name="point">The point to check for.</param>
    /// <returns><c>true</c> if specified point is a valid draw point, <c>false</c> otherwise.</returns>
    private bool ValidDrawPoint(PointDouble point)
    {
        if (point.X < 0 && point.Y < 0)
        {
            return false;
        }

        var x = Width / 2.0;
        var y = Height / 2.0;
        var r = Math.Min(Width, Height);
        return Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2)) <= r;
    }


    /// <summary>
    /// Draws the actual star map image.
    /// <param name="context">An instance to a <see cref="DrawingContext"/> to draw on to.</param>
    /// </summary>
    private void DrawMapImage(DrawingContext context)
    {
        plot2D.Diameter = Diameter;

        context.DrawGeometry(new SolidColorBrush(MapBorderColor), new Pen(), new RectangleGeometry(DrawArea));
        context.DrawGeometry(new SolidColorBrush(MapCircleColor), new Pen(), new EllipseGeometry(DrawArea));
        using var clip = context.PushGeometryClip(new EllipseGeometry(DrawArea));

        var previousMagnitude = -11;
        var drawArguments = GetStarDrawArguments(-11);

        foreach (var starMapObject in StarMapObjects)
        {
            if (starMapObject.Magnitude > magnitudeMinimum || starMapObject.Magnitude < magnitudeMaximum)
            {
                continue;
            }

            if (starMapObject.IsLocationCalculated)
            {
                var position = starMapObject.CalculatePosition?.Invoke(Plot2D.AaDate, Plot2D.HighPrecision,
                    Plot2D.Latitude, Plot2D.Longitude, Diameter / 2.0);

                if (position != null)
                {
                    var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter, starMapObject.Magnitude);
                    if (image != null)
                    {
                        context.DrawImage(image, new Rect(GetDrawPoint(image, position), image.Size));
                    }
                }
            }
            else
            {
                var coordinate = new AAS2DCoordinate
                        { X = starMapObject.RightAscension % 360, Y = starMapObject.Declination }
                    .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                var pointD = Plot2D.Project2D(coordinate, invertEastWest);

                var location = new Point(pointD.X, pointD.Y);

                var drawPoint = new Point(location.X + OffsetX, location.Y + OffsetY);

                var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter, starMapObject.Magnitude);
                if (image != null)
                {
                    drawPoint = GetDrawPoint(image, pointD);

                    context.DrawImage(image, new Rect(drawPoint, image.Size));

                    continue;
                }

                if ((int)starMapObject.Magnitude != previousMagnitude)
                {
                    drawArguments = GetStarDrawArguments(starMapObject.Magnitude);
                    previousMagnitude = (int)starMapObject.Magnitude;
                }

                context.DrawStar(drawPoint, drawArguments.starSize, drawArguments.starColor);
            }
        }


        foreach (var constellation in constellations)
        {
            DrawConstellationBoundary(constellation, context);
            DrawConstellation(constellation, context);
        }
    }


    /// <summary>
    /// Draws the specified constellation boundary on a specified graphics.
    /// </summary>
    /// <param name="constellation">The constellation instance which boundary to draw.</param>
    /// <param name="context">An instance to a <see cref="DrawingContext"/> to draw on to.</param>
    private void DrawConstellationBoundary(IConstellation<ConstellationArea, ConstellationLine> constellation,
        DrawingContext context)
    {
        if (!DrawConstellationBoundaries)
        {
            return;
        }

        for (var i = 0; i < constellation.Boundary.Count - 1; i++)
        {
            var point1 = new AAS2DCoordinate
                {
                    X = constellation.Boundary[i].RightAscension % 360, Y = constellation.Boundary[i].Declination
                }
                .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            var point2 = new AAS2DCoordinate
            {
                X = constellation.Boundary[i + 1].RightAscension % 360,
                Y = constellation.Boundary[i + 1].Declination
            }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            var pointD1 = Plot2D.Project2D(point1, invertEastWest);
            var pointD2 = Plot2D.Project2D(point2, invertEastWest);

            var drawPoint1 = new Point(pointD1.X + OffsetX, pointD1.Y + OffsetY);
            var drawPoint2 = new Point(pointD2.X + OffsetX, pointD2.Y + OffsetY);

            if (!ValidDrawPoint(drawPoint1) && !ValidDrawPoint(drawPoint2))
            {
                continue;
            }

            var pen = new Pen(new SolidColorBrush(constellationBorderLineColor));
            context.DrawLine(pen, drawPoint1, drawPoint2);
        }
    }

    /// <summary>
    /// Draws the specified constellation stick image on a specified graphics.
    /// </summary>
    /// <param name="constellation">The constellation instance which stick image to draw.</param>
    /// <param name="context">An instance to a <see cref="DrawingContext"/> to draw on to.</param>
    private void DrawConstellation(IConstellation<ConstellationArea, ConstellationLine> constellation,
        DrawingContext context)
    {
        if (!DrawConstellations)
        {
            return;
        }

        foreach (var constellationLine in constellation.ConstellationLines)
        {
            var star1 = ConstellationStars.Stars.First(f =>
                f.InternalId == constellationLine.StartIdentifier);

            var star2 = ConstellationStars.Stars.First(f =>
                f.InternalId == constellationLine.EndIdentifier);

            var point1 = new AAS2DCoordinate
                    { X = star1.RightAscension, Y = star1.Declination }
                .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            var point2 = new AAS2DCoordinate
                    { X = star2.RightAscension, Y = star2.Declination }
                .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            var pointD1 = Plot2D.Project2D(point1, invertEastWest);
            var pointD2 = Plot2D.Project2D(point2, invertEastWest);

            var drawPoint1 = new Point((int)pointD1.X + OffsetX, (int)pointD1.Y + OffsetY);
            var drawPoint2 = new Point((int)pointD2.X + OffsetX, (int)pointD2.Y + OffsetY);

            if (!ValidDrawPoint(drawPoint1) && !ValidDrawPoint(drawPoint2))
            {
                continue;
            }


            var pen = new Pen(new SolidColorBrush(constellationLineColor));

            context.DrawLine(pen, drawPoint1, drawPoint2);
        }

        if (drawConstellationLabels)
        {
            var constellationData = ConstellationCollection.Constellations.First(f =>
                f.Identifier == constellation.Identifier && f.SerpensOfficial == false);

            var labelPoint = new AAS2DCoordinate
                    { X = constellationData.RightAscension, Y = constellationData.Declination }
                .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            labelPoint = Plot2D.Project2D(labelPoint, invertEastWest);

            var name = constellationNames.GetMessage($"text{constellationData.NameNoWhiteSpace}",
                constellationData.Name ?? string.Empty, Locale);


            var measureSize = MeasureString(name);

            var drawPoint = new Point((int)labelPoint.X + OffsetX - measureSize.Width / 2.0,
                labelPoint.Y + OffsetY - measureSize.Height / 2.0);

            var formattedText = new FormattedText(
                name,
                new Typeface(FontFamily, FontStyle, FontWeight),
                FontSize,
                TextAlignment.Left,
                TextWrapping.NoWrap,
                new Size(10000, 10000));

            var brush = new SolidColorBrush(mapLabelColor);

            context.DrawText(brush, drawPoint, formattedText);
        }
    }

    private Size MeasureString(string candidate)
    {
        var formattedText = new FormattedText(
            candidate,
            new Typeface(FontFamily, FontStyle, FontWeight),
            FontSize,
            TextAlignment.Left,
            TextWrapping.NoWrap,
            new Size(10000, 10000));

        return new Size(formattedText.Bounds.Width, formattedText.Bounds.Height);
    }
    #endregion



    #region PublicProperties
    /// <summary>
    /// Gets or sets the color of the map rectangle.
    /// </summary>
    /// <value>A <see cref="Color"/> that represents the color of the map rectangle.</value>
    public Color MapBorderColor
    {
        get => mapBorderColor;

        set
        {
            if (value != mapBorderColor)
            {
                mapBorderColor = value;
                InvalidateVisual();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the map circle background.
    /// </summary>
    /// <value>The color of the map circle background.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("The color of the map circle background.")]
    public Color MapCircleColor
    {
        get => mapCircleColor;

        set
        {
            if (mapCircleColor != value)
            {
                mapCircleColor = value;
                InvalidateVisual();
            }
        }
    }

    private double magnitudeMinimum = 5.5;

    /// <summary>
    /// Gets or sets the minimum magnitude limit.
    /// </summary>
    /// <value>The minimum magnitude limit.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("The maximum magnitude limit.")]
    public double MagnitudeMinimum
    {
        get => magnitudeMinimum;

        set
        {
            if (Math.Abs(value - magnitudeMinimum) > 0.000000000000001)
            {
                magnitudeMinimum = value;
                InvalidateVisual();
            }
        }
    }

    private double magnitudeMaximum = -500;

    /// <summary>
    /// Gets or sets the maximum magnitude limit.
    /// </summary>
    /// <value>The maximum magnitude limit.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("The maximum magnitude limit.")]
    public double MagnitudeMaximum
    {
        get => magnitudeMaximum;

        set
        {
            if (Math.Abs(value - magnitudeMaximum) > 0.000000000000001)
            {
                magnitudeMaximum = value;
                InvalidateVisual();
            }
        }
    }

    /// <summary>
    /// Gets the star map objects to draw to the map.
    /// </summary>
    /// <value>The star map objects.</value>
    [Browsable(false)]
    public List<StarMapObject> StarMapObjects { get; } = new();

    /// <summary>
    /// Gets or sets the an instance to the <see cref="Plot2D"/> class used for the star map visualization.
    /// </summary>
    /// <value>The <see cref="Plot2D"/> class used for the star map visualization.</value>
    [Browsable(false)]
    public Plot2D Plot2D
    {
        get => plot2D;

        set
        {
            if (plot2D != value)
            {
                plot2D = value;
                plot2D.Diameter = Math.Min(Width, Height);
                CoordinatesChanged?.Invoke(this,
                    new LocationChangedEventArgs { Latitude = plot2D.Latitude, Longitude = plot2D.Longitude });
            }
        }
    }

    private bool invertEastWest;

    /// <summary>
    /// Gets or sets a value indicating whether to invert the star map along east-west axis.
    /// </summary>
    /// <value><c>true</c> if to invert the star map along east-west axis; otherwise, <c>false</c>.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("Value indicating whether to invert the star map along east-west axis")]
    public bool InvertEastWest
    {
        get => invertEastWest;

        set
        {
            if (value != invertEastWest)
            {
                invertEastWest = value;
                InvalidateVisual();
            }
        }
    }

    private bool drawConstellationBoundaries;

    /// <summary>
    /// Gets or sets a value indicating whether to draw constellation boundaries.
    /// </summary>
    /// <value><c>true</c> if to draw constellation boundaries; otherwise, <c>false</c>.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("Value indicating whether to draw constellation boundaries.")]
    public bool DrawConstellationBoundaries
    {
        get => drawConstellationBoundaries;

        set
        {
            if (drawConstellationBoundaries != value)
            {
                drawConstellationBoundaries = value;
                InvalidateVisual();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the constellation border lines.
    /// </summary>
    /// <value>The color of the constellation border lines.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("The color of the constellation border lines.")]
    public Color ConstellationBorderLineColor
    {
        get => constellationBorderLineColor;

        set
        {
            if (constellationBorderLineColor != value)
            {
                constellationBorderLineColor = value;
                InvalidateVisual();
            }
        }
    }

    private bool drawConstellations = true;

    /// <summary>
    /// Gets or sets a value indicating whether to draw constellations.
    /// </summary>
    /// <value><c>true</c> if to draw constellations; otherwise, <c>false</c>.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("Value indicating whether to draw constellations.")]
    public bool DrawConstellations
    {
        get => drawConstellations;

        set
        {
            if (drawConstellations != value)
            {
                drawConstellations = value;
                InvalidateVisual();
            }
        }
    }

    private bool drawConstellationLabels = true;

    /// <summary>
    /// Gets or sets a value indicating whether to draw constellation labels.
    /// </summary>
    /// <value><c>true</c> if to draw constellation labels; otherwise, <c>false</c>.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("Value indicating whether to draw constellation labels.")]
    public bool DrawConstellationNames
    {
        get => drawConstellationLabels;

        set
        {
            if (drawConstellationLabels != value)
            {
                drawConstellationLabels = value;
                InvalidateVisual();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the constellation lines.
    /// </summary>
    /// <value>The color of the constellation lines.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("The color of the constellation lines.")]
    public Color ConstellationLineColor
    {
        get => constellationLineColor;

        set
        {
            if (constellationLineColor != value)
            {
                constellationLineColor = value;
                InvalidateVisual();
            }
        }
    }

    private Color mapLabelColor = Colors.DeepPink;

    /// <summary>
    /// Gets or sets the color of the labels in the map view (constellations, etc).
    /// </summary>
    /// <value>The color of the labels in the map view.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("The color of the labels in the map view.")]
    public Color MapLabelColor
    {
        get => mapLabelColor;

        set
        {
            if (mapLabelColor != value)
            {
                mapLabelColor = value;
                InvalidateVisual();
            }
        }
    }

    private string? locale;

    /// <summary>
    /// Gets or sets the locale for the constellation names.
    /// </summary>
    /// <value>The locale for the constellation names.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("The locale for the constellation names.")]
    public string Locale
    {
        get => locale ?? CultureInfo.CurrentCulture.ToString();

        set
        {
            if (locale != value)
            {
                try
                {
                    locale = new CultureInfo(value).ToString();
                    InvalidateVisual();
                }
                catch
                {
                    // Erroneous culture.
                }
            }
        }
    }

    #endregion

    #region EventDelegates

    /// <summary>
    /// Delegate OnCoordinatesChanged
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="LocationChangedEventArgs"/> instance containing the event data.</param>
    public delegate void OnCoordinatesChanged(object? sender, LocationChangedEventArgs e);

    #endregion

    #region Events

    /// <summary>
    /// Occurs when the latitude or the longitude coordinates changed.
    /// </summary>
    [Browsable(true)]
    [Description("Occurs when the latitude or the longitude coordinates changed.")]
    public event OnCoordinatesChanged? CoordinatesChanged;

    #endregion

    private void Visual_OnAttachedToVisualTree(object? sender, VisualTreeAttachmentEventArgs e)
    {
        plot2D.Diameter = Diameter;
    }
}