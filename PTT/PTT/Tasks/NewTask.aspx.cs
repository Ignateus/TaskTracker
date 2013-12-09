////-----------------------------------------------------------------------
//// <copyright file="NewTask.aspx.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
////-----------------------------------------------------------------------
namespace PTT.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.Sql;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This code will initiate during New Task
    /// </summary>
    /// <param name="sender">not needed</param>
    /// <param name="e">not needed 9</param> 
    public partial class NewTask : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate when Page is loaded
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.DrpStatus.Items.Add("Open");
            this.DrpStatus.Items.Add("Closed");
            this.DrpStatus.Items.Add("Cancelled");
            this.DrpStatus.Items.Add("On Hold");
            this.DrpType.Items.Add("Individual");
            this.DrpType.Items.Add("Shared");
            this.DrpPriority.Items.Add("High");
            this.DrpPriority.Items.Add("Normal");
            this.DrpPriority.Items.Add("Low");
        }

        /// <summary>
        /// This code will initiate when Cancel button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Forms/MainMenu.aspx");
        }

        /// <summary>
        /// This code will initiate when Cancel button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
                SqlConnection con1 = new SqlConnection(connString);
                SqlDataAdapter da1;
                string mySql1 = "select MAX(TaskID) from tblTask";
                ////Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                SqlCommand cmmd = new SqlCommand(mySql1, con1);
                int nextID = (int)cmmd.ExecuteScalar();
                nextID = nextID + 1;
                con1.Close();
                SqlConnection con2 = new SqlConnection(connString);
                SqlDataAdapter da2;
                ////SqlDataReader reader;
                string mySql2 = "INSERT INTO tblTask (TaskID, Status, AssignedTo, Type, DueDate, Priority, CreationDate, Notes, ProjectTitle) VALUES (" + nextID + ", '" + this.DrpStatus.Text + "', '" + this.DropDownList2.Text + "', '" + this.DrpType.Text + "', '" + this.TxtDueDate.Text + "', '" + this.DrpPriority.Text + "', '" + DateTime.Now + "' , '" + this.TxtNotes.Text + "', '" + this.DropDownList5.Text + "')";
                ////Query to update access level in the table
                DataSet dsView2 = new DataSet();
                da2 = new SqlDataAdapter(mySql2, con2);
                con2.Open();
                SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
                SqlDataReader reader = cmmd2.ExecuteReader();
                con2.Close();
                Response.Redirect("../Forms/MainMenu.aspx");
            }
            catch (SqlException sqle)
            {
                Response.Write("<script>alert('Username already taken. Kindly use another username.')</script>");
                Console.WriteLine("Username already taken. Kindly use another username.", sqle);
            }
        }

        /// <summary>
        /// This code will initiate during calendar selection
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 9</param> 
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            this.TxtDueDate.Text = this.Calendar1.SelectedDate.ToString();
        }
    }
}