using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

public partial class Administrator_SubjectTool : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        if (!IsPostBack)
        {
           // PopulateSubjectGrid();
            MyDAL.BindSubjectComboBox(RCBSubjectName);
        }
    }

    protected void RBCreateSubject_Click(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        MyDAL.AddSubjectMaster(RTBSubjectName.Text.Trim());
        PopulateSubjectGrid();
        MyDAL.BindSubjectComboBox(RCBSubjectName);
    }

    public void PopulateSubjectGrid()
    {
        AbcDAL MyDAL = new AbcDAL("");
        RGSubjectGrid.DataSource = MyDAL.PopulateSubject();
        RGSubjectGrid.DataBind();
    }




    protected void RBUpdate_Click(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        MyDAL.UpdateSubjectMaster(RCBSubjectName.SelectedValue, RTBUpdateName.Text);
        MyDAL.BindSubjectComboBox(RCBSubjectName);
        PopulateSubjectGrid();
    }

    protected void RCBSubjectName_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RTBUpdateName.Text = RCBSubjectName.SelectedItem.Text;
    }



    protected void RGSubjectGrid_DeleteCommand(object sender, GridCommandEventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        Telerik.Web.UI.GridDataItem MyGridDataItem = e.Item as Telerik.Web.UI.GridDataItem;
        if (MyGridDataItem != null)
        {
            string SubjectID = (string)((GridDataItem)e.Item).GetDataKeyValue("SubjectID");

            
            MyDAL.DeleteSubjectMaster(SubjectID);
        }
        MyDAL.BindSubjectComboBox(RCBSubjectName);
    }


    protected void RGSubjectGrid_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        RGSubjectGrid.DataSource = MyDAL.PopulateSubject();
        
    }
}