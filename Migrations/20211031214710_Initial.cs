using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Des_evaluacion_frontend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CountryInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsoCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataSerialized = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryInformation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DataCountryInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalVaccinations = table.Column<long>(type: "bigint", nullable: false),
                    Vaccine = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCountryInformation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExtendedCountryInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Population = table.Column<int>(type: "int", nullable: false),
                    PopulationDensity = table.Column<double>(type: "double", nullable: false),
                    MedianAge = table.Column<double>(type: "double", nullable: false),
                    Aged65Older = table.Column<double>(type: "double", nullable: false),
                    Aged70Older = table.Column<double>(type: "double", nullable: false),
                    GdpPerCapita = table.Column<double>(type: "double", nullable: false),
                    ExtremePoverty = table.Column<double>(type: "double", nullable: false),
                    CardiovascDeathRate = table.Column<double>(type: "double", nullable: false),
                    DiabetesPrevalence = table.Column<double>(type: "double", nullable: false),
                    HospitalBedsPerThousand = table.Column<double>(type: "double", nullable: false),
                    LifeExpectancy = table.Column<double>(type: "double", nullable: false),
                    HumanDevelopmentIndex = table.Column<double>(type: "double", nullable: false),
                    Latitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FemaleSmokers = table.Column<double>(type: "double", nullable: true),
                    MaleSmokers = table.Column<double>(type: "double", nullable: true),
                    HandwashingFacilities = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtendedCountryInformation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DataExtendedCountryInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalCases = table.Column<int>(type: "int", nullable: false),
                    NewCases = table.Column<int>(type: "int", nullable: false),
                    NewCasesSmoothed = table.Column<double>(type: "double", nullable: false),
                    TotalDeaths = table.Column<int>(type: "int", nullable: false),
                    NewDeaths = table.Column<int>(type: "int", nullable: false),
                    NewDeathsSmoothed = table.Column<double>(type: "double", nullable: false),
                    TotalCasesPerMillion = table.Column<double>(type: "double", nullable: false),
                    NewCasesPerMillion = table.Column<double>(type: "double", nullable: false),
                    NewCasesSmoothedPerMillion = table.Column<double>(type: "double", nullable: false),
                    TotalDeathsPerMillion = table.Column<double>(type: "double", nullable: false),
                    NewDeathsPerMillion = table.Column<double>(type: "double", nullable: false),
                    NewDeathsSmoothedPerMillion = table.Column<double>(type: "double", nullable: false),
                    ReproductionRate = table.Column<double>(type: "double", nullable: false),
                    NewVaccinationsSmoothed = table.Column<int>(type: "int", nullable: false),
                    NewVaccinationsSmoothedPerMillion = table.Column<int>(type: "int", nullable: false),
                    StringencyIndex = table.Column<double>(type: "double", nullable: false),
                    TotalVaccinations = table.Column<int>(type: "int", nullable: true),
                    PeopleVaccinated = table.Column<int>(type: "int", nullable: true),
                    PeopleFullyVaccinated = table.Column<int>(type: "int", nullable: true),
                    TotalVaccinationsPerHundred = table.Column<double>(type: "double", nullable: true),
                    PeopleVaccinatedPerHundred = table.Column<double>(type: "double", nullable: true),
                    PeopleFullyVaccinatedPerHundred = table.Column<double>(type: "double", nullable: true),
                    NewTests = table.Column<int>(type: "int", nullable: true),
                    TotalTests = table.Column<int>(type: "int", nullable: true),
                    TotalTestsPerThousand = table.Column<double>(type: "double", nullable: true),
                    NewTestsPerThousand = table.Column<double>(type: "double", nullable: true),
                    NewTestsSmoothed = table.Column<int>(type: "int", nullable: true),
                    NewTestsSmoothedPerThousand = table.Column<double>(type: "double", nullable: true),
                    PositiveRate = table.Column<double>(type: "double", nullable: true),
                    TestsPerCase = table.Column<double>(type: "double", nullable: true),
                    TestsUnits = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NewVaccinations = table.Column<int>(type: "int", nullable: true),
                    ExtendedCountryInformationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataExtendedCountryInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataExtendedCountryInformation_ExtendedCountryInformation_Ex~",
                        column: x => x.ExtendedCountryInformationId,
                        principalTable: "ExtendedCountryInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DataExtendedCountryInformation_ExtendedCountryInformationId",
                table: "DataExtendedCountryInformation",
                column: "ExtendedCountryInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryInformation");

            migrationBuilder.DropTable(
                name: "DataCountryInformation");

            migrationBuilder.DropTable(
                name: "DataExtendedCountryInformation");

            migrationBuilder.DropTable(
                name: "ExtendedCountryInformation");
        }
    }
}
