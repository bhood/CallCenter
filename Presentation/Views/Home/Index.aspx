﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Home Page
</asp:Content>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
   <script type="text/javascript">

      $(function () {
         $('#BedData').html('Please wait...');
         $.ajax({
            type: 'GET',
            url: '/Home/ShowBedInfo?bedId=1',
            success: ShowBed
         });
      });

      function ShowBed(data) {
         $('#BedData').html(data.Poc + ' - ' + data.Room);
      }

   </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <h2>
      Call Center</h2>
   <div>Bed Data: <span id="BedData"></span></div>
</asp:Content>
