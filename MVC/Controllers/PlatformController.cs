using Microsoft.AspNetCore.Mvc;

namespace CI_Platform.Controllers
{
    public class PlatformController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
