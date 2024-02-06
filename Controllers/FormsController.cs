using Microsoft.AspNetCore.Mvc;

namespace webdev.Controllers
{
    [Route("Forms")]
    public class FormsController : Controller
    {
        public IActionResult Index() => View();
        
        [HttpGet]
        [Route("Basic")]
        public IActionResult Basic() => View();
        
        [HttpPost]
        [Route("Basic")]
        public string Basic(string username, string password, int age, string comment) => 
            $"Name: {username} | Password: {password} | Age: {age} | Comment: {comment}";
        
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
