<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="Yonergetmelik.SifremiUnuttum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <section class="page-header page-header-modern bg-color-light-scale-1 page-header-md">
        <div class="container">
            <div class="row">
                <div class="col-md-12 align-self-center p-static order-2 text-center">

                    <h1 class="text-dark font-weight-bold text-8">ŞİFREMİ UNUTTUM
                    </h1>

                </div>


                <div class="col-md-12 align-self-center order-1">

                    <ul class="breadcrumb d-block text-center">
                        <li><a href="Login.aspx">Giriş</a></li>
                        <li class="active">Şifre</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <hr />
    <div class="row justify-content-center">
        <div class="col-md-6 col-lg-5 mb-5 mb-lg-0">


            <form id="frmSignIn" method="post" class="needs-validation" runat="server">
                <asp:Panel ID="Panel_Email" runat="server">
                    <div class="form-row">
                        <div class="form-group col">

                            <asp:Label ID="Label1" CssClass="text-color-dark text-3" runat="server">Email <span class="text-color-danger">*</span></asp:Label>
                            <asp:TextBox ID="tB_Email" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="Email"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="form-group col">
                            <asp:Button ID="btn_Giris" runat="server" Text="Şifreni Öğren" CssClass="btn btn-dark btn-modern btn-block text-uppercase rounded-0 font-weight-bold text-3 py-3" OnClick="btn_Giris_Click" />
                        </div>
                    </div>
                </asp:Panel>
            </form>

        </div>



    </div>

    <form  method="post" class="needs-validation" runat="server" id="form2">
    <div class="row justify-content-center">
        <div class="col-md-6 col-lg-5 mb-5 mb-lg-0">

            <asp:Panel ID="Panel_Soru" runat="server">
                
                <asp:Label ID="Label_Soru" CssClass="text-color-dark text-5" runat="server"></asp:Label><br /><br />
                <asp:Label ID="Label3" CssClass="text-color-dark text-3" runat="server">Cevap:</asp:Label>
                <asp:TextBox ID="tB_Cevap" runat="server" CssClass="form-control form-control-lg text-4" TextMode="SingleLine" required></asp:TextBox>
                <div style="margin-top:5px;">
                <asp:Button ID="btn_Cevap" runat="server" CssClass="btn btn-dark btn-modern btn-block text-uppercase rounded-0 font-weight-bold text-3 py-3" Text="Cevapla" OnClick="btn_Cevap_Click" />
            </div> 
                            </asp:Panel>

                </div>
    </div>

            </form>
    </div>


</asp:Content>
