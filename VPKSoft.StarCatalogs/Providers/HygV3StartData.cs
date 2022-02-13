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
using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers;

/// <summary>
/// Star data entry for the HYG v.3.0 database.
/// Implements the <see cref="IStarData" />
/// </summary>
/// <seealso cref="IStarData" />
public class HygV3StartData : StarData
{
    /// <summary>
    /// Gets or sets the proper name of the star if any.
    /// </summary>
    /// <value>The proper name of the star.</value>
    public string? Proper
    {
        get
        {
            if (!FetchMemory["proper"])
            {
                proper = GetEntryByName<string?>("proper")?.Trim();
                FetchMemory["proper"] = true;
            }

            return proper;
        }

        set
        {
            FetchMemory["proper"] = true;
            proper = value;
        }
    }

    private string? bayerFlamsteed;

    /// <summary>
    /// Gets or sets the Bayer-Flamsteed name for the star if any.
    /// </summary>
    /// <value>The Bayer-Flamsteed name.</value>
    public string? BayerFlamsteed
    {
        get
        {
            if (!FetchMemory["bf"])
            {
                bayerFlamsteed = GetEntryByName<string?>("bf")?.Trim();
                FetchMemory["bf"] = true;
            }

            return bayerFlamsteed;
        }

        set
        {
            FetchMemory["bf"] = true;
            bayerFlamsteed = value;
        }
    }

    /// <summary>
    /// Gets or sets the Hipparcos identifier for the data entry.
    /// </summary>
    /// <value>The Hipparcos identifier for the data entry.</value>
    // ReSharper disable once InconsistentNaming
    public int? HIP
    {
        get
        {
            if (!FetchMemory["hip"])
            {
                hip = GetEntryByName<int?>("hip");
                FetchMemory["hip"] = true;
            }

            return hip;
        }

        set
        {
            FetchMemory["hip"] = true;
            hip = value;
        }
    }

    private double? declination;
    private double? rightAscension;
    private double? magnitude;
    private string? proper;
    private int? hip;

    /// <inheritdoc cref="IStarData.Declination"/>
    public override double Declination
    {
        get
        {
            if (!FetchMemory["dec"])
            {
                declination ??= GetEntryByName<double>("dec");
                FetchMemory["dec"] = true;
            }

            return declination ?? 0;
        }

        set
        {
            FetchMemory["dec"] = true;
            declination = value;
        }
    }

    /// <inheritdoc cref="IStarData.RightAscension"/>
    public override double RightAscension
    {
        get
        {
            if (!FetchMemory["ra"])
            {
                rightAscension ??= GetEntryByName<double>("ra");
                FetchMemory["ra"] = true;
            }

            return rightAscension ?? 0;
        }

        set
        {
            FetchMemory["dec"] = true;
            rightAscension = value;
        }
    }

    /// <inheritdoc cref="IStarData.Magnitude"/>
    public override double Magnitude
    {
        get
        {
            if (!FetchMemory["mag"])
            {
                magnitude ??= GetEntryByName<double>("mag");
                FetchMemory["mag"] = true;
            }

            return magnitude ?? 0;
        }


        set
        {
            FetchMemory["mag"] = true;
            magnitude = value;
        }
    }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string? ToString()
    {
        return string.IsNullOrEmpty(Proper) ? HIP?.ToString(CultureInfo.InvariantCulture) ?? base.ToString() : Proper;
    }

    /// <summary>
    /// The field names of the star data of this provider.
    /// </summary>
    public static readonly string[] FieldNames =
    {
        "id",
        "hip",
        "hd",
        "hr",
        "gl",
        "bf",
        "proper",
        "ra",
        "dec",
        "dist",
        "pmra",
        "pmdec",
        "rv",
        "mag",
        "absmag",
        "spect",
        "ci",
        "x",
        "y",
        "z",
        "vx",
        "vy",
        "vz",
        "rarad",
        "decrad",
        "pmrarad",
        "pmdecrad",
        "bayer",
        "flam",
        "con",
        "comp",
        "comp_primary",
        "base",
        "lum",
        "var",
        "var_min",
        "var_max",
    };

    private static List<string> FieldNameList { get; } = new();

    /// <summary>
    /// Gets the raw data of the star based by the data field name.
    /// </summary>
    /// <param name="rawDataEntry">The raw data entry.</param>
    /// <param name="dataName">Name of the data.</param>
    /// <returns>System.String.</returns>
    public static string? GetDataRaw(string? rawDataEntry, string dataName)
    {
        if (rawDataEntry == null)
        {
            return null;
        }

        if (FieldNameList.Count == 0)
        {
            FieldNameList.AddRange(FieldNames);
        }

        var dataIndex = FieldNameList.IndexOf(dataName);

        if (dataIndex != -1)
        {
            return rawDataEntry.Split(',')[dataIndex];
        }

        return string.Empty;
    }
}