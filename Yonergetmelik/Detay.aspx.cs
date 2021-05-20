using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class Detay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btn_Aram_Click(object sender, EventArgs e)
        {
            if (tb_Ara.Text.Length<2)
            {
                //Response.Write("<script language='JavaScript'>alert('Minimum uzunluk 2 olmalıdır.');</script>");
                Page.ClientScript.RegisterStartupScript(GetType(), "myScript", "alert('Minimum uzunluk 2 olmalıdır.');", true);
            }
            else
            {
                var lblID = (Label)FormView1.FindControl("lbl_ara");

                lblID.Visible = false;

                string m = lblID.Text;

                spIcerik.InnerHtml = Vurgula(m, tb_Ara.Text);
            }
               
        }

        public string Vurgula(string metin, string anahtarKelime)
        {
            Regex rx = new Regex(anahtarKelime, RegexOptions.IgnoreCase);
            return rx.Replace(metin, "<b style='color: #FF0000;font-weight:bold;'>$0</b>");
        }

    }
}