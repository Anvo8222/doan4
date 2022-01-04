<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="wsbqa.khachhang.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .button {
            margin-top: 40px;
        }

            .button li {
                display: inline-block;
                padding: 10px 10px;
            }
                .button li .btn {
                    cursor: pointer;
                    color: var(--primary-color);
                    font-size: 20px;
                    font-weight: bold;
                    background-color: #d6d3d3;
                }
        .button {
            text-align: center;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        
        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <asp:LinkButton class="col-xl-3 col-lg-4 col-md-6 col-sm-6 container-link" CommandArgument='<%# Eval("IDSANPHAM") %>' runat="server" OnClick="LinkButton1_Click">
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
    <ul class="button">
        <li>
            <asp:Button CssClass="btn" ID="btnPrev2" runat="server" Text="&lt;&lt;" OnClick="btnPrev2_Click" /></li>
        <li>
            <asp:Button CssClass="btn" ID="btnPrev1" runat="server" Text="&lt;" OnClick="btnPrev1_Click" /></li>
        <li>
            <asp:Button CssClass="btn" ID="btnNext1" runat="server" Text="&gt;" OnClick="btnNext1_Click" /></li>
        <li>
            <asp:Button CssClass="btn" ID="btnNext2" runat="server" Text="&gt;&gt;" OnClick="btnNext2_Click" /></li>
    </ul>
</asp:Content>
