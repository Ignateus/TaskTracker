<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Team.aspx.cs" Inherits="PTT.Admin.Team" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TeamID" DataSourceID="SqlDataSourceTeam">
            <Columns>
                <asp:BoundField DataField="TeamID" HeaderText="TeamID" ReadOnly="True" SortExpression="TeamID" />
                <asp:BoundField DataField="TeamName" HeaderText="TeamName" SortExpression="TeamName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceTeam" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [TeamID], [TeamName] FROM [Team]"></asp:SqlDataSource>
        <asp:Button ID="NewTeam" runat="server" Text="Add New Team" OnClick="NewTeam_Click" />
    </form>
</body>
</html>
