<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewContacts.aspx.cs" Inherits="PTT.Contacts.NewContacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="UserName" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="FirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="LastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="RoleID" runat="server" Text="Role"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSourceRole" DataTextField="RoleName" DataValueField="RoleName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceRole" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [RoleName] FROM [Role]"></asp:SqlDataSource>
        <p>
            <asp:Label ID="AdminLevel" runat="server" Text="Admin Level"></asp:Label>
            <asp:DropDownList ID="drpAdminLvl" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label ID="TeamID" runat="server" Text="Team"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSourceTeam" DataTextField="TeamName" DataValueField="TeamName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceTeam" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [TeamName] FROM [Team]"></asp:SqlDataSource>
        <p>
            <asp:Label ID="Email" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Phone" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSave" runat="server" Text="SAVE" OnClick="BtnSave_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="CANCEL" OnClick="=BtnCancel_Click" />
        </p>
    </form>
</body>
</html>
