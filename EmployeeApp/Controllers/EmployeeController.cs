using EmployeeApp.Entities;
using EmployeeApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees() 
        { 
              //employeeService.GetAllEmployees();
            return Ok(employeeService.GetAllEmployees());
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employeeService.AddEmployee(employee);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteEmoplyee(int id)
        {
            employeeService.DeleteEmployee(id);
            return Ok();
        }

        [HttpPut("{id,age}")]
        public IActionResult UpdateEmployee(int id,int age)
        {
            employeeService.UpdateEmployee(id,age);
            return Ok();    
        }
        
        [HttpPost("{id}")]
        public IActionResult GetById(int id)
        {
            employeeService.GetById(id);
            return Ok();
        }

    }
}
