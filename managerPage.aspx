<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="managerPage.aspx.cs" Inherits="UpdatedFinalProject.managerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        h1{text-align:center; color:red;}
        h2{text-align:center; direction:rtl}
        h3{text-align:center;}
        
        .tableDB { border: 1px solid black; margin: 0px auto; }
        .tblTH { text-align:center; border:1px solid black;}
        .tblTD1{border: 1px solid black; text-align: center;}
        .tblTD2{border: 1px solid black;}
    </style>
    <link rel="stylesheet" type="text/css" href="css.css" media="screen" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>טבלת משתמשים</h1>
    <h2><%= sqlSelect %></h2>

        <table style="border: 1px solid black;margin: 0px auto">
            <%=st %>
        </table>

       <h3><%=msg %></h3>
</asp:Content>
