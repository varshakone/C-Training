using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.BusinessLayer;
using TicketBookingSystem.BusinessLayer.Repository;
using TicketBookingSystem.BusinessLayer.Services;
using TicketBookingSystem.Entity;

namespace TicketBookingSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventRepository eventRepository = new EventRepository();
            EventService service = new EventService(eventRepository);
           
            service.addCustomer(new Customer() { Id = 1 ,Name="xyz",Address="Abc"});

            Console.ReadKey();
        }
    }
}
