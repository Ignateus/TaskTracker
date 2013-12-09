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
            document.getElementById('contactL').className = "inactive";

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
                <li><a id='contactL' href="javascript:activateTab('contactSection', 'contactL')">Contacts</a></li>
                <%--<li><a id='contactsL' href="javascript:activateTab('newSection', 'contactsL')">Contacts</a></li>--%>
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
            <div id="projectSection" style="display: none;">
                <asp:Button ID="NewProject" runat="server" Text="New Project" OnClick="NewProject_Click" />
                
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Project_ER_SR_NO" DataSourceID="SqlDataSourceProjects" AllowSorting="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
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
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Project_ER_SR_NO" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" DataSourceID="SqlDataSource1ProjectAdmin" AllowSorting="True">
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
            </div>
            <div id="taskSection" style="display: none;">
                
       <div>
   
        <asp:Button ID="NewTasks" runat="server" Text="New Task" OnClick="NewTasks_Click" />   
        <asp:Button ID="AllTasks" runat="server" Text="All Tasks" OnClick="AllTasks_Click" />  
        <asp:Button ID="OriginalView" runat="server" Text="Original View" OnClick="OriginalView_Click" />        
        <asp:Button ID="SharedTask" runat="server" Text="Shared Task" OnClick="SharedTask_Click" />
            
    </div>
        <asp:GridView ID="GridView4" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="TaskID" DataSourceID="SqlDataSource1tasks" OnSelectedIndexChanged="GridView4_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="TaskID" HeaderText="TaskID" ReadOnly="True" SortExpression="TaskID" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="AssignedTo" HeaderText="AssignedTo" SortExpression="AssignedTo" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" />
                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" SortExpression="CreationDate" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1tasks" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>"></asp:SqlDataSource>
<%--        <asp:GridView ID="GridView5" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="TaskID" DataSourceID="SqlDataSource1tasks" OnSelectedIndexChanged="GridView5_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="TaskID" HeaderText="TaskID" ReadOnly="True" SortExpression="TaskID" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="AssignedTo" HeaderText="AssignedTo" SortExpression="AssignedTo" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" />
                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" SortExpression="CreationDate" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
            </Columns>
        </asp:GridView>--%>
            
        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataKeyNames="TaskID" DataSourceID="SqlDataSource1tasks" AllowSorting="True" OnSelectedIndexChanged="GridView6_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="TaskID" HeaderText="TaskID" ReadOnly="True" SortExpression="TaskID" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="AssignedTo" HeaderText="AssignedTo" SortExpression="AssignedTo" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" />
                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" SortExpression="CreationDate" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
            </Columns>
        </asp:GridView>

        <asp:GridView ID="GridView5" runat="server" AllowSorting="True" AutoGenerateColumns="False" visible="false" DataKeyNames="TaskID" DataSourceID="SqlDataSourceSharedTasks">
            <Columns>
                <asp:BoundField DataField="TaskID" HeaderText="TaskID" ReadOnly="True" SortExpression="TaskID" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="AssignedTo" HeaderText="AssignedTo" SortExpression="AssignedTo" />
                <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" />
                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
                <asp:BoundField DataField="ProjectTitle" HeaderText="ProjectTitle" SortExpression="ProjectTitle" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceSharedTasks" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT t.TaskID, t.Status, t.Type, t.AssignedTo, t.DueDate, t.Priority, t.Notes, t.ProjectTitle FROM tblTask t, tblAccess a, tblSharedTask s WHERE a.PMName = s.SharedUser AND t.Type = 'Shared'"></asp:SqlDataSource>


            </div>  
             <div id="contactSection" style="display: none;">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceContacts">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="RoleName" HeaderText="Role" SortExpression="Role" />
                <asp:BoundField DataField="AdminLevel" HeaderText="AdminLevel" SortExpression="AdminLevel" />
                <asp:BoundField DataField="TeamName" HeaderText="Team" SortExpression="Team" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            </Columns>
           </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceContacts" runat="server" ConnectionString="<%$ ConnectionStrings:TaskTrackerConnectionString %>" SelectCommand="SELECT [UserID],[UserName],[Password],[FirstName],[LastName],a.RoleName,[AdminLevel],b.TeamName,[Email],[Phone] FROM [tblUser] as c, [Role] as a, [Team] as b WHERE c.RoleID = a.RoleID AND c.TeamID = b.TeamID"></asp:SqlDataSource>
        <asp:Button ID="NewUser" runat="server" Text="Add New User" OnClick="NewUser_Click" />
                </div> 
            </div>
            <div id="adminSection" style="display: none;">Admin Screen
              
            </div>
        
        
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
