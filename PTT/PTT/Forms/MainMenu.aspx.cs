////-----------------------------------------------------------------------
//// <copyright file="MainMenu.aspx.cs" company="UTD">
//// Copyright (c) UTD. All rights reserved.
//// </copyright>
//// <author>Software Engineering Project</author>
////-----------------------------------------------------------------------
namespace PTT.Usr_Ctl
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.Sql;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// Code for the main menu page
    /// </summary>
    public partial class MainMenu : System.Web.UI.Page
    {
        /// <summary>
        /// Page Load for Main Menu
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 6</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string accessId = HttpContext.Current.Session["Access_Level"].ToString();
            string sessionId = HttpContext.Current.Session["Session_State"].ToString();
            string username = HttpContext.Current.Session["User"].ToString();
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
            SqlConnection con1 = new SqlConnection(connString);
            SqlDataAdapter da1;
            string mySql1 = "select AccessLevel from tblAccess where AccessID = '1'";
            ////Query to update access level in the table
            DataSet dsView = new DataSet();
            da1 = new SqlDataAdapter(mySql1, con1);
            con1.Open();
            SqlCommand cmmd = new SqlCommand(mySql1, con1);
            int nextID = (int)cmmd.ExecuteScalar();
            if (nextID.Equals(1))
            {
                this.adminD.Visible = false;
            }
            else
            {
                this.adminD.Visible = true;
            }

            if (!accessId.ToString().Equals("2"))
            {
                this.GridView3.Visible = false;
                this.GridView6.Visible = false;
                SqlDataSource1tasks.SelectCommand = "SELECT t.TaskID, t.Status, t.AssignedTo, t.Type, t.DueDate, t.Priority, t.CreationDate, t.Notes FROM tblTask As t WHERE t.AssignedTo = '" + username + "'" + "AND t.Status = 'Open'";
            }
            else
            {
                AllTasks.Visible = false;
                OriginalView.Visible = false;
                this.GridView4.Visible = false;
                this.GridView2.Visible = false;
                SqlDataSource1tasks.SelectCommand = "SELECT t.TaskID, t.Status, t.AssignedTo, t.Type, t.DueDate, t.Priority, t.CreationDate, t.Notes FROM tblTask As t";
            }
        } 
   
        /// <summary>
        /// Button for logout which would take the user to the login page
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 7</param>
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

        /// <summary>
        /// This code will initiate when admin is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 45</param>
        protected void Admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        /// <summary>
        /// This code will initiate when contacts is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 33</param>
        protected void Contacts_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Contacts/Contacts.aspx");
        }

        ////protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        ////{

        ////    if (e.Row.RowType == DataControlRowType.DataRow)
        ////    {
        ////        // Set the hand mouse cursor for the selected row.
        ////        e.Row.Attributes.Add("OnMouseOver", "this.style.cursor = 'hand';");

        ////        // The seelctButton exists for ensuring the selection functionality
        ////        // and bind it with the appropriate event hanlder.
        ////        LinkButton selectButton = new LinkButton()
        ////        {
        ////            CommandName = "Select",
        ////            Text = e.Row.Cells[0].Text
        ////        };
        ////        selectButton.Font.Underline = false;
        ////        selectButton.ForeColor = Color.Black;

        ////        e.Row.Cells[0].Controls.Add(selectButton);
        ////        //e.Row.Attributes["OnClick"] =
        ////        //     Page.ClientScript.GetPostBackClientHyperlink(selectButton, "");
        ////        e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.taskGV, "Select$" + e.Row.RowIndex);
        ////    }
        ////}

        /// <summary>
        /// This code will initiate when New User button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 107</param>
        protected void NewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Contacts/NewContacts.aspx");
        }

        /// <summary>
        /// This code will initiate when contacts is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 58</param>     
        protected void NewProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Projects/NewProjects.aspx");
        }

        /// <summary>
        /// This code will initiate when grid view is loaded 
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 102</param>     
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
            var blah = this.GridView2.SelectedValue;
            Response.Redirect("../Projects/EditProjects.aspx?Project_ER_SR_No=" + blah);
            SqlConnection con3 = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            ////cmd.CommandText = "UPDATE tblAccess SET UserID = '" + txtUserID.Text + "' WHERE AccessID = '1'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con3;
            con3.Open();
            reader = cmd.ExecuteReader();
            con3.Close();
        }

        /// <summary>
        /// This code will initiate when Grid View is invoked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 105</param>
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var blah = this.GridView3.SelectedValue;
            Response.Redirect("../Projects/EditProjects.aspx?Project_ER_SR_No=" + blah);
        }

        /// <summary>
        /// This code will initiate when New Tasks button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 108</param>
        protected void NewTasks_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Tasks/NewTask.aspx");
        }

        /// <summary>
        /// This code will initiate when All Tasks button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void AllTasks_Click(object sender, EventArgs e)
        {
            string username = HttpContext.Current.Session["User"].ToString();
            SqlDataSource1tasks.SelectCommand = "SELECT t.TaskID, t.Status, t.AssignedTo, t.Type, t.DueDate, t.Priority, t.CreationDate, t.Notes FROM tblTask As t WHERE t.AssignedTo = '" + username + "'";
            ////AllTasks.Visible = false;
            ////OriginalView.Visible = true;
            //    //AllTasks.Text = "Original View";
            //    //this.GridView4.Visible = false;
            ////this.GridView5.Visible = false;
            ////this.GridView6.Visible = true;
        }

        /// <summary>
        /// This code will initiate when Grid View is initiated
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var task1 = GridView4.SelectedValue;
            Response.Redirect("../Tasks/EditTasks.aspx?TaskID=" + task1);
        }

        ////protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
        ////{
        ////    var task2 = GridView5.SelectedValue;
        ////    Response.Redirect("../Tasks/EditTasks.aspx?TaskID=" + task2);
        ////}

        /// <summary>
        /// This code will initiate when Grid View is invoked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void GridView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            var task3 = GridView6.SelectedValue;
            Response.Redirect("../Tasks/EditTasks.aspx?TaskID=" + task3);
        }

        /// <summary>
        /// This code will initiate when Original View button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void OriginalView_Click(object sender, EventArgs e)
        {
            string username = HttpContext.Current.Session["User"].ToString();
            SqlDataSource1tasks.SelectCommand = "SELECT t.TaskID, t.Status, t.AssignedTo, t.Type, t.DueDate, t.Priority, t.CreationDate, t.Notes FROM tblTask As t WHERE t.AssignedTo = '" + username + "'" + " AND t.Status = 'Open'";
            ////OriginalView.Visible = false;
            ////AllTasks.Visible = true;
        }

        /// <summary>
        /// This code will initiate when Shared Tasks button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 112</param>
        protected void SharedTask_Click(object sender, EventArgs e)
        {
            this.GridView5.Visible = true;
        }

        ////protected void Page_PreRender(object sender, EventArgs e)
        ////{
        ////    string username = HttpContext.Current.Session["User"].ToString();
        ////    if (AllTasks.Visible)
        ////    {
        ////        SqlDataSource1tasks.SelectCommand = "SELECT t.TaskID, t.Status, t.AssignedTo, t.Type, t.DueDate, t.Priority, t.CreationDate, t.Notes FROM tblTask As t WHERE t.AssignedTo = '" + username + "'";
        ////        OriginalView.Visible = true;
        ////        AllTasks.Visible = false;
        ////    }
        ////    else if (OriginalView.Visible)
        ////    {
        ////        SqlDataSource1tasks.SelectCommand = "SELECT t.TaskID, t.Status, t.AssignedTo, t.Type, t.DueDate, t.Priority, t.CreationDate, t.Notes FROM tblTask As t WHERE t.AssignedTo = '" + username + "'" + "AND t.Status = 'Open'";
        ////        OriginalView.Visible = false;
        ////        AllTasks.Visible = true;
        ////    }
        ////}
    }
}