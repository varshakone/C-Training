using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectedDBWithConfig;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name= "Test1";
            employee.Salary = 10000;
            employee.Address = "xyz1";
            employee.ManagerID = 2;

            EmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeService employeeService =new EmployeeService();
            employeeService.EmployeeRepository = employeeRepository;
           
            Console.WriteLine(employeeService.newEmployee(employee));

            Console.ReadKey();
        }
    }
}
