using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using jQuery_AJAX_DEMO.Models;

namespace jQuery_AJAX_DEMO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // Action method for handling GET operation
        // Inside this Action method, simply the View is returned.
        // GET: Home
        public IActionResult Index()
        {
            return View();
        }
        // Action method for handling jQuery AJAX operation
        // This Action method handles the call made from the jQuery AJAX function from the View.

        // The value of the name parameter is assigned to the Name property of the PersonModel
        // object along with the Current DateTime and finally the PersonModel object is returned
        // back as JSON to the jQuery AJAX function.

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return Json(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
