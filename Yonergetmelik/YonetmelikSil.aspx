<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="YonetmelikSil.aspx.cs" Inherits="Yonergetmelik.YonetmelikSil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selo {
            overflow: hidden;
            overflow-x: auto;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--   <section class="page-header page-header-modern bg-color-light-scale-1 page-header-md">
        <div class="container">
            <div class="row">
               
                <div class="col-md-12 align-self-center p-static order-2 text-center">

                    <h1 class="text-dark font-weight-bold text-8">Yönetmelik Sil
                    </h1>

                </div>

                <div class="col-md-12 align-self-center order-1">

                    <ul class="breadcrumb d-block text-center">
                        <li><a href="Profil.aspx">Anasayfa</a></li>
                        <li class="active">Yönetmelikler</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>--%>

    <div class="col-lg-12" style="margin-top: 6%">
        <div class="overflow-hidden mb-1" style="margin-top: 6%">
            <h2 class="font-weight-normal text-7 mb-0" style="margin-top: 10px;"><strong class="font-weight-bold">Y</strong>önetmelik Sil</h2>
        </div>
        <div class="overflow-hidden mb-4 pb-3">
            <p class="mb-0"></p>
        </div>

        <%--<div class="container py-2">--%>

            <div class="row">
                <div class="col">

                    <div class="row">
                        <div class="col pb-3 selo">

                            <table class="table table-hover">
                                <thead>
                                    <tr>

                                        <th>Başlık
                                        </th>
                                        <th>Tarih
                                        </th>
                                        <th>Ekleyen
                                        </th>
                                        <th>Detay
                                        </th>
                                        <th>Sil
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <form runat="server">
                                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                            <ItemTemplate>
                                                <tr>
                                                    <td><%# Eval("baslik") %>
                                                    </td>
                                                    <td><%# Eval("tarih", "{0:d}") %>
                                                    </td>
                                                    <td><%# Eval("adsoyad") %>
                                                    </td>
                                                    <td><a class="btn btn-primary" target="_blank" href="<%# "/Detay.aspx?belge="+Eval("belge_id") %>">DEVAMI </a>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton ID="LinkButton_Sil" CssClass="btn btn-danger" runat="server" CommandName="Sil" CommandArgument='<%#Eval("belge_id") %>'>Sil</asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </form>
                                </tbody>

                            </table>

                        </div>



                    </div>
                </div>
            </div>
        </div>

   <%-- </div>--%>
</asp:Content>
