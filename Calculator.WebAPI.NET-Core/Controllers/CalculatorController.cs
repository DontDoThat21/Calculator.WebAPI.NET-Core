using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebAPI.NET_Core.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
