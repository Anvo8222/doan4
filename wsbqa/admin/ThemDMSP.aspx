<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ThemDMSP.aspx.cs" Inherits="wsbqa.admin.ThemDMSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="">
        <div class="row">
            <div class="col">
               <form>
                <div class="form-group">
                    <label for="formGroupExampleInput">Tên danh mục yêu cầu</label>
                    <asp:TextBox ID="txtTenDanhMuc" placeholder="Nhập tên danh mục" type="text" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnThemDanhMuc" type="submit" class="btn btn-primary" runat="server" Text="Thêm danh mục" OnClick="btnThemDanhMuc_Click" />
                </div>
            </form>
            </div>
            <div class="col">
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
            </div>
        </div>
    </div>
</asp:Content>

