using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(2024,10,01);

            DateTime dateTime1 = Convert.ToDateTime("01/10/2024");

            //retrieve year 
            Console.WriteLine($"Year {dateTime.Year} Month {dateTime.Month} Day {dateTime.Day}"  );

            Console.WriteLine("Current Date and Time {0}",DateTime.Now);

            Console.ReadKey();
        }
    }
}
