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
            ViewData["Message"] = "Here are some of the services We provide.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Let our Team take care of you. We can help you look your best without the stress!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
