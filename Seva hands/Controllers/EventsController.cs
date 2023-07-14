using Microsoft.AspNetCore.Mvc;

namespace Seva_hands.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}
