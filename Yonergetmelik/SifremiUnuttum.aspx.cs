using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Configuration;

namespace Yonergetmelik
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        OleDbDataReader dr;
        OleDbCommand cmd;
        string soru;
        string sifre;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Panel_Soru.Visible = false;
                form2.Visible = false;
            }

        }

        protected void btn_Giris_Click(object sender, EventArgs e)
        {

            Panel_Email.Visible = false;
            Panel_Soru.Visible = true;
            frmSignIn.Visible = false;
            form2.Visible = true;




            objConn.Open();
            string kayit = "Select * from Kullanici where email=@a";
            cmd = new OleDbCommand(kayit, objConn);
            cmd.Parameters.AddWithValue("@a", tB_Email.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                soru = dr["gsorusu"].ToString();
            }
            objConn.Close();


            Label_Soru.Text = soru;

            if (Label_Soru.Text == "")
            {
                Panel_Email.Visible = true;
                Response.Write("<script language='JavaScript'>alert('Kullanıcı Bulunamadı.');</script>");
                //Response.Redirect("SifremiUnuttum.aspx");
                //Response.End();

                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS", "setTimeout(function() { window.location.replace('SifremiUnuttum.aspx') }, 10);", true);
            }

        }

        protected void btn_Cevap_Click(object sender, EventArgs e)
        {
            objConn.Open();
            string kayit = "Select * from Kullanici where email=@a and gcevap=@cevap";
            cmd = new OleDbCommand(kayit, objConn);
            cmd.Parameters.AddWithValue("@a", tB_Email.Text);
            cmd.Parameters.AddWithValue("@cevap", tB_Cevap.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sifre = dr["sifre"].ToString();

                Label_Soru.Text = "Email: " + tB_Email.Text + "<br />" + "Şifreniz: " + sifre;
                Label3.Visible = false;

                tB_Cevap.Visible = false;
                btn_Cevap.Visible = false;

            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('Hatalı giriş.');</script>");
            }
            objConn.Close();
        }
    }
}