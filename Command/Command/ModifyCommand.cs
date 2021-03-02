using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// A concrete command modify.
    /// </summary>
    public class ModifyCommand : ICommand
    {
        /// <summary>
        /// Execute modify command for item.
        /// </summary>
        /// <param name="order"> Collection with elements. </param>
        /// <param name="currentItem"> Current item. </param>
        public void Execute(List<MenuItem> order, MenuItem currentItem)
        {
            // Find items in the list by name.
            MenuItem item = order.Find(x => x.Name == currentItem.Name);

            if (item == null)
            {
                Console.WriteLine($"{currentItem.Name} not found. Nothing to modify.");
            }
            else
            {
                // Change price and amount.
                item.Price = currentItem.Price;
                item.Amount = currentItem.Amount;
            }
        }
    }
}