using CricketWebApp.Entitties;
using CricketWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CricketWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CricketerController : ControllerBase
    {
        private readonly ICricketerService _cricketerService;

        public CricketerController(ICricketerService cricketerService)
        {
                _cricketerService = cricketerService;   
        }


        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_cricketerService.GetAll());
            
        }

        [HttpPost]
        public IActionResult AddCrickter(Cricketer  cricketer)
        {
            _cricketerService.AddCricketer(cricketer);
            return Ok();
        }

        [HttpPost("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok(_cricketerService.GetById(id));
        }


        [HttpPut]

        public IActionResult UpdateCricketer(UpdateModel cricketer)
        {
             _cricketerService.UpdateCricketer(cricketer);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCricketer(int id)
        {
            _cricketerService.DeleteCricketer(id);
            return Ok();
        }

        [HttpGet("{sort}")]

        public IActionResult SortByRole() {
            _cricketerService.SortByRole();
          return Ok();
        }

        [HttpPost("{role}")]

        public IActionResult SearchByRole(string role)
        {
            return Ok(_cricketerService.SearchByRole(role));    
        }



    }
}
