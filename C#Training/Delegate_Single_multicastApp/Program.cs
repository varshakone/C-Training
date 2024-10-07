using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Single_multicastApp
{
    //step 1 declare delegate should match with method signature
    delegate int singleMathDel (int x, int y);

    internal class Program
    {
        
        static void Main(string[] args)
        {
       
            Manipulation manipulation = new Manipulation();
            //step3 create object of delegate to hold reference of method
            singleMathDel objSingleDel = new singleMathDel(manipulation.Addition);

            //step4 call delegate
            Console.WriteLine(  "Addition using object reference "+ objSingleDel(10, 20).ToString());

            Console.WriteLine("Addition using invoke method "+ objSingleDel.Invoke(130, 40).ToString());

            Console.ReadKey();
        }
    }
}
