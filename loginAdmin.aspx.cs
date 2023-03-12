using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace UpdatedFinalProject
{
    public partial class loginAdmin : System.Web.UI.Page
    {
        public string msg;
        public string sqlAdmin;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                string name = Request.Form["mName"].ToString();
                string password = Request.Form["mPassword"].ToString();

                string fileName = "userDB.mdf";

                sqlAdmin = "SELECT * FROM [managerTbl] WHERE (mName = '" + name + "'AND mPassword = '" + password + "')";

                DataTable table = Helper.ExecuteDataTable(fileName, sqlAdmin);
                int length = table.Rows.Count;

                if (length == 0)
                {
                    msg += "<div style='text-align: center;'>";
                    msg += "<h3> אינך מנהל אינך רשאי לצפות בדף זה </h3>";
                    msg += "<a href='homepage.aspx'>[המשך]</a>";
                    msg += "</div>";
                }
                else
                {
                    Session["firstName"] = "מנהל";
                    Session["userName"] = "admin";
                    Session["admin"] = "yes";
                    Response.Redirect("homepage.aspx");
                }
            }
        }
    }
}