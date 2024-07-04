using FlipKart.Services;
using Microsoft.AspNetCore.Mvc;
using FlipKart.Models;

namespace FlipKart.Controllers
{
    public class ProductController : Controller
    {

        private IproductService productService;
         
        public ProductController(IproductService productService)
        {
            this.productService = productService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
             productService.Insert(model);
            return RedirectToAction("Index","Home");
        }
       
             
       

        public IActionResult GetProduct()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            productService.Delete(Id);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {    
            productService.Update(product);
            return RedirectToAction("Index","Home");
        }

        public IActionResult Update()
        {
            return View();
        }
    }
    
}
