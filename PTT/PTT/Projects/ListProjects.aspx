<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProjects.aspx.cs" Inherits="PTT.Projects.ListProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="MainMenu" runat="server" Text="Main Menu" OnClick="MainMenu_Click" />
        <asp:Button ID="NewProject" runat="server" Text="New Project" OnClick="NewProject_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceProjects" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Project_ER_SR_No" HeaderText="Project_ER_SR_No" SortExpression="Project_ER_SR_No" />
                <asp:BoundField DataField="ProjectTitle" HeaderText="ProjectTitle" SortExpression="ProjectTitle" />
                <asp:BoundField DataField="LeadPMName" HeaderText="LeadPMName" SortExpression="LeadPMName" />
                <asp:BoundField DataField="ProjectCategory" HeaderText="ProjectCategory" SortExpression="ProjectCategory" />
                <asp:BoundField DataField="ProjectType" HeaderText="ProjectType" SortExpression="ProjectType" />
                <asp:BoundField DataField="ProjectStatus" HeaderText="ProjectStatus" SortExpression="ProjectStatus" />
                <asp:BoundField DataField="ProjectYear" HeaderText="ProjectYear" SortExpression="ProjectYear" />
                <asp:BoundField DataField="ProjectQuarter" HeaderText="ProjectQuarter" SortExpression="ProjectQuarter" />
                <asp:BoundField DataField="ProjectDescription" HeaderText="ProjectDescription" SortExpression="ProjectDescription" />
                <asp:BoundField DataField="CustomerTypeID" HeaderText="CustomerTypeID" SortExpression="CustomerTypeID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceProjects" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT tblProject.Project_ER_SR_No, tblProject.ProjectTitle, tblProject.LeadPMName, tblProject.ProjectCategory, tblProject.ProjectType, tblProject.ProjectStatus, tblProject.ProjectYear, tblProject.ProjectQuarter, tblProject.ProjectDescription, tblProject.CustomerTypeID FROM tblProject, tblAccess WHERE  tblAccess.PMName = tblProject.LeadPMName"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1ProjectAdmin" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AllowSorting="True" DataKeyNames="Project_ER_SR_No">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Project_ER_SR_No" HeaderText="Project_ER_SR_No" SortExpression="Project_ER_SR_No" />
                <asp:BoundField DataField="ProjectTitle" HeaderText="ProjectTitle" SortExpression="ProjectTitle" />
                <asp:BoundField DataField="LeadPMName" HeaderText="LeadPMName" SortExpression="LeadPMName" />
                <asp:BoundField DataField="ProjectCategory" HeaderText="ProjectCategory" SortExpression="ProjectCategory" />
                <asp:BoundField DataField="ProjectType" HeaderText="ProjectType" SortExpression="ProjectType" />
                <asp:BoundField DataField="ProjectStatus" HeaderText="ProjectStatus" SortExpression="ProjectStatus" />
                <asp:BoundField DataField="ProjectYear" HeaderText="ProjectYear" SortExpression="ProjectYear" />
                <asp:BoundField DataField="ProjectQuarter" HeaderText="ProjectQuarter" SortExpression="ProjectQuarter" />
                <asp:BoundField DataField="BudgetedCost" HeaderText="BudgetedCost" SortExpression="BudgetedCost" />
                <asp:BoundField DataField="ActualCost" HeaderText="ActualCost" SortExpression="ActualCost" />
                <asp:BoundField DataField="Currency" HeaderText="Currency" SortExpression="Currency" />
                <asp:BoundField DataField="ProjectDescription" HeaderText="ProjectDescription" SortExpression="ProjectDescription" />
                <asp:BoundField DataField="CustomerTypeID" HeaderText="CustomerTypeID" SortExpression="CustomerTypeID" />
                <asp:BoundField DataField="ReturnOnInvestment" HeaderText="ReturnOnInvestment" SortExpression="ReturnOnInvestment" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1ProjectAdmin" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [Project_ER_SR_No], [ProjectTitle], [LeadPMName], [ProjectCategory], [ProjectType], [ProjectStatus], [ProjectYear], [ProjectQuarter], [BudgetedCost], [ActualCost], [Currency], [ProjectDescription], [CustomerTypeID], [ReturnOnInvestment] FROM [tblProject]"></asp:SqlDataSource>
    </form>
</body>
</html>
