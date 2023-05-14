using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestiondeStock
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"SHINERPC\SQLEXPRESS";
            string database = "LACAMIONNETTE";
            //string username = "SHINERPC'\'Essi Chaïner KOMISSA";
            //string password = "";
            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
