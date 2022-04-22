using System;
using GrpcServer;
using Grpc.Net.Client;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
             //Initial basic implementation that esablishes connection and greets user, in this case me.
            var input = new HelloRequest { Name = "Andrew" };
            var channel = GrpcChannel.ForAddress("https://localhost:7042");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);
            
            Console.WriteLine(reply.Message);
            
            Console.ReadLine();


            //memory not allocated for var, method until called, unless static.
        }
    }
}