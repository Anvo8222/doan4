<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="dathang.aspx.cs" Inherits="wsbqa.khachhang.dathang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .id_name{
            display:block;
        }
        .id_name-id{
            display:flex;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <thead>
            <tr>
                <th scope="col">ID SP</th>
                <th scope="col">ID/Tên nhà cung cấp</th>
                <th scope="col">Hình ảnh</th>
                <th scope="col">Tên SP</th>
                <th scope="col">Đơn giá</th>
                <th scope="col">Số lượng</th>
                <th scope="col">Thành tiền</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row">  <%# Eval("ID") %> </th>
                        <td class="id_name">
                            <div class="id_name-id">
                                <p>id: </p>
                                <p><%# Eval("IDnhacungcap") %> </p>
                            </div>
                            <div class="id_name-id">
                                <p>Tên:</p>
                                <p>sád</p>
                            </div>
                        </td>
                        <td>
                            <asp:Image scope="row" ID="Image1" runat="server" Width="60px" Height="70px" ImageUrl='<%# "../img/"+Eval("HINHANH") %>' />
                        </td>
                        <td><%# Eval("Name") %> </td>
                        <td><%# Eval("Dongia") %> </td>
                        <td><%# Eval("Quantity") %> </td>
                        <td><%# Eval("Thanhtien") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <div class="tongtien">
        <asp:Label ID="Label1" runat="server" Text="Tổng tiền cần thanh toán"></asp:Label>
        <asp:TextBox ID="txtTongTien" runat="server" Enabled="true"></asp:TextBox>
    </div>

    <form>
        
        <div class="form-group">
            <label for="inputAddress">Địa chỉ</label>
            <asp:TextBox type="text" placeholder="Nhập địa chỉ" class="form-control" ID="txtDiaChi" runat="server"></asp:TextBox>
           
        </div>
        <div class="form-group">
            <label for="inputAddress2">Họ tên</label>
            <asp:TextBox type="text" placeholder="Nhập họ tên" class="form-control" ID="txtHoTen" runat="server"></asp:TextBox>
            
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputCity">Số điện thoại</label>
                <asp:TextBox ID="txtsdt" type="number" title="Nhập số điện thoại từ 10 đến 11 số" pattern="(\+84|0)\d{9,10}"  placeholder="Số điện thoại" class="form-control" runat="server"></asp:TextBox>
                
            </div>
        </div>
        <asp:PlaceHolder ID="phd_dathang" runat="server" Visible="true">
        </asp:PlaceHolder>
    </form>
    <asp:Button ID="Button1" type="button" class="btn btn-primary" runat="server" Text="Đặt hàng" OnClick="Button1_Click" />

</asp:Content>
