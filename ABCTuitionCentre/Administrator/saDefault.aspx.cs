using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

public partial class Administrator_saDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int AuthorityID = 0;

        if (!IsPostBack)
        {
            AbcDAL MyDAL = new AbcDAL("");
            DataTable ResultTable = MyDAL.PopulateStudent();
            
            
                AuthorityID = Convert.ToInt32(ResultTable.Rows[0]["AuthorityID"]); //Getting my field value
                if (AuthorityID != 1002)
                {
                    Response.Redirect("~/default.aspx?MsgPos=5&MsgType=warning&MsgContent=You are not authorised to this function, No students allowed !!!!");

                }
            
           
        }
    }

    protected void RBEnrollStudent_Click(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        MyDAL.AddStudentMaster(RTBStudentName.Text, RTBPhoneNo.Text, RTBAddress.Text, RDPDob.SelectedDate.Value,"Tommy");

        Response.Redirect("saDefault.aspx");
    }

    public void DisplayData()
    {
        AbcDAL MyDAL = new AbcDAL("");
        DataTable ResultTable = MyDAL.PopulateStudent();
        RadGrid1.DataSource = ResultTable;
        RadGrid1.DataBind();

    }

    protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        DataTable ResultTable = MyDAL.PopulateStudent();
        RadGrid1.DataSource = ResultTable;
    }



    protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    protected void RadGrid1_SelectedCellChanged(object sender, EventArgs e)
    {
        foreach (GridDataItem item in RadGrid1.SelectedItems)
        {
            Response.Write(item["StudentName"].Text.ToString()); // CustomerID is the uniquename of column 
            string StudentName = item.GetDataKeyValue("StudentName").ToString().Trim(); // Works if you set the DataKeyValue as CustomerID 
        }
    }

    protected void RadGrid1_UpdateCommand(object sender, GridCommandEventArgs e)
    {
       
        GridEditableItem editedItem = e.Item as GridEditableItem;
        string StudentID = editedItem.GetDataKeyValue("StudentID").ToString().Trim(); // Works if you set the DataKeyValue as CustomerID 

        string name = (editedItem["StudentName"].Controls[0] as TextBox).Text;
        string address = (editedItem["Address"].Controls[0] as TextBox).Text;
        string DOB = (editedItem["DOB"].Controls[0] as TextBox).Text;
        string phoneNo = (editedItem["PhoneNo"].Controls[0] as TextBox).Text;

        AbcDAL MyDAL = new AbcDAL("");
        MyDAL.UpdStudentMaster(StudentID,name,phoneNo,address,Convert.ToDateTime(DOB));
    }
}