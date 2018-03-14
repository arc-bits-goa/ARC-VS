using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ARCSoftware
{
    class DataAccess
    {
        public List<Student> GetStudents()
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataConnect")))
                {
                return connection.Query<Student>($"select * from table").ToList();
                }
            }
    }
}
