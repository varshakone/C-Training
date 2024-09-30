using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // object type
            Int32 MyValue = 100;

            long myVal = 10000;



            Object myObject = 2000;
            Console.WriteLine( "Object Value {0}",myObject );


            // explicit conversion
            UInt32 myUnsignedValue =(UInt32)myVal;

            //explicit convertion

            UInt32 myConversion = Convert.ToUInt32(myVal);


            //string conversion using convert class

            Console.WriteLine( "Enter value for number" );
            string firstNumber = Console.ReadLine();

            Int64 myNumber=  Convert.ToInt64(firstNumber);

            Console.WriteLine( "String conversion using Convert class {0}",myNumber );

            //string conversion using Try parse

            Console.WriteLine("Enter value for number");
            string secondNumber = Console.ReadLine();
           
            Console.WriteLine("String conversion {0}", myNumber);

            object myObjectReference = new object();
            myObjectReference = myUnsignedValue;
            Console.WriteLine("Object Reference type {0}", myObjectReference );
            Console.ReadKey();
        }
    }
}
