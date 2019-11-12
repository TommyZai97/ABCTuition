using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_Progress : System.Web.UI.Page
{
    static string ClassID;
    protected void Page_Load(object sender, EventArgs e)
    {
        int AuthorityID = 0;
        if (!IsPostBack)
        {
            StudentSearchBox();
            SubjectCombobox();

            AbcDAL MyDAL = new AbcDAL("");
            DataTable ResultTable = MyDAL.PopulateStudent();


            AuthorityID = Convert.ToInt32(ResultTable.Rows[0]["AuthorityID"]); //Getting my field value
            if (AuthorityID != 1002)
            {
                Response.Redirect("~/default.aspx?MsgPos=5&MsgType=warning&MsgContent=You are not authorised to this function, No students allowed !!!!");

            }
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
        ResultTable = MyDAL.PopulateClassByStudentID(RCBStudentName.SelectedValue.ToString().Trim());
        int count = 0;
        int countStop = 0;
        foreach (DataRow row in ResultTable.Rows)
        { 
            Attendance = ResultTable.Rows[count]["Attendance"].ToString().Trim();
            if (RCBSubject.SelectedValue.ToString().Trim() == ResultTable.Rows[count]["SubjectID"].ToString().Trim())
            {
                DropdownlistGrade();
                ClassID = ResultTable.Rows[count]["ClassID"].ToString();
                if (Attendance == "Present")
                {
                    countStop++;
                    RDDLAttendance.SelectedIndex = 0;
                    break;
                }
                else if (Attendance == "Absent")
                {
                    countStop++;
                    RDDLAttendance.SelectedIndex = 1;
                    break;
                }
                else
                {
                    countStop++;
                    RDDLAttendance.SelectedIndex = 2;
                    break;
                }

                
            }
            
            count++;
        }

        if (countStop == 0)
        {
            RDDLAttendance.SelectedIndex = 2;
        }
    }

    protected void RBModify_Click(object sender, EventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        if (ClassID != null) 
        {
            MyDAL.UpdateClassGradeByStudentID(RCBStudentName.SelectedValue.ToString().Trim(), RDDLAttendance.SelectedText, RDDLGrade.SelectedText, ClassID);
            Response.Redirect("Progress.aspx?MsgPos=5&MsgType=warning&MsgContent=Data successfully modified");

        }
        else
        {
            Response.Redirect("Progress.aspx?MsgPos=5&MsgType=warning&MsgContent=ERROR LAH WALAO");

        }
    }

    public void DropdownlistGrade()
    {
        AbcDAL MyDAL = new AbcDAL("");
        DataTable ResultTable = new DataTable();
        ResultTable = MyDAL.PopulateClassByStudentID(RCBStudentName.SelectedValue.ToString().Trim());
        string grade;

        int count = 0;
      
        foreach (DataRow row in ResultTable.Rows)
        {
            grade = ResultTable.Rows[count]["Grade"].ToString().Trim();
            if (RCBSubject.SelectedValue.ToString().Trim() == ResultTable.Rows[count]["SubjectID"].ToString().Trim())
            {
                if (grade == "A")
                {
                    RDDLGrade.SelectedIndex = 1;
                    break;
                }
                else if (grade == "B")
                {
                    RDDLGrade.SelectedIndex = 2;
                    break;
                }
                else if (grade == "C")
                {
                    RDDLGrade.SelectedIndex = 3;
                    break;
                }
                else if (grade == "D")
                {
                    RDDLGrade.SelectedIndex = 4;
                    break;
                }
                else if (grade == "E")
                {
                    RDDLGrade.SelectedIndex = 5;
                    break;
                }
                else if (grade == "F")
                {
                    RDDLGrade.SelectedIndex = 6;
                    break;
                }
            }
            count++;
        }
    }


    protected void RGClassMaster_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        AbcDAL MyDAL = new AbcDAL("");
        RGClassMaster.DataSource = MyDAL.PopulateClass();


    }
}