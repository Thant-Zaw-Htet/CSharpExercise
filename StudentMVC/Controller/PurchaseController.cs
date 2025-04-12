using StudentMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMVC.Controller
{
    public class PurchaseController
    {
        public tbl_PurchaseDetail AddPurchaseDetail(tbl_PurchaseDetail purchaseDetail)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    db.tbl_PurchaseDetails.InsertOnSubmit(purchaseDetail);
                    db.SubmitChanges();
                    return purchaseDetail;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                purchaseDetail = new tbl_PurchaseDetail();
            }
        }
        public bool UpdatePurchaseDetail(Guid id, string detail)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var exisitingPurchaseID = db.tbl_PurchaseDetails.FirstOrDefault(x => x.PurchaseDetailID == id);
                    {
                        if (exisitingPurchaseID != null)
                        {
                              exisitingPurchaseID.Detail = detail; 
                              db.SubmitChanges();
                              return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeletePurchaseDetail(Guid id)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var exisitingID = db.tbl_PurchaseDetails.FirstOrDefault(y => y.PurchaseDetailID == id);
                    {
                        if (exisitingID != null)
                        {
                            db.tbl_PurchaseDetails.DeleteOnSubmit(exisitingID);
                            db.SubmitChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                return false;
            }
        }
        public tbl_PurchaseDetail SelectByPurchaseID(Guid id)
        {
            try
            {
                using (PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    var existingPurchaseDetailID = db.tbl_PurchaseDetails.FirstOrDefault(x => x.PurchaseDetailID == id);
                    if (existingPurchaseDetailID != null)
                    {
                        return existingPurchaseDetailID;
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
        public IEnumerable<tbl_PurchaseDetail> GetAllPurchaseDetail()
        {
            try
            {
                using(PurchaseDBDataContext db = new PurchaseDBDataContext())
                {
                    return db.tbl_PurchaseDetails;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
            
    }
}
