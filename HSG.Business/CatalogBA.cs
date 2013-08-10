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
            logger.Debug("Method GetProducts called.");

            Dictionary<string, object> dicProducts = new Dictionary<string, object>();
            DataSet dsProducts = new CatalogDA().GetProducts(iCategoryID, iBrandID, iProductTypeID, strSearchText, iPageNo, iPageCount);
            if (dsProducts.Tables.Count > 0)
            {
                logger.Debug("Total products returned : " + dsProducts.Tables[0].Rows.Count);
                Dictionary<int, ProductDO> dicProduct = new Dictionary<int, ProductDO>();
                ProductDO objProduct = new ProductDO();
                foreach (DataRow drProduct in dsProducts.Tables[0].Rows)
                {
                    objProduct = GetProductMappedData(drProduct);
                    dicProduct.Add(objProduct.ProductID, objProduct);                    
                }
                dicProducts.Add("Products", dicProduct);
            }
            return dicProducts;
        }

        /// <summary>
        /// This method is used to get product details data by its unique ID.
        /// </summary>
        /// <param name="iProductID">ProductID as integer.</param>
        /// <returns>ProductDO object with details data.</returns>
        public ProductDO GetProductDetail(int iProductID)
        {
            ProductDO objProduct = new ProductDO();
            DataSet dsProductDetail = new CatalogDA().GetProductDetail(iProductID);
            if (dsProductDetail.Tables.Count > 0 && dsProductDetail.Tables[0].Rows.Count > 0)
            {
                objProduct = GetProductMappedData(dsProductDetail.Tables[0].Rows[0]);
            }

            return objProduct;
        }

        /// <summary>
        /// This method is used to map product data from DataRow to product object.
        /// </summary>
        /// <param name="drProduct">Product data as DataRow.</param>
        /// <returns>Product details data as ProductDO.</returns>
        private ProductDO GetProductMappedData(DataRow drProduct)
        {
            ProductDO objProduct = new ProductDO();
            objProduct.ProductID = Convert.ToInt32(drProduct["PkProductId"]);
            objProduct.CategoryID = Convert.ToInt32(drProduct["FkCatagoryId"]);
            objProduct.ProductTypeID = Convert.ToInt32(drProduct["FkProductTypeId"]);
            objProduct.BrandID = Convert.ToInt32(drProduct["FkBrandId"]);
            objProduct.Name = Convert.ToString(drProduct["ProductName"]);
            objProduct.OnHandQuantity = Convert.ToInt32(drProduct["Quantity"]);
            objProduct.PurchasePrice = Convert.ToDecimal(drProduct["PurchasePrice"]);
            objProduct.SellingPrice = Convert.ToDecimal(drProduct["SellingPrice"]);
            objProduct.Description = Convert.ToString(drProduct["Description"]);
            logger.Debug("Mapping product details successfully done.");
            return objProduct;
        }

        /// <summary>
        /// This method is used for deleting a Product by its ID.
        /// </summary>
        /// <param name="iProductID">ParoductID as integer.</param>
        /// <returns>Boolean value for success or failure.</returns>
        public bool DeleteProduct(int iProductID)
        {
            logger.Debug("Called method DeleteProduct");

            try
            {
                return new CatalogDA().DeleteProduct(iProductID);
            } catch(Exception objExc)
            {
                logger.Debug("Error method DeleteProduct : " +objExc.ToString());
            }
            return false;
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
