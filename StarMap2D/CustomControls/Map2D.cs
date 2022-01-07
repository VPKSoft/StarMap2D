﻿#region License
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
using AASharp;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.Plotting;
using StarMap2D.Drawing;

namespace StarMap2D.CustomControls
{
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
            base.DoubleBuffered = true;
            DrawMapImage();
            base.BackgroundImageLayout = ImageLayout.None;
        }

        #region PrivateFields
        private Color mapCircleColor = Color.Black;
        private SolidBrush mapBrush;
        private SolidBrush backgroundBrush;
        private Bitmap? previousBitmap;
        private Plot2D? plot2D;
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

        private double Diameter => Math.Min(Width, Height);
        #endregion

        #region PrivateMethods
        private Point GetDrawPoint(Image image, PointDouble centerPoint)
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

            if (Plot2D != null)
            {
                foreach (var starMapObject in StarMapObjects)
                {
                    if (starMapObject.IsLocationCalculated)
                    {
                        var position = starMapObject.CalculatePosition?.Invoke(Plot2D.AaDate, Plot2D.HighPrecision,
                            Plot2D.Latitude, Plot2D.Longitude, Diameter / 2);

                        if (position != null)
                        {
                            var image = starMapObject.ObjectGraphics?.GetImage?.Invoke(Diameter, starMapObject.Magnitude);
                            if (image != null)
                            {
                                graphics.DrawImage(image, GetDrawPoint(image, position));
                            }
                        }
                    }
                    else
                    {
                        var pointD = starMapObject.CalculatePosition?.Invoke(Plot2D.AaDate, Plot2D.HighPrecision,
                            Plot2D.Latitude, Plot2D.Longitude, Diameter / 2);

                        var location = Point.Empty;

                        if (pointD != null)
                        {
                            location = new Point((int)pointD.X / 2, (int)pointD.Y / 2);
                            graphics.CreateStar(location, plot2D?.Radius ?? 0, starMapObject.Magnitude, 5);

                            //graphics.FillEllipse(Brushes.White,
                            //    new Rectangle(new Point((int)pointD.X, (int)pointD.Y), new Size(3, 3)));
                            continue;
                        }

                        var coordinate = new AAS2DCoordinate
                            { X = starMapObject.RightAscension % 360, Y = starMapObject.Declination }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                        pointD = Plot2D.Project2D(coordinate);

                        location = new Point((int)pointD.X, (int)pointD.Y);

                        var drawPoint = new Point(location.X + OffsetX, location.Y + OffsetY);

                        graphics.CreateStarSimple(drawPoint, plot2D?.Radius ?? 0, starMapObject.Magnitude, 25, 6);
                        //graphics.FillEllipse(Brushes.White,
                        //    new Rectangle(new Point((int)point.X, (int)point.Y), new Size(3, 3)));
                        
                    }
                }

                var constellation = new Perseus();
                for (int i = 0; i < constellation.Stars.Count - 1; i++)
                {
                    var point1 = new AAS2DCoordinate
                    { X = constellation.Stars[i].RightAscension % 360, Y = constellation.Stars[i].Declination }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                    var point2 = new AAS2DCoordinate
                        { X = constellation.Stars[i + 1].RightAscension % 360, Y = constellation.Stars[i + 1].Declination }.ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                    var pointD1 = Plot2D.Project2D(point1);
                    var pointD2 = Plot2D.Project2D(point2);

                    var drawPoint1 = new Point((int)pointD1.X + OffsetX, (int)pointD1.Y + OffsetY);
                    var drawPoint2 = new Point((int)pointD2.X + OffsetX, (int)pointD2.Y + OffsetY);

                    graphics.DrawLine(Pens.White, drawPoint1, drawPoint2);
                }

                foreach (var orionConstellationLine in constellation.ConstellationLines)
                {
                    var point1 = new AAS2DCoordinate
                            { X = orionConstellationLine.RightAscensionStart % 360, Y = orionConstellationLine.DeclinationStart }
                        .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                    var point2 = new AAS2DCoordinate
                            { X = orionConstellationLine.RightAscensionEnd % 360, Y = orionConstellationLine.DeclinationEnd }
                        .ToHorizontal(Plot2D.AaDate, Plot2D.Latitude, Plot2D.Longitude);

                    var pointD1 = Plot2D.Project2D(point1);
                    var pointD2 = Plot2D.Project2D(point2);

                    var drawPoint1 = new Point((int)pointD1.X + OffsetX, (int)pointD1.Y + OffsetY);
                    var drawPoint2 = new Point((int)pointD2.X + OffsetX, (int)pointD2.Y + OffsetY);

                    graphics.DrawLine(Pens.White, drawPoint1, drawPoint2);
                }
            }

            BackgroundImage = bitmap;
            previousBitmap?.Dispose();
            previousBitmap = bitmap;
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
                    mapBrush = new SolidBrush(mapCircleColor);
                    mapBrush.Dispose();
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
            get => base.BackColor;

            set
            {
                if (value != base.BackColor)
                {
                    base.BackColor = value;
                    backgroundBrush = new SolidBrush(BackColor);
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

        /// <summary>
        /// Gets the star map objects to draw to the map.
        /// </summary>
        /// <value>The star map objects.</value>
        public List<StarMapObject> StarMapObjects { get; } = new ();

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
                        plot2D.Radius = Math.Min(Width, Height);
                    }
                }
            }
        }

        #region InternalEvents
        private void Map2D_NeedsRepaint(object sender, EventArgs e)
        {
            if (plot2D != null)
            {
                plot2D.Radius = Math.Min(Width, Height);
                DrawMapImage();
            }
        }
        #endregion
    }
}
