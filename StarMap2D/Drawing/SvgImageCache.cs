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
    /// A class to provide object images to the star map.
    /// </summary>
    public class SvgImageCache: IDisposable
    {
        /// <summary>
        /// A class to cache image data to prevent re-render on every time an image is requested.
        /// </summary>
        internal class SvgImageCacheItem
        {
            /// <summary>
            /// Gets or sets the color #1 of the image.
            /// </summary>
            /// <value>The color #1 of the image.</value>
            internal Color Color1 { get; set; }

            /// <summary>
            /// Gets or sets the color #2 of the image.
            /// </summary>
            /// <value>The color #2 of the image.</value>
            internal Color Color2 { get; set; }

            /// <summary>
            /// Gets or sets the size of the image.
            /// </summary>
            /// <value>The size of the image.</value>
            internal Size Size { get; set; }

            /// <summary>
            /// Gets or sets the name of the image.
            /// </summary>
            /// <value>The name of the image.</value>
            internal string ImageName { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the cached image.
            /// </summary>
            /// <value>The cached image.</value>
            internal Image? CachedImage { get; set; }

            /// <summary>
            /// Gets or sets the cached image bytes.
            /// </summary>
            /// <value>The cached image bytes.</value>
            internal byte[] CachedImageBytes { get; set; } = Array.Empty<byte>();
        }

        /// <summary>
        /// Gets the list of cached image items.
        /// </summary>
        /// <value>The cached image items.</value>
        private List<SvgImageCacheItem> CachedItems { get; } = new();

        /// <summary>
        /// Generates an image from specified SVG data.
        /// </summary>
        /// <param name="imageBytes">The SVG image data bytes.</param>
        /// <param name="size">The size of the image to generate.</param>
        /// <param name="color1">The color #1 to colorize the resulting image.</param>
        /// <param name="color2">The color #2 to colorize the resulting image.</param>
        /// <returns>An image generated from specified SVG data with specified colors and size.</returns>
        public static  Image GenerateImageFromSvg(byte[] imageBytes, Size size, Color color1, Color color2)
        {
            var svg = SvgColorize.FromBytes(imageBytes);
            foreach (var svgElement in svg.Descendants())
            {
                if (svgElement is SvgCircle circle)
                {
                    circle.Fill = new SvgColourServer(color1);
                    circle.Stroke = SvgPaintServer.None;
                }

                if (svgElement is SvgPath path)
                {
                    path.Fill = new SvgColourServer(color2);
                }
            }

            return svg.Draw(size.Width, size.Height);
        }

        /// <summary>
        /// Adds or sets the image with a specified name and data into the cache.
        /// </summary>
        /// <param name="name">The name of the image to add.</param>
        /// <param name="imageData">The SVG image data bytes.</param>
        public void SetImage(string name, byte[] imageData)
        {
            Remove(name);

            var cache = new SvgImageCacheItem
            {
                ImageName = name,
                Color1 = Color.Empty,
                Color2 = Color.Empty,
                Size = Size.Empty,
                CachedImageBytes = imageData,
            };

            CachedItems.Add(cache);
        }

        /// <summary>
        /// Clears the cached images from this instance.
        /// </summary>
        public void Clear()
        {
            foreach (var svgImageCacheItem in CachedItems)
            {
                svgImageCacheItem.CachedImage?.Dispose();
            }

            CachedItems.Clear();
        }

        /// <summary>
        /// Removes the image from the cache with specified name.
        /// </summary>
        /// <param name="name">The name of the image to remove.</param>
        public void Remove(string name)
        {
            var index = CachedItems.FindIndex(f => f.ImageName == name);

            if (index != -1)
            {
                CachedItems.RemoveAt(index);
            }
        }

        /// <summary>
        /// Gets the <see cref="Image"/> with the specified name from the cache.
        /// </summary>
        /// <param name="name">The name of the image.</param>
        /// <param name="color1">The #1 for the image colorization.</param>
        /// <param name="color2">The #2 for the image colorization.</param>
        /// <param name="size">The size of the image to return.</param>
        /// <returns>An instance to a <see cref="Image"/> if one with specified <paramref name="name"/> was found; <c>null</c> otherwise.</returns>
        public Image? this[string name, Color color1, Color color2, Size size]
        {
            get
            {
                var cache = CachedItems.FirstOrDefault(f => f.ImageName == name);
                if (cache == null)
                {
                    return null;
                }

                if (cache.CachedImage != null && cache.Size == size && cache.Color1 == color1 && cache.Color2 == color2)
                {
                    return cache.CachedImage;
                }
                
                cache.CachedImage?.Dispose();
                cache.CachedImage = GenerateImageFromSvg(cache.CachedImageBytes, size, color1, color2);
                return cache.CachedImage;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Clear();
        }
    }
}
