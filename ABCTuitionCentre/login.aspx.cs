using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RBLogin_Click(object sender, EventArgs e)
    {
        if(RTBUsername.Text == "user" && RTBPassword.Text == "123")
        {
            Response.Redirect("~/default.aspx");
 
        }
    
    }
}