using StudentMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMVC.Controller
{
    public class PurchaseHeaderController
    {
        public tbl_PurchaseHeader AddPurchaseHeader(tbl_PurchaseHeader purchaseHeader)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    db.tbl_PurchaseHeaders.InsertOnSubmit(purchaseHeader);
                    db.SubmitChanges();
                    return purchaseHeader;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool UpdatePurchaseHeader(Guid id, string description)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var existingPurchaseHeaderID = db.tbl_PurchaseHeaders.FirstOrDefault(x => x.PurchaseHeaderID == id);
                    if (existingPurchaseHeaderID != null)
                    {
                        existingPurchaseHeaderID.Description = description; 
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeletePurchaseHeader(Guid id)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var exisitingPurchaseHeaderID = db.tbl_PurchaseHeaders.FirstOrDefault(x => x.PurchaseHeaderID == id);
                    if (exisitingPurchaseHeaderID != null)
                    {
                        db.tbl_PurchaseHeaders.DeleteOnSubmit(exisitingPurchaseHeaderID);
                        db.SubmitChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<tbl_PurchaseHeader> GetAllPurchaseHeader()
        {
            try
            {
                using(PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                   return db.tbl_PurchaseHeaders;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public tbl_PurchaseHeader GetPurchaserHeaderByID(Guid id)
        {
            try
            {
                using(PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var exisitingPurchaseHeaderID = db.tbl_PurchaseHeaders.FirstOrDefault(x => x.PurchaseHeaderID == id);
                    if (exisitingPurchaseHeaderID != null)
                    {
                        return exisitingPurchaseHeaderID;
                    }
                    else
                    {
                        return null;
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
