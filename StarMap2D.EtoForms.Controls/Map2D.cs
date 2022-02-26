using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AASharp;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Helpers.DateAndTime;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.Plotting;
using StarMap2D.Common.EventsAndDelegates;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.Drawing;
using StarMap2D.EtoForms.Controls.Utilities;
using VPKSoft.StarCatalogs;

namespace StarMap2D.EtoForms.Controls
{
    /// <summary>
    /// A <see cref="Control"/> to display a 2D sky map.
    /// Implements the <see cref="Eto.Forms.Drawable" />
    /// </summary>
    /// <seealso cref="Eto.Forms.Drawable" />
    public class Map2D : Drawable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Map2D"/> class.
        /// </summary>
        public Map2D()
        {
            Paint += Map2D_Paint;

            foreach (var constellationClassEnumMap in ConstellationClassEnumMap.ConstellationClassesEnums)
            {
                var constellation = Activator.CreateInstance(constellationClassEnumMap.ConstellationClassType);
                constellations.Add((IConstellation<ConstellationArea, ConstellationLine>)constellation!);
            }

            constellationNames.GetLocalizedTexts(Common.Properties.Resources.Constellations);

            SizeChanged += Map2D_SizeChanged;
        }

        private void Map2D_SizeChanged(object? sender, EventArgs e)
        {
            plot2D!.Diameter = Diameter;
            Invalidate();
        }

        #region Events

        /// <summary>
        /// Occurs when the latitude or the longitude coordinates changed.
        /// </summary>
        public event MapInteractionDelegates.OnCoordinatesChanged? CoordinatesChanged;

        /// <summary>
        /// Occurs when horizontal or ecliptic coordinates change on mouse move.
        /// </summary>
        public event MapInteractionDelegates.OnMouseCoordinatesChanged? MouseCoordinatesChanged;

        /// <summary>
        /// Occurs when mouse hovers over a named object.
        /// </summary>
        public event MapInteractionDelegates.OnObjectUserInteraction? MouseHoverObject;


        /// <summary>
        /// Occurs when mouse leaves the hovered object.
        /// </summary>
        public event MapInteractionDelegates.OnObjectUserInteraction? MouseLeaveObject;

        /// <summary>
        /// Occurs when the object is clicked via mouse.
        /// </summary>
        public event MapInteractionDelegates.OnObjectUserInteraction? MouseClickObject;

        /// <summary>
        /// Occurs when the object is double-clicked via mouse.
        /// </summary>
        public event MapInteractionDelegates.OnObjectUserInteraction? MouseDoubleClickObject;

        #endregion

        #region PrivateFields
        TabDeliLocalization constellationNames = new();
        private readonly List<MapObjectMetadata> objectMetadata = new();
        private readonly List<IConstellation<ConstellationArea, ConstellationLine>> constellations = new();
        #endregion

        #region PublicProperties        
        /// <summary>
        /// Gets the sidereal time.
        /// </summary>
        /// <value>The sidereal time.</value>
        public double SiderealTime => DateTimeUtc.ToLocalSiderealTime(Longitude);

        /// <inheritdoc cref="Plot2D.Latitude"/>
        public double Latitude
        {
            get => plot2D?.Latitude ?? 0;

            set
            {
                if (plot2D != null)
                {
                    plot2D.Latitude = value;
                    Invalidate();
                }
            }
        }

        /// <inheritdoc cref="Plot2D.Longitude"/>
        public double Longitude
        {
            get => plot2D?.Longitude ?? 0;

            set
            {
                if (plot2D != null)
                {
                    plot2D.Longitude = value;
                    Invalidate();
                }
            }
        }


        /// <summary>
        /// Gets or sets the nap date and time in UTC.
        /// </summary>
        /// <value>The date time UTC.</value>
        public DateTime DateTimeUtc
        {
            get => plot2D?.DateTimeUtc ?? DateTime.UtcNow;

            set
            {
                if (plot2D != null && plot2D.DateTimeUtc != value)
                {
                    plot2D.DateTimeUtc = value;
                    Invalidate();
                }
            }
        }

        private Color crossHairColor = Colors.LimeGreen;

        /// <summary>
        /// Gets or sets the color of the constellation lines.
        /// </summary>
        /// <value>The color of the constellation lines.</value>
        public Color CrossHairColor
        {
            get => crossHairColor;

            set
            {
                if (crossHairColor != value)
                {
                    crossHairColor = value;
                    Invalidate();
                }
            }
        }

        private Color mapCircleColor = Colors.Black;

        /// <summary>
        /// Gets or sets the color of the map circle background.
        /// </summary>
        /// <value>The color of the map circle background.</value>
        public Color MapCircleColor
        {
            get => mapCircleColor;

            set
            {
                if (mapCircleColor != value)
                {
                    mapCircleColor = value;
                    Invalidate();
                }
            }
        }

        private Color constellationLineColor = Colors.DeepSkyBlue;

        /// <summary>
        /// Gets or sets the color of the constellation lines.
        /// </summary>
        /// <value>The color of the constellation lines.</value>
        public Color ConstellationLineColor
        {
            get => constellationLineColor;

            set
            {
                if (constellationLineColor != value)
                {
                    constellationLineColor = value;
                    Invalidate();
                }
            }
        }

        private Color constellationBorderLineColor = Color.FromArgb(13, 23, 125);

        /// <summary>
        /// Gets or sets the color of the constellation border lines.
        /// </summary>
        /// <value>The color of the constellation border lines.</value>
        public Color ConstellationBorderLineColor
        {
            get => constellationBorderLineColor;

            set
            {
                if (constellationBorderLineColor != value)
                {
                    constellationBorderLineColor = value;
                    Invalidate();
                }
            }
        }

        private Color backColor = Color.FromArgb(39, 39, 39);

        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>A <see cref="Color"/> that represents the background color of the control</value>.
        public Color BackColor
        {
            get => backColor;

            set
            {
                if (value != backColor)
                {
                    backColor = value;
                    Invalidate();
                }
            }
        }

        private Plot2D? plot2D;

        /// <summary>
        /// Gets or sets the an instance to the <see cref="Plot2D"/> class used for the star map visualization.
        /// </summary>
        /// <value>The <see cref="Plot2D"/> class used for the star map visualization.</value>
        public Plot2D? Plot2D
        {
            get => plot2D;

            set
            {
                if (plot2D != value)
                {
                    plot2D = value;
                    if (plot2D != null)
                    {
                        plot2D.Diameter = Math.Min(Width, Height);
                        CoordinatesChanged?.Invoke(this,
                            new LocationChangedEventArgs { Latitude = plot2D.Latitude, Longitude = plot2D.Longitude });
                    }
                }
            }
        }

        /// <summary>
        /// Gets the star map objects to draw to the map.
        /// </summary>
        /// <value>The star map objects.</value>
        public List<StarMapObject> StarMapObjects { get; } = new();

        private double magnitudeMaximum = -500;

        /// <summary>
        /// Gets or sets the maximum magnitude limit.
        /// </summary>
        /// <value>The maximum magnitude limit.</value>
        public double MagnitudeMaximum
        {
            get => magnitudeMaximum;

            set
            {
                if (Math.Abs(value - magnitudeMaximum) > 0.000000000000001)
                {
                    magnitudeMaximum = value;
                    Invalidate();
                }
            }
        }

        private double magnitudeMinimum = 5.5;

        /// <summary>
        /// Gets or sets the minimum magnitude limit.
        /// </summary>
        /// <value>The minimum magnitude limit.</value>

        public double MagnitudeMinimum
        {
            get => magnitudeMinimum;

            set
            {
                if (Math.Abs(value - magnitudeMinimum) > 0.000000000000001)
                {
                    magnitudeMinimum = value;
                    Invalidate();
                }
            }
        }

        private bool skipCalculatedObjects;

        /// <summary>
        /// Gets or sets a value indicating whether skip calculated objects (i.e. the Sun and the Moon).
        /// </summary>
        /// <value><c>true</c> if to skip calculated objects; otherwise, <c>false</c>.</value>
        public bool SkipCalculatedObjects
        {
            get => skipCalculatedObjects;

            set
            {
                if (skipCalculatedObjects != value)
                {
                    skipCalculatedObjects = value;
                    Invalidate();
                }
            }
        }

        private bool invertEastWest;

        /// <summary>
        /// Gets or sets a value indicating whether to invert the star map along east-west axis.
        /// </summary>
        /// <value><c>true</c> if to invert the star map along east-west axis; otherwise, <c>false</c>.</value>
        public bool InvertEastWest
        {
            get => invertEastWest;

            set
            {
                if (value != invertEastWest)
                {
                    invertEastWest = value;
                    Invalidate();
                }
            }
        }

        private bool drawConstellations = true;

        /// <summary>
        /// Gets or sets a value indicating whether to draw constellations.
        /// </summary>
        /// <value><c>true</c> if to draw constellations; otherwise, <c>false</c>.</value>
        public bool DrawConstellations
        {
            get => drawConstellations;

            set
            {
                if (drawConstellations != value)
                {
                    drawConstellations = value;
                    Invalidate();
                }
            }
        }

        private bool drawConstellationLabels = true;

        /// <summary>
        /// Gets or sets a value indicating whether to draw constellation labels.
        /// </summary>
        /// <value><c>true</c> if to draw constellation labels; otherwise, <c>false</c>.</value>
        public bool DrawConstellationNames
        {
            get => drawConstellationLabels;

            set
            {
                if (drawConstellationLabels != value)
                {
                    drawConstellationLabels = value;
                    Invalidate();
                }
            }
        }

        private bool drawConstellationBoundaries;

        /// <summary>
        /// Gets or sets a value indicating whether to draw constellation boundaries.
        /// </summary>
        /// <value><c>true</c> if to draw constellation boundaries; otherwise, <c>false</c>.</value>
        public bool DrawConstellationBoundaries
        {
            get => drawConstellationBoundaries;

            set
            {
                if (drawConstellationBoundaries != value)
                {
                    drawConstellationBoundaries = value;
                    Invalidate();
                }
            }
        }

        private string? locale;

        /// <summary>
        /// Gets or sets the locale for the constellation names.
        /// </summary>
        /// <value>The locale for the constellation names.</value>
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
                        Invalidate();
                    }
                    catch
                    {
                        // Erroneous culture.
                    }
                }
            }
        }

        private Font font = new("Cabin", 9);

        /// <summary>
        /// Gets or sets the font to draw labels to the map.
        /// </summary>
        public Font Font
        {
            get => font;

            set
            {
                if (!Equals(value, font))
                {
                    font = value;
                    Invalidate();
                }
            }
        }

        private Color foreColor = Color.FromArgb(231, 23, 180);

        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        /// <value>The foreground color of the control.</value>
        public Color ForeColor
        {
            get => foreColor;

            set
            {
                if (value != foreColor)
                {
                    foreColor = value;
                    Invalidate();
                }
            }
        }

        private bool drawCrossHair = true;

        /// <summary>
        /// Gets or sets a value indicating whether to draw cross hair on the center of the map area.
        /// </summary>
        /// <value><c>true</c> if draw cross hair to the center; otherwise, <c>false</c>.</value>
        public bool DrawCrossHair
        {
            get => drawCrossHair;

            set
            {
                if (drawCrossHair != value)
                {
                    drawCrossHair = value;
                    Invalidate();
                }
            }
        }

        private int crossHairSize = 20;

        /// <summary>
        /// Gets or sets the size of the cross hair.
        /// </summary>
        /// <value>The size of the cross hair.</value>
        public int CrossHairSize
        {
            get => crossHairSize;

            set
            {
                if (value != crossHairSize)
                {
                    crossHairSize = value;
                    Invalidate();
                }
            }
        }
        #endregion

        #region PrivateProperties
        private RectangleF DrawArea
        {
            get
            {
                RectangleF drawArea;

                if (Width > Height)
                {
                    drawArea = new RectangleF((Width - Height) / 2f, 0, Height - 1, Height - 1);
                }
                else
                {
                    drawArea = new RectangleF(0, (Height - Width) / 2f, Width - 1, Width - 1);
                }

                return drawArea;
            }
        }

        private float OffsetX => Width > Height ? (Width - Height) / 2f : 0;

        private float OffsetY => Height > Width ? (Height - Width) / 2f : 0;

        private double CenterX => OffsetX + (double)Width / 2;

        private double CenterY => OffsetY + (double)Height / 2;

        private double Diameter => Math.Min(Width, Height);

        private int[] starSizes = Array.Empty<int>();

        private Color[] starColors = Array.Empty<Color>();

        #endregion

        #region PrivateMethods

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

        private PointF GetTopLeftPoint(RectangleF rectangle)
        {
            var size = Math.Min(rectangle.Width, rectangle.Height);
            return new PointF((rectangle.Width - size) / 2f, (rectangle.Height - size) / 2f);
        }

        private RectangleF GetCenterSquare(RectangleF rectangle)
        {
            var size = Math.Min(rectangle.Width, rectangle.Height);
            return new RectangleF(GetTopLeftPoint(rectangle), new SizeF(size, size));
        }

        private void Map2D_Paint(object? sender, PaintEventArgs e)
        {
            var topLeft = GetTopLeftPoint(e.ClipRectangle);
            var mapRect = GetCenterSquare(e.ClipRectangle);

            using var backgroundBrush = new SolidBrush(backColor);
            e.Graphics.FillRectangle(backgroundBrush, e.ClipRectangle);

            using var circleBrush = new SolidBrush(mapCircleColor);
            e.Graphics.FillEllipse(circleBrush, mapRect);

            using var clipPath = new GraphicsPath();
            clipPath.AddEllipse(mapRect);

            e.Graphics.SetClip(clipPath);

            var previousMagnitude = -11;
            var drawArguments = GetStarDrawArguments(previousMagnitude);

            objectMetadata.Clear();

            if (Plot2D != null)
            {
                foreach (var starMapObject in StarMapObjects)
                {
                    if (!(starMapObject.Magnitude < magnitudeMinimum && starMapObject.Magnitude > magnitudeMaximum) ||
                        starMapObject.SkipObject)
                    {
                        continue;
                    }

                    if (starMapObject.IsLocationCalculated)
                    {
                        if (skipCalculatedObjects)
                        {
                            continue;
                        }

                        var position = starMapObject.CalculatePosition?.Invoke(Plot2D.AaDate, Plot2D.HighPrecision,
                            Plot2D.Latitude, Plot2D.Longitude, Diameter / 2);

                        if (position != null)
                        {
                            var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter,
                                starMapObject.Magnitude);
                            if (image != null)
                            {
                                e.Graphics.DrawImage(image, GetDrawPoint(image, position));
                                if (starMapObject.ObjectName != null)
                                {
                                    objectMetadata.Add(new MapObjectMetadata
                                    {
                                        Name = starMapObject.ObjectName,
                                        X = position.X + OffsetX,
                                        Y = position.Y + OffsetY,
                                        Radius = image.Width / 2.0,
                                        Identifier = starMapObject.Identifier,
                                    });
                                }
                            }
                        }
                    }
                    else
                    {
                        var coordinate = new AAS2DCoordinate
                        { X = starMapObject.RightAscension % 360, Y = starMapObject.Declination }
                            .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                        var pointD = Plot2D.Project2D(coordinate, invertEastWest);

                        var location = new PointF((int)pointD.X, (int)pointD.Y);

                        var drawPoint = new PointF(location.X + OffsetX, location.Y + OffsetY);

                        var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter, starMapObject.Magnitude);
                        if (image != null)
                        {
                            drawPoint.X -= image.Width / 2f;
                            drawPoint.Y -= image.Height / 2f;
                            e.Graphics.DrawImage(image, drawPoint);
                            continue;
                        }

                        if ((int)starMapObject.Magnitude != previousMagnitude)
                        {
                            drawArguments = GetStarDrawArguments(starMapObject.Magnitude);
                            previousMagnitude = (int)starMapObject.Magnitude;
                        }

                        e.Graphics.DrawStar(drawPoint, drawArguments.starSize, drawArguments.starColor);
                    }
                }


                foreach (var constellation in constellations)
                {
                    DrawConstellationBoundary(constellation, e.Graphics);
                    DrawConstellation(constellation, e.Graphics);
                }
            }

            DrawCrossHairFigure(e.Graphics);
        }

        /// <summary>
        /// Draws the specified constellation boundary on a specified graphics.
        /// </summary>
        /// <param name="constellation">The constellation instance which boundary to draw.</param>
        /// <param name="graphics">The graphics to draw the constellation boundary on.</param>
        private void DrawConstellationBoundary(IConstellation<ConstellationArea, ConstellationLine> constellation,
            Graphics graphics)
        {
            if (Plot2D == null || !DrawConstellationBoundaries)
            {
                return;
            }

            using var pen = new Pen(constellationBorderLineColor);

            for (var i = 0; i < constellation.Boundary.Count - 1; i++)
            {
                var point1 = new AAS2DCoordinate
                {
                    X = constellation.Boundary[i].RightAscension % 360,
                    Y = constellation.Boundary[i].Declination
                }
                    .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                var point2 = new AAS2DCoordinate
                {
                    X = constellation.Boundary[i + 1].RightAscension % 360,
                    Y = constellation.Boundary[i + 1].Declination
                }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                var pointD1 = Plot2D.Project2D(point1, invertEastWest);
                var pointD2 = Plot2D.Project2D(point2, invertEastWest);

                var drawPoint1 = new PointF((float)pointD1.X + OffsetX, (float)pointD1.Y + OffsetY);
                var drawPoint2 = new PointF((float)pointD2.X + OffsetX, (float)pointD2.Y + OffsetY);

                if (!ValidDrawPoint(drawPoint1) && !ValidDrawPoint(drawPoint2))
                {
                    continue;
                }


                graphics.DrawLine(pen, drawPoint1, drawPoint2);
            }
        }

        /// <summary>
        /// Draws the specified constellation stick image on a specified graphics.
        /// </summary>
        /// <param name="constellation">The constellation instance which stick image to draw.</param>
        /// <param name="graphics">The graphics to draw the constellation stick image on.</param>
        private void DrawConstellation(IConstellation<ConstellationArea, ConstellationLine> constellation,
            Graphics graphics)
        {
            if (Plot2D == null || !DrawConstellations)
            {
                return;
            }

            using var pen = new Pen(constellationLineColor);
            using var textBrush = new SolidBrush(foreColor);

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

                var drawPoint1 = new PointF((float)pointD1.X + OffsetX, (float)pointD1.Y + OffsetY);
                var drawPoint2 = new PointF((float)pointD2.X + OffsetX, (float)pointD2.Y + OffsetY);

                if (!ValidDrawPoint(drawPoint1) && !ValidDrawPoint(drawPoint2))
                {
                    continue;
                }

                graphics.DrawLine(pen, drawPoint1, drawPoint2);
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

                var measureSize = graphics.MeasureString(Font, name);

                var drawPoint = new PointF((float)labelPoint.X + OffsetX - measureSize.Width / 2,
                    (float)labelPoint.Y + OffsetY - measureSize.Height / 2);


                graphics.DrawText(font, textBrush, drawPoint, name);
            }
        }

        /// <summary>
        /// Draws the cross hair figure onm the map.
        /// </summary>
        /// <param name="graphics">The graphics to draw the cross hair figure on.</param>
        private void DrawCrossHairFigure(Graphics graphics)
        {
            if (drawCrossHair)
            {
                using var pen = new Pen(crossHairColor);

                var point1 = new PointF(Size.Width / 2 - crossHairSize, Size.Height / 2f);
                var point2 = new PointF(Size.Width / 2 + crossHairSize, Size.Height / 2f);
                graphics.DrawLine(pen, point1, point2);
                point1 = new PointF(Size.Width / 2f, Size.Height / 2f - crossHairSize);
                point2 = new PointF(Size.Width / 2f, Size.Height / 2f + crossHairSize);
                graphics.DrawLine(pen, point1, point2);
            }
        }

        /// <inheritdoc cref="ValidDrawPoint(PointDouble)"/>
        private bool ValidDrawPoint(PointF point)
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
            var r = (double)Math.Min(Width, Height);
            return Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2)) <= r;
        }
        private PointF GetDrawPoint(Image image, AAS2DCoordinate centerPoint)
        {
            return new PointF((int)centerPoint.X - image.Width / 2f + OffsetX,
                (int)centerPoint.Y - image.Height / 2f + OffsetY);
        }

        #endregion
    }
}
