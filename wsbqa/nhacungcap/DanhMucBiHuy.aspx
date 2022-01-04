<%@ Page Title="" Language="C#" MasterPageFile="~/nhacungcap/nhacungcap.Master" AutoEventWireup="true" CodeBehind="DanhMucBiHuy.aspx.cs" Inherits="wsbqa.nhacungcap.DanhMucBiHuy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">TÊN DANH MỤC</th>
                <th scope="col">TÌNH TRẠNG</th>
                <th scope="col">XÓA</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%# Eval("IDDANHMUC") %></th>
                        <td><%# Eval("TENDANHMUC") %></td>
                        <td><%# Eval("TINHTRANG") %></td>
                        <td>
                            <asp:Button ID="btnXoa" CommandArgument='<%# Eval("IDDANHMUC") %>' runat="server" Text="Xóa" OnClick="btnXoa_Click" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </tbody>
    </table>
</asp:Content>
