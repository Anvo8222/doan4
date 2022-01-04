<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang_login/KhachHang_login.Master" AutoEventWireup="true" CodeBehind="ChinhSuaTTCN.aspx.cs" Inherits="wsbqa.KhachHang_login.ChinhSuaTTCN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
			.main{
            margin:auto;
            width:1000px;
			}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="container">
    <div class="col">

					<div class="card">
						<div class="card-body">
							
							<div class="row mb-3">
								<div class="col-sm-3">
									<h6 class="mb-0">Họ Tên</h6>
								</div>
								<div class="col-sm-9 text-secondary">
									<asp:TextBox ID="txtHoTen" type="text" Width="100%" class="form-control"  runat="server"></asp:TextBox>
								</div>
							</div>
							<div class="row mb-3">
								<div class="col-sm-3">
									<h6 class="mb-0">Năm sinh</h6>
								</div>
								<div class="col-sm-9 text-secondary">
									<asp:TextBox ID="txtNamSinh" type="number" max="2005" min="1950" Width="100%" class="form-control" runat="server"></asp:TextBox>
									
								</div>
							</div>
							<div class="row mb-3">
								<div class="col-sm-3">
									<h6 class="mb-0">Số điện thoại</h6>
								</div>
								<div class="col-sm-9 text-secondary">
									<asp:TextBox ID="txtSDT" runat="server" type="number" class="form-control" pattern="(\+84|0)\d{9,10}" title="Nhập số điện thoại từ 10 đến 11 số" required >
                           
                            </asp:TextBox>
									
								</div>
							</div>
							<div class="row mb-3">
								<div class="col-sm-3">
									<h6 class="mb-0">Địa chỉ</h6>
								</div>
								<div class="col-sm-9 text-secondary">
									<asp:TextBox ID="txtDiaChi" type="text"  Width="100%" class="form-control"  runat="server"></asp:TextBox>
									
								</div>
							</div>
							<div class="row">
								<div class="col-sm-3"></div>
								<div class="col-sm-9 text-secondary">
									<asp:Button ID="btnSave" class="btn btn-primary px-4" runat="server" Text="Cập nhật" OnClick="btnSave_Click" />
									
								</div>
							</div>
						</div>
					</div>
        </div>
            </div>
        </div>

</asp:Content>
