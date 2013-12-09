<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProjects.aspx.cs" Inherits="PTT.Projects.EditProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Project Number<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
        Project Title<asp:TextBox ID="TxtProjectTitle" runat="server"></asp:TextBox>
        <p>
            Lead PM Name
            <asp:TextBox ID="TxtLeadPMName" runat="server"></asp:TextBox>
        </p>
        Project Category
        <asp:TextBox ID="TxtProjectCategory" runat="server"></asp:TextBox>
        <p>
            Project Type
            <asp:TextBox ID="TxtProjectType" runat="server"></asp:TextBox>
        </p>
        Project Status
        <asp:TextBox ID="TxtProjectStatus" runat="server"></asp:TextBox>
        <p>
            Project Year
            <asp:TextBox ID="TxtProjectYear" runat="server"></asp:TextBox>
        </p>
        Project Quarter
        <asp:TextBox ID="TxtProjectQ" runat="server"></asp:TextBox>
        <p>
            Budget Cost<asp:TextBox ID="TxtBudgetCost" runat="server"></asp:TextBox>
        </p>
        Actual Cost
        <asp:TextBox ID="TxtActualCost" runat="server"></asp:TextBox>
        <p>
            Currency
            <asp:TextBox ID="TxtCurrency" runat="server"></asp:TextBox>
        </p>
        Updates
        <asp:TextBox ID="TxtUpdates" runat="server"></asp:TextBox>
        <p>
            Project Description
            <asp:TextBox ID="TxtProjectDescription" runat="server"></asp:TextBox>
        </p>
        Benefits<asp:TextBox ID="TxtBenefits" runat="server"></asp:TextBox>
&nbsp;<p>
            Customer
            <asp:TextBox ID="TxtCustomer" runat="server"></asp:TextBox>
        </p>
        <p>
            Return On Investment
            <asp:TextBox ID="TxtROI" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnUpdate" runat="server" Text="UPDATE" OnClick="BtnUpdate_Click" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="TaskID" DataSourceID="SqlDataSource1projecttask">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="SEQN" HeaderText="SEQN" InsertVisible="False" ReadOnly="True" SortExpression="SEQN" />
                <asp:BoundField DataField="TaskID" HeaderText="TaskID" ReadOnly="True" SortExpression="TaskID" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="AssignedTo" HeaderText="AssignedTo" SortExpression="AssignedTo" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" />
                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" SortExpression="CreationDate" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
                <asp:BoundField DataField="ProjectTitle" HeaderText="ProjectTitle" SortExpression="ProjectTitle" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1projecttask" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="select * from tblTask where AssignedTo = 'TxtLeadPMName.Text' And ProjectTitle = 'TxtProjectTitle.Text'"></asp:SqlDataSource>
    </form>
</body>
</html>
