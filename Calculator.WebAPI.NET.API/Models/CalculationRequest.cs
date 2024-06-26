namespace Calculator.WebAPI.NET.API.Models
{
    public class CalculationRequest
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }
        public string Location { get; set; }
    }
}
