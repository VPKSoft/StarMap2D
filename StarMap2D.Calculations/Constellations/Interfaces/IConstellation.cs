namespace StarMap2D.Calculations.Constellations.Interfaces
{
    /// <summary>
    /// An interface for a constellation of stars.
    /// </summary>
    /// <typeparam name="T">The type of the class implementing the <see cref="IConstellationStar"/> interface.</typeparam>
    /// <typeparam name="TLines">The type of the class implementing the <see cref="IConstellationLine"/> interface.</typeparam>
    public interface IConstellation<T, TLines> where T: IConstellationStar where TLines: IConstellationLine
    {
        /// <summary>
        /// Gets or sets the identifier of the constellation. I.e. "ORI".
        /// </summary>
        /// <value>The identifier.</value>
        string Identifier { get; init; }

        /// <summary>
        /// Gets or sets the name of the constellation.
        /// </summary>
        /// <value>The name of the constellation.</value>
        string Name { get; set; }

        /// <summary>
        /// Gets the constellation boundary.
        /// </summary>
        /// <value>The constellation boundary.</value>
        IReadOnlyList<IConstellationStar> Boundary { get; }

        /// <summary>
        /// Gets or sets the constellation lines.
        /// </summary>
        /// <value>The constellation lines.</value>
        public IReadOnlyList<TLines> ConstellationLines { get; init; }
    }
}
