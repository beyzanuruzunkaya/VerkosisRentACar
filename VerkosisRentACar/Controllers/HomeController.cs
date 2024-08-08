using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;
using VerkosisRentACar.DTOs;
using VerkosisRentACar.Models;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAracRepository _repository;
        private readonly IKiralananAracRepository _kiralananAracRepository;
        private readonly IMapper _mapper;

        public HomeController(IAracRepository repository, IKiralananAracRepository kiralananAracRepository, IMapper mapper)
        {
            _repository = repository;
            _kiralananAracRepository = kiralananAracRepository;
            _mapper = mapper;
        }

        public IActionResult Index(int userId,string username)
        {
            ViewBag.UserId = userId;
            ViewBag.Username = username;
            List<Arac> araclar = _repository.GetList();
            var filteredAraclar = araclar.Where(x => x.Uygun == true).ToList();
            return View(filteredAraclar);
        }

        
        public IActionResult Kirala(int carid,int userid)
        {
           Arac Arac =_repository.GetByID(carid);
            Arac.Uygun = false;
            _repository.Update(Arac);

            KiralananAracDTO kiralananAracDto = new KiralananAracDTO
            {
                AracId = carid,
                UyeId = userid,
                BaslangicTarih = DateTime.Now,
                BitisTarih = DateTime.Now.AddHours(1)
            };

            KiralananArac kiralananArac = _mapper.Map<KiralananArac>(kiralananAracDto);

            _kiralananAracRepository.Insert(kiralananArac);

           
            return RedirectToAction("Index");
        }

    }
}
