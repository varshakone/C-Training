using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REfAndOutApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string status = null;
           Console.WriteLine("Current Status of order {0}",status );
            ChangeStatus(ref status);
            Console.WriteLine("Current Status of Order {0}", status);

            int num1 =10, num2=20, result =0;
            Console.WriteLine("Before calculation {0}", result);
            Addition(num1, num2, out result);
            Console.WriteLine("After calculation {0}", result);

            Console.ReadKey();
        }
       static void ChangeStatus(ref string status)
        {
           // status = "Delivered";
        }

        static void Addition(int num1, int num2,out int result)
        {
           result= num1+num2;
        }
    }
}
