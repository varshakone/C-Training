using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectedArchitectureLibrary;

namespace ConnectedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EmployeeDBManipulation employeeDBManipulation = new EmployeeDBManipulation();
                employeeDBManipulation.getEmployeeDetails();

                //employeeDBManipulation.newEmployee(new Employee()
                //{
                //    Name = "Zafar",
                //    Salary = 100000,
                //    Address = "MP",
                //    ManagerID = 100
                //}

                //);

                //employeeDBManipulation.editEmployee(new Employee()
                //{
                //   ID = 1002,
                //    Salary = 50000,
                //    Address = "UP",

                //});

                // employeeDBManipulation.removeEmployee(1002);
                //employeeDBManipulation.maxSalary();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
