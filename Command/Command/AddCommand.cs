using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// A concrete command add.
    /// </summary>
    public class AddCommand : ICommand
    {
        /// <summary>
        /// Execute add command to collection MenuItem.
        /// </summary>
        /// <param name="order"> Collection with elements. </param>
        /// <param name="currentItem"> Current item. </param>
        public void Execute(List<MenuItem> order, MenuItem currentItem)
        {
            // Add item to the list.
            order.Add(currentItem);
        }
    }
}