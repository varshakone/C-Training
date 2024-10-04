using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceLibrary
{
    public class salary
    {
        public int basicSalary {  get; set; }
        public int TA {  get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }

        public int PF { get; set; }
        public int Tax { get; set; }
        public int grossSalary { get; set; }
        public int netSalary { get; set; }
    }
}
