using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class Kayit : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) != "")
            {
                Response.Redirect("Profil.aspx");
                Response.End();
            }
        }

        protected void btn_Kayit_Click(object sender, EventArgs e)
        {
            if (tB_Sifre.Text != tB_SifreTekrar.Text)
            {
                Response.Write("<script language='JavaScript'>alert('Şifreler aynı değil.');</script>");
            }
            else if (tB_Sifre.Text == tB_SifreTekrar.Text)
            {

                objConn.Open();
                string kayit1 = "Select count(*) from Kullanici where email=@mail";
                cmd = new OleDbCommand(kayit1, objConn);
                cmd.Parameters.AddWithValue("@mail", tB_Email.Text);
                int sayi = (int)cmd.ExecuteScalar();
                if (sayi == 0)
                {
                    string kayit = "insert into Kullanici(adsoyad,email,sifre,gsorusu,gcevap) values (@ad,@mail,@sifre,@g,@h)";
                    cmd = new OleDbCommand(kayit, objConn);
                    cmd.Parameters.AddWithValue("@ad", tB_Ad.Text);
                    cmd.Parameters.AddWithValue("@mail", tB_Email.Text);
                    cmd.Parameters.AddWithValue("@sifre", tB_Sifre.Text);
                    cmd.Parameters.AddWithValue("@g", tB_Soru.Text);
                    cmd.Parameters.AddWithValue("@h", tB_Sifre.Text);
                    cmd.ExecuteNonQuery();
                    objConn.Close();
                    Response.Write("<script language='JavaScript'>alert('Kayıt Başarılı. Menüden kullanıcı girişine tıklayarak giriş yapabilirsiniz.');</script>");
                    tB_Email.Text = "";
                    tB_Ad.Text = "";
                    tB_Soru.Text = "";
                    tB_Cevap.Text = "";
                }
                else
                {
                    Response.Write("<script language='JavaScript'>alert('Email daha önce kullanılmış.');</script>");
                    tB_Email.Text = "";
                    objConn.Close();
                }


            }
        }
    }
}