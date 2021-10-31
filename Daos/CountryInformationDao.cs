using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Des_evaluacion_frontend.Helpers;
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
            List<CountryInformation> countryInformationList;

            try
            {
                var json = await File.ReadAllTextAsync("Models/InformationCA.json");
                countryInformationList = JsonConvert.DeserializeObject<List<CountryInformation>>(json);
                
                /*var request = WebRequest.Create(ApiService.ApiExtendedCountryInformation);
                var response = await request.GetResponseAsync();

                countryInformationList = JsonConvert.DeserializeObject<List<CountryInformation>>
                    (await new StreamReader(response.GetResponseStream()!).ReadToEndAsync());*/
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                countryInformationList = await _context.CountryInformation.ToListAsync();
            }

            return countryInformationList;
        }
        
        public async Task<CountryInformation> GetDataByCountry(string country) 
            => await _context.CountryInformation.FirstOrDefaultAsync(x => x.Country == country);

        public async Task Create(CountryInformation countryInformation)
        {
            await _context.CountryInformation.AddAsync(countryInformation);
            await _context.SaveChangesAsync();
        }
        
        public void DeleteAll()
        {
            _context.DataCountryInformation.Clear();
            _context.CountryInformation.Clear();
            _context.SaveChanges();
        }

    }
}