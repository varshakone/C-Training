using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Entity;

namespace TicketBookingSystem.BusinessLayer
{
    public class CustomerService
    {
        Customer _customer;
        Customer Customer
        {
            get
            {
                return _customer;
            } 
            set
            {
                _customer = value;
            }
        }

        public CustomerService()
        {
                
        }

        public void display_customer_details()
        {
            Console.WriteLine(  Customer.Name + " "+Customer.Id);
        }
    }
}
