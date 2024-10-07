using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicketBookingSystem.Entity
{
    public class Customer
    {
        public Customer()
        {
           
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
