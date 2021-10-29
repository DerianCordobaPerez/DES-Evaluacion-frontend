using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Des_evaluacion_frontend.Models
{
    public class CountryInformation
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
        
        [JsonProperty(PropertyName = "COUNTRY")]
        public string Country { get; set; }
        
        [JsonProperty(PropertyName = "ISO_CODE")]
        public string IsoCode { get; set; }
        
        [JsonProperty(PropertyName = "data")]
        public List<DataCountryInformation> Data { get; set; }

        public class DataCountryInformation
        {
            [JsonIgnore]
            [Key]
            public int Id { get; set; }
            
            [JsonProperty(PropertyName = "date")]
            public string Date { get; set; }
            
            [JsonProperty(PropertyName = "total_vaccinations")]
            public long TotalVaccinations { get; set; }
            
            [JsonProperty(PropertyName = "vaccine")]
            public string Vaccine { get; set; }
        }
        
    }
}