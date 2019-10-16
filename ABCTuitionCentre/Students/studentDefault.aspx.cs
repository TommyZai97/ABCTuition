using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ABCtuitionCentre {
    public partial class Students_studentDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void GenerateStudentDetails()
        {
            string AccountID = Request.ServerVariables["AUTH_USER"].Substring(Request.ServerVariables["AUTH_USER"].IndexOf("\\") + 1);
            AbcDAL MyDAL = new AbcDAL(AccountID);
            MyDAL.PopulateStudent();
            
        }
    }
}