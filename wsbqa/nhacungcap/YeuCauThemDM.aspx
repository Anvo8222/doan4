<%@ Page Title="" Language="C#" MasterPageFile="nhacungcap.Master" AutoEventWireup="true" CodeBehind="YeuCauThemDM.aspx.cs" Inherits="wsbqa.KhachHang_login.YeuCauThemDM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .main{
            width:100%;
            min-height:50vh;

        }
        .form{
            margin:auto auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="form">
            <form>
                <div class="form-group">
                    <label for="formGroupExampleInput">Tên danh mục yêu cầu</label>
                    <asp:TextBox ID="txtTenDanhMuc" placeholder="Nhập tên danh mục" type="text" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="Button1" type="submit" class="btn btn-primary" runat="server" Text="Gửi yêu cầu" OnClick="Button1_Click" />

                </div>
            </form>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="449px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="ID danh mục">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("IDDANHMUC") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên danh mục">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TENDANHMUC") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("TENDANHMUC") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tình trạng">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("TINHTRANG") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Sửa / Xóa">
                        <EditItemTemplate>
                            <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                            &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" class="btn btn-primary" CausesValidation="False" CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:Button ID="Button2" runat="server" class="btn btn-primary" CausesValidation="False" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </div>
 

</asp:Content>
