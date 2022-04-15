using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply //setting up newTask to put results in here w/o waiting. wants to allow synchronous/asynchronous calling
            {
                //Pascal in C# class conversion
                Message = "Hello " + request.Name
            });
        }
    }
}