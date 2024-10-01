using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndReadonlyApp
{
    internal class Program
    {
        const float PI = 3.14F;
        readonly float PI1 = 3.14F;
        public Program()
        {
                PI1 = 3.15F;
                PI = 3.15F;
        }
        static void Main(string[] args)
        {
            PI = 3.15F;
           
           
        }
    }
}
