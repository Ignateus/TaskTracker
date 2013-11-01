<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTT.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Task Tracker Login</title>
     <style>
         h1
          {
            
             width: 406px;
             margin-left: 960px;
         }
         background
            {
            background-color:#6495ed;
            }
            body {background-image:url('http://3.bp.blogspot.com/-FopBRFLP77Y/UAgKRxQWigI/AAAAAAAABUQ/1LCtfXEnbxg/s1600/OLY82943.JPG');}
       </style>
</head>
    
<body>
    <div style="margin-left:320px">
         <h1>&nbsp;&nbsp; </h1>
         <h1>&nbsp;&nbsp; Personal Task Tracker</h1>
    </div>
   
    <h1 style="height: 32px; margin-left: 617px"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</em></h1>
    <h1 style="height: 32px; margin-left: 617px"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em></h1>
    
    <form id="form1" runat="server" style="position:absolute; top: 149px; left: 991px; width: 305px; height: 175px; background-image:url('https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcROnqRKt9eqiElORxZQy7S3BEE5_k8nmi4WVXq9gzWW-rsoQbpF1Q')">

    <div style="margin-left: 320px">
        <br />
        <br />
        <div style="margin-left: 80px" >
            <asp:Label ID="Label1" runat="server" Text="User Name" style="position:absolute; top: 35px; left: 30px;"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" style="position:absolute; top: 33px; left: 117px; width: 164px;" TabIndex="1"></asp:TextBox>
        </div>
        <br />
    </div>
        <div style="margin-left: 400px">
        </div>
        <p style="margin-left: 400px">
            <asp:Label ID="Label2" runat="server" Text="Password" style="position:absolute; top: 90px; left: 32px; height: 17px; width: 60px;"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="position:absolute; top: 86px; left: 116px; width: 163px; height: 21px;" TabIndex="2"
            TextMode="Password"></asp:TextBox>
        </p>
        <div style="margin-left: 480px">
            <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" style="z-index: 1; left: 129px; top: 123px; position: absolute; width: 60px; height: 23px; right: 116px;"
            TabIndex="3" Text="Login" />
        </div>
        <div style="margin-left: 400px">
        </div>
        <p>
            <asp:TextBox ID="txtAccessControl" runat="server" Visible="true" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
            <asp:Button ID="BtnCancel" runat="server" OnClick="BtnCancel_Click" style="z-index: 1; left: 207px; top: 124px; position: absolute; width: 60px; height: 23px"
            TabIndex="3" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
           
        <p>
            &nbsp;</p>
        <p>
            ***New Users : Contact Admin***</p>
    </form>
</body>
</html>
