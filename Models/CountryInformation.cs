using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Des_evaluacion_frontend.Models
{
    public class CountryInformation
    {
        [JsonProperty(PropertyName = "COUNTRY")]
        public string Country { get; set; }
        
        [JsonProperty(PropertyName = "ISO_CODE")]
        public string IsoCode { get; set; }
        
        [JsonProperty(PropertyName = "data")]
        public List<DataCountryInformation> Data { get; set; }

        public class DataCountryInformation
        {
            [JsonProperty(PropertyName = "date")]
            public string Date { get; set; }
            
            [JsonProperty(PropertyName = "total_vaccinations")]
            public long TotalVaccinations { get; set; }
            
            [JsonProperty(PropertyName = "vaccine")]
            public string Vaccine { get; set; }
        }
        
    }
}