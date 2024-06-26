namespace Calculator.WebAPI.NET.Core.Interfaces
{
    public interface INumberStore
    {
        void StoreNumber(int number, string location, int position);
        void ClearNumbers(string location);
        (int? First, int? Second) GetNumbers(string location);
    }
}
