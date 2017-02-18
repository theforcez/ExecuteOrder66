using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class ActivationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*  if (!this.IsPostBack)
          {
              string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
              string activationCode = !string.IsNullOrEmpty(Request.QueryString["ActivationCode"]) ? Request.QueryString["ActivationCode"] : Guid.Empty.ToString();
              using (SqlConnection con = new SqlConnection(constr))
              {
                  using (SqlCommand cmd = new SqlCommand("DELETE FROM UserActivation WHERE ActivationCode = @ActivationCode"))
                  {
                      using (SqlDataAdapter sda = new SqlDataAdapter())
                      {
                          cmd.CommandType = CommandType.Text;
                          cmd.Parameters.AddWithValue("@ActivationCode", activationCode);
                          cmd.Connection = con;
                          con.Open();
                          int rowsAffected = cmd.ExecuteNonQuery();
                          con.Close();
                          if (rowsAffected == 1)
                          {
                              ltMessage.Text = "Activation successful.";
                          }
                          else
                          {
                              ltMessage.Text = "Invalid Activation code.";
                          }
                      }
                  }
              }
          }
       */
        if(Session["New"] != null)
        {
            Label_welcome.Text += Session["New"].ToString();
        }
        else
            Response.Redirect("~/LogIn.aspx");
    }
    protected void b_logout_Click(object sender, EventArgs e)
    {

        Session["New"] = null;
        Response.Redirect("~/LogIn.aspx");
    }
    protected void Send_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(constr))
      {
          SqlCommand cmd = new SqlCommand("INSERT INTO Orders (OrderInfo, UserId) VALUES (@order, @id)");
          cmd.CommandType = CommandType.Text;
          cmd.Connection = connection;
          cmd.Parameters.AddWithValue("@order", order.Text);
          cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
            if(@order.Text != "")
            { 
          connection.Open();
          cmd.ExecuteNonQuery();
          Response.Redirect("~/default.aspx");
            }
            else
            {
                Response.Redirect("~/default.aspx");
                string script = "alert(\"You can't send empty order! Ex: Order 66!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                
            }
      }

    }
}