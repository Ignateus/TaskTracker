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
            ////To implement access control I am using this text box to store the flag and 
            txtAccessControl.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ////connection string
            SqlConnection con = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
            SqlDataAdapter da;
            string mySql = "Select * FROM tblUser where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            da = new SqlDataAdapter(mySql, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                //connection string
                SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
                SqlDataAdapter da1;
                string mySql1 = "select AdminLevel from tblUser where UserName = '" + txtUsername.Text + "'"; 
                ////Query to update access level in the table
                DataSet dsView = new DataSet();
                da1 = new SqlDataAdapter(mySql1, con1);
                con1.Open();
                SqlCommand cmmd = new SqlCommand(mySql1, con1);
                //cmmd = New SqlCommand(mySql1, con1);
                //IDataReader readerA;// = new IDataReader();
                SqlDataReader readerA = cmmd.ExecuteReader();
                //readerA = con1.ExecuteReader();
                //using (SqlDataReader read = cmmd.ExecuteReader())
                //readerA = cmmd.ExecuteReader(CommandBehavior.CloseConnection);                
                while (readerA.Read())
                {
                    txtAccessControl.Text = (readerA["AdminLevel"].ToString());
                    //cmmd.Parameters..Value = txtAccessControl.Text;
                    //txtAccessControl.Text = readerA.GetInt(0);
                    // ** Update quarter and year based on GoLive Plan date
                    SqlConnection con3 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;
                    cmd.CommandText = "UPDATE tblAccess SET AccessLevel = '" + txtAccessControl.Text + "' WHERE AccessID = '1'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con3;
                    con3.Open();
                    reader = cmd.ExecuteReader();
                    con3.Close();
                    Response.Redirect("Forms/MainMenu.aspx");
                }
                readerA.Close();                 
               
                con1.Close();

                //select AdminLevel from tblUser where UserName = '" + txtUsername.Text + "'
                //UPDATE tblAccess SET AccessLevel = '" + txtAccessLevel.Text + "' WHERE AccessID = '1'
               // Response.Redirect("Forms/MainMenu.aspx");
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