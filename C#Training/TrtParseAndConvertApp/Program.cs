using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrtParseAndConvertApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "12";

            Int32 number2 = Convert.ToInt32(number);
            Console.WriteLine(  "Parsed value {0}",number2);


            Int32 number3 = int.Parse(number);
            Console.WriteLine("Parsed value {0}", number3);

            Console.ReadKey();
        }
    }
}
