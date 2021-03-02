namespace Command
{
    /// <summary>
    /// Factory method.
    /// </summary>
    public class CommandFactory
    {
        /// <summary>
        /// Get command.
        /// </summary>
        /// <param name="commandOption"> A command that requires execution. </param>
        /// <returns> Selected command. </returns>
        public ICommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new ModifyCommand();
                case 3:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }
        }
    }
}