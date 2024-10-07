using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateApp
{
    delegate void multiCastDel(int x,int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipulation manipulation = new Manipulation();
            multiCastDel multiCastDel = new multiCastDel(manipulation.Addition);
            multiCastDel += new multiCastDel(manipulation.Substraction);
            multiCastDel += new multiCastDel(manipulation.Multiplication);
            multiCastDel -= new multiCastDel(manipulation.Multiplication);
            //call delegate
            multiCastDel(10,20);
            

            Console.ReadKey();

        }
    }
}
