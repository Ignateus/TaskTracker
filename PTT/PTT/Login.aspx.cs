using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;


namespace PTT
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session("Previous_Page") = Login.aspx;
            //Session("LoggedIn") = "";
            //Image1.Visible = true;
            //txtUsername.Text = "";
            //txtPassword.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");//connection string
            SqlDataAdapter da;
            string mySql = "Select * FROM tblUser where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            da = new SqlDataAdapter(mySql, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");//connection string
                SqlDataAdapter da1;
                string mySql1 = "select AdminLevel from tblUser where UserName = '" + txtUsername.Text + "'"; //Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                da1.Fill(ds);
                txtAccessControl.Text = dsView.Tables[0].Rows[0][0].ToString();
                txtAccessControl.DataBind();
                con1.Close();

                //select AdminLevel from tblUser where UserName = '" + txtUsername.Text + "'
                //UPDATE tblAccess SET AccessLevel = '" + txtAccessLevel.Text + "' WHERE AccessID = '1'
                Response.Redirect("Forms/MainMenu.aspx");
            }
            else
            {
                Response.Write("<script>alert('Wrong username or password.')</script>");
            }
            con.Close();



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}