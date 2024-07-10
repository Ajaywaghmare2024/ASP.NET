using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Entities;
using StudentWebAPI.Services;

namespace StudentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var list = _studentService.GetAllStudent();
            return Ok(list);
        }

        [HttpPost]

        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return Ok();


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }

        [HttpPost("{id}")]

        public IActionResult GetStudent(int id)
        {

            return Ok(_studentService.GetStudent(id));
        }

        [HttpPut("{id}")]

        public IActionResult UpdateStudent(int id, string status)
        {
            _studentService.UpdateStudent(id, status);
            return Ok();
        }


        [HttpGet("{status}")]
        public IActionResult SearchByStatus(string status)
        {
            var list = _studentService.SearchByStatus(status);
            return Ok(list);
        }

        [HttpGet("sort")]
        public  IActionResult SortByStatus()
        {
            var list= _studentService.SortByStatus();
            return Ok(list);
        }


    }

}
