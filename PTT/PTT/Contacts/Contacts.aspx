<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="PTT.Forms.Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceContacts">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="RoleName" HeaderText="Role" SortExpression="Role" />
                <asp:BoundField DataField="AdminLevel" HeaderText="AdminLevel" SortExpression="AdminLevel" />
                <asp:BoundField DataField="TeamName" HeaderText="Team" SortExpression="Team" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceContacts" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [UserID],[UserName],[Password],[FirstName],[LastName],a.RoleName,[AdminLevel],b.TeamName,[Email],[Phone] FROM [tblUser] as c, [Role] as a, [Team] as b WHERE c.RoleID = a.RoleID AND c.TeamID = b.TeamID"></asp:SqlDataSource>
        <asp:Button ID="NewUser" runat="server" Text="Add New User" OnClick="NewUser_Click" />
    </form>
</body>
</html>
