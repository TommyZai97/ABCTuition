using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_Progress : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            StudentSearchBox();
        }
    }

    public void StudentSearchBox()
    {
        AbcDAL MyDAL = new AbcDAL("");

        DataTable ResultTable = MyDAL.PopulateStudent();
        MyDAL.BindStudentCombobox(RCBStudentName);
        
    }



    protected void RCBStudentName_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {

    }
}