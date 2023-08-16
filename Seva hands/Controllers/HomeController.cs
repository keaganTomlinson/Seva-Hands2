using Microsoft.AspNetCore.Mvc;
using Seva_hands.Models;
using System.Diagnostics;

namespace Seva_hands.Controllers
{
    
       
  

    public class HomeController : Controller
    {
        

        private readonly ILogger<HomeController> _logger;
        private static string PaypalUrl = "https://www.paypal.com/donate/?hosted_button_id=9A7RM3N4NQV3G";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.PaypalUrl = HomeController.PaypalUrl;
            return View();
        }
        public IActionResult About()
        {
            ViewBag.PaypalUrl = HomeController.PaypalUrl;
            return View();
        }
        public IActionResult Donate()
        {
            ViewBag.PaypalUrl = HomeController.PaypalUrl;
            return View();
        }
     
        public IActionResult Explore()
        {
            ViewBag.PaypalUrl = HomeController.PaypalUrl;
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.PaypalUrl = HomeController.PaypalUrl;
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.PaypalUrl = HomeController.PaypalUrl;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}