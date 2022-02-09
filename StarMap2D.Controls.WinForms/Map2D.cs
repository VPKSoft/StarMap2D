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

using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using AASharp;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.Plotting;
using StarMap2D.Controls.WinForms.Drawing;
using StarMap2D.Controls.WinForms.EventArguments;
using StarMap2D.Controls.WinForms.Utilities;
using VPKSoft.StarCatalogs;

namespace StarMap2D.Controls.WinForms;

/// <summary>
/// A Windows Forms user control to draw a 3D star map.
/// Implements the <see cref="System.Windows.Forms.UserControl" />
/// </summary>
/// <seealso cref="System.Windows.Forms.UserControl" />
public partial class Map2D : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Map2D"/> class.
    /// </summary>
    public Map2D()
    {
        InitializeComponent();
        base.Margin = new Padding(0);
        mapBrush = new SolidBrush(mapCircleColor);
        backgroundBrush = new SolidBrush(BackColor);
        constellationLinePen = new Pen(constellationLineColor);
        constellationBorderPen = new Pen(constellationBorderLineColor);
        crossHairPen = new Pen(crossHairColor);
        textBrush = new SolidBrush(ForeColor);
        base.DoubleBuffered = true;
        constellationNames.GetLocalizedTexts(Properties.Resources.Constellations);
        DrawMapImage();
        HandleCreated += Map2D_NeedsRepaint;
        base.BackgroundImageLayout = ImageLayout.None;
        foreach (var constellationClassEnumMap in ConstellationClassEnumMap.ConstellationClassesEnums)
        {
            var constellation = Activator.CreateInstance(constellationClassEnumMap.ConstellationClassType);
            constellations.Add((IConstellation<ConstellationArea, ConstellationLine>)constellation!);
        }

        MouseWheel += Map2D_MouseWheel;
    }

    private void Map2D_MouseWheel(object? sender, MouseEventArgs e)
    {
        if (ModifierKeys.HasFlag(Keys.Control))
        {
            if (e.Delta < 0)
            {
                if (Zoom - 0.1 >= 1)
                {
                    Zoom -= 0.1;
                }
            }
            else if (e.Delta > 0)
            {
                Zoom += 0.1;
            }
        }
    }

    #region EventDelegates        
    /// <summary>
    /// Delegate OnCoordinatesChanged
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="LocationChangedEventArgs"/> instance containing the event data.</param>
    public delegate void OnCoordinatesChanged(object? sender, LocationChangedEventArgs e);

    /// <summary>
    /// A delegate for an event when the horizontal or ecliptic coordinates change on mouse position change.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="CoordinatesChangedEventArgs"/> instance containing the event data.</param>
    public delegate void OnMouseCoordinatesChanged(object? sender, CoordinatesChangedEventArgs e);

    /// <summary>
    /// Delegate OnObjectUserInteraction.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="NamedObjectEventArgs"/> instance containing the event data.</param>
    public delegate void OnObjectUserInteraction(object sender, NamedObjectEventArgs e);
    // TODO::!!
    #endregion

    #region Events        
    /// <summary>
    /// Occurs when the latitude or the longitude coordinates changed.
    /// </summary>
    [Category("StarMap2D")]
    [Browsable(true)]
    [Description("Occurs when the latitude or the longitude coordinates changed.")]
    public event OnCoordinatesChanged? CoordinatesChanged;

    /// <summary>
    /// Occurs when horizontal or ecliptic coordinates change on mouse move.
    /// </summary>
    [Category("StarMap2D")]
    [Browsable(true)]
    [Description("Occurs when horizontal or ecliptic coordinates change on mouse move.")]
    public event OnMouseCoordinatesChanged? MouseCoordinatesChanged;

    /// <summary>
    /// Occurs when mouse hovers over a named object.
    /// </summary>
    [Browsable(true)]
    [Category("StarMap2D")]
    [Description("Occurs when mouse hovers over a named object.")]
    public event OnObjectUserInteraction? MouseHoverObject;


    /// <summary>
    /// Occurs when mouse leaves the hovered object.
    /// </summary>
    [Browsable(true)]
    [Category("StarMap2D")]
    [Description("Occurs when mouse leaves the hovered object.")]
    public event OnObjectUserInteraction? MouseLeaveObject;

    /// <summary>
    /// Occurs when the object is clicked via mouse.
    /// </summary>
    [Browsable(true)]
    [Category("StarMap2D")]
    [Description("Occurs when the object is clicked via mouse.")]
    public event OnObjectUserInteraction? MouseClickObject;

    /// <summary>
    /// Occurs when the object is double-clicked via mouse.
    /// </summary>
    [Browsable(true)]
    [Category("StarMap2D")]
    [Description("Occurs when the object is double-clicked via mouse.")]
    public event OnObjectUserInteraction? MouseDoubleClickObject;
    #endregion

    #region PrivateFields
    TabDeliLocalization constellationNames = new ();
    private Color mapCircleColor = Color.Black;
    private Color constellationLineColor = Color.DeepSkyBlue;
    private Color constellationBorderLineColor = Color.FromArgb(13, 23, 125);
    private Color backColor = Color.FromArgb(39, 39, 39);
    private Pen constellationLinePen;
    private Pen crossHairPen;
    private Pen constellationBorderPen;
    private SolidBrush mapBrush;
    private SolidBrush backgroundBrush;
    private Bitmap? previousBitmap;
    private Plot2D? plot2D;
    private readonly List<IConstellation<ConstellationArea, ConstellationLine>> constellations = new();
    private int[] starSizes = Array.Empty<int>();
    private Color[] starColors = Array.Empty<Color>();
    private string? locale;
    private readonly List<MapObjectMetadata> objectMetadata = new();
    #endregion

    #region PrivateProperties
    private Rectangle DrawArea
    {
        get
        {
            Rectangle drawArea;

            if (Width > Height)
            {
                drawArea = new Rectangle((Width - Height) / 2, 0, Height - 1, Height - 1);
            }
            else
            {
                drawArea = new Rectangle(0, (Height - Width) / 2, Width - 1, Width - 1);
            }

            return drawArea;
        }
    }

    private int OffsetX => Width > Height ? (Width - Height) / 2 : 0;

    private int OffsetY => Height > Width ? (Height - Width) / 2 : 0;

    private double CenterX => OffsetX + (double)Width / 2;
    
    private double CenterY => OffsetY + (double)Height / 2;

    private double Diameter => Math.Min(Width, Height);
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
        var starColor = Color.White;

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

    private Point GetDrawPoint(Image image, AAS2DCoordinate centerPoint)
    {
        return new Point((int)centerPoint.X - image.Width / 2 + OffsetX, (int)centerPoint.Y - image.Height / 2 + OffsetY);
    }

    /// <summary>
    /// Draws the actual star map image.
    /// </summary>
    private void DrawMapImage()
    {
        var bitmap = new Bitmap(Size.Width, Size.Height);
        using var graphics = Graphics.FromImage(bitmap);

        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        var rectangle = new Rectangle(Point.Empty, bitmap.Size);

        graphics.FillRectangle(backgroundBrush, rectangle);
        graphics.FillEllipse(mapBrush, DrawArea);

        // Create graphics path.
        using var clipPath = new GraphicsPath();
        clipPath.AddEllipse(DrawArea);

        graphics.SetClip(clipPath, CombineMode.Replace);

        var previousMagnitude = -11;
        var drawArguments = GetStarDrawArguments(-11);

        objectMetadata.Clear();

        if (Plot2D != null)
        {
            foreach (var starMapObject in StarMapObjects)
            {
                if (!(starMapObject.Magnitude < magnitudeMinimum && starMapObject.Magnitude > magnitudeMaximum) || starMapObject.SkipObject)
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

                    if (starMapObject.ObjectType == ObjectsWithPositions.Moon)
                    {

                    }

                    if (position != null)
                    {
                        var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter, starMapObject.Magnitude);
                        if (image != null)
                        {
                            graphics.DrawImage(image, GetDrawPoint(image, position));
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
                        { X = starMapObject.RightAscension % 360, Y = starMapObject.Declination }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                    var pointD = Plot2D.Project2D(coordinate, invertEastWest);

                    var location = new Point((int)pointD.X, (int)pointD.Y);

                    var drawPoint = new Point(location.X + OffsetX, location.Y + OffsetY);

                    var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter, starMapObject.Magnitude);
                    if (image != null)
                    {
                        drawPoint.X -= image.Width / 2;
                        drawPoint.Y -= image.Height / 2;
                        graphics.DrawImage(image, drawPoint);
                        continue;
                    }

                    if ((int)starMapObject.Magnitude != previousMagnitude)
                    {
                        drawArguments = GetStarDrawArguments(starMapObject.Magnitude);
                        previousMagnitude = (int)starMapObject.Magnitude;
                    }

                    graphics.DrawStar(drawPoint, drawArguments.starSize, drawArguments.starColor);
                }
            }

            foreach (var constellation in constellations)
            {
                DrawConstellationBoundary(constellation, graphics);
                DrawConstellation(constellation, graphics);
            }
        }

        DrawCrossHairFigure(graphics);

        BackgroundImage = bitmap;
        previousBitmap?.Dispose();
        previousBitmap = bitmap;
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
        var r = (double)Math.Min(Width, Height);
        return Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2)) <= r;
    }

    /// <summary>
    /// Draws the cross hair figure onm the map.
    /// </summary>
    /// <param name="graphics">The graphics to draw the cross hair figure on.</param>
    private void DrawCrossHairFigure(Graphics graphics)
    {
        if (drawCrossHair)
        {
            var point1 = new Point(Size.Width / 2 - crossHairSize, Size.Height / 2);
            var point2 = new Point(Size.Width / 2 + crossHairSize, Size.Height / 2);
            graphics.DrawLine(crossHairPen, point1, point2);
            point1 = new Point(Size.Width / 2, Size.Height / 2 - crossHairSize);
            point2 = new Point(Size.Width / 2, Size.Height / 2 + crossHairSize);
            graphics.DrawLine(crossHairPen, point1, point2);
        }
    }

    /// <summary>
    /// Draws the specified constellation boundary on a specified graphics.
    /// </summary>
    /// <param name="constellation">The constellation instance which boundary to draw.</param>
    /// <param name="graphics">The graphics to draw the constellation boundary on.</param>
    private void DrawConstellationBoundary(IConstellation<ConstellationArea, ConstellationLine> constellation, Graphics graphics)
    {
        if (Plot2D == null || !DrawConstellationBoundaries)
        {
            return;
        }

        for (var i = 0; i < constellation.Boundary.Count - 1; i++)
        {
            var point1 = new AAS2DCoordinate
                { X = constellation.Boundary[i].RightAscension % 360, Y = constellation.Boundary[i].Declination }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            var point2 = new AAS2DCoordinate
                { X = constellation.Boundary[i + 1].RightAscension % 360, Y = constellation.Boundary[i + 1].Declination }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

            var pointD1 = Plot2D.Project2D(point1, invertEastWest);
            var pointD2 = Plot2D.Project2D(point2, invertEastWest);

            var drawPoint1 = new Point((int)pointD1.X + OffsetX, (int)pointD1.Y + OffsetY);
            var drawPoint2 = new Point((int)pointD2.X + OffsetX, (int)pointD2.Y + OffsetY);

            if (!ValidDrawPoint(drawPoint1) && !ValidDrawPoint(drawPoint2))
            {
                continue;
            }

            graphics.DrawLine(constellationBorderPen, drawPoint1, drawPoint2);
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

            graphics.DrawLine(constellationLinePen, drawPoint1, drawPoint2);
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

            var measureSize = graphics.MeasureString(name, Font);

            var drawPoint = new Point((int)labelPoint.X + OffsetX - (int)measureSize.Width / 2,
                (int)labelPoint.Y + OffsetY - (int)measureSize.Height / 2);

            graphics.DrawString(name, Font, textBrush, drawPoint);
        }
    }


    #endregion

    /// <summary>
    /// Gets or sets the space between controls.
    /// </summary>
    /// <value>A <see cref="Padding"/> representing the space between controls.</value>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new Padding Margin { get => base.Margin; set => base.Margin = value; }

    /// <summary>
    /// Gets or sets padding within the control.
    /// </summary>
    /// <value>A <see cref="Padding"/> representing the control's internal spacing characteristics.</value>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new Padding Padding { get => base.Padding; set => base.Padding = value; }

#pragma warning disable CS1574, CS1584, CS1581, CS1580
    /// <summary>
    /// Gets or sets the border style of the user control.
    /// </summary>
    /// <value>One of the <see cref="BorderStyle"/> values. The default is <see cref="BorderStyle.Fixed3D"/>.</value>
#pragma warning restore CS1574, CS1584, CS1581, CS1580
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new BorderStyle BorderStyle
    {
        get => base.BorderStyle;
        set => base.BorderStyle = value;
    }

    /// <inheritdoc cref="Plot2D.Latitude"/>
    public double Latitude
    {
        get => plot2D?.Latitude ?? 0;

        set
        {
            if (plot2D != null)
            {
                plot2D.Latitude = value;
                DrawMapImage();
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
                DrawMapImage();
            }
        }
    }

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
                    DrawMapImage();
                }
                catch
                {
                    // Erroneous culture.
                }
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
                DrawMapImage();
            }
        }
    }

    private SolidBrush textBrush;

    /// <summary>
    /// Gets or sets the foreground color of the control.
    /// </summary>
    /// <value>The foreground color of the control.</value>
    [Category("Appearance")]
    [Description("The foreground color of the control, which is used to display text.")]
    [Browsable(true)]
    public new Color ForeColor
    {
        get => base.ForeColor;

        set
        {
            if (value != base.ForeColor)
            {
                textBrush.Dispose();
                textBrush = new SolidBrush(value);
                base.ForeColor = value;
                DrawMapImage();
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
                DrawMapImage();
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
                DrawMapImage();
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
                DrawMapImage();
            }
        }
    }

    private bool skipCalculatedObjects;

    /// <summary>
    /// Gets or sets a value indicating whether skip calculated objects (i.e. the Sun and the Moon).
    /// </summary>
    /// <value><c>true</c> if to skip calculated objects; otherwise, <c>false</c>.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("Value indicating whether to skip calculated objects.")]
    public bool SkipCalculatedObjects
    {
        get => skipCalculatedObjects;

        set
        {
            if (skipCalculatedObjects != value)
            {
                skipCalculatedObjects = value;
                DrawMapImage();
            }
        }
    }
    
    /// <summary>
    /// Gets or sets the star sizes for different magnitudes from -10 to 10.
    /// </summary>
    /// <value>The star sizes for different magnitudes.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("he star sizes for different magnitudes.")]
    public int[] StarSizes
    {
        get => starSizes;

        set
        {
            if (value.Length != starSizes.Length)
            {
                starSizes = value;
                DrawMapImage();
                return;
            }

            var changes = starSizes.Where((t, i) => t != value[i]).Any();

            if (changes)
            {
                starSizes = value;
                DrawMapImage();
            }
        }
    }

    /// <summary>
    /// Gets or sets the star colors for different magnitudes from -10 to 10.
    /// </summary>
    /// <value>The star colors different magnitudes.</value>
    public Color[] StarColors
    {
        get => starColors;

        set
        {
            if (value.Length != starSizes.Length)
            {
                starColors = value;
                DrawMapImage();
                return;
            }

            var changes = starColors.Where((t, i) => t != starColors[i]).Any();

            if (changes)
            {
                starColors = value;
                DrawMapImage();
            }
        }
    }

    private bool drawCrossHair = true;

    /// <summary>
    /// Gets or sets a value indicating whether to draw cross hair on the center of the map area.
    /// </summary>
    /// <value><c>true</c> if draw cross hair to the center; otherwise, <c>false</c>.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("A value indicating whether to draw cross hair on the center of the map area.")]
    public bool DrawCrossHair
    {
        get => drawCrossHair;

        set
        {
            if (drawCrossHair != value)
            {
                drawCrossHair = value;
                DrawMapImage();
            }
        }
    }

    private int crossHairSize = 20;

    /// <summary>
    /// Gets or sets the size of the cross hair.
    /// </summary>
    /// <value>The size of the cross hair.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("The size of the cross hair.")]
    public int CrossHairSize
    {
        get => crossHairSize;

        set
        {
            if (value != crossHairSize)
            {
                crossHairSize = value;
                DrawMapImage();
            }
        }
    }

    private Color crossHairColor = Color.LimeGreen;

    /// <summary>
    /// Gets or sets the color of the constellation lines.
    /// </summary>
    /// <value>The color of the constellation lines.</value>
    [Browsable(true)]
    [Category("Appearance")]
    [Description("The color of the constellation lines.")]
    public Color CrossHairColor
    {
        get => crossHairColor;

        set
        {
            if (crossHairColor != value)
            {
                crossHairPen.Dispose();
                crossHairColor = value;
                crossHairPen = new Pen(value);
                DrawMapImage();
            }
        }
    }

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
                mapBrush.Dispose();
                mapCircleColor = value;
                mapBrush = new SolidBrush(value);
                DrawMapImage();
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
                constellationLinePen.Dispose();
                constellationLineColor = value;
                constellationLinePen = new Pen(value);
                DrawMapImage();
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
                constellationBorderPen.Dispose();
                constellationBorderLineColor = value;
                constellationBorderPen = new Pen(value);
                DrawMapImage();
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
                DrawMapImage();
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
                DrawMapImage();
            }
        }
    }

    /// <summary>
    /// Gets or sets the background color for the control.
    /// </summary>
    /// <value>A <see cref="Color"/> that represents the background color of the control. The default is the value of the <see cref="Control.DefaultBackColor"/>  property.</value>
    public new Color BackColor
    {
        get => backColor;

        set
        {
            if (value != backColor)
            {
                backColor = value;
                backgroundBrush.Dispose();
                backgroundBrush = new SolidBrush(value);
                DrawMapImage();
            }
        }
    }

    /// <summary>
    /// Gets or sets the current time in UTC.
    /// </summary>
    /// <value>The current time in UTC.</value>
    public DateTime CurrentTimeUtc
    {
        get => Plot2D?.DateTimeUtc ?? DateTime.UtcNow;

        set
        {
            if (Plot2D != null)
            {
                if (Plot2D.DateTimeUtc != value)
                {
                    // Convert to UTC if the kind differs.
                    var newValue = value;
                    if (newValue.Kind != DateTimeKind.Utc)
                    {
                        newValue = new DateTime(newValue.Year, newValue.Month, newValue.Day, newValue.Hour,
                            newValue.Minute, newValue.Second, DateTimeKind.Utc);
                    }

                    Plot2D.DateTimeUtc = newValue;
                    DrawMapImage();
                }
            }
        }
    }

    private double zoom = 1;

    /// <summary>
    /// Gets or sets the zoom value of the sky map area.
    /// </summary>
    /// <value>The zoom.</value>
    [Browsable(true)]
    [Category("Behaviour")]
    [Description("A zoom value of the sky map area.")]
    public double Zoom
    {
        get => zoom;

        set
        {
            if (zoom != value)
            {
                zoom = value;
                if (plot2D != null)
                {
                    plot2D.Zoom = value;
                }
                DrawMapImage();
            }
        }
    }

    /// <summary>
    /// Gets the star map objects to draw to the map.
    /// </summary>
    /// <value>The star map objects.</value>
    public List<StarMapObject> StarMapObjects { get; } = new();

    /// <summary>
    /// Gets or sets the an instance to the <see cref="Plot2D"/> class used for the star map visualization.
    /// </summary>
    /// <value>The <see cref="Plot2D"/> class used for the star map visualization.</value>
    [Browsable(false)]
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
                    CoordinatesChanged?.Invoke(this, new LocationChangedEventArgs { Latitude = plot2D.Latitude, Longitude = plot2D.Longitude});
                }
            }
        }
    }

    #region InternalEvents
    private void Map2D_NeedsRepaint(object? sender, EventArgs e)
    {
        if (plot2D != null)
        {
            plot2D.Diameter = Math.Min(Width, Height);
            DrawMapImage();
        }
    }

    private bool mouseDown;
    private Point mousePoint;

    private void Map2D_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button.HasFlag(MouseButtons.Right))
        {
            mouseDown = true;
            Cursor = Cursors.NoMove2D;
            mousePoint = e.Location;
        }
    }

    private void Map2D_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button.HasFlag(MouseButtons.Right))
        {
            Cursor = Cursors.Default;
            mouseDown = false;
        }
    }

    private void Map2D_MouseLeave(object sender, EventArgs e)
    {
        Cursor = Cursors.Default;
        mouseDown = false;
    }

    private MapObjectMetadata? metadata;

    private Point previousMousePoint = Point.Empty;

    private void Map2D_MouseMove(object sender, MouseEventArgs e)
    {
        if (mouseDown && e.Button.HasFlag(MouseButtons.Right))
        {
            var newPoint = e.Location;
            var xChange = (mousePoint.X - newPoint.X) / 10.0;
            var yChange = (mousePoint.Y - newPoint.Y) / 10.0;

            if (Plot2D != null)
            {
                if (!Plot2D.Zoomed && !Plot2D.CanPanBy(xChange, yChange))
                {
                    var latitude = Plot2D.Latitude - yChange;
                    var longitude = Plot2D.Longitude - xChange;
                    if (latitude > 90)
                    {
                        latitude = 90;
                    }

                    if (latitude < -90)
                    {
                        latitude = -90;
                    }

                    if (longitude > 180)
                    {
                        longitude = -180;
                    }

                    if (longitude < -180)
                    {
                        longitude = 180;
                    }

                    if (latitude != Plot2D.Latitude || longitude != Plot2D.Longitude)
                    {
                        Plot2D.Latitude = latitude;
                        Plot2D.Longitude = longitude;

                        mousePoint = newPoint;
                        DrawMapImage();
                        CoordinatesChanged?.Invoke(this,
                            new LocationChangedEventArgs { Latitude = latitude, Longitude = longitude });
                    }
                }
                else if (Plot2D.CanPanBy(-xChange, -yChange))
                {
                    Plot2D.ZoomPanPointX += xChange;
                    Plot2D.ZoomPanPointY += yChange;
                    DrawMapImage();
                    mousePoint = newPoint;
                }
            }
        }
        else
        {
            if (previousMousePoint != e.Location)
            {
                var drawPoint = new Point(e.X - OffsetX, e.Y - OffsetY);

                if (Circle.PointIsInside(CenterX, CenterY, Diameter / 2, OffsetX + e.X, OffsetY + e.Y))
                {

                    var point = plot2D?.Invert2DProjection(new AAS2DCoordinate { X = drawPoint.X, Y = drawPoint.Y },
                        invertEastWest);

                    if (point != null && plot2D != null)
                    {
                        var pointRaDec = Coordinates.AltitudeAzimuthToRightAscensionDeclination(point.Y, point.X,
                            Latitude, Longitude, plot2D.DateTimeUtc);
                        MouseCoordinatesChanged?.Invoke(this,
                            new CoordinatesChangedEventArgs
                            {
                                Altitude = point.X,
                                Azimuth = point.Y,
                                RightAscension = pointRaDec.X,
                                Declination = pointRaDec.Y,
                                X = e.X, Y = e.Y,
                            });
                    }
                }
                previousMousePoint = e.Location;
            }

            var newMetadata = objectMetadata.FirstOrDefault(f => Circle.PointIsInside(f.X, f.Y, f.Radius, e.X, e.Y));
            if (newMetadata != null)
            {
                MouseHoverObject?.Invoke(this,
                    new NamedObjectEventArgs { Identifier = newMetadata.Identifier, Name = newMetadata.Name });
            }
            else if (newMetadata == null && metadata != null)
            {
                MouseLeaveObject?.Invoke(this, new NamedObjectEventArgs { Identifier = metadata.Identifier, Name = metadata.Name });
            }

            metadata = newMetadata;
        }
    }

    private void Map2D_MouseClick(object sender, MouseEventArgs e)
    {
        if (metadata != null)
        {
            MouseClickObject?.Invoke(this, new NamedObjectEventArgs { Identifier = metadata.Identifier, Name = metadata.Name });
        }
    }

    private void Map2D_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (metadata != null)
        {
            MouseDoubleClickObject?.Invoke(this, new NamedObjectEventArgs { Identifier = metadata.Identifier, Name = metadata.Name });
        }
    }
    #endregion
}