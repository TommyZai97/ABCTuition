using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_EnrollSubject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        if (!IsPostBack)
        {
            MyDAL.BindSubjectComboBox(RCBSubject);
            MyDAL.BindStudentCombobox(RCBStudent);
        }
        
    }

    protected void RCBSubject_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        //after selection student combobox will populate student that havent registered in this subject
        AbcDAL MyDAL = new AbcDAL("");
        //MyDAL.BindSubjectComboBox(RCBStudent);


    }
    protected void RBSubmit_Click(object sender, EventArgs e)
    {
        int count = 0;
        int countStopper = 0;
        string StudentID = "";
        string SubjectID = "";
        string SubjectName = "";
        AbcDAL MyDAL = new AbcDAL("");
        DataTable ResultTable = MyDAL.PopulateClass();
        DataTable ResultTableSubject = MyDAL.SelectSubjectMasterByID(RCBSubject.SelectedValue.ToString().Trim());
        foreach (DataRow row in ResultTable.Rows)
        {
            SubjectName = ResultTableSubject.Rows[0]["SubjectName"].ToString().Trim();
            SubjectID = ResultTable.Rows[count]["SubjectID"].ToString().Trim();
            StudentID = ResultTable.Rows[count]["StudentID"].ToString().Trim();
            if (StudentID == RCBStudent.SelectedValue.ToString().Trim() && SubjectID == RCBSubject.SelectedValue.ToString().Trim())
            {
                countStopper++;
            }
            count++;
        }
        if (countStopper >= 1)
        {
            Response.Redirect("EnrollSubject.aspx?MsgPos=5&MsgType=warning&MsgContent=Student already exists in " + SubjectName.Trim());

        }
        else
        {
            MyDAL.AddClassMaster("Classs A", RCBSubject.SelectedValue, RCBStudent.SelectedValue);
            Response.Redirect("EnrollSubject.aspx?MsgPos=5&MsgType=warning&MsgContent=Success in Enrollment");
        }


    }
}