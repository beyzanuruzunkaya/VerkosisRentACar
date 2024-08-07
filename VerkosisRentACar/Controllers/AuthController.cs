using Microsoft.AspNetCore.Mvc;

namespace VerkosisRentACar.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {

            return View();
        }
        public IActionResult Signup()
        {

            return View();
        }
    }
}
