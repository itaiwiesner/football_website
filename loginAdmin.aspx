<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginAdmin.aspx.cs" Inherits="UpdatedFinalProject.loginAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form runat ="server" method ="post">
        <style type="text/css">
    </style>
    <link rel="stylesheet" type="text/css" href="css2.css" media="screen" />
    <h1>כניסת מנהל</h1>
        <table id ="table1" dir ="rtl" align ="center">
        <tr>
            <td>שם מנהל:</td>
            <td><input type ="text" name ="mName" id="mName" /></td>
        </tr>
        <tr>
            <td>סיסמה:</td>
            <td><input type="password" name ="mPassword" id="mPassword" /></td>
        </tr>
        <tr>
            <td colspan ="2" align ="center">
                <input  type ="submit" name ="submit" value =" התחבר " /></td>
        </tr>
    </table>
    </form>
    
</asp:Content>
