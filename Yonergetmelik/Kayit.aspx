<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="Yonergetmelik.Kayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="container">
    <section class="page-header page-header-modern bg-color-light-scale-1 page-header-md">
					<div class="container">
						<div class="row">
							<div class="col-md-12 align-self-center p-static order-2 text-center">

								<h1 class="text-dark font-weight-bold text-8">KAYIT OL
								</h1>

							</div>
							

							<div class="col-md-12 align-self-center order-1">

								<ul class="breadcrumb d-block text-center">
									<li><a href="Login.aspx">Giriş</a></li>
									<li class="active"> KAYIT</li>
								</ul>
							</div>
						</div>
					</div>
				</section>
	<hr />
  					<div class="row justify-content-center">
						<div class="col-md-6 col-lg-5 mb-5 mb-lg-0">
							
							<form id="frmSignIn" method="post" class="needs-validation" runat="server">
								
								<div class="form-row">
									<div class="form-group col">
										<label class="text-color-dark text-3">Ad Soyad<span class="text-color-danger">*</span></label>
                                        <asp:TextBox ID="tB_Ad" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="SingleLine"></asp:TextBox>
									</div>
								</div>
								
								
								<div class="form-row">
									<div class="form-group col">
										<label class="text-color-dark text-3">Email<span class="text-color-danger">*</span></label>
                                        <asp:TextBox ID="tB_Email" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="Email"></asp:TextBox>
									</div>
								</div>

								<div class="form-row">
									<div class="form-group col">
										<label class="text-color-dark text-3">Şifre <span class="text-color-danger">*</span></label>
                                        <asp:TextBox ID="tB_Sifre" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="Password"></asp:TextBox>
									</div>
								</div>
								<div class="form-row">
									<div class="form-group col">
										<label class="text-color-dark text-3">Şifre Tekrar <span class="text-color-danger">*</span></label>
                                        <asp:TextBox ID="tB_SifreTekrar" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="Password"></asp:TextBox>
									</div>
								</div>
								<div class="form-row">
									<div class="form-group col">
										<label class="text-color-dark text-3">Güvenlik Sorusu<span class="text-color-danger">*</span></label>
                                        <asp:TextBox ID="tB_Soru" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="SingleLine"></asp:TextBox>
									</div>
								</div>
								<div class="form-row">
									<div class="form-group col">
										<label class="text-color-dark text-3">Güvenlik Sorusu Cevap<span class="text-color-danger">*</span></label>
                                        <asp:TextBox ID="tB_Cevap" runat="server" CssClass="form-control form-control-lg text-4" required TextMode="SingleLine"></asp:TextBox>
									</div>
								</div>

								<div class="form-row">
									<div class="form-group col">
                                        <asp:Button ID="btn_Kayit" runat="server" Text="KAYIT OL"  CssClass="btn btn-dark btn-modern btn-block text-uppercase rounded-0 font-weight-bold text-3 py-3" OnClick="btn_Kayit_Click"  />								
									</div>
								</div>
						
							</form>
						</div>
						
					</div>

		</div>
</asp:Content>
