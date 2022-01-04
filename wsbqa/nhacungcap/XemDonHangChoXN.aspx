<%@ Page Title="" Language="C#" MasterPageFile="~/nhacungcap/nhacungcap.Master" AutoEventWireup="true" CodeBehind="XemDonHangChoXN.aspx.cs" Inherits="wsbqa.nhacungcap.XemDonHangChoXN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Ngày lập</th>
                <th scope="col">Địa chỉ khách hàng</th>
                <th scope="col">Trạng thái</th>
                <th scope="col">Số điện thoại</th>
                <th scope="col">Họ tên</th>
                <th scope="col">ID user</th>
                <th scope="col">Tổng sl</th>
                <th scope="col">Tổng đơn giá</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%# Eval("IDDONHANG") %></th>
                        <td><%# Eval("NGAYLAP") %></td>
                        <td><%# Eval("DIACHIKH") %></td>
                        <td><%# Eval("TRANGTHAI") %></td>
                        <td><%# Eval("SDT") %></td>
                        <td><%# Eval("HOTEN") %></td>
                        <td><%# Eval("IDUSER") %></td>
                        <td><%# Eval("TONGSL") %></td>
                        <td><%# Eval("TONGDG","{0:0,00}") %></td>                        
                            <td>
                            <asp:Button ID="btnXacNhan"  runat="server" CommandArgument='<%# Eval("IDDONHANG") %>' class="btn btn-success" Text="Xác nhận" OnClick="btnXacNhan_Click"  />
                        </td>
                        <td>
                            <asp:Button ID="btnHuy" runat="server" CommandArgument='<%# Eval("IDDONHANG") %>' class="btn btn-danger"  Text="Hủy" OnClick="btnHuy_Click"  />
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </tbody>
    </table>

</asp:Content>
