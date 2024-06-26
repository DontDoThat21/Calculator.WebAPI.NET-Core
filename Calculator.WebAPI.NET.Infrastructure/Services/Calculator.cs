using Calculator.WebAPI.NET.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WebAPI.NET.Infrastructure.Services
{
    public class Calculator : ICalculator
    {
        public List<string> GetAvailableOperations(int firstNumber, int secondNumber)
        {
            var operations = new List<string> { "Add", "Subtract", "Multiply" };
            if (secondNumber != 0)
            {
                operations.Add("Divide");
            }
            return operations;
        }

        public double PerformCalculation(int firstNumber, int secondNumber, string operation)
        {
            if (operation == "Divide" && secondNumber == 0)
            {
                throw new InvalidOperationException("Division by zero is not allowed.");
            }

            return operation switch
            {
                "Add" => firstNumber + secondNumber,
                "Subtract" => firstNumber - secondNumber,
                "Multiply" => firstNumber * secondNumber,
                "Divide" => (double)firstNumber / secondNumber,
                _ => throw new InvalidOperationException("Invalid operation"),
            };
        }
    }
}
