////-----------------------------------------------------------------------
//// <copyright file="NewContacts.aspx.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
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
            this.drpAdminLvl.Items.Add("0");
            this.drpAdminLvl.Items.Add("1");
            this.drpAdminLvl.Items.Add("2");
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
            try
            {
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
                string mySql2 = "INSERT INTO tblUser (UserID, UserName, Password, FirstName, LastName, Role, AdminLevel, Team, Email, Phone) VALUES (" + nextID + ", '" + this.txtUserName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtFirstName.Text + "', '" + this.txtLastName.Text + "', '" + this.DropDownList1.Text + "', '" + this.drpAdminLvl.Text + "' , '" + this.DropDownList3.Text + "', '" + this.txtEmail.Text + "', '" + this.txtPhone.Text + "')";
                ////Query to update access level in the table
                DataSet dsView2 = new DataSet();
                da2 = new SqlDataAdapter(mySql2, con2);
                con2.Open();
                SqlCommand cmmd2 = new SqlCommand(mySql2, con2);
                SqlDataReader reader = cmmd2.ExecuteReader();
                con2.Close();
                Response.Redirect("Contacts.aspx");
            }
            catch (SqlException sqle)
            {
                Response.Write("<script>alert('Username already taken. Kindly use another username.')</script>");
                Console.WriteLine("Username already taken. Kindly use another username.", sqle);
            }
        }
    }
}