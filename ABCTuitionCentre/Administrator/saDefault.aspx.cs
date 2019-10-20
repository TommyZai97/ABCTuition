using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_saDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int AuthorityID = 0;

        if (!IsPostBack)
        {
            AbcDAL MyDAL = new AbcDAL("");
            DataTable ResultTable = MyDAL.PopulateStudent();
            
            foreach (DataRow row in ResultTable.Rows)
            {
                AuthorityID = Convert.ToInt32(row["AuthorityID"]); //Getting my field value
                if (AuthorityID != 1002)
                {
                    Response.Redirect("~/default.aspx?MsgPos=5&MsgType=warning&MsgContent=You are not authorised to this function, No students allowed !!!!");

                }
            }
           
        }
    }

    protected void RBEnrollStudent_Click(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        MyDAL.AddStudentMaster(RTBStudentName.Text, RTBPhoneNo.Text, RTBAddress.Text, RDPDob.SelectedDate.Value,"Tommy");

        Response.Redirect("saDefault.aspx");
    }
}