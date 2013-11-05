<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewRole.aspx.cs" Inherits="PTT.Admin.NewRole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="RoleName" runat="server" Text="Role"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="AddRole" runat="server" Text="AddRole" OnClick="AddRole_Click" />
        </p>
    </form>
</body>
</html>
