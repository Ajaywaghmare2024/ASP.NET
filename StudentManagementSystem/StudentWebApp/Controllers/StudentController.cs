using Microsoft.AspNetCore.Mvc;
using StudentWebApp.Models;
using StudentWebApp.Services;

namespace StudentWebApp.Controllers
{
    public class StudentController : Controller

    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return View(student); // Return the view with the model to show validation errors if any
        }

        public IActionResult DeleteStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteStudent(int Student_Id)
        {
            _studentService.DeleteStudent(Student_Id);
            return View();  
        }

        public IActionResult UpdateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            _studentService.UpdateStudent(student);
            return View();
        }
        


        public IActionResult SearchStudentByStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchStudentByStatus(string status)
        {    
           
            return View(_studentService.SearchStudentByStatus(status));
        }

        [HttpGet]
        public IActionResult SortByStatus()
        {
            
            return View(_studentService.SortByStatus());
           }    



    }
}
