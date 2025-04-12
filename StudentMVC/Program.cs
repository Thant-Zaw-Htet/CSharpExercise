using CustomerMVC.Controller;
using StudentMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1: Insert \n2: Update \n3: Delete \n4: SelectALL \n5: SelectByID \n");
            Console.Write("Enter Number");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
               
                case 1:
                    tbl_Customer tbl_Customer = new tbl_Customer();
                    Console.Write("Enter Name: ");
                    tbl_Customer.CustomerID = Guid.NewGuid();
                    tbl_Customer.CustomerName = Console.ReadLine();
                    CustomerController customerController = new CustomerController();
                    var obj = customerController.AddCustomer(tbl_Customer);
                    if(obj != null)
                    {
                        Console.WriteLine($"{obj.CustomerName} add successfully");
                    }
                    else
                    {
                        Console.WriteLine("Failed! Please try again");
                    }
                    break;
                case 2:
                    Console.Write("Enter CustomerID : ");
                    Guid customerID = Guid.Parse(Console.ReadLine());

                    Console.Write("Enter Updated Customer Name: ");
                    string newName = Console.ReadLine();

                    CustomerController controller = new CustomerController();
                    var updated = controller.UpdateCustomerByID(customerID, newName);

                    if (updated)
                    {
                        Console.WriteLine("Update Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Customer not found or update failed");
                    }
                    break;
                case 3:
                    Console.Write("Enter Customer ID: ");
                    Guid cusomerId = Guid.Parse(Console.ReadLine());
                    CustomerController cusDelete = new CustomerController();
                    var objDelete = cusDelete.DeleteCustomerByID(cusomerId);
                    if (objDelete)
                    {
                        Console.WriteLine("Delete Successfully");
                    }
                    break;
                case 4:
                    //tbl_Customer customer = new tbl_Customer();
                    CustomerController cusGetAll = new CustomerController();
                    var objGetAll = cusGetAll.GetAllCustomer();
                    if (objGetAll == null)
                    {
                        Console.WriteLine("No Customer to show");
                    }
                    else
                    {
                        foreach (var customer in objGetAll)
                        {
                            Console.WriteLine($"{customer.CustomerID} | {customer.CustomerName}");
                            Console.WriteLine("---------------");
                        }
                    }
                    break;
                case 5:
                    Console.Write("Enter CustomerID you want to seach: ");
                    Guid customerIDSearch = Guid.Parse(Console.ReadLine());
                    CustomerController selectByID = new CustomerController();
                    var objsearch = selectByID.SelectByCustomerID(customerIDSearch);
                    if (objsearch == null)
                    {
                        Console.WriteLine("Customer not found");
                    }
                    else
                    {
                        Console.WriteLine($"{objsearch.CustomerID} | {objsearch.CustomerName}");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
