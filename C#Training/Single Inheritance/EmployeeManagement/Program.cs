using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleInheritanceLibrary;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTime donetEmployee= new PartTime(101,"varsha","pune,",40,2000);
            var result = donetEmployee.calculateSalary();
            Console.WriteLine(donetEmployee.employeeDetails(101));
            Console.WriteLine(  result);


            FullTime fullTime = new FullTime(102, "Xyz", "AbC");
           var payslip= fullTime.calculateSalary(102);
            Console.WriteLine( "Pay Slip \n Basic Salary :{0}\n Net Salary :{1}",payslip.basicSalary,payslip.netSalary );
            
            Console.ReadKey();


        }
    }
}
