using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void gotoreg_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Registration.aspx");
    }
    protected void gotologin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/LogIn.aspx");
    }
}