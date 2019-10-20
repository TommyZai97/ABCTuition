using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    private string _AbcConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        string AccountID = Request.ServerVariables["AUTH_USER"].Substring(Request.ServerVariables["AUTH_USER"].IndexOf("\\") + 1);
    }
   
    protected void RBLogin_Click(object sender, EventArgs e)
    {
        string Login = "Error";

        AbcDAL MyDal = new AbcDAL("");

       
        if (RTBUsername.Text == "user" && RTBPassword.Text == "123")
        {
            MyDal.UpdateStudentAuth("STU1000001",1002);
            Response.Redirect("~/default.aspx");
 
        }

        else 
        {
            DataTable ResultTable = MyDal.SelectStudentByUserPass(RTBUsername.Text, RTBPassword.Text);
            for (int i = 0; i < ResultTable.Rows.Count; i++) //Looping through rows
            {
                var Username = ResultTable.Rows[i]["Username"]; //Getting my field value
                var Password = ResultTable.Rows[i]["Password"]; //Getting my field value

                Login = "123";
                

            } 
            if (Login == "123")
            {
                MyDal.UpdateStudentAuth("STU1000001",1001);
                Response.Redirect("~/default.aspx");
            }
            else
            {
                
                Response.Redirect("login.aspx?MsgPos=5&MsgType=warning&MsgContent=You are not authorised to this function, User Wrong Login !!!!");

            }


        }

    }
}