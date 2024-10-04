using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceLibrary
{
    public class PartTime : Employee
    {
        //additional attributes 
        int noOfHours;
        int paymentPerHour;
        Int64 payment;

        public PartTime()
        {
            noOfHours = 40;
            paymentPerHour = 100;
              
        }

        public PartTime(int id, string name,string address,int nofohours, int paymentperhour):base(name,address)
        {
            base.Emp_Id = id;
            noOfHours= nofohours;
            paymentPerHour= paymentperhour;
        }

        public string calculateSalary()
        {
            Console.WriteLine(base.employeeDetails(102));
            payment = noOfHours*paymentPerHour;
            return payment.ToString();
        }
    }
}
