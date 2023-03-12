using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace UpdatedFinalProject
{
    public partial class registration : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlMsg = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)// בדיקה אם המשתמש מילא ושלח את הטופס
            {
                st += "<table dir = 'lrt' border = '1'>";
                st += "<tr><th colspan='2'> הפרטים שהתקבלו </th></tr>";

                string fileName = "userDB.mdf";
                string tableName = "userTbl";
                string userName = Request.Form["userName"];
                string firstName = Request.Form["firstName"];
                string lastName = Request.Form["lastName"];
                string year = Request.Form["year"];
                string gender = Request.Form["gender"];
                string phone = Request.Form["phone"];
                string password = Request.Form["password"];

                string sqlSelect = "SELECT * FROM [" + tableName + "] WHERE userName = '" + userName + "'";

                sqlMsg = "INSERT INTO [" + tableName + "] VALUES" +
                    "('" + userName + "','" + firstName + "','" + lastName + "','" + year + "','" + gender + "','" + phone + "','" + password + "');";
                if (Helper.IsExist(fileName, sqlSelect))// בדיקה אם שם המשתמש שהכניס הלקוח תפוס או לא
                {
                    msg = "the user name has been taken";// הודעה התוצג למשתמש אם שם המשתמש שהכניס כבר תפוס
                    st += "<tr><td>" + msg ;
                    sqlMsg = sqlSelect;
                }
                else
                {
                    Helper.DoQuery(fileName,sqlMsg);
                    msg = "Success";// התוצג למשתמש אם הלקוח מילא את הפרטים בהצלחה

                    st += "<tr><td>username: </td><td>" + userName + "</td></tr>";
                    st += "<tr><td>first name: </td><td>" + firstName + "</td></tr>";
                    st += "<tr><td>last name: </td><td>" + lastName + "</td></tr>";
                    st += "<tr><td>year of birth: </td><td>" + year + "</td></tr>";
                    st += "<tr><td>gender: </td><td>" + gender + "</td></tr>";
                    st += "<tr><td>phone number: </td><td>" + phone + "</td></tr>";
                    st += "<tr><td>password: </td><td>" + password + "</td></tr>";

                    st += "</table>";
                }
                


            }
        }
    }
}