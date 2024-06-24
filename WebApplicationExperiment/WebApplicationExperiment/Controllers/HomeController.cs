using Microsoft.AspNetCore.Mvc;

namespace WebApplicationExperiment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Links()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
