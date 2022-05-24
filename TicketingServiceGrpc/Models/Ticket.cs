using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;

namespace TicketingServiceGrpc.Models
{
    [DynamoDBTable("tickets")]
    public class Ticket
    {
        [DynamoDBHashKey("id")]
        public string? Id { get; set; }

        [DynamoDBProperty("matchTime")]        
        public string? MatchTime { get; set; }
        
        [DynamoDBProperty("stadium")]
        public string? Stadium { get; set; }
        
        [DynamoDBProperty("ticketName")]
        public string? TicketName { get; set; }
        
        [DynamoDBProperty("ticketPrice")]
        public float TicketPrice { get; set; }
    }
}