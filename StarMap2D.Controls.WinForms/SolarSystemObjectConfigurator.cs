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

using POCs.Sanjay.SharpSnippets.Drawing;
using StarMap2D.Controls.WinForms.Utilities;

namespace StarMap2D.Controls.WinForms;

public partial class SolarSystemObjectConfigurator : UserControl
{
    public SolarSystemObjectConfigurator()
    {
        InitializeComponent();

        lbSolarSystemObjects.Items.AddRange(SolarSystemObjectGraphics.CreateDefaultList("fi-Fi", 10).Select(f => (object)f)
            .ToArray());

        textBrushSelection = new SolidBrush(SystemColors.Highlight.GetContrast(false));
    }

    private Brush? listTextBrush;
    private readonly Brush textBrushSelection;

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

    /// <summary>
    /// Gets or sets the background color of the star map.
    /// </summary>
    /// <value>Gets or sets the background color of the star map.</value>
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

    private bool suspendEvents;

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
        suspendEvents = false;

        lbSelectedSymbolName.Text = item.Name;

        UpdatePreviewImage();
    }

    private Image previousImage;

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
        previousImage = item.Image;
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

    private void cbDontUse_CheckedChanged(object sender, EventArgs e)
    {

    }
}