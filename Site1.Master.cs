using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpdatedFinalProject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string loginMsg;
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            // מחרוזת הפתיחה
            loginMsg = "<h3>שלום ";
            loginMsg += Session["firstName"].ToString();
            loginMsg += "<h3>";
            // אם המשתמש אינו מחובר, כלומר אורח
            if (Session["userName"].ToString() == "אורח")
            {
                loginMsg += "[<a href = 'login.aspx'>התחבר</a>]<br />";
                loginMsg += "[<a href = 'loginAdmin.aspx'>התחברות מנהל</a>]<br />";
                loginMsg += "[<a href = 'registration.aspx'>יצירת חשבון</a>]<br />";
            }
            // אם המשתמש מחובר
            // אם המשתמש מנהל
            else if (Session["admin"].ToString() == "yes")
            {
                loginMsg += "[<a href = 'managerPage.aspx'>דף ניהול</a>]<br />";
                loginMsg += "[<a href = 'logout.aspx'>התנתק</a>]<br />";
            }
            // אם המשתמש מחובר אך אינו מנהל, כלומר משתמש מחובר רגיל 
            else
            {
                loginMsg += "[<a href = 'update.aspx'>עדכון פרטים</a>]<br />";
                loginMsg += "[<a href = 'logout.aspx'>התנתק</a>]<br />";
            }
        }
    }
}