using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipulation manipulation = new Manipulation();

            //generic delegate func

            Func<int,int,string> func =manipulation.Addition;
            Console.WriteLine(func.Invoke(10,20));

            Func<int, int, string> funcsub = manipulation.Substraction;
            Console.WriteLine(funcsub.Invoke(10, 20));

            Func<int, int, string> funcmul = manipulation.Multiplication;
            Console.WriteLine(funcmul.Invoke(10, 20));

            Console.ReadKey();  
        }
    }
}
