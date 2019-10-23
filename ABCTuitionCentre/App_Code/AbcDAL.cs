using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using Telerik.Web.UI;

/// <summary>
/// Summary description for AbcDAL
/// </summary>
public class AbcDAL
{

    private string _AbcConnectionString;
    public string AbcConnectionString
    {
        get { return _AbcConnectionString; }
        set { _AbcConnectionString = value; }
    }

    public AbcDAL(string UserID)
    {
        
        AbcConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ABC"].ToString();
        //change the Database if it is NOT ABC Tuition Centre
        
    }


    #region Student
    public DataTable PopulateStudent()
    {
        SqlConnection MyCon = new SqlConnection(AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelStudentsAll", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");

        try
        {
            MyCon.Open();

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At SelStudentsAll : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;
    }

    public int AddStudentMaster(string StudentName,string PhoneNo,string Address,DateTime DOB,string CreatedBy)
    {
        int StudentCodeID = 0;
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("AddStudentMaster", MyCon);
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCon.Open();

        try
        {
            MyCmd.Parameters.AddWithValue("@StudentName", StudentName);
            MyCmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            MyCmd.Parameters.AddWithValue("@Address", Address);
            MyCmd.Parameters.AddWithValue("@DOB", DOB);
            MyCmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            StudentCodeID = Convert.ToInt32(MyCmd.ExecuteScalar());
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At AddStudentMaster : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }

        return StudentCodeID;
    }

    public DataTable SelectStudentMasterByID(string StudentID)
    {
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelAllStudentbyID", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCmd.Parameters.AddWithValue("@StudentID", StudentID);
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");

        try
        {
            MyCon.Open();

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At GetAllRequestMasterByWorkType : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;

    }

    public void BindStudentCombobox(RadComboBox RCBStudentName)
    {
        SqlConnection conn = new SqlConnection(AbcConnectionString);
        SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID,StudentName From StudentMaster", conn);
        DataTable links = new DataTable();
        da.Fill(links);
        RCBStudentName.DataTextField = "StudentName";
        RCBStudentName.DataValueField = "StudentID";
        RCBStudentName.DataSource = links;
        RCBStudentName.DataBind();
    }

    public DataTable SelectStudentByUserPass(string Username,string Password)
    {
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("VerifyStudentLogin", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCmd.Parameters.AddWithValue("@Username", Username);
        MyCmd.Parameters.AddWithValue("@Password", Password);
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");

        try
        {
            MyCon.Open();

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At GetAllRequestMasterByWorkType : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;

    }

    public string UpdateStudentAuth(string StudentID,int AuthorityID)
    {
        string code = "";
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("UpdStudentAuthority", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCmd.Parameters.AddWithValue("@StudentID", StudentID);
        MyCmd.Parameters.AddWithValue("@AuthorityID", AuthorityID);
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");

        try
        {
            MyCon.Open();

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At GetAllRequestMasterByWorkType : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return code;

    }
    #endregion
    #region Subject
    public int AddSubjectMaster(string SubjectName)
    {
        int SubjectCode = 0;
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("AddSubjectMaster", MyCon);
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCon.Open();

        try
        { 
            MyCmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            SubjectCode = Convert.ToInt32(MyCmd.ExecuteScalar());
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At AddStudentMaster : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }

        return SubjectCode;
    }

    public DataTable PopulateSubject()
    {
        SqlConnection MyCon = new SqlConnection(AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelSubjectMaster", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");

        try
        {
            MyCon.Open();

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At SelStudentsAll : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;
    }
    public DataTable SelectSubjectMasterByID(string SubjectID)
    {
        SqlConnection MyCon = new SqlConnection(AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelSubjectMasterByID", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");
        MyCon.Open();
        try
        {
            MyCmd.Parameters.AddWithValue("@SubjectID", SubjectID);

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At SelSubjectMasterByID : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;
    }
    public void BindSubjectComboBox(RadComboBox RCBSubjectName)
    {
        SqlConnection conn = new SqlConnection(AbcConnectionString);
        SqlDataAdapter da = new SqlDataAdapter("SELECT SubjectID,SubjectName From SubjectMaster", conn);
        DataTable links = new DataTable();
        da.Fill(links);
        RCBSubjectName.DataTextField = "SubjectName";
        RCBSubjectName.DataValueField = "SubjectID";
        RCBSubjectName.DataSource = links;
        RCBSubjectName.DataBind();
    }

    public int UpdateSubjectMaster(string SubjectID,string SubjectName)
    {
        int SubjectCode = 0;
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("UpdSubjectMaster", MyCon);
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCon.Open();

        try
        {
            MyCmd.Parameters.AddWithValue("@SubjectID", SubjectID);
            MyCmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            SubjectCode = Convert.ToInt32(MyCmd.ExecuteScalar());
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At AddStudentMaster : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }

        return SubjectCode;
    }  
    public int DeleteSubjectMaster(string SubjectID)
    {
        int SubjectCode = 0;
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("DelSubjectMaster", MyCon);
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCon.Open();

        try
        {
            MyCmd.Parameters.AddWithValue("@SubjectID", SubjectID);
         
            SubjectCode = Convert.ToInt32(MyCmd.ExecuteScalar());
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At DelSubjectMaster : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }

        return SubjectCode;
    }

    #endregion
    #region Class
    public int AddClassMaster(string ClassName,string SubjectID,string StudentID)
    {
        int SubjectCode = 0;
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("AddClassMaster", MyCon);
        MyCmd.CommandType = CommandType.StoredProcedure;
        MyCon.Open();

        try
        {
            MyCmd.Parameters.AddWithValue("@ClassName", ClassName);
            MyCmd.Parameters.AddWithValue("@SubjectID", SubjectID);
            MyCmd.Parameters.AddWithValue("@StudentID", StudentID);
            SubjectCode = Convert.ToInt32(MyCmd.ExecuteScalar());
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At AddClassMaster : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }

        return SubjectCode;
    }

    public DataTable PopulateClass()
    {
        SqlConnection MyCon = new SqlConnection(AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelClassMaster", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");

        try
        {
            MyCon.Open();

            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At SelClassMaster : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;
    }

    #endregion
    #region Attendance
    public DataTable PopulateAttendanceByStudentID(string StudentID)
    {
        SqlConnection MyCon = new SqlConnection(AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelAttendanceByStuID", MyCon);
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable ResultDataTable = new DataTable("ResultDataTable");
        MyCon.Open();
        try
        {
            
            MyCmd.Parameters.AddWithValue("@StudentID", StudentID);
            MyDA.Fill(ResultDataTable);
        }
        catch (Exception e)
        {
            throw new Exception("DB Operation Error At SelAttendanceByStuID : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
        return ResultDataTable;
    }

    public void BindAttendanceComboBox(RadComboBox RCBSubjectName)
    {
        SqlConnection conn = new SqlConnection(AbcConnectionString);
        SqlCommand MyCmd = new SqlCommand("SelAttendanceByStuID");
        MyCmd.CommandTimeout = 600;
        MyCmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter MyDA = new SqlDataAdapter(MyCmd);
        DataTable links = new DataTable();
        MyDA.Fill(links);
        RCBSubjectName.DataTextField = "Attendance";
        RCBSubjectName.DataValueField = "AttendanceID";
        RCBSubjectName.DataSource = links;
        RCBSubjectName.DataBind();
    }

    #endregion
}