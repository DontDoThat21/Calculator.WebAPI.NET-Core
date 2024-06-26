using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WebAPI.NET.Core.Interfaces
{
    public interface ICalculator
    {
        List<string> GetAvailableOperations(int firstNumber, int secondNumber);
        double PerformCalculation(int firstNumber, int secondNumber, string operation);
    }
}
