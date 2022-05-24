// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using static TicketingServiceGrpc.Ticket;
// using GrpcClient;

using var grpcChannel = GrpcChannel.ForAddress("http://localhost:7974");
var ticketClient =  new TicketClient(grpcChannel);
// var res = await ticketClient.CreateTicketAsync(new TicketingServiceGrpc.TicketRequest
// {
//     TicketName = "Italy v Germany",
//     Stadium = "Stadio Renato Dall'Ara, Bologna, Italy",
//     TicketPrice = 21.25f
// });

// var res = await ticketClient.GetTicketByIdAsync(new TicketingServiceGrpc.TicketByIdRequest
// {
//     Id = "9f033042-21ff-420a-9a41-ef290fc6ba54"
// });

TicketingServiceGrpc.TicketsReply tickets = await ticketClient.GetTicketsAsync(new TicketingServiceGrpc.TicketsRequest());
foreach (var res in tickets.Tickets)
{
    Console.WriteLine($"Ticket: {res.TicketName}; {res.TicketPrice}; {res.Stadium}");
}
// Console.WriteLine($"Ticket: {res.Tickets}; {res.TicketPrice}; {res.Stadium}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();