<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="wsbqa.khachhang.login" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login" style="background-image: url(../img/baner/photo-1595665593673-bf1ad72905c0.jpg);">
        <div class="form">
            <div class="form-login">
                <div class="login__header">
                    <h1 class="login__header-name">Đăng nhập</h1>
                </div>
                <div class="login__center">
                    <div class="login__center-input">
                        <span class="icon-email"><i class="login__center-icon--email far fa-envelope"></i></span>
                        <asp:TextBox ID="txtEmail"  name="email" type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"
                            title="Vui lòng nhập nhập đúng email" required placeholder="Email" class="login__center-input--email" runat="server"></asp:TextBox>
                    </div>
                    <div class="login__center-input">
                        <span class="icon-password"><i class="login__center-icon--password fas fa-key"></i></span>
                        <asp:TextBox ID="txtPassword1" runat="server" name="password" type="password" pattern=".{6,}" title="Mật khẩu có độ dài từ 8 kí tự" required placeholder="Mật khẩu" class="login__center-input--password"></asp:TextBox>
                    </div>
                    <table>
                        <tr>
                            <td class="auto-style5">
                                <asp:TextBox CssClass="capcha" ID="Capcha" placeholder="Mã capcha" Font-Size="24px" runat="server" Height="33px" Width="189px"></asp:TextBox>
                            </td>
                            <td>
                                <cap:CaptchaControl ID="captcha1" runat="server" CaptchaLength="5" CaptchaHeight="32" CaptchaWidth="150" CaptchaLineNoise="None" CaptchaMinTimeout="3" CaptchaMaxTimeout="240" ForeColor="Blue" BackColor="Blue" CaptchaChars="ABCDEFGHIJKLMNOPQRSTUVWX123456789" Height="32px" Width="150px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <a href="QuenMatKhau.aspx" class="login__header-qmk">Quên mật khẩu?</a>

                </div>
                <div class="login__footer">
                    <asp:Button ID="btnDangNhap" class="login__footer-login" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
                    <div class="login__footer-footer">
                        <p class="login__footer-question">
                            Bạn chưa có tài khoản?
                        </p>
                        <a href="signup.aspx" class="login__footer-link">Đăng ký!</a>
                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
