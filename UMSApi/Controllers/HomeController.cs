using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using umsApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using umsApp.Models;
using Microsoft.Extensions.Logging;

namespace umsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // New API endpoint
        [HttpGet("api/data")]
        public JsonResult GetData()
        {
            return Json(new { message = "Hello, world!" });
        }
    }
}
