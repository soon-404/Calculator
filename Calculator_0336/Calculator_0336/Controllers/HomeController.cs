using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Data;
using Calculator_0336.Models;

namespace Calculator_0336.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Produces("text/html")]
        public IActionResult Calculate(string number)
        {
            CalculatorModel cal = new CalculatorModel();
            string value = new DataTable().Compute(number, null).ToString();
            cal.CalculateValue = value;
            return Content(cal.CalculateValue, "text/html", Encoding.UTF8); 
        }
    }
}
