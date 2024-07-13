using Microsoft.AspNetCore.Mvc;

namespace ModelBindingDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
