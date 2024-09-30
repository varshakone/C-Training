using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nullable type

            Int64  subject1 = 0 ;
            Nullable<Int64> subject2 = null ;
            Int32? subject3 = null ;

            // Int32 subject4 = Convert.ToInt32(Console.ReadLine());
            //convert using parse
          

            Console.WriteLine("Marks of subject1 {0}\n subject2 {1}\n subject3 {2}\n subject4 {3}", subject1,subject2,subject3,subject4 );
            Console.ReadKey();
        }
    }
}
