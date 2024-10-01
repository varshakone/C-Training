using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder app = new StringBuilder("Tanaygeet");
            Console.WriteLine( app );

            StringBuilder stringBuilder = app;
            //app.Capacity = 5;
            stringBuilder.Replace( "Tanaygeet", "Tanay" );
            
            Console.WriteLine($"After replacing the string {app}");

            stringBuilder.AppendFormat(" My name is {0}", app);

            Console.WriteLine(stringBuilder);
            Console.ReadKey();

        }
    }
}
