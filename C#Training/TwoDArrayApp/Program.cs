using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Delcaring Two Dimensional Array
             */

            //object[,] lstStudent = new Object[3, 4];
            object[,] lstStudent = { { 101,"Tanay","Indore",68},

                                    {102,"Adhyatm","Karjat",76 },
                                    {103,"Anisha","Tamil nadu",68 },
                                    };

            // access array Elements

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" " + lstStudent[i,j] );
                }
                Console.WriteLine("\t" );
            }
        
            Console.ReadKey();
        }
    }
}
