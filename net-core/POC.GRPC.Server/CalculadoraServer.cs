using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace POC.GRPC.Server
{
    public class CalculadoraServer : Calculadora.CalculadoraBase
    {
        public override Task<Repply> Soma(Request request, ServerCallContext context)
        {
            return Task.FromResult(new Repply() { Resultado = request.PrimeiroValor + request.SegundoValor });
        }

        public override Task<Repply> Subtracao(Request request, ServerCallContext context)
        {
            return Task.FromResult(new Repply() { Resultado = request.PrimeiroValor - request.SegundoValor });
        }
    }
}
