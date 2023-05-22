using Microsoft.AspNetCore.Mvc;

namespace hw.Controllers
{
    public class helow : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
