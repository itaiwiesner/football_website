<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UpdatedFinalProject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style> table {margin: 0px auto; direction: rtl ; text-align: center;} </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method ="post" runat="server">
        <style type="text/css">
    </style>
    <link rel="stylesheet" type="text/css" href="css2.css" media="screen" />
        <h1>כניסת משתמש</h1>
        <table>
            <tr>
                <td>שם משתמש:</td>
                <td><input type="text" name ="userName" id ="userName" /></td>
            </tr>
            <tr>
                <td>סיסמה:</td>
                <td><input type="password" name ="password" id ="password" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center;">
                    <input type="submit" name="submit" value=" התחבר " />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
