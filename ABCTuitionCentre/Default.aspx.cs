using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Charting;
using Telerik.Web.UI;

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
            Piechart();
            string StudentID = ResultTable.Rows[0]["StudentID"].ToString().Trim();

            RLName.Text = ResultTable.Rows[0]["StudentName"].ToString();
            RLPhoneNo.Text = ResultTable.Rows[0]["PhoneNo"].ToString();
            RLAddress.Text = ResultTable.Rows[0]["Address"].ToString();
            
            DataTable ResultTableClass = MyDAL.PopulateClassByStudentID(StudentID);

            //string Attendance = ResultTableClass.Rows[0]["Attendance"].ToString().Trim();
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

    public void Piechart()
    {
        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        int E = 0;
        int count = 0;
        AbcDAL MyDAL = new AbcDAL("");

        DataTable ResultTable = MyDAL.SelectStudentByAuthID(1);
        string StudentID = ResultTable.Rows[0]["StudentID"].ToString().Trim();
        DataTable ResultTableClass = MyDAL.PopulateClassByStudentID(StudentID);

        RadChart radChart = new RadChart();
        radChart.ChartTitle.TextBlock.Text = "My RadChart";
        ChartSeries chartSeries = new ChartSeries();
        chartSeries.Name = "Overall Grade";
        chartSeries.Type = ChartSeriesType.Bar;
        // add new items to the series,
        // passing a value and a label string
       
        foreach (DataRow row in ResultTableClass.Rows)
        {
            if (ResultTableClass.Rows[count]["Grade"].ToString().Trim() == "A")
            {
                A++;
                
            }
            else if (ResultTableClass.Rows[count]["Grade"].ToString().Trim() == "B")
            {
                B++;
            }
            else if (ResultTableClass.Rows[count]["Grade"].ToString().Trim() == "C")
            {
                C++;
            }
            else if (ResultTableClass.Rows[count]["Grade"].ToString().Trim() == "D")
            {
                D++;
            }
            else if (ResultTableClass.Rows[count]["Grade"].ToString().Trim() == "E")
            {
                E++;
            }
            count++;
        }
        chartSeries.AddItem(A, "A");
        chartSeries.AddItem(B, "B");
        chartSeries.AddItem(C, "C");
        chartSeries.AddItem(D, "D");
        chartSeries.AddItem(E, "E");

        RCStudent.AddChartSeries(chartSeries);
        
    }

}