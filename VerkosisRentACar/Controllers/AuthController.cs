using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using VerkosisRentACar.DTOs;
using VerkosisRentACar.Models;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUyeRepository _uyeRepository;

        public AuthController(IUyeRepository uyeRepository)
        {
            _uyeRepository = uyeRepository;
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(GirisYapDTO girisYapDTO)
        {
            int Id = _uyeRepository.GetIdByEMail(girisYapDTO.EMail);

            if(Id== null)
            return View();
            

            Uye uye = _uyeRepository.GetByID(Id);
            if(girisYapDTO.Sifre != uye.Sifre)
                return View();
            
            

            ViewBag.UserId = Id;
            ViewBag.Username = uye.Ad + " " + uye.Soyad;

            var userId = Id;

            if (uye.Rol == "user")
                return RedirectToAction("Index", "Home", new {userId,ViewBag.Username});
            else if (uye.Rol == "admin")
                return RedirectToAction("Index", "Admin");

            return View();

        }

        [HttpGet]
        public IActionResult Signup()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Signup(KayıtOlDTO KayıtOlDTO)
        {
            if(!(KayıtOlDTO.SifreTekrar == KayıtOlDTO.Sifre))
                return View();

            if(_uyeRepository.IsUserExists(KayıtOlDTO.EMail))
                return View();

            Uye uye = new Uye
            {
                Ad = KayıtOlDTO.Ad,
                Soyad = KayıtOlDTO.Soyad,
                EMail = KayıtOlDTO.EMail,
                TelefonNo = KayıtOlDTO.TelefonNo,
                Sifre = KayıtOlDTO.Sifre,
            };

            uye.Rol = "user";

            _uyeRepository.Insert(uye);

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            ViewBag.UserId = null;
            return RedirectToAction("Login");
        }

    }
}
