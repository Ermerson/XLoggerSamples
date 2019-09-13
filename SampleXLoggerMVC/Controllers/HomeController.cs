using Microsoft.AspNetCore.Mvc;
using SampleXLoggerMVC.Models;
using System.Diagnostics;
using XLogger.Adapters.Console;

namespace SampleXLoggerMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConsoleLogger _consoleLogger;
        public HomeController(IConsoleLogger consoleLogger)
        {
            _consoleLogger = consoleLogger;
        }

        public IActionResult Index()
        {
            System.Console.WriteLine("Teste novamente");
            _consoleLogger.Information("Logou");
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
    }
}
