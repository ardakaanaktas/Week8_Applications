using Microsoft.AspNetCore.Mvc;

namespace EmtyCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
