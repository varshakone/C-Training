using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarAndDynamicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Object obj = new Object();
            
            // set type of variable at compile time
            var generic = 10;

            var generic1 = 20.2F;

            var generic2 = "Abhay";

            var generic3 = 'a';
            System.Console.WriteLine(  generic3.GetType());

            //set type of variable as decimal at runtime
            dynamic generic4 = 123.15M;
            System.Console.WriteLine(generic4.GetType());

            //Change type of variable as string at runtime
            Console.WriteLine(  "Inpu value for generic4 ");
            generic4 = Console.ReadLine();
            System.Console.WriteLine(generic4.GetType());
            System.Console.WriteLine(generic4.ToString() );
            Console.WriteLine($"System date and time is:{DateTime.Now.ToString("dd-MMM-yyyy")} Year={DateTime.Now.Year} Month={DateTime.Now.Month} Day={DateTime.Now.Day}");
            System.Console.ReadKey();

        }
    }
}
