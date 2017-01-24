using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Configuration;

namespace HRMS
{
    class dbConnection
    {

        public string cnnStr = "";

        public SqlConnection dbConnect()
        {
            //cnnStr = "Data Source = (local)"; ;
            //cnnStr += "; Integrated Security = True";
            //cnnStr += "; User ID = sa";
            //cnnStr += "; Password = erp";

            cnnStr = ConfigurationSettings.AppSettings.Get("SqlString");

            return new SqlConnection(cnnStr);
        }

    }
}
