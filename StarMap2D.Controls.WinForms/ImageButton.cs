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
using StarMap2D.Controls.WinForms.Drawing;
using StarMap2D.Controls.WinForms.EventArguments;
using StarMap2D.Controls.WinForms.Utilities;
using Svg;

namespace StarMap2D.Controls.WinForms;

/// <summary>
/// A button control with centered image scaled to size of the button.
/// Implements the <see cref="System.Windows.Forms.UserControl" />
/// </summary>
/// <seealso cref="System.Windows.Forms.UserControl" />
[DefaultEvent(nameof(Click))]
public partial class ImageButton : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ImageButton"/> class.
    /// </summary>
    public ImageButton()
    {
        InitializeComponent();
    }

    #region PropertyFields
    private string? imageCheckedSvg;
    private string? imageSvg;
    private Color disabledColor;
    private SvgDocument? selectedSvgDocument;
    private SvgDocument? selectedCheckedSvgDocument;
    private Color imageColor = Color.SteelBlue;
    private Color imageColorChecked;
    #endregion

    #region Events

    public delegate void ImageCheckedChangedEventHandler(object? sender, CheckedChangeEventArguments args);

    /// <summary>
    /// Occurs when the image <see cref="Checked"/> property has changed.
    /// </summary>
    [Description("Occurs when the image Checked property has changed.")]
    [Category("Behavior")]
    [Browsable(true)]
    public event EventHandler<CheckedChangeEventArguments>? CheckedChanged;
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets the SVG image name displayed in the button.
    /// </summary>
    /// <value>The SVG image name displayed in the button.</value>
    /// <remarks>Setting this property will override the <see cref="Image"/> property value.</remarks>
    [Description("The SVG image name displayed in the button.")]
    [Category("Appearance")]
    [Browsable(true)]
    [TypeConverter(typeof(SvgResourceSelectionConverter))]
    public string? ImageSvg
    {
        get => imageSvg;

        set
        {
            if (value != imageSvg)
            {
                imageSvg = value;
                SetSvgImage();
            }
        }
    }

    private bool isCheckedButton;

    /// <summary>
    /// Gets or sets a value indicating whether this button is checked button.
    /// </summary>
    /// <value><c>true</c> if this button is checked button; otherwise, <c>false</c>.</value>
    [Description("A value indicating whether this button is checked button.")]
    [Category("Behaviour")]
    [Browsable(true)]
    public bool IsCheckedButton
    {
        get => isCheckedButton;

        set
        {
            if (value != isCheckedButton)
            {
                isCheckedButton = value;
                pnButtonImage.Invalidate();
            }
        }
    }

    private bool @checked;

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="ImageButton"/> is checked.
    /// </summary>
    /// <value><c>true</c> if checked; otherwise, <c>false</c>.</value>
    [Description("A value indicating whether this button is checked.")]
    [Category("Behaviour")]
    [Browsable(true)]
    public bool Checked
    {
        get => @checked;

        set
        {
            if (value != @checked)
            {
                @checked = value;
                if (isCheckedButton)
                {
                    pnButtonImage.Invalidate();
                }

                CheckedChanged?.Invoke(this, new CheckedChangeEventArguments { Checked = value });
            }
        }
    }

    /// <summary>
    /// Gets or sets the SVG image name displayed in the button when the button is .
    /// </summary>
    /// <value>The SVG image name displayed in the button.</value>
    /// <remarks>Setting this property will override the <see cref="Image"/> property value.</remarks>
    [Description("The SVG image name displayed in the button.")]
    [Category("Appearance")]
    [Browsable(true)]
    [TypeConverter(typeof(SvgResourceSelectionConverter))]
    public string? ImageCheckedSvg
    {
        get => imageCheckedSvg;

        set
        {
            if (value != imageCheckedSvg)
            {
                imageCheckedSvg = value;
                SetSvgImage();
            }
        }
    }

    /// <summary>
    /// Gets or sets a value that is returned to the parent form when the button is clicked.
    /// </summary>
    /// <value>One of the <see cref="DialogResult"/> values. The default value is <c>None</c>.</value>
    [Category("Appearance")]
    [Browsable(true)]
    [Description("The value that is returned to the parent form when the button is clicked.")]
    public DialogResult DialogResult { get; set; } = DialogResult.None;


    /// <summary>
    /// Gets or sets the disabled color for the control.
    /// </summary>
    /// <value>The disabled color for the control.</value>
    [Category("Appearance")]
    [Description("The disabled color for the control.")]
    [Browsable(true)]
    public Color DisabledColor
    {
        get => disabledColor == default ? Color.LightGray : disabledColor;

        set
        {
            if (value != disabledColor)
            {
                disabledColor = value;
                SetSvgImage();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the <see cref="SvgImage"/> image.
    /// </summary>
    /// <value>The color of the <see cref="SvgImage"/> image.</value>
    [Category("Appearance")]
    [Description("The color of the SvgImage image.")]
    [Browsable(true)]
    public Color ImageColor
    {
        get => imageColor;

        set
        {
            if (value != imageColor)
            {
                imageColor = value;
                pnButtonImage.Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the <see cref="SvgImage"/> image.
    /// </summary>
    /// <value>The color of the <see cref="SvgImage"/> image.</value>
    [Category("Appearance")]
    [Description("The color of the SvgImage image.")]
    [Browsable(true)]
    public Color ImageColorChecked
    {
        get => imageColorChecked == default ? imageColor : imageColorChecked;

        set
        {
            if (value != imageColorChecked)
            {
                imageColorChecked = value;
                pnButtonImage.Invalidate();
            }
        }
    }

    /// <inheritdoc cref="Control.Enabled"/>
    [Category("Behaviour")]
    [Browsable(true)]
    [Description("Indicates whether the control is enabled.")]
    public new bool Enabled
    {
        get => base.Enabled;

        set
        {
            base.Enabled = value;
            SetSvgImage();
        } 
    }
    #endregion

    #region PrivateMethodsAndProperties
    private void SetSvgImage()
    {
        SetSvgImage(true);
        SetSvgImage(false);
    }

    private void SetSvgImage(bool checkedImage)
    {
        if ((checkedImage ? imageCheckedSvg : imageSvg) != null)
        {
            try
            {
                SvgColorize.SvgColor = Enabled ? imageColor : disabledColor;
                var resource = Properties.Resources.ResourceManager.GetObject((checkedImage ? imageCheckedSvg : imageSvg) ?? string.Empty);
                if (resource != null)
                {
                    var bytes = (byte[])resource;
                    if (checkedImage)
                    {
                        selectedCheckedSvgDocument = SvgColorize.FromBytes(bytes);
                    }
                    else
                    {
                        selectedSvgDocument = SvgColorize.FromBytes(bytes);
                    }

                    pnButtonImage.Invalidate();
                }
            }
            catch
            {
                pnButtonImage.BackgroundImage = null;
            }
        }
        else
        {
            pnButtonImage.BackgroundImage = null;
        }
    }
    #endregion

    #region InternalEvents
    private void pnButtonImage_Click(object sender, EventArgs e)
    {
        if (DialogResult != DialogResult.None && ParentForm is { Modal: true })
        {
            ParentForm.DialogResult = DialogResult;
        }

        if (isCheckedButton)
        {
            Checked = !Checked;
        }
        else
        {
            OnClick(e);
        }
    }

    private void image_Resize(object sender, EventArgs e)
    {
        SetSvgImage();
    }

    private void pnButtonImage_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        if (selectedSvgDocument != null)
        {
            SvgColorize.SvgColor = Enabled ? imageColor : disabledColor;
            var svg = SvgColorize.ColorizeSvg(selectedSvgDocument);

            if (@checked && isCheckedButton && selectedCheckedSvgDocument != null)
            {
                svg = SvgColorize.ColorizeSvg(selectedCheckedSvgDocument);
            }

            var wh = Math.Min(Width, Height);

            var brush = new SolidBrush(BackColor);
            e.Graphics.FillRectangle(brush, e.ClipRectangle);
            if (wh < 1)
            {
                return;
            }
            var image = svg.Draw(wh, wh);

            var x = (Width - wh) / 2;
            var y = (Height - wh) / 2;

            e.Graphics.DrawImage(image, new Point(x, y));

            image?.Dispose();
        }
    }
    #endregion
}