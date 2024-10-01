using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Abhay";

            string myLastName = " Singh";
            string.Concat(myName, myLastName);

            Console.WriteLine("After concatination {0}", string.Concat(myName, myLastName)  );
            
            Console.WriteLine("Length of string {0} ",myName.Length );
            Console.WriteLine("the string in Lower case {0}", myName.ToLower());
            Console.WriteLine("the string in upper case {0}", myName.ToUpper());
            Console.WriteLine("the string Trim {0}", myName.Trim('y'));
            myName= String.Empty;
            Console.WriteLine("String is Empty or not {0}", myName);


            Console.ReadKey();
        }
    }
}
