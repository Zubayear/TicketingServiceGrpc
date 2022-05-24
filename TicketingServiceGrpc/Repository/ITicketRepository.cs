using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingServiceGrpc.Models;

namespace TicketingServiceGrpc.Repository
{
    public interface ITicketRepository
    {
        Task SaveTicket(Models.Ticket ticket);
        Task<Models.Ticket> FetchTicket(string id);
        Task<IEnumerable<Models.Ticket>> FetchTickets();
    }
}