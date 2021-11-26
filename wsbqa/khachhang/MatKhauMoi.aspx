<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="MatKhauMoi.aspx.cs" Inherits="wsbqa.khachhang.MatKhauMoi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/DangKyKhachHang.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="signup" style="background-image: url(../img/baner/photo-1595665593673-bf1ad72905c0.jpg);">
            <div action="" class="form">
                <div class="form-signup">
                    <div class="signup__header">
                        <img class="signup__header-logo" src="./assets/image/logo.png" alt="logo">
                        <h1 class="signup__header-name">Đổi mật khẩu</h1>
                    </div>
                    <div class="signup__center">
                        <div  class="signup__center-input">
                            <span class="icon-password"><i class="signup__center-icon--password fas fa-key"></i></span>
                            <asp:TextBox ID="txtPassword1" runat="server" name="password" type="password"  pattern=".{6,}" title="Mật khẩu có độ dài tối thiểu 6 kí tự" required placeholder="Mật khẩu" class="signup__center-input--password"></asp:TextBox>
                      
                        </div>
                        <div  class="signup__center-input">
                            <span class="icon-password-2"><i class="signup__center-icon--password fas fa-key"></i></span>
                            <asp:TextBox ID="txtPassword2" runat="server" name="password" type="password" pattern=".{6,}" title="Mật khẩu có độ dài tối thiểu 6 kí tự" required placeholder="Mật khẩu" class="signup__center-input--password"></asp:TextBox>
                        </div>
        
                    </div>
                    <div class="signup__footer">
                        <asp:Button ID="btnTiepTuc" runat="server" Text="Đổi mật khẩu" OnClick="btnTiepTuc_Click" />
                    </div>
                </div>
                
            </div>
        </div>
           
</asp:Content>
