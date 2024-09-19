using System;
using System.Collections.Generic;

namespace PetStore
{
    // Base class
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        // Override ToString() method to print the Product details
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
        }
    }

    // Derived class
    public class CatFood : Product
    {
        public bool KittenFood { get; set; }

        // Override ToString() method to include CatFood specific property
        public override string ToString()
        {
            return base.ToString() + $", KittenFood: {KittenFood}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();

            for (int i = 0; i < numberOfRecords; i++)
            {
                // Create a new instance of CatFood
                var catFood = new CatFood();

                // Collect data for the properties inherited from Product
                Console.WriteLine("Enter the Name of the product: ");
                catFood.Name = Console.ReadLine();

                Console.WriteLine("Enter the Price of the product: ");
                catFood.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Quantity of the product: ");
                catFood.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Description of the product: ");
                catFood.Description = Console.ReadLine();

                // Collect data for the CatFood specific property
                Console.WriteLine("Is this for kitten food? (true/false): ");
                catFood.KittenFood = bool.Parse(Console.ReadLine());

                // Add the object to the list
                recordList.Add(catFood);
            }

            // Print out the list of records using Console.WriteLine()
            Console.WriteLine("\nList of CatFood records:");
            foreach (var record in recordList)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}
