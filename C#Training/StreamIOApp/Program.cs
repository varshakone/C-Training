using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamIOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //absolute path
            string path = @"C:\Users\DELL\OneDrive\Desktop\Mytxt.txt";

            //FileStream to create file with file access amd mode permisiions

            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Write);

            if (File.Exists(path))
            {
                //write to file using streamwriter
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine("Wel come to File IO");
                writer.Close();
            }


            //read to file using streamReader

            fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

            //using block to dispose the object 
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            Console.ReadKey();

        }
    }
}
