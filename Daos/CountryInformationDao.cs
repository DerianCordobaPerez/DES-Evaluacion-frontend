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
        private readonly AppDbContext _context;
        
        /// <summary>
        /// Constructor CountryInformationDao
        /// </summary>
        /// <param name="context"></param>
        public CountryInformationDao(AppDbContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Get all country information
        /// </summary>
        /// <returns>All country information</returns>
        public async Task<List<CountryInformation>> All()
        {
            List<CountryInformation> countryInformationList;

            try
            {
                var request = WebRequest.Create(ApiService.ApiCountryInformation);
                var response = await request.GetResponseAsync();

                countryInformationList = JsonConvert.DeserializeObject<List<CountryInformation>>
                    (await new StreamReader(response.GetResponseStream()!).ReadToEndAsync());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                countryInformationList = await _context.CountryInformation.ToListAsync();
            }

            return countryInformationList;
        }
        
        /// <summary>
        /// Create a new country information
        /// </summary>
        /// <param name="countryInformation"></param>
        public async Task Create(CountryInformation countryInformation)
        {
            await _context.CountryInformation.AddAsync(countryInformation);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Update a country information
        /// </summary>
        /// <param name="countryInformation"></param>
        public async Task Update(CountryInformation countryInformation)
        {
            _context.CountryInformation.Update(countryInformation);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Delete a country information
        /// </summary>
        /// <param name="countryInformation"></param>
        public async Task Delete(CountryInformation countryInformation)
        {
            _context.CountryInformation.Remove(countryInformation);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Drop all country information
        /// </summary>
        public async Task Drop()
        {
            _context.DataCountryInformation.Clear();
            _context.CountryInformation.Clear();
            await _context.SaveChangesAsync();
        }

    }
}