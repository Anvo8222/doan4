<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="XemDMDaHuy.aspx.cs" Inherits="wsbqa.admin.XemDMDaHuy" %>
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
                        <td><%# Eval("IDUSER") %></td>
                        <td>
                           <asp:Button ID="btnXoa"  runat="server" CommandArgument='<%# Eval("IDDANHMUC") %>' class="btn btn-success" Text="Xóa" OnClick="btnXoa_Click" />
                        </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </tbody>
         
    </table>
    
</asp:Content>
