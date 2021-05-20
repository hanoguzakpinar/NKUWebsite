using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class Profil : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        OleDbDataReader dr;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) == "")
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            Doldur();
        }

        private void Doldur()
        {
            string kayit = "Select * from Kullanici where kullanici_id=" + Convert.ToInt32(Session["admin"]) + "";
            cmd = new OleDbCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tB_Ad.Text = dr["adsoyad"].ToString();
                tB_Email.Text = dr["email"].ToString();
            }

            con.Close();
        }

        protected void btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            if (tB_Sifre.Text != tB_SifreTekrar.Text)
            {
                Response.Write("<script language='JavaScript'>alert('Şifreler aynı değil.');</script>");
            }
            else if(tB_Sifre.Text == tB_SifreTekrar.Text)
            {
                con.Open();
                string kayit2 = "update Kullanici set sifre="+tB_Sifre.Text+" where kullanici_id= " + Convert.ToInt32(Session["admin"]) +"";
                cmd = new OleDbCommand(kayit2, con);
               // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Session["admin"]));
               // cmd.Parameters.AddWithValue("@sifre", tB_Sifre.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                


                Response.Write("<script language='JavaScript'>alert('Şifre değiştirme başarılı.');</script>");

                tB_Sifre.Text = "";
                tB_SifreTekrar.Text = "";
            }
        }
    }
}