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
using StarMap2D.Calculations.Helpers.Math;
using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers;

/// <summary>
/// Star data entry for the Tycho catalog.
/// Implements the <see cref="IStarData" />
/// </summary>
/// <seealso cref="IStarData" />
public class TychoStarData: StarData, IRightAscensionHms, IDeclinationDms
{
    private string? tyc;
    private double? magnitude;

    private string? name;

    /// <summary>
    /// The star name.
    /// </summary>
    public string Name
    {
        get
        {
            if (!FetchMemory["Name"])
            {
                name ??= GetEntryByName<string>("Name")?.Trim();
                FetchMemory["Name"] = true;
            }

            return name ?? string.Empty;
        }

        set
        {
            FetchMemory["Name"] = true;
            name = value;
        }
    }

    /// <summary>
    /// Gets or sets the TYC number.
    /// </summary>
    /// <value>The TYC number.</value>
    // ReSharper disable once InconsistentNaming
    public string? TYC
    {
        get
        {
            if (!FetchMemory["TYC"])
            {
                tyc = GetEntryByName<string?>("TYC")?.Trim();
                FetchMemory["TYC"] = true;
            }
                
            return tyc;
        }
            
        set
        {
            FetchMemory["TYC"] = true;
            tyc = value;
        }
    }

    /// <inheritdoc cref="IStarData.Magnitude"/>
    public override double Magnitude 
    {
        get
        {
            if (!FetchMemory["Vmag"])
            {
                magnitude ??= GetEntryByName<double>("Vmag");
                FetchMemory["Vmag"] = true;
            }
                
            return magnitude ?? 0;
        }


        set
        {
            FetchMemory["Vmag"] = true;
            magnitude = value;
        } 
    }

    private string? raHms;

    /// <summary>
    /// Gets or sets the right ascension in hours, minutes and seconds format.
    /// </summary>
    public string? RAhms
    {
        get
        {
            if (!FetchMemory["RAhms"])
            {
                raHms = GetEntryByName<string?>("RAhms")?.Trim();
                FetchMemory["RAhms"] = true;
            }
                
            return raHms;
        }
            
        set
        {
            FetchMemory["RAhms"] = true;
            raHms = value;
        }
    }

    private string? deDms;

    /// <summary>
    /// Gets or sets the declination in degrees, minutes and seconds format.
    /// </summary>
    public string? DEdms
    {
        get
        {
            if (!FetchMemory["DEdms"])
            {
                deDms = GetEntryByName<string?>("DEdms")?.Trim();
                FetchMemory["DEdms"] = true;
            }
                
            return deDms;
        }
            
        set
        {
            FetchMemory["DEdms"] = true;
            deDms = value;
        }
    }

    private double? rah;
    private double? ram;
    private double? ras;
    private double? ded;
    private double? dem;
    private double? des;

    /// <inheritdoc cref="IRightAscensionHms.RAh"/>
    public double RAh {
        get
        {
            if (!FetchMemory["RAh"])
            {
                rah = double.Parse(RAhms?.Split(' ')[0] ?? "0", CultureInfo.InvariantCulture);
                FetchMemory["RAh"] = true;
            }

            return rah ?? 0;
        }

        set
        {
            FetchMemory["RAh"] = true;
            rah = value;
        }
    }

    /// <inheritdoc cref="IRightAscensionHms.RAm"/>
    public double RAm {
        get
        {
            if (!FetchMemory["RAm"])
            {
                ram = double.Parse(RAhms?.Split(' ')[1] ?? "0", CultureInfo.InvariantCulture);
                FetchMemory["RAm"] = true;
            }

            return ram ?? 0;
        }

        set
        {
            FetchMemory["RAm"] = true;
            ram = value;
        }
    }

    /// <inheritdoc cref="IRightAscensionHms.RAs"/>
    public double RAs
    {
        get
        {
            if (!FetchMemory["RAs"])
            {
                ras = double.Parse(RAhms?.Split(' ')[2] ?? "0", CultureInfo.InvariantCulture);
                FetchMemory["RAs"] = true;
            }

            return ras ?? 0;
        }

        set
        {
            FetchMemory["RAs"] = true;
            ras = value;
        }
    }

    /// <inheritdoc cref="IDeclinationDms.DeD"/>
    public double DeD
    {
        get
        {
            if (!FetchMemory["DeD"])
            {
                ded = double.Parse(DEdms?.Split(' ')[0] ?? "0", CultureInfo.InvariantCulture);
                FetchMemory["DeD"] = true;
            }

            return ded ?? 0;
        }

        set
        {
            FetchMemory["DEd"] = true;
            ded = value;
        }
    }

    /// <inheritdoc cref="IDeclinationDms.Dem"/>
    public double Dem
    {
        get
        {
            if (!FetchMemory["Dem"])
            {
                dem = double.Parse(DEdms?.Split(' ')[1] ?? "0", CultureInfo.InvariantCulture);
                FetchMemory["Dem"] = true;
            }

            return dem ?? 0;
        }

        set
        {
            FetchMemory["Dem"] = true;
            dem = value;
        }
    }

    /// <inheritdoc cref="IDeclinationDms.Des"/>
    public double Des
    {
        get
        {
            if (!FetchMemory["Des"])
            {
                des = double.Parse(DEdms?.Split(' ')[2] ?? "0", CultureInfo.InvariantCulture);
                FetchMemory["Des"] = true;
            }

            return des ?? 0;
        }

        set
        {
            FetchMemory["Des"] = true;
            des = value;
        }
    }

    private double rightAscension;
    private double declination;

    /// <inheritdoc cref="IStarData.RightAscension"/>
    /// <exception cref="System.InvalidOperationException"></exception>
    public override double RightAscension
    {
        get
        {
            if (!FetchMemory["RightAscension"])
            {
                rightAscension = RAh + RAm / 60 + RAs / 3600;
                FetchMemory["RightAscension"] = true;
            }

            return rightAscension;
        }

        set => throw new InvalidOperationException($"{nameof(RightAscension)} is a calculated value.");
    }

    /// <inheritdoc cref="IStarData.Declination"/>
    /// <exception cref="System.InvalidOperationException"></exception>
    public override double Declination
    {
        get
        {
            if (!FetchMemory["Declination"])
            {
                declination = DmsConvert.DmsToDegrees(DeD, Dem, Des);
                FetchMemory["Declination"] = true;
            }

            return declination;
        }

        set => throw new InvalidOperationException($"{nameof(Declination)} is a calculated value.");
    }

    private static List<string> FieldNameList { get; } = new();

    /// <summary>
    /// Gets the raw data of the star based by the data field name.
    /// </summary>
    /// <param name="rawDataEntry">The raw data entry.</param>
    /// <param name="dataName">Name of the data.</param>
    /// <returns>A string containing the raw string data extracted from the <paramref name="rawDataEntry"/> if found; <c>null</c> otherwise.</returns>
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

        if (!FieldNames.Contains(dataName))
        {
            return null;
        }

        var index = new List<string>(FieldNames).IndexOf(dataName);

        return ReadRaw(rawDataEntry, FieldPositions[index].start, FieldPositions[index].end);
    }

    private static string ReadRaw(string lineEntry, int index, int end)
    {
        end += 1;
        var result = lineEntry.Substring(index - 1, end - index);
        return result;
    }


    /// <summary>
    /// The field names of the star data of this provider.
    /// </summary>
    public static readonly string[] FieldNames =
    {
        "Catalog",
        "TYC",
        "Proxy",
        "RAhms",
        "DEdms",
        "Vmag",
        "---N/A_1", // Reserved field.
        "r_Vmag",
        "RAdeg",
        "DEdeg",
        "AstroRef",
        "Plx",
        "pmRA",
        "pmDE",
        "e_RAdeg",
        "e_DEdeg",
        "e_Plx",
        "e_pmRA",
        "e_pmDE",
        "DE:RA",
        "Plx:RA",
        "Plx:DE",
        "pmRA:RA",
        "pmRA:DE",
        "pmRA:Plx",
        "pmDE:RA",
        "pmDE:DE",
        "pmDE:Plx",
        "pmDE:pmRA",
        "Nastro",
        "F2",
        "HIP",
        "BTmag",
        "e_BTmag",
        "VTmag",
        "e_VTmag",
        "r_BTmag",
        "B-V",
        "e_B-V",
        "---N/A_2", // Reserved field.
        "Q",
        "Fs",
        "Source",
        "Nphoto",
        "VTscat",
        "VTmax",
        "VTmin",
        "Var",
        "VarFlag",
        "MultFlag",
        "morePhoto",
        "m_HIP",
        "PPM",
        "HD",
        "BD",
        "CoD",
        "CPD",
        "Remark",
    };

    private static readonly (int start, int end)[] FieldPositions =
    {
        (1, 1),
        (3, 14),
        (16, 16),
        (18, 28),
        (30, 40),
        (42, 46),
        (48, 48),
        (50, 50),
        (52, 63),
        (65, 76),
        (78, 78),
        (80, 86),
        (88, 95),
        (97, 104),
        (106, 111),
        (113, 118),
        (120, 125),
        (127, 132),
        (134, 139),
        (141, 145),
        (147, 151),
        (153, 157),
        (159, 163),
        (165, 169),
        (171, 175),
        (177, 181),
        (183, 187),
        (189, 193),
        (195, 199),
        (201, 203),
        (205, 209),
        (211, 216),
        (218, 223),
        (225, 229),
        (231, 236),
        (238, 242),
        (244, 244),
        (246, 251),
        (253, 257),
        (259, 259),
        (261, 261),
        (263, 266),
        (268, 268),
        (270, 272),
        (274, 278),
        (280, 284),
        (286, 290),
        (292, 292),
        (294, 294),
        (296, 296),
        (298, 298),
        (300, 301),
        (303, 308),
        (310, 315),
        (317, 326),
        (328, 337),
        (339, 348),
        (350, 350),
    };
}