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

using VPKSoft.ApplicationSettingsJson;

namespace StarMap2D.Eto.ApplicationSettings
{
    public class Settings : ApplicationJsonSettings
    {
        [Settings(Default = 60.1102605)]
        public double Latitude { get; set; }

        [Settings(Default = 22.8782576)]
        public double Longitude { get; set; }

        [Settings(Default = "")]
        public string? FormattingLocale { get; set; }

        [Settings(Default = "N/A")]
        public string? DefaultLocationName { get; set; }

        [Settings(Default = "#00BFFF")]
        public string? ConstellationLineColor { get; set; }

        [Settings(Default = "#0D177F")]
        public string? ConstellationBorderLineColor { get; set; }

        [Settings(Default = "#000000")]
        public string? MapCircleColor { get; set; }

        [Settings(Default = "#272727")]
        public string? MapSurroundingsColor { get; set; }

        [Settings(Default = "#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff")]
        public string? StarMagnitudeColors { get; set; }

        [Settings(Default = "10;10;10;10;10;10;9;8;7;6;5;4;3;3;3;3;3;3;3;3;2")]
        public string? StarMagnitudeSizes { get; set; }

        [Settings(Default = -500.0)]
        public double MagnitudeMaximum { get; set; }

        [Settings(Default = 5.5)]
        public double MagnitudeMinimum { get; set; }

        [Settings(Default = false)]
        public bool InvertEastWest { get; set; }

        [Settings(Default = "#E717B4")]
        public string? MapTextColor { get; set; }

        [Settings(Default = true)]
        public bool DrawConstellationLines { get; set; }

        [Settings(Default = false)]
        public bool DrawConstellationLabels { get; set; }

        [Settings(Default = false)]
        public bool DrawConstellationBorders { get; set; }

        [Settings(Default = "en-US")]
        public string? Locale { get; set; }

        [Settings(Default = "")]
        public string? KnownObjects { get; set; }

        [Settings(Default = true)]
        public bool DrawCrossHair { get; set; }

        [Settings(Default = "#00FF00")]
        public string CrossHairColor { get; set; }

        [Settings(Default = "")]
        public string? ColumnsGridObjectDetails { get; set; }

        [Settings(Default = "")]
        public string? StarCatalog { get; set; }

        [Settings(Default = "")]
        public string? DateFormattingCulture { get; set; }
    }
}