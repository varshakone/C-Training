using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declaring anonymus type

            var employee = new
            {
                FirstName = "Tanay",
                LastName = "Shrivastava"

            };

            //Try to modify the values
            //employee.FirstName = "Tanaygeet";

            Console.WriteLine($"First Name : {employee.FirstName} \n Last NAme : {employee.LastName}"  );

            Console.ReadKey();
        }
    }
}
