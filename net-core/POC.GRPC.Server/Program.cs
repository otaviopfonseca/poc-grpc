using System;
using System.Threading;
using Grpc.Core;

namespace POC.GRPC.Server
{
    public class Program
    {
        const int Port = 50052;

        public static void Main(string[] args)
        {
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { Calculadora.BindService(new CalculadoraServer()) },
                Ports = { new ServerPort("0.0.0.0", Port, ServerCredentials.Insecure) }
            };
            server.Start();
                        
            Console.WriteLine("Greeter server listening on port " + Port);
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
