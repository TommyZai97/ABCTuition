using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AbcDAL
/// </summary>
public class AbcDAL
{
    public string _AbcConnectionString
    {
        get { return _AbcConnectionString; }
        set { _AbcConnectionString = value; }
    }

    public AbcDAL(string UserID)
    {
        _AbcConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CRS"].ToString();
        //change the Databse if it is NOT Arachem
        
    }

    #region Student
    public void PopulateStudent()
    {
        SqlConnection MyCon = new SqlConnection(_AbcConnectionString);
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
            throw new Exception("Cant Find SelStudentsAll : " + e.Message);
        }
        finally
        {
            MyCon.Close();
            MyCon.Dispose();
            MyCmd.Dispose();
        }
    }

    #endregion
}