// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using static TicketingServiceGrpc.Ticket;
// using GrpcClient;

using var grpcChannel = GrpcChannel.ForAddress("http://localhost:7974");
var ticketClient =  new TicketClient(grpcChannel);
var res = await ticketClient.CreateTicketAsync(new TicketingServiceGrpc.TicketRequest
{
    TicketName = "Italy v Germany",
    Stadium = "Stadio Renato Dall'Ara, Bologna, Italy",
    TicketPrice = 21.25f
});

Console.WriteLine(res.Stadium);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();