using Grpc.Net.Client;
using GrpcService.Protos;
using System;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Service.ServiceClient(channel);
            var req = new AddCommentRequest {Postid = 1, Text = "un tesxt" };
            var res = await client.AddCommentAsync(req);
            Console.WriteLine(res.BResult);
        }
    }
}
