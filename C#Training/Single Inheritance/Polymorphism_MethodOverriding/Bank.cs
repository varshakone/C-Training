using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_MethodOverriding
{
    internal class Bank
    {
        public virtual void statement(int acnumber)
        {
            Console.WriteLine( "saving Account Statement" );
        }
    }

    internal class  SBI: Bank
    {
        //override the method

        public override void statement(int acnumber)
        {
            base.statement(acnumber);
            Console.WriteLine( "current account statement" );
        }

    }

    internal class Axis : Bank
    {

        public override void statement(int acnumber)
        {
            
            Console.WriteLine( "loan account statement" );
        }
    }
}
