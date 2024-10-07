using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelApp
{

    internal class Program
    {

      static  bool checkVal(string str)
        {
            bool isString = false;
            if (str != null)
            {
                isString= true;
            }
            return isString;
        }
        static void Main(string[] args)
        {

            Func<string, bool> func = checkVal;
            Console.WriteLine(func(null));

            //predicate

            Predicate<string> predicate = checkVal;
            Console.WriteLine(predicate("abcd"));


            Console.ReadKey();
        }
    }
}
