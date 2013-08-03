using log4net;
using HSG.Library;
using System.Data;
using HSG.DataAccess;
using System.Collections.Generic;
using System;

namespace HSG.Business
{
    public class CatalogBA
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatalogBA));

        /// <summary>
        /// This method is used to get all the products and related data as a Dictionary object.
        /// </summary>
        /// <returns>Products and related data as Dictionary.</returns>
        public Dictionary<string, object> GetProducts(int iCategoryID, int iBrandID, int iProductTypeID, string strSearchText, int iPageNo, int iPageCount)
        {
            Dictionary<string, object> dicProducts = new Dictionary<string, object>();
            DataSet dsProducts = new CatalogDA().GetProducts(iCategoryID, iBrandID, iProductTypeID, strSearchText, iPageNo, iPageCount);
            if (dsProducts.Tables.Count > 0)
            {
                Dictionary<int, ProductDO> dicProduct = new Dictionary<int, ProductDO>();
                ProductDO objProduct = new ProductDO();
                foreach (DataRow drProduct in dsProducts.Tables[0].Rows)
                {
                    objProduct.ProductID = Convert.ToInt32(drProduct["PkProductId"]);
                    objProduct.Name = Convert.ToString(drProduct["ProductName"]);
                    objProduct.OnHandQuantity = Convert.ToInt32(drProduct["Quantity"]);
                    objProduct.PurchasePrice = Convert.ToDecimal(drProduct["PurchasePrice"]);
                    objProduct.SellingPrice = Convert.ToDecimal(drProduct["SellingPrice"]);
                    dicProduct.Add(objProduct.ProductID, objProduct);
                }
                dicProducts.Add("Products", dicProduct);
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
