//using Avalonia.Controls;

using Avalonia.Media;
using StarMap2D.Avalonia.Controls;

namespace StarMap2D.Avalonia.Interfaces;

/// <summary>
/// Interface for the objects in the <see cref="Map2D"/> star map control.
/// </summary>
public interface IMap2DGraphics
{
    /// <summary>
    /// A delegate to provide an image for a specified diameter of the 2D star map.
    /// </summary>
    /// <param name="diameter">The diameter of the 2D star map.</param>
    /// <param name="magnitude">An optional magnitude of the 2D star map object.</param>
    /// <returns>An image suitable to be used in a 2D star map of diameter of the <paramref name="diameter"/>.</returns>
    public delegate IImage GetImageDelegate(double diameter, double? magnitude);

    /// <summary>
    /// A delegate to get an image for the 2D graphics object.
    /// </summary>
    GetImageDelegate? GetImage { get; set; }
}