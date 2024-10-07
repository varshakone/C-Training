using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    delegate int SingleDel(int x,int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anonymous method

            SingleDel singleDel = delegate(int x,int y) { return x + y; };

            //call method
            Console.WriteLine( singleDel.Invoke(10, 20));


            //Lambda Expression
            SingleDel singleDel1 = (x, y) => {  return x + y; };

            Console.WriteLine(singleDel1.Invoke(30,40));

            Console.ReadKey();

        }
    }
}
