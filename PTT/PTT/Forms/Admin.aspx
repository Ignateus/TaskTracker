<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="PTT.Forms.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

        <style type="text/css"> 
        body
        {
            background-color:#66CCFF;
        }
        #tabs{ 
            padding:0; 
            margin:0; 
            font-family:Arial, Helvetica, sans-serif; 
            font-size:12px; 
            color:#FFF; 
            font-weight:bold; 
        } 
        #tabs ul{ 
            list-style:none; 
            margin:0; 
            padding:0; 
        } 
        #tabs ul li{ 
            display:inline; 
            margin:0;
            text-transform:capitalize; 
        }        
        #tabs ul li a{ 
            padding:5px 16px;
            color:#000000; 
            background:#EAEAEA;
            float:left; 
            text-decoration:none; 
            border-left:0; 
            margin-left:2px;
            margin-right:2px; 
            text-transform:capitalize; 
            border-top-right-radius: 10px;
            border-top-left-radius: 10px;
        } 

        #tabs ul li a.active{ 
            background:#000000; 
            color:#FFFFFF; 
            border-top-right-radius: 10px;
            border-top-left-radius: 10px;
   
        }

        #tabs ul li a.inactive{
            padding:5px 16px;
            color:#000000; 
            background:#EAEAEA;
            float:left; 
            text-decoration:none; 
            border-left:0; 
            margin-left:2px;
            margin-right:2px; 
            text-transform:capitalize; 
            border-top-right-radius: 10px;
            border-top-left-radius: 10px; 
        }
 
        #tabCtrl{     
            clear:both;
            background:#FFFFFF; 
            font-size:11px; 
            color:#000; 
            padding:10px; 
            font-family:Arial, Helvetica, sans-serif; 
            border:1px solid #000000; 
        } 
    </style>

    <script type="text/javascript">

        function activateTab(pageId, src) {
            var tabCtrl = document.getElementById('tabCtrl');
            var pageToActivate = document.getElementById(pageId);

            //Make every tab have css class inactive
            document.getElementById('mainMenuL').className = "inactive";
            document.getElementById('roleL').className = "inactive";
            document.getElementById('teamL').className = "inactive";
            

            //Make selected tab have css class active
            document.getElementById(src).className = "active";

            for (var i = 0; i < tabCtrl.childNodes.length; i++) {
                var node = tabCtrl.childNodes[i];
                if (node.nodeType == 1) { /* Element */
                    node.style.display = (node == pageToActivate) ? 'block' : 'none';
                }
            }
        }

    </script>

        <div id="tabs"> 
            <ul class="tabList"> 
                
                <li><a id='mainMenuL' href="mainMenu.aspx"  class='active'>Main Menu</a></li>
                <li><a id='roleL' href="javascript:activateTab('roleSection', 'roleL')">Role</a></li>

                <li><a id='teamL' href="javascript:activateTab('teamSection', 'teamL')">Team</a></li>
                <li>
                <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
                </li>
            </ul>
        </div>

        


        

        <div id="tabCtrl">
            <div id="mainMenuSection" style="display: block;">Main Menu Screen </div>
            <div id="roleSection" style="display: none;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RoleID" DataSourceID="SqlDataSourceRole">
            <Columns>
                <asp:BoundField DataField="RoleID" HeaderText="RoleID" ReadOnly="True" SortExpression="RoleID" />
                <asp:BoundField DataField="RoleName" HeaderText="RoleName" SortExpression="RoleName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceRole" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [RoleID], [RoleName] FROM [Role]"></asp:SqlDataSource>
         <asp:Button ID ="NewRole" runat ="server" Text ="New Role" OnClick="NewRole_Click" />

        
        </div>
            <div id="teamSection" style="display: none;">

                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="TeamID" DataSourceID="SqlDataSourceTeam">
            <Columns>
                <asp:BoundField DataField="TeamID" HeaderText="TeamID" ReadOnly="True" SortExpression="TeamID" />
                <asp:BoundField DataField="TeamName" HeaderText="TeamName" SortExpression="TeamName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceTeam" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [TeamID], [TeamName] FROM [Team]"></asp:SqlDataSource>
            <asp:Button ID ="NewTeam" runat="server" Text="NewTeam" OnClick="NewTeam_Click" />
            
            </div>
            
        </div>
        <%--<asp:Button ID="NewRole" runat="server" Text="New Role" OnClick="NewRole_Click" />--%>
        
    </form>
</body>
</html>

  