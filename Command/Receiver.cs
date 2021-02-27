using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// The Receiver knows how to perform the operations associated with carrying out the request.
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Collection of orders.
        /// </summary>
        public List<MenuItem> menuItems { get; set; }

        public Receiver()
        {
            menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Execute geting command and item.
        /// </summary>
        /// <param name="command"> Received a command from the client. </param>
        /// <param name="item"> The element over which the command must be executed. </param>
        public void ExecuteCommand(ICommand command, MenuItem item)
        {
            command.Execute(menuItems, item);
        }

        /// <summary>
        /// Show items from list.
        /// </summary>
        public void ShowCurrentItems()
        {
            foreach (MenuItem item in menuItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }
    }
}