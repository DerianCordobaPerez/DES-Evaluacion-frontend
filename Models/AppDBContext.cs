using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Des_evaluacion_frontend.Models
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opptions) : base(opptions) { }
        
        public DbSet<ExtendedCountryInformation> ExtendedCountryInformation { get; set; }
        public DbSet<CountryInformation> CountryInformation { get; set; }
    }
}