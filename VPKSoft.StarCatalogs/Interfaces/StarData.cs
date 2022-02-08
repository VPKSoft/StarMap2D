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

using VPKSoft.StarCatalogs.PrimitiveProperty;

namespace VPKSoft.StarCatalogs.Interfaces;

/// <summary>
/// A class to containing line data for a single star.
/// Implements the <see cref="VPKSoft.StarCatalogs.Interfaces.IStarData" />
/// </summary>
/// <seealso cref="VPKSoft.StarCatalogs.Interfaces.IStarData" />
public abstract class StarData: IStarData
{
    /// <inheritdoc cref="IStarData.RightAscension"/>
    public virtual double RightAscension { get; set; }

    /// <inheritdoc cref="IStarData.Declination"/>
    public virtual double Declination { get; set; }

    /// <inheritdoc cref="IStarData.Magnitude"/>
    public virtual double Magnitude { get; set; }

    /// <inheritdoc cref="IStarData.RawData"/>
    public virtual string? RawData { get; set; }

    /// <inheritdoc cref="IStarData.GetStarData"/>
    public IStarData.GetStarDataDelegate? GetStarData { get; set; }

    /// <summary>
    /// A dictionary to remember which properties have been parsed from the <see cref="RawData"/>.
    /// </summary>
    public DefaultDictionary<string, bool> FetchMemory { get; } = new();

    /// <summary>
    /// Gets an entry from a (line-formatted) data and tries to convert it to type of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The requested type.</typeparam>
    /// <param name="name">The name of the type value within the <see cref="RawData"/> string.</param>
    /// <returns>A System.Nullable&lt;T&gt; containing the requested value if the operation was successful; otherwise null.</returns>
    public virtual T? GetEntryByName<T>(string name)
    {
        var value = GetStarData?.Invoke(RawData, name);

        return StringToPrimitiveConvert.ToPrimitiveNullable<T>(value);
    }
}