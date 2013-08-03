
namespace HSG.Library
{
    public class BrandDO
    {
        #region Private Variables

        /// <summary>
        ///
        /// </summary>
        private int _iBrandID;
        
        /// <summary>
        ///
        /// </summary>
        private string _strBrandName;

        #endregion

        #region Constructors

        /// <summary>
        /// User defined Brand
        /// <summary>
        public BrandDO()
        {
            this._iBrandID = -1;
            this._strBrandName = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int BrandID
        {
            get { return this._iBrandID; }
            set { this._iBrandID = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public string BrandName
        {
            get { return this._strBrandName; }
            set { this._strBrandName = value; }
        }

        #endregion
    }
}
