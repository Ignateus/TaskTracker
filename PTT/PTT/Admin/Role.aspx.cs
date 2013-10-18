////-----------------------------------------------------------------------
//// <copyright file="Role.aspx.cs" company="Sprocket Enterprises">
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
    /// This is the code for Role Page
    /// </summary>
    public partial class Role : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate during page load
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 38</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Regular Page Load
        }

        /// <summary>
        /// This code will initiate when NewRole is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 39</param>
        protected void NewRole_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewRole.aspx");
        }
    }
}