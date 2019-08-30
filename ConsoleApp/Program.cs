using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var c = new System.Net.Http.HttpClient
            {
                BaseAddress = new Uri("https://example.com"),
            };

            var s = Grpc.Net.Client.GrpcClient.Create<MyGrpcServices.HelloWorldService.HelloWorldServiceClient>(c);
            var r = await s.SayHelloAsync(new MyGrpcServices.HelloWorldRequest { Name = "xxx" });
            Console.WriteLine(r.Message);
        }
    }
}
