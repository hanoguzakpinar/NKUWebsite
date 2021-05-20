using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class Guncelle : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        OleDbCommand cmd;
        OleDbDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) == "")
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            if (!Page.IsPostBack)
            {
                Doldur();
            }
            
        }

        private void Doldur()
        {
            string kayit = "Select * from Belge where belge_id=" + Convert.ToInt32(Session["guncel"]) + "";
            cmd = new OleDbCommand(kayit, objConn);
            objConn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tB_Baslik.Text = dr["baslik"].ToString();
                ck_Icerik.Text = dr["icerik"].ToString();
            }

            objConn.Close();
        }

        protected void btn_Kaydet_Click(object sender, EventArgs e)
        {

            objConn.Open();
            string kayit2 = "update Belge set baslik=@a , icerik=@b where belge_id=@id";
            cmd = new OleDbCommand(kayit2, objConn);
            
            cmd.Parameters.AddWithValue("@a", tB_Baslik.Text);
            cmd.Parameters.AddWithValue("@b", ck_Icerik.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Session["guncel"]));
            cmd.ExecuteNonQuery();
            objConn.Close();
            Response.Write("<script language='JavaScript'>alert('Güncellendi.');</script>");


        }
    }
}