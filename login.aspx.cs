using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UpdatedFinalProject
{
    public partial class login : System.Web.UI.Page
    {
        public string msg;
        public string sqlLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Form["submit"] != null)// בדיקה אם המשתמש מילא ושלח את הטופס
            {
                string userName = Request.Form["userName"];
                string password = Request.Form["password"];

                string fileName = "userDB.mdf";
                string tableName = "userTbl";

                sqlLogin = "SELECT * FROM " + tableName +
                    " WHERE userName = '" + userName + "'AND password = '" + password + "'";

                DataTable table = Helper.ExecuteDataTable(fileName, sqlLogin);

                int length = table.Rows.Count;
                if (length == 0)// בדיקה אם הפרטים שהכניס המשתמש שגויים או לא
                {
                    msg = "משתמש לא נמצא";
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Session["userName"] = table.Rows[0]["userName"];
                    Session["firstName"] = table.Rows[0]["firstName"];
                    Response.Redirect("homepage.aspx");
                }
            }           
        }
    }
}