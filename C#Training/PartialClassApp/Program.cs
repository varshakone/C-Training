using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Student_Id = 1;
            student.Student_Name = "Test";
            Console.WriteLine(student.getStudent());

            Console.ReadKey();
            
        }
    }
}
