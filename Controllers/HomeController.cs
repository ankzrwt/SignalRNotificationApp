using Microsoft.AspNetCore.Mvc;
using SignalRApp.Models;
using System.Diagnostics;

namespace SignalRApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
