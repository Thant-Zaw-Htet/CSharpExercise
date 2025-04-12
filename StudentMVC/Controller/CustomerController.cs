using StudentMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMVC.Controller
{
    public class CustomerController
    {
        public tbl_Customer AddCustomer(tbl_Customer customer)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    db.tbl_Customers.InsertOnSubmit(customer);
                    db.SubmitChanges();
                    return customer;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                customer = new tbl_Customer();
            }
        }
        public bool UpdateCustomerByID (Guid id,string name)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var existingCustomerId = db.tbl_Customers.FirstOrDefault(x => x.CustomerID == id);
                    if (existingCustomerId == null)
                    {
                      
                        return false;
                    }
                   
                        existingCustomerId.CustomerName = name;
                        db.SubmitChanges(); 
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteCustomerByID(Guid id)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var existingCustomerID = db.tbl_Customers.FirstOrDefault(x => x.CustomerID == id);
                    if (existingCustomerID == null)
                    {
                        Console.WriteLine("Customer not found");
                    }
                    else
                    {
                        db.tbl_Customers.DeleteOnSubmit(existingCustomerID);
                        db.SubmitChanges();

                    }
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public tbl_Customer SelectByCustomerID(Guid id)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var existingID = db.tbl_Customers.FirstOrDefault(y => y.CustomerID == id);
                    if (existingID == null)
                    {
                        return null;
                    }
                    else
                    {
                        return existingID;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<tbl_Customer> GetAllCustomer()
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    if (db.tbl_Customers == null)
                    {
                        return null;
                    }
                    else
                    {
                        return db.tbl_Customers.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
