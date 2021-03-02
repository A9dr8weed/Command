using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// A concrete command remove.
    /// </summary>
    public class RemoveCommand : ICommand
    {
        /// <summary>
        /// Execute remove command from collection MenuItem.
        /// </summary>
        /// <param name="order"> Collection with elements. </param>
        /// <param name="currentItem"> Current item. </param>
        public void Execute(List<MenuItem> order, MenuItem currentItem)
        {
            // Find items in the list by name.
            order.Remove(order.Find(x => x.Name == currentItem.Name));
        }
    }
}