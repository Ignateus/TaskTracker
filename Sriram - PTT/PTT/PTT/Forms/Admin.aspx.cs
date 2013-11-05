////-----------------------------------------------------------------------
//// <copyright file="Admin.aspx.cs" company="Sprocket Enterprises">
////     Copyright (c) Sprocket Enterprises. All rights reserved.
//// </copyright>
//// <author>John Doe</author>
////-----------------------------------------------------------------------
namespace PTT.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This is the code for Admin Page
    /// </summary>
    public partial class Admin : System.Web.UI.Page
    {
        
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 32</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            object sessionId = HttpContext.Current.Session["Session_State"];
            if (sessionId == null)
                Response.Redirect("../Login.aspx");
            ////Regular Page Load
        }

        /// <summary>
        /// This code will initiate when MainMenu button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 31</param>
        protected void MainMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        /// <summary>
        /// This code will initiate when Logout is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 20</param>
        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

        /// <summary>
        /// This code will initiate when Role is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 34</param>
        protected void Role_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/Role.aspx");
        }

        /// <summary>
        /// This code will initiate when Team button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 35</param>
        protected void Team_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/Team.aspx");
        }

        protected void NewRole_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/NewRole.aspx");
        }

        protected void NewTeam_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/NewTeam.aspx");
        }
    }
}