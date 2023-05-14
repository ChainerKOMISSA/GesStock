using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestiondeStock
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource,string database/*,string username,string password*/)
        {
            string connection = @"Data Source = "+datasource+";Initial Catalog ="+database/*+";Persist Security Info=True;User ID=" + username + ";Password=" + password*/;
            SqlConnection connect = new SqlConnection(connection);
            return connect;
        }
        
    }
}
