using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionLibrary;
namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    try
                    {
                        var name = Console.ReadLine();
                        var name1 = Console.ReadLine();
                       // name = null;
                        var charArray = name.ToCharArray();
                        for (int i = 0; i <charArray.Length; i++)
                        {
                            Console.WriteLine(charArray.Length);
                            Console.WriteLine(charArray[i]);
                        }

                        Manipulation manipulation = new Manipulation();
                        manipulation.StringAndMath(name, name1, 10, 0);

                    }
                    catch (NullReferenceException ex)
                    {
                        if (ex is NullReferenceException)
                        {
                            Console.WriteLine("Both values must be provided");
                        }
                        else if (ex is DivideByZeroException)
                        {
                            Console.WriteLine("both number and devisor shoud be greater than zero");
                        }
                        else if (ex is IndexOutOfRangeException)
                        {
                            Console.WriteLine("Array out of range");
                        }
                    }
                    
                   
                }
                catch (IndexOutOfRangeException ex)
                {


                    Console.WriteLine("Array out of range");

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("both number and devisor shoud be greater than zero");
            }
          
            Console.ReadKey();
        }
    }
}
