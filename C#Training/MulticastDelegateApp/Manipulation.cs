using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateApp
{
    internal class Manipulation
    {

        public void Addition(int n1, int n2)
        {
            Console.WriteLine( $"Addition is {n1 + n2}" ); 
        }
        public void Substraction(int n1, int n2)
        {
            Console.WriteLine($"Substraction is {n1 - n2}");
        }
        public void Multiplication(int n1, int n2)
        {
            Console.WriteLine($"Multiplication is {n1 * n2}");
        }

    }
}
