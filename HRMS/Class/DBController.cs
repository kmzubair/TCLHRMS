using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace HRMS.Class
{
    class DBController
    {
        public string GetConnectionString()
        {
            string sConnection = ConfigurationSettings.AppSettings.Get("ConnectionString");
            //string sConnection = "Provider=SQLOLEDB.1;Data Source=(local);Initial Catalog=HRMS;User ID=sa;Password=erp";
                
            return sConnection;
        }

    }
}
