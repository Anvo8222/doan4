<%@ Page Title="" Language="C#" MasterPageFile="~/nhacungcap/nhacungcap.Master" AutoEventWireup="true" CodeBehind="XemSP.aspx.cs" Inherits="wsbqa.nhacungcap.XemSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Repeater ID="Repeater1" runat="server">
  <ItemTemplate>
    <table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Tên SP</th>
      <th scope="col">Tồn kho</th>
      <th scope="col">Đơn giá</th>
      <th scope="col">Hình ảnh</th>
      <th scope="col">ID danh mục</th>
      <th scope="col">Tên danh mục</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row"><%# Eval("IDSANPHAM") %></th>
      <td><%# Eval("TENSANPHAM") %></td>
      <td><%# Eval("TONKHO") %></td>
      <td><%# Eval("DONGIA","{0:0,00}") %></td>
      <td>
          <asp:Image ID="Image1" src='<%# "../img/"+Eval("HINHANH1") %>' runat="server" Width="50px"/>
      </td>
      <td><%# Eval("IDDANHMUC") %></td>
      <td><%# Eval("TENDANHMUC") %></td>
    </tr>
    
  </tbody>
</table>
       </ItemTemplate>
    </asp:Repeater>

</asp:Content>
