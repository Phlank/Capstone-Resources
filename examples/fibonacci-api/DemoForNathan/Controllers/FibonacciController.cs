using BackendProject.Handlers;
using DemoForNathan.ApiModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoForNathan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public FibonacciApiResponse Fibonacci5(FibonnaciApiRequest request)
        {
            var result = FibonacciHandler.ProcessSum(request.Value1, request.Value2, request.Value3, request.Value4, request.Value5);
            var output = new FibonacciApiResponse
            {
                Result = result,
            };
            return output;
        }
    }
}
