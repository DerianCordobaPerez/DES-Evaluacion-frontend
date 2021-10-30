using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Des_evaluacion_frontend.Models;
using Des_evaluacion_frontend.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Des_evaluacion_frontend.Daos
{
    public class CountryInformationDao : IModelDao<CountryInformation>
    {
        private readonly AppDBContext _context;
        
        public CountryInformationDao(AppDBContext context)
        {
            _context = context;
        }
        
        public async Task<List<CountryInformation>> GetDataList()
        {
            try
            {
                var request = WebRequest.Create(ApiService.ApiCountryInformation);
                var response = await request.GetResponseAsync();

                return JsonConvert.DeserializeObject<List<CountryInformation>>
                    (await new StreamReader(response.GetResponseStream()!).ReadToEndAsync());
            } 
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return await _context.CountryInformation.ToListAsync();
            }
        }
    }
}