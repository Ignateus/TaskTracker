////-----------------------------------------------------------------------
//// <copyright file="Contacts.aspx.cs" company="Sprocket Enterprises">
////     Copyright (c) Sprocket Enterprises. All rights reserved.
//// </copyright>
//// <author>John Doe</author>
////-----------------------------------------------------------------------
namespace PTT.Forms
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
    /// This is the code for Contacts Page
    /// </summary>
    public partial class Contacts : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 42</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Regular Page Load
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
                this.NewUser.Visible = false;
            }
            else
            {
                this.NewUser.Visible = true;
            }
        }

        /// <summary>
        /// This code will initiate when NewUser button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 43</param>
        protected void NewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewContacts.aspx");
        }
    }
}