using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOWithFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create file using fileinfo

            string path = @"C:\Users\DELL\OneDrive\Desktop\Mytxt.txt";
            FileInfo fileInfo = new FileInfo(path);
            //fileInfo.Create();
            
            //write to file
            //fileInfo.MoveTo("C:\\Users\\DELL\\source\\repos\\myDesTxt.txt");

            //delete the file
            fileInfo.Delete();
            Console.ReadKey();
        }
    }
}
