using System;
using System.Collections.Generic;

// Creating Program Logic
public class Program
{
    static List<Product> products = new List<Product>();
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Inventory Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    ViewProducts();
                    break;
                case "3":
                    UpdateProduct();
                    break;
                case "4":
                    DeleteProduct();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
    // Adding Product
    public static void AddProduct()
    {
        Console.WriteLine("Enter Product Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Product Price:");
        if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
            return;
        }
        Console.WriteLine("Enter Product Quantity:");
        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
        {
            Console.WriteLine("Invalid quantity. Please enter a valid number.");
            return;
        }
        products.Add(new Product(name, price, quantity));
        Console.WriteLine("Product added successfully.");
    }
    // Viewing Products
    public static void ViewProducts()
    {
        Console.WriteLine("Product List:");
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }
        for (int i = 0; i < products.Count; i++)
        {
            Product product = products[i];
            Console.WriteLine($"{i+1}. Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
        }

    }
    // Updating Product
    public static void UpdateProduct()
    {
        ViewProducts();
        Console.WriteLine("Enter Product number to update: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > products.Count)
        {
            Console.WriteLine("Invalid product number.");
            return;
        }
        Console.WriteLine("Enter quantity to add or remove (negative to remove):");
        if (!int.TryParse(Console.ReadLine(), out int quantityChange))
        {
            Console.WriteLine("Invalid quantity. Please enter a valid number.");
            return;
        }
        products[index-1].Quantity += quantityChange;
        Console.WriteLine("Product updated successfully.");

    }
    // Deleting Product
    public static void DeleteProduct()
    {
        ViewProducts();
        Console.WriteLine("Enter Product number to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > products.Count)
        {
            Console.WriteLine("Invalid product number.");
            return;
        }
        products.RemoveAt(index-1);
        Console.WriteLine("Product deleted successfully.");
    }

}
// Creating Product class 
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

}