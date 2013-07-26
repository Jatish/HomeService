using System.Web.Mvc;

namespace HSG.Web.Controllers
{
    public class LoginController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Action method to validate username and password, save user information in session.
        /// </summary>
        /// <returns>Login view.</returns>
        /// <c>Version 1.0</c>
        //public string ValidateUsers()
        //{
            //LoginServiceClient objLoginClient = new LoginServiceClient();
            //UserSessionDO objUserSession = new UserSessionDO();
            //string strUserName = Request.Params.Get("UsrName");
            //string strPassword = Request.Params.Get("Pwd");
            //bool bAllowLogin = true;
            //int iLoginAttempts = 0;

            //string strDistrictShortName = string.Empty;
            //bool bIsDistrictLDAPEnabled = false;
            //if (CommonMethod.IsValidObject(SessionManager.ReadSession(UtilityConstants.SessionNames.DISTRICT_SHORT_NAME)) && CommonMethod.IsValidObject(SessionManager.ReadSession(UtilityConstants.SessionNames.IS_DIST_LDAP_ENABLED)))
            //{
            //    strDistrictShortName = Convert.ToString(SessionManager.ReadSession(UtilityConstants.SessionNames.DISTRICT_SHORT_NAME));
            //    bIsDistrictLDAPEnabled = Convert.ToBoolean(SessionManager.ReadSession(UtilityConstants.SessionNames.IS_DIST_LDAP_ENABLED));
            //    logger.Debug(string.Concat("strDistrictShortName==>", strDistrictShortName, " and bIsDistrictLDAPEnabled==>", bIsDistrictLDAPEnabled, " from session"));
            //}
            //else
            //{
            //    strDistrictShortName = Request.Params.Get("dsname");
            //    bIsDistrictLDAPEnabled = Convert.ToBoolean(Request.Params.Get("bIsDistLDAPEnbd"));
            //    logger.Debug(string.Concat("strDistrictShortName==>", strDistrictShortName, " and bIsDistrictLDAPEnabled==>", bIsDistrictLDAPEnabled, " from js variable"));
            //}

            //bool bIsUserLDAPExempted = objLoginClient.IsUserLDAPExempted(strUserName, strDistrictShortName);
            //logger.Debug("User LDAP exemption status: " + bIsUserLDAPExempted);

            //UserDO objUser = new UserDO();
            //if (bIsDistrictLDAPEnabled && !bIsUserLDAPExempted)
            //{
            //    LdapAuthenticationClient objLDAPAuthentication = new LdapAuthenticationClient();

            //    //logger.Debug("LDAP Auth Status: " + objLDAPAuthentication.authenticate(strDistrictShortName, strUserName, strPassword));
            //    if ("valid" == objLDAPAuthentication.authenticate(strDistrictShortName, strUserName, strPassword))
            //    {
            //        logger.Debug("LDAP Authentication Status: Valid");
            //        objUser = objLoginClient.AuthenticateUserLDAP(strUserName, strDistrictShortName);
            //        objUser.IsUserExists = true;
            //    }
            //    else objUser.IsUserExists = false;
            //}
            //else
            //{
            //    objUser = objLoginClient.AuthenticateUser(strUserName, strPassword, strDistrictShortName);
            //    logger.Debug("Normal authentication: " + objUser.IsUserExists);
            //    objUser.IsUserExists = true;
            //}
            //List<UserSessionDO> lstUserSession = HttpContext.Application["UserSession"] != null ? (List<UserSessionDO>)HttpContext.Application["UserSession"] : new List<UserSessionDO>();
            //iLoginAttempts = 0; //lstUserSession.Count > 0 ? Convert.ToInt32(lstUserSession.Where(x => x.LoginDate.Value.AddMinutes(UtilityConstants.Constants.MINUTES_LOCK) > DateTime.Now && x.UserName == (strDistrictShortName + strUserName)).OrderBy(x => x.LoginDate).Select(x => x.LoginDate).Count()) : 0; // SET_CURRENT_DATE

            //if (lstUserSession.Count > 0)
            //{
            //    lstUserSession = lstUserSession.Where(x => x.LoginDate.Value.AddMinutes(UtilityConstants.Constants.MINUTES_LOCK) > DateTime.Now).ToList();
            //    //iLoginAttempts = Convert.ToInt32(lstUserSession.Where(x => x.LoginDate.Value.AddMinutes(UtilityConstants.Constants.MINUTES_LOCK) > DateTime.Now && x.UserName == (strDistrictShortName + strUserName)).OrderBy(x => x.LoginDate).Select(x => x.LoginDate).Count());
            //}

            //AuthenticateUser.SignIn((strDistrictShortName + strUserName));
            //if (objUser.UserProfileID != -1 && iLoginAttempts < UtilityConstants.Constants.MAX_ATTEMPTS)
            //{
            //    logger.Debug("The user is Authenticated and store in session. ");
            //    lstUserSession = lstUserSession.Where(x => (x.UserName != (strDistrictShortName + strUserName))).ToList();
            //    SessionManager.AddToSession(UtilityConstants.SessionNames.USER, objUser);
            //    SessionManager.AddToSession(UtilityConstants.SessionNames.DISTRICT_SHORT_NAME, strDistrictShortName);
            //    SessionManager.AddToSession(UtilityConstants.SessionNames.IS_DIST_LDAP_ENABLED, bIsDistrictLDAPEnabled);
            //    logger.Debug("User District Id added to the session: " + objUser.DistrictName);
            //}
            //else
            //{
            //    logger.Debug("The user Authentication is failed with the user - " + (strDistrictShortName + strUserName) + " - " + iLoginAttempts);
            //    objUserSession.UserName = (strDistrictShortName + strUserName);
            //    objUserSession.LoginDate = DateTime.Now;
            //    lstUserSession.Add(objUserSession);
            //    HttpContext.Application["UserSession"] = lstUserSession;
            //}
            //bAllowLogin = true; // iLoginAttempts >= UtilityConstants.Constants.MAX_ATTEMPTS ? false : true;
            //var vUserData = new
            //{
            //    AllowLogin = bAllowLogin,
            //    UserData = objUser
            //};
            //objLoginClient.Close();
            //return UtilityConstants.CommonMethods.SerializeData(vUserData);
        //}

        /// <summary>
        /// Action method to update password.
        /// </summary>
        /// <returns>Login view.</returns>
        /// <c>Version 1.0</c>
        //public JsonResult ResetPassword()
        //{
            //LoginServiceClient objLoginClient = new LoginServiceClient();
            //UserDO objUser = (UserDO)SessionManager.ReadSession(UtilityConstants.SessionNames.USER);
            //bool bPwdChange = false;
            //bool bIsSendMail = false;
            //string strPassword = Request.Params.Get("pwd");
            //string strURL = string.IsNullOrEmpty(Request.Params.Get("dsnme")) ? string.Empty : Request.Params.Get("dsnme");
            //logger.Debug("strURL --> " + strURL);
            //string strPasswordUpdate = Convert.ToString(JsonConvert.DeserializeObject(objLoginClient.ChangePassword(objUser.UserName, new SecureData().EncryptAndHash(strPassword), strURL)));
            //bPwdChange = Convert.ToBoolean(JsonUtility.GetJsonValueByKey(strPasswordUpdate, "IsPwdChange"));
            //bIsSendMail = Convert.ToBoolean(JsonUtility.GetJsonValueByKey(strPasswordUpdate, "IsSendMail"));
            //if (bIsSendMail) objUser.IsPasswordChangePending = bPwdChange;
            //objLoginClient.Close();
            //return Json(new { IsAgreementPending = objUser.IsAgreementPending, IsPwdChange = bPwdChange, IsSendMail = bIsSendMail }, JsonRequestBehavior.AllowGet);
        //}

        /// <summary>
        /// Action Method to get the ChangePassword information.
        /// </summary>
        /// <returns>ChangePassword view</returns>
        /// <c>Version 1.0</c>
        public ActionResult ChangePassword()
        {
            return View();
        }

        /// <summary>
        /// Action Method to save the browser information.
        /// </summary>
        /// <returns>ChangePassword view</returns>
        /// <c>Version 1.0</c>
        //public JsonResult InsertBrowserInfo()
        //{
            //LoginServiceClient objLoginClient = new LoginServiceClient();
            //UserDO objUser = (UserDO)SessionManager.ReadSession(UtilityConstants.SessionNames.USER);
            //objUser.UserSessionID = objLoginClient.InsertBrowserDetails(objUser.UserProfileID, Request.Params.Get("browserName"), Request.Params.Get("majorVersion"), Request.Params.Get("OSName"), objUser.InstanceID);
            //objLoginClient.Close();
            //return Json(true, JsonRequestBehavior.AllowGet);
        //}
    }
}
