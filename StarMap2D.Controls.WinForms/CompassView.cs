using System.ComponentModel;

namespace StarMap2D.Controls.WinForms
{
    /// <summary>
    /// A simple control to display a compass image and the names of the directions.
    /// Implements the <see cref="System.Windows.Forms.UserControl" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class CompassView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompassView"/> class.
        /// </summary>
        public CompassView()
        {
            InitializeComponent();
        }

        private void CompassView_Resize(object sender, EventArgs e)
        {
            lbNorth.Left = (Width - lbNorth.Width) / 2;
            lbSouth.Left = (Width - lbSouth.Width) / 2;

            lbEast.Top = (Height - lbEast.Height) / 2;
            lbWest.Top = (Height - lbWest.Height) / 2;
        }

        /// <summary>
        /// Gets or sets the name of the north direction to display.
        /// </summary>
        /// <value>The name of the north direction.</value>
        [Category("Behaviour")]
        [Description("The name of the north direction")]
        public string NorthName
        {
            get => lbNorth.Text;

            set => lbNorth.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the south direction to display.
        /// </summary>
        /// <value>The name of the south direction.</value>
        [Category("Behaviour")]
        [Description("The name of the south direction")]
        public string SouthName
        {
            get => lbSouth.Text;

            set => lbSouth.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the south east to display.
        /// </summary>
        /// <value>The name of the east direction.</value>
        [Category("Behaviour")]
        [Description("The name of the east direction")]
        public string EastName
        {
            get => lbEast.Text;

            set => lbEast.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the west east to display.
        /// </summary>
        /// <value>The name of the west direction.</value>
        [Category("Behaviour")]
        [Description("The name of the west direction")]
        public string WestName
        {
            get => lbWest.Text;

            set => lbWest.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the north-east to display.
        /// </summary>
        /// <value>The name of the north-east direction.</value>
        [Category("Behaviour")]
        [Description("The name of the north-east direction")]
        public string NorthEastName
        {
            get => lbNorthEast.Text;

            set => lbNorthEast.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the north-west to display.
        /// </summary>
        /// <value>The name of the north-west direction.</value>
        [Category("Behaviour")]
        [Description("The name of the north-west direction")]
        public string NorthWestName
        {
            get => lbNorthWest.Text;

            set => lbNorthWest.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the south-east to display.
        /// </summary>
        /// <value>The name of the south-east direction.</value>
        [Category("Behaviour")]
        [Description("The name of the south-east direction")]
        public string SouthEastName
        {
            get => lbSouthEast.Text;

            set => lbSouthEast.Text = value;
        }

        /// <summary>
        /// Gets or sets the name of the south-west to display.
        /// </summary>
        /// <value>The name of the south-west direction.</value>
        [Category("Behaviour")]
        [Description("The name of the south-west direction")]
        public string SouthWestName
        {
            get => lbSouthWest.Text;

            set => lbSouthWest.Text = value;
        }

        private bool invertEastWest;

        /// <summary>
        /// Gets or sets a value indicating whether the east-west axis is inverted.
        /// </summary>
        /// <value><c>true</c> if the east-west axis is inverted; otherwise, <c>false</c>.</value>
        [Category("Behaviour")]
        [Description("A value indicating if the east-west axis is inverted.")]
        public bool InvertEastWest
        {
            get => invertEastWest;

            set
            {
                if (value != invertEastWest)
                {
                    invertEastWest = value;
                    var nw = NorthWestName;
                    var w = WestName;
                    var sw = SouthWestName;

                    NorthWestName = NorthEastName;
                    WestName = EastName;
                    SouthWestName = SouthEastName;

                    NorthEastName = nw;
                    EastName = w;
                    SouthEastName = sw;
                }
            }
        }
    }
}
