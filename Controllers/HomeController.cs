using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            //string message = "Don't let Benny Bob into your mainframe";
            //ViewBag.Message = message;
            //return View("Index"); <--does the same thing
            return View(); //looks in view folder, then looks for Home Folder corresponding to HomeController, then looks for index file
        }
        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}