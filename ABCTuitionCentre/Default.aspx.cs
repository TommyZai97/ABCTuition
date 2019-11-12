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
        AbcDAL MyDAL = new AbcDAL("");
        if (!IsPostBack)
        {
            PopulateStudentName();
        }
    }

    public void PopulateStudentName()
    {
        int Present = 0;
        int Absent = 0;
        int count = 0;
        AbcDAL MyDAL = new AbcDAL("");

        DataTable ResultTable = MyDAL.SelectStudentByAuthID(1);
        if (ResultTable.Rows.Count != 0) {
            string StudentID = ResultTable.Rows[0]["StudentID"].ToString().Trim();

            RLName.Text = ResultTable.Rows[0]["StudentName"].ToString();
            DataTable ResultTableClass = MyDAL.PopulateClassByStudentID(StudentID);

            string Attendance = ResultTableClass.Rows[0]["Attendance"].ToString().Trim();
            foreach (DataRow row in ResultTableClass.Rows)
            {
                if (ResultTableClass.Rows[count]["Attendance"].ToString().Trim() == "Present")
                {
                    Present++;
                }
                else
                {
                    Absent++;
                }
                count++;
            }
            if (Present == Absent)
            {
                RLAttendance.Text = "Fair";
            }

            else if (Present > Absent)
            {
                RLAttendance.Text = "Good";
            }
            else
            {
                RLAttendance.Text = "Poor";
            }
        }
        else
        {
            RLName.Text = "Super Admin";
            RLAttendance.Text = "Super Admin has Logged in";
        }
    }

}