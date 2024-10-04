using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceLibrary
{
    public class FullTime :Employee
    {
        employeeType employeeType;
        public FullTime(int id, string name, string address):base(id,name,address)
        {
            Console.WriteLine("Fullt Time Employee "+  base.employeeDetails(101));
        }
    }
}
