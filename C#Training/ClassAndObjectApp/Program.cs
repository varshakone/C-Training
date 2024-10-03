using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndObjectApp;

namespace ProgramClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM kotakATM = new ATM();
            kotakATM._Pin = 1234;
            kotakATM._Amount = 45000;
            kotakATM.withdraw();
            Console.WriteLine("Amount {0}",kotakATM._Amount);

            Console.ReadKey();
        }
    }
}
