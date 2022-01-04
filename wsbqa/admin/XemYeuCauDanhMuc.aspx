<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="XemYeuCauDanhMuc.aspx.cs" Inherits="wsbqa.admin.XemYeuCauDanhMuc" %>
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
                <th scope="col">XÁC NHẬN</th>
                <th scope="col">HỦY</th>
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
                        <td>
                            <asp:Button ID="btnXacNhan"  runat="server" CommandArgument='<%# Eval("IDDANHMUC") %>' class="btn btn-success" Text="Xác nhận" OnClick="btnXacNhan_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnHuy" runat="server" CommandArgument='<%# Eval("IDDANHMUC") %>' class="btn btn-danger"  Text="Hủy" OnClick="btnHuy_Click" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </tbody>
    </table>

</asp:Content>
