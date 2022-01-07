<%@ Page Title="" Language="C#" MasterPageFile="~/nhacungcap/nhacungcap.Master" AutoEventWireup="true" CodeBehind="TrangThaiDH.aspx.cs" Inherits="wsbqa.nhacungcap.TrangThaiDH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .ddl{
            display:block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="container">
       <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
        <div class="row">
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">ID</label>
                <asp:TextBox type="text" class="form-control" ID="txtID" Text='<%# Bind("IDDONHANG") %>' runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Ngày lập</label>
                <asp:TextBox type="text" class="form-control" ID="txtNgayLap" Text='<%# Bind("NGAYLAP") %>' Enabled="False" runat="server" ></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Địa chỉ</label>
                <asp:TextBox type="text" class="form-control" ID="txtDiaChiKH" Text='<%# Bind("DIACHIKH") %>' Enabled="False" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Trạng thái</label>
                <asp:TextBox type="text" class="form-control" ID="txtTrangThai" runat="server" Enabled="False" Text='<%# Bind("TRANGTHAI") %>' ></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Số điện thoại khách hàng</label>
                <asp:TextBox type="text" class="form-control" ID="txtSDT" Text='<%# Bind("SDT") %>' Enabled="False" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Họ tên KH</label>
                <asp:TextBox type="text" class="form-control" ID="txtHoTen" Text='<%# Bind("HOTEN") %>' Enabled="False" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">IDuser</label>
                <asp:TextBox type="text" class="form-control" ID="txtIDUser" Text='<%# Bind("IDUSER") %>' Enabled="False" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Tổng số lượng</label>
                <asp:TextBox type="text" class="form-control" ID="txtTongSL" Text='<%# Bind("TONGSL") %>' Enabled="False" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <label for="formGroupExampleInput2">Tổng đơn giá</label>
                <asp:TextBox type="text" class="form-control" ID="txtTongDG" Text='<%# Bind("TONGDG","{0:0,00}") %>' Enabled="False" runat="server"><%--<%# Eval("TONGDG","{0:0,00}") %>--%></asp:TextBox>
            </div>
        </div>
             </ItemTemplate>
            </asp:Repeater>
    </div>

    <asp:DropDownList ID="ddl" CssClass="ddl" runat="server">
        <asp:ListItem Text="đã xác nhận" Value="đã xác nhận">

        </asp:ListItem>
        <asp:ListItem Text="Đang giao" Value="đang giao">

        </asp:ListItem>
        <asp:ListItem Text="Đã giao" Value="đã giao">

        </asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Cập nhật" OnClick="Button1_Click" />


     
</asp:Content>
