using System;

namespace Command
{
    /// <summary>
    /// Represents an item being ordered from this restaurant.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Name of product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Amount of product.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Product price.
        /// </summary>
        public double Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        /// <summary>
        /// Display data.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Price: ${Price}");
        }

        public override string ToString()
        {
            return $"Name: {Name} Amount: {Amount} Price: ${Price}";
        }
    }
}