using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace TemplateDesignPatternDemo.Controllers
{
    public class HomeController : Controller
    {

        private ILogger _logger;

        public HomeController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger(typeof(HomeController).Name);
        }
        public IActionResult Index()
        {
            _logger.LogDebug("Starting Index page.");
            //throw new Exception("Intentional");
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            _logger.LogDebug("Starting About page.");

            //throw new Exception("Intentional");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
