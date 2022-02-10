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

namespace StarMap2D.Calculations.Compass;

/// <summary>
/// The compass directions.
/// </summary>
public enum CompassPoint
{
    /// <summary>
    /// The north compass direction.
    /// </summary>
    North = 0,

    /// <summary>
    /// The north-north-east compass direction.
    /// </summary>
    NorthNorthEast = 225,

    /// <summary>
    /// The north-east compass direction.
    /// </summary>
    NorthEast = 450,

    /// <summary>
    /// The east-north-east compass direction.
    /// </summary>
    EastNorthEast = 675,

    /// <summary>
    /// The east
    /// </summary>
    East = 900,

    /// <summary>
    /// The east-south-east compass direction.
    /// </summary>
    EastSouthEast = 1125,

    /// <summary>
    /// The south-east compass direction.
    /// </summary>
    SouthEast = 1350,

    /// <summary>
    /// The south-south-east compass direction.
    /// </summary>
    SouthSouthEast = 1575,

    /// <summary>
    /// The south compass direction.
    /// </summary>
    South = 1800,

    /// <summary>
    /// The south-south-west compass direction.
    /// </summary>
    SouthSouthWest = 2025,

    /// <summary>
    /// The south-west compass direction.
    /// </summary>
    SouthWest = 2250,

    /// <summary>
    /// The west-south-west compass direction.
    /// </summary>
    WestSouthWest = 2475,

    /// <summary>
    /// The west compass direction.
    /// </summary>
    West = 2700,

    /// <summary>
    /// The west-north-west compass direction.
    /// </summary>
    WestNorthWest = 2925,

    /// <summary>
    /// The north-west compass direction.
    /// </summary>
    NorthWest = 3150,

    /// <summary>
    /// The north-north-west compass direction.
    /// </summary>
    NorthNorthWest = 3375,
}