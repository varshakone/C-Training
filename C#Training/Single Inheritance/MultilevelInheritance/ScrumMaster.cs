using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class ScrumMaster:Employee
    {
        public ScrumMaster(int id, string name, string address):base(id,name,address)
        {
                
        }
        public void doManagement() {

            Console.WriteLine("Manager look after employee Management"  );
        
        }
        public void softwareDevelopment()
        {

            Console.WriteLine("ScrumMaster look after Project Management and development");

        }

    }
}
