<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="XemDMDaXN.aspx.cs" Inherits="wsbqa.admin.XemDMDaXN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">TÊN DANH MỤC</th>
                <th scope="col">TÌNH TRẠNG</th>
                <th scope="col">IDUSER</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <th scope="row"><%# Eval("IDDANHMUC") %></th>
                <td><%# Eval("TENDANHMUC") %></td>
                <td><%# Eval("TINHTRANG") %></td>
                <td><%# Eval("IDUSER") %></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

