using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConnectedArchitectureLibrary
{
    public static class DBUtil
    {
        
        public static SqlConnection getDBConnection()
        {
            SqlConnection conn;
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MyTrainingDB;Integrated Security=True";
            conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            return conn;
        }
    }
}
