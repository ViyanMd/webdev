using Microsoft.AspNetCore.Mvc;
using webdev.Data;
using webdev.Models;

namespace webdev.Controllers
{
    [Route("Forms")]
    public class FormsController : Controller
    {
        ApplicationContext db;
        public FormsController(ApplicationContext _db)
        {
            db = _db;
        }

        public IActionResult Index() => View();

        [HttpGet]
        [Route("Basic")]
        public IActionResult Basic() => View();

        [HttpPost]
        [Route("Basic")]
        public async Task<IActionResult> Basic(User user)
        {
            db.users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("Checkbox")]
        public IActionResult Checkbox() => View();
        
        [HttpPost]
        [Route("Checkbox")]
        public string Checkbox(bool isSelected) => $"Is Selected: {isSelected}";


        [HttpGet]
        [Route("Radio")]
        public IActionResult Radio() => View();

        [HttpPost]
        [Route("Radio")]
        public string Radio(string color) => $"Color: {color}";

        [HttpGet]
        [Route("Select")]
        public IActionResult Select() => View();

        [HttpPost]
        [Route("Select")]
        public string Select(string[] languages)
        {
            string result = "You've chosen:";
            foreach (string lang in languages)
            {
                result = $"{result} {lang};";
            }
            return result;
        }
    }
}
