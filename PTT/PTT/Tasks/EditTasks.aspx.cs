////-----------------------------------------------------------------------
//// <copyright file="EditTasks.aspx.cs" company="Advance Software Engineering Project">
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
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This is the code for Edit Task Page
    /// </summary>
    public partial class EditTasks : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 9</param>        
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Need to work on displaying data            
                ////var srNumber = Request.Params["TaskID"];
                ////this.DrpStatus.Items.Add("Open");
                ////this.DrpStatus.Items.Add("Closed");
                ////this.DrpStatus.Items.Add("Cancelled");
                ////this.DrpStatus.Items.Add("On Hold");
                ////this.DrpType.Items.Add("Individual");
                ////this.DrpType.Items.Add("Shared");
                ////this.DrpPriority.Items.Add("High");
                ////this.DrpPriority.Items.Add("Normal");
                ////this.DrpPriority.Items.Add("Low");
                ////string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
                ////using (SqlConnection con1 = new SqlConnection(connString))
                ////{
                ////    SqlDataAdapter da1;
                ////    string mySql1 = string.Format("SELECT * FROM tblTask WHERE TaskID = '{0}'", srNumber);
                ////    ////Query to update access level in the table
                ////    DataSet dsView = new DataSet();
                ////    da1 = new SqlDataAdapter(mySql1, con1);
                ////    con1.Open();
                ////    SqlCommand cmmd = new SqlCommand(mySql1, con1);
                ////    var data = cmmd.ExecuteReader();
                ////    if (data.Read())
                ////    {
                ////        TxtTaskID.Text = (string)Convert.ToString(data["TaskID"]);
                ////        DrpStatus.Text = (string)data["Status"];
                ////        DropDownList2.Text = (string)data["AssignedTo"];
                ////        DrpType.Text = (string)data["Type"];
                ////        TxtDueDate.Text = (string)Convert.ToString(data["DueDate"]);
                ////        DrpPriority.Text = (string)data["Priority"];
                ////        TxtCreationDate.Text = (string)Convert.ToString(data["CreationDate"]);
                ////        TxtNotes.Text = (string)data["Notes"];
                ////        DropDownList5.Text = (string)data["ProjectTitle"];
                ////    }
                ////    con1.Close();
                ////}
        }

        /// <summary>
        /// This code will initiate when page is pre rendered based on item
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            var srNumber = Request.Params["TaskID"];
            this.DrpStatus.Items.Add("Open");
            this.DrpStatus.Items.Add("Closed");
            this.DrpStatus.Items.Add("Cancelled");
            this.DrpStatus.Items.Add("On Hold");
            this.DrpType.Items.Add("Individual");
            this.DrpType.Items.Add("Shared");
            this.DrpPriority.Items.Add("High");
            this.DrpPriority.Items.Add("Normal");
            this.DrpPriority.Items.Add("Low");
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
            using (SqlConnection con1 = new SqlConnection(connString))
            {
                SqlDataAdapter da1;
                string mySql1 = string.Format("SELECT * FROM tblTask WHERE TaskID = '{0}'", srNumber);
                ////Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                SqlCommand cmmd = new SqlCommand(mySql1, con1);
                var data = cmmd.ExecuteReader();
                if (data.Read())
                {
                    this.TxtTaskID.Text = (string)Convert.ToString(data["TaskID"]);
                    this.DrpStatus.Text = (string)data["Status"];
                    this.DropDownList2.Text = (string)data["AssignedTo"];
                    this.DrpType.Text = (string)data["Type"];
                    this.TxtDueDate.Text = (string)Convert.ToString(data["DueDate"]);
                    this.DrpPriority.Text = (string)data["Priority"];
                    this.TxtCreationDate.Text = (string)Convert.ToString(data["CreationDate"]);
                    this.TxtNotes.Text = (string)data["Notes"];
                    this.DropDownList5.Text = (string)data["ProjectTitle"];
                }

                con1.Close();
            }
        }

        /// <summary>
        /// This code will initiate when date is selected from calendar
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TxtDueDate.Text = Calendar1.SelectedDate.ToString();
        }

        /// <summary>
        /// This code will initiate when Update button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 113</param>
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
            SqlConnection con2 = new SqlConnection(connString);
            SqlDataAdapter da2;
            ////SqlDataReader reader;
            int index = DrpPriority.SelectedIndex;
            string mySql2 = "UPDATE tblTask SET Status = '" + this.DrpStatus.Text + "', Notes = '" + this.TxtNotes.Text + "', Type = '" + this.DrpType.Text + "', Priority = '" + this.DrpPriority.Text + "' WHERE TaskID = '" + this.TxtTaskID.Text + "'";
            ////Query to update access level in the table
            DataSet dsView2 = new DataSet();
            da2 = new SqlDataAdapter(mySql2, con2);
            con2.Open();
            SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
            SqlDataReader reader = cmmd2.ExecuteReader();
            con2.Close();
            Response.Redirect("../Forms/MainMenu.aspx");
        }

        /// <summary>
        /// This code will initiate when Cancel button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 106</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Forms/MainMenu.aspx");
        }
    }
}