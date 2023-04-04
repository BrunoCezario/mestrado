using Microsoft.AspNetCore.Mvc;

namespace SmartIO.Controllers
{
    public class DriversController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
