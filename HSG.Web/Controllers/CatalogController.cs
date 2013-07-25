using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HSG.Library;
using log4net;
using HSG.Web.CatalogServiceReference;

namespace HSG.Web.Controllers
{
    public class CatalogController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatalogController));
        
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int SaveProduct(ProductDO objProduct)
        {
            logger.Debug("SaveProduct Json method in Catalog Controller called-" + objProduct.ProductID);
            int iResult = -1;
            CatalogServiceClient objCatalogServiceClient = new CatalogServiceClient();
            try
            {
                //int iUserProfileID = ((UserDO)SessionManager.ReadSession(UtilityConstants.SessionNames.USER)).UserProfileID;
                //objProduct.CreatedBy = iUserProfileID;
                iResult = objCatalogServiceClient.SaveProduct(objProduct);
            }
            catch (Exception objException)
            {
                logger.Error("Method SaveResource - Error." + objException.Message);
            }
            finally
            {
                objCatalogServiceClient.Close();
            }
            return iResult;
        }
    }
}
