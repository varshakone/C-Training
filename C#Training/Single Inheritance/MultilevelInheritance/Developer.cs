using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Developer:ScrumMaster
    {
        public Developer(int id, string name, string address):base(id,name,address)
        {
                
        }
        public void Testing() {

            Console.WriteLine("Developer carries testing Task"  );
        }
    }
}
