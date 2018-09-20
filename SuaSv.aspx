<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuaSv.aspx.cs" Inherits="SuaSv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMa" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Ten"></asp:Label>
&nbsp;<asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gioi tinh"></asp:Label>
&nbsp;<asp:RadioButton ID="rdbNam" runat="server" Text="Nam" Checked="True" GroupName="rdbGt" />
            <asp:RadioButton ID="rdbNu" runat="server" Text="Nu" GroupName="rdbGt" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlLop" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cap nhat" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Xoa" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
