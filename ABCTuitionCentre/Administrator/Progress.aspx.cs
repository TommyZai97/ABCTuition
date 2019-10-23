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
            SubjectCombobox();
        }
    }

    public void StudentSearchBox()
    {
        AbcDAL MyDAL = new AbcDAL("");

        DataTable ResultTable = MyDAL.PopulateStudent();
        MyDAL.BindStudentCombobox(RCBStudentName);
        
    }

    public void SubjectCombobox()
    {
        AbcDAL MyDAL = new AbcDAL("");
        MyDAL.BindSubjectComboBox(RCBSubject);

    }


    protected void RCBStudentName_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        string Attendance = "";
        
        RLStudentName.Text = RCBStudentName.Text;
        AbcDAL MyDAL = new AbcDAL("");
        DataTable ResultTable = new DataTable();
        ResultTable = MyDAL.PopulateAttendanceByStudentID(RCBStudentName.SelectedValue.ToString().Trim());
        int count = 0;
        foreach (DataRow row in ResultTable.Rows)
        {
            Attendance = ResultTable.Rows[count]["Attendance"].ToString().Trim();
            if (RCBSubject.SelectedValue.ToString().Trim() == ResultTable.Rows[count]["SubjectID"].ToString().Trim())
            {
                if (Attendance == "Present")
                {
                    RDDLAttendance.SelectedIndex = 0;
                }
                else if (Attendance == "Absent")
                {
                    RDDLAttendance.SelectedIndex = 1;
                }
                else
                {
                    RDDLAttendance.SelectedIndex = 2;
                }
            }
            count++;
        }
    }

    protected void RBModify_Click(object sender, EventArgs e)
    {

    }
}