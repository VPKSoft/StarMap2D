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

using VPKSoft.StarCatalogs.Providers;

namespace VPKSoft.StarCatalogs.StaticData;

/// <summary>
/// A class for star catalog names.
/// </summary>
public class CatalogNames
{
    /// <summary>
    /// The built-in star catalog name.
    /// </summary>
    public const string BuiltInName = "The Yale Bright Star Catalogue, 5th Revised Ed.";

    private static int id = 1;

    /// <summary>
    /// Gets or sets the type-name pairs for the supported star catalogs.
    /// </summary>
    public static List<StarCatalogData> TypeNames { get; set; } = new(new[]
    {
        new StarCatalogData { Name = "The Hipparcos Catalogue", Type = typeof(HipparcosProvider), Identifier = id++, },
        new StarCatalogData { Name = "The Tycho Catalogue", Type = typeof(TychoProvider), Identifier = id++, },
        new StarCatalogData { Name = "The PPM Star Catalog", Type = typeof(PpmProvider), Identifier = id++, },
        new StarCatalogData
            { Name = "The Yale Bright Star Catalogue, 5th Revised Ed.", Type = typeof(YaleBrightProvider), Identifier = id++, },
        new StarCatalogData
            { Name = "Nearby Stars, Preliminary 3rd Version (Gliese+ 1991)", Type = typeof(Gliese3rdProvider), Identifier = id++, },
        new StarCatalogData { Name = "Yale small (unknown origin)", Type = typeof(YaleSmallProvider), Identifier = id++, },
    });
}