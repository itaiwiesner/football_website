using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpdatedFinalProject
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();// מבטלת את המצב הנוכחי של הלקוח (מחובר/מנהל), ומחזירה אותו למצב אורח 
            Response.Redirect("homepage.aspx"); // המשתמש יוחזר אוטומטית בעת הלחיצה אל דף הבית
        }
    }
}