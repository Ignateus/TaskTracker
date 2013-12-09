////-----------------------------------------------------------------------
//// <copyright file="Login.aspx.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
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
using System.Configuration;

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
        /// 

        protected void Page_Load(object sender, EventArgs e)
        {
            ////To implement access control I am using this text box to store the flag and 
            txtAccessControl.Visible = false;
            txtUserID.Visible = false;
            txtPMName.Visible = false;
        }

        /// <summary>
        /// Code executed when Login button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 10</param>
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            string username = txtUsername.Text;
            
            string mySql2 = "select AdminLevel from tblUser where UserName = '" + username + "'";
            string mySql3 = "select FirstName from tblUser where UserName = '" + username + "'";
            ////Query to update access level in the table
            DataSet dsView1 = new DataSet();
            Guid sessionId = Guid.NewGuid();
            
            context.Session["Session_State"] = sessionId.ToString();
            ////connection string
            string connString = ConfigurationManager.ConnectionStrings["TaskTrackerConnectionString"].ToString();
            //string connString = @"Data Source=Sriram-PC; Initial Catalog=PTT_Database;  User id = Sriram-PC\Sriram ; Password = Chennai44!;";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlDataAdapter da;
            string mySql = "Select * FROM tblUser where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            da = new SqlDataAdapter(mySql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SqlDataAdapter da2 = new SqlDataAdapter(mySql2, con);
            SqlCommand cmmd1 = new SqlCommand(mySql2, con);
            int nextID = (int)cmmd1.ExecuteScalar();
            context.Session["Access_Level"] = nextID.ToString();

            SqlDataAdapter da3 = new SqlDataAdapter(mySql3, con);
            SqlCommand cmmd2 = new SqlCommand(mySql3, con);
            string user = (string)cmmd2.ExecuteScalar();
            context.Session["User"] = user;

            if (ds.Tables[0].Rows.Count > 0)
            {
                ////connection string
                string connString1 = connString;
                SqlConnection con1 = new SqlConnection(connString1);
                //SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
                SqlDataAdapter da1;
                string mySql1 = "select AdminLevel, UserID, FirstName from tblUser where UserName = '" + txtUsername.Text + "'"; 
                ////Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                SqlCommand cmmd = new SqlCommand(mySql1, con1);                
                SqlDataReader readerA = cmmd.ExecuteReader();                          
                while (readerA.Read())
                {
                    txtAccessControl.Text = readerA["AdminLevel"].ToString();
                    txtUserID.Text = readerA["UserID"].ToString();
                    txtPMName.Text = readerA["FirstName"].ToString();
                    string connString3 = connString;
                    SqlConnection con3 = new SqlConnection(connString3);
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;
                    cmd.CommandText = "UPDATE tblAccess SET AccessLevel = '" + txtAccessControl.Text + "', UserID = '" + txtUserID.Text + "', PMName = '" + txtPMName.Text + "' WHERE AccessID = '1'";
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