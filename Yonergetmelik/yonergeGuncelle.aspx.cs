using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yonergetmelik
{
    public partial class yonergeGuncelle : System.Web.UI.Page
    {
        
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/Yonergetmelik.accdb"));
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) == "")
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            YaziGetir();
        }

        private void YaziGetir()
        {
            OleDbCommand objCmd = new OleDbCommand("Select * from Belge inner join Kullanici on Kullanici.kullanici_id = Belge.kullanici_id where Belge.kategori_id=2 and Belge.kullanici_id=" + Convert.ToInt32(Session["admin"]) + "");
            objCmd.Connection = objConn;
            OleDbDataAdapter objDataAdapter = new OleDbDataAdapter(objCmd);
            DataTable objDt = new DataTable();
            objConn.Open();
            objDataAdapter.Fill(objDt);
            objConn.Close();
            Repeater1.DataSource = objDt;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle")
            {
                Session["guncel"] = Convert.ToInt32(e.CommandArgument.ToString());
                Response.Redirect("Guncelle.aspx");
                Response.End();
            }
        }
    }
}
