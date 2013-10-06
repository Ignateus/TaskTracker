////-----------------------------------------------------------------------
//// <copyright file="Login.aspx.cs" company="Sprocket Enterprises">
////     Copyright (c) Sprocket Enterprises. All rights reserved.
//// </copyright>
//// <author>John Doe</author>
////-----------------------------------------------------------------------
namespace PTT
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
    /// This is the code for Login Page
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 9</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////To implement access control I am using this text box to store the flag and 
            txtAccessControl.Visible = false;
        }

        /// <summary>
        /// Code executed when Login button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 10</param>
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            ////connection string
            SqlConnection con = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
            SqlDataAdapter da;
            string mySql = "Select * FROM tblUser where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            da = new SqlDataAdapter(mySql, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ////connection string
                SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
                SqlDataAdapter da1;
                string mySql1 = "select AdminLevel from tblUser where UserName = '" + txtUsername.Text + "'"; 
                ////Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                SqlCommand cmmd = new SqlCommand(mySql1, con1);                
                SqlDataReader readerA = cmmd.ExecuteReader();                          
                while (readerA.Read())
                {
                    txtAccessControl.Text = readerA["AdminLevel"].ToString();                    
                    SqlConnection con3 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;
                    cmd.CommandText = "UPDATE tblAccess SET AccessLevel = '" + txtAccessControl.Text + "' WHERE AccessID = '1'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con3;
                    con3.Open();
                    reader = cmd.ExecuteReader();
                    con3.Close();
                    Response.Redirect("Forms/MainMenu.aspx");
                }

                readerA.Close();                        
                con1.Close();                
            }
            else
            {
                Response.Write("<script>alert('Wrong username or password.')</script>");
            }

            con.Close();
        }

        /// <summary>
        /// The following part of the code is for handling the cancel feature that 
        /// will refresh the page to clear text boxes from previous data.
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 12</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}