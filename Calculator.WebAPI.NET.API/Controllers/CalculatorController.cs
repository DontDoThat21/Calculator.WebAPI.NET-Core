using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebAPI.NET.Core.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
