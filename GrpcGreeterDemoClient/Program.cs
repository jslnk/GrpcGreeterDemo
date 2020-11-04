using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterDemo;

namespace GrpcGreeterDemoClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //AppContext.SetSwitch("System.net.http.socketshttphandler.Http2UnecrytedSupport", true);
            //var httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("http://localhost:5001");
            //var client = GrpcClient.Create<Greeter.GreeterClient>(httpClient) ;                       
            //var reply = await client.SayHelloAsync(new HelloRequest { nameof = "AAA" });
            //Console.WriteLine("Greeting:" + reply.Message);
            //Console.ReadKey();

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel); // new GrpcGreeterDemo.Greeter();
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Jeongseon" });
            Console.WriteLine("here is the message from server side :" + reply.Message);
            Console.ReadKey();


        }
    }
}
