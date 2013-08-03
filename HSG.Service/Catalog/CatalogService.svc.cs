using log4net;
using HSG.Library;
using HSG.Business;
using Newtonsoft.Json;

namespace HSG.Service.Catalog
{
    public class CatalogService : ICatalogService
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatalogService));

        /// <summary>
        /// This method is used to get all the products as JSON formatted string.
        /// </summary>
        /// <returns>All products as JSON formatted string.</returns>
        public string GetProducts(int iCategoryID, int iBrandID, int iProductTypeID, string strSearchText, int iPageNo, int iPageCount)
        {
            logger.Debug("Called Method GetProducts.");
            return JsonConvert.SerializeObject(new CatalogBA().GetProducts(iCategoryID, iBrandID, iProductTypeID, strSearchText, iPageNo, iPageCount));
        }

        /// <summary>
        /// This method is used to save product supplied from UI as object.
        /// </summary>
        /// <param name="objProductDO">Product as ProductDO object.</param>
        /// <returns>ProductID as integer.</returns>
        public int SaveProduct(ProductDO objProductDO)
        {
            logger.Debug("Called Method SaveProduct with parameter objProductDo : " + objProductDO.ToString());
            return new CatalogBA().SaveProduct(objProductDO);
        }
    }
}
