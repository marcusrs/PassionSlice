using Microsoft.AspNetCore.Mvc;

namespace PassionSlice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Let our Team take care of you!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
