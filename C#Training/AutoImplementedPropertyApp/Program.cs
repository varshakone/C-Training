using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedPropertyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM kotakATM = new ATM();
            Bank bank = new Bank();
            bank.bankID = 1234; bank.bankName = "SBI";
            bank.accountNumber = "ac15984";
             var result = kotakATM.Withdraw(5647, 45000, bank);
            Console.WriteLine( result );
            Console.ReadKey();

        }
    }
}
