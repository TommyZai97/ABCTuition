using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayData();   
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

  
}