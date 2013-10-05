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
namespace PTT.Usr_Ctl
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=.\IGNATEUS; Initial Catalog=TaskTracker;  User id = sa ; Password = 123456;");
                SqlDataAdapter da1;
                string mySql1 = "select AccessLevel from tblAccess where AccessID = '1'"; 
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
                    txtAccessControl.Text = (readerA["AccessLevel"].ToString());
                }
                readerA.Close();
                if (txtAccessControl.Text.Equals(1))
                {
                    sample.Visible = true;
                }
                else
                    //Button4.Visible = true;

                    Button5.Visible = true;

        }       
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
    }
}