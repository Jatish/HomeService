using System.Configuration;

namespace HSG.DataAccess.Base
{
    internal class DBConstants
    {
        /// <summary>
        /// Class which holds information about the database connection string, database related constants etc.
        /// <c>Version 1.0</c>
        /// </summary>
        internal class Constants
        {
            public static string CONNECTION_STRING = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

            public static string GetConnectionString(string strConnectionName)
            {
                return System.Configuration.ConfigurationManager.AppSettings[strConnectionName];
            }
        }
    }
}
