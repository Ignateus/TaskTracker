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
        <asp:Button ID="Admin" runat="server" Text="Admin" OnClick="Admin_Click" />
        <asp:Button ID="Contacts" runat="server" Text="Contacts" OnClick="Contacts_Click" />
        <asp:Button ID="btnLogout" runat="server" OnClick="BtnLogout_Click" Text="Logout" />
        <br />
        <br />
        <asp:Button ID="sample" runat="server" Text="sample" Visible="false" />
       

        <br />
        <asp:Label ID="role" runat="server" />
    </form>
</body>
</html>
