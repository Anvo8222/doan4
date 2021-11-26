<%@ Page Title="" Language="C#" MasterPageFile="~/khachhang/Home.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="wsbqa.khachhang.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .view{
            width:100%;
        }
        
    </style>
    <link href="../css/cart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" CssClass="table view" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting1" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="ID SP">
                <ItemTemplate>
                    <asp:Label scope="row" ID="Label12" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ảnh">
                <EditItemTemplate>
                    
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image scope="row" ID="Image1" runat="server" Width="60px" Height="70px" ImageUrl='<%# "../img/"+Eval("HINHANH") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên sp">
                <ItemTemplate>
                    <asp:Label scope="row" ID="Label3" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đơn giá">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Dongia","{0:n0}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <EditItemTemplate>
                    <asp:TextBox scope="row" ID="txtQuantity" runat="server" Height="19px" Text='<%# Bind("Quantity") %>' Width="51px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thành tiền">
                <ItemTemplate>
                    <asp:Label scope="row" ID="Label6" runat="server" Text='<%# Bind("Thanhtien") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" ControlStyle-CssClass="button" HeaderText="Chức năng" ShowDeleteButton="True" ShowEditButton="True">
                <ControlStyle  />
            </asp:CommandField>

        </Columns>
      
    </asp:GridView>
    <div id="tongtien">
        <asp:Label ID="Label2" runat="server" Text="TỔNG TIỀN:"></asp:Label>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    <div id="dathang">
        <asp:LinkButton ID="LinkButton3" runat="server" >Đặt Hàng! </asp:LinkButton>
    </div>

</asp:Content>
