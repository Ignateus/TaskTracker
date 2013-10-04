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
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Height="113px" StaticSubMenuIndent="10px" Width="71px" OnMenuItemClick="Menu1_MenuItemClick">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <DynamicItemTemplate>
                <%# Eval("Text") %>
            </DynamicItemTemplate>
            <Items>
                <asp:MenuItem Text="Main Menu" Value="Project"></asp:MenuItem>
                <asp:MenuItem Text="Project" Value="Title"></asp:MenuItem>
                <asp:MenuItem Text="Task" Value="Task"></asp:MenuItem>
                <asp:MenuItem Text="Admin" Value="Admin">
                    <asp:MenuItem Text="Role" Value="Role"></asp:MenuItem>
                    <asp:MenuItem Text="Contact" Value="Contact"></asp:MenuItem>
                    <asp:MenuItem Text="Team" Value="Team"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Contacts" Value="Contacts"></asp:MenuItem>
                <asp:MenuItem Text="Logout" Value="Logout"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
            <StaticItemTemplate>
                <%# Eval("Text") %>
            </StaticItemTemplate>
        </asp:Menu>
        <asp:Button ID="Button1" runat="server" Text="Main Menu" />
        <asp:Button ID="Button2" runat="server" Text="Project" />
        <asp:Button ID="Button3" runat="server" Text="Task" />
        <asp:Button ID="Button4" runat="server" Text="Admin" />
        <asp:Button ID="Button5" runat="server" Text="Contacts" />
        <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
    </form>
</body>
</html>
