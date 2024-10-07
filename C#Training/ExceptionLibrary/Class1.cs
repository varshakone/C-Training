using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLibrary
{
    public class Manipulation
    {

        public void StringAndMath(string str, String str1,int number,int deviser )
        {
            
                Console.WriteLine("enter choice");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "string":
                        str1 = null;
                        var result = str1.CompareTo(str);
                        Console.WriteLine($"String Concatination is {result} \n");
                        break;
                    case "math":
                        var divResult = number / deviser;
                        Console.WriteLine($"Division of number is {divResult}");
                        //}
                        break;

                }
            




        }
    }
}
