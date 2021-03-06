using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
namespace EmployeePro.Factory
{
   public class Repository<T> : Database, IRepository<T> where T : class
    {
        private IDbConnection connection = new SqlConnection(conVal("EmployeePro"));
       
        public void Execute(string sqlstr)
        {
            connection.Execute(sqlstr);
        }

        public void ExecuteParam(string sqlstr, object param)
        {
            connection.Execute(sqlstr, param);
        }

        public IEnumerable<T> GetAll(string sqlstr)
        {
           return connection.Query<T>(sqlstr);
        }

        public IEnumerable<T> GetById(string sqlstr, object param)
        {
            return connection.Query<T>(sqlstr, param);
        }
    }
}
