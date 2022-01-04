<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="XemTKNhaCungCap.aspx.cs" Inherits="wsbqa.admin.XemTKNhaCungCap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Email</th>
                <th scope="col">Mật khẩu</th>
                <th scope="col">Họ tên</th>
                <th scope="col">Năm sinh</th>
                <th scope="col">Giới tính</th>
                <th scope="col">Số điện thoại</th>
                <th scope="col">Địa chỉ</th>
                <th scope="col">Trạng thái</th>
                <th scope="col">Khóa</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                     <tr>
                <th scope="row"><%# Eval("IDUSER") %></th>
                 <td><%# Eval("EMAIL") %></td>
                        <td><%# Eval("MATKHAU") %></td>
                        <td><%# Eval("HOTEN") %></td>
                        <td><%# Eval("NAMSINH") %></td>
                        <td><%# Eval("GIOITINH") %></td>
                        <td><%# Eval("SODIENTHOAI") %></td>
                        <td><%# Eval("DIACHI") %></td>
                         <td><%# Eval("TRANGTHAI") %></td>
                <td>
                           <asp:Button ID="btnSua" runat="server"  CommandArgument='<%# Eval("IDUSER") %>' Text="Khóa" OnClick="btnSua_Click"/>
                        </td>
            </tr>
                </ItemTemplate>
            </asp:Repeater>
           
        </tbody>
    </table>
    
     
</asp:Content>

