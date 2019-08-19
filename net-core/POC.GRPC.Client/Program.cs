using Grpc.Core;
using System;

namespace POC.GRPC.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("52.226.109.36:50051", ChannelCredentials.Insecure);

            var client = new Calculadora.CalculadoraClient(channel);
            
            var reply = client.Soma(new Request() { PrimeiroValor = 10, SegundoValor = 20 });
            Console.WriteLine("Soma Retornou: " + reply.Resultado);

            var reply2 = client.Subtracao(new Request() { PrimeiroValor = 30, SegundoValor = 25 });
            Console.WriteLine("Subtracao Retornou: " + reply2.Resultado);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
