using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.Services;


namespace Ecommerce.Controllers
{
    public class AuthController : Controller


    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
                _userService = userService;
        }

            

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(string email, string password)
        {
            return View();
        }

        public IActionResult Register()
        {
         return View();
        }


        [HttpPost]
        public IActionResult Register(string FirstName, string LastName, string contactNumber, string email)
        {
            User user = new User();
            user.FirstName = FirstName;
                
            user.LastName = LastName;
            user.ContactNumber = contactNumber;
            user.Email = email;
            _userService.insert(user);

            
                
                
            return View();
        }
    }
}
