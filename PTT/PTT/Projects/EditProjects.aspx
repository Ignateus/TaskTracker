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
        Project Title<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            Lead PM Name
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        Project Category
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Project Type
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        Project Status
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <p>
            Project Year
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        Project Quarter
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <p>
            Budget Cost<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        Actual Cost
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <p>
            Currency
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </p>
        Updates
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <p>
            Project Description
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </p>
        Benefits<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
&nbsp;<p>
            Customer
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        </p>
        <p>
            Return On Investment
            <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnUpdate" runat="server" Text="UPDATE" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
        </p>
    </form>
</body>
</html>
