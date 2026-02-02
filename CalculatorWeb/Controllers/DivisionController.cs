using Microsoft.AspNetCore.Mvc;
using CalculatorWeb.Models;
namespace CalculatorWeb.Controllers
{
    public class DivisionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Division d1)
        {
            if (d1.SecondNumber == 0)
            {
                ViewBag.ErrorMessage = "Division by zero is not allowed.";
                return View();
            }

            return View(d1);
        }
    }
}
