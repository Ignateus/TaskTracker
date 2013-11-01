////-----------------------------------------------------------------------
//// <copyright file="EditProjects.aspx.cs" company="Advance Software Engineering Project">
////     Copyright (c) Advance Software Engineering Project. All rights reserved.
//// </copyright>
//// <author>PTT Team</author>
////-----------------------------------------------------------------------
namespace PTT.Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This is the code for Edit Project Page
    /// </summary>
    public partial class EditProjects : System.Web.UI.Page
    {
        /// <summary>
        /// This code will initiate when contacts is clicked
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 59</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Need to work on displaying data
        }

        /// <summary>
        /// This code for main menu generation
        /// </summary>
        /// <param name="sender">not needed</param>
        /// <param name="e">not needed 61</param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListProjects.aspx");
        }
    }
}