using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Party.Data;
using Party.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Party.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ResponsesDb _db;

        public HomeController(ILogger<HomeController> logger, ResponsesDb db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //RsvpForm Get
        public IActionResult RsvpForm()
        {
            Invited obj = new Invited();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RsvpForm(Invited invited)
        {
            if (ModelState.IsValid)
            {
                _db.Invited.Add(invited);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(invited);
        }

        public IActionResult ListResponses()
        {
            IEnumerable<Invited> obj = _db.Invited;
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
