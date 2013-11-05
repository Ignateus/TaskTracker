<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="PTT.Usr_Ctl.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>

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
            document.getElementById('projectL').className = "inactive";
            document.getElementById('taskL').className = "inactive";
            //document.getElementById('adminL').className = "inactive";
            document.getElementById('contactsL').className = "inactive";

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

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
             
        <div id="tabs"> 
            <ul class="tabList"> 
                <li><a id='mainMenuL' href="javascript:activateTab('mainMenuSection', 'mainMenuL')"  class='active'>Main Menu</a></li> 
                <li><a id='projectL' href="javascript:activateTab('projectSection', 'projectL')">Project</a></li> 
                <li><a id='taskL' href="javascript:activateTab('taskSection', 'taskL')">Task</a></li>
                <%--<li><a id='adminL' href="javascript:activateTab('adminSection', 'adminL')">Admin</a></li>--%>
                <%--<li><a id='contactsL' href="javascript:activateTab('contactsSection', 'contactsL')">Contacts</a></li>--%>
                <li><a id='contactsL' href="../Contacts/Contacts.aspx">Contacts</a></li>
            </ul>
            <div id="adminD" runat="server">
                <ul class="tabList">
                    <li><a id='adminL' href="Admin.aspx">Admin</a></li>

                </ul>
            </div>
        </div>

        <div style="float:right">
            <asp:Button ID="btnLogout" runat="server" OnClick="BtnLogout_Click" Text="Logout" />
        </div>
       
        <div id="tabCtrl">
            <div id="mainMenuSection" style="display: block;">Main Menu Screen</div>
            <div id="projectSection" style="display: none;">Project Screen</div>
            <div id="taskSection" style="display: none;">
                Task Screen</div>
            
                
                <div>
                    <asp:GridView ID="taskGV" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="100" AllowSorting="True" DataKeyNames="TaskID" onselectedindexchanged="GridView1_SelectedIndexChanged"  onrowdatabound="GridView1_RowDataBound">
                        <Columns>
                            <asp:BoundField DataField="TaskID" HeaderText="Task ID"/>
                            <asp:BoundField DataField="StatusName" HeaderText="Status"/>
                            <asp:BoundField DataField="AssignedTo" HeaderText="Assigned To"/>
                            <asp:BoundField DataField="ProjectTitle" HeaderText="Project"/>
                            <asp:BoundField DataField="DueDate" HeaderText="Due Date"/>
                            <asp:BoundField DataField="Priority" HeaderText="Priority"/>
                            <asp:BoundField DataField="Type" HeaderText="Type"/>
                            <asp:BoundField DataField="CreationDate" HeaderText="Creation Date"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <div id="adminSection" style="display: none;">Admin Screen
              
            </div>
            <div id="contactsSection" style="display: none;">Contacts Screen</div>
        
        <%--   
        <asp:Button ID="Button1" runat="server" Text="Main Menu" />
        <asp:Button ID="Button2" runat="server" Text="Project" />
        <asp:Button ID="Button3" runat="server" Text="Task" />
        <asp:Button ID="Admin" runat="server" Text="Admin" OnClick="Admin_Click" />
        <asp:Button ID="Contacts" runat="server" Text="Contacts" OnClick="Contacts_Click" />
        <br />
        <br />
        <asp:Button ID="sample" runat="server" Text="sample" Visible="false" />
       

        <br />
        <asp:Label ID="role" runat="server" />--%>
    </form>
</body>
</html>
