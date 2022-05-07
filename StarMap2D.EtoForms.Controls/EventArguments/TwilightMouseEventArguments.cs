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

using StarMap2D.EtoForms.Controls.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMap2D.EtoForms.Controls.EventArguments;

/// <summary>
/// Event arguments for the <see cref="TwilightVisualization.TwilightClicked"/> event.
/// Implements the <see cref="System.EventArgs" />
/// </summary>
/// <seealso cref="System.EventArgs" />
public class TwilightMouseEventArguments : EventArgs
{
    /// <summary>
    /// Gets or sets the type of the twilight which was clicked.
    /// </summary>
    /// <value>The type of the twilight.</value>
    public TwilightType TwilightType { get; set; }

    /// <summary>
    /// Gets or sets the twilight start hour.
    /// </summary>
    /// <value>The twilight start hour.</value>
    public double TwilightStartHour { get; set; }

    /// <summary>
    /// Gets or sets the twilight end hour.
    /// </summary>
    /// <value>The twilight end hour.</value>
    public double TwilightEndHour { get; set; }

    /// <summary>
    /// Gets or sets the twilight hour value.
    /// </summary>
    /// <value>The twilight hour value.</value>
    public double TwilightHourValue { get; set; }
}