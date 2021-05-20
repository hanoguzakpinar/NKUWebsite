using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class Cikis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Convert.ToString(Session["admin"]) != "")
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("Login.aspx");
                Response.End();
            }
            else
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
        }
    }
}