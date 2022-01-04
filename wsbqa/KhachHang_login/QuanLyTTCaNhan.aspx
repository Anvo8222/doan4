<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang_login/KhachHang_login.Master" AutoEventWireup="true" CodeBehind="QuanLyTTCaNhan.aspx.cs" Inherits="wsbqa.KhachHang_login.QuanLyTTCaNhan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .profile__content-btn{
            display:block;
            width:100%;
            text-align:center;
            text-decoration:none;
        }
        .main{
            width:1000px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Repeater ID="Repeater1" runat="server">
  <ItemTemplate>
    <div class="main">
        <div class="container">
        <div class="row">
            <div class="col">
              <div class="card mb-3">
                <div class="card-body">
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">ID User</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                      <%# Eval("IDUSER") %>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Email</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                      <%# Eval("EMAIL") %>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Họ tên</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                      <%# Eval("HOTEN") %>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Năm Sinh</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                      <%# Eval("NAMSINH") %>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Giới tính</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                      <%# Eval("GIOITINH") %>
                    </div>
                  </div>
                    <hr>
                    <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Số điện thoại</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                     <%# Eval("SODIENTHOAI") %>
                    </div>
                  </div>
                    <hr>
                    <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Địa chỉ</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                     <%# Eval("DIACHI") %>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-12">
                      <a class="btn btn-info " href="./ChinhSuaTTCN.aspx">Edit</a>
                    </div>
                  </div>
                </div>
              </div>
        </div>
        
    
      </div>
    </div>
    
            </ItemTemplate>
    </asp:Repeater>

</asp:Content>
