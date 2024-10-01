using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 98, 85, 75 };
            String[] names = new String[] { "Tanay", "Adhyatma", "Anisha" };

            //Jagged Array declaration
            Object[][] jaggedArray = new object[2][];

            //Initialize jagged Array
            jaggedArray[0] = new object[] { 98, 85, 75 };
            jaggedArray[1] = new object[] { "Tanay" };

            //Access jagged Array Elements

            for (int i = 0; i <= jaggedArray.GetUpperBound(0); i++)
            {
                foreach (object temp in jaggedArray[i])
                {
                    Console.Write(" "+temp  );
                }
                Console.WriteLine(  );
            }

            Console.ReadKey();
        }
    }
}
