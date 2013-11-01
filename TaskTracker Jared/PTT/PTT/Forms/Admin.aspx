<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="PTT.Forms.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="MainMenu" runat="server" Text="MainMenu" OnClick="MainMenu_Click" />
        <asp:Button ID="Role" runat="server" Text="Role" OnClick="Role_Click" />
        <asp:Button ID="Team" runat="server" Text="Team" OnClick="Team_Click" />
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
    </form>
</body>
</html>
