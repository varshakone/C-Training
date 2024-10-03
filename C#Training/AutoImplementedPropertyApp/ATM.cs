using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedPropertyApp
{
    internal class ATM
    {
        int pin;
        Int64 amount;
        Bank bank;

        public ATM()
        {
            pin = 100;
            amount = 100;
        }
        public ATM(int pin, long amount, Bank bank)
        {
            this.pin = pin;
            this.amount = amount;
            this.bank = bank;
            
        }


        internal string Withdraw(int pin, long amount, Bank bank)
        {
            return "Withdraw process Successful";

        }



    }
}
