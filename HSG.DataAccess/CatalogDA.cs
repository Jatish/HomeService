using log4net;
using System.Data;
using HSG.DataAccess.Base;
using System.Data.SqlClient;
using HSG.Library;
using System;

namespace HSG.DataAccess
{
    public class CatalogDA
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatalogDA));

        /// <summary>
        /// This method is used to get all the products from the catalog.
        /// </summary>
        /// <returns>Product fetched as DataSet.</returns>
        public DataSet GetProducts(int iCategoryID, int iBrandID, int iProductTypeID, string strSearchText, int iPageNo, int iPageCount)
        {
            logger.Debug("Method GetProducts called.");
            SqlCommand objSqlCommand = new SqlCommand();
            objSqlCommand.CommandText = "hsProductList";
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@CatagoryId", iCategoryID);
            objSqlCommand.Parameters.AddWithValue("@BrandId", iBrandID);
            objSqlCommand.Parameters.AddWithValue("@ProductTypeId", iProductTypeID);
            objSqlCommand.Parameters.AddWithValue("@SearchText", strSearchText);
            objSqlCommand.Parameters.AddWithValue("@PageNumber", iPageNo);
            objSqlCommand.Parameters.AddWithValue("@NoOfRecords", iPageCount);

            return DBBase.Execute.ExecuteDataset(objSqlCommand);
        }

        /// <summary>
        /// This method is used for getting all the lookup data for product pages.
        /// </summary>
        /// <returns>All lookup data as DataSet.</returns>
        public DataSet GetAllLookupData()
        {
            logger.Debug("Method GetAllLookupData called.");
            SqlCommand objSqlCommand = new SqlCommand();
            objSqlCommand.CommandText = "hsProductLookUp";
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            return DBBase.Execute.ExecuteDataset(objSqlCommand);
        }

        /// <summary>
        /// This method is to add/update product to the database Product table.
        /// </summary>
        /// <param name="product">Product data as ProductDO class object.</param>
        /// <returns>ProductID as integer.</returns>
        public int SaveProduct( ProductDO objProduct)
        {
            try
            {
                logger.Debug("Method SaveProduct - hsgProductSave.");
                SqlCommand objSqlCommand = null;
                objSqlCommand = DBBase.Execute.GetCommandObject();
                objSqlCommand.CommandText = "hsProductSave";// procedure name needs to be changed.
                objSqlCommand.CommandType = CommandType.StoredProcedure;

                #region Add Parameters with Value

                if (objProduct.ProductID != -1)
                {
                    objSqlCommand.Parameters.AddWithValue("@ModifiedBy", objProduct.ModifiedBy);
                    objSqlCommand.Parameters.AddWithValue("@PkProductId", objProduct.ProductID);
                }
                else
                    objSqlCommand.Parameters.AddWithValue("@ModifiedBy", objProduct.CreatedBy);

                objSqlCommand.Parameters.AddWithValue("@FkProductTypeId", objProduct.ProductTypeID);
                objSqlCommand.Parameters.AddWithValue("@FkCatagoryId", objProduct.CategoryID);
                objSqlCommand.Parameters.AddWithValue("@FkBrandId", objProduct.BrandID);
                objSqlCommand.Parameters.AddWithValue("@FkProductGroupId", 1);
                objSqlCommand.Parameters.AddWithValue("@FkProductAvailableStatusId", objProduct.ProductAvailableStatusID);
                objSqlCommand.Parameters.AddWithValue("@ProductName", objProduct.Name);
                objSqlCommand.Parameters.AddWithValue("@ProcuctBatchNumber", objProduct.BatchNo);
                objSqlCommand.Parameters.AddWithValue("@ExpirationDate", DateTime.Now);
                objSqlCommand.Parameters.AddWithValue("@Quantity", objProduct.OnHandQuantity);
                objSqlCommand.Parameters.AddWithValue("@PurchasePrice", objProduct.PurchasePrice);
                objSqlCommand.Parameters.AddWithValue("@SellingPrice", objProduct.SellingPrice);
                objSqlCommand.Parameters.AddWithValue("@ImagePath", objProduct.ImagePath);
                //objSqlCommand.Parameters.AddWithValue("@ModificationStatus", objProduct.ModificationStatus);

                #endregion

                objProduct.ProductID = Convert.ToInt32(DBBase.Execute.ExecuteScalar(objSqlCommand));
            }
            catch(Exception objExc)
            {
                logger.Error("Method SaveProduct - Error " + objExc.ToString());
            }

            return objProduct.ProductID;
        }
    }
}
