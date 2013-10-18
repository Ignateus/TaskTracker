////-----------------------------------------------------------------------
//// <copyright file="Team.aspx.cs" company="Sprocket Enterprises">
////     Copyright (c) Sprocket Enterprises. All rights reserved.
//// </copyright>
//// <author>John Doe</author>
////-----------------------------------------------------------------------
namespace PTT.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This is the code for Team Page
    /// </summary>
    public partial class Team : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 40</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Regular Page Load
        }

        /// <summary>
        /// This code will initiate when NewTeam button is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 41</param>
        protected void NewTeam_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewTeam.aspx");
        }
    }
}