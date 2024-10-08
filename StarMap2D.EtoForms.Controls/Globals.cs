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

using System.Globalization;
using System.Threading;
using Eto.Drawing;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Controls;

/// <summary>
/// A class containing the global static parameters.
/// </summary>
public static class Globals
{
    /// <summary>
    /// Overrides the current thread's <see cref="Thread.CurrentUICulture"/> property for all
    /// resource lookups using strongly typed resource classes in this library.
    /// </summary>
    public static CultureInfo Culture
    {
        set
        {

            Units.Culture = value;
            UI.Culture = value;
        }

        get => Units.Culture;
    }

    private static Font? font;

    /// <summary>
    /// Gets or sets the <see cref="Font"/> to use with the controls of this library.
    /// </summary>
    /// <value>The font.</value>
    public static Font Font
    {
        get => font ?? new Font(FontFamilies.Sans.Name, 9);

        set => font = value;
    }

    /// <summary>
    /// Gets or sets the floating point comparison tolerance.
    /// </summary>
    /// <value>The floating point comparison tolerance.</value>
    public static double FloatingPointTolerance { get; set; } = 0.000000001;

    /// <summary>
    /// Gets or sets the floating point comparison tolerance for the single-precision floating point values.
    /// </summary>
    /// <value>The floating point comparison tolerance.</value>
    public static float FloatingPointSingleTolerance { get; set; } = 0.00001f;
}