using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeddingAnniversary.Areas.User.Models;
using WeddingAnniversary.Data;
using WeddingAnniversary.Models;

namespace WeddingAnniversary.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [Route("")]
        [Route("User")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("User/Home")]
        [Route("User/Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Invites(string email)
        {
            return RedirectToAction("Index", new { UserName = email });
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
    }
}
