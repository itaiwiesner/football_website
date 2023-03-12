using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UpdatedFinalProject
{
    public partial class update : System.Web.UI.Page
    {
        public string msg = "";
        public string sqlUpdate = "";
        public string sqlSelect = "";

        public string userName, firstName, lastName, year, gender, phone, password;
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "userDB.mdf";
            userName = Session["userName"].ToString();
            // בדיקה האם המשתמש מחובר
            if (userName == "אורח")
            {
                msg = "אינך משתמש רשום במערכת";
                Response.Redirect("homepage.aspx");
            }
            // שליפת נתוני המשתמש מטבלת הנתונים
            sqlSelect = "SELECT * FROM userTbl WHERE userName = '" + userName + "'";
            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

            int length = table.Rows.Count;
            // בדיקה האם המשתמש קיים במערכת
            if (length == 0)
            {
                msg = "אינך משתמש רשום במערכת";
            }
            // שליפת הנתונים מהרשומה
            else
            {
                firstName = table.Rows[0]["firstName"].ToString().Trim();
                lastName = table.Rows[0]["lastName"].ToString().Trim();
                year = table.Rows[0]["year"].ToString().Trim();
                gender = table.Rows[0]["gender"].ToString().Trim();
                phone = table.Rows[0]["phone"].ToString().Trim();
                password = table.Rows[0]["password"].ToString().Trim();
            }
            // אחזור הפרטים המעודכנים מהטופס
            if (this.IsPostBack)
            {
                firstName = Request.Form["firstName"];
                lastName = Request.Form["lastName"];
                year = Request.Form["year"];
                gender = Request.Form["gender"];
                phone = Request.Form["phone"];
                password = Request.Form["password"];
                // בניית שאילתת עדכון שתחליף את הפרטים הקודמים בפרטים שעודכנו
                sqlUpdate = "UPDATE userTbl ";
                sqlUpdate += "SET firstName = N'" + firstName + "', ";
                sqlUpdate += "lastName = N'" + lastName + "', ";
                sqlUpdate += "year = '" + year + "', ";
                sqlUpdate += "gender = '" + gender + "', ";
                sqlUpdate += "phone = '" + phone + "', ";
                

                sqlUpdate += "password = '" + password + "' ";
                sqlUpdate += "WHERE userName = '" + userName + "'";
                // הפעלת שאילתת העדכון
                Helper.DoQuery(fileName, sqlUpdate);

                msg = "Success";// ההודעה שתוצג ללקוח לאחר שהפרטים עודכנו בהצלחה
            }
        }
    }
}