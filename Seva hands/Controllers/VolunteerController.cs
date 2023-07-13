using Microsoft.AspNetCore.Mvc;

namespace Seva_hands.Controllers
{
    public class VolunteerController : Controller
    {
       

        public IActionResult volunteer()
        {
            return View();
        }
    }
}
