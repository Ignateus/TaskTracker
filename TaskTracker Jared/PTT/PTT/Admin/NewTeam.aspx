<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTeam.aspx.cs" Inherits="PTT.Admin.NewTeam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Team" runat="server" Text="New Team"></asp:Label>
        <asp:TextBox ID="txtNewTeam" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="SaveTeam" runat="server" Text="Save" OnClick="SaveTeam_Click" />
        </p>
    </form>
</body>
</html>
