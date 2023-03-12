<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="UpdatedFinalProject.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
    <style type="text/css">
    </style>
    <link rel="stylesheet" type="text/css" href="css2.css" media="screen" />
     <script>
                        function chkForm()
                        {
                            var firstName = document.getElementById("firstName").value;
                            // בדיקה שהשם הפרטי לא קצר מיד, ארוך מידי או לא קיים
                            if (firstName.length < 2 || firstName.length > 10)
                            {
                                document.getElementById("mFirstName").value = "על שדה שם פרטי להכיל 2-10 תווים";
                                document.getElementById("mFirstName").style.display = "inline";
                                return false;
                            }
                            else
                                document.getElementById("mFirstName").style.display = "none";


                            var lastName = document.getElementById("lastName").value;
                            // בדיקה ששם המשפחה לא קצר מידי, ארוך מידי או לא קיים
                            if (lastName.length < 2 || lastName.length > 15)
                            {
                                document.getElementById("mLastName").value = "על שדה שם משפחה להכיל 2-15 תווים ";
                                document.getElementById("mLastName").style.display = "inline";
                                return false;
                            }
                            else
                                document.getElementById("mLastName").style.display = "none";


                            var year = document.getElementById("year").value;

                            var d = new Date();
                            var today = d.getFullYear();
                            // בדיקה ששנת הלידה מכילה ספרות בלבד
                            if (isNaN(year)) {
                                document.getElementById("mYear").value = "שנת לידה חייבת להכיל ספרות בלבד";
                                document.getElementById("mYear").style.display = "inline";
                                return false;
                            }
                            // בדיקה ששנת הלידה לא קטנה מ1900
                            else if (year < 1900) {
                                document.getElementById("mYear").value = "שנת לידה חייבת להיות מספר 4 ספרתי גדול מ- 1900";
                                document.getElementById("mYear").style.display = "inline";
                                return false;
                            }
                            // בדיקה שגילו של המשתמש לא נמוך מ6 שנים
                            else if (year > today - 6)
                            {
                                document.getElementById("mYear").value = "צעיר.ה מדי כדי להירשם לאתר";
                                document.getElementById("mYear").style.display = "inline";
                                return false;
                            }
                            else
                                document.getElementById("mYear").style.display = "none";

                            // בדיקה שהמגדר שהכניס המשתשמש לא קצר מידי, ארוך או לא קיים
                            var gender = document.getElementById("gender").value;
                            if (gender.length < 4 || gender.length > 6)
                            {
                                document.getElementById("mGender").value = "על שדה מין להכיל 4-6 תווים";
                                document.getElementById("mGender").style.display = "inline";
                                return false;
                            }
                            else
                                document.getElementById("mGender").style.display = "none";



                            var phone = document.getElementById("phone").value;
                            // בדיקה שמספר הטלפון מכיל ספרות בלבד
                            if (isNaN(phone))
                            {
                                document.getElementById("mPhone").value = "מספר טלפון חייב להכיל ספרות בלבד";
                                document.getElementById("mPhone").style.display = "inline";
                                return false;
                            }
                            // בדיקה שמספר הטלפון מכיל 10 ספרות בדיוק
                            else if (phone.length < 10 || phone.length > 10)
                            {
                                document.getElementById("mPhone").value = "על שדה מספר טלפון להכיל 10 ספרות בדיוק";
                                document.getElementById("mPhone").style.display = "inline";
                                return false;
                            }
                            else
                                document.getElementById("mPhone").style.display = "none";



                            var password = document.getElementById("password").value;
                            // בדיקה שהסיסמה מכילה בין 6 ל15 ספרות
                            if (password.length < 6 || password.length > 15)
                            {
                                document.getElementById("mPassword").value = "על שדה סיסמה להכיל 6-15 תווים";
                                document.getElementById("mPassword").style.display = "inline";
                                return false;
                            }
                            else
                                document.getElementById("mPassword").style.display = "none";
                            

                        }
         </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1>עדכון פרטים</h1>
    <form method ="post" runat="server" onsubmit="return chkForm();">
        <table>
            <tr>
                <td>שם משתמש:</td>
                <td>
                    <input type="text" name="userName" disabled = "disabled "value="<%=userName %>" />

                </td>            
            </tr>
             <tr>
                <td>שם פרטי:</td>

                <td><input type="text" name="firstName" id="firstName" value="<%=firstName %>" /></td>
                <td>
                    <input type="text" id="mFirstName"size="30"
                        style="display: none; background-color: silver; font-weight: bold;"
                                disabled="disabled" />
                    </td>
            </tr>
                    
                
            <tr>
                <td>שם משפחה:</td>

                <td><input type="text" name="lastName" id="lastName" value="<%=lastName %>"/></td>
                <td>
                    <input type="text" id="mLastName"size="30"
                        style="display: none; background-color: silver; font-weight: bold;"
                                disabled="disabled" />
                    </td>
            </tr>
                    
                  
            <tr>
                <td>שנת לידה:</td>

                <td><input type="text" name="year" id="year" value="<%=year %>" /></td>
                <td>
                    <input type="text" id="mYear"size="30"
                        style="display: none; background-color: silver; font-weight: bold;"
                                disabled="disabled" />
                    </td>
            </tr>
                    
                
            <tr>
                <td>מין:</td>

                <td><input type="text" name="gender" id="gender" value="<%=gender %>"></td>
                <td>
                    <input type="text" id="mGender"size="30"
                        style="display: none; background-color: silver; font-weight: bold;"
                                disabled="disabled" />
                    </td>
            </tr>
                    
                
            <tr>
                <td>מספר טלפון:</td>

                <td><input type="text" name="phone" id="phone" value="<%=phone %>"/></td>
                <td>
                    <input type="text" id="mPhone"size="30"
                        style="display: none; background-color: silver; font-weight: bold;"
                                disabled="disabled" />
                    </td>
            </tr>
                    
            <tr>
                <td>סיסמה:</td>

                <td>
                    <input type="password" name="password" id="password" value="<%=password %>"/>
                </td>
                <td>
                    <input type="text" id="mPassword"size="30"
                        style="display: none; background-color: silver; font-weight: bold;"
                                disabled="disabled" />
                    </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center;">
                    <input type="submit" name="submit" value=" עדכן " />
                </td>
            </tr>
        </table>
    </form>
    <h3><%= sqlSelect %></h3>

    <h3><%= sqlUpdate %></h3>
    <h3><%= msg %></h3>


</asp:Content>
