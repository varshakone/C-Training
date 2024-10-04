using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceLibrary
{
    enum employeeType { Full_Time, Part_Time}
  public  class Employee
    {
        //attributes
        protected int Emp_Id;
        string Name;
        String Address;
        public Employee()
        {
            Console.WriteLine( "Employee Default constructor" ); 
        }
        public Employee(string name, string address)
        {
            Name= name;
            Address= address;
        }

        public Employee(int id,string name, string address)
        {
            Emp_Id= id;
            Name = name;
            Address = address;
        }

        //method
        public String employeeDetails(int emp_id)
        {
            //filter employee in DB
            return this.Emp_Id+" "+this.Name + " "+this.Address;
        }
        public salary calculateSalary(int emp_id)
        {
            
            
            salary salary = new salary();
            salary.basicSalary = 35000;
            salary.TA =salary.basicSalary* 10/100;
            salary.DA = salary.basicSalary * 10 / 100;
            salary.HRA= salary.basicSalary * 10 / 100;
            salary.Tax= salary.basicSalary * 10 / 100;
            salary.PF = 1000;
            salary.grossSalary = salary.basicSalary + salary.TA+ salary.DA+ salary.HRA;
            salary.netSalary = salary.grossSalary-(salary.Tax+salary.PF);
            return salary;

        }
       
    }
}
