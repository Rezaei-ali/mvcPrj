using GeneralCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeneralCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new Contact();
            return View(model);
        }

        
        public IActionResult Contact()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public IActionResult RegisterContact(IFormCollection iforms)
        //{
        //    var a = iforms["name"];

        //    return Json(iforms);
        //}

        [HttpPost]
        public IActionResult RegisterContact(Contact form)
        {
            var a = form.Name;
            var b = form.Service;
            return RedirectToAction("Contact");
        }


        public IActionResult Re() {

            return new StatusCodeResult(401);
            } 
    }
}