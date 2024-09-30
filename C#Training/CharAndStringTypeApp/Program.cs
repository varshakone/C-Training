using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndStringTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char grade = 'A';
            string studentName = "Abhijeet";
            string status = "Not valid";
            

        }

        void validateStudent(string studentName,string status)
        {
            // code for validating user
            bool valid = false;
            valid = int.TryParse(studentName, out int result);
            if (!valid)
                {
                status = "Valid student";
                }

        }
    }
}
