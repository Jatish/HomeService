<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/NestedHSGMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="contentHomeHead" ContentPlaceHolderID="cphNestedMasterHead" runat="server">
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/HSG/Home/Home.js?ver=1.0.0") %>"></script>
    <script type="text/javascript">
        $(function () {
            var vHomePageData = '';// getData(jsonHSGService.Home + "/GetHomePageData", {}, false, true);
            var s1 = buildHomePageContent(vHomePageData);
            document.getElementById('divMainContainer').innerHTML = s1;

            $('#banner-fade').bjqs({
                height: 280,
                width: 720,
                responsive: true
            });
        });
    </script>
</asp:Content>

<asp:Content ID="contentHomeBody" ContentPlaceHolderID="cphNestedMasterBody" runat="server">
<div id="divMainContainer">
    
</div>
</asp:Content>
