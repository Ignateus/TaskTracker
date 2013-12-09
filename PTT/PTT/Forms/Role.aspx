<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Role.aspx.cs" Inherits="PTT.Admin.Role" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RoleID" DataSourceID="SqlDataSourceRole">
            <Columns>
                <asp:BoundField DataField="RoleID" HeaderText="RoleID" ReadOnly="True" SortExpression="RoleID" />
                <asp:BoundField DataField="RoleName" HeaderText="RoleName" SortExpression="RoleName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceRole" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [RoleID], [RoleName] FROM [Role]"></asp:SqlDataSource>
        <asp:Button ID="NewRole" runat="server" Text="New Role" OnClick="NewRole_Click" />
    </form>
</body>
</html>
