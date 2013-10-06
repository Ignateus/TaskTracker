<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="PTT.Usr_Ctl.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
                
        <asp:Button ID="Button1" runat="server" Text="Main Menu" />
        <asp:Button ID="Button2" runat="server" Text="Project" />
        <asp:Button ID="Button3" runat="server" Text="Task" />
        <asp:Button ID="Button4" runat="server" Text="Admin" />
        <asp:Button ID="Button5" runat="server" Text="Contacts" />
        <asp:Button ID="btnLogout" runat="server" OnClick="BtnLogout_Click" Text="Logout" />
        <br />
        <br />
        <asp:Button ID="sample" runat="server" Text="sample" Visible="false" />
        <asp:TextBox ID="txtAccessControl" runat="server" Visibile="false"></asp:TextBox>

        <br />
        <asp:Label ID="role" runat="server" />
    </form>
</body>
</html>
