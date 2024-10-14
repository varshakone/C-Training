using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectedDBWithConfig
{
   
    public static class DBUtil
    {
        readonly static SqlConnection sqlConnection;
        static DBUtil()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["MyTrainingConnection"].ConnectionString;
        }

        public static SqlConnection SqlConnection => sqlConnection;
    }
}
