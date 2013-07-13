using System;

namespace HSG.Library
{
    public class ProductDO
    {
        #region Private Variables

        /// <summary>
        ///
        /// </summary>
        private int _iProductID;

        /// <summary>
        ///
        /// </summary>
        private int _iProductTypeID;

        /// <summary>
        ///
        /// </summary>
        private int _iCategoryID;

        /// <summary>
        ///
        /// </summary>
        private int _iBrandID;

        /// <summary>
        ///
        /// </summary>
        private int _iProductAvailableStatusID;

        /// <summary>
        ///
        /// </summary>
        private string _strName;

        /// <summary>
        /// 
        /// </summary>
        private string _strBatchNo;

        /// <summary>
        ///
        /// </summary>
        private int _iOnHandQuantity;

        /// <summary>
        /// 
        /// </summary>
        private decimal _dPurchasePrice;

        /// <summary>
        ///
        /// </summary>
        private decimal _dSellingPrice;

        /// <summary>
        /// 
        /// </summary>
        private string _strImagePath;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _dtmCreatedDate;

        /// <summary>
        /// 
        /// </summary>
        private int _iCreatedBy;

        /// <summary>
        ///
        /// </summary>
        private bool _bModificationStatus;

        /// <summary>
        ///
        /// </summary>
        private int _iModifiedBy;

        #endregion

        #region Constructors

        /// <summary>
        /// User defined Product
        /// <summary>
        public ProductDO()
        {
            this._iProductID = -1;
            this._iCategoryID = -1;
            this._iProductTypeID = -1;
            this._iBrandID = -1;
            this._iProductAvailableStatusID = -1;
            this._strName = string.Empty;
            this._strBatchNo = string.Empty;
            this._iOnHandQuantity = -1;
            this._dPurchasePrice = -1;
            this._dSellingPrice = -1;
            this._strImagePath = string.Empty;
            this._dtmCreatedDate = DateTime.MinValue;
            this._iCreatedBy = -1;
            this._dtmModifiedDate = DateTime.MinValue;
            this._bModificationStatus = 0;
        }

        #endregion

        #region Public Properties

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int ProductID
        {
            get { return this._iProductID; }
            set { this._iProductID = value; }
        }

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
        public int ProductTypeID
        {
            get { return this._iProductTypeID; }
            set { this._iProductTypeID = value; }
        }

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
        public int ProductAvailableStatusID
        {
            get { return this._iProductAvailableStatusID; }
            set { this._iProductAvailableStatusID = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public string Name
        {
            get { return this._strName; }
            set { this._strName = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public string BatchNo
        {
            get { return this._strBatchNo; }
            set { this._strBatchNo = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int OnHandQuantity
        {
            get { return this._iOnHandQuantity; }
            set { this._iOnHandQuantity = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <c>Version 1.0</c>
        public decimal PurchasePrice
        {
            get { return this._dPurchasePrice; }
            set { this._dPurchasePrice = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public decimal SellingPrice
        {
            get { return this._dSellingPrice; }
            set { this._dSellingPrice = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public string ImagePath
        {
            get { return this._strImagePath; }
            set { this._strImagePath = value; }
        }
        
        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public DateTime? CreatedDate
        {
            get { return this._dtmCreatedDate; }
            set { this._dtmCreatedDate = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int CreatedBy
        {
            get { return this._iCreatedBy; }
            set { this._iCreatedBy = value; }
        }

        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public bool ModificationStatus
        {
            get { return this._dtmModifiedDate; }
            set { this._dtmModifiedDate = value; }
        }
        
        /// <value>
        ///
        /// </value>
        /// <c>Version 1.0</c>
        public int ModifiedBy
        {
            get { return this._iModifiedBy; }
            set { this._iModifiedBy = value; }
        }

        #endregion
    }
}
