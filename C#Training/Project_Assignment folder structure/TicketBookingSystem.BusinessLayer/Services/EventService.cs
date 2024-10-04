using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.BusinessLayer.Repository;
using TicketBookingSystem.Entity;

namespace TicketBookingSystem.BusinessLayer.Services
{
    public class EventService : IEventService
    {
        Customer customer;
        IEventRepository _eventRepository;
        public EventService(EventRepository eventRepository)
        {
            _eventRepository= eventRepository;
        }

        public void addCustomer(Customer customer)
        {
            _eventRepository.addCustomer(customer);
        }

       
    }
}
