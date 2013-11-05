////-----------------------------------------------------------------------
//// <copyright file="NewRole.aspx.cs" company="Sprocket Enterprises">
////     Copyright (c) Sprocket Enterprises. All rights reserved.
//// </copyright>
//// <author>John Doe</author>
////-----------------------------------------------------------------------
namespace PTT.Admin
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
    using System.Configuration;

    /// <summary>
    /// This is the code for New Role Page
    /// </summary>
    public partial class NewRole : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 35</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////txtRole.Text = "";
        }

        /// <summary>
        /// This code will initiate after AddRole button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 36</param>
        protected void AddRole_Click(object sender, EventArgs e)
        {
            ////connection string
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
            SqlConnection con1 = new SqlConnection(connString);
            SqlDataAdapter da1;
            string mySql1 = "select MAX(RoleID) from Role";
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
            string mySql2 = "INSERT INTO Role (RoleID, RoleName) VALUES (" + nextID + ",'" + this.txtRole.Text + "')";
            ////Query to update access level in the table
            DataSet dsView2 = new DataSet();
            da2 = new SqlDataAdapter(mySql2, con2);
            con2.Open();
            SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
            SqlDataReader reader = cmmd2.ExecuteReader();
            con2.Close();
            Response.Redirect("../Forms/Admin.aspx");
        }
    }
}