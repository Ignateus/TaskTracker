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
    using System.Configuration;
    using System.Drawing;

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
            string sessionId = HttpContext.Current.Session["Session_State"].ToString();
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
                this.adminD.Visible = false;
            }
            else
            {
                this.adminD.Visible = true;
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Set the hand mouse cursor for the selected row.
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor = 'hand';");

                // The seelctButton exists for ensuring the selection functionality
                // and bind it with the appropriate event hanlder.
                LinkButton selectButton = new LinkButton()
                {
                    CommandName = "Select",
                    Text = e.Row.Cells[0].Text
                };
                selectButton.Font.Underline = false;
                selectButton.ForeColor = Color.Black;

                e.Row.Cells[0].Controls.Add(selectButton);
                //e.Row.Attributes["OnClick"] =
                //     Page.ClientScript.GetPostBackClientHyperlink(selectButton, "");
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.taskGV, "Select$" + e.Row.RowIndex);
            }
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