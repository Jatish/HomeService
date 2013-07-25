using log4net;
using HSG.Library;
using System.Data;
using HSG.DataAccess;
using System.Collections.Generic;

namespace HSG.Business
{
    public class CatalogBA
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatalogBA));

        /// <summary>
        /// This method is used to get all the products and related data as a Dictionary object.
        /// </summary>
        /// <returns>Products and related data as Dictionary.</returns>
        public Dictionary<string, object> GetProducts()
        {
            Dictionary<string, object> dicProducts = new Dictionary<string, object>();
            DataSet dsProducts = new CatalogDA().GetAllProducts();
            if (dsProducts.Tables.Count > 0)
            {

            }
            return dicProducts;
        }

        /// <summary>
        /// This method is used to save the product
        /// </summary>
        /// <param name="objProduct">Product information as ProductDO object.</param>
        /// <returns>ProductID as integer.</returns>
        public int SaveProduct(ProductDO objProduct)
        {
            logger.Debug("Method SaveProduct - objProduct.ProductID " + objProduct.ProductID);
            return new CatalogDA().SaveProduct(objProduct);
        }
    }
}
