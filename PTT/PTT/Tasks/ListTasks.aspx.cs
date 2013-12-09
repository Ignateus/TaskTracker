////-----------------------------------------------------------------------
//// <copyright file="ListTasks.aspx.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
////-----------------------------------------------------------------------

namespace PTT.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.Sql;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This code will initiate during List Tasks
    /// </summary>
    /// <param name="sender">not needed</param>
    /// <param name="e">not needed 9</param>
    public partial class ListTasks : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 9</param> 
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView3.Visible = false;
            SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
            SqlDataAdapter da1;
            string mySql1 = "select AccessLevel from tblAccess where AccessID = '1'";
            ////Query to update access level in the table
            DataSet dsView = new DataSet();
            da1 = new SqlDataAdapter(mySql1, con1);
            con1.Open();
            SqlCommand cmmd = new SqlCommand(mySql1, con1);
            int nextID = (int)cmmd.ExecuteScalar();
            //// Access level 1 is low and 2 is high
            if (nextID.Equals(1))
            {
                this.GridView1.Visible = true;
                this.GridView2.Visible = false;                
            }
            else
            {
                this.GridView1.Visible = false;
                this.GridView2.Visible = true;
                this.AllTasks.Visible = false;
            }
        }

        /// <summary>
        /// This code will initiate when New Tasks button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void NewTasks_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewTask.aspx");
        }

        /// <summary>
        /// This code will initiate when all tasks button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void AllTasks_Click(object sender, EventArgs e)
        {
            this.GridView1.Visible = false;
            this.GridView2.Visible = false;
            this.GridView3.Visible = true;
        }

        /// <summary>
        /// This code will initiate when Grid view is invoked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var task1 = this.GridView1.SelectedValue;
            Response.Redirect("EditTasks.aspx?TaskID=" + task1);
        }

        /// <summary>
        /// This code will initiate when Grid view is invoked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var task2 = this.GridView2.SelectedValue;
            Response.Redirect("EditTasks.aspx?TaskID=" + task2);
        }

        /// <summary>
        /// This code will initiate when grid view is invoked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var task3 = this.GridView2.SelectedValue;
            Response.Redirect("EditTasks.aspx?TaskID=" + task3);
        }
    }
}