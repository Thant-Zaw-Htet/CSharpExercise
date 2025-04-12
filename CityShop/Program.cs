using System;
using System.Collections.Generic;

namespace CityShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("<<<Welcome From CityShop>>> \n(1) Add New Product \n(2) Show All Products \n(3) Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product.ProductDisplay();
                        break;
                    case 2:
                        Product.ShowProductList();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    public class Inventory
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Profit { get; set; }
        public int Quantity { get; set; }

        public Inventory()
        {
        }

        public Inventory(Guid productId, string productName, decimal purchasePrice, decimal sellingPrice, decimal profit, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            Profit = SellingPrice - PurchasePrice;
            Quantity = quantity;
        }
    }

    public class Product
    {
        static List<Inventory> inventories = new List<Inventory>();

        public static void ProductDisplay()
        {
            Console.WriteLine("Enter 'exit' to go back to the main menu.");
            while (true)
            {
                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();
                if (productName.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                Console.Write("Enter product quantity: ");
                string productAmountInput = Console.ReadLine();
                if (productAmountInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                Console.Write("Enter purchase price: ");
                string purchasePriceInput = Console.ReadLine();
                if (purchasePriceInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                Console.Write("Enter selling price: ");
                string sellingPriceInput = Console.ReadLine();
                if (sellingPriceInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                if (int.TryParse(productAmountInput, out int quantity) &&
                    decimal.TryParse(purchasePriceInput, out decimal purchasePrice) &&
                    decimal.TryParse(sellingPriceInput, out decimal sellingPrice))
                {
                    Guid productId = Guid.NewGuid();
                    Inventory newProduct = new Inventory(productId, productName, purchasePrice, sellingPrice, 0, quantity);
                    inventories.Add(newProduct);
                    Console.WriteLine("Product added successfully!\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        public static void ShowProductList()
        {
            if (inventories.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }

            Console.WriteLine("Product List:");
            foreach (var product in inventories)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Purchase Price: {product.PurchasePrice}, Selling Price: {product.SellingPrice}, Profit: {product.Profit}, Quantity: {product.Quantity}");
            }
        }
    }
}
