////-----------------------------------------------------------------------
//// <copyright file="NewTeam.aspx.cs" company="Sprocket Enterprises">
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

    /// <summary>
    /// This is the code for New Team Page
    /// </summary>
    public partial class NewTeam : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 37</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Regular Page Load
        }

        /// <summary>
        /// This code will initiate when SaveTeam is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 37</param>
        protected void SaveTeam_Click(object sender, EventArgs e)
        {
            ////connection string
            SqlConnection con1 = new SqlConnection("Data Source=.\\sqldeveloper; Initial Catalog=PTT; Integrated Security=SSPI");
            SqlDataAdapter da1;
            string mySql1 = "select MAX(TeamID) from Team";
            ////Query to update access level in the table
            DataSet dsView = new DataSet();
            da1 = new SqlDataAdapter(mySql1, con1);
            con1.Open();
            SqlCommand cmmd = new SqlCommand(mySql1, con1);
            int nextID = (int)cmmd.ExecuteScalar();
            nextID = nextID + 1;
            con1.Close();
            SqlConnection con2 = new SqlConnection("Data Source=.\\sqldeveloper; Initial Catalog=PTT; Integrated Security=SSPI");
            SqlDataAdapter da2;
            ////SqlDataReader reader;
            string mySql2 = "INSERT INTO Team (TeamID, TeamName) VALUES (" + nextID + ",'" + this.txtNewTeam.Text + "')";
            ////Query to update access level in the table
            DataSet dsView2 = new DataSet();
            da2 = new SqlDataAdapter(mySql2, con2);
            con2.Open();
            SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
            SqlDataReader reader = cmmd2.ExecuteReader();
            con2.Close();
            Response.Redirect("Team.aspx");
        }
    }
}