using System.Threading.Tasks;
using Des_evaluacion_frontend.Daos;
using Des_evaluacion_frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Des_evaluacion_frontend.Controllers
{
    public class ExtendedCountryInformationController : Controller
    {
        
        private readonly AppDbContext _context;

        public ExtendedCountryInformationController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all the extended countries
        /// </summary>
        /// <returns>All extended countries</returns>
        [HttpGet("/extendedCountryInformation/getAll", Name = "ExtendedCountryInformationList")]
        public async Task<IActionResult> GetExtendedCountryInformation()
        {
            var extendedCountryInformation = await new ExtendedCountryInformationDao(_context).All();
            return Ok(extendedCountryInformation);
        }
    }
}