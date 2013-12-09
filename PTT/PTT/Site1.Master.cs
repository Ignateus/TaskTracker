////-----------------------------------------------------------------------
//// <copyright file="Site1.Master.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
////-----------------------------------------------------------------------
namespace PTT
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.Sql;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This code will initiate when New Role button is clicked
    /// </summary>
    /// <param name="sender">not needed</param>
    /// <param name="e">not needed 113</param>
    public partial class Site1 : System.Web.UI.MasterPage
    {
        /// <summary>
        /// This code will initiate when Page Load is initiated
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 110</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Regular Page Load
        }

        /// <summary>
        /// This code will initiate when Logout button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 109</param>
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

        /// <summary>
        /// This code will initiate when Admin button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 111</param>
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
        /// This code will initiate when Grid view is invoked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Gridview index changed
        }

        /// <summary>
        /// This code will initiate when row from grid view is selected
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 100</param>
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
                ////e.Row.Attributes["OnClick"] =
                ////     Page.ClientScript.GetPostBackClientHyperlink(selectButton, "");
                
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(this.TaskGV, "Select$" + e.Row.RowIndex);
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

        /// <summary>
        /// Gets or sets a value indicating whether the item is enabled.
        /// </summary>
        ////[SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", 
        ////Justification = "Reviewed.")]
        public Control TaskGV 
        { 
            get; 
            set; 
        }
    }    
}