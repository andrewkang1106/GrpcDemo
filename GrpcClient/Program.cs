using System;
using GrpcServer;
using Grpc.Net.Client;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
            var input = new HelloRequest { Name = "Andrew" };
            var channel = GrpcChannel.ForAddress("https://localhost:7042");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);
            
            Console.WriteLine(reply.Message);
            */
            Console.ReadLine();
        }
    }
}