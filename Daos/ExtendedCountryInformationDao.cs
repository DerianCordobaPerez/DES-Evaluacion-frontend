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
            try
            {
                var request = WebRequest.Create(ApiService.ApiExtendedCountryInformation);
                var response = await request.GetResponseAsync();

                return JsonConvert.DeserializeObject<List<ExtendedCountryInformation>>
                    (await new StreamReader(response.GetResponseStream()!).ReadToEndAsync());
            } 
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return await _context.ExtendedCountryInformation.ToListAsync();
            }
        }
    }
}