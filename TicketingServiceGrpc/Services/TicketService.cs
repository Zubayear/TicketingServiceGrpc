using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using TicketingServiceGrpc.Repository;
using static TicketingServiceGrpc.Ticket;

namespace TicketingServiceGrpc.Services
{
    public class TicketService : TicketBase
    {
        private readonly ITicketRepository ticketRepository;
        private readonly ILogger<TicketService> logger;

        public TicketService(ITicketRepository ticketRepository, ILogger<TicketService> logger)
        {
            this.ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public override Task<TicketReply> CreateTicket(TicketRequest request, ServerCallContext context)
        {
            var ticket = new Models.Ticket
            {
                TicketName = request.TicketName,
                Stadium = request.Stadium,
                TicketPrice = request.TicketPrice
            };
            ticketRepository.SaveTicket(ticket);
            var res = new TicketReply()
            {
                TicketName = request.TicketName,
                Stadium = request.Stadium,
                TicketPrice = request.TicketPrice  
            };
            return Task.FromResult(new TicketReply
            {
                TicketName = request.TicketName,
                Stadium = request.Stadium,
                TicketPrice = request.TicketPrice 
            });
        }

        public override async Task<TicketByIdReply> GetTicketById(TicketByIdRequest request, ServerCallContext context)
        {
            var ticket = await ticketRepository.FetchTicket(request.Id);
            return await Task.FromResult(new TicketByIdReply
            {
                TicketName = ticket.TicketName,
                Stadium = ticket.Stadium,
                TicketPrice = ticket.TicketPrice
            });
        }

        public override async Task<TicketsReply> GetTickets(TicketsRequest request, ServerCallContext context)
        {
            var tickets = await ticketRepository.FetchTickets();
            IList<TicketReply> ticketReplies = new List<TicketReply>();
            foreach (var ticket in tickets)
            {
                ticketReplies.Add(new TicketReply
                {
                    TicketName = ticket.TicketName,
                    TicketPrice = ticket.TicketPrice,
                    Stadium = ticket.Stadium
                });
            }

            return await Task.FromResult(new TicketsReply
            {
                Tickets = {ticketReplies}
            });
        }

    }
}