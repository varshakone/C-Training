using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Array
             Int32[] studentMarks = { 85, 95, 75, 65, 35 };
            Int32[] studentCounts = new Int32[studentMarks.Length];

            //Int32[] studentMarks = new Int32[5];
            //Initialize the array
            studentMarks[0] = 85;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Input array elements");
            //    studentMarks[i] =int.Parse(Console.ReadLine());
            //}

            ////Reading Array elements
            Console.WriteLine("All Array Elements");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(studentMarks[i]);
            }


            //Sort Array
            Array.Sort(studentMarks);
            Console.WriteLine("All Array Elements in sorted order");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(studentMarks[i]);
            }

            //Search element in array
            var searchResult = Array.BinarySearch(studentMarks, 30);
            Console.WriteLine( "Element present in Array {0}",searchResult );


            //copy array
            Array.Copy(studentMarks, studentCounts, studentCounts.Length);
            Console.WriteLine("All Array Elements after copy");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(studentCounts[i]);
            }

            //reverse array
            Array.Reverse(studentCounts);
            Console.WriteLine("All Array Elements after Reverse");
            foreach (int i in studentCounts)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
