using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UpdatedFinalProject
{
    public partial class managerPage : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            // בדיקת אבטחה. האם המשתמש מנהל או לא
            if (Session["admin"].ToString() == "no")
            {
                msg += "<h3> אינך מנהל אין לך גישה לאיזור זה";
                msg += "<br />";
                msg += "לחץ";
                msg += "<a href='homepage.aspx'> כאן </a>";
                msg += "לחזרה לדף הבית </h3>";
            }
            else
            {
                string fileName = "userDB.mdf";
                string tableName = "userTbl";

                sqlSelect = "SELECT * FROM " + tableName; // שאילתת בחירת נתוני המשתמשים מטבלת הנתונים

                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect); // אחזור הנתונים מטבלת הנתונים
                int length = table.Rows.Count; // מספר השורות בטבלת הנתונים. כל שורה היא משתמש אחד
                if (length == 0) // אם מספר השורות הוא 0, זאת אומרת שאין רשומים
                    msg = "0 נרשמים";
                else // הדפסת כותרות הטבלה
                {
                    st += "<tr>";
                    st += "<th class = 'tblTH' style = 'width: 100px;' >שם משתמש</th>";
                    st += "<th class = 'tblTH' style = 'width: 60px' >שם פרטי</th>";
                    st += "<th class = 'tblTH' style = 'width: 80px' >שם משפחה</th>";
                    st += "<th class = 'tblTH' >שנת לידה</th>";
                    st += "<th class = 'tblTH' style = 'width: 60px' >מגדר</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px' >טלפון</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px' >סיסמה</th>";
                    st += "</tr>";
                }
                for (int i = 0; i < length; i++) // לולאת פור שרצה כמספר השורות בטבלת הנתונים. עבור כל שורה בטבלה תדפיס הלולאה את הנתונים של משתמש אחד
                {
                    st += "<tr>";
                    st += "<td class = 'tblTD2'>" + table.Rows[i]["userName"] + "</td>";
                    st += "<td class = 'tblTD2'>" + table.Rows[i]["firstName"] + "</td>";
                    st += "<td class = 'tblTD2'>" + table.Rows[i]["lastName"] + "</td>";
                    st += "<td class = 'tblTD1'>" + table.Rows[i]["year"] + "</td>";
                    st += "<td class = 'tblTD1'>" + table.Rows[i]["gender"] + "</td>";
                    st += "<td class = 'tblTD1'>" + table.Rows[i]["phone"] + "</td>";
                    st += "<td class = 'tblTD1'>" + table.Rows[i]["password"] + "</td>";
                    st += "</tr>";
                }
                msg = "נרשמו: " + length + " אנשים "; // הודעה ובה כמות האנשים שנרשמו
            }        
        }
    }
}