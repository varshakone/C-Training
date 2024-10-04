using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassApp
{
    static class Bank
    {
        static Bank()
        {
                
        }
    }

   static class ICICI : Bank
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
