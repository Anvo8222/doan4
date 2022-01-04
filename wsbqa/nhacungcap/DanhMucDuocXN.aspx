<%@ Page Title="" Language="C#" MasterPageFile="~/nhacungcap/nhacungcap.Master" AutoEventWireup="true" CodeBehind="DanhMucDuocXN.aspx.cs" Inherits="wsbqa.nhacungcap.DanhMucDuocXN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Danh sách danh mục được xác nhận</h2>
    <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Tên danh mục</th>
                <th scope="col">Tình trạng</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                     
                    <tr>
                        <th scope="row"><%# Eval("IDDANHMUC") %></th>
                        <td><%# Eval("TENDANHMUC") %></td>
                        <td><%# Eval("TINHTRANG") %></td>
               
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
