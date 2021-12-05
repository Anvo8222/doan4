<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="wsbqa.khachhang.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .img{
            float:left;

        }
        .thongtin{
            float:left;
        }
        .starempty{
            background-image:url(../icon/starempty.png);
            width:50px;
            height:50px;
        }
        .starfilled{
            background-image:url(../icon/starfilled.png);
            width:50px;
            height:50px;
        }
        .starwaiting{
            background-image:url(../icon/starwaiting.png);
            width:50px;
            height:50px;
        }
       
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="container">
        

                <div class="row">
                    <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                    <div class="col-xl-5">
                        <img class="chitietanh" src='<%# "../img/"+Eval("HINHANH1") %>' alt="Chitiet">
                    </div>
                    <div class="col-xl-7">
                        <h1 class="name"><%# Eval("TENSANPHAM") %></h1>
                        <div class="mota">
                            <span class="mota__ma">Người bán: </span>
                            <span class="mota__mahang"><%# Eval("HOTEN") %></span>
                        </div>
                        <div class="mota">
                            <span class="mota__ma">Mã hàng: </span>
                            <span class="mota__mahang"><%# Eval("IDSANPHAM") %></span>
                        </div>
                        <div class="mota danhmuc">
                            <span class="mota__ma">Danh mục: </span>
                            <span class="mota__mahang"><%# Eval("TENDANHMUC") %></span>
                        </div>
                        <div class="mota">
                            <span class="mota__ma soluong">Số lượng tồn kho: </span>
                            <span class="mota__mahang"><%# Eval("TONKHO") %></span>
                        </div>
                        <div class="mota mota_dongia">
                            <span class="mota__ma dongia"><%# Eval("DONGIA","{0:0,00}") %> </span>
                        </div>
                        </ItemTemplate>
        </asp:Repeater>
                        <div class="mota">

                            <asp:TextBox ID="txtsl" PlaceHolder="Số" value="1" min="1" type="number" runat="server"></asp:TextBox>

                        </div>
                    
                        <div class="button">
                            <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                            <asp:LinkButton ID="btnMuaNgay" class="button__muangay" runat="server" OnClick="btnMuaNgay_Click1">Mua Ngay</asp:LinkButton>
                            <%--                        <asp:Button ID="btnThemVaoGio"  class="button__themvaogio" runat="server" Text="Thêm vào giỏ hàng" OnClick="btnThemVaoGio_Click" />--%>
                            <%-- CommandArgument='<%# Eval("IDSANPHAM") %>'--%>
                            <asp:LinkButton ID="LinkButton1" CommandArgument='<%# Eval("IDSANPHAM")%>' runat="server" class="button__themvaogio" OnClick="LinkButton1_Click">Thêm vào giỏ hàng</asp:LinkButton>

                        </div>
                    </div>
                </div>
                <div class="row row-2">
                    <div class="col-xl-6">
                        <img class="chitietanh" src="./assets/image/backgroundbaner.jpg" alt="Chitiet">
                    </div>
                    <div class="col-xl-6">
                        <img class="chitietanh" src="./assets/image/backgroundbaner.jpg" alt="Chitiet">
                    </div>
                </div>
             </ItemTemplate>
        </asp:Repeater>


    </div>
</asp:Content>
