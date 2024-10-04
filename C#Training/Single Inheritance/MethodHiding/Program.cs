using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class parent
    {
        public void myProperty()
        {
            Console.WriteLine("Parents stays in property");
        }
    }
    class child : parent {

        public new string myProperty()
        {
          return "child stays in property";
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            parent parent = new child();
            parent.myProperty();

            child child = new child();
            child.myProperty();

            Console.ReadKey();
        }
    }
}
