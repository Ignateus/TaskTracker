////-----------------------------------------------------------------------
//// <copyright file="NewContacts.aspx.cs" company="Sprocket Enterprises">
////     Copyright (c) Sprocket Enterprises. All rights reserved.
//// </copyright>
//// <author>John Doe</author>
////-----------------------------------------------------------------------
namespace PTT.Contacts
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
    /// This is the code for New Contacts Page
    /// </summary>
    public partial class NewContacts : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 44</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            drpAdminLvl.Items.Add("0");
            drpAdminLvl.Items.Add("1");
            drpAdminLvl.Items.Add("2");
        }

        /// <summary>
        /// This code will initiate when Button Cancel is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 45</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contacts.aspx");
        }

        /// <summary>
        /// This code will initiate when Button Save is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 47</param>
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            ////connection string
            SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
            SqlDataAdapter da1;
            string mySql1 = "select MAX(UserID) from tblUser";
            ////Query to update access level in the table
            DataSet dsView = new DataSet();
            da1 = new SqlDataAdapter(mySql1, con1);
            con1.Open();
            SqlCommand cmmd = new SqlCommand(mySql1, con1);
            int nextID = (int)cmmd.ExecuteScalar();
            nextID = nextID + 1;
            con1.Close();
            SqlConnection con2 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
            SqlDataAdapter da2;
            ////SqlDataReader reader;
            string mySql2 = "INSERT INTO tblUser (UserID, UserName, Password, FirstName, LastName, Role, AdminLevel, Team, Email, Phone) VALUES (" + nextID + ", '" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + DropDownList1.Text + "', '" + drpAdminLvl.Text + "' , '" + DropDownList3.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "')";
            ////Query to update access level in the table
            DataSet dsView2 = new DataSet();
            da2 = new SqlDataAdapter(mySql2, con2);
            con2.Open();
            SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
            SqlDataReader reader = cmmd2.ExecuteReader();
            con2.Close();
            Response.Redirect("Contacts.aspx");
        }
    }
}