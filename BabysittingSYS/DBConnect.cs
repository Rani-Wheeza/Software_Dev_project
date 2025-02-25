using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    class DBConnect
    {
        //public const String oradb = "Data Source = localHost/orcl; User Id = C##User1; Password = 1234567;";

        public const String oradb = "Data Source = studentoracle:1521/orcl; User Id = T002793; Password = ca4#dd;";

        //public const String oradb = "Data Source = studentoracle/orcl; User Id = Leccw; Password = 1234567;";

       /* public OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }*/ //working on it

    }
}
