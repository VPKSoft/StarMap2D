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

namespace StarMap2D.Calculations.Constellations.StaticData;

/// <summary>
/// A class to map constellations class types and their enumeration values together.
/// </summary>
public class ConstellationClassEnumMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConstellationClassEnumMap"/> class.
    /// </summary>
    /// <param name="constellation">The <see cref="ConstellationValue"/> enumeration value.</param>
    /// <param name="constellationClassType">Type of the constellation class.</param>
    public ConstellationClassEnumMap(ConstellationValue constellation, Type constellationClassType)
    {
        Constellation = constellation;
        ConstellationClassType = constellationClassType;
    }

    /// <summary>
    /// Gets or sets the <see cref="ConstellationValue"/> enumeration value.
    /// </summary>
    /// <value>The constellation <see cref="ConstellationValue"/> enumeration value.</value>
    public ConstellationValue Constellation { get; init; }

    /// <summary>
    /// Gets or sets the type of the constellation class.
    /// </summary>
    /// <value>The type of the constellation class.</value>
    public Type ConstellationClassType { get; init; }

    /// <summary>
    /// Gets the constellation classes enums.
    /// </summary>
    /// <value>The constellation classes enums.</value>
    public static IReadOnlyList<ConstellationClassEnumMap> ConstellationClassesEnums { get; } =
        new ConstellationClassEnumMap[]
        {
            new(constellation: ConstellationValue.Hydra, constellationClassType: typeof(Hydra)),
            new(constellation: ConstellationValue.Virgo, constellationClassType: typeof(Virgo)),
            new(constellation: ConstellationValue.UrsaMajor, constellationClassType: typeof(UrsaMajor)),
            new(constellation: ConstellationValue.Cetus, constellationClassType: typeof(Cetus)),
            new(constellation: ConstellationValue.Hercules, constellationClassType: typeof(Hercules)),
            new(constellation: ConstellationValue.Eridanus, constellationClassType: typeof(Eridanus)),
            new(constellation: ConstellationValue.Pegasus, constellationClassType: typeof(Pegasus)),
            new(constellation: ConstellationValue.Draco, constellationClassType: typeof(Draco)),
            new(constellation: ConstellationValue.Centaurus, constellationClassType: typeof(Centaurus)),
            new(constellation: ConstellationValue.Aquarius, constellationClassType: typeof(Aquarius)),
            new(constellation: ConstellationValue.Ophiuchus, constellationClassType: typeof(Ophiuchus)),
            new(constellation: ConstellationValue.Leo, constellationClassType: typeof(Leo)),
            new(constellation: ConstellationValue.Boötes, constellationClassType: typeof(Boötes)),
            new(constellation: ConstellationValue.Pisces, constellationClassType: typeof(Pisces)),
            new(constellation: ConstellationValue.Sagittarius, constellationClassType: typeof(Sagittarius)),
            new(constellation: ConstellationValue.Cygnus, constellationClassType: typeof(Cygnus)),
            new(constellation: ConstellationValue.Taurus, constellationClassType: typeof(Taurus)),
            new(constellation: ConstellationValue.Camelopardalis, constellationClassType: typeof(Camelopardalis)),
            new(constellation: ConstellationValue.Andromeda, constellationClassType: typeof(Andromeda)),
            new(constellation: ConstellationValue.Puppis, constellationClassType: typeof(Puppis)),
            new(constellation: ConstellationValue.Auriga, constellationClassType: typeof(Auriga)),
            new(constellation: ConstellationValue.Aquila, constellationClassType: typeof(Aquila)),
            new(constellation: ConstellationValue.SerpensCauda, constellationClassType: typeof(SerpensCauda)),
            new(constellation: ConstellationValue.SerpensCaput, constellationClassType: typeof(SerpensCaput)),
            new(constellation: ConstellationValue.Perseus, constellationClassType: typeof(Perseus)),
            new(constellation: ConstellationValue.Cassiopeia, constellationClassType: typeof(Cassiopeia)),
            new(constellation: ConstellationValue.Orion, constellationClassType: typeof(Orion)),
            new(constellation: ConstellationValue.Cepheus, constellationClassType: typeof(Cepheus)),
            new(constellation: ConstellationValue.Lynx, constellationClassType: typeof(Lynx)),
            new(constellation: ConstellationValue.Libra, constellationClassType: typeof(Libra)),
            new(constellation: ConstellationValue.Gemini, constellationClassType: typeof(Gemini)),
            new(constellation: ConstellationValue.Cancer, constellationClassType: typeof(Cancer)),
            new(constellation: ConstellationValue.Vela, constellationClassType: typeof(Vela)),
            new(constellation: ConstellationValue.Scorpius, constellationClassType: typeof(Scorpius)),
            new(constellation: ConstellationValue.Carina, constellationClassType: typeof(Carina)),
            new(constellation: ConstellationValue.Monoceros, constellationClassType: typeof(Monoceros)),
            new(constellation: ConstellationValue.Sculptor, constellationClassType: typeof(Sculptor)),
            new(constellation: ConstellationValue.Phoenix, constellationClassType: typeof(Phoenix)),
            new(constellation: ConstellationValue.CanesVenatici, constellationClassType: typeof(CanesVenatici)),
            new(constellation: ConstellationValue.Aries, constellationClassType: typeof(Aries)),
            new(constellation: ConstellationValue.Capricornus, constellationClassType: typeof(Capricornus)),
            new(constellation: ConstellationValue.Fornax, constellationClassType: typeof(Fornax)),
            new(constellation: ConstellationValue.ComaBerenices, constellationClassType: typeof(ComaBerenices)),
            new(constellation: ConstellationValue.CanisMajor, constellationClassType: typeof(CanisMajor)),
            new(constellation: ConstellationValue.Pavo, constellationClassType: typeof(Pavo)),
            new(constellation: ConstellationValue.Grus, constellationClassType: typeof(Grus)),
            new(constellation: ConstellationValue.Lupus, constellationClassType: typeof(Lupus)),
            new(constellation: ConstellationValue.Sextans, constellationClassType: typeof(Sextans)),
            new(constellation: ConstellationValue.Tucana, constellationClassType: typeof(Tucana)),
            new(constellation: ConstellationValue.Indus, constellationClassType: typeof(Indus)),
            new(constellation: ConstellationValue.Octans, constellationClassType: typeof(Octans)),
            new(constellation: ConstellationValue.Lepus, constellationClassType: typeof(Lepus)),
            new(constellation: ConstellationValue.Lyra, constellationClassType: typeof(Lyra)),
            new(constellation: ConstellationValue.Crater, constellationClassType: typeof(Crater)),
            new(constellation: ConstellationValue.Columba, constellationClassType: typeof(Columba)),
            new(constellation: ConstellationValue.Vulpecula, constellationClassType: typeof(Vulpecula)),
            new(constellation: ConstellationValue.UrsaMinor, constellationClassType: typeof(UrsaMinor)),
            new(constellation: ConstellationValue.Telescopium, constellationClassType: typeof(Telescopium)),
            new(constellation: ConstellationValue.Horologium, constellationClassType: typeof(Horologium)),
            new(constellation: ConstellationValue.Pictor, constellationClassType: typeof(Pictor)),
            new(constellation: ConstellationValue.PiscisAustrinus, constellationClassType: typeof(PiscisAustrinus)),
            new(constellation: ConstellationValue.Hydrus, constellationClassType: typeof(Hydrus)),
            new(constellation: ConstellationValue.Antlia, constellationClassType: typeof(Antlia)),
            new(constellation: ConstellationValue.Ara, constellationClassType: typeof(Ara)),
            new(constellation: ConstellationValue.LeoMinor, constellationClassType: typeof(LeoMinor)),
            new(constellation: ConstellationValue.Pyxis, constellationClassType: typeof(Pyxis)),
            new(constellation: ConstellationValue.Microscopium, constellationClassType: typeof(Microscopium)),
            new(constellation: ConstellationValue.Apus, constellationClassType: typeof(Apus)),
            new(constellation: ConstellationValue.Lacerta, constellationClassType: typeof(Lacerta)),
            new(constellation: ConstellationValue.Delphinus, constellationClassType: typeof(Delphinus)),
            new(constellation: ConstellationValue.Corvus, constellationClassType: typeof(Corvus)),
            new(constellation: ConstellationValue.CanisMinor, constellationClassType: typeof(CanisMinor)),
            new(constellation: ConstellationValue.Dorado, constellationClassType: typeof(Dorado)),
            new(constellation: ConstellationValue.CoronaBorealis, constellationClassType: typeof(CoronaBorealis)),
            new(constellation: ConstellationValue.Norma, constellationClassType: typeof(Norma)),
            new(constellation: ConstellationValue.Mensa, constellationClassType: typeof(Mensa)),
            new(constellation: ConstellationValue.Volans, constellationClassType: typeof(Volans)),
            new(constellation: ConstellationValue.Musca, constellationClassType: typeof(Musca)),
            new(constellation: ConstellationValue.Triangulum, constellationClassType: typeof(Triangulum)),
            new(constellation: ConstellationValue.Chamaeleon, constellationClassType: typeof(Chamaeleon)),
            new(constellation: ConstellationValue.CoronaAustralis, constellationClassType: typeof(CoronaAustralis)),
            new(constellation: ConstellationValue.Caelum, constellationClassType: typeof(Caelum)),
            new(constellation: ConstellationValue.Reticulum, constellationClassType: typeof(Reticulum)),
            new(constellation: ConstellationValue.TriangulumAustrale,
                constellationClassType: typeof(TriangulumAustrale)),
            new(constellation: ConstellationValue.Scutum, constellationClassType: typeof(Scutum)),
            new(constellation: ConstellationValue.Circinus, constellationClassType: typeof(Circinus)),
            new(constellation: ConstellationValue.Sagitta, constellationClassType: typeof(Sagitta)),
            new(constellation: ConstellationValue.Equuleus, constellationClassType: typeof(Equuleus)),
            new(constellation: ConstellationValue.Crux, constellationClassType: typeof(Crux)),
        };
}