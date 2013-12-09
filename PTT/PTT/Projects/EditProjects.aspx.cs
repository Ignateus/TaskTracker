////-----------------------------------------------------------------------
//// <copyright file="EditProjects.aspx.cs" company="Advance Software Engineering Project">
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
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This is the code for Edit Project Page
    /// </summary>
    public partial class EditProjects : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate when contacts is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 59</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //////Need to work on displaying data
            ////var srNumber = Request.Params["Project_ER_SR_No"];
            ////string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();

            ////using (SqlConnection con1 = new SqlConnection(connString))
            ////{
            ////    SqlDataAdapter da1;
            ////    string mySql1 = string.Format("SELECT * FROM tblProject WHERE Project_ER_SR_No = '{0}'", srNumber);
            ////    ////Query to update access level in the table
            ////    DataSet dsView = new DataSet();
            ////    da1 = new SqlDataAdapter(mySql1, con1);
            ////    con1.Open();
            ////    SqlCommand cmmd = new SqlCommand(mySql1, con1);
            ////    var data = cmmd.ExecuteReader();
            ////    if (data.Read())
            ////    {
            ////        TxtProjectTitle.Text = (string)data["ProjectTitle"];
            ////        TxtLeadPMName.Text = (string)data["LeadPMName"];
            ////        TxtProjectCategory.Text = (string)data["ProjectCategory"];
            ////        TxtProjectType.Text = (string)data["ProjectType"];
            ////        TxtProjectStatus.Text = (string)data["ProjectStatus"];
            ////        TxtProjectYear.Text = (string)data["ProjectYear"];
            ////        TxtProjectQ.Text = (string)data["ProjectQuarter"];
            ////        TxtActualCost.Text = (string)Convert.ToString(data["ActualCost"]);
            ////        TxtCurrency.Text = (string)data["Currency"];
            ////        TxtUpdates.Text = (string)data["Updates"];
            ////        TxtProjectDescription.Text = (string)data["ProjectDescription"];
            ////        TxtBenefits.Text = (string)data["Benefit"];
            ////        TxtCustomer.Text = (string)data["CustomerTypeID"];
            ////        TxtROI.Text = (string)Convert.ToString(data["ReturnOnInvestment"]);
            ////    }
            ////}
        }

        /// <summary>
        /// This code for main menu generation
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 61</param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ////Need to work on displaying data
            var srNumber = Request.Params["Project_ER_SR_No"];
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();

            using (SqlConnection con1 = new SqlConnection(connString))
            {
                SqlDataAdapter da1;
                string mySql1 = string.Format("SELECT * FROM tblProject WHERE Project_ER_SR_No = '{0}'", srNumber);
                ////Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                SqlCommand cmmd = new SqlCommand(mySql1, con1);
                var data = cmmd.ExecuteReader();
                if (data.Read())
                {
                    this.TxtProjectTitle.Text = (string)data["ProjectTitle"];
                    this.TxtLeadPMName.Text = (string)data["LeadPMName"];
                    this.TxtProjectCategory.Text = (string)data["ProjectCategory"];
                    this.TxtProjectType.Text = (string)data["ProjectType"];
                    this.TxtProjectStatus.Text = (string)data["ProjectStatus"];
                    this.TxtProjectYear.Text = (string)data["ProjectYear"];
                    this.TxtProjectQ.Text = (string)data["ProjectQuarter"];
                    this.TxtActualCost.Text = (string)Convert.ToString(data["ActualCost"]);
                    this.TxtCurrency.Text = (string)data["Currency"];
                    this.TxtUpdates.Text = (string)data["Updates"];
                    this.TxtProjectDescription.Text = (string)data["ProjectDescription"];
                    this.TxtBenefits.Text = (string)data["Benefit"];
                    this.TxtCustomer.Text = (string)data["CustomerTypeID"];
                    this.TxtROI.Text = (string)Convert.ToString(data["ReturnOnInvestment"]);
                }
            }
        }

        /// <summary>
        /// This code will initiate when Cancel button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 101</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Forms/MainMenu.aspx");
        }

        /// <summary>
        /// This code will initiate when Update button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            ////try
            ////{       
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
                SqlConnection con2 = new SqlConnection(connString);
                SqlDataAdapter da2;
                ////SqlDataReader reader;
                string mySql2 = "UPDATE tblProject SET ProjectTitle = '" + this.TxtProjectTitle.Text + "', LeadPMName = '" + this.TxtLeadPMName.Text + "', ProjectCategory = '" + this.TxtProjectCategory.Text + "', ProjectType = '" + this.TxtProjectType.Text + "', ProjectStatus = '" + this.TxtProjectStatus.Text + "', ProjectYear = '" + this.TxtProjectYear.Text + "', ProjectQuarter = '" + this.TxtProjectQ.Text + "', ProjectDescription = '" + this.TxtProjectDescription.Text + "', CustomerTypeID = '" + this.TxtCustomer.Text + "', Currency = '" + this.TxtCurrency.Text + "', BudgetedCost = '" + this.TxtBudgetCost.Text + "', ActualCost = '" + this.TxtActualCost.Text + "', ReturnOnInvestment = '" + this.TxtROI.Text + "' WHERE ProjectTitle = '" + this.TxtProjectTitle.Text + "'";
                ////Query to update access level in the table
                DataSet dsView2 = new DataSet();
                da2 = new SqlDataAdapter(mySql2, con2);
                con2.Open();
                SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
                SqlDataReader reader = cmmd2.ExecuteReader();
                con2.Close();
                Response.Redirect("../Forms/MainMenu.aspx");
            ////}
            ////catch (SqlException se)
            ////{
            ////    Response.Write("<script>alert('Data not saved! Contact Admin.')</script>");
            ////    Console.WriteLine("", se);
            ////}        
        }
    }
}