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
        public DataSet GetAllProducts()
        {
            logger.Debug("Method GetAllProducts called.");
            SqlCommand objSqlCommand = new SqlCommand();
            objSqlCommand.CommandText = "hsgGetAllProducts";
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
