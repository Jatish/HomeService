﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/NestedHSGMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="contentHomeHead" ContentPlaceHolderID="cphNestedMasterHead" runat="server">
</asp:Content>

<asp:Content ID="contentHomeBody" ContentPlaceHolderID="cphNestedMasterBody" runat="server">
    <table width="100%">
        <tr>
            <td colspan="2" class="all-round-corner">   
                <div id="banner-fade">
				    <ul class="bjqs">
                      <li><img src="../../Content/Images/Slider/banner01.jpg" title="Free Shipping on amount above Rs 500/-." alt="No Image" /></li>
                      <li><img src="../../Content/Images/Slider/banner02.jpg" title="Get 10% discount of the previous purchase amount in current." alt="No Image" /></li>
                      <li><img src="../../Content/Images/Slider/banner03.jpg" title="Call to order now (+91-9861583625)." alt="No Image" /></li>
                    </ul> 
                </div>           
            </td>
        </tr>
        <tr>
            <td colspan="2" style="width:70%;">
                <div class="list-heading">Featured Products</div>
                <ul id="ulCarouselCategories" class="jcarousel-skin-tango">
                    <li>
                        <a href="javascript:void(0);"><img src="../../Content/Images/Carousal/1.jpg" alt="" /></a>
                        <p class="text">Category 1</p>
                    </li>
                    <li>
                        <a href="javascript:void(0);"><img src="http://static.flickr.com/75/199481072_b4a0d09597_s.jpg" alt="" /></a>
                        <p class="text">Category 2</p>
                    </li>
                    <li>
                        <a href="javascript:void(0);"><img src="http://static.flickr.com/57/199481087_33ae73a8de_s.jpg" alt="" /></a>
                        <p class="text">Category 3</p>
                    </li>
                    <li>
                        <a href="javascript:void(0);"><img src="http://static.flickr.com/77/199481108_4359e6b971_s.jpg" alt="" /></a>
                        <p class="text">Category 4</p>
                    </li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/58/199481143_3c148d9dd3_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/72/199481203_ad4cdcf109_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/58/199481218_264ce20da0_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/69/199481255_fdfe885f87_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/60/199480111_87d4cb3e38_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/70/229228324_08223b70fa_s.jpg" alt="" /></a></li>
                  </ul>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div class="list-heading">All Categories</div>
                <ul id="ulCareouselRecommendations" class="jcarousel-skin-tango">
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/66/199481236_dc98b5abb3_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/75/199481072_b4a0d09597_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/57/199481087_33ae73a8de_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/77/199481108_4359e6b971_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/58/199481143_3c148d9dd3_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/72/199481203_ad4cdcf109_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/58/199481218_264ce20da0_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/69/199481255_fdfe885f87_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/60/199480111_87d4cb3e38_s.jpg" alt="" /></a></li>
                    <li><a href="javascript:void(0);"><img src="http://static.flickr.com/70/229228324_08223b70fa_s.jpg" alt="" /></a></li>
                  </ul>
            </td>
        </tr>
    </table>
</asp:Content>