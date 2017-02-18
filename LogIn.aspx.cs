using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void LogInUser(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        conn.Open();

        string checkuser = "select count (*) from Users where Username='" + txtUsername.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();

        if(temp==1)
        {
            conn.Open();
            string checkPasswordQuery = "Select Password from Users where Username='" + txtUsername.Text + "'";
            SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
            string password = passComm.ExecuteScalar().ToString();

            if(password == txtPassword.Text)
            {
                Session["New"] = txtUsername.Text;
                string takeIDQuerry = "Select UserId from Users where Username='" + txtUsername.Text + "'";
                SqlCommand idComm = new SqlCommand(takeIDQuerry, conn);
                string id = idComm.ExecuteScalar().ToString();
                Session["id"] = id;
                Response.Redirect("~/default.aspx");
                
            }

            else
            {
                Response.Write("Password is not correct!");
            }

        }

        else
        {
            Response.Write("Username is not corrrect!");
        }
    }

 }
