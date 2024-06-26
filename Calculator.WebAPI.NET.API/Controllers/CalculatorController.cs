using Calculator.WebAPI.NET.API.Models;
using Calculator.WebAPI.NET.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebAPI.NET.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;
        private readonly INumberStore _numberStore;

        public CalculatorController(ICalculator calculator, INumberStore numberStore)
        {
            _calculator = calculator;
            _numberStore = numberStore;
        }

        [HttpPost("SetFirstNumber")]
        public IActionResult SetFirstNumber([FromBody] NumberRequest request)
        {
            _numberStore.StoreNumber(request.Number, request.Location, 1);
            var operations = _calculator.GetAvailableOperations(request.Number, _numberStore.GetNumbers(request.Location).Second ?? 0);
            return Ok(operations);
        }

        [HttpPost("SetSecondNumber")]
        public IActionResult SetSecondNumber([FromBody] NumberRequest request)
        {
            _numberStore.StoreNumber(request.Number, request.Location, 2);
            var operations = _calculator.GetAvailableOperations(_numberStore.GetNumbers(request.Location).First ?? 0, request.Number);
            return Ok(operations);
        }

        [HttpPost("Calculate")]
        public IActionResult Calculate([FromBody] CalculationRequest request)
        {
            var result = _calculator.PerformCalculation(request.FirstNumber, request.SecondNumber, request.Operation);
            return Ok(result);
        }

        [HttpPost("ClearNumbers")]
        public IActionResult ClearNumbers([FromBody] NumberRequest request)
        {
            _numberStore.ClearNumbers(request.Location);
            return Ok();
        }
    }
}
