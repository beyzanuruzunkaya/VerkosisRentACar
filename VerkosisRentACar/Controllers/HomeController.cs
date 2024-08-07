using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VerkosisRentACar.Models;

namespace VerkosisRentACar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
