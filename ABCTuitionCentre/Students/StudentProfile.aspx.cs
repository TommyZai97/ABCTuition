using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students_StudentProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //PopulateStudentName();
        if (!IsPostBack)
        {
            AbcDAL MyDAL = new AbcDAL("");
            MyDAL.BindSubjectComboBox(RCBSubject);
        }
    }

    public void PopulateStudentName()
    {
        AbcDAL MyDAL = new AbcDAL("");
        
        DataTable ResultTable =  MyDAL.SelectStudentByAuthID(1);
        string StudentID = ResultTable.Rows[0]["StudentID"].ToString().Trim();

        RLStudentName.Text = ResultTable.Rows[0]["StudentName"].ToString();
        DataTable ResultTableClass = MyDAL.PopulateClassByStudentIDSubjectID(StudentID,RCBSubject.SelectedValue.ToString().Trim());

        if (ResultTableClass.Rows.Count != 0)
        {
            RLGrade.Text = ResultTableClass.Rows[0]["Grade"].ToString();
            RLAttendance.Text = ResultTableClass.Rows[0]["Attendance"].ToString().Trim();
        }
        else
        {
            RLGrade.Text = "No record yet";
            RLAttendance.Text = "No record yet";
        }
         
        
    }

    protected void RCBSubject_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        PopulateStudentName();
    }

 

}