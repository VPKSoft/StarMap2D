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
using System.Text;
using AASharp;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Plotting;
using StarMap2D.Forms;
using StarMap2D.StarData;

namespace StarMap2D
{
    /// <summary>
    /// The main form of the application.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            new FormSkyMap2D().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(@"C:\Users\Petteri Kautonen\Downloads\constellations");
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);

                var builder = new StringBuilder();

                string? identifier = null;
                string? firstLine = null;

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    var lineData = line.Split("|");

                    if (identifier == null)
                    {
                        identifier = lineData[2];
                        // Identifier = "ORI";
                        // Name = "";

                        builder.AppendLine($"Identifier = \"{identifier}\";");
                        builder.AppendLine($"Name = \"Replace: {identifier}\";");
                        builder.AppendLine("\tStars = new[] {");
                    }


                    var rah = lineData[0].Split(' ')[0];
                    var ram = lineData[0].Split(' ')[1];
                    var ras = lineData[0].Split(' ')[2];

//                    var d = AASCoordinateTransformation.HoursToDegrees(double.Parse(rah, CultureInfo.InvariantCulture));
                    var d = double.Parse(rah, CultureInfo.InvariantCulture);
                    var m = double.Parse(ram, CultureInfo.InvariantCulture);
                    var s = double.Parse(ras, CultureInfo.InvariantCulture);
                    var dec = double.Parse(lineData[1], CultureInfo.InvariantCulture);

                    var csData = $"new ConstellationStar {{ Identifier = \"{identifier}\", Rad = {rah.TrimStart('0')}, Ram = {ram}, Ras = {ras}, RightAscension = {AASCoordinateTransformation.DMSToDegrees(d, m, s).ToString(CultureInfo.InvariantCulture)}, Declination = {dec.ToString(CultureInfo.InvariantCulture)} }},";

                    firstLine ??= csData;

                    builder.AppendLine(csData);
                }

                if (firstLine != null)
                {
                    builder.AppendLine(firstLine);
                }

                builder.AppendLine("};");
                textBox1.Text += builder.ToString();
//                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var test = new ConstellationLine
                { RightAscensionStart = 1, DeclinationStart = 2, RightAscensionEnd = 3, DeclinationEnd = 4 };

            var lines = textBox1.Lines;
            var builder = new StringBuilder();

            foreach (var line in lines)
            {
                var lineData = line.Replace("+", "").Split(',');
                builder.AppendLine($"new ConstellationLine {{ RightAscensionStart = {lineData[1]}, DeclinationStart = {lineData[2]}, RightAscensionEnd = {lineData[3]}, DeclinationEnd = {lineData[4]} }}, ");
            }

            textBox1.Text = builder.ToString();
            /*
            
            var testD = new PointDouble { X = 0, Y = 1 };
            var hipparcosProvider = new HipparcosProvider();
            hipparcosProvider.LoadData(@"C:\Files\GitHub\StarMap2D\StarMap2D\StarCatalogs\Hipparcos\Extracted\hip_main.dat");

            var lines = textBox1.Lines;
            var builder = new StringBuilder();

            foreach (var line in lines)
            {
                var lineData = line.Trim('[', ']', '\"').Split(",");
                for (int i = 0; i < lineData.Length - 1; i++)
                {
                    var data1 = lineData[i];
                    var data2 = lineData[i + 1];

                    var hipId1 = int.Parse(data1.Replace("\"", ""));
                    var hipId2 = int.Parse(data2.Replace("\"", ""));

                    var hip1 = hipparcosProvider.StarData.First(f => f.HIP == hipId1);
                    var hip2 = hipparcosProvider.StarData.First(f => f.HIP == hipId2);

                    builder.AppendLine($"new ConstellationLine {{ RightAscensionStart = {hip1.RightAscension.ToString(CultureInfo.InvariantCulture)}, DeclinationStart = {hip1.Declination.ToString(CultureInfo.InvariantCulture)}, RightAscensionEnd = {hip2.RightAscension.ToString(CultureInfo.InvariantCulture)}, DeclinationEnd = {hip2.Declination.ToString(CultureInfo.InvariantCulture)} }}, ");

//                    builder.AppendLine($"new PointDouble {{ X = {hip.RightAscension.ToString(CultureInfo.InvariantCulture)}, Y = {hip.Declination.ToString(CultureInfo.InvariantCulture)} }},");
                }
            }

            textBox1.Text = builder.ToString();
            */
        }
    }
}