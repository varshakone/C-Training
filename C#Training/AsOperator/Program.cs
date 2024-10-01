using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsOperator
{
    class Training
    {
        public Training() {
            Console.WriteLine("Dot Net Training");

        }
    }

    class DotNet : Training
    {
        public DotNet()
        {
            Console.WriteLine( "Dot Net Training" );
        }
    }
    class Java
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //long number = 1478965432;

            //int number2 = number as Int32; 

            Training training = new Training();

            DotNet dotNet = training as DotNet;

            DotNet dotNet1 = new DotNet();

            training = dotNet1;

            Java dotNet2 = training as Java;

            Console.ReadKey();
        }
    }
}
