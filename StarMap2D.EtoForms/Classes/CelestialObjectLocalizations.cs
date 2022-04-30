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

using StarMap2D.Calculations.Enumerations;
using CO = StarMap2D.Localization.CelestialObjects;

namespace StarMap2D.EtoForms.Classes;

/// <summary>
/// A class to localize known celestial objects.
/// </summary>
public static class CelestialObjectLocalizations
{
    /// <summary>
    /// Gets the localized name of the celestial object.
    /// </summary>
    /// <param name="object">The object <see cref="Calculations.Enumerations.ObjectsWithPositions"/> enumeration value.</param>
    /// <returns>The localized name of the object.</returns>
    public static string GetLocalizedName(ObjectsWithPositions @object)
    {
        return @object switch
        {
            ObjectsWithPositions.Mercury => CO.Mercury,
            ObjectsWithPositions.Venus => CO.Venus,
            ObjectsWithPositions.Earth => CO.Earth,
            ObjectsWithPositions.Mars => CO.Mars,
            ObjectsWithPositions.Jupiter => CO.Jupiter,
            ObjectsWithPositions.Saturn => CO.Saturn,
            ObjectsWithPositions.Uranus => CO.Uranus,
            ObjectsWithPositions.Neptune => CO.Neptune,
            ObjectsWithPositions.Pluto => CO.Pluto,
            ObjectsWithPositions.Moon => CO.Moon,
            ObjectsWithPositions.Sun => CO.Sun,
            ObjectsWithPositions.Ceres => CO.Ceres,
            ObjectsWithPositions.Eris => CO.Eris,
            ObjectsWithPositions.Makemake => CO.Makemake,
            ObjectsWithPositions.Haumea => CO.Haumea,
            _ => @object.ToString(),
        };
    }
}