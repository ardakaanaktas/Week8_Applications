using LiveLesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiveLesson1.Controllers
{
    public class YasamController : Controller
    {
        [Route("ItsMyLife")]
        public IActionResult Index()
        {
            List<Hobi> Hobi = Veri.Hobilerim().OrderByDescending(h => h.Degree).ToList();

            ViewBag.sample_text = "Hobiler, hayatın rutininden kaçış, ruhun özgürlüğüdür.";

            ViewData["sample_text"] = "Hobiler, hayatın rutininden kaçış, ruhun özgürlüğüdür.2";
            return View(Hobi);
        }
    }
}
