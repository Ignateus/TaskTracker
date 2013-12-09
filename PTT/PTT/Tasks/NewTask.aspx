<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTask.aspx.cs" Inherits="PTT.Tasks.NewTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Status<asp:DropDownList ID="DrpStatus" runat="server">
        </asp:DropDownList>
    
    </div>
        <p>
            Assigned To<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1Person" DataTextField="FirstName" DataValueField="FirstName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1Person" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [FirstName] FROM [tblUser]"></asp:SqlDataSource>
        </p>
        Type<asp:DropDownList ID="DrpType" runat="server">
        </asp:DropDownList>
        <p>
            Due Date<asp:TextBox ID="TxtDueDate" runat="server"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </p>
        Priority<asp:DropDownList ID="DrpPriority" runat="server">
        </asp:DropDownList>
        <p>
            Notes<asp:TextBox ID="TxtNotes" runat="server"></asp:TextBox>
        </p>
        Project<asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource1Project" DataTextField="ProjectTitle" DataValueField="ProjectTitle">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1Project" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [ProjectTitle] FROM [tblProject]"></asp:SqlDataSource>
        <asp:Button ID="BtnSave" runat="server" Text="SAVE" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
