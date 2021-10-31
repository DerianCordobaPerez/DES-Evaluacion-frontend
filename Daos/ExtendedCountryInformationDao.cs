using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Des_evaluacion_frontend.Models;
using Des_evaluacion_frontend.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Des_evaluacion_frontend.Daos
{
    public class ExtendedCountryInformationDao : IModelDao<ExtendedCountryInformation>
    {
        private readonly AppDBContext _context;

        public ExtendedCountryInformationDao(AppDBContext context)
        {
            _context = context;
        }
        
        public async Task<List<ExtendedCountryInformation>> GetDataList()
        {
            List<ExtendedCountryInformation> extendedCountryInformationList;
            
            try
            {
                var request = WebRequest.Create(ApiService.ApiExtendedCountryInformation);
                var response = await request.GetResponseAsync();

                extendedCountryInformationList = JsonConvert.DeserializeObject<List<ExtendedCountryInformation>>
                    (await new StreamReader(response.GetResponseStream()!).ReadToEndAsync());

                if (extendedCountryInformationList == null || extendedCountryInformationList!.Count == 0)
                    extendedCountryInformationList = await _context.ExtendedCountryInformation.ToListAsync();

            } 
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                extendedCountryInformationList = await _context.ExtendedCountryInformation.ToListAsync();
            }

            return extendedCountryInformationList;
        }
    }
}