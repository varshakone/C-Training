using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DELL\OneDrive\Desktop\Mytxt.txt";
            Console.WriteLine( "File Operations" );

            string fileOperations = Console.ReadLine();

            switch (fileOperations)
            {
                case "create":
                    //create file
                    
                    File.Create(path);
                    break;
                case "write":
                    //write to file
                    File.WriteAllText(path, "Wel come to C# file IO");
                    break;
                case "read":
                    //read file content
                    var result = File.ReadAllText(path);
                    break;
                case "delete":
                    //delete the file
                    if (File.Exists(path))
                    {
                        File.Delete(path);

                    }
                    else
                    {
                        var result1 = File.ReadAllText(path);
                        Console.WriteLine(result1);
                    }

                    break;
                case "copy":
                    break;
                default:
                    break;
            }
            

          

           

          
            Console.ReadKey();
        }
    }
}
