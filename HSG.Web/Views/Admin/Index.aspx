<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/HSGMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Admin
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMasterBody" runat="server">

<h5></h5>
<div id="divAdminMainContent">
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphMasterHead" runat="server">
<script type="text/javascript" src="<%= Url.Content("~/Scripts/HSG/Admin/Admin.js?ver=1.0.0") %>"></script>
    <script type="text/javascript">
        $(function () {
            var s1 = buildAdminMainPage();
        });
    </script>
</asp:Content>
