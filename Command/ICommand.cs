using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// The Command abstract class.
    /// Declares an interface for executing an operation.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute operation.
        /// </summary>
        /// <param name="order"> Collection with elements. </param>
        /// <param name="currentItem"> Current item. </param>
        void Execute(List<MenuItem> order, MenuItem currentItem);
    }
}