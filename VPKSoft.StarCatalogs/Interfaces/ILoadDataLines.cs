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

namespace VPKSoft.StarCatalogs.Interfaces;

/// <summary>
/// An interface for line data/text data star catalogs.
/// </summary>
public interface ILoadDataLines
{
    /// <summary>
    /// Loads the star data from a specified collection of data lines.
    /// </summary>
    /// <param name="lines">The lines containing the data.</param>
    void LoadData(string[] lines);

    /// <summary>
    /// Loads the star data from a specified collection of data lines.
    /// </summary>
    /// <param name="lines">The lines containing the data.</param>
    /// <param name="magnitudeLimit">The magnitude limit of smallest magnitude to not to load into the memory.</param>
    void LoadData(string[] lines, double magnitudeLimit);
}