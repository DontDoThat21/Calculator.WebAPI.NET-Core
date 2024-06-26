namespace Calculator.WebAPI.NET.Core.Interfaces
{
    public interface ICalculator
    {
        List<string> GetAvailableOperations();
        double PerformCalculation(string operation);
    }
}
