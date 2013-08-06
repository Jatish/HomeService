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
        /// This method is used to retrieve all the lookups for the product pages.
        /// </summary>
        /// <returns>All lookup values as Dictionary.</returns>
        public Dictionary<string, object> GetAllLookups()
        {
            logger.Debug("Entered into method GetAllLookups.");

            Dictionary<string, object> dicAllLookups = new Dictionary<string,object>();
            DataSet dsLookups = new CatalogDA().GetAllLookupData();
            logger.Debug("Total tables retrieved from database are : " + dsLookups.Tables.Count);

            try
            {
                if (dsLookups.Tables.Count > 0 && dsLookups.Tables[0].Rows.Count > 0)
                {
                    Dictionary<int, CategoryDO> dicCategory = new Dictionary<int, CategoryDO>();
                    foreach (DataRow drCatagory in dsLookups.Tables[0].Rows)
                    {
                        CategoryDO objCategoryDO = new CategoryDO();
                        objCategoryDO.CategoryID = Convert.ToInt32(drCatagory["PkCatagoryId"]);
                        objCategoryDO.ParentCategoryID = drCatagory["FkParentCatagoryId"] != DBNull.Value?Convert.ToInt32(drCatagory["FkParentCatagoryId"]):-1;
                        objCategoryDO.CategoryName = Convert.ToString(drCatagory["CatagoryName"]);
                        dicCategory.Add(objCategoryDO.CategoryID, objCategoryDO);
                    }
                    dicAllLookups.Add("Categories", dicCategory);

                    if (dsLookups.Tables.Count > 1 && dsLookups.Tables[1].Rows.Count > 0)
                    {
                        Dictionary<int, string> dicProductType = new Dictionary<int, string>();
                        foreach (DataRow drProductType in dsLookups.Tables[1].Rows)
                            dicProductType.Add(Convert.ToInt32(drProductType["PkProductTypeId"]), Convert.ToString(drProductType["Description"]));
                        dicAllLookups.Add("ProductTypes", dicProductType);
                    }

                    if (dsLookups.Tables.Count > 2 && dsLookups.Tables[2].Rows.Count > 0)
                    {
                        Dictionary<int, string> dicBrand = new Dictionary<int, string>();
                        foreach (DataRow drBrand in dsLookups.Tables[2].Rows)
                            dicBrand.Add(Convert.ToInt32(drBrand["PkBrandId"]), Convert.ToString(drBrand["BrandName"]));
                        dicAllLookups.Add("Brands", dicBrand);
                    }
                }
            }
            catch (Exception objExc)
            {
                logger.Error("Method GetAllLookups : " + objExc.ToString());
            }
            return dicAllLookups;
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
