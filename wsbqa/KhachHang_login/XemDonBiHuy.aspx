<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang_login/KhachHang_login.Master" AutoEventWireup="true" CodeBehind="XemDonBiHuy.aspx.cs" Inherits="wsbqa.KhachHang_login.XemDonBiHuy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Lịch sử đặt hàng
    </h2>
    <table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Ngày đặt hàng</th>
      <th scope="col">Địa chỉ khách hàng</th>
      <th scope="col">Tên sản phẩm</th>
      <th scope="col">Hình ảnh</th>
      <th scope="col">Đơn giá</th>
      <th scope="col">Số lượng</th>
      <th scope="col">Tổng tiền</th>
      <th scope="col">Trạng thái</th>
      
    </tr>
  </thead>
        <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
  <tbody>
    <tr>
      <th scope="row"><%# Eval("IDDONHANG") %></th>
      <td><%# Eval("NGAYLAP") %></td>
      <td><%# Eval("DIACHIKH") %></td>
        <td><%# Eval("TENSANPHAM") %></td>
        <td>
            <asp:Image ID="Image1" Width="70px" src='<%# "../img/"+Eval("HINHANH1") %>' runat="server" />
        </td>
        <td><%# Eval("DONGIA") %></td>
        <td><%# Eval("SOLUONG") %></td>
        <td><%# Eval("TONG") %></td>
      <td><%# Eval("TRANGTHAI") %></td>
        
    </tr>
    
  </tbody>
        </ItemTemplate>
            </asp:Repeater>
</table>
</asp:Content>
