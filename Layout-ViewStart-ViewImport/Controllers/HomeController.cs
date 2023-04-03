using Layout_ViewStart_ViewImport.Models;
using Layout_ViewStart_ViewImport.ViewModels.Home;
using Layout_ViewStart_ViewImport.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewStart_ViewImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["name"] = "Abraham";
            //TempData["surname"] = "Akberov";
            //ViewBag.address = "Sumqayit";
            //ViewBag.nums = new List<int>() { 1, 2, 3, 5 };
            ////return RedirectToAction("Detail");
            //string firstName = "Konul";
            //return View((object)firstName); 

            Student student1 = new()
            {
                Id = 1,
                Name = "Ali",
                Age = 21
            };
            Student student2 = new()
            {
                Id = 2,
                Name = "Shaiq",
                Age = 25
            };
            List<Student> students = new List<Student> { student1, student2 };

            Product product = new()
            {
                Id = 1,
                Name = "Samsung",
                Price = 5000,
                Description = "Desc",
                Count = 10
            };
            ProductVM productVM = new()
            {
                Name = product.Name,
                Price = product.Price
            };

            HomeVM model = new()
            {
                Student = students,
                Product = productVM
            };

            return View(model);
        }

        //public IActionResult Detail()
        //{
        //    return View();
        //}
    }
}  

