using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedPropertyApp
{
    internal class Bank
    {

        //Auto implemented properties;

        public int bankID { 
            get; 
            set; } = 1000;
        public string bankName { get; 
            set; }
        public string bankDescription { get; 
            set; } 
        public string accountNumber { get; 
            set; }
    }
}
