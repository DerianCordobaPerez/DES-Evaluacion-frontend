using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Des_evaluacion_frontend.Models
{
    public class ExtendedCountryInformation
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
        
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
        
        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }
        
        [JsonProperty(PropertyName = "population_density")]
        public double PopulationDensity { get; set; }
        
        [JsonProperty(PropertyName = "median_age")]
        public double MedianAge { get; set; }
        
        [JsonProperty(PropertyName = "aged_65_older")]
        public double Aged65Older { get; set; }
        
        [JsonProperty(PropertyName = "aged_70_older")]
        public double Aged70Older { get; set; }
        
        [JsonProperty(PropertyName = "gdp_per_capita")]
        public double GdpPerCapita { get; set; }
        
        [JsonProperty(PropertyName = "extreme_poverty")]
        public double ExtremePoverty { get; set; }
        
        [JsonProperty(PropertyName = "cardiovasc_death_rate")]
        public double CardiovascDeathRate { get; set; }
        
        [JsonProperty(PropertyName = "diabetes_prevalence")]
        public double DiabetesPrevalence { get; set; }
        
        [JsonProperty(PropertyName = "hospital_beds_per_thousand")]
        public double HospitalBedsPerThousand { get; set; }
        
        [JsonProperty(PropertyName = "life_expectancy")]
        public double LifeExpectancy { get; set; }
        
        [JsonProperty(PropertyName = "human_development_index")]
        public double HumanDevelopmentIndex { get; set; }
        
        [JsonProperty(PropertyName = "Lat")]
        public string Latitude { get; set; }
        
        [JsonProperty(PropertyName = "Lon")]
        public string Longitude { get; set; }
        
        [JsonProperty(PropertyName = "data")]
        public List<DataExtendedCountryInformation> Data { get; set; }
        
        [JsonProperty(PropertyName = "female_smokers")]
        public double? FemaleSmokers { get; set; }
        
        [JsonProperty(PropertyName = "male_smokers")]
        public double? MaleSmokers { get; set; }
        
        [JsonProperty(PropertyName = "handwashing_facilities")]
        public double? HandwashingFacilities { get; set; }
        
        public class DataExtendedCountryInformation
        {
            [JsonIgnore]
            [Key]
            public int Id { get; set; }
            
            [JsonProperty(PropertyName = "date")]
            public string Date { get; set; }
            
            [JsonProperty(PropertyName = "total_cases")]
            public int TotalCases { get; set; }
            
            [JsonProperty(PropertyName = "new_cases")]
            public int NewCases { get; set; }
            
            [JsonProperty(PropertyName = "new_cases_smoothed")]
            public double NewCasesSmoothed { get; set; }
            
            [JsonProperty(PropertyName = "total_deaths")]
            public int TotalDeaths { get; set; }
            
            [JsonProperty(PropertyName = "new_deaths")]
            public int NewDeaths { get; set; }
            
            [JsonProperty(PropertyName = "new_deaths_smoothed")]
            public double NewDeathsSmoothed { get; set; }
            
            [JsonProperty(PropertyName = "total_cases_per_million")]
            public double TotalCasesPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "new_cases_per_million")]
            public double NewCasesPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "new_cases_smoothed_per_million")]
            public double NewCasesSmoothedPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "total_deaths_per_million")]
            public double TotalDeathsPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "new_deaths_per_million")]
            public double NewDeathsPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "new_deaths_smoothed_per_million")]
            public double NewDeathsSmoothedPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "reproduction_rate")]
            public double ReproductionRate { get; set; }
            
            [JsonProperty(PropertyName = "new_vaccinations_smoothed")]
            public int NewVaccinationsSmoothed { get; set; }
            
            [JsonProperty(PropertyName = "new_vaccinations_smoothed_per_million")]
            public int NewVaccinationsSmoothedPerMillion { get; set; }
            
            [JsonProperty(PropertyName = "stringency_index")]
            public double StringencyIndex { get; set; }
            
            [JsonProperty(PropertyName = "total_vaccinations")]
            public int? TotalVaccinations { get; set; }
            
            [JsonProperty(PropertyName = "people_vaccinated")]
            public int? PeopleVaccinated { get; set; }
            
            [JsonProperty(PropertyName = "People_fully_vaccinated")]
            public int? PeopleFullyVaccinated { get; set; }
            
            [JsonProperty(PropertyName = "total_vaccinations_per_hundred")]
            public double? TotalVaccinationsPerHundred { get; set; }
            
            [JsonProperty(PropertyName = "people_vaccinated_per_hundred")]
            public double? PeopleVaccinatedPerHundred { get; set; }
            
            [JsonProperty(PropertyName = "people_fully_vaccinated_per_hundred")]
            public double? PeopleFullyVaccinatedPerHundred { get; set; }
            
            [JsonProperty(PropertyName = "new_tests")]
            public int? NewTests { get; set; }
            
            [JsonProperty(PropertyName = "total_tests")]
            public int? TotalTests { get; set; }
            
            [JsonProperty(PropertyName = "total_tests_per_thousand")]
            public double? TotalTestsPerThousand { get; set; }
            
            [JsonProperty(PropertyName = "new_tests_per_thousand")]
            public double? NewTestsPerThousand { get; set; }
            
            [JsonProperty(PropertyName = "new_tests_smoothed")]
            public int? NewTestsSmoothed { get; set; }
            
            [JsonProperty(PropertyName = "new_tests_smoothed_per_thousand")]
            public double? NewTestsSmoothedPerThousand { get; set; }
            
            [JsonProperty(PropertyName = "positive_rate")]
            public double? PositiveRate { get; set; }
            
            [JsonProperty(PropertyName = "tests_per_case")]
            public double? TestsPerCase { get; set; }
            
            [JsonProperty(PropertyName = "tests_units")]
            public string TestsUnits { get; set; }
            
            [JsonProperty(PropertyName = "new_vaccinations")]
            public int? NewVaccinations { get; set; }
        }

    }
}