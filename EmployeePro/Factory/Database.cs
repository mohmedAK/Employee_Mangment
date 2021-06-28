using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeePro.Factory
{
   public class Database
    {
       public static string conVal(string conStr)
        {
            return ConfigurationManager.ConnectionStrings[conStr].ConnectionString;
        }
    }
}
