using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace HastaneMVC.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IHospitalService hospitalservice;

        public HospitalController(IHospitalService hospitalservice)
        {
            this.hospitalservice = hospitalservice;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = hospitalservice.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Add(Hastane hastane)
        {
            hospitalservice.AddHospital(hastane);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Hastane hastane)
        {
           
                hospitalservice.RemoveHospital(hastane);
                return RedirectToAction("GetAll");
    
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Hastane hastane)
        {
            hospitalservice.UpdateHospital(hastane);
            return RedirectToAction("GetAll");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
