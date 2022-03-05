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

using System;
using System.Globalization;
using Eto.Forms;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;

namespace StarMap2D.EtoForms
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                System.Threading.Thread.CurrentThread.CurrentCulture;

            Globals.Settings.CreateApplicationSettingsFolder("VPKSoft", nameof(StarMap2D));
            Globals.Settings.Load(Globals.Settings.GetApplicationSettingsFile("VPKSoft", nameof(StarMap2D)));

            Globals.FormattingCulture = string.IsNullOrWhiteSpace(Globals.Settings.FormattingLocale)
                ? CultureInfo.CurrentUICulture
                : new CultureInfo(Globals.Settings.FormattingLocale);

            if (!string.IsNullOrWhiteSpace(Globals.Settings.Locale))
            {
                Controls.Globals.Culture = new CultureInfo(Globals.Settings.Locale);
            }

            new Application().Run(new MainForm());
        }
    }
}
