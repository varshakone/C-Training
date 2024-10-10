using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArchitectureLibrary
{
    public class EmployeeDBManipulation
    {
        //open connection
       
        
        
        public void getEmployeeDetails()
        {
            //open the connection
            using(var conn = DBUtil.getDBConnection())
            {
                conn.Open();

                //fire query
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Employee";
                cmd.Connection = conn;

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                Console.WriteLine("Employee ID\tEmployee Name\tEmployee Address\tEmployee Salary\tEmployee Manager ");

                Console.WriteLine("Column Ordinal " + sqlDataReader.GetOrdinal("Emp_Name") + sqlDataReader.GetSqlString(0));
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["Emp_ID"] + "\t\t " + sqlDataReader[1]

                        + "\t \t " + sqlDataReader[2] + "\t\t " + sqlDataReader[3] + "\t\t " + sqlDataReader[4]);
                }


                sqlDataReader.Close();


            }



            //can't reread record as reader is closed / you can read sequentially
            //while (sqlDataReader.Read())
            //{
            //    Console.WriteLine(sqlDataReader["Emp_ID"] + "\t" + sqlDataReader[1]

            //        + "\t" + sqlDataReader[2] + "\t " + sqlDataReader[3] + "\t" + sqlDataReader[4]);
            //}


            //close the connection
            
        }

        public void newEmployee(Employee employee)
        {
            //open the connection
            DBUtil.getDBConnection().Open();

            //fire query
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "insert into employee values('"+employee.Name+"','"+employee.Address+"','"+employee.Salary+"','"+employee.ManagerID+"')";
           cmd.Connection = DBUtil.getDBConnection();
           int count= cmd.ExecuteNonQuery();
            if(count==1)
            {
                Console.WriteLine( "\n \n New Employee inserted");
            }
            //close the connection
           DBUtil.getDBConnection().Close();

            getEmployeeDetails();
            
        }

        public void editEmployee(Employee employee)
        {
            //open the connection
            DBUtil.getDBConnection().Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update employee set Emp_Address='" + employee.Address + "',Emp_Salary ='" + employee.Salary + "' where Emp_Id='"+employee.ID+"'";
            cmd.Connection = DBUtil.getDBConnection();
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                Console.WriteLine("\n \n  Employee details updated");
            }
            //close the connection
            DBUtil.getDBConnection().Close();

            getEmployeeDetails();

        }

        public void removeEmployee(int id)
        {
            //open the connection
            DBUtil.getDBConnection().Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from employee where Emp_Id='" + id + "'";
            cmd.Connection = DBUtil.getDBConnection()   ;
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                Console.WriteLine("\n \n  Employee removed");
            }
            //close the connection
          DBUtil.getDBConnection ().Close();

            getEmployeeDetails();

        }

        public void maxSalary()
        {
            //open the connection
           var conn = DBUtil.getDBConnection();
            conn.Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select MAX(Emp_Salary) from employee";
            cmd.Connection = conn;
            var maxsalary = cmd.ExecuteScalar();
            Console.WriteLine("\n \n  Employee with maximum salary {0}",maxsalary);

            //close the connection
            conn.Close();

            getEmployeeDetails();

        }
    }
}
