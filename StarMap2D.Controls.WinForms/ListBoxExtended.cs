namespace StarMap2D.Controls.WinForms
{
    /// <summary>
    /// A <see cref="ListBox"/> descendant with few additional features.
    /// Implements the <see cref="System.Windows.Forms.ListBox" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.ListBox" />
    public class ListBoxExtended: ListBox
    {
        /// <summary>
        /// Refreshes all <see cref="ListBox"/> items and retrieves new strings for them.
        /// </summary>
        public new void RefreshItems()
        {
            base.RefreshItems();
        }
    }
}
