<%@ Page Title="" Language="C#" MasterPageFile="~/nhacungcap/nhacungcap.Master" AutoEventWireup="true" CodeBehind="ThemSanPham.aspx.cs" Inherits="wsbqa.nhacungcap.ThemSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ThemMoi.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="head">
    Đăng bán sản phẩm
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chọn danh mục</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMuc" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Tên sản phẩm</div>
        <div class="oNhap">            
            <asp:TextBox ID="txtTemSanPham" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Chưa nhập tên sản phẩm" ControlToValidate="txtTemSanPham" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Số lượng</div>
        <div class="oNhap">
            <asp:TextBox ID="txtSoLuong" type="number" required runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator  ID="RegularExpressionValidator1" runat="server" ErrorMessage="Số lượng phải nhập kiểu số" ControlToValidate="txtSoLuong" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Giá bán</div>
        <div class="oNhap">
            <asp:TextBox ID="txtGia" type="number" title="Khong duoc de tron" min="1" max="100000000" required runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Giá bán phải nhập kiểu số" ControlToValidate="txtGia" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Ảnh sản phẩm</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:TextBox ID="txtHinh" runat="server" Width="70"></asp:TextBox>
              <asp:FileUpload  ID="fuphinh" runat="server" Width="70"  />
              <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click"/>
        </div>
        <asp:Label ID="lbltb" runat="server" Text=""></asp:Label>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click"  />
            
        </div>
    </div>
</asp:Content>
