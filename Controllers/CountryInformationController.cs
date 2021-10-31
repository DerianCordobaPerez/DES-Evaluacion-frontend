using System.Threading.Tasks;
using Des_evaluacion_frontend.Daos;
using Des_evaluacion_frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Des_evaluacion_frontend.Controllers
{
    public class CountryInformationController : Controller
    {
        private readonly AppDBContext _context;
        
        public CountryInformationController(AppDBContext context)
        {
            _context = context;
        }
        
        [HttpGet("/countryInformation/getAll", Name = "CountryInformationList")]
        public async Task<IActionResult> GetCountryInformation()
        {
            var countryInformation = await new CountryInformationDao(_context).GetDataList();
            return Ok(countryInformation);
        }
    }
}