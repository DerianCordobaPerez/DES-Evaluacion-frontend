using System.Threading.Tasks;
using Des_evaluacion_frontend.Daos;
using Des_evaluacion_frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Des_evaluacion_frontend.Controllers
{
    public class ExtendedCountryInformationController : Controller
    {
        private readonly IModelDao<ExtendedCountryInformation> _extendedCountryInformationService;

        public ExtendedCountryInformationController(IModelDao<ExtendedCountryInformation> extendedCountryInformationService)
        {
            _extendedCountryInformationService = extendedCountryInformationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetExtendedCountryInformation()
        {
            var extendedCountryInformation = await _extendedCountryInformationService.GetDataList();
            return Ok(extendedCountryInformation);
        }
    }
}