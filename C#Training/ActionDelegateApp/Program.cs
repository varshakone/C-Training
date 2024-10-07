using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateApp
{
    internal class Program
    {
        static void charAscii(string s)
        {
            var charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(Convert.ToInt16( charArray[i]));
            }
            
        }
        static void Main(string[] args)
        {

            //Action delegate

            Action<String> action = charAscii;
            action("abcd");

            Console.ReadKey();
        }
    }
}
