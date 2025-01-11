using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CityShop
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<Welcome From CityShop>>> \n(1)Add New Product \n(2)Show All Product");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Product.ProductDisplay();
                    
                    break;
                case 2:
                    Product.ShowProductList();
                    break;
            }              
        }
    }


    public class Inventory
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPring { get; set; }
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
            SellingPring = sellingPrice;
            Profit = SellingPring - PurchasePrice;
            Quantity = quantity;
        }

    }

    public class Product
    {
        static List<Inventory> inventories = new List<Inventory>();
        public static void ProductDisplay()
        {
            while (true)
            {
                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();
                Console.Write("Enter product quality: ");
                string productAmountInput = Console.ReadLine();
                Console.Write("Enter Purchase price: ");
                string purchasePriceInput = Console.ReadLine();
                Console.Write("Enter Selling Price: ");
                string sellingPriceInput = Console.ReadLine();

                if (string.IsNullOrEmpty(productName) || !int.TryParse(productAmountInput, out int productAmount) || !decimal.TryParse(purchasePriceInput, out decimal purchasePrice) || !decimal.TryParse(sellingPriceInput, out decimal sellingPrice))
                {
                    Console.WriteLine("Please fill data first! ");
                }
                else
                {
                    decimal profitInput = sellingPrice - purchasePrice;
                    Inventory inventory = new Inventory(Guid.NewGuid(), productName, purchasePrice, sellingPrice, profitInput, productAmount);

                    inventories.Add(inventory);
                    Console.Read();
                    Console.WriteLine("Product Add Successfully! ");
                  

                }
            }
        }
        

        public static void ShowProductList()
        {
            if (inventories.Count <= 0)
            {
                Console.WriteLine("No Product Add");
            }
            else
            {
                foreach (var inventoriesList in inventories)
                {
                    Console.WriteLine($"ProductID: {inventoriesList.ProductId} | ProductName: {inventoriesList.ProductName} | Product Quantity: {inventoriesList.Quantity} | Product Purchase Price: {inventoriesList.PurchasePrice} | Product Selling Price: {inventoriesList.SellingPring} | Product Profit:  {inventoriesList.Profit}");
                }
            }


        }


    }
}
