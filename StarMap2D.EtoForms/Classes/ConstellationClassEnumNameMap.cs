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

using StarMap2D.Calculations.Constellations.ConstellationClasses;
using StarMap2D.Calculations.Constellations.Enumerations;
using StarMap2D.Calculations.Constellations.StaticData;
using System;
using System.Collections.Generic;

namespace StarMap2D.EtoForms.Classes;

/// <summary>
/// A class to map the constellation localizations with their types and enumeration values.
/// Implements the <see cref="StarMap2D.Calculations.Constellations.StaticData.ConstellationClassEnumMap" />
/// </summary>
/// <seealso cref="StarMap2D.Calculations.Constellations.StaticData.ConstellationClassEnumMap" />
public class ConstellationClassEnumNameMap : ConstellationClassEnumMap
{
    /// <summary>
    /// Gets or sets the name of the constellation.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConstellationClassEnumNameMap"/> class.
    /// </summary>
    /// <param name="constellation">The constellation.</param>
    /// <param name="constellationClassType">Type of the constellation class.</param>
    /// <param name="name">The name of the constellation.</param>
    public ConstellationClassEnumNameMap(ConstellationValue constellation, Type constellationClassType, string name) :
        base(constellation, constellationClassType)
    {
        Name = name;
    }

    /// <summary>
    /// Gets or sets the constellation class types, enum values and their names.
    /// </summary>
    /// <value>The constellation class types, enum values and their names.</value>
    public static IReadOnlyList<ConstellationClassEnumNameMap> ConstellationClassesEnumsNames { get; set; } =
        Array.Empty<ConstellationClassEnumNameMap>();

    /// <summary>
    /// Generates the data to the <see cref="ConstellationClassesEnumsNames"/> collection based on the current thread locale.
    /// </summary>
    public static void GenerateData()
    {
        var newData = new ConstellationClassEnumNameMap[]
        {
            new(constellation: ConstellationValue.Hydra, constellationClassType: typeof(Hydra), Localization.Constellations.Hydra),
            new(constellation: ConstellationValue.Virgo, constellationClassType: typeof(Virgo), Localization.Constellations.Virgo),
            new(constellation: ConstellationValue.UrsaMajor, constellationClassType: typeof(UrsaMajor), Localization.Constellations.UrsaMajor),
            new(constellation: ConstellationValue.Cetus, constellationClassType: typeof(Cetus), Localization.Constellations.Cetus),
            new(constellation: ConstellationValue.Hercules, constellationClassType: typeof(Hercules), Localization.Constellations.Hercules),
            new(constellation: ConstellationValue.Eridanus, constellationClassType: typeof(Eridanus), Localization.Constellations.Eridanus),
            new(constellation: ConstellationValue.Pegasus, constellationClassType: typeof(Pegasus), Localization.Constellations.Pegasus),
            new(constellation: ConstellationValue.Draco, constellationClassType: typeof(Draco), Localization.Constellations.Draco),
            new(constellation: ConstellationValue.Centaurus, constellationClassType: typeof(Centaurus), Localization.Constellations.Centaurus),
            new(constellation: ConstellationValue.Aquarius, constellationClassType: typeof(Aquarius), Localization.Constellations.Aquarius),
            new(constellation: ConstellationValue.Ophiuchus, constellationClassType: typeof(Ophiuchus), Localization.Constellations.Ophiuchus),
            new(constellation: ConstellationValue.Leo, constellationClassType: typeof(Leo), Localization.Constellations.Leo),
            new(constellation: ConstellationValue.Boötes, constellationClassType: typeof(Boötes), Localization.Constellations.Boötes),
            new(constellation: ConstellationValue.Pisces, constellationClassType: typeof(Pisces), Localization.Constellations.Pisces),
            new(constellation: ConstellationValue.Sagittarius, constellationClassType: typeof(Sagittarius), Localization.Constellations.Sagittarius),
            new(constellation: ConstellationValue.Cygnus, constellationClassType: typeof(Cygnus), Localization.Constellations.Cygnus),
            new(constellation: ConstellationValue.Taurus, constellationClassType: typeof(Taurus), Localization.Constellations.Taurus),
            new(constellation: ConstellationValue.Camelopardalis, constellationClassType: typeof(Camelopardalis), Localization.Constellations.Camelopardalis),
            new(constellation: ConstellationValue.Andromeda, constellationClassType: typeof(Andromeda), Localization.Constellations.Andromeda),
            new(constellation: ConstellationValue.Puppis, constellationClassType: typeof(Puppis), Localization.Constellations.Puppis),
            new(constellation: ConstellationValue.Auriga, constellationClassType: typeof(Auriga), Localization.Constellations.Auriga),
            new(constellation: ConstellationValue.Aquila, constellationClassType: typeof(Aquila), Localization.Constellations.Aquila),
            new(constellation: ConstellationValue.SerpensCauda, constellationClassType: typeof(SerpensCauda), Localization.Constellations.SerpensCauda),
            new(constellation: ConstellationValue.SerpensCaput, constellationClassType: typeof(SerpensCaput), Localization.Constellations.SerpensCaput),
            new(constellation: ConstellationValue.Perseus, constellationClassType: typeof(Perseus), Localization.Constellations.Perseus),
            new(constellation: ConstellationValue.Cassiopeia, constellationClassType: typeof(Cassiopeia), Localization.Constellations.Cassiopeia),
            new(constellation: ConstellationValue.Orion, constellationClassType: typeof(Orion), Localization.Constellations.Orion),
            new(constellation: ConstellationValue.Cepheus, constellationClassType: typeof(Cepheus), Localization.Constellations.Cepheus),
            new(constellation: ConstellationValue.Lynx, constellationClassType: typeof(Lynx), Localization.Constellations.Lynx),
            new(constellation: ConstellationValue.Libra, constellationClassType: typeof(Libra), Localization.Constellations.Libra),
            new(constellation: ConstellationValue.Gemini, constellationClassType: typeof(Gemini), Localization.Constellations.Gemini),
            new(constellation: ConstellationValue.Cancer, constellationClassType: typeof(Cancer), Localization.Constellations.Cancer),
            new(constellation: ConstellationValue.Vela, constellationClassType: typeof(Vela), Localization.Constellations.Vela),
            new(constellation: ConstellationValue.Scorpius, constellationClassType: typeof(Scorpius), Localization.Constellations.Scorpius),
            new(constellation: ConstellationValue.Carina, constellationClassType: typeof(Carina), Localization.Constellations.Carina),
            new(constellation: ConstellationValue.Monoceros, constellationClassType: typeof(Monoceros), Localization.Constellations.Monoceros),
            new(constellation: ConstellationValue.Sculptor, constellationClassType: typeof(Sculptor), Localization.Constellations.Sculptor),
            new(constellation: ConstellationValue.Phoenix, constellationClassType: typeof(Phoenix), Localization.Constellations.Phoenix),
            new(constellation: ConstellationValue.CanesVenatici, constellationClassType: typeof(CanesVenatici), Localization.Constellations.CanesVenatici),
            new(constellation: ConstellationValue.Aries, constellationClassType: typeof(Aries), Localization.Constellations.Aries),
            new(constellation: ConstellationValue.Capricornus, constellationClassType: typeof(Capricornus), Localization.Constellations.Capricornus),
            new(constellation: ConstellationValue.Fornax, constellationClassType: typeof(Fornax), Localization.Constellations.Fornax),
            new(constellation: ConstellationValue.ComaBerenices, constellationClassType: typeof(ComaBerenices), Localization.Constellations.ComaBerenices),
            new(constellation: ConstellationValue.CanisMajor, constellationClassType: typeof(CanisMajor), Localization.Constellations.CanisMajor),
            new(constellation: ConstellationValue.Pavo, constellationClassType: typeof(Pavo), Localization.Constellations.Pavo),
            new(constellation: ConstellationValue.Grus, constellationClassType: typeof(Grus), Localization.Constellations.Grus),
            new(constellation: ConstellationValue.Lupus, constellationClassType: typeof(Lupus), Localization.Constellations.Lupus),
            new(constellation: ConstellationValue.Sextans, constellationClassType: typeof(Sextans), Localization.Constellations.Sextans),
            new(constellation: ConstellationValue.Tucana, constellationClassType: typeof(Tucana), Localization.Constellations.Tucana),
            new(constellation: ConstellationValue.Indus, constellationClassType: typeof(Indus), Localization.Constellations.Indus),
            new(constellation: ConstellationValue.Octans, constellationClassType: typeof(Octans), Localization.Constellations.Octans),
            new(constellation: ConstellationValue.Lepus, constellationClassType: typeof(Lepus), Localization.Constellations.Lepus),
            new(constellation: ConstellationValue.Lyra, constellationClassType: typeof(Lyra), Localization.Constellations.Lyra),
            new(constellation: ConstellationValue.Crater, constellationClassType: typeof(Crater), Localization.Constellations.Crater),
            new(constellation: ConstellationValue.Columba, constellationClassType: typeof(Columba), Localization.Constellations.Columba),
            new(constellation: ConstellationValue.Vulpecula, constellationClassType: typeof(Vulpecula), Localization.Constellations.Vulpecula),
            new(constellation: ConstellationValue.UrsaMinor, constellationClassType: typeof(UrsaMinor), Localization.Constellations.UrsaMinor),
            new(constellation: ConstellationValue.Telescopium, constellationClassType: typeof(Telescopium), Localization.Constellations.Telescopium),
            new(constellation: ConstellationValue.Horologium, constellationClassType: typeof(Horologium), Localization.Constellations.Horologium),
            new(constellation: ConstellationValue.Pictor, constellationClassType: typeof(Pictor), Localization.Constellations.Pictor),
            new(constellation: ConstellationValue.PiscisAustrinus, constellationClassType: typeof(PiscisAustrinus), Localization.Constellations.PiscisAustrinus),
            new(constellation: ConstellationValue.Hydrus, constellationClassType: typeof(Hydrus), Localization.Constellations.Hydrus),
            new(constellation: ConstellationValue.Antlia, constellationClassType: typeof(Antlia), Localization.Constellations.Antlia),
            new(constellation: ConstellationValue.Ara, constellationClassType: typeof(Ara), Localization.Constellations.Ara),
            new(constellation: ConstellationValue.LeoMinor, constellationClassType: typeof(LeoMinor), Localization.Constellations.LeoMinor),
            new(constellation: ConstellationValue.Pyxis, constellationClassType: typeof(Pyxis), Localization.Constellations.Pyxis),
            new(constellation: ConstellationValue.Microscopium, constellationClassType: typeof(Microscopium), Localization.Constellations.Microscopium),
            new(constellation: ConstellationValue.Apus, constellationClassType: typeof(Apus), Localization.Constellations.Apus),
            new(constellation: ConstellationValue.Lacerta, constellationClassType: typeof(Lacerta), Localization.Constellations.Lacerta),
            new(constellation: ConstellationValue.Delphinus, constellationClassType: typeof(Delphinus), Localization.Constellations.Delphinus),
            new(constellation: ConstellationValue.Corvus, constellationClassType: typeof(Corvus), Localization.Constellations.Corvus),
            new(constellation: ConstellationValue.CanisMinor, constellationClassType: typeof(CanisMinor), Localization.Constellations.CanisMinor),
            new(constellation: ConstellationValue.Dorado, constellationClassType: typeof(Dorado), Localization.Constellations.Dorado),
            new(constellation: ConstellationValue.CoronaBorealis, constellationClassType: typeof(CoronaBorealis), Localization.Constellations.CoronaBorealis),
            new(constellation: ConstellationValue.Norma, constellationClassType: typeof(Norma), Localization.Constellations.Norma),
            new(constellation: ConstellationValue.Mensa, constellationClassType: typeof(Mensa), Localization.Constellations.Mensa),
            new(constellation: ConstellationValue.Volans, constellationClassType: typeof(Volans), Localization.Constellations.Volans),
            new(constellation: ConstellationValue.Musca, constellationClassType: typeof(Musca), Localization.Constellations.Musca),
            new(constellation: ConstellationValue.Triangulum, constellationClassType: typeof(Triangulum), Localization.Constellations.Triangulum),
            new(constellation: ConstellationValue.Chamaeleon, constellationClassType: typeof(Chamaeleon), Localization.Constellations.Chamaeleon),
            new(constellation: ConstellationValue.CoronaAustralis, constellationClassType: typeof(CoronaAustralis), Localization.Constellations.CoronaAustralis),
            new(constellation: ConstellationValue.Caelum, constellationClassType: typeof(Caelum), Localization.Constellations.Caelum),
            new(constellation: ConstellationValue.Reticulum, constellationClassType: typeof(Reticulum), Localization.Constellations.Reticulum),
            new(constellation: ConstellationValue.TriangulumAustrale,
                constellationClassType: typeof(TriangulumAustrale), Localization.Constellations.TriangulumAustrale),
            new(constellation: ConstellationValue.Scutum, constellationClassType: typeof(Scutum), Localization.Constellations.Scutum),
            new(constellation: ConstellationValue.Circinus, constellationClassType: typeof(Circinus), Localization.Constellations.Circinus),
            new(constellation: ConstellationValue.Sagitta, constellationClassType: typeof(Sagitta), Localization.Constellations.Sagitta),
            new(constellation: ConstellationValue.Equuleus, constellationClassType: typeof(Equuleus), Localization.Constellations.Equuleus),
            new(constellation: ConstellationValue.Crux, constellationClassType: typeof(Crux), Localization.Constellations.Crux),
        };

        ConstellationClassesEnumsNames = newData;
    }
}