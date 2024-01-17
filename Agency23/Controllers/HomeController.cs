using Agency23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agency23.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
             
    }
}
