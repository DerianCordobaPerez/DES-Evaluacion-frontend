using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
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
            // Request from api
            var request = WebRequest.Create("https://api.jsonbin.io/b/614507ed4a82881d6c510b6b/10");
            
            // Response obtain from request api
            var response = request.GetResponse();

            // Object (ExtendedCountryInformation) obtain from json response
            var extendedCountryInformation = JsonConvert.DeserializeObject<List<ExtendedCountryInformation>>
                (new StreamReader(response.GetResponseStream()!).ReadToEnd());

            return View(extendedCountryInformation!);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}