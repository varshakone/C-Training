using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StudentList studentList = new StudentList();
                studentList[0] = new Student() { Id=100,Name="Vijay",MobileNumber="456123"};
                studentList[1] = new Student() { Id = 101, Name = "Akash", MobileNumber = "456123" };
                studentList[2] = new Student() { Id = 102, Name = "Akshat", MobileNumber = "456123" };
                studentList[3] = new Student() { Id = 103, Name = "", MobileNumber = "456123" };
                studentList[4] = new Student() { Id = 104, Name = "Vijay", MobileNumber = "456123" };
                studentList[5] = new Student() { Id = 105, Name = "Vijay", MobileNumber = "456123" };

                Console.WriteLine(studentList[5].Id + studentList[5].Name + studentList[5].MobileNumber);

               
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
