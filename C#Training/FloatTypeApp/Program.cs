using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float data types

            Console.WriteLine(  "input value");
             string num= Console.ReadLine();

            float number1 = 1F/Convert.ToSingle(num) ;
            double number2 = 1D / 3;
            Decimal number3 = 1M / 3;

            string format = string.Format("Number 1 {0} Number2 {1} Number3 {2}", number1, number2, number3);
            Console.WriteLine( format);

           

            Console.ReadKey();
        }
    }
}
