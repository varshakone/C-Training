using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOperatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var grade = 'A';
            dynamic Name = "Vijay";
            Object marks = 76;
            Object examDate= DateTime.Now;

            var isGrade = grade is char;

            var  isNameString = Name is string;

            var isMarkint = marks is Int32;

            var isExamDate = examDate is DateTime;

            Console.WriteLine( "is Garde Char {0} and It's Type is {1}",isGrade,grade.GetType() );
            Console.WriteLine("Is Name String {0} and It's Type is {1}",isNameString, Name.GetType());

            Console.WriteLine("is marl int {0} and It's Type is {1}", isMarkint,marks.GetType());
            Console.WriteLine("Is exam DateTime {0} and It's Type is {1}", isExamDate,examDate.GetType());

            Console.ReadKey();
        }
    }
}
