namespace VPKSoft.StarCatalogs.Interfaces
{
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
    }
}
