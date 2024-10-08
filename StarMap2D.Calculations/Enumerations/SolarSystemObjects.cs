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

using AASharp;

namespace StarMap2D.Calculations.Enumerations;

/// <summary>
/// An enumeration of common solar system objects.
/// </summary>
public enum SolarSystemObjects
{
    /// <summary>
    /// The sun.
    /// </summary>
    Sun = AASEllipticalObject.SUN,

    /// <summary>
    /// The planet Mercury.
    /// </summary>
    Mercury = AASEllipticalObject.MERCURY,

    /// <summary>
    /// The planet Venus.
    /// </summary>
    Venus = AASEllipticalObject.VENUS,

    /// <summary>
    /// The planet Earth.
    /// </summary>
    Earth = 100,

    /// <summary>
    /// The moon of the planet Earth.
    /// </summary>
    Moon = 101,

    /// <summary>
    /// The planet Mars.
    /// </summary>
    Mars = AASEllipticalObject.MARS,

    /// <summary>
    /// The planet Jupiter.
    /// </summary>
    Jupiter = AASEllipticalObject.JUPITER,

    /// <summary>
    /// The planet Saturn.
    /// </summary>
    Saturn = AASEllipticalObject.SATURN,

    /// <summary>
    /// The planet Uranus.
    /// </summary>
    Uranus = AASEllipticalObject.URANUS,

    /// <summary>
    /// The planet Neptune.
    /// </summary>
    Neptune = AASEllipticalObject.NEPTUNE,
}