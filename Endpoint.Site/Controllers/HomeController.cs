using Endpoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Endpoint.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Production()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }
        public IActionResult CEO()
        {
            return View();
        }
        public IActionResult Cooperation()
        {
            return View();
        }
    }
}