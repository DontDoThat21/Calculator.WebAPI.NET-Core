namespace Calculator.WebAPI.NET_Core.Interfaces
{
    public interface ICalculator
    {
        List<string> GetAvailableOperations();
        double PerformCalculation(string operation);
    }
}
