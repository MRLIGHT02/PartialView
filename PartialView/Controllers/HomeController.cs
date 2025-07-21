using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using System.Runtime.CompilerServices;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        ListModel listModel = new ListModel() { ListTitle = "", ListItems = new List<string> { "Delhi", "Mumbai", "Pune" } };
        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            // This is the default route for the HomeController
            listModel.ListTitle = "Home Page";



            return View(listModel);
        }
        [Route("home-about")]
        public IActionResult About()
        {
            listModel.ListTitle = "About Page";


            return View(listModel);

        }
        [Route("programming-languages")]
        public IActionResult ProgrammingLanguages()
        {

            listModel.ListTitle = "Programming Languages";
            listModel.ListItems = new List<string> { "C#", "Java", "Python", "JavaScript", "Ruby" };
            return PartialView("_ListPartialView", listModel);
        }
    }
}
