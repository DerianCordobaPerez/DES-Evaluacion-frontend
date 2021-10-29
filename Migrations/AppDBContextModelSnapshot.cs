﻿// <auto-generated />
using System;
using Des_evaluacion_frontend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Des_evaluacion_frontend.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Des_evaluacion_frontend.Models.CountryInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("IsoCode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CountryInformation");
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.CountryInformation+DataCountryInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CountryInformationId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("longtext");

                    b.Property<long>("TotalVaccinations")
                        .HasColumnType("bigint");

                    b.Property<string>("Vaccine")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CountryInformationId");

                    b.ToTable("DataCountryInformation");
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.ExtendedCountryInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Aged65Older")
                        .HasColumnType("double");

                    b.Property<double>("Aged70Older")
                        .HasColumnType("double");

                    b.Property<double>("CardiovascDeathRate")
                        .HasColumnType("double");

                    b.Property<double>("DiabetesPrevalence")
                        .HasColumnType("double");

                    b.Property<double>("ExtremePoverty")
                        .HasColumnType("double");

                    b.Property<double?>("FemaleSmokers")
                        .HasColumnType("double");

                    b.Property<double>("GdpPerCapita")
                        .HasColumnType("double");

                    b.Property<double?>("HandwashingFacilities")
                        .HasColumnType("double");

                    b.Property<double>("HospitalBedsPerThousand")
                        .HasColumnType("double");

                    b.Property<double>("HumanDevelopmentIndex")
                        .HasColumnType("double");

                    b.Property<string>("Latitude")
                        .HasColumnType("longtext");

                    b.Property<double>("LifeExpectancy")
                        .HasColumnType("double");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .HasColumnType("longtext");

                    b.Property<double?>("MaleSmokers")
                        .HasColumnType("double");

                    b.Property<double>("MedianAge")
                        .HasColumnType("double");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<double>("PopulationDensity")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("ExtendedCountryInformation");
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.ExtendedCountryInformation+DataExtendedCountryInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("longtext");

                    b.Property<int?>("ExtendedCountryInformationId")
                        .HasColumnType("int");

                    b.Property<int>("NewCases")
                        .HasColumnType("int");

                    b.Property<double>("NewCasesPerMillion")
                        .HasColumnType("double");

                    b.Property<double>("NewCasesSmoothed")
                        .HasColumnType("double");

                    b.Property<double>("NewCasesSmoothedPerMillion")
                        .HasColumnType("double");

                    b.Property<int>("NewDeaths")
                        .HasColumnType("int");

                    b.Property<double>("NewDeathsPerMillion")
                        .HasColumnType("double");

                    b.Property<double>("NewDeathsSmoothed")
                        .HasColumnType("double");

                    b.Property<double>("NewDeathsSmoothedPerMillion")
                        .HasColumnType("double");

                    b.Property<int?>("NewTests")
                        .HasColumnType("int");

                    b.Property<double?>("NewTestsPerThousand")
                        .HasColumnType("double");

                    b.Property<int?>("NewTestsSmoothed")
                        .HasColumnType("int");

                    b.Property<double?>("NewTestsSmoothedPerThousand")
                        .HasColumnType("double");

                    b.Property<int?>("NewVaccinations")
                        .HasColumnType("int");

                    b.Property<int>("NewVaccinationsSmoothed")
                        .HasColumnType("int");

                    b.Property<int>("NewVaccinationsSmoothedPerMillion")
                        .HasColumnType("int");

                    b.Property<int?>("PeopleFullyVaccinated")
                        .HasColumnType("int");

                    b.Property<double?>("PeopleFullyVaccinatedPerHundred")
                        .HasColumnType("double");

                    b.Property<int?>("PeopleVaccinated")
                        .HasColumnType("int");

                    b.Property<double?>("PeopleVaccinatedPerHundred")
                        .HasColumnType("double");

                    b.Property<double?>("PositiveRate")
                        .HasColumnType("double");

                    b.Property<double>("ReproductionRate")
                        .HasColumnType("double");

                    b.Property<double>("StringencyIndex")
                        .HasColumnType("double");

                    b.Property<double?>("TestsPerCase")
                        .HasColumnType("double");

                    b.Property<string>("TestsUnits")
                        .HasColumnType("longtext");

                    b.Property<int>("TotalCases")
                        .HasColumnType("int");

                    b.Property<double>("TotalCasesPerMillion")
                        .HasColumnType("double");

                    b.Property<int>("TotalDeaths")
                        .HasColumnType("int");

                    b.Property<double>("TotalDeathsPerMillion")
                        .HasColumnType("double");

                    b.Property<int?>("TotalTests")
                        .HasColumnType("int");

                    b.Property<double?>("TotalTestsPerThousand")
                        .HasColumnType("double");

                    b.Property<int?>("TotalVaccinations")
                        .HasColumnType("int");

                    b.Property<double?>("TotalVaccinationsPerHundred")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ExtendedCountryInformationId");

                    b.ToTable("DataExtendedCountryInformation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.CountryInformation+DataCountryInformation", b =>
                {
                    b.HasOne("Des_evaluacion_frontend.Models.CountryInformation", null)
                        .WithMany("Data")
                        .HasForeignKey("CountryInformationId");
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.ExtendedCountryInformation+DataExtendedCountryInformation", b =>
                {
                    b.HasOne("Des_evaluacion_frontend.Models.ExtendedCountryInformation", null)
                        .WithMany("Data")
                        .HasForeignKey("ExtendedCountryInformationId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.CountryInformation", b =>
                {
                    b.Navigation("Data");
                });

            modelBuilder.Entity("Des_evaluacion_frontend.Models.ExtendedCountryInformation", b =>
                {
                    b.Navigation("Data");
                });
#pragma warning restore 612, 618
        }
    }
}
