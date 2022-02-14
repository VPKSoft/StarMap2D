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

using System.Globalization;
using StarMap2D.Forms;
using StarMap2D.Forms.Dialogs;
using VPKSoft.LangLib;
using VPKSoft.StarCatalogs.Files;

namespace StarMap2D;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        DBLangEngine.DataDir = SettingsFolder;

        // localizeProcess (user wishes to localize the software)..
        var localizeProcess = Utils.CreateDBLocalizeProcess(SettingsFolder);

        // if the localize process was requested via the command line..
        if (localizeProcess != null)
        {
            // start the DBLocalization.exe and return..
            localizeProcess.Start();
            return;
        }

        // Save languages..
        if (Utils.ShouldLocalize() != null)
        {
            _ = new FormMain();
            _ = new FormDialogSettings();
            _ = new FormSkyMap2D();
            _ = new FormPlanetDetails();
            _ = new FormSolarSystemObjectsTable();
            return;
        }

        Globals.FormattingCulture = string.IsNullOrWhiteSpace(Properties.Settings.Default.FormattingLocale)
            ? CultureInfo.CurrentUICulture
            : new CultureInfo(Properties.Settings.Default.FormattingLocale);

        StarMap2D.Calculations.Globals.FormattingCulture = Globals.FormattingCulture;

        DBLangEngine.UseCulture = new CultureInfo(Properties.Settings.Default.Locale);
        CatalogFileProvider.BaseFolder = SettingsFolder;

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormMain());
    }

    /// <summary>
    /// Gets or sets the application settings folder.
    /// </summary>
    /// <value>The application settings folder.</value>
    internal static string SettingsFolder
    {
        get
        {
            var result = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "VPKSoft",
                nameof(StarMap2D));

            if (!Directory.Exists(result))
            {
                Directory.CreateDirectory(result);
            }

            return result;
        }
    }

    internal static string GetSettingFile(string fileName)
    {
        return Path.Combine(SettingsFolder, fileName);
    }
}