using System;

namespace HSG.Library
{
    /// <summary>
    /// Data object that holds the User related data which includes
    /// User Profile Id, User Name, Last Name, First Name and so on.
    /// </summary>
    /// <c>Version 1.0</c>
    public class UserDO
    {
        #region Private Variables

        /// <summary>
        /// Data member that contains the User Profile ID which is used to uniquely identify the User.
        /// </summary>
        private int _iUserProfileID;
        
        /// <summary>
        /// Data member that contains User Name of the User.
        /// </summary>
        private string _strUserName;

        /// <summary>
        /// Data member that contains User Name of the User.
        /// </summary>
        private string _strTitle;

        /// <summary>
        /// Data member that contains User Name of the User.
        /// </summary>
        private string _strPassword;

        /// <summary>
        /// Data member that contains User Name of the User.
        /// </summary>
        private int _iCreatedBy;

        /// <summary>
        /// Data member that contains User Name of the User.
        /// </summary>
        private string _strCreatedUser;

        /// <summary>
        /// Data member that contains User Name of the User.
        /// </summary>
        private string _objCreatedDate;

        /// <summary>
        /// Data member that contains UserType Code information.
        /// </summary>
        private string _strUserTypeCode;

        /// <summary>
        /// Data member that contains User's First Name.
        /// </summary>
        private string _strFirstName;

        /// <summary>
        /// Data member that contains User's Middle Name.
        /// </summary>
        private string _strMiddleName;

        /// <summary>
        /// Data member that contains User's Last Name.
        /// </summary>
        private string _strLastName;

        /// <summary>
        /// Data member that contains User's Email.
        /// </summary>
        private string _strEmail;

        /// <summary>
        /// Data member that contains User's Last login date.
        /// </summary>
        private DateTime? _objLastLoginDate;

        /// <summary>
        /// Data member that contains User's Password change pending.
        /// </summary>
        private bool _bIsPasswordChangePending;

        /// <summary>
        /// Data member that contains date when the the user changed last time.
        /// </summary>
        private DateTime? _objPasswordChangeDate;

        /// <summary>
        /// Data member that contains unread notifications count.
        /// </summary>
        private int _iNotificationCount;

        /// <summary>
        /// Data member that contains Academic year of the User.
        /// </summary>
        private bool _bIsUserExits;

        /// <summary>
        /// Data member that contains whether the user is Active or not.
        /// </summary>
        private string _strStatus;

        /// <summary>
        /// Data member that contains the UserSessionID which is used to uniquely identify the UserSession.
        /// </summary>
        private int _iUserSessionID;

        /// <summary>
        ///
        /// </summary>
        private bool _bAdminPermission;

        /// <summary>
        /// 
        /// </summary>
        private UserPermissionDO _objUserPermission;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor where we are initializing the Data members of this class.
        /// </summary>
        /// <c>Version 1.0</c>
        public UserDO()
        {
            this._iUserProfileID = -1;
            this._strUserName = string.Empty;
            this._strPassword = string.Empty;
            this._strUserTypeCode = string.Empty;
            this._strTitle = string.Empty;
            this._strFirstName = string.Empty;
            this._strMiddleName = string.Empty;
            this._strLastName = string.Empty;
            this._strEmail = string.Empty;
            this._objLastLoginDate = DateTime.MinValue;
            this._bIsPasswordChangePending = false;
            this._objPasswordChangeDate = DateTime.MinValue;
            this._iNotificationCount = 0;
            this._bIsUserExits = false;
            this._strStatus = string.Empty;
            this._iUserSessionID = -1;
            this._iCreatedBy = -1;
            this._strCreatedUser = string.Empty;
            this._objCreatedDate = string.Empty;
            this._bAdminPermission = false;
            this._objUserPermission = new UserPermissionDO();
        }

        #endregion

        #region Public Properties

        /// <value>
        /// Public property to get/set the User Profile ID of the User, which uniquely identifies the User.
        /// </value>
        /// <c>Version 1.0</c>
        public int UserProfileID
        {
            get { return this._iUserProfileID; }
            set { this._iUserProfileID = value; }
        }

        /// <value>
        /// Public property to get/set the ID of user who created this User.
        /// </value>
        /// <c>Version 1.0</c>
        public int CreatedBy
        {
            get { return this._iCreatedBy; }
            set { this._iCreatedBy = value; }
        }

        /// <value>
        /// Public property to get/set the User Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string UserName
        {
            get { return this._strUserName; }
            set { this._strUserName = value; }
        }

        /// <value>
        /// Public property to get/set the User Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string Title
        {
            get { return this._strTitle; }
            set { this._strTitle = value; }
        }

        /// <value>
        /// Public property to get/set the User Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string Password
        {
            get { return this._strPassword; }
            set { this._strPassword = value; }
        }

        /// <value>
        /// Public property to get/set the User Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string CreatedUser
        {
            get { return this._strCreatedUser; }
            set { this._strCreatedUser = value; }
        }

        /// <value>
        /// Public property to get/set the User Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string CreatedDate
        {
            get { return this._objCreatedDate; }
            set { this._objCreatedDate = value; }
        }

        /// <value>
        /// Public property to get/set the user type code inormation.
        /// </value>
        /// <c>Version 1.0</c>
        public string UserTypeCode
        {
            get { return this._strUserTypeCode; }
            set { this._strUserTypeCode = value; }
        }

        /// <value>
        /// Public property to get/set the _strFirstName data member,
        /// which contains the First Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string FirstName
        {
            get { return this._strFirstName; }
            set { this._strFirstName = value; }
        }

        /// <value>
        /// Public property to get/set the _strMiddleName data member,
        /// which contains the Middle Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string MiddleName
        {
            get { return this._strMiddleName; }
            set { this._strMiddleName = value; }
        }

        /// <value>
        /// Public property to get/set the _strLastName data member,
        /// which contains the Last Name of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string LastName
        {
            get { return this._strLastName; }
            set { this._strLastName = value; }
        }

        /// <value>
        /// Public property to get/set the _strEmail data member,
        /// which contains the Email of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public string Email
        {
            get { return this._strEmail; }
            set { this._strEmail = value; }
        }

        /// <value>
        /// Public property to get the Full Name of the User(i.e., LastName, FirstName MiddleName).
        /// </value>
        /// <c>Version 1.0</c>
        public string FullName
        {
            get
            {
                return string.Concat(this._strLastName, ", ", this._strFirstName,
                    (string.IsNullOrEmpty(this._strMiddleName) ? string.Empty : this._strMiddleName));
            }
        }

        /// <value>
        /// Public property to get/set the _objLastLoginDate data member,
        /// which contains the Last Login date of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public DateTime? LastLoginDate
        {
            get { return this._objLastLoginDate; }
            set { this._objLastLoginDate = value; }
        }

        /// <value>
        /// Public property to get/set the _bIsPasswordChangePending data member,
        /// which contains the pasword change status of the User.
        /// </value>
        /// <c>Version 1.0</c>
        public bool IsPasswordChangePending
        {
            get { return this._bIsPasswordChangePending; }
            set { this._bIsPasswordChangePending = value; }
        }

        /// <value>
        /// Public property to get/set the _objPasswordChangeDate data member,
        /// which contains the last password change date.
        /// </value>
        /// <c>Version 1.0</c>
        public DateTime? PasswordChangeDate
        {
            get { return this._objPasswordChangeDate; }
            set { this._objPasswordChangeDate = value; }
        }

        // <value>
        /// Public property to get/set the _iNotificationCount data member,
        /// which contains the notifications count which are unread by the user.
        /// </value>
        /// <c>Version 1.0</c>
        public int NotificationCount
        {
            get { return this._iNotificationCount; }
            set { this._iNotificationCount = value; }
        }

        // <value>
        /// Public property to get/set the _bIsUserExits data member,
        /// which represents whether the user is exists or not.
        /// </value>
        /// <c>Version 1.0</c>
        public bool IsUserExists
        {
            get { return this._bIsUserExits; }
            set { this._bIsUserExits = value; }
        }

        /// <value>
        /// Public property to get/set the _strStatus data member,
        /// which represents whether the user is active or not. If 'A' the user is Active.
        /// </value>
        /// <c>Version 1.0</c>
        public string Status
        {
            get { return this._strStatus; }
            set { this._strStatus = value; }
        }

        /// <value>
        /// Public property to get/set the _iUserSessionID data member, which uniquely identifies the UserSession.
        /// </value>
        /// <c>Version 1.0</c>
        public int UserSessionID
        {
            get { return this._iUserSessionID; }
            set { this._iUserSessionID = value; }
        }

        /// <value>
        /// Public property to get/set the _bAdminPermission data member,
        /// which represents whether the user has admin permission or not.
        /// </value>
        /// <c>Version 1.0</c>
        public bool AdminPermission
        {
            get { return this._bAdminPermission; }
            set { this._bAdminPermission = value; }
        }

        /// <value>
        /// Public property to get/set the _objUserPermission data member, 
        /// which holds user permission.
        /// </value>
        /// <c>Version 1.0</c>
        public UserPermissionDO UserPermission
        {
            get { return this._objUserPermission; }
            set { this._objUserPermission = value; }
        }

        #endregion
    }
}
