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