var vProducts = [];
/*
*This function display class room Types to UI.
*/
function buildAdminMainPage() {
    var sHtml = '';
    sHtml += '<ul class="admin-main-menu-1 icons-menu-1a">';
    sHtml += '<li onclick="loadProductManagerContent();">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1>Catalog Manager</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1>Order Manager</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1>Inventory Manager</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '</ul>';
    sHtml += '<ul class="admin-main-menu-1 icons-menu-1a">';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1>Marketing Manager</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1>Coming Soon</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1>Coming Soon</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '</ul>';
    $('#divAdminMainContent').html(sHtml);
}

/*
 * This method is used to load ProductManager page content.
 */
function loadProductManagerContent() {
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

    var hBreadCrumb = document.getElementById("hBreadCrumb");
    var str = '';
    str += '<a href="javascript:void(0);" onclick="buildAdminMainPage();">Administration Menu</a> <b>&gt;</b>';
    str += '<a href="javascript:void(0);" onclick="loadProductManagerContent();">Product Manager</a> <b>&gt;</b>Products';
    hBreadCrumb.innerHTML = str;

    sHtml += '<table width="100%"><tr>';
    sHtml += '<td style="width:50%;"></td>';
    sHtml += '<td style="text-align:right; vertical-align:middle;">';
    sHtml += '<button id="btnAddNew" class="hsInputStyle" type="button" style="width:80px;"><span>Add New</span></button>&nbsp;';
    sHtml += '<button id="btnDelectSelected" class="hsInputStyle" type="button" style="width:150px;"><span>Remove Selected</span></button>&nbsp;';
    sHtml += '<button id="btnSelectAll" class="hsInputStyle" type="button" style="width:80px;"><span>Select All</span></button>&nbsp;';
    sHtml += '</td></tr></table>';

    sHtml = '<table class="table-1 tvat alt-rows">';
    sHtml += '<colgroup><col align="left" /><col align="left" /><col align="left" /><col /><col /><col /><col /><col /></colgroup>'
    sHtml += '<tr class="th-1 tvam"><td style="text-align: left;">Product Name</td><td style="text-align: left;">OnHand Quantity</td>';
    sHtml += '<td style="text-align: left;">Created By</td><td>Purchase Price</td><td>Selling Price</td>';
    sHtml += '<td></td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>';
//    sHtml += '<tr id="trSort" class="th-1 th_sort alt">';
//    sHtml += prepareSortRow();
//    sHtml += '<tr/>';
    sHtml += '<tbody id="tblProducts">';
    //str += loadProductList(vProducts);
    sHtml += '</tbody>';
    sHtml += '</table>';
    $('#divAdminMainContent').empty().html(sHtml);
}

function loadProductList(vProducts) {
    if (vProducts.length > 0) {
        // vProducts.Products;
        // vProducts.ProductsCount;
        $('#divProducts').show();
        //$('#divSearchProduct').show();
        $('#divNoData').hide();
        $('#tblProducts').empty().append(prepareProductListBody());
        //bind paging div on page load, so passing 1 as current page  
        //BuildPager(CPCount, currPage, 'divPager');
        //onAutoSuggest('txtSearch', vCoursePlans.AutoSuggest);
    } else {
        if (vProducts.ProductsCount <= 0) $('#divProducts').hide();
        $('#divCoursePlans').hide();
        $('#divPager').hide();
        $('#divNoData').empty().html('<span style="color:Red">No Products available for this Category.</span>');
        $('#divNoData').show();
    }
}

/*
* Function to prepare body of the grid with data as per the page size.
* @param  CoursePlanLst - List of course plans in the JSON format to load the grid.
* s1 - Used to store the string with all bank details with in the body of grid
*/
function prepareProductListBody() {
    var s1 = '';
    $.each(cplst, function (iIndex, item) {
        s1 += '<tr id="trCoursePlan_' + item.CoursePlanID + '" ' + ((iIndex % 2 == 0) ? 'class="alt"' : '') + '>';
        s1 += '<td style="text-align: left;"><a href="javascript:void(0);" onclick="javascript:onAECoursePlan(' + item.CoursePlanID + ', false);">' + item.CoursePlanName + '</a></td>';
        s1 += '<td style="text-align: left;">' + item.SiteName + '</td>';
        s1 += '<td style="text-align: left;">' + item.SubjectName + '</td>';
        s1 += '<td>' + item.CoursePlanTemplateName + '</td>';
        s1 += '<td>' + item.CoursesCount + '</td>';
        s1 += '<td>' + item.CoursePlannersCount + '</td>';
        s1 += '<td><a id="lbtnLock_' + iIndex + '" href="javascript:void(0);" class="icon-link ' + ((item.IsCoursePlanLocked) ? "icon-locked" : "icon-unlocked") + '" title="' + ((item.IsCoursePlanLocked) ? "Unlock Course Plan" : "Lock Course Plan") + '" onclick="javascript:onLockCoursePlan(' + iIndex + ')"></a></td>';
        s1 += '<td><a id="lbtnCoursePlanning_' + iIndex + '" href="javascript:void(0);" class="buttons-6 silver" ' + ((item.IsCoursePlanLocked) ? "" : "style=\"display:none;\"") + ' onclick="javascript:onAECoursePlan(' + item.CoursePlanID + ', true);">Course Planning</a></td>';
        s1 += '<td><a href="javascript:void(0);" class="icon-link icon-delete" onclick="javascript:onDeleteCoursePlan(' + item.CoursePlanID + ', \'' + item.ProgressCode + '\');"></a></td>';
        s1 += '</tr>';
    });
    return s1;
}

