using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConnectedDBWithConfig
{
    public class EmployeeRepository
    {

        public string newEmployee(Employee employee)
        {
            string message =null;
            using(SqlConnection connection= DBUtil.SqlConnection)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "newEmployeeProcedure";
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@name",employee.Name);
                cmd.Parameters.AddWithValue("@address", employee.Address);
                cmd.Parameters.AddWithValue("@salary", employee.Salary);
                cmd.Parameters.AddWithValue("@mID", employee.ManagerID);
                int countOfRows= cmd.ExecuteNonQuery();
                if (countOfRows > 0)
                {
                    message = "New Employee Added";
                }

            }
            return message;
        }

    }
}
