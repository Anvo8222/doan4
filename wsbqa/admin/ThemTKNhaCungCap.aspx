<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ThemTKNhaCungCap.aspx.cs" Inherits="wsbqa.admin.ThemTKNhaCungCap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .formThemMoi {
            padding: 10px;
            width: 700px;
        }

        .thongtin {
            overflow: hidden;
            padding-bottom: 10px;
        }

        .tenTruong {
            float: left;
            width: 150px;
        }

        .nhap {
            width: calc(100%-150px);
        }

        .formThemMoi input[type=text],
        .formThemMoi select {
            border: solid 1px #ffd800;
            padding: 5px;
            width: 50%;
        }

        .btnThem {
            border: 0;
            background: #ff0000;
            color: #000000;
            cursor: pointer;
            padding: 5px 10px;
            padding-right: 5px;
        }

        .btnHuy {
            border: 0;
            background: #f6ecec;
            color: #000000;
            cursor: pointer;
            padding: 5px 10px;
            margin-left: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Thêm mới tài khoản</h1>
    <div class="formThemMoi">
        <div class="thongtin">
            <div class="tenTruong">Email</div>
            <div class="nhap">
                <asp:TextBox ID="txtEmail" type="email" aria-describedby="emailHelp" placeholder="Enter email" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtEmail" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="thongtin">
             <div class="tenTruong">Mật khẩu</div>
            <div class="nhap">
                <asp:TextBox ID="txtMatKhau" type="password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtMatKhau" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="thongtin">
            <div class="tenTruong">Họ tên</div>
            <div class="nhap">
                <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtHoTen" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        
        <div class="thongtin">
            <div class="tenTruong">Năm sinh</div>
            <div class="nhap">
                <asp:TextBox ID="txtNamSinh"  type="number" min="1940" max="2015" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtNamSinh" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Năm sinh phải nhập số" ControlToValidate ="txtNamSinh" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" Font-Size="15px"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="thongtin">
            <div class="tenTruong">Giới tính</div>
            <div class="nhap">
                <asp:TextBox ID="txtGioiTinh" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtGioiTinh" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="thongtin">
            <div class="tenTruong">Số điện thoại</div>
            <div class="nhap">
                <asp:TextBox ID="txtSoDienThoai" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="txtSoDienThoai" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Năm sinh phải nhập số" ControlToValidate ="txtSoDienThoai" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" Font-Size="15px"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="thongtin">
            <div class="tenTruong">Địa chỉ</div>
            <div class="nhap">
                <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="txtDiaChi" Display="Dynamic" SetFocusOnError="true">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="thongtin">
        </div>
        
        <div class="thongtin">
            <div class="tenTruong"></div>
            <div class="nhap">
                <asp:Button ID="btnThem" runat="server" Text="Thêm" CssClass="btnThem" OnClick="btnThem_Click" />
            </div>
        </div>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="#">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("IDUSER") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EMAIL">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("EMAIL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Họ tên">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("HOTEN") %>' Height="23px" Width="101px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("HOTEN") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Năm sinh">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("NAMSINH") %>' Width="115px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("NAMSINH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giới tính">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("GIOITINH") %>' Height="19px" Width="70px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("GIOITINH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SDT">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("SODIENTHOAI") %>' Height="28px" Width="147px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("SODIENTHOAI") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Địa chỉ">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("DIACHI") %>' Height="16px" Width="98px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("DIACHI") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Quyền">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("IDPHANQUYEN") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Trạng thái">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("TRANGTHAI") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button"  HeaderText="Sửa" ShowEditButton="True" ShowHeader="True" />
        </Columns>

    </asp:GridView>

</asp:Content>

