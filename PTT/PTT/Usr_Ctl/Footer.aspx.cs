namespace PTT.Usr_Ctl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This section of the code is for the footer which will be used in the future
    /// </summary>    
    public partial class Footer : System.Web.UI.Page
    {
        /// <summary>
        /// Page load properties
        /// </summary>
        /// <param name="sender">none needed</param>
        /// <param name="e">none needed 1</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFooter1.Text = "Personal Task Tracker";
        }
    }
}