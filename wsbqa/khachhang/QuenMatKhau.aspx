<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="QuenMatKhau.aspx.cs" Inherits="wsbqa.khachhang.QuenMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/DangKyKhachHang.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="signup" style="background-image: url(../img/baner/photo-1595665593673-bf1ad72905c0.jpg);">
            <div action="" class="form">
                <div class="form-signup">
                    <div class="signup__header">
                        <img class="signup__header-logo" src="./assets/image/logo.png" alt="logo">
                        <h1 class="signup__header-name">Quên Mật Khẩu</h1>
                    </div>
                    <div class="signup__center">
                        <div class="signup__center-input">
                            <asp:TextBox ID="txtEmail" runat="server"  name="email" type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"
                                title="Vui lòng nhập nhập đúng email" required placeholder="Email" class="signup__center-input--email"></asp:TextBox>
                        </div>
                    </div>
                    <div class="signup__footer">
                        <asp:Button ID="btnDangKy" class="signup__footer-link" runat="server" Text="Quên Mật Khẩu" OnClick="btnDangKy_Click" />
                        <div class="signup__footer-footer">
                            <p class="signup__footer-question">
                                Bạn đã có tài khoản?
                            </p>
                            <a href="login.aspx" class="signup__footer-link">Đăng nhập!</a>
                        </div>
                        <div class="signup__footer-box">
                            <p>Nếu bạn có nhu cầu bán sản phẩm, vui lòng đăng ký <a href="singupMem.aspx">Tại đây</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
