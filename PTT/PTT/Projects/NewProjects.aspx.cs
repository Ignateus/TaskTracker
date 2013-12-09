////-----------------------------------------------------------------------
//// <copyright file="NewProjects.aspx.cs" company="Advance Software Engineering Project">
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
    /// This is the code for New Project Creation
    /// </summary>
    public partial class NewProjects : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 57</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.drpQuarter.Items.Add("Q1");
            this.drpQuarter.Items.Add("Q2");
            this.drpQuarter.Items.Add("Q3");
            this.drpQuarter.Items.Add("Q4");
            this.drpProjectStatus.Items.Add("Open");
            this.drpProjectStatus.Items.Add("Closed");
            this.drpProjectStatus.Items.Add("Canceled");
            this.drpProjectStatus.Items.Add("Completed");
            this.drpProjectType.Items.Add("Individual");
            this.drpProjectType.Items.Add("Team");
            this.drpCategory.Items.Add("Development");
            this.drpCategory.Items.Add("Bug Fix");
            this.drpCategory.Items.Add("Testing");
        }

        /// <summary>
        /// This code will initiate when Button Project is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 56</param>
        protected void ListProjects_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Projects/ListProjects.aspx");
        }

        /// <summary>
        /// This code will initiate when Button Save is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 50</param>
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            ////connection string
            ////try
            ////{
                string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
                SqlConnection con1 = new SqlConnection(connString);
                SqlDataAdapter da1;
                string mySql1 = "select MAX(ProjectID) from tblProject";
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
                string mySql2 = "INSERT INTO tblProject (ProjectID, Project_ER_SR_No, ProjectTitle, LeadPMName, ProjectCategory, ProjectType, ProjectStatus, ProjectYear, ProjectQuarter, ProjectDescription, CustomerTypeID) VALUES (" + nextID + ", '" + this.txtProjectNo.Text + "', '" + this.txtProjectTitle.Text + "', '" + this.drpPM.Text + "', '" + this.drpCategory.Text + "', '" + this.drpProjectType.Text + "', '" + this.drpProjectStatus.Text + "' , '" + this.txtYear.Text + "', '" + this.drpQuarter.Text + "', '" + this.txtProjectDesc.Text + "' , '" + this.txtCustomer.Text + "')";
                ////Query to update access level in the table
                DataSet dsView2 = new DataSet();
                da2 = new SqlDataAdapter(mySql2, con2);
                con2.Open();
                SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
                SqlDataReader reader = cmmd2.ExecuteReader();
                con2.Close();
                Response.Redirect("../Forms/MainMenu.aspx");
            ////}
            ////catch (SqlException sqle)
            ////{
            ////    Response.Write("<script>alert('Data not saved! Contact Admin.')</script>");
            ////    Console.WriteLine("Data not saved! Contact Admin", sqle);
            ////}
        }

        /// <summary>
        /// This code will initiate when Button Cancel is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 55</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Forms/MainMenu.aspx");
        }
    }
}