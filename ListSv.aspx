<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListSv.aspx.cs" Inherits="ListSv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ten"></asp:Label>
        &nbsp;<asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tim" />
            <br />
            <br />
            <br />
            <asp:GridView ID="grvSv" runat="server" OnRowDeleting="grvSv_RowDeleting" AutoGenerateColumns="False" OnSelectedIndexChanging="grvSv_SelectedIndexChanging">
                <Columns>
                    <asp:BoundField DataField="ma" HeaderText="Mã" />
                    <asp:BoundField DataField="ten" HeaderText="Tên" />
                    <asp:BoundField DataField="gt" HeaderText="Giới Tính" />
                    <asp:BoundField DataField="tenLop" HeaderText="Lớp" />
                    <asp:CommandField SelectText="Sua" ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
