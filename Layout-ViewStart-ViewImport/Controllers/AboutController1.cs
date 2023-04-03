using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewStart_ViewImport.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
