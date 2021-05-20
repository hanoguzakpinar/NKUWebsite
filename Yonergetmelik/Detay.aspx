<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="Yonergetmelik.Detay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selo {
            overflow: hidden;
            overflow-x: auto;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM [Belge] inner join Kullanici on Kullanici.kullanici_id = Belge.kullanici_id WHERE ([belge_id] = ?)">
            <SelectParameters>
                <asp:QueryStringParameter Name="belge_id" QueryStringField="belge" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>




        <section class="page-header page-header-modern bg-color-light-scale-1 page-header-md">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 align-self-center p-static order-2 text-center">

                        <h1 class="text-dark font-weight-bold text-8">
                            <asp:FormView ID="FormView2" runat="server" DataKeyNames="belge_id" DataSourceID="SqlDataSource1">
                                <ItemTemplate>
                                    <%# Eval("baslik") %>
                                </ItemTemplate>
                            </asp:FormView>
                        </h1>

                    </div>
                    <div class="col-md-12 align-self-center order-1">

                        <ul class="breadcrumb d-block text-center">
                            <li><a href="#">Anasayfa</a></li>
                            <li class="active">Yönerge-Yönetmelikler</li>
                        </ul>
                    </div>



                </div>

                <%--      <div class="row">
                        <div class="col-md-9"></div>
                        <div class="col-md-3 align-self-center p-static order-2 text-center" style="margin-top:8px;">

                            <form role="search" class="d-flex w-50" action="page-search-results.html" method="get" runat="server">
                                <div class="simple-search input-group w-100">
                                    <input class="form-control border-0" id="headerSearch" name="q" type="search" value="" placeholder="Ara...">
                                    <span class="input-group-append bg-light border-0">
                                        <button class="btn" type="submit">
                                            <i class="fa fa-search header-nav-top-icon"></i>
                                        </button>
                                    </span>
                                </div>
                            </form>



                        </div>
                    </div>--%>
            </div>
        </section>

        <div class="container py-1 ">
            <asp:TextBox ID="tb_Ara" required runat="server" placeholder="Arama" MaxLength="15"></asp:TextBox>
            <asp:Button Text=">" runat="server" OnClick="btn_Aram_Click" ID="btn_Aram" />
        </div>

        <hr />

        <div class="container py-4 selo">
            <div class="row">

                <div class="col">

                    <div class="blog-posts single-post">

                        <div class="blog-posts single-post">

                            <span id="spIcerik" runat="server"></span>

                            <asp:FormView ID="FormView1" runat="server" DataKeyNames="belge_id" DataSourceID="SqlDataSource1">
                                <ItemTemplate>
                                    <div class="post-content ml-0">

                                        <p>
                                            <asp:Label ID="lbl_ara" runat="server" Text='<%# Eval("icerik")%>' />
                                        </p>


                                    </div>


                                    <div class="post-content ml-0" style="float: right;">
                                        <div class="post-meta">
                                            <span><i class="far fa-user">&nbsp </i><%#Eval("adsoyad")%> </span>
                                            <br />
                                            <span><i class="far fa-calendar">&nbsp </i><%# Eval("tarih", "{0:d}") %> </span>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:FormView>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</asp:Content>
