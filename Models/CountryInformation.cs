using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Des_evaluacion_frontend.Models
{
    public class CountryInformation
    {
        [JsonPropertyName("COUNTRY")]
        public string Country { get; set; }
        
        [JsonPropertyName("ISO_CODE")]
        public string IsoCode { get; set; }
        
        [JsonPropertyName("data")]
        public List<DataCountryInformation> Data { get; set; }

        public class DataCountryInformation
        {
            [JsonPropertyName("date")]
            public DateTime Date { get; set; }
            
            [JsonPropertyName("total_vaccinations")]
            public long TotalVaccinations { get; set; }
            
            [JsonPropertyName("vaccine")]
            public string Vaccine { get; set; }
        }
        
    }
}