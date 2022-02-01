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

using AASharp;
using StarMap2D.Calculations.Enumerations;

namespace StarMap2D.Controls.WinForms.Enumerations;

/// <summary>
/// An enumeration of objects in the solar system which currently have graphics defined.
/// </summary>
public enum ObjectsWithGraphics
{
    /// <inheritdoc cref="SolarSystemObjects.Sun"/>
    Sun = SolarSystemObjects.Sun,

    /// <inheritdoc cref="SolarSystemObjects.Mercury"/>
    Mercury = SolarSystemObjects.Mercury,

    /// <inheritdoc cref="SolarSystemObjects.Venus"/>
    Venus = SolarSystemObjects.Venus,

    /// <inheritdoc cref="SolarSystemObjects.Earth"/>
    Earth = SolarSystemObjects.Earth,

    /// <inheritdoc cref="SolarSystemObjects.Moon"/>
    Moon = SolarSystemObjects.Moon,

    /// <inheritdoc cref="SolarSystemObjects.Mars"/>
    Mars = SolarSystemObjects.Mars,

    /// <inheritdoc cref="SolarSystemObjects.Jupiter"/>
    Jupiter = SolarSystemObjects.Jupiter,

    /// <inheritdoc cref="SolarSystemObjects.Saturn"/>
    Saturn = SolarSystemObjects.Saturn,

    /// <inheritdoc cref="SolarSystemObjects.Uranus"/>
    Uranus = SolarSystemObjects.Uranus,

    /// <inheritdoc cref="SolarSystemObjects.Neptune"/>
    Neptune = SolarSystemObjects.Neptune,

    /// <inheritdoc cref="SolarSystemSmallBodies.Ceres"/>
    Ceres = SolarSystemSmallBodies.Ceres,

    /// <inheritdoc cref="SolarSystemSmallBodies.Orcus"/>
    Orcus = SolarSystemSmallBodies.Orcus,

    /// <inheritdoc cref="SolarSystemSmallBodies.Pluto"/>
    Pluto = AASEllipticalObject.PLUTO,

    /// <inheritdoc cref="SolarSystemSmallBodies.Haumea"/>
    Haumea = SolarSystemSmallBodies.Haumea,

    /// <inheritdoc cref="SolarSystemSmallBodies.Quaoar"/>
    Quaoar = SolarSystemSmallBodies.Quaoar,

    /// <inheritdoc cref="SolarSystemSmallBodies.Makemake"/>
    Makemake = SolarSystemSmallBodies.Makemake,

    /// <inheritdoc cref="SolarSystemSmallBodies.Gonggong"/>
    Gonggong = SolarSystemSmallBodies.Gonggong,

    /// <inheritdoc cref="SolarSystemSmallBodies.Eris"/>
    Eris = SolarSystemSmallBodies.Eris,

    /// <inheritdoc cref="SolarSystemSmallBodies.Sedna"/>
    Sedna = SolarSystemSmallBodies.Sedna,

    /// <inheritdoc cref="SolarSystemSmallBodies.Juno"/>
    Juno = SolarSystemSmallBodies.Juno,

    /// <inheritdoc cref="SolarSystemSmallBodies.Vesta"/>
    Vesta = SolarSystemSmallBodies.Vesta,
        
    /// <inheritdoc cref="SolarSystemSmallBodies.Pallas"/>
    Pallas = SolarSystemSmallBodies.Pallas,

    /// <inheritdoc cref="SolarSystemSmallBodies.Chiron"/>
    Chiron = SolarSystemSmallBodies.Chiron,
}