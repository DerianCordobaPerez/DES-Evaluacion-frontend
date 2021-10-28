using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Des_evaluacion_frontend.Models;
using Newtonsoft.Json;

namespace Des_evaluacion_frontend.Controllers
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
            var request = WebRequest.Create("https://api.jsonbin.io/b/614505444a82881d6c510a08");
            var response = request.GetResponse();

            var countryInformation = JsonConvert.DeserializeObject<List<CountryInformation>>
                (new StreamReader(response.GetResponseStream()!).ReadToEnd());

            return View(countryInformation!);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}