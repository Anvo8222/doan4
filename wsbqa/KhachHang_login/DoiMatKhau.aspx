<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang_login/KhachHang_login.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="wsbqa.KhachHang_login.DoiMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/DoiMatKhauNCC.css" rel="stylesheet" />
    <style>
        
        .body-form{
            margin-top:150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="body-form">
    <div class="form-login">
        <div class="title-login">
            <h3>Đổi Mật Khẩu</h3>
            <hr />
        </div>
        <div class="box">
            <div class="box-import">
                <div class="box-input">
                    <i class="fas fa-lock"></i>
                    <asp:TextBox ID="txtmk1" runat="server" CssClass="password text" placeholder="Mật khẩu Mới" TextMode="Password" ></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Vui lòng nhập mật khẩu</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtmk1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Phải > 8 ký tự, có thể số hoặc ký tự, ít nhất 1 ký tự chữ</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtmk1" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{9,}$"></asp:RegularExpressionValidator>
            </div>
            <div class="box-import">
                <div class="box-input">
                    <i class="fas fa-lock"></i>
                    <asp:TextBox ID="txtmk2" runat="server" CssClass="password text" placeholder="Nhập lại mật khẩu" TextMode="Password"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Vui lòng nhập lại mật khẩu</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtmk2"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Nhập lại mật khẩu không trùng khớp</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtmk2" ControlToCompare="txtmk1"></asp:CompareValidator>
            </div>
            <div class="btn-login">
                <asp:Button ID="btnDoiMatKhau" CssClass="btn" runat="server" Text="Đổi mật khẩu" OnClick="btnDoiMatKhau_Click"/>
            </div>
    </div>
    </div>
</div>
    </div>
</asp:Content>
