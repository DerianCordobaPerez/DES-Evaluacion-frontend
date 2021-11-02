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
    public class ExtendedCountryInformationDao : IModelDao<ExtendedCountryInformation>
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Constructor ExtendedCountryInformationDao
        /// </summary>
        /// <param name="context"></param>
        public ExtendedCountryInformationDao(AppDbContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Get all ExtendedCountryInformation
        /// </summary>
        /// <returns>All Extended country information</returns>
        public async Task<List<ExtendedCountryInformation>> All()
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
        
        /// <summary>
        /// Create a new ExtendedCountryInformation
        /// </summary>
        /// <param name="extendedCountryInformation"></param>
        public async Task Create(ExtendedCountryInformation extendedCountryInformation)
        {
            _context.ExtendedCountryInformation.Add(extendedCountryInformation);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Update an ExtendedCountryInformation
        /// </summary>
        /// <param name="extendedCountryInformation"></param>
        public async Task Update(ExtendedCountryInformation extendedCountryInformation)
        {
            _context.ExtendedCountryInformation.Update(extendedCountryInformation);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Delete an ExtendedCountryInformation
        /// </summary>
        /// <param name="extendedCountryInformation"></param>
        public async Task Delete(ExtendedCountryInformation extendedCountryInformation)
        {
            _context.ExtendedCountryInformation.Remove(extendedCountryInformation);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Drop all ExtendedCountryInformation
        /// </summary>
        public async Task Drop()
        {
            _context.ExtendedCountryInformation.Clear();
            await _context.SaveChangesAsync();
        }

    }
}