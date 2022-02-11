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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMap2D.Calculations.Classes
{
    /// <summary>
    /// An interface for solar system object details.
    /// </summary>
    public interface IObjectDetails
    {    
        /// <summary>
        /// Gets or sets the name of the object.
        /// </summary>
        /// <value>The name of the object.</value>
        string? ObjectName { get; set; }

        /// <summary>
        /// Gets or sets the right ascension of the object.
        /// </summary>
        /// <value>The right ascension.</value>
        double RightAscension { get; set; }

        /// <summary>
        /// Gets or sets the declination of the object.
        /// </summary>
        /// <value>The declination.</value>
        double Declination { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the object is above horizon at the <see cref="DetailDateTime"/> date and time.
        /// </summary>
        /// <value><c>true</c> if the object is above horizon at the <see cref="DetailDateTime"/>; otherwise, <c>false</c>.</value>
        bool AboveHorizon { get; set; }

        /// <summary>
        /// Gets or sets the horizontal X-coordinate in degrees.
        /// </summary>
        /// <value>The horizontal X-coordinate in degrees.</value>
        double HorizontalDegreesX { get; set; }

        /// <summary>
        /// Gets or sets the horizontal Y-coordinate in degrees.
        /// </summary>
        /// <value>The horizontal Y-coordinate in degrees.</value>
        double HorizontalDegreesY { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the calculation of these object details.
        /// </summary>
        /// <value>The calculation date time of the details.</value>
        /// <remarks>
        /// The date and time will be converted into UTC in case it is passed as local date and time.
        /// </remarks>
        DateTime DetailDateTime { get; set; }
    }
}