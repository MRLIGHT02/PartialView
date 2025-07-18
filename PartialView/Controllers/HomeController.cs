using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("home/home-about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
