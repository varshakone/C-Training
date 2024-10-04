using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bank bank1 = new Bank();
            //bank1.statement(1234);

            //Bank sBI = new SBI();
            //sBI.statement(1234);

            Bank bank = new Axis();
            bank.statement(1234);

            Axis axis = bank as Axis;
            axis.statement(1234);

            Console.ReadKey();
        }
    }
}
