using ED_MVC.Domain;
using ED_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED_MVC.Controllers
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
            //return View("Index", "Home");
            //Produdct product = productsservice.GetProductById(1);
            return View(new Product() {Name = "Chocolate Bar"}); //Views/Home/Index
        }

        public IActionResult Privacy()
        {
            return View(); //Views/Home/Privacy
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
