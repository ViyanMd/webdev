using Microsoft.AspNetCore.Mvc;

namespace webdev.Controllers
{
    public class HomeController : Controller
    {
        [Route("{controller=Home}/{action=Index}")]
        public IActionResult Index() => View("Home");

        [Route("Home/About")]
        public IActionResult About() => View();
    }
}
