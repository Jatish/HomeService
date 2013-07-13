using log4net;
using System.Data;
using HSG.DataAccess.Base;
using System.Data.SqlClient;
using HSG.Library;

namespace HSG.DataAccess
{
    public class CatalogDA
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatalogDA));

        /// <summary>
        /// This method is used to get all the products from the catalog.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllProducts()
        {
            logger.Debug("Method GetAllProducts called.");
            SqlCommand objSqlCommand = new SqlCommand();
            objSqlCommand.CommandText = "hsgGetAllProducts";
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            return DBBase.Execute.ExecuteDataset(objSqlCommand);
        }

        public int UpdateProduct( ProductDO product)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@PkProductId", SqlDbType.Int, int.MaxValue).Value = product.ProductID;
                sqlCommand.Parameters.Add("@FkProductTypeId", SqlDbType.SmallInt, int.MaxValue).Value = product.ProductTypeID;
                sqlCommand.Parameters.Add("@FkCatagoryId", SqlDbType.SmallInt, int.MaxValue).Value = product.CategoryID;
                sqlCommand.Parameters.Add("@FkBrandId", SqlDbType.SmallInt, int.MaxValue).Value = product.BrandID;
                sqlCommand.Parameters.Add("@FkProductGroupId", SqlDbType.SmallInt, int.MaxValue).Value = 0;
                sqlCommand.Parameters.Add("@FkProductAvailableStatusId", SqlDbType.SmallInt, int.MaxValue).Value = product.ProductAvailableStatusID;
                sqlCommand.Parameters.Add("@ProductName", SqlDbType.VarChar, 500).Value = product.Name;
                sqlCommand.Parameters.Add("@ProcuctBatchNumber", SqlDbType.VarChar, 50).Value = product.BatchNo;
                sqlCommand.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value =  ;
                sqlCommand.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = product.OnHandQuantity;
                sqlCommand.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = product.PurchasePrice;
                sqlCommand.Parameters.Add("@SellingPrice", SqlDbType.Decimal).Value = product.SellingPrice;
                sqlCommand.Parameters.Add("@Image", SqlDbType.VarChar).Value = product.ImagePath;
                sqlCommand.Parameters.Add("@ModifiedBy", SqlDbType.Int).Value = product.ModifiedBy;
                sqlCommand.Parameters.Add("@ModificationStatus", SqlDbType.Int, int.MaxValue).Value = product.ModificationStatus;

            }
            catch
            { }
        }


    }
}
