using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
   abstract class Bank
    {
        //field member
         int bankId;
         string bankName;
         string bankLocation;

        protected Bank()
        {
            bankId = 123;
            bankName = "bank";
            bankLocation = "xyz";
        }

        protected Bank(int id, string name, string address)
        {
            this.bankId = id;
            this.bankName = name;
            this.bankLocation = address;
        }
        //abstract method
        public abstract string statement(int acnumber);

        //non-abstract method
        public string credit(int acnumber)
        {
            return "ammount credited";
        }

    }

    class statement
    {

    }
    class Axis : Bank
    {

        public Axis(int id, string name, string address):base(id, name,address)
        {
            
        }
        public string credit(int acnumber)
        {
            return base.credit(acnumber);
        }
        public override string statement(int acnumber)
        {
            return "Satement from axis bank";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Axis(101,"Axis","Bhopal");
            Console.WriteLine(   bank.credit(1010));
            Console.WriteLine(   bank.statement(1010));

            Console.ReadKey();
        }
    }
}
