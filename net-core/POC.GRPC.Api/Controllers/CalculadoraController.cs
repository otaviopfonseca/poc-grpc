using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POC.GRPC.Api.Controllers
{
    [Route("api/Calculadora")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("Soma")]
        public async Task<double> Soma(double primeiro, double segundo)
        {
            return await Task.FromResult(primeiro + segundo);
        }

        [HttpGet("Subtracao")]
        public async Task<double> Subtracao(double primeiro, double segundo)
        {
            return await Task.FromResult(primeiro - segundo);
        }
    }
}