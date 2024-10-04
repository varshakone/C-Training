using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Employee
    {
        protected int Emp_Id;
        string Name;
        String Address;

        public Employee(int id, string name, string address)
        {
            this.Emp_Id = id;
            this.Name = name;
            this.Address = address;
        }
        public String employeeDetails(int emp_id)
        {
            //filter employee in DB
            return this.Emp_Id + " " + this.Name + " " + this.Address;
        }
    }
}
