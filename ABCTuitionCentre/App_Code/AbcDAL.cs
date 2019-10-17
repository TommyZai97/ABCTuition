using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

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
        AbcConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ABCLaptop"].ToString();
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
    #endregion
}