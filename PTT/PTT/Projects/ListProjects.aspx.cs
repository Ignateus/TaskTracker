////-----------------------------------------------------------------------
//// <copyright file="ListProjects.aspx.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
////-----------------------------------------------------------------------
namespace PTT.Projects
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
    /// This is the code for List Project Page
    /// </summary>
    public partial class ListProjects : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 44</param>
        protected void Page_Load(object sender, EventArgs e)
        {
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
                this.GridView1.Visible = true;
                this.GridView2.Visible = false;
            }
            else
            {
                this.GridView1.Visible = false;
                this.GridView2.Visible = true;
            }
        }

        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 44</param>
        protected void NewProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewProjects.aspx");
        }

        /// <summary>
        /// This code for main menu generation
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 58</param>
        protected void MainMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Forms/MainMenu.aspx");
        }

        /// <summary>
        /// This code for main menu generation
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 60</param>
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("EditProjects.aspx");
            SqlConnection con3 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
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
        /// This code for main menu generation
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 62</param>
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var blah = this.GridView2.SelectedValue; 
            Response.Redirect("EditProjects.aspx?Project_ER_SR_No=" + blah);
        }
    }
}