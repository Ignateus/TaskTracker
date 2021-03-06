﻿using System;
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

namespace PTT
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

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
                
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(this.taskGV, "Select$" + e.Row.RowIndex);
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

        public Control taskGV { get; set; }
    }
    
}