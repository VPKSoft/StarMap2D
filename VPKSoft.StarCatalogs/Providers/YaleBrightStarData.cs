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
using AASharp;
using VPKSoft.StarCatalogs.Interfaces;

namespace VPKSoft.StarCatalogs.Providers;

/// <summary>
/// Class YaleBrightStarData.
/// Implements the <see cref="IStarData" />
/// </summary>
/// <seealso cref="IStarData" />
public class YaleBrightStarData: StarData, IRightAscensionHms, IDeclinationDms
{
    private string? name;

    /// <summary>
    /// Name, generally Bayer and/or Flamsteed name.
    /// </summary>
    public string Name
    {
        get
        {
            if (!FetchMemory["Name"])
            {
                name ??= GetEntryByName<string>("Name");
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

    private static string ReadRaw(string lineEntry, int index, int end)
    {
        end += 1;
        var result = lineEntry.Substring(index - 1, end - index);
        return result;
    }

    private double? rah;
    private double? ram;
    private double? ras;

    private double? deSign;
    private double? ded;
    private double? dem;
    private double? des;

    private double? declination;
    private double? rightAscension;

    /// <summary>
    /// Gets or sets the right ascension hours.
    /// </summary>
    /// <value>The right ascension hours.</value>
    public double RAh
    {
        get
        {
            if (!FetchMemory["RAh"])
            {
                rah ??= GetEntryByName<double>("RAh");
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

    /// <summary>
    /// Gets or sets the right ascension minutes.
    /// </summary>
    /// <value>The right ascension minutes.</value>
    public double RAm
    {
        get
        {
            if (!FetchMemory["RAm"])
            {
                ram ??= GetEntryByName<double>("RAm");
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


    /// <summary>
    /// Gets or sets the right ascension seconds.
    /// </summary>
    /// <value>The right ascension seconds.</value>
    public double RAs
    {
        get
        {
            if (!FetchMemory["RAs"])
            {
                ras ??= GetEntryByName<double>("RAs");
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

    /// <summary>
    /// Gets or sets the declination sign.
    /// </summary>
    /// <value>The declination sign.</value>
    public double DeSign
    {
        get
        {
            if (!FetchMemory["DE-"])
            {
                var sign = GetEntryByName<string?>("DE-");
                var no = "1";
                if (sign != null)
                {
                    deSign ??= double.Parse(sign + no, CultureInfo.InvariantCulture);
                }

                FetchMemory["DE-"] = true;
            }

            return deSign ?? 0;
        }

        set
        {
            FetchMemory["DE-"] = true;
            deSign = value;
        }
    }


    /// <summary>
    /// Gets or sets the declination degrees.
    /// </summary>
    /// <value>The declination degrees.</value>
    public double DeD
    {
        get
        {
            if (!FetchMemory["DEd"])
            {
                ded ??= GetEntryByName<double?>("DEd");
                FetchMemory["DEd"] = true;

                if (ded != null)
                {
                    ded *= DeSign;
                }
            }

            return ded ?? 0;
        }

        set
        {
            FetchMemory["DEd"] = true;
            ded = value;
        }
    }

    /// <summary>
    /// Gets or sets the declination minutes.
    /// </summary>
    /// <value>The declination minutes.</value>
    public double Dem
    {
        get
        {
            if (!FetchMemory["DEm"])
            {
                dem ??= GetEntryByName<double>("DEm");
                FetchMemory["DEm"] = true;
            }

            return dem ?? 0;
        }

        set
        {
            FetchMemory["DEm"] = true;
            dem = value;
        }
    }

    /// <summary>
    /// Gets or sets the declination seconds.
    /// </summary>
    /// <value>The declination seconds.</value>
    public double Des
    {
        get
        {
            if (!FetchMemory["DEs"])
            {
                des ??= GetEntryByName<double>("DEs");
                FetchMemory["DEs"] = true;
            }

            return des ?? 0;
        }

        set
        {
            FetchMemory["DEs"] = true;
            des = value;
        }
    }

    private double? magnitude;

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

    /// <inheritdoc cref="IStarData.RightAscension"/>
    /// <exception cref="System.InvalidOperationException"></exception>
    public override double RightAscension
    {
        get
        {
            if (!FetchMemory[nameof(RightAscension)])
            {
                rightAscension ??= RAh + RAm / 60 + RAs / 3600;
                FetchMemory[nameof(RightAscension)] = true;
            }

            return rightAscension ?? 0;
        }

        set => throw new InvalidOperationException($"{nameof(RightAscension)} is a calculated value.");
    }

    /// <inheritdoc cref="IStarData.Declination" />
    /// <exception cref="System.InvalidOperationException"></exception>
    public override double Declination
    {
        get
        {
            if (!FetchMemory[nameof(Declination)])
            {
                declination ??= AASCoordinateTransformation.DMSToDegrees(DeD, Dem, Des);
                FetchMemory[nameof(Declination)] = true;
            }

            return declination?? 0;
        }

        set => throw new InvalidOperationException($"{nameof(Declination)} is a calculated value.");
    }

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

        var dataIndex = FieldNameList.IndexOf(dataName);

        if (dataIndex != -1)
        {
            return ReadRaw(rawDataEntry, FieldPositions[dataIndex].start, FieldPositions[dataIndex].end);
        }

        return string.Empty;
    }

    private static List<string> FieldNameList { get; } = new();

    private static readonly (int start, int end)[] FieldPositions =
    {
        (1, 4),
        (5, 14),
        (15, 25),
        (26, 31),
        (32, 37),
        (38, 41),
        (42, 42),
        (43, 43),
        (44, 44),
        (45, 49),
        (50, 51),
        (52, 60),
        (61, 62),
        (63, 64),
        (65, 68),
        (69, 69),
        (70, 71),
        (72, 73),
        (74, 75),
        (76, 77),
        (78, 79),
        (80, 83),
        (84, 84),
        (85, 86),
        (87, 88),
        (89, 90),
        (91, 96),
        (97, 102),
        (103, 107),
        (108, 108),
        (109, 109),
        (110, 114),
        (115, 115),
        (116, 120),
        (121, 121),
        (122, 126),
        (127, 127),
        (128, 147),
        (148, 148),
        (149, 154),
        (155, 160),
        (161, 161),
        (162, 166),
        (167, 170),
        (171, 174),
        (175, 176),
        (177, 179),
        (180, 180),
        (181, 184),
        (185, 190),
        (191, 194),
        (195, 196),
        (197, 197),
    };

    /// <summary>
    /// The field names of the star data of this provider.
    /// </summary>
    public static readonly string[] FieldNames =
    {
        "HR",
        "Name",
        "DM",
        "HD",
        "SAO",
        "FK5",
        "IRflag",
        "r_IRflag",
        "Multiple",
        "ADS",
        "ADScomp",
        "VarID",
        "RAh1900",
        "RAm1900",
        "RAs1900",
        "DE-1900",
        "DEd1900",
        "DEm1900",
        "DEs1900",
        "RAh",
        "RAm",
        "RAs",
        "DE-",
        "DEd",
        "DEm",
        "DEs",
        "GLON",
        "GLAT",
        "Vmag",
        "n_Vmag",
        "u_Vmag",
        "B-V",
        "u_B-V",
        "U-B",
        "u_U-B",
        "R-I",
        "n_R-I",
        "SpType",
        "n_SpType",
        "pmRA",
        "pmDE",
        "n_Parallax",
        "Parallax",
        "RadVel",
        "n_RadVel",
        "l_RotVel",
        "RotVel",
        "u_RotVel",
        "Dmag",
        "Sep",
        "MultID",
        "MultCnt",
        "NoteFlag1",
    };
}