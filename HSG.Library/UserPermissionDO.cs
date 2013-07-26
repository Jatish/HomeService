
namespace HSG.Library
{
    /// <summary>
    /// Data object that holds the User permission data.
    /// </summary>
    /// <c>Version 1.0</c>
    public class UserPermissionDO
    {
        #region Private Variables

        /// <summary>
        /// 
        /// </summary>
        private string _strManageProduct;

        /// <summary>
        /// 
        /// </summary>
        private string _strMangaeInventory;
        
        /// <summary>
        /// 
        /// </summary>
        private string _strManageUser;

        /// <summary>
        /// 
        /// </summary>
        private string _strManageOrder;

        /// <summary>
        /// 
        /// </summary>
        private string _strMangaeMarket;

        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <c>Version 1.0</c>
        public UserPermissionDO()
        {
            this._strManageProduct = string.Empty;
            this._strManageUser = string.Empty;
            this._strManageOrder = string.Empty;
            this._strMangaeMarket = string.Empty;
            this._strMangaeInventory = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <value>
        /// 
        /// </value>
        /// <c>Version 1.0</c>
        public string ManageProduct
        {
            get { return this._strManageProduct; }
            set { this._strManageProduct = value; }
        }

        /// <value>
        /// 
        /// </value>
        /// <c>Version 1.0</c>
        public string MangaeInventory
        {
            get { return this._strMangaeInventory; }
            set { this._strMangaeInventory = value; }
        }

        /// <value>
        /// 
        /// </value>
        /// <c>Version 1.0</c>
        public string ManageOrder
        {
            get { return this._strManageOrder; }
            set { this._strManageOrder = value; }
        }

        /// <value>
        /// 
        /// </value>
        /// <c>Version 1.0</c>
        public string MangaeMarket
        {
            get { return this._strMangaeMarket; }
            set { this._strMangaeMarket = value; }
        }

        /// <value>
        /// 
        /// </value>
        /// <c>Version 1.0</c>
        public string ManageUser
        {
            get { return this._strManageUser; }
            set { this._strManageUser = value; }
        }

        #endregion
    }
}
