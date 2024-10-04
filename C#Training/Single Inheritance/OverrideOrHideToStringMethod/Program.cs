using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideOrHideToStringMethod
{
    class student : Object
    {
        private int id;
        private string name;
        private int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //public override string ToString()
        //{
        //    var result = string.Format("Student ID : {0}\n Student Name:{1}" +
        //        "" +
        //        "\n Student Age :{2} ", id, name, age);


        //    return result;
        //}
        public new string ToString()
        {
            var result = string.Format("Student ID : {0}\n Student Name:{1}" +
                "" +
                "\n Student Age :{2} ", id, name, age);


            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.Id = 124;
            student.Name= "test";
            student.Age = 5;
            Console.WriteLine(student.ToString());

            Console.ReadKey();
        }
    }
}
