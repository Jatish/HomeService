using log4net;
using System.Data;
using HSG.DataAccess.Base;
using System.Data.SqlClient;

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
    }
}
