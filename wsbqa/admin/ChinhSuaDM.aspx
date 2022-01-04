<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ChinhSuaDM.aspx.cs" Inherits="wsbqa.admin.ChinhSuaDM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .button-cancel{
            display:flex;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="449px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="ID danh mục">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("IDDANHMUC") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên danh mục">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TENDANHMUC") %>' Width="99px"></asp:TextBox>
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
                            <div class="button-cancel">
                                <asp:Button ID="Button1" runat="server" CausesValidation="True" class="btn btn-warning" CommandName="Update" Text="Update" />
                            &nbsp;<asp:Button ID="Button2" runat="server" class="btn btn-dark" CausesValidation="False" CommandName="Cancel" Text="Cancel" Width="85px" />
                            </div>
                            
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" class="btn btn-primary" CausesValidation="False" CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:Button ID="Button2" runat="server" class="btn btn-primary" CausesValidation="False" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
</asp:Content>

