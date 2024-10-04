using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScrumMaster master = new ScrumMaster(101,"Vijay","Tamil Nadu");
            master.doManagement();
            master.softwareDevelopment();
           var masterDetails= master.employeeDetails(101);
            Console.WriteLine(masterDetails);

            Developer developer = new Developer(102,"Akash","Gorakhpur");
            developer.softwareDevelopment();
            developer.Testing();
           var developerDetaild = developer.employeeDetails(102);
            Console.WriteLine(developerDetaild);
            Console.ReadKey();
        }
    }
}
