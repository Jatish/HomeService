/*
* This method is used to get data from server by making ajax call.
* if response is empty, calling function has to handle the empty response object.
* Parameters{
strUrl = URL as string to be used for ajax call.
arrParams = Parameters to be passed to the ajax call as object array.
bIsCache = Should set cache ON as boolean value.
bIsAsync = Is an aynchronous call as boolean value.
bShowLoadPnl - Whether Page loading to be happen or not.
fnSuccess = Function reference to be called on success of the ajax cal.
fnSuccessParams = Contains parameters to pass for the Success function.
}
*/
function getData(strUrl, arrParams, bIsCache, bIsAsync, bShowLoadPnl, fnSuccess, fnSuccessParams) {
    var objResponse = null;
    var bIsLoading = ((bShowLoadPnl != undefined) ? bShowLoadPnl : false);
//    var bIsValid = checkSessionValidation();
//    if (!bIsValid)
//        window.location = jsonAppData.ContextPath + jsonAppData.DistrictShortName;
//    else {
        $.ajax({
            cache: ((bIsCache == undefined) ? false : bIsCache),
            type: 'GET',
            async: ((bIsAsync == undefined) ? true : bIsAsync),
            url: strUrl,
            data: arrParams,
            beforeSend: function () { if (bIsLoading) onBeginRequest(); },
            dataType: 'json',
            success: function (response) {
                if (bIsLoading) onEndRequest();
                if (response != undefined && response != '') {
                    if (fnSuccess != undefined) fnSuccess(response, fnSuccessParams);
                    objResponse = response;
                }
            },
            error: function (message) {
                if (bIsLoading) onEndRequest();
                alert("Error occurred while processing your request. Please try again.");
            }
        });
//    }
    return objResponse;
}

/*
* This method is used to send data to server by making ajax call.
* [mainly to save, update, delete or any other server operations as well]
* if response is empty, calling function has to handle the empty response object.
* Parameters{
strUrl = URL as string to be used for ajax call.
arrParams = Parameters to be passed to the ajax call as object array.
bIsCache = Should set cache ON as boolean value.
bIsAsync = Is an aynchronous call as boolean value.
bShowLoadPnl - Whether Page loading to be happen or not.
fnSuccess = Function reference to be called on success of the ajax cal.
fnSuccessParams = Contains parameters to pass for the Success function.
}
*/
function postData(strUrl, arrParams, bIsCache, bIsAsync, bShowLoadPnl, fnSuccess, fnSuccessParams) {
    var objResponse = null;
    var bIsLoading = ((bShowLoadPnl != undefined) ? bShowLoadPnl : false);
//    var bIsValid = checkSessionValidation();
//    if (!bIsValid)
//        window.location = jsonAppData.ContextPath + jsonAppData.DistrictShortName;
//    else {
        $.ajax({
            cache: ((bIsCache == undefined) ? false : bIsCache),
            type: 'POST',
            url: strUrl,
            async: ((bIsAsync == undefined) ? true : bIsAsync),
            dataType: 'json',
            beforeSend: function () { if (bIsLoading) onBeginRequest(); },
            //contentType: 'application/json; charset=utf-8',
            data: arrParams,
            success: function (response) {
                if (bIsLoading) onEndRequest();
                if (response != undefined && response != '') {
                    if (fnSuccess != undefined) fnSuccess(response, fnSuccessParams);
                    objResponse = response;
                }
            },
            error: function (message) {
                if (bIsLoading) onEndRequest();
                alert("Error occurred while processing your request. Please try again.");
            }
        });
//    }
    return objResponse;
}

function updateServiceInformation(jsonHSGServices) {
    //    if (!isValidSession()) {
    //        redirectToDefault();
    //    }
    //    else {
    jsonHSGServices.Home = "http://localhost/hsg.service.devqa/Home/HomeService.svc";
    jsonHSGServices.Catalog = "http://localhost/hsg.service/Catalog/CatalogService.svc";
    jsonHSGServices.Order = "http://localhost/hsg.service.devqa/Order/OrderService.svc";
    jsonHSGServices.Marketing = "http://localhost/hsg.service.devqa/Marketing/MarketingService.svc";
    jsonHSGServices.User = "http://localhost/hsg.service.devqa/User/UserService.svc";
    //    }
}

/*
* This method loads partial views.
*/
function loadPartialView(url) {
    jQuery.ajax({
        type: 'GET',
        url: jsonAppData.ContextPath + url,
        async: false,
        success: function (result) {
            $("#divMainContainer").html(result);
            $("#divTitle").hide();
        }
    });
}