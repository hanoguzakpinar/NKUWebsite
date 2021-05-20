<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="Yonergetmelik.Profil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    						<div class="col-lg-5" style="margin-top:6%">

							<div class="overflow-hidden mb-1">
								<h2 class="font-weight-normal text-7 mb-0" style="margin-top:10px;"><strong class="font-weight-bold">P</strong>rofilim</h2>
							</div>
							<div class="overflow-hidden mb-4 pb-3">
								<p class="mb-0"></p>
							</div>

							<form role="form" class="needs-validation" runat="server">
							    <div class="form-group row">
							        <label class="col-lg-3 font-weight-bold text-dark col-form-label form-control-label text-2 required">Ad Soyad</label>
							        <div class="col-lg-9">					            
                                        <asp:TextBox ID="tB_Ad" runat="server" class="form-control" type="text" required ReadOnly="True"></asp:TextBox>
							        </div>
							    </div>
							    <div class="form-group row">
							        <label class="col-lg-3 font-weight-bold text-dark col-form-label form-control-label text-2 required">Email</label>
							        <div class="col-lg-9">
										<asp:TextBox ID="tB_Email" runat="server" class="form-control" type="email" required ReadOnly="True"></asp:TextBox>
							        </div>
							    </div>

							    <div class="form-group row">
							        <label class="col-lg-3 font-weight-bold text-dark col-form-label form-control-label text-2 required">Şifre</label>
							        <div class="col-lg-9">
										<asp:TextBox ID="tB_Sifre" runat="server" class="form-control" type="password" required></asp:TextBox>
							        </div>
							    </div>
							    <div class="form-group row">
							        <label class="col-lg-3 font-weight-bold text-dark col-form-label form-control-label text-2 required">Şifre Tekrar </label>
							        <div class="col-lg-9">
							            <asp:TextBox ID="tB_SifreTekrar" runat="server" class="form-control" type="password" required></asp:TextBox>
							        </div>
							    </div>
							    <div class="form-group row">
									<div class="form-group col-lg-9">
										
										</div>
									<div class="form-group col-lg-3">
										
										<asp:Button ID="btn_Kaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary btn-modern float-right" OnClick="btn_Kaydet_Click"  />
										<br />
										
										
									</div>
									
									</div>

								
								</form>

							    </div>

						

</asp:Content>
