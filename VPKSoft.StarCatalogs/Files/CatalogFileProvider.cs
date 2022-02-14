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

using VPKSoft.StarCatalogs.Interfaces;
using VPKSoft.StarCatalogs.Providers;

namespace VPKSoft.StarCatalogs.Files;

/// <summary>
/// A class to provide file names for the star catalog types.
/// </summary>
public class CatalogFileProvider
{
    /// <summary>
    /// Gets or sets the base folder for the star catalogs.
    /// </summary>
    /// <value>The base folder.</value>
    public static string BaseFolder { get; set; } = string.Empty;

    internal const string CNS3 = "CNS3/catalog.dat";
    internal const string Hipparcos = "Hipparcos/hip_main.dat";
    internal const string Tycho = "Hipparcos/tyc_main.dat";
    internal const string HYGv3_0 = "HYG 3.0/hygdata_v3.csv";
    internal const string PPM = "PPM/PPM";
    internal const string PPMRaSorted = "PPM/PPMra";
    internal const string YaleBrightStar = "Yale Bright Star Catalog 5th/bsc5.dat";
    internal const string YaleSmall = "YaleSmall/yale.dat";

    /// <summary>
    /// Gets a star catalog instance.
    /// </summary>
    /// <param name="catalogType">Type of the catalog.</param>
    /// <param name="magnitudeLimit">The lower magnitude limit (more is less).</param>
    /// <param name="isPpmRa">if set to <c>true</c> if the data is in PPMra format (only for the PPM Star Catalog).</param>
    /// <returns>IStarDataProvider&lt;IStarData&gt;.</returns>
    /// <exception cref="System.NotImplementedException">Load method for: '{CatalogType}'.</exception>
    public static IStarDataProvider<IStarData> GetCatalog(Type catalogType, double magnitudeLimit = double.MaxValue,
        bool isPpmRa = false)
    {
        if (catalogType == typeof(Gliese3rdProvider))
        {
            return GetCatalog<Gliese3rdProvider>(magnitudeLimit, isPpmRa);
        }

        if (catalogType == typeof(HipparcosProvider))
        {
            return GetCatalog<HipparcosProvider>(magnitudeLimit, isPpmRa);
        }

        if (catalogType == typeof(HygV3Provider))
        {
            return GetCatalog<HygV3Provider>(magnitudeLimit, isPpmRa);
        }

        if (catalogType == typeof(TychoProvider))
        {
            return GetCatalog<TychoProvider>(magnitudeLimit, isPpmRa);
        }

        if (catalogType == typeof(YaleBrightProvider))
        {
            return GetCatalog<YaleBrightProvider>(magnitudeLimit, isPpmRa);
        }

        if (catalogType == typeof(YaleSmallProvider))
        {
            return GetCatalog<YaleSmallProvider>(magnitudeLimit, isPpmRa);
        }

        if (catalogType == typeof(PpmProvider))
        {
            return GetCatalog<PpmProvider>(magnitudeLimit, isPpmRa);
        }

        throw new NotImplementedException($"Load method for: '{catalogType.Name}'.");
    }

    /// <summary>
    /// Gets the name of the catalog file for specified catalog type.
    /// </summary>
    /// <param name="catalogType">Type of the catalog.</param>
    /// <param name="isPpmRa">if set to <c>true</c> if the data is in PPMra format (only for the PPM Star Catalog).</param>
    /// <returns>The file name for the star catalog.</returns>
    public static string GetCatalogFileName(Type catalogType, bool isPpmRa = false)
    {
        if (catalogType == typeof(Gliese3rdProvider))
        {
            return Path.Combine(BaseFolder, CNS3);
        }

        if (catalogType == typeof(HipparcosProvider))
        {
            return Path.Combine(BaseFolder, Hipparcos);
        }

        if (catalogType == typeof(HygV3Provider))
        {
            return Path.Combine(BaseFolder, HYGv3_0);
        }

        if (catalogType == typeof(TychoProvider))
        {
            return Path.Combine(BaseFolder, Tycho);
        }

        if (catalogType == typeof(YaleBrightProvider))
        {
            return Path.Combine(BaseFolder, YaleBrightStar);
        }

        if (catalogType == typeof(YaleSmallProvider))
        {
            return Path.Combine(BaseFolder, YaleSmall);
        }

        if (catalogType == typeof(PpmProvider))
        {
            return Path.Combine(BaseFolder, isPpmRa ? PPMRaSorted : PPM);
        }

        return string.Empty;
    }

    /// <summary>
    /// Gets a star catalog instance.
    /// </summary>
    /// <typeparam name="T">The type of the star catalog instance to get.</typeparam>
    /// <param name="magnitudeLimit">The lower magnitude limit (more is less).</param>
    /// <param name="isPpmRa">if set to <c>true</c> if the data is in PPMra format (only for the PPM Star Catalog).</param>
    /// <returns>T.</returns>
    /// <exception cref="System.InvalidOperationException">An argument: 'bool isPpmRa' is required for the constructor of '{nameof(PpmProvider)}'.</exception>
    /// <exception cref="System.NotImplementedException">Load method for: '{CatalogType}'.</exception>
    public static T GetCatalog<T>(double magnitudeLimit = double.MaxValue, bool isPpmRa = false) where T : IStarDataProvider<IStarData>
    {
        if (typeof(T) == typeof(Gliese3rdProvider))
        {
            var result = (IStarDataProvider<IStarData>)new Gliese3rdProvider();
            result.LoadData(GetCatalogFileName(typeof(T)), magnitudeLimit);
            return (T)result;
        }

        if (typeof(T) == typeof(HipparcosProvider))
        {
            var result = (IStarDataProvider<IStarData>)new HipparcosProvider();
            result.LoadData(GetCatalogFileName(typeof(T)), magnitudeLimit);
            return (T)result;
        }

        if (typeof(T) == typeof(HygV3Provider))
        {
            var result = (IStarDataProvider<IStarData>)new HygV3Provider();
            result.LoadData(GetCatalogFileName(typeof(T)), magnitudeLimit);
            return (T)result;
        }

        if (typeof(T) == typeof(TychoProvider))
        {
            var result = (IStarDataProvider<IStarData>)new TychoProvider();
            result.LoadData(GetCatalogFileName(typeof(T)), magnitudeLimit);
            return (T)result;
        }

        if (typeof(T) == typeof(YaleBrightProvider))
        {
            var result = (IStarDataProvider<IStarData>)new YaleBrightProvider();
            result.LoadData(GetCatalogFileName(typeof(T)), magnitudeLimit);
            return (T)result;
        }

        if (typeof(T) == typeof(YaleSmallProvider))
        {
            var result = (IStarDataProvider<IStarData>)new YaleSmallProvider();
            result.LoadData(GetCatalogFileName(typeof(T)), magnitudeLimit);
            return (T)result;
        }

        if (typeof(T) == typeof(PpmProvider))
        {
            var result = (IStarDataProvider<IStarData>)new PpmProvider(isPpmRa);
            result.LoadData(GetCatalogFileName(typeof(T), isPpmRa), magnitudeLimit);
            return (T)result;
        }

        throw new NotImplementedException($"Load method for: '{nameof(T)}'.");
    }
}