using System.Threading.Tasks;
using Des_evaluacion_frontend.Daos;
using Des_evaluacion_frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Des_evaluacion_frontend.Controllers
{
    public class CountryInformationController : Controller
    {
        private readonly AppDbContext _context;
        
        /// <summary>
        /// Constructor CountryInformationController
        /// </summary>
        /// <param name="context"></param>
        public CountryInformationController(AppDbContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Get all countries
        /// </summary>
        /// <returns>All countries</returns>
        [HttpGet("/countryInformation/getAll", Name = "CountryInformationList")]
        public async Task<IActionResult> GetCountryInformation()
        {
            var countryInformation = await new CountryInformationDao(_context).All();
            return Ok(countryInformation);
        }
    }
}