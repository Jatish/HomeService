var vProducts = [];

//Paging related global variables
var stype = '';
var psize = 1;

/*
* This method is used to load ProductManager page content.
*/
function loadCategoryListContent() {
    var sHtml = '';
    sHtml += '<table width="100%"><tr>';
    sHtml += '<td style="width:50%;"></td>';
    sHtml += '<td style="text-align:right; vertical-align:middle;">';
    sHtml += '<button id="btnAddNew" class="hsInputStyle" type="button" style="width:80px;"><span>Add New</span></button>&nbsp;';
    sHtml += '<button id="btnDelectSelected" class="hsInputStyle" type="button" style="width:150px;"><span>Remove Selected</span></button>&nbsp;';
    sHtml += '<button id="btnSelectAll" class="hsInputStyle" type="button" style="width:80px;"><span>Select All</span></button>&nbsp;';
    sHtml += '</td></tr></table>';
    sHtml += '<ul class="admin-main-menu-1 icons-menu-1a">';
    sHtml += '<li onclick="loadProductListViewContent();">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkCategory" value="CategoryID">Category 1</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkCategory" value="CategoryID">Category 2</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkCategory" value="CategoryID">Category 3</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '</ul>';
    sHtml += '<ul class="admin-main-menu-1 icons-menu-1a">';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkCategory" value="CategoryID">Category 4</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkCategory" value="CategoryID">Category 5</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkCategory" value="CategoryID">Category 6</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '</ul>';
    $('#divAdminMainContent').html(sHtml);
}

function loadProductListViewContent() {
    var sHtml = '';

    vProducts = getData(jsonHSGServices.Catalog + "/GetProducts", {}, false, false, false);
    var hBreadCrumb = document.getElementById("hBreadCrumb");
    var str = '';
    str += '<a href="javascript:void(0);" onclick="buildAdminMainPage();">Administration Menu</a>  <b>&gt;</b>Products';
    hBreadCrumb.innerHTML = str;

    sHtml += '<table width="100%"><tr>';
    sHtml += '<td style="width:50%;"></td>';
    sHtml += '<td style="text-align:right; vertical-align:middle;">';
    sHtml += '<button id="btnAddNew" class="hsInputStyle" type="button" style="width:80px;" onclick="loadProductAddEditView(-1);" ><span>Add New</span></button>&nbsp;';
    sHtml += '<button id="btnDelectSelected" class="hsInputStyle" type="button" style="width:150px;"><span>Remove Selected</span></button>&nbsp;';
    sHtml += '<button id="btnSelectAll" class="hsInputStyle" type="button" style="width:80px;"><span>Select All</span></button>&nbsp;';
    sHtml += '</td></tr></table>';

    sHtml +='<div class="list-heading">Filter By:</div>';    
    sHtml += '<table width="100%"><tr>';
    sHtml += '<td style="width:10%;">Category:&nbsp;</td><td><select id="ddlCategory" style="width:99%;" onchange="onChangeCategory(\'\');"></select></td>';
    sHtml += '<td style="width:10%; text-align:right;">Product Type:&nbsp;</td><td><select id="ddlType" style="width:99%;" onchange="onChangeTypes();"></select></td>';
    sHtml += '<td style="width:10%; text-align:right;">Brand:</td><td><select id="ddlBrand" style="width:99%;" onchange="onChangeBrand();"></select></td>';
    sHtml += '</tr></table>';

    sHtml += '<table class="table-listview tvat alt-rows">';
    sHtml += '<colgroup><col align="left" /><col align="left" /><col align="left" /><col /><col /><col/></colgroup>'
    sHtml += '<tr class="th-1 tvam"><td style="text-align: left;">Product Name</td><td style="text-align: left;">OnHand Quantity</td>';
    sHtml += '<td style="text-align: left;">Created By</td><td>Purchase Price</td><td>Selling Price</td>';
    sHtml += '<td>&nbsp;</td></tr>';
    //    sHtml += '<tr id="trSort" class="th-1 th_sort alt">';
    //    sHtml += prepareSortRow();
    //    sHtml += '<tr/>';
    sHtml += '<tbody id="tblProducts">';
    sHtml += '</tbody>';
    sHtml += '</table>';
    $('#divAdminMainContent').empty().html(sHtml);
    
    loadProductList();
}

function loadProductList() {
   // if (vProducts.length > 0) {
        // vProducts.Products;
        // vProducts.ProductsCount;
        //$('#divProducts').show();
        //$('#divSearchProduct').show();
        //$('#divNoData').hide();
        $('#tblProducts').empty().append(prepareProductListBody($.parseJSON(vProducts.GetProductsResult).Products));
        //bind paging div on page load, so passing 1 as current page  
        BuildPager(10, 1, 'divPager');
        //onAutoSuggest('txtSearch', vProducts.AutoSuggest);
 //   } else {
//        if (vProducts.ProductsCount <= 0) $('#divProducts').hide();
//        $('#divCoursePlans').hide();
//        $('#divPager').hide();
//        $('#divNoData').empty().html('<span style="color:Red">No Products available for this Category.</span>');
//        $('#divNoData').show();
//    }
}

/*
* Function to prepare body of the grid with data as per the page size.
*/
function prepareProductListBody(products) {
    var s1 = '';
    $.each(products, function (iIndex, item) {
        s1 += '<tr id="trCoursePlan_' + item.ProductID + '" ' + ((iIndex % 2 == 0) ? 'class="alt"' : '') + '>';
        s1 += '<td style="text-align: left;"><a href="javascript:void(0);" onclick="">' + item.Name + '</a></td>';
        s1 += '<td style="text-align: left;">' + item.OnHandQuantity + '</td>';
        s1 += '<td style="text-align: left;">' + item.CreatedBy + '</td>';
        s1 += '<td>' + item.PurchasePrice + '</td>';
        s1 += '<td>' + item.SellingPrice + '</td>';
//        s1 += '<td><a id="lbtnLock_' + iIndex + '" href="javascript:void(0);" class="icon-link ' + ((item.IsActive) ? "icon-locked" : "icon-unlocked") + '" title="' + ((item.IsCoursePlanLocked) ? "Unlock Course Plan" : "Lock Course Plan") + '" onclick="javascript:onLockCoursePlan(' + iIndex + ')"></a></td>';
//        s1 += '<td><a id="lbtnCoursePlanning_' + iIndex + '" href="javascript:void(0);" class="buttons-6 silver" ' + ((item.ExpirationDate) ? "" : "style=\"display:none;\"") + ' onclick="javascript:onAECoursePlan(' + item.CoursePlanID + ', true);">Course Planning</a></td>';
//        s1 += '<td><a href="javascript:void(0);" class="icon-link icon-delete" onclick=""></a></td>';
        s1 += '</tr>';
    });
    return s1;
}

/*
* Function to prepare body of the product add edit view.
*/
function loadProductAddEditView(productID) {

    var hBreadCrumb = document.getElementById("hBreadCrumb");
    var str = '';
    str += '<a href="javascript:void(0);" onclick="buildAdminMainPage();">Administration Menu</a> <b>&gt;</b>';
    str += '<a href="javascript:void(0);" onclick="loadProductManagerContent();">Product Manager</a> <b>&gt;</b>';
    str += '<a href="javascript:void(0);" onclick="loadProductListViewContent();">Product ListView</a> <b>&gt;</b>' + ((productID != -1) ? 'Edit Product' : 'Create Product');
    hBreadCrumb.innerHTML = str;

    var sHtml = '';
    sHtml += '<table width="100%"><tr>';
    sHtml += '<td style="width:50%;"></td>';
    sHtml += '<td style="text-align:right; vertical-align:middle;">';
    sHtml += '<button id="btnAddNew" class="hsInputStyle" type="button" style="width:80px;"><span>Add New</span></button>&nbsp;';
    sHtml += '<button id="btnDelectSelected" class="hsInputStyle" type="button" style="width:150px;"><span>Remove</span></button>&nbsp;';
    sHtml += '</td></tr></table>';
    sHtml += '<div id="divProductDetails">';
    sHtml += '<table class="form-table-1 alt-rows">';
    sHtml += '<colgroup>';
    sHtml += '<col align="left" style="width:30%;" />';
    sHtml += '<col align="left" />';
    sHtml += '</colgroup>';
    sHtml += '<tbody>';
    sHtml += '<tr id="trName">';
    sHtml += '<td style="text-align: left;"><b>Name:</b></td>';
    sHtml += '<td style="text-align: left;"><input id="txtName" type="text" style="width:400px;" /></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trImage">';
    sHtml += '<td style="text-align: left;"><b>Image:</b></td>';
    sHtml += '<td style="text-align: left;">';
    sHtml += '<input id="flFile" name="file" type="file" style="width:300px;" />';
    sHtml += '</td>';
    sHtml += '</tr> ';
    sHtml += '<tr class="alt">';
    sHtml += '<td style="text-align: left;"><b>Category:</b></td>';
    sHtml += '<td style="text-align: left;">';
    sHtml += '<select id="ddlCategory" style="width:200px;" onchange="onChangeCategory(\'\');"></select>';
    sHtml += '</td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trType">';
    sHtml += '<td style="text-align: left;"><b>Type:</b></td>';
    sHtml += '<td style="text-align: left;">';
    sHtml += '<select id="ddlType" style="width:200px;" onchange="onChangeTypes();"></select>';
    sHtml += '</td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trBrand">';
    sHtml += '<td style="text-align: left;"><b>Brand:</b></td>';
    sHtml += '<td style="text-align: left;">';
    sHtml += '<select id="ddlBrand" style="width:200px;" onchange="onChangeBrand();"></select>';
    sHtml += '</td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trBatchNo">';
    sHtml += '<td style="text-align: left;"><b>Batch Number:</b></td>';
    sHtml += '<td style="text-align: left;"><input id="txtBatchNo" type="text" style="width:250px;" /></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trExpDate">';
    sHtml += '<td style="text-align: left;"><b>Expiration Date:</b></td>';
    sHtml += '<td id="tdExpDate" style="text-align: left;"></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trAvailableStats">';
    sHtml += '<td style="text-align: left;"><b>Available Status:</b></td>';
    sHtml += '<td id="tdAvailableStats" style="text-align: left;"></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trQuantity">';
    sHtml += '<td style="text-align: left;"><b>Quantity:</b></td>';
    sHtml += '<td style="text-align: left;"><input id="txtQuantity" type="text" style="width:250px;" /></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="tr1">';
    sHtml += '<td style="text-align: left;"><b>Purchase Price:</b></td>';
    sHtml += '<td style="text-align: left;"><input id="Text1" type="text" style="width:250px;" /></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="tr2">';
    sHtml += '<td style="text-align: left;"><b>Selling Price:</b></td>';
    sHtml += '<td style="text-align: left;"><input id="Text2" type="text" style="width:250px;" /></td>';
    sHtml += '</tr>';
    sHtml += '<tr id="trNotes" class="tvat">';
    sHtml += '<td style="text-align: left;"><b>Description:</b></td>';
    sHtml += '<td style="text-align: left;">';
    sHtml += '<div style="width:500px;">';
    sHtml += '<textarea id="txtNotes" name="txtNotes" style="width:400px;"></textarea>';
    sHtml += '</div>';
    sHtml += '</td>';
    sHtml += '</tr>';
    sHtml += '</tbody>';
    sHtml += '</table>';
    sHtml += '</div>';
    sHtml += '<div class="buttons tac">';
    sHtml += '<button id="btnSave" class="hsInputStyle" type="button" style="width:70px;" onclick="javascript:saveProduct();"><span>Save</span></button>&nbsp;';
    sHtml += '<button id="btnCancel" class="hsInputStyle" type="button" style="width:70px;" onclick="javascript:loadProductListViewContent();"><span>Cancel</span></button>';
    sHtml += '</div>';
    $('#divAdminMainContent').empty().html(sHtml);

    /* Populate all combo boxes. */
    // populateCategories(vProducts.Categories);
    // populateBrands(vProducts.Brands);
    // populateProductTypes(vProducts.ProductTypes);
    /* End Populate all combo boxes. */

    /* START populating product details */
    if (productID != -1) {
        // write code to populate product details for EDIT mode
    }
    /* END populating product details */
}

function populateCategories(vCategories){
    var sHTML = '';
    sHTML += '<option value="0" selected="selected">Select Category</option>';
    $.each(vJsonResourceData.Subjects, function (iSubjectID, objSubject) {
        sHTML += '<option value="' + objSubject.Code + '" ' + ((vMode == 'edit' && vJsonResourceData.Resource.SubjectCode == objSubject.Code) ? 'selected=selected' : '') + '>' + objSubject.Label + '</option>';
    });
    $('#trSubject').show();
    $('#ddlSubject').html(sHTML);
}

function onChangeCategory() {
    bIsChanged = true;
    var strSubjectCode = $('#ddlSubject option:selected').val();
    if (strSubjectCode == 'M') {
        $('#trGenreCode').hide();
        applyRowColors();
    }
    else if (strSubjectCode == 'E' && $('#ddlClassification option:selected').val() == 'OT') loadGenre();
}

function populateBrands(vBrands) {
    var sHTML = '';
    sHTML += '<option value="0" selected="selected">Select Category</option>';
    $.each(vJsonResourceData.Subjects, function (iSubjectID, objSubject) {
        sHTML += '<option value="' + objSubject.Code + '" ' + ((vMode == 'edit' && vJsonResourceData.Resource.SubjectCode == objSubject.Code) ? 'selected=selected' : '') + '>' + objSubject.Label + '</option>';
    });
    $('#trSubject').show();
    $('#ddlSubject').html(sHTML);
}

function populateProductTypes(vProductTypes) {
    var sHTML = '';
    sHTML += '<option value="0" selected="selected">Select Category</option>';
    $.each(vJsonResourceData.Subjects, function (iSubjectID, objSubject) {
        sHTML += '<option value="' + objSubject.Code + '" ' + ((vMode == 'edit' && vJsonResourceData.Resource.SubjectCode == objSubject.Code) ? 'selected=selected' : '') + '>' + objSubject.Label + '</option>';
    });
    $('#trSubject').show();
    $('#ddlSubject').html(sHTML);
}

function saveProduct(productID) {
    var vProduct = {ProductID:productID, CategoryID:1, ProductTypeID:1, BrandID:1, ProductAvailableStatusID:1, Name:'Name', BatchNo:'batchno', OnHandQuantity:1, PurchasePrice:0, SellingPrice:1, ImagePath:'ImagePath', CreatedBy:1, ModificationStatus:true, ModifiedBy:1 };
    var vResponse = postData(jsonAppData.ContextPath + 'Catalog/SaveProduct', vProduct, false, false, false);
}