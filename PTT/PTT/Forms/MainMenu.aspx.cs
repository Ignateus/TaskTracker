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
    using System.Data;
    using System.Data.OleDb;
    using System.Data.Sql;
    using System.Data.SqlClient;
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
            SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
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
                this.Admin.Visible = false;
            }
            else
            {
                this.Admin.Visible = true;
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

        /// <summary>
        /// This code will initiate when contacts is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 58</param>
        protected void Project_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Projects/ListProjects.aspx");
        }
    }
}