using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifier;

namespace AccessmodifierApp
{
    class StringFunction : StringManipulation
    {
        public StringFunction()
        {
            
            Console.WriteLine(nameUpper("hexaware"));
            Console.WriteLine("Protected Internal Member of Library "+nameLower("TECHNOLOGY"));

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            var aceesmodify= Console.ReadLine();

            Console.WriteLine( aceesmodify);

            switch (aceesmodify)
            {
                case "Public":
                    StringManipulation stringManipulation = new StringManipulation();
                    var result = stringManipulation.stringConcatination("Vijay", "Surya");
                   
                    Console.WriteLine(result);
                    break;

                case "Private":
                    
                    Console.WriteLine("stringLength not accessible as it's private class of Library");
                    break;
                case "Protected":
                    StringFunction stringFunction = new StringFunction();
                    break;
                case "Protected internal":
                    StringFunction stringFunction1 = new StringFunction();
                    Console.WriteLine("newLower accessible only in derived class outside this project");

                    break;
                case "internal":
                    Console.WriteLine("newName not accessible as it's public to Library");
                    break;
                   
            }
            Console.ReadKey();  
           
        }
    }
}
