using Microsoft.AspNetCore.Mvc;
using VerkosisRentACar.Models;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAracRepository _repository;

        public AdminController(IAracRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Arac> araclar = _repository.GetList();
            return View(araclar);
        }

        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCar(Arac Arac)
        {
            Arac.Uygun = true;
            _repository.Insert(Arac);
            return RedirectToAction("Index");
        }

        [Route("RemoveCar/{id}")]
        public IActionResult RemoveCar(int id)
        {
            Arac Arac = _repository.GetByID(id);
            _repository.Delete(Arac);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            Arac Arac = _repository.GetByID(id);
            return View(Arac);
        }

        [HttpPost]
        [Route("UpdateCar/{id}")]
        public IActionResult UpdateCar(Arac Arac)
        {
            _repository.Update(Arac);
            return RedirectToAction("Index");
        }
    }
}
