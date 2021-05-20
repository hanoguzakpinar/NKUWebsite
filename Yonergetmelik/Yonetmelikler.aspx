<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Yonetmelikler.aspx.cs" Inherits="Yonergetmelik.Yonetmelikler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selo {
            overflow: hidden;
            overflow-x: auto;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="page-header page-header-modern bg-color-light-scale-1 page-header-md">
        <div class="container">
            <div class="row">
                <div class="col-md-12 align-self-center p-static order-2 text-center">

                    <h1 class="text-dark font-weight-bold text-8">Yönetmelikler
                    </h1>

                </div>


                <div class="col-md-12 align-self-center order-1">

                    <ul class="breadcrumb d-block text-center">
                        <li><a href="Default.aspx">Anasayfa</a></li>
                        <li class="active">Yönetmelikler</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>

    <div class="container py-2">

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
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <Itemtemplate>
                                        <tr>
                                            <td><%# Eval("baslik") %>
                                            </td>
                                            <td><%# Eval("tarih", "{0:d}") %>
                                            </td>
                                            <td><%# Eval("adsoyad") %>
                                            </td>
                                            <td><a class="btn btn-primary" href="<%# "/Detay.aspx?belge="+Eval("belge_id") %>">DEVAMI </a>
                                            </td>
                                        </tr>
                                    </Itemtemplate>
                                </asp:Repeater>
                            </tbody>

                        </table>

                    </div>


                
            </div>
        </div>
    </div>

</asp:Content>
