<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTT.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Task Tracker Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1" ImageUrl="C:\Users\Ignateus\Documents\Visual Studio 2012\Projects\PTT\Title.jpg" runat="server" Height="103px" Width="465px" Visible ="true" />
        <br />
        <br />
        <br />
    </div>
        <asp:Label ID="Message" runat="server"></asp:Label>
        <div style="margin-left: 80px" >
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <p style="margin-left: 80px">
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <div style="margin-left: 240px">
            <asp:Button ID="btnLogin" runat="server" OnClick="BtnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" OnClick="BtnCancel_Click" Text="Cancel" />
        </div>
        <div style="margin-left: 400px">
        </div>
        <p style="margin-left: 80px">
            <asp:Label ID="Label3" runat="server" Text="Contact Administrator for Login Credentials"></asp:Label>
            <asp:TextBox ID="txtAccessControl" runat="server" Visibile="true"></asp:TextBox>
        </p>
    </form>
</body>
</html>
