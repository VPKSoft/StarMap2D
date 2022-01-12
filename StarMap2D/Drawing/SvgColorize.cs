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

using Svg;

namespace StarMap2D.Drawing
{
    /// <summary>
    /// A class to change colors of a SVG image.
    /// </summary>
    public class SvgColorize
    {
        /// <summary>
        /// Gets or sets the color for the SVG colorization.
        /// </summary>
        /// <value>The color for the SVG colorization.</value>
        public static Color SvgColor { get; set; } = Color.Teal;

        /// <summary>
        /// Colorizes the SVG specified by the <see cref="SvgColor"/> property.
        /// </summary>
        /// <param name="svgDocument">The SVG document.</param>
        /// <returns>A new instance of the <see cref="SvgDocument"/> colorized with the <see cref="SvgColor"/> color.</returns>
        public static SvgDocument ColorizeSvg(SvgDocument svgDocument)
        {
            var stream = new MemoryStream();
            svgDocument.Write(stream);
            stream.Position = 0;
            var document = SvgDocument.Open<SvgDocument>(stream);
            ProcessSvgNodes(document.Descendants(), new SvgColourServer(SvgColor));
            return document;
        }

        /// <summary>
        /// Generates a SVG image from specified byte array.
        /// </summary>
        /// <param name="imageData">The image data.</param>
        /// <returns>An instance to a <see cref="SvgDocument"/> class.</returns>
        public static SvgDocument FromBytes(byte[] imageData)
        {
            using var memoryStream = new MemoryStream(imageData);
            return SvgDocument.Open<SvgDocument>(memoryStream);
        }

        /// <summary>
        /// Processes the SVG nodes and sets their color specified by the <see cref="SvgPaintServer"/> instance value.
        /// </summary>
        /// <param name="nodes">The Svg document nodes.</param>
        /// <param name="colorServer">The color server.</param>
        private static void ProcessSvgNodes(IEnumerable<SvgElement> nodes, SvgPaintServer colorServer)
        {
            foreach (var node in nodes)
            {
                if (node.Fill != null && node.Fill != SvgPaintServer.None)
                {
                    node.Fill = colorServer;
                }

                if (node.Color != null && node.Color != SvgPaintServer.None)
                { 
                    node.Color = colorServer;
                }

                if (node.Stroke != null && node.Stroke != SvgPaintServer.None)
                {
                    node.Stroke = colorServer;
                }

                ProcessSvgNodes(node.Descendants(), colorServer);
            }
        }
    }
}
