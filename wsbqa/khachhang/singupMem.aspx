<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="singupMem.aspx.cs" Inherits="wsbqa.khachhang.singupMem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/DangKyNguoiBanHang.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="signupMem" style="background-image: url(../img/baner/photo-1595665593673-bf1ad72905c0.jpg);">
            <div action="" method="POST" class="form" id="form-1">
                <div class="form-signupMem">
                    <div class="signupMem__header">
                        <h1 class="signupMem__header-name">Đăng Ký Người Bán Hàng</h1>
                    </div>
                    <div class="signupMem__center">
                        <div class="signupMem__center-icon">
                            <span class="icon-user"><i class="signupMem__center-icon--user fas fa-user"> Tài
                                    Khoản</i></span>
                        </div>
                        <div class="signupMem__center-input">
                            <div class="signupMem__center-input-boxname">
                                <asp:TextBox ID="txtTen" class="signupMem__center-input--email-one" runat="server" type="text" required placeholder="Tên"></asp:TextBox>
                                <span class="form-message-one"></span>
                            </div>
                            <div class="signupMem__center-input-boxname-one">
                                <asp:TextBox ID="txtHo" runat="server" name="surname" type="text" required placeholder="Họ"
                                    class="signupMem__center-input--email-two"></asp:TextBox>
                            
                                <span class="form-message-one"></span>
                            </div>
                        </div>
                        <div class="signupMem__center-input">
                            <span class="icon-email"><i
                                    class="signupMem__center-icon--email far fa-envelope"></i></span>
                            <asp:TextBox ID="txtEmail" type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"
                                title="Vui lòng nhập nhập đúng email" required placeholder="Email"
                                class="signupMem__center-input--email" runat="server"></asp:TextBox>
                          
                            <span class="form-message-two"></span>
                        </div>
                        <div class="signupMem__center-input">
                            <span class="icon-phone"><i
                                    class="signupMem__center-icon--phone fas fa-phone-square-alt"></i></span>
                            <asp:TextBox ID="txtSDT" runat="server" type="number" pattern="(\+84|0)\d{9,10}"
                                title="Nhập số điện thoại từ 10 đến 11 số" required placeholder="Số điện thoại"
                                class="signupMem__center-input--phone">

                            </asp:TextBox>
                      
                            <span class="form-message-three"></span>
                        </div>

                        <div class="signupMem__center-input">
                            <span class="icon-password"><i
                                    class="signupMem__center-icon--password fas fa-key"></i></span>
                            <asp:TextBox ID="txtPW1" runat="server" type="password" pattern=".{6,}"
                                title="Mật khẩu có độ dài 8 kí tự" required placeholder="Mật khẩu"
                                class="signupMem__center-input--password"></asp:TextBox>
                          
                            <span class="form-message-four"></span>
                        </div>
                        <div class="signupMem__center-input">
                            <span class="icon-password-2"><i
                                    class="signupMem__center-icon--password fas fa-key"></i></span>
                            <asp:TextBox ID="txtPW2" type="password" required
                                placeholder="Nhập lại mật khẩu" class="signupMem__center-input--password" runat="server"></asp:TextBox>
                         
                            <span class="form-message-five"></span>
                        </div>

                    </div>

                    <div class="signupMem__center_right">
                        <div class="signupMem__center-icon">
                            <span class="icon-user"><i class="signupMem__center-icon--user fas fa-building"> Năm Sinh</i></span>
                        </div>

                        <div class="signupMem__center-input">
                            <div class="signupMem__center-input-boxname-one">
                                <asp:TextBox ID="txtNamSinh" runat="server" type="number" max="2005" min="1950" required placeholder="Năm Sinh"
                                    class="signupMem__center-input--email-three"></asp:TextBox>
                      
                                <span class="form-message-one"></span>
                            </div>
                        </div>
                        <div class="signupMem__center-input">
                            <asp:DropDownList ID="DropDownList1" class="search__select-location" runat="server">
                                <asp:ListItem Selected="True" Value="nam">Nam</asp:ListItem>
                                <asp:ListItem Value="nữ">Nữ</asp:ListItem>
                                
                            </asp:DropDownList>
                        </div>
                        <div class="signupMem__center-input">
                            <span class="icon-address"><i
                                    class="signupMem__center-icon--map fas fa-map-marker-alt"></i></span>
                            <asp:TextBox ID="txtDiaChi" type="text" required placeholder="Địa chỉ" class="signupMem__center-input--address" runat="server"></asp:TextBox>
                            <span class="form-message-three"></span>
                        </div>
                    </div>
                </div>
                <div class="signupMem__footer">
                    <asp:Button ID="btnTiepTuc" class="signupMem__footer-login" runat="server" Text="Tiếp Tục" OnClick="btnTiepTuc_Click" />
                    <div class="signupMem__footer-footer">
                        <p class="signupMem__footer-question">
                            Bạn đã có tài khoản?
                        </p>
                        <a href="login.aspx" class="signupMem__footer-link">Đăng nhập!</a>
                    </div>

                </div>
            </div>
        </div>
</asp:Content>
