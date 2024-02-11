using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webdev.Data;

namespace webdev.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext _db)
        {
            db = _db;
        }

        [Route("{controller=Home}/{action=Index}")]
        public async Task<IActionResult> Index() => View(await db.users.ToListAsync());

        [Route("Home/About")]
        public IActionResult About() => View();
    }
}
