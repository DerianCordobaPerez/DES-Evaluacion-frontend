using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Des_evaluacion_frontend.Models
{
    public class ExtendedCountryInformation
    {
        [JsonPropertyName("location")]
        public string Location { get; set; }
        
        [JsonPropertyName("Population")]
        public int Population { get; set; }
        
        [JsonPropertyName("population_density")]
        public double PopulationDensity { get; set; }
        
        [JsonPropertyName("median_age")]
        public double MedianAge { get; set; }
        
        [JsonPropertyName("aged_65_older")]
        public double Aged65Older { get; set; }
        
        [JsonPropertyName("aged_70_older")]
        public double Aged70Older { get; set; }
        
        [JsonPropertyName("gdp_per_capita")]
        public double GdpPerCapita { get; set; }
        
        [JsonPropertyName("extreme_poverty")]
        public double ExtremePoverty { get; set; }
        
        [JsonPropertyName("cardiovasc_death_rate")]
        public double CardiovascDeathRate { get; set; }
        
        [JsonPropertyName("diabetes_prevalence")]
        public double DiabetesPrevalence { get; set; }
        
        [JsonPropertyName("hospital_beds_per_thousand")]
        public double HospitalBedsPerThousand { get; set; }
        
        [JsonPropertyName("life_expectancy")]
        public double LifeExpectancy { get; set; }
        
        [JsonPropertyName("human_development_index")]
        public double HumanDevelopmentIndex { get; set; }
        
        [JsonPropertyName("lat")]
        public string Latitude { get; set; }
        
        [JsonPropertyName("lon")]
        public string Longitude { get; set; }
        
        [JsonPropertyName("data")]
        public List<DataExtendedCountryInformation> Data { get; set; }
        
        [JsonPropertyName("female_smokers")]
        public double? FemaleSmokers { get; set; }
        
        [JsonPropertyName("male_smokers")]
        public double? MaleSmokers { get; set; }
        
        [JsonPropertyName("handwashing_facilities")]
        public double? HandwashingFacilities { get; set; }
        
        public class DataExtendedCountryInformation
        {
            [JsonPropertyName("date")]
            public string Date { get; set; }
            
            [JsonPropertyName("total_cases")]
            public int TotalCases { get; set; }
            
            [JsonPropertyName("new_cases")]
            public int NewCases { get; set; }
            
            [JsonPropertyName("new_cases_smoothed")]
            public double NewCasesSmoothed { get; set; }
            
            [JsonPropertyName("total_deaths")]
            public int TotalDeaths { get; set; }
            
            [JsonPropertyName("new_deaths")]
            public int NewDeaths { get; set; }
            
            [JsonPropertyName("new_deaths_smoothed")]
            public double NewDeathsSmoothed { get; set; }
            
            [JsonPropertyName("total_cases_per_million")]
            public double TotalCasesPerMillion { get; set; }
            
            [JsonPropertyName("new_cases_per_million")]
            public double NewCasesPerMillion { get; set; }
            
            [JsonPropertyName("new_cases_smoothed_per_million")]
            public double NewCasesSmoothedPerMillion { get; set; }
            
            [JsonPropertyName("total_deaths_per_million")]
            public double TotalDeathsPerMillion { get; set; }
            
            [JsonPropertyName("new_deaths_per_million")]
            public double NewDeathsPerMillion { get; set; }
            
            [JsonPropertyName("new_deaths_smoothed_per_million")]
            public double NewDeathsSmoothedPerMillion { get; set; }
            
            [JsonPropertyName("reproduction_rate")]
            public double ReproductionRate { get; set; }
            
            [JsonPropertyName("new_vaccinations_smoothed")]
            public int NewVaccinationsSmoothed { get; set; }
            
            [JsonPropertyName("new_vaccinations_smoothed_per_million")]
            public int NewVaccinationsSmoothedPerMillion { get; set; }
            
            [JsonPropertyName("stringency_index")]
            public double StringencyIndex { get; set; }
            
            [JsonPropertyName("total_vaccinations")]
            public int? TotalVaccinations { get; set; }
            
            [JsonPropertyName("people_vaccinated")]
            public int? PeopleVaccinated { get; set; }
            
            [JsonPropertyName("people_fully_vaccinated")]
            public int? PeopleFullyVaccinated { get; set; }
            
            [JsonPropertyName("total_vaccinations_per_hundred")]
            public double? TotalVaccinationsPerHundred { get; set; }
            
            [JsonPropertyName("people_vaccinated_per_hundred")]
            public double? PeopleVaccinatedPerHundred { get; set; }
            
            [JsonPropertyName("people_fully_vaccinated_per_hundred")]
            public double? PeopleFullyVaccinatedPerHundred { get; set; }
            
            [JsonPropertyName("new_tests")]
            public int? NewTests { get; set; }
            
            [JsonPropertyName("total_tests")]
            public int? TotalTests { get; set; }
            
            [JsonPropertyName("total_tests_per_thousand")]
            public double? TotalTestsPerThousand { get; set; }
            
            [JsonPropertyName("new_tests_per_thousand")]
            public double? NewTestsPerThousand { get; set; }
            
            [JsonPropertyName("new_tests_smoothed")]
            public int? NewTestsSmoothed { get; set; }
            
            [JsonPropertyName("new_tests_smoothed_per_thousand")]
            public double? NewTestsSmoothedPerThousand { get; set; }
            
            [JsonPropertyName("positive_rate")]
            public double? PositiveRate { get; set; }
            
            [JsonPropertyName("tests_per_case")]
            public double? TestsPerCase { get; set; }
            
            [JsonPropertyName("tests_units")]
            public string TestsUnits { get; set; }
            
            [JsonPropertyName("new_vaccinations")]
            public int? NewVaccinations { get; set; }
        }

    }
}