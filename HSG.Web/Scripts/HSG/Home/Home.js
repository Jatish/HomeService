function buildHomePageContent(vHomePageData){
    var s= '';
    s += '<table width="100%">';
    s += '<tr>';
    s += '<td colspan="2" class="all-round-corner">';
    s += '<div id="banner-fade">';
    s += '<ul class="bjqs">';
    s += '<li><img src="' + jsonAppData.ContextPath + 'Content/Images/Slider/banner01.jpg" title="Free Shipping on amount above Rs 500/-." alt="No Image" /></li>';
    s += '<li><img src="' + jsonAppData.ContextPath + 'Content/Images/Slider/banner02.jpg" title="Get 10% discount of the previous purchase amount in current." alt="No Image" /></li>';
    s += '<li><img src="' + jsonAppData.ContextPath + 'Content/Images/Slider/banner03.jpg" title="Call to order now (+91-9861583625)." alt="No Image" /></li>';
    s += '</ul> ';
    s += '</div>';
    s += '</td>';
    s += '</tr>';
    s += '<tr>';
    s += '<td colspan="2" style="width:70%;">';
    s += '<div class="list-heading">Featured Products</div>';
    s += '<ul id="ulCarouselCategories" class="jcarousel-skin-tango">';
    s += getAllFeaturedProducts();
    s += '</ul>';
    s += '</td>';
    s += '</tr>';
    s += '<tr>';
    s += '<td colspan="2">';
    s += '<div class="list-heading">All Categories</div>';
    s += '<ul id="ulCareouselRecommendations" class="jcarousel-skin-tango">';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/66/199481236_dc98b5abb3_s.jpg" alt="" /></a></li>'
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/75/199481072_b4a0d09597_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/57/199481087_33ae73a8de_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/77/199481108_4359e6b971_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/58/199481143_3c148d9dd3_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/72/199481203_ad4cdcf109_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/58/199481218_264ce20da0_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/69/199481255_fdfe885f87_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/60/199480111_87d4cb3e38_s.jpg" alt="" /></a></li>';
    s += '<li><a href="javascript:void(0);"><img src="http://static.flickr.com/70/229228324_08223b70fa_s.jpg" alt="" /></a></li>';
    s += '</ul>';
    s += '</td>';
    s += '</tr></table>';

    return s;
}

function getHomePageData() {
}

function getAllFeaturedProducts() {
  var vProducts = getData(jsonHSGServices.Catalog + "/GetProducts", { iCategoryID: -1, iBrandID: -1, iProductTypeID: -1, strSearchText: '', iPageNo: 1, iPageCount: 10 }, false, false, false);
  var  s = '';
  $.each($.parseJSON(vProducts.GetProductsResult).Products, function (iIndex, item) {
      s += '<li>';
      s += '<a href="javascript:void(0);"><img src="' + jsonAppData.ContextPath + item.ImagePath + '" alt="" /></a>';
      s += '<p class="text">Name : ' + item.Name + ' <br/>Price : ' + item.SellingPrice + '<br/><a href="javascript:void(0);">Add To Cart</a></p>';
      s += '</li>';
  });
  return s;
}

function getAllNewProducts() {

}
