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
using POCs.Sanjay.SharpSnippets.Drawing;
using StarMap2D.Controls.WinForms.Utilities;

namespace StarMap2D.Controls.WinForms;

/// <summary>
/// A control to configure solar system symbols.
/// Implements the <see cref="System.Windows.Forms.UserControl" />
/// </summary>
/// <seealso cref="System.Windows.Forms.UserControl" />
public partial class SolarSystemObjectConfigurator : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SolarSystemObjectConfigurator"/> class.
    /// </summary>
    public SolarSystemObjectConfigurator()
    {
        InitializeComponent();

        lbSolarSystemObjects.Items.AddRange(ObjectGraphics.Cast<object>().ToArray());

        textBrushSelection = new SolidBrush(SystemColors.Highlight.GetContrast(false));
    }

    #region PrivateFields
    private Brush? listTextBrush;
    private readonly Brush textBrushSelection;
    private static string locale = "en-US";
    private SolarSystemObjectGraphics[] objectGraphics = SolarSystemObjectGraphics.CreateDefaultList(locale).ToArray();
    private bool suspendEvents;
    #endregion


    /// <summary>
    /// Gets or sets the background color of the star map.
    /// </summary>
    /// <value>Gets or sets the background color of the star map.</value>
    [Category("Appearance")]
    [Browsable(true)]
    [Description("The background color of the star map.")]
    public Color MapBackgroundColor
    {
        get => lbSolarSystemObjects.BackColor;

        set
        {
            lbSolarSystemObjects.BackColor = value;
            pnMapSymbol.BackColor = value;
            lbSolarSystemObjects.ForeColor = value.GetContrast(true);
            listTextBrush?.Dispose();
            listTextBrush = new SolidBrush(value.GetContrast(true));
        }
    }

    /// <summary>
    /// Gets or sets the locale for the <see cref="SolarSystemObjectGraphics.Name"/> localization.
    /// </summary>
    /// <value>The locale for the <see cref="SolarSystemObjectGraphics.Name"/> localization.</value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Locale
    {
        get => locale;

        set
        {
            if (value != locale)
            {
                foreach (var objectGraphic in objectGraphics)
                {
                    objectGraphic.Locale = value;
                }

                locale = value;

                lbSolarSystemObjects.RefreshItems();
            }
        }
    }

    /// <summary>
    /// Gets or sets the object graphic settings.
    /// </summary>
    /// <value>The object graphic settings.</value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public SolarSystemObjectGraphics[] ObjectGraphics
    {
        get => objectGraphics;

        set
        {
            objectGraphics = SolarSystemObjectGraphics.MergeWithDefaults(value, locale).ToArray();
            lbSolarSystemObjects.Items.Clear();
            lbSolarSystemObjects.Items.AddRange(ObjectGraphics.Cast<object>().ToArray());
        }
    }

    #region InternalEvents
    private void lbSolarSystemObjects_DrawItem(object sender, DrawItemEventArgs e)
    {
        e.DrawBackground();

        var listBox = (ListBox)sender;

        if (e.Index < 0 || e.Index >= listBox.Items.Count)
        {
            return;
        }

        var selected = e.State.HasFlag(DrawItemState.Selected) || e.State.HasFlag(DrawItemState.Focus);

        var item = (SolarSystemObjectGraphics)listBox.Items[e.Index];

        e.Graphics.DrawImage(item.ImageStaticDiameter, new Point(0, 1 + e.Bounds.Top));

        listTextBrush ??= new SolidBrush(listBox.ForeColor.GetContrast(true));

        e.Graphics.DrawString(item.Name, listBox.Font, selected ? textBrushSelection : listTextBrush,
            new PointF(2 + SolarSystemObjectGraphics.StaticDiameter, e.Bounds.Top));
    }

    private void lbSolarSystemObjects_MeasureItem(object sender, MeasureItemEventArgs e)
    {
        var listBox = (ListBox)sender;
        if (e.Index < 0 || e.Index >= listBox.Items.Count)
        {
            return;
        }

        var item = (SolarSystemObjectGraphics)listBox.Items[e.Index];

        var measure = e.Graphics.MeasureString(item.Name, listBox.Font);

        var fontHeight = (int)Math.Round(measure.Height + 0.5);

        e.ItemHeight = Math.Max(fontHeight, SolarSystemObjectGraphics.StaticDiameter + 2);
        e.ItemWidth = (int)e.Graphics.ClipBounds.Width;
    }

    private void nudStarSize_ValueChanged(object sender, EventArgs e)
    {
        if (suspendEvents)
        {
            return;
        }

        foreach (var selectedItem in lbSolarSystemObjects.SelectedItems)
        {
            var item = (SolarSystemObjectGraphics)selectedItem;
            item.Diameter = (int)nudStarSize.Value;
        }

        UpdatePreviewImage();
    }

    private void lbSolarSystemObjects_SelectedIndexChanged(object sender, EventArgs e)
    {
        var listBox = (ListBox)sender;

        var index = listBox.SelectedIndex;

        if (index < 0 || index >= listBox.Items.Count)
        {
            UpdatePreviewImage();
            return;
        }

        var item = (SolarSystemObjectGraphics)listBox.SelectedItem;
        suspendEvents = true;
        nudStarSize.Value = item.Diameter;
        cwColor.Color = rbCircle.Checked ? item.ObjectCircleColor : item.ObjectSymbolColor;
        ceColor.Color = rbCircle.Checked ? item.ObjectCircleColor : item.ObjectSymbolColor;
        tbObjectName.Text = item.Name;
        suspendEvents = false;

        lbSelectedSymbolName.Text = item.Name;

        UpdatePreviewImage();
    }

    private void cwColor_ColorChanged(object sender, EventArgs e)
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
        suspendEvents = false;
    }

    private void tbObjectName_TextChanged(object sender, EventArgs e)
    {
        if (suspendEvents)
        {
            return;
        }
        
        var textBox = (TextBox)sender;
        if (!string.IsNullOrWhiteSpace(textBox.Text) && lbSolarSystemObjects.SelectedItem != null)
        {
            var item = (SolarSystemObjectGraphics)lbSolarSystemObjects.SelectedItem;
            item.Name = textBox.Text;
            lbSolarSystemObjects.RefreshItems();
        }
    }

    private void cbDontUse_CheckedChanged(object sender, EventArgs e)
    {
        var enabled = !((CheckBox)sender).Checked;

        foreach (var selectedItem in lbSolarSystemObjects.SelectedItems)
        {
            var item = (SolarSystemObjectGraphics)selectedItem;
            item.Enabled = enabled;
        }
    }
    #endregion

    #region PrivateMethodsAndProperties
    private void SetColor(Color value)
    {
        foreach (var selectedItem in lbSolarSystemObjects.SelectedItems)
        {
            var item = (SolarSystemObjectGraphics)selectedItem;
            if (rbCircle.Checked)
            {
                item.ObjectCircleColor = value;
            }
            else
            {
                item.ObjectSymbolColor = value;
            }
            item.Diameter = (int)nudStarSize.Value;
        }

        UpdatePreviewImage();
    }
    
    private void UpdatePreviewImage()
    {
        var listBox = lbSolarSystemObjects;

        var index = listBox.SelectedIndex;

        if (index < 0 || index >= listBox.Items.Count)
        {
            pnMapSymbol.BackgroundImage = null;
            return;
        }


        var item = (SolarSystemObjectGraphics)listBox.SelectedItem;
        pnMapSymbol.BackgroundImage = item.Image;
    }
    #endregion

    #region PublicMethods
    /// <summary>
    /// Resets the <see cref="SolarSystemObjectGraphics"/> objects to default values.
    /// </summary>
    public void Reset()
    {
        ObjectGraphics = SolarSystemObjectGraphics.CreateDefaultList(locale).ToArray();
    }
    #endregion
}