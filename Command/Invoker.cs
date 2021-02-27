namespace Command
{
    /// <summary>
    /// The Invoker is associated with one or several commands. It sends a request to the command.
    /// </summary>
    public class Invoker
    {
        /// <summary>
        /// Reference to the command object.
        /// </summary>
        private ICommand _command;

        /// <summary>
        /// Item.
        /// </summary>
        private MenuItem _menuItem;

        /// <summary>
        /// Reference to an instance Receiver.
        /// </summary>
        private readonly Receiver _receiver;

        public Invoker()
        {
            _receiver = new Receiver();
        }

        /// <summary>
        /// Set command like object from command factory.
        /// </summary>
        /// <param name="commandOption"> Add, remove or modify command. </param>
        public void SetCommand(int commandOption)
        {
            _command = new CommandFactory().GetCommand(commandOption);
        }

        /// <summary>
        /// Set new item.
        /// </summary>
        /// <param name="item"> Our item. </param>
        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        /// <summary>
        /// Receiver get setted command and item like objects.
        /// </summary>
        public void ExecuteCommand()
        {
            _receiver.ExecuteCommand(_command, _menuItem);
        }

        /// <summary>
        /// Say to receiver: Show items from list MenuItem.
        /// </summary>
        public void ShowCurrentOrder()
        {
            _receiver.ShowCurrentItems();
        }
    }
}