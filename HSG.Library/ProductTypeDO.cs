
namespace HSG.Library
{
    public class ProductTypeDO
    {
        #region Private Variables

        /// <summary>
        ///
        /// </summary>
        private int _iProductTypeID;
        
        /// <summary>
        ///
        /// </summary>
        private string _strProductTypeName;

        #endregion

        #region Constructors

        /// <summary>
        /// User defined ProductType
        /// <summary>
        public ProductTypeDO()
        {
            this._iProductTypeID = -1;
            this._strProductTypeName = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int ProductTypeID
        {
            get { return this._iProductTypeID; }
            set { this._iProductTypeID = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public string ProductTypeName
        {
            get { return this._strProductTypeName; }
            set { this._strProductTypeName = value; }
        }

        #endregion
    }
}
