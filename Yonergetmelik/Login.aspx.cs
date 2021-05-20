using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class Login : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        OleDbDataReader dr;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) != "")
            {
                Response.Redirect("Profil.aspx");
                Response.End();
            }
        }

        private void IDBUL()
        {
            objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
            cmd = new OleDbCommand();
            objConn.Open();
            cmd.Connection = objConn;
            cmd.CommandText = "SELECT kullanici_id FROM Kullanici where email=@a";
            cmd.Parameters.AddWithValue("@a", tB_Email.Text);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Session["admin"] = dr["kullanici_id"];

            }
            objConn.Close();
        }

        protected void btn_Giris_Click(object sender, EventArgs e)
        {
            OleDbCommand db_komut;
            objConn.Open();
            string sorgu = "SELECT COUNT(*) FROM Kullanici WHERE email=@a and sifre=@sifre";
            db_komut = new OleDbCommand(sorgu, objConn);
            db_komut.Parameters.Add("@a", OleDbType.VarChar).Value = tB_Email.Text;
            db_komut.Parameters.Add("@sifre", OleDbType.VarChar).Value = tB_Sifre.Text;
            int kayitsayisi = (int)db_komut.ExecuteScalar();
            objConn.Close();
            objConn = null;
            if (kayitsayisi <= 0)
            {
                Response.Write("<script language='JavaScript'>alert('Kullanıcı adı veya Şifre Yanlış');</script>");
            }
            else
            {
                IDBUL();
                Response.Write("<script language='JavaScript'>alert('Giriş yapıldı.');</script>");
                Response.Redirect("Profil.aspx");
                Response.End();
            }
        }
    }
}