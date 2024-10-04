using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Task
using TicketBookingSystem.Entity;

namespace TicketBookingSystem.BusinessLayer.Repository
{
    internal interface IEventRepository
    {
        void addCustomer(Customer customer);
    }
}
