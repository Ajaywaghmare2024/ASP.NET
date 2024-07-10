using CricketWebMVC.Models;
using CricketWebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CricketWebMVC.Controllers
{
    public class CricketerController : Controller
    {      private readonly ICricketerService _cricketerService;

        public CricketerController(ICricketerService cricketerService)
        {
            _cricketerService = cricketerService;   
        }
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllCricketer()
        {
       
            return View(_cricketerService.GetAllCricketer());
        }

        public IActionResult AddCricketer()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddCricketer(Cricketer cricketer)
        {   
             _cricketerService.AddCricketer(cricketer);
            return View(cricketer);
        }
        public IActionResult DeleteCricketer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCricketer(int Id)
        { 
            _cricketerService.DeleteCricketer(Id);

            return View();
        }
        public IActionResult UpdateCricketer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCricketer(Cricketer cricketer)
        {
            _cricketerService.UpdateCricketer(cricketer);
            return View();
        }

        

        [HttpGet]
        public IActionResult SortByRole()
        {

            
            return View(_cricketerService.SortByRole());
        }
        public IActionResult SearchByRole()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SearchByRole(string role)
        {
            return Json(_cricketerService.SearchByRole(role));  
        }


    }
}
