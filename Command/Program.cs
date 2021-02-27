namespace Command
{
    public static class Program
    {
        /// <summary>
        /// The Command pattern encapsulates commands as objects, allowing them to be executed by a Receiver class and kicked off
        /// by an Invoker object. This enables more complex architectures such as CQRS (Command/Query Responsibility Segregation).
        /// </summary>
        private static void Main()
        {
            Invoker invoker = new Invoker();

            // Add.
            invoker.SetCommand(1);
            invoker.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            invoker.ExecuteCommand();

            // Add.
            invoker.SetCommand(1);
            invoker.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            invoker.ExecuteCommand();

            // Add.
            invoker.SetCommand(1);
            invoker.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            invoker.ExecuteCommand();

            invoker.ShowCurrentOrder();

            //Remove the french fries
            invoker.SetCommand(3);
            invoker.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            invoker.ExecuteCommand();

            invoker.ShowCurrentOrder();

            //Now we want 4 hamburgers rather than 2
            invoker.SetCommand(2);
            invoker.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
            invoker.ExecuteCommand();

            invoker.ShowCurrentOrder();
        }
    }
}