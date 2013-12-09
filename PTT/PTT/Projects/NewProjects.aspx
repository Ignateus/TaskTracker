<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProjects.aspx.cs" Inherits="PTT.Projects.NewProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%--<asp:Button ID="ListProjects" runat="server" Text="List Projects" OnClick="ListProjects_Click" />--%>
    
    </div>
        Project Number<asp:TextBox ID="txtProjectNo" runat="server"></asp:TextBox>
        <p>
            Project Title<asp:TextBox ID="txtProjectTitle" runat="server"></asp:TextBox>
        </p>
        Lead Manager<asp:DropDownList ID="drpPM" runat="server" DataSourceID="SqlDataSourcePM" DataTextField="FirstName" DataValueField="FirstName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourcePM" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [FirstName] FROM [tblUser]"></asp:SqlDataSource>
        <p>
            Project Category<asp:DropDownList ID="drpCategory" runat="server">
            </asp:DropDownList>
        </p>
        Project Type<asp:DropDownList ID="drpProjectType" runat="server">
        </asp:DropDownList>
        <p>
            Project Status<asp:DropDownList ID="drpProjectStatus" runat="server">
            </asp:DropDownList>
        </p>
        Project Year<asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <p>
            Project Quarter<asp:DropDownList ID="drpQuarter" runat="server">
            </asp:DropDownList>
        </p>
        Project Description<asp:TextBox ID="txtProjectDesc" runat="server"></asp:TextBox>
        <p>
            Customer<asp:TextBox ID="txtCustomer" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
