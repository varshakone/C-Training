using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_Func_Delegate
{
    internal class Manipulation
    {

        public string Addition(int n1, int n2)
        {
            return $"Addition is {n1 + n2}" ; 
        }
        public string Substraction(int n1, int n2)
        {
            return $"Substraction is {n1 - n2}";
        }
        public string Multiplication(int n1, int n2)
        {
            return $"Multiplication is {n1 * n2}";
        }

    }
}
