<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="yonetmelikGuncelle.aspx.cs" Inherits="Yonergetmelik.yonetmelikGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selo {
            overflow: hidden;
            overflow-x: auto;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-12" style="margin-top: 6%">
        <div class="overflow-hidden mb-1" style="margin-top: 6%">
            <h2 class="font-weight-normal text-7 mb-0" style="margin-top: 10px;"><strong class="font-weight-bold">Y</strong>önetmelik Güncelle</h2>
        </div>
        <div class="overflow-hidden mb-4 pb-3">
            <p class="mb-0"></p>
        </div>



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
                                    <th>Güncelle
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
                                                    <asp:LinkButton ID="LinkButton_Guncelle" CssClass="btn btn-default" runat="server" CommandName="Guncelle" CommandArgument='<%#Eval("belge_id") %>'>Güncelle</asp:LinkButton>
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

</asp:Content>
