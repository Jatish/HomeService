
namespace HSG.Library
{
    public class CategoryDO
    {
        #region Private Variables

        /// <summary>
        ///
        /// </summary>
        private int _iCategoryID;

        /// <summary>
        ///
        /// </summary>
        private int _iParentCategoryID;

        /// <summary>
        ///
        /// </summary>
        private string _strCategoryName;

        #endregion

        #region Constructors

        /// <summary>
        /// User defined Category
        /// <summary>
        public CategoryDO()
        {
            this._iCategoryID = -1;
            this._iParentCategoryID = -1;
            this._strCategoryName = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int CategoryID
        {
            get { return this._iCategoryID; }
            set { this._iCategoryID = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int ParentCategoryID
        {
            get { return this._iParentCategoryID; }
            set { this._iParentCategoryID = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public string CategoryName
        {
            get { return this._strCategoryName; }
            set { this._strCategoryName = value; }
        }
        
        #endregion
    }
}
