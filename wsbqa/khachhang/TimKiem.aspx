<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="wsbqa.khachhang.TimKiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <asp:LinkButton class="col-xl-3 col-lg-4 col-md-6 col-sm-6 container-link" CommandArgument='<%# Eval("IDSANPHAM") %>' runat="server">
                        <img src='<%# "../img/"+Eval("HINHANH1") %>' class="container__img" width="100%" height="250px" alt="">
                        <div class="middle">
                            <div class="text">Xem chi tiết sản phẩm</div>
                        </div>
                        <div class="container__block">
                            <span class="container-name">  <%# Eval("TENSANPHAM") %> </span>
                            <span class="container-price">Giá: <span>  <%# Eval("DONGIA","{0:0,00}") %> </span> vnd
                            </span>
                        </div>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
