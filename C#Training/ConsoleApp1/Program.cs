using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calculateValue(1,2,3,4);
            calculateValue('c','d','f');
            calculateValue(1,2,"abhay","Singh");
            Console.ReadKey();
        }

        static void calculateValue(int num1,int num , params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(" " + items[i] );
            }
            Console.WriteLine( "\n" );
        }
    }
}
