using System;


namespace MyAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wel come to the world of C#");

            // Console.WriteLine(Convert.ToInt32(Console.ReadLine())   );
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("\n", key.Key.ToString());
            Console.ReadKey();


        }
    }
}
