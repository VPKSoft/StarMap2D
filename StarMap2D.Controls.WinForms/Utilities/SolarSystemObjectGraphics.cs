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

using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using StarMap2D.Controls.WinForms.Drawing;
using StarMap2D.Controls.WinForms.Enumerations;
using Svg;

namespace StarMap2D.Controls.WinForms.Utilities;

/// <summary>
/// A class to provide symbols for known solar system objects.
/// </summary>
public class SolarSystemObjectGraphics
{
    /// <summary>
    /// Creates a new list of <see cref="SolarSystemObjectGraphics"/> objects with default values.
    /// </summary>
    /// <param name="locale">The locale for the <see cref="SolarSystemObjectGraphics.Name"/> value.</param>
    /// <returns>A list of <see cref="SolarSystemObjectGraphics"/> objects.</returns>
    public static List<SolarSystemObjectGraphics> CreateDefaultList(string locale)
    {
        var result = new List<SolarSystemObjectGraphics>();

        foreach (var objectGraphic in ObjectGraphics)
        {
            var newGraphic = new SolarSystemObjectGraphics(objectGraphic)
            {
                Diameter = DefaultDiameter,
                Locale = locale
            };
            result.Add(newGraphic);
        }

        return result.OrderBy(f => f.Name).ToList();
    }

    /// <summary>
    /// Merges the specified objects with default objects.
    /// </summary>
    /// <param name="serializedGraphics">The serialized graphics delimited with semicolon(';'). See also: <seealso cref="SaveToString"/>.</param>
    /// <param name="locale">The locale.</param>
    /// <returns>A list of solar system objects.</returns>
    public static List<SolarSystemObjectGraphics> MergeWithDefaults(string serializedGraphics, string locale)
    {
        return MergeWithDefaults(string.IsNullOrWhiteSpace(serializedGraphics)
            ? Array.Empty<SolarSystemObjectGraphics>()
            : serializedGraphics.Split(';').Select(FromString).ToArray(), locale);
    }

    /// <summary>
    /// Merges the specified objects with default objects.
    /// </summary>
    /// <param name="values">The values to merge with default objects.</param>
    /// <param name="locale">The locale.</param>
    /// <returns>A list of solar system objects.</returns>
    public static List<SolarSystemObjectGraphics> MergeWithDefaults(SolarSystemObjectGraphics[] values, string locale)
    {
        var existing = values.Select(f => f.ObjectType).ToList();

        var result = new List<SolarSystemObjectGraphics>();

        var newItems = CreateDefaultList(locale);

        newItems = newItems.Where(f => !existing.Contains(f.ObjectType)).ToList();

        result.AddRange(newItems);
        result.AddRange(values);

        return result.OrderBy(f => f.Name).ToList();
    }

    /// <summary>
    /// Gets or sets the default diameter for the solar system object symbols.
    /// </summary>
    /// <value>The default diameter for solar system objects.</value>
    public static int DefaultDiameter { get; set; } = 20;

    /// <summary>
    /// The default solar system object graphics.
    /// </summary>
    private static readonly SolarSystemObjectGraphics[] ObjectGraphics =
    {
        new()
        {
            ObjectType = ObjectsWithGraphics.Sun, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Sun),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.sun)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Mercury, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Mercury),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_mercury)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Venus, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Venus),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_venus)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Earth, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Earth),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.earth)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Moon, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Moon),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.moon)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Mars, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Mars),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_mars)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Jupiter, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Jupiter),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_jupiter)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Saturn, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Saturn),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_saturn)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Uranus, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Uranus),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_uranus)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Neptune, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Neptune),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.planet_neptune)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Ceres, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Ceres),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_ceres)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Orcus, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Orcus),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_orcus)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Pluto, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Pluto),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_pluto)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Haumea, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Haumea),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_haumea)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Quaoar, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Quaoar),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_quoar)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Makemake, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Makemake),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_makemake)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Gonggong, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Gonggong),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_gonggong)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Eris, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Eris),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_eris1)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Sedna, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Sedna),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_sedna)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Juno, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Juno),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_juno)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Vesta, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Vesta),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_vesta)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Pallas, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Pallas),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_pallas)
        },
        new()
        {
            ObjectType = ObjectsWithGraphics.Chiron, Diameter = DefaultDiameter, Name = nameof(ObjectsWithGraphics.Chiron),
            SvgDocument = SvgColorize.FromBytes(Properties.Resources.minor_planet_chiron)
        },
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="SolarSystemObjectGraphics"/> class.
    /// </summary>
    /// <param name="name">The name of the object.</param>
    /// <param name="imageFile">The image file.</param>
    /// <param name="svgDocument">The SVG document.</param>
    /// <param name="objectImage">The object image.</param>
    /// <param name="diameter">The diameter.</param>
    /// <param name="objectType">Type of the object.</param>
    public SolarSystemObjectGraphics(string name, string? imageFile, SvgDocument? svgDocument, Image? objectImage,
        int diameter, ObjectsWithGraphics objectType)
    {
        this.name = name;
        this.imageFile = imageFile;
        this.svgDocument = svgDocument;
        this.objectImage = objectImage;
        this.diameter = diameter;
        ObjectType = objectType;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SolarSystemObjectGraphics"/> class.
    /// </summary>
    public SolarSystemObjectGraphics()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SolarSystemObjectGraphics"/> class.
    /// </summary>
    /// <param name="objectGraphics">The object graphics.</param>
    public SolarSystemObjectGraphics(SolarSystemObjectGraphics objectGraphics) : this(objectGraphics.Name,
        objectGraphics.ImageFile, objectGraphics.SvgDocument, objectGraphics.ObjectImage, objectGraphics.Diameter,
        objectGraphics.ObjectType)
    {

    }

    /// <summary>
    /// Gets or sets the locale to use for the object name.
    /// </summary>
    /// <value>The locale for the object name.</value>
    public string Locale { get; set; } = "en-US";

    /// <summary>
    /// Gets or sets the function to localize the solar system objects.
    /// </summary>
    /// <value>The localize function.</value>
    public static Func<string, string, string> LocalizeFunc { get; set; } = (name, _) => name;

    private string name = string.Empty;

    /// <summary>
    /// Gets or sets the name of the solar system object.
    /// </summary>
    /// <value>The name of the solar system object.</value>
    public string Name
    {
        get => LocalizeFunc(name, Locale);

        set => name = value;
    }

    private string? imageFile;

    /// <summary>
    /// Gets or sets the optional image file name for the <see cref="Image"/> property.
    /// </summary>
    /// <value>The optional image file name for the <see cref="Image"/> property.</value>
    public string? ImageFile
    {
        get => imageFile;

        set
        {
            if (imageFile != value)
            {
                if (Path.GetExtension(value?.ToLowerInvariant()) == ".svg")
                {
                    SvgDocument = SvgDocument.Open(value);
                    redrawRequired = true;
                    return;
                }

                redrawRequired = true;
                imageFile = value;
            }
        }
    }

    private SvgDocument? svgDocument;

    /// <summary>
    /// Gets or sets the optional <see cref="Svg.SvgDocument"/> image for the <see cref="Image"/> property.
    /// </summary>
    /// <value>The optional <see cref="Svg.SvgDocument"/> image for the <see cref="Image"/> property.</value>
    public SvgDocument? SvgDocument
    {
        get => svgDocument;

        set
        {
            if (value != svgDocument)
            {
                redrawRequired = true;
                svgDocument = value;
            }
        }
    }

    private Image? objectImage;

    /// <summary>
    /// Gets or sets the optional <see cref="System.Drawing.Image"/> image for the <see cref="Image"/> property.
    /// </summary>
    /// <value>The optional <see cref="System.Drawing.Image"/> image for the <see cref="Image"/> property.</value>
    public Image? ObjectImage
    {
        get => objectImage;

        set
        {
            if (objectImage != value)
            {
                objectImage = value;
                redrawRequired = true;
            }
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="SolarSystemObjectGraphics"/> is enabled.
    /// </summary>
    /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
    public bool Enabled { get; set; } = true;

    private int diameter;

    /// <summary>
    /// Gets or sets the draw diameter.
    /// </summary>
    /// <value>The draw diameter.</value>
    public int Diameter
    {
        get => diameter;

        set
        {
            if (value != diameter)
            {
                diameter = value;
                redrawRequired = true;
            }
        }
    }

    /// <summary>
    /// Gets or sets the static draw diameter.
    /// </summary>
    /// <value>The static draw diameter.</value>
    public static int StaticDiameter { get; set; } = 20;

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    public ObjectsWithGraphics ObjectType { get; set; }

    private Color objectSymbolColor = Color.Black;

    /// <summary>
    /// Gets or sets the color of the object symbol in case an SVG image is used.
    /// </summary>
    /// <value>The color of the object symbol in case an SVG image is used.</value>
    public Color ObjectSymbolColor
    {
        get => objectSymbolColor;

        set
        {
            if (objectSymbolColor != value)
            {
                objectSymbolColor = value;
                redrawRequired = true;
            }
        }
    }

    private Color objectCircleColor = Color.White;

    /// <summary>
    /// Gets or sets the color of the object circle in case an SVG image is used.
    /// </summary>
    /// <value>The color of the object circle in case an SVG image is used.</value>
    public Color ObjectCircleColor
    {
        get => objectCircleColor;

        set
        {
            if (objectCircleColor != value)
            {
                objectCircleColor = value;
                redrawRequired = true;
            }
        }
    }

    private Image? previousDrawImage;
    private bool redrawRequired = true;

    /// <summary>
    /// Gets the image for drawing the object specified by this <see cref="SolarSystemObjectGraphics"/> instance.
    /// </summary>
    /// <value>The image for the object specified by this instance.</value>
    public Image Image
    {
        get
        {
            if (redrawRequired)
            {
                previousDrawImage?.Dispose();
                previousDrawImage = null;
            }

            if (ObjectImage != null)
            {
                if (redrawRequired || previousDrawImage == null)
                {
                    previousDrawImage = new Bitmap(Diameter, Diameter);
                    using var graphics = Graphics.FromImage(previousDrawImage);
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.DrawImage(ObjectImage, new Rectangle(Point.Empty, new Size(diameter, diameter)));
                    redrawRequired = false;

                    return previousDrawImage;
                }
            }

            if (SvgDocument != null && (redrawRequired || previousDrawImage == null))
            {
                previousDrawImage = ColorizeObjectImage(SvgDocument, ObjectCircleColor, ObjectSymbolColor)
                    .Draw(Diameter, Diameter);

                redrawRequired = false;

                return previousDrawImage;
            }

            if (ImageFile != null)
            {
                if (redrawRequired || previousDrawImage == null)
                {
                    var image = Image.FromFile(ImageFile);
                    previousDrawImage = new Bitmap(Diameter, Diameter);
                    using var graphics = Graphics.FromImage(previousDrawImage);
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.DrawImage(image, new Rectangle(Point.Empty, new Size(diameter, diameter)));
                    redrawRequired = false;

                    return previousDrawImage;
                }
            }

            previousDrawImage ??= new Bitmap(Diameter, Diameter);

            return previousDrawImage;
        }
    }

    /// <summary>
    /// Gets the image using a <see cref="StaticDiameter"/> property for diameter value.
    /// </summary>
    /// <value>The image using a static diameter.</value>
    public Image ImageStaticDiameter
    {
        get
        {
            if (ObjectImage != null)
            {
                var result = new Bitmap(Diameter, Diameter);
                using var graphics = Graphics.FromImage(result);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawImage(ObjectImage,
                    new Rectangle(Point.Empty, new Size(StaticDiameter, StaticDiameter)));

                return result;
            }

            if (SvgDocument != null)
            {
                var result = ColorizeObjectImage(SvgDocument, ObjectCircleColor, ObjectSymbolColor)
                    .Draw(StaticDiameter, StaticDiameter);


                return result;
            }

            if (ImageFile != null)
            {
                var image = Image.FromFile(ImageFile);
                var result = new Bitmap(StaticDiameter, StaticDiameter);
                using var graphics = Graphics.FromImage(result);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawImage(image, new Rectangle(Point.Empty, new Size(StaticDiameter, StaticDiameter)));

                return result;
            }

            return new Bitmap(Diameter, Diameter);
        }
    }

    /// <summary>
    /// Colorizes the object SVG image.
    /// </summary>
    /// <param name="document">The document.</param>
    /// <param name="circleColor">Color of the circle.</param>
    /// <param name="symbolColor">Color of the symbol.</param>
    /// <returns>A new instance of the <see cref="Svg.SvgDocument"/> class colorized by specified colors.</returns>
    public static SvgDocument ColorizeObjectImage(SvgDocument document, Color circleColor, Color symbolColor)
    {
        foreach (var svgElement in document.Descendants())
        {
            if (svgElement is SvgCircle circle)
            {
                circle.Fill = new SvgColourServer(circleColor);
                circle.Stroke = SvgPaintServer.None;
            }

            if (svgElement is SvgPath path)
            {
                path.Fill = new SvgColourServer(symbolColor);
            }
        }

        return document;
    }

    /// <summary>
    /// Saves this instance data into a string format.
    /// </summary>
    /// <returns>This instance data in string format.</returns>
    public string SaveToString()
    {
        var builder = new StringBuilder();
        builder.Append($"{nameof(Locale)}: {Locale}|{nameof(Name)}: {name}|{nameof(ImageFile)}: {ImageFile}");

        if (SvgDocument != null)
        {
            using var stream = new MemoryStream();
            SvgDocument.Write(stream);
            var svgData = Convert.ToBase64String(stream.ToArray());
            builder.Append($"|{nameof(SvgDocument)}: {svgData}");
        }

        if (ObjectImage != null)
        {
            using var stream = new MemoryStream();
            ObjectImage.Save(stream, ObjectImage.RawFormat);
            var imageData = Convert.ToBase64String(stream.ToArray());
            builder.Append($"|{nameof(ObjectImage)}: {imageData}");
        }

        builder.Append($"|{nameof(ObjectType)}: {ObjectType}");

        builder.Append($"|{nameof(Enabled)}: {Enabled}");
        builder.Append($"|{nameof(Diameter)}: {Diameter.ToString(CultureInfo.InvariantCulture)}");

        builder.Append($"|{nameof(ObjectCircleColor)}: {ColorTranslator.ToHtml(ObjectCircleColor)}");
        builder.Append($"|{nameof(ObjectSymbolColor)}: {ColorTranslator.ToHtml(ObjectSymbolColor)}");

        return builder.ToString();
    }

    /// <summary>
    /// Creates a new instance of <see cref="SolarSystemObjectGraphics"/> from a string value.
    /// </summary>
    /// <param name="value">The string value representing the object.</param>
    /// <returns>An instance of the <see cref="SolarSystemObjectGraphics"/> class.</returns>
    public static SolarSystemObjectGraphics FromString(string value)
    {
        var dataEntries = value.Split('|');

        var result = new SolarSystemObjectGraphics();

        foreach (var dataEntry in dataEntries)
        {
            var entryData = dataEntry.Split(':');
            var dataName = entryData[0];
            var dataValue = entryData[1][1..];

            if (dataName == nameof(Locale))
            {
                result.Locale = dataValue;
            }
            else if (dataName == nameof(Name))
            {
                result.Name = dataValue;
            }
            else if (dataName == nameof(ImageFile))
            {
                result.ImageFile = dataValue;
            }
            else if (dataName == nameof(SvgDocument))
            {
                result.SvgDocument = SvgColorize.FromBytes(Convert.FromBase64String(dataValue));
            }
            else if (dataName == nameof(ObjectImage))
            {
                using var stream = new MemoryStream(Convert.FromBase64String(dataValue));
                result.ObjectImage = Image.FromStream(stream);
            }
            else if (dataName == nameof(ObjectType))
            {
                result.ObjectType = Enum.Parse<ObjectsWithGraphics>(dataValue);
            }
            else if (dataName == nameof(Enabled))
            {
                result.Enabled = bool.Parse(dataValue);
            }
            else if (dataName == nameof(Diameter))
            {
                result.Diameter = int.Parse(dataValue, CultureInfo.InvariantCulture);
            }
            else if (dataName == nameof(ObjectCircleColor))
            {
                result.ObjectCircleColor = ColorTranslator.FromHtml(dataValue);
            }
            else if (dataName == nameof(ObjectSymbolColor))
            {
                result.ObjectSymbolColor = ColorTranslator.FromHtml(dataValue);
            }
        }

        return result;
    }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return Name;
    }
}