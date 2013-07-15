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
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkProduct" value="ProductID">Product 1</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkProduct" value="ProductID">Product 2</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkProduct" value="ProductID">Product 3</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '</ul>';
    sHtml += '<ul class="admin-main-menu-1 icons-menu-1a">';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkProduct" value="ProductID">Product 4</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkProduct" value="ProductID">Product 5</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '<li onclick="">';
    sHtml += '<div>';
    sHtml += '<p>';
    sHtml += '<h1><input type="checkbox" name="chkProduct" value="ProductID">Product 6</h1>';
    sHtml += '</div>';
    sHtml += '</li>';
    sHtml += '</ul>';
    $('#divAdminMainContent').html(sHtml);
}