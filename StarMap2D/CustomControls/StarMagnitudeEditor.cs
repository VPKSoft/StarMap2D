using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace StarMap2D.CustomControls
{
    /// <summary>
    /// A control to specify magnitudes and magnitude colors to be used with the software.
    /// Implements the <see cref="System.Windows.Forms.UserControl" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class StarMagnitudeEditor : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StarMagnitudeEditor"/> class.
        /// </summary>
        public StarMagnitudeEditor()
        {
            InitializeComponent();
            SetSelectedData();
        }

        #region PrivateFields
        private int[] diameters = Array.Empty<int>();

        private Color[] magnitudeColors = Array.Empty<Color>();

        private readonly List<PictureBox> starImageBoxes = new();

        private string starMagnitudes = string.Empty;
        private string starMagnitudeColors = string.Empty;

        private string magnitudeValueFormat = "Selected magnitude: {0}";

        private int selectedMagnitude = int.MaxValue;

        private readonly List<(PictureBox starPicture, Panel starColorPanel, Label)> starControls = new();

        private int selectedMagnitudeIndex = -10;

        private bool suspendEvents;

        /// <summary>
        /// The absolute value of the smallest magnitude used.
        /// </summary>
        private const int SmallestMagnitudeAbs = 10;
        #endregion

        #region PrivateMethodsAndProperties        
        /// <summary>
        /// Gets or sets the index of the selected magnitude from the star symbol list.
        /// </summary>
        /// <value>The index of the selected magnitude from the star symbol list.</value>
        private int SelectedMagnitudeIndex
        {
            set
            {
                if (value != selectedMagnitudeIndex)
                {
                    selectedMagnitudeIndex = value;
                    SetSelectedData();
                }
            }
        }
        
        /// <summary>
        /// Re-create the controls based on the array values <see cref="StarMagnitudeColors"/> and <see cref="StarMagnitudes"/>.
        /// </summary>
        private void UpdateArrayProperties()
        {
            tlpStarMagnitudes.Controls.Clear();
            tlpStarMagnitudes.RowCount = 21;
            tlpStarMagnitudes.RowStyles.Clear();
            starControls.Clear();

            if (string.IsNullOrWhiteSpace(starMagnitudeColors) || string.IsNullOrWhiteSpace(starMagnitudes))
            {
                return;
            }

            diameters = starMagnitudes.Split(';').Select(int.Parse).ToArray();
            var colorStrings = starMagnitudeColors.Split(';');

            magnitudeColors = new Color[21];

            for (int i = 0; i < colorStrings.Length; i++)
            {
                magnitudeColors[i] = ColorTranslator.FromHtml(colorStrings[i]);
            }

            if (colorStrings.Length < 21 || diameters.Length < 21) 
            {
                return;
            }

            for (int i = -SmallestMagnitudeAbs; i <= SmallestMagnitudeAbs; i++)
            {
                tlpStarMagnitudes.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
                var magnitudeLabel = new Label
                {
                    Text = $@"{i}", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Cursor = Cursors.Hand,
                    Tag = i,
                };
                magnitudeLabel.Click += MagnitudeSelect_Click;
                tlpStarMagnitudes.Controls.Add(magnitudeLabel, 0, i + SmallestMagnitudeAbs);

                var box = new PictureBox
                {
                    Margin = Padding.Empty,
                    Dock = DockStyle.Fill,
                    Tag = i,
                    Cursor = Cursors.Hand,
                };

                box.Click += MagnitudeSelect_Click;

                box.Parent = tlpStarMagnitudes;
                tlpStarMagnitudes.Controls.Add(box, 1, i + SmallestMagnitudeAbs);

                var panel = new Panel
                {
                    BackColor = magnitudeColors[i + SmallestMagnitudeAbs],
                    Margin = Padding.Empty,
                    Dock = DockStyle.Fill,
                    Tag = i,
                    Cursor = Cursors.Hand,
                };

                starControls.Add((box, panel, magnitudeLabel));

                panel.Click += MagnitudeSelect_Click;

                tlpStarMagnitudes.Controls.Add(panel, 2, i + SmallestMagnitudeAbs);
                starImageBoxes.Add(box);
            }

            DrawStarImages();
        }

        /// <summary>
        /// Update the GUI based on selected star magnitude.
        /// </summary>
        private void SetSelectedData()
        {
            lbSelectedMagnitude.Text = string.Format(magnitudeValueFormat, selectedMagnitudeIndex);

            if (starControls.Count < selectedMagnitudeIndex + SmallestMagnitudeAbs + 1)
            {
                return;
            }

            suspendEvents = true;
            nudStarSize.Value = diameters[selectedMagnitudeIndex + SmallestMagnitudeAbs];

            cwColor.Color = magnitudeColors[selectedMagnitudeIndex + SmallestMagnitudeAbs];

            ceColor.Color = magnitudeColors[selectedMagnitudeIndex + SmallestMagnitudeAbs];
            suspendEvents = false;
        }

        /// <summary>
        /// Draws the star images for different magnitudes.
        /// </summary>
        private void DrawStarImages()
        {
            using var backgroundBrush = new SolidBrush(Color.Black);
            for (int i = 0; i < starImageBoxes.Count; i++)
            {
                var box = starImageBoxes[i];
                var wh = Math.Min(box.Width, box.Height);
                var bitmap = new Bitmap(wh, wh);
                using var graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                var circleColor = magnitudeColors[i];
                var circleDiameter = diameters[i];

                var topLeft = ((float)wh - circleDiameter) / 2f;

                graphics.FillRectangle(backgroundBrush, new Rectangle(Point.Empty, new Size(wh, wh)));

                using var circleBrush = new SolidBrush(circleColor);

                graphics.FillEllipse(circleBrush, new RectangleF(new PointF(topLeft, topLeft), new SizeF(circleDiameter, circleDiameter)));
                box.Image = bitmap;
            }
        }

        /// <summary>
        /// Sets the color for the selected star magnitude.
        /// </summary>
        /// <param name="value">The value for the magnitude.</param>
        private void SetColor(Color value)
        {
            if (magnitudeColors.Length < selectedMagnitudeIndex + SmallestMagnitudeAbs + 1)
            {
                return;
            }

            magnitudeColors[selectedMagnitudeIndex + SmallestMagnitudeAbs] = value;
            starControls[selectedMagnitudeIndex + SmallestMagnitudeAbs].starColorPanel.BackColor = value;

            starMagnitudeColors = string.Join(";", magnitudeColors.Select(ColorTranslator.ToHtml));
        }
        #endregion

        #region PublicProperties
        /// <summary>
        /// Gets or sets the star magnitude diameters in a semicolon-separated list from -10 to 10 magnitudes.
        /// </summary>
        /// <value>The star magnitude diameters.</value>
        [Browsable(false)]
        public string StarMagnitudes
        {
            get => starMagnitudes;

            set
            {
                if (value != starMagnitudes)
                {
                    starMagnitudes = value;
                    UpdateArrayProperties();
                }
            }
        }

        /// <summary>
        /// Gets or sets the magnitude value format.
        /// </summary>
        /// <value>The magnitude value format.</value>
        [Browsable(true)]
        [Category("Behaviour")]
        [Description("The magnitude value format.")]
        public string MagnitudeValueFormat
        {
            get => magnitudeValueFormat;

            set
            {
                if (value != magnitudeValueFormat)
                {
                    try
                    {
                        _ = string.Format(value, 0);
                        magnitudeValueFormat = value;
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the selected magnitude.
        /// </summary>
        /// <value>The selected magnitude.</value>
        [Browsable(false)]
        public int SelectedMagnitude
        {
            get => selectedMagnitude;

            set
            {
                if (value != selectedMagnitude)
                {
                    selectedMagnitude = value;
                    lbSelectedMagnitude.Text = string.Format(magnitudeValueFormat, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the star magnitude colors in a semicolon-separated HTML list from -10 to 10 magnitudes.
        /// </summary>
        /// <value>The star magnitude colors.</value>
        [Browsable(false)]
        public string StarMagnitudeColors
        {
            get => starMagnitudeColors;

            set
            {
                if (value != starMagnitudeColors)
                {
                    starMagnitudeColors = value;
                    UpdateArrayProperties();
                }
            }
        }
        #endregion

        #region InternalEvents
        private void controlColor_ColorChanged(object sender, EventArgs e)
        {
            if (suspendEvents)
            {
                return;
            }

            suspendEvents = true;
            if (sender.Equals(cwColor))
            {
                SetColor(cwColor.Color);
                ceColor.Color = cwColor.Color;
            }
            else
            {
                SetColor(ceColor.Color);
                cwColor.Color = ceColor.Color;
            }
            DrawStarImages();
            suspendEvents = false;
        }

        private void MagnitudeSelect_Click(object? sender, EventArgs e)
        {
            var control = (Control)sender!;
            SelectedMagnitudeIndex = (int)control.Tag;
        }

        private void nudStarSize_ValueChanged(object sender, EventArgs e)
        {
            if (suspendEvents)
            {
                return;
            }

            suspendEvents = true;
            diameters[selectedMagnitudeIndex] = (int)nudStarSize.Value;

            starMagnitudes = string.Join(";", diameters.Select(f => f.ToString()));

            DrawStarImages();
            suspendEvents = false;
        }
        #endregion
    }
}
