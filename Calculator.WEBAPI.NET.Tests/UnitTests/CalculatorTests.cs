using Calculator.WebAPI.NET.Core.Interfaces;

namespace Calculator.WebAPI.NET.Tests.UnitTests
{
    public class CalculatorTests
    {
        private readonly ICalculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Infrastructure.Services.Calculator();
        }

        /// <summary>
        /// tests whether the add/sub/mult/div operation is returning a correct result
        /// </summary>
        [Theory]
        [InlineData(9, 3, "Add", 12)]
        [InlineData(5, 3, "Subtract", 2)]
        [InlineData(50, 3, "Multiply", 150)]
        [InlineData(40, 2, "Divide", 20)]
        public void PerformCalculation_ShouldReturnCorrectResult(int firstNumber, int secondNumber, string operation, double expectedResult)
        {
            var result = _calculator.PerformCalculation(firstNumber, secondNumber, operation);
            Assert.Equal(expectedResult, result);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void PerformCalculation_DivideByZero_ShouldThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _calculator.PerformCalculation(5, 0, "Divide"));
        }

        [Fact]
        public void GetAvailableOperations_WithZeroSecondNumber_ShouldNotIncludeDivide()
        {
            var operations = _calculator.GetAvailableOperations(5, 0);
            Assert.DoesNotContain("Divide", operations);
        }

        [Fact]
        public void GetAvailableOperations_WithNonZeroSecondNumber_ShouldIncludeDivide()
        {
            var operations = _calculator.GetAvailableOperations(5, 3);
            Assert.Contains("Divide", operations);
        }
    }
}
