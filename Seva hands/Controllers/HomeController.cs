using Microsoft.AspNetCore.Mvc;
using Seva_hands.Models;
using System.Diagnostics;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.Net;

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
            string firebaseUrl = "https://sevahands-4c62d-default-rtdb.firebaseio.com/counter.json";
            try
            {
                // Create a WebRequest to the Firebase Realtime Database URL
                WebRequest request = WebRequest.Create(firebaseUrl);
                request.Method = "GET";

                // Get the WebResponse from the request
                using (WebResponse response = request.GetResponse())
                {
                    // Read the response data
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        string responseFromServer = reader.ReadToEnd();

                        // Parse the response as an integer
                        int counterValue = int.Parse(responseFromServer);

                        // Pass the counter value to the view
                        ViewBag.CounterValue = counterValue;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                ViewBag.Error = ex.Message;
            }

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