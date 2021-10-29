using System.Threading.Tasks;
using Des_evaluacion_frontend.Daos;
using Des_evaluacion_frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Des_evaluacion_frontend.Controllers
{
    public class ExtendedCountryInformationController : Controller
    {
        
        private readonly AppDBContext _context;

        public ExtendedCountryInformationController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet("/extendedCountryInformation/getAll", Name = "ExtendedCountryInformationList")]
        public async Task<IActionResult> GetExtendedCountryInformation()
        {
            var extendedCountryInformation = await new ExtendedCountryInformationDao(_context).GetDataList();
            return Ok(extendedCountryInformation);
        }
    }
}