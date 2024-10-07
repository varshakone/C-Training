using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp
{
    //Step 1 create static class

    static class NewMethodToObject
    {
        static NewMethodToObject()
        {
            Console.WriteLine( "Static class" );
        }
        //step2 define static method with binding parameter
        public static int Adiition(this Object obj,int number1, int number2, int number3)
        {
            return  number1 + number2+number3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new Object();
            var result = obj.Adiition(10, 20, 30);
            Console.WriteLine(result);

            Console.ReadKey();
            
        }
    }
}
