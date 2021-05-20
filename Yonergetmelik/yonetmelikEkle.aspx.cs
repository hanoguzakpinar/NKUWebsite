using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class yonetmelikEkle : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) == "")
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
        }

        protected void btn_Kaydet_Click(object sender, EventArgs e)
        {
            objConn.Open();
            string kayit = "insert into Belge(baslik,kullanici_id,kategori_id,icerik) values (@a,@b,1,@d)";
            cmd = new OleDbCommand(kayit, objConn);
            cmd.Parameters.AddWithValue("@a", tB_Baslik.Text);
            cmd.Parameters.AddWithValue("@b", Convert.ToInt32(Session["admin"]));
            cmd.Parameters.AddWithValue("@d", ck_Icerik.Text);
            
            cmd.ExecuteNonQuery();
            objConn.Close();
            Response.Write("<script language='JavaScript'>alert('Yönetmelik Eklendi.');</script>");


            tB_Baslik.Text = "";
            ck_Icerik.Text = "";
        }
    }
}