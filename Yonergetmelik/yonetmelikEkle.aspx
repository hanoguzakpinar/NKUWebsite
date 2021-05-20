<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="yonetmelikEkle.aspx.cs" Inherits="Yonergetmelik.yonetmelikEkle" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    						<div class="col-lg-12" style="margin-top:6%">

							<div class="overflow-hidden mb-1">
								<h2 class="font-weight-normal text-7 mb-0" style="margin-top:10px;"><strong class="font-weight-bold">Y</strong>önetmelik Ekle</h2>
							</div>
							<div class="overflow-hidden mb-4 pb-3">
								<p class="mb-0"></p>
							</div>

							<form role="form" class="needs-validation" runat="server">
							    <div class="form-group row">
							        <label class="col-lg-3 font-weight-bold text-dark col-form-label form-control-label text-2 required">Başlık</label>
							        <div class="col-lg-9">					            
                                        <asp:TextBox ID="tB_Baslik" runat="server" class="form-control" type="text" required ></asp:TextBox>
							        </div>
							    </div>
							    <div class="form-group row">
							        <label class="col-lg-3 font-weight-bold text-dark col-form-label form-control-label text-2 required">İçerik</label>
							        <div class="col-lg-9">
                                        <CKEditor:CKEditorControl ID="ck_Icerik" runat="server"></CKEditor:CKEditorControl>

							        </div>
							    </div>

							
							    <div class="form-group row">
									<div class="form-group col-lg-9">
										
										</div>
									<div class="form-group col-lg-3">
										
										<asp:Button ID="btn_Kaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary btn-modern float-right" OnClick="btn_Kaydet_Click"   />
										<br />
										
										
									</div>
									
									</div>

								
								</form>

							    </div>

</asp:Content>
