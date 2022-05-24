using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using TicketingServiceGrpc.Models;

namespace TicketingServiceGrpc.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IDynamoDBContext dynamoDBContext;
        private readonly ILogger<TicketRepository> logger;

        public TicketRepository(IDynamoDBContext dynamoDBContext, ILogger<TicketRepository> logger)
        {
            this.dynamoDBContext = dynamoDBContext ?? throw new ArgumentNullException(nameof(dynamoDBContext));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Models.Ticket> FetchTicket(string id)
        {
            return await dynamoDBContext.LoadAsync<Models.Ticket>(id);
        }

        public async Task<IEnumerable<Models.Ticket>> FetchTickets()
        {
            return await dynamoDBContext.ScanAsync<Models.Ticket>(default).GetRemainingAsync();
        }

        public async Task SaveTicket(Models.Ticket ticket)
        {
            ticket.Id = Guid.NewGuid().ToString();
            ticket.MatchTime = DateTimeOffset.Now.ToLocalTime().ToString();
            await dynamoDBContext.SaveAsync(ticket);
        }
    }
}