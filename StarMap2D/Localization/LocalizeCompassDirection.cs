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

using StarMap2D.Calculations.Compass;
using VPKSoft.LangLib;

namespace StarMap2D.Localization
{
    /// <summary>
    /// A class to localize the compass direction.
    /// </summary>
    public class LocalizeCompassDirection
    {
        /// <summary>
        /// The localize compass direction function.
        /// </summary>
        public static Func<CompassPoint, string> LocalizeCompassDirectionFunc = point =>
        {
            switch (point)
            {
                case CompassPoint.North:
                    return DBLangEngine.GetStatMessage("msgNorth", "north|The compass direction to north.");
                case CompassPoint.NorthNorthEast:
                    return DBLangEngine.GetStatMessage("msgNorthNorthEast",
                        "north-north-east|The compass direction to north-north-east.");
                case CompassPoint.NorthEast:
                    return DBLangEngine.GetStatMessage("msgNorthEast", "north-east|The compass direction to north-east.");
                case CompassPoint.EastNorthEast:
                    return DBLangEngine.GetStatMessage("msgEastNorthEast",
                        "east-north-east|The compass direction to east-north-east.");
                case CompassPoint.East:
                    return DBLangEngine.GetStatMessage("msgEast", "east|The compass direction to east.");
                case CompassPoint.EastSouthEast:
                    return DBLangEngine.GetStatMessage("msgEastSouthEast",
                        "east-south-east|The compass direction to east-south-east.");
                case CompassPoint.SouthEast:
                    return DBLangEngine.GetStatMessage("msgSouthEast", "south-east|The compass direction to south-east.");
                case CompassPoint.SouthSouthEast:
                    return DBLangEngine.GetStatMessage("msgSouthSouthEast",
                        "south-south-east|The compass direction to south-south-east.");
                case CompassPoint.South:
                    return DBLangEngine.GetStatMessage("msgSouth", "south|The compass direction to south.");
                case CompassPoint.SouthSouthWest:
                    return DBLangEngine.GetStatMessage("msgSouthSouthWest",
                        "south-south-west|The compass direction to south-south-west.");
                case CompassPoint.SouthWest:
                    return DBLangEngine.GetStatMessage("msgSouthWest", "south-west|The compass direction to south-west.");
                case CompassPoint.WestSouthWest:
                    return DBLangEngine.GetStatMessage("msgWestSouthWest",
                        "west-south-west|The compass direction to west-south-west.");
                case CompassPoint.West:
                    return DBLangEngine.GetStatMessage("msgWest", "west|The compass direction to west.");
                case CompassPoint.WestNorthWest:
                    return DBLangEngine.GetStatMessage("msgWestNorthWest",
                        "west-north-west|The compass direction to west-north-west.");
                case CompassPoint.NorthWest:
                    return DBLangEngine.GetStatMessage("msgNorthWest", "north-west|The compass direction to north-west.");
                case CompassPoint.NorthNorthWest:
                    return DBLangEngine.GetStatMessage("msgNorthNorthWest",
                        "north-north-west|The compass direction to north-north-west.");
                default:
                    return DBLangEngine.GetStatMessage("msgNorth", "north|The compass direction to north.");
            }
        };
    }
}