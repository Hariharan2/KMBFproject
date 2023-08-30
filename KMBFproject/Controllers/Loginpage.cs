using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KMBFproject.Controllers
{
    public class Loginpage : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
