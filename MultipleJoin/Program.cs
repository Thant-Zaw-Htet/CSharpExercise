using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleJoin
{
    internal class Program
    {
        class Customer
        {
            public string ID { get; set; } //Primary Key
            public string Name { get; set; }
        }

        class PurchaseHeader
        {
            public string ID { get; set; }//Primary Key
            public string CustomerID { get; set; } //Foreign Key
            public string Description { get; set; }
        }

        class PurchaseDetail
        {
            public string ID { get; set; } //Primary Key
            public string PurchaseHeaderID { get; set; } //Foreign Key
            public string Detail { get; set; }
        }

        static void Main(string[] args)
        {
            // Create collections for customers, purchase headers, and purchase details
            List<Customer> customers = new List<Customer>();
            List<PurchaseHeader> purchaseHeaders = new List<PurchaseHeader>();
            List<PurchaseDetail> purchaseDetails = new List<PurchaseDetail>();

            // Collecting customer information
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Customer customer = new Customer()
            {
                ID = Guid.NewGuid().ToString(),
                Name = name,
            };

            customers.Add(customer);

            // Collecting purchase header information
            Console.WriteLine("Enter Purchase Header Description: ");
            string purchaseHeaderInput = Console.ReadLine();

            PurchaseHeader purchaseHeader = new PurchaseHeader()
            {
                ID = Guid.NewGuid().ToString(),
                CustomerID = customer.ID,
                Description = purchaseHeaderInput
            };

            purchaseHeaders.Add(purchaseHeader);

            // Collecting purchase detail information
            Console.WriteLine("Enter Purchase Detail: ");
            string detailInput = Console.ReadLine();

            PurchaseDetail purchaseDetail = new PurchaseDetail()
            {
                ID = Guid.NewGuid().ToString(),
                PurchaseHeaderID = purchaseHeader.ID,
                Detail = detailInput
            };

            purchaseDetails.Add(purchaseDetail);

            // Perform the join using LINQ
            var result = from c in customers
                         join ph in purchaseHeaders on c.ID equals ph.CustomerID
                         join pd in purchaseDetails on ph.ID equals pd.PurchaseHeaderID
                         select new
                         {
                             c.Name,
                             PurchaseDescription = ph.Description,
                             pd.Detail
                         };

            // Display the result
            foreach (var item in result)
            {
                Console.WriteLine($"Customer Name: {item.Name}, Purchase: {item.PurchaseDescription}, Detail: {item.Detail}");
            }
        }
    }
}
