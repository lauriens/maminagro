using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anthromes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anthromes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Biomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColetaMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColetaMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ContinentName = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDestinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    GbifId = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDestinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleAreaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    IsSnuc = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleAreaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ufs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Abbreviation = table.Column<string>(type: "character(2)", fixedLength: true, maxLength: 2, nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ufs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ufs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kingdoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DomainId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kingdoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kingdoms_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: true),
                    ReferenceTypeId = table.Column<int>(type: "integer", nullable: true),
                    ReferenceId = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    BibtexKey = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                    table.ForeignKey(
                        name: "FK_References_ReferenceTypes_ReferenceTypeId",
                        column: x => x.ReferenceTypeId,
                        principalTable: "ReferenceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Localities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: true),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localities_SampleAreaTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "SampleAreaTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    UfId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipalities_Ufs_UfId",
                        column: x => x.UfId,
                        principalTable: "Ufs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Phyla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    KingdomId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phyla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phyla_Kingdoms_KingdomId",
                        column: x => x.KingdomId,
                        principalTable: "Kingdoms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudyCollectMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SampleDrawing = table.Column<int>(type: "integer", nullable: true),
                    SamplingEffort = table.Column<decimal>(type: "numeric", nullable: true),
                    SamplingEffortUnit = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    CollectStartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CollectEndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MaterialDestinationId = table.Column<int>(type: "integer", nullable: true),
                    ReferenceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyCollectMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyCollectMethods_MaterialDestinations_MaterialDestinatio~",
                        column: x => x.MaterialDestinationId,
                        principalTable: "MaterialDestinations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudyCollectMethods_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Landscapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: true),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: true),
                    Radius = table.Column<decimal>(type: "numeric", nullable: true),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    IsProtectedArea = table.Column<bool>(type: "boolean", nullable: true),
                    Agroecosystem = table.Column<int>(type: "integer", nullable: false),
                    AnthromeId = table.Column<int>(type: "integer", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    ReferenceId = table.Column<int>(type: "integer", nullable: true),
                    SampleAreaTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landscapes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landscapes_Anthromes_AnthromeId",
                        column: x => x.AnthromeId,
                        principalTable: "Anthromes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Landscapes_Municipalities_CityId",
                        column: x => x.CityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Landscapes_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Landscapes_SampleAreaTypes_SampleAreaTypeId",
                        column: x => x.SampleAreaTypeId,
                        principalTable: "SampleAreaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    PhylumId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Phyla_PhylumId",
                        column: x => x.PhylumId,
                        principalTable: "Phyla",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BiomeLandscape",
                columns: table => new
                {
                    BiomesId = table.Column<int>(type: "integer", nullable: false),
                    LandscapesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiomeLandscape", x => new { x.BiomesId, x.LandscapesId });
                    table.ForeignKey(
                        name: "FK_BiomeLandscape_Biomes_BiomesId",
                        column: x => x.BiomesId,
                        principalTable: "Biomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiomeLandscape_Landscapes_LandscapesId",
                        column: x => x.LandscapesId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandscapeAreaTypes",
                columns: table => new
                {
                    LandscapeId = table.Column<int>(type: "integer", nullable: false),
                    AreaTypeId = table.Column<int>(type: "integer", nullable: false),
                    Percentage = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandscapeAreaTypes", x => new { x.AreaTypeId, x.LandscapeId });
                    table.ForeignKey(
                        name: "FK_LandscapeAreaTypes_AreaTypes_AreaTypeId",
                        column: x => x.AreaTypeId,
                        principalTable: "AreaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandscapeAreaTypes_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandscapeLocality",
                columns: table => new
                {
                    LandscapesId = table.Column<int>(type: "integer", nullable: false),
                    LocalitiesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandscapeLocality", x => new { x.LandscapesId, x.LocalitiesId });
                    table.ForeignKey(
                        name: "FK_LandscapeLocality_Landscapes_LandscapesId",
                        column: x => x.LandscapesId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandscapeLocality_Localities_LocalitiesId",
                        column: x => x.LocalitiesId,
                        principalTable: "Localities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandscapeStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Value = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    LandscapeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandscapeStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandscapeStatistics_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ClassId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Families_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    FamilyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genera_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CultureSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    GenusId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CultureSpecies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CultureSpecies_Genera_GenusId",
                        column: x => x.GenusId,
                        principalTable: "Genera",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    GenusId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Species_Genera_GenusId",
                        column: x => x.GenusId,
                        principalTable: "Genera",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cultures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CommonName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Variety = table.Column<string>(type: "text", nullable: true),
                    Phenology = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    PlantedArea = table.Column<decimal>(type: "numeric", nullable: true),
                    TimeSincePlanting = table.Column<int>(type: "integer", nullable: true),
                    TimeSincePlantingUnit = table.Column<int>(type: "integer", nullable: false),
                    LandscapeId = table.Column<int>(type: "integer", nullable: true),
                    SpeciesType = table.Column<int>(type: "integer", nullable: true),
                    SpecieId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cultures_CultureSpecies_SpecieId",
                        column: x => x.SpecieId,
                        principalTable: "CultureSpecies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cultures_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThreatDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Classification = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Source = table.Column<int>(type: "integer", nullable: false),
                    UfId = table.Column<int>(type: "integer", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: true),
                    SpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreatDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThreatDegrees_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThreatDegrees_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThreatDegrees_Ufs_UfId",
                        column: x => x.UfId,
                        principalTable: "Ufs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Occurrences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OccurrenceTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDuplicate = table.Column<bool>(type: "boolean", nullable: true),
                    OccurrenceType = table.Column<int>(type: "integer", nullable: false),
                    IsSnucOccurrence = table.Column<bool>(type: "boolean", nullable: false),
                    ReviewerObservation = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    ThreatDegreeId = table.Column<int>(type: "integer", nullable: true),
                    OccurenceMethodId = table.Column<int>(type: "integer", nullable: true),
                    SpeciesId = table.Column<int>(type: "integer", nullable: true),
                    ReferenceId = table.Column<int>(type: "integer", nullable: true),
                    LocalityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occurrences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Occurrences_ColetaMethods_OccurenceMethodId",
                        column: x => x.OccurenceMethodId,
                        principalTable: "ColetaMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Occurrences_Localities_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Localities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Occurrences_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Occurrences_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Occurrences_ThreatDegrees_ThreatDegreeId",
                        column: x => x.ThreatDegreeId,
                        principalTable: "ThreatDegrees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Occurrences_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abundances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AbundanceValue = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LandscapeId = table.Column<int>(type: "integer", nullable: false),
                    OccurrenceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abundances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abundances_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Abundances_Occurrences_OccurrenceId",
                        column: x => x.OccurrenceId,
                        principalTable: "Occurrences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OccurrenceCultures",
                columns: table => new
                {
                    CultureId = table.Column<int>(type: "integer", nullable: false),
                    OccurenceId = table.Column<int>(type: "integer", nullable: false),
                    Stage = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Phenology = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    Percentage = table.Column<int>(type: "integer", nullable: true),
                    IsMajority = table.Column<bool>(type: "boolean", nullable: true),
                    Area = table.Column<decimal>(type: "numeric", nullable: true),
                    Productivity = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccurrenceCultures", x => new { x.CultureId, x.OccurenceId });
                    table.ForeignKey(
                        name: "FK_OccurrenceCultures_Cultures_CultureId",
                        column: x => x.CultureId,
                        principalTable: "Cultures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccurrenceCultures_Occurrences_OccurenceId",
                        column: x => x.OccurenceId,
                        principalTable: "Occurrences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abundances_LandscapeId",
                table: "Abundances",
                column: "LandscapeId");

            migrationBuilder.CreateIndex(
                name: "IX_Abundances_OccurrenceId",
                table: "Abundances",
                column: "OccurrenceId");

            migrationBuilder.CreateIndex(
                name: "IX_BiomeLandscape_LandscapesId",
                table: "BiomeLandscape",
                column: "LandscapesId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_PhylumId",
                table: "Classes",
                column: "PhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Cultures_LandscapeId",
                table: "Cultures",
                column: "LandscapeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cultures_SpecieId",
                table: "Cultures",
                column: "SpecieId");

            migrationBuilder.CreateIndex(
                name: "IX_CultureSpecies_GenusId",
                table: "CultureSpecies",
                column: "GenusId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_OrderId",
                table: "Families",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Genera_FamilyId",
                table: "Genera",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Kingdoms_DomainId",
                table: "Kingdoms",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeAreaTypes_LandscapeId",
                table: "LandscapeAreaTypes",
                column: "LandscapeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeLocality_LocalitiesId",
                table: "LandscapeLocality",
                column: "LocalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Landscapes_AnthromeId",
                table: "Landscapes",
                column: "AnthromeId");

            migrationBuilder.CreateIndex(
                name: "IX_Landscapes_CityId",
                table: "Landscapes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Landscapes_ReferenceId",
                table: "Landscapes",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Landscapes_SampleAreaTypeId",
                table: "Landscapes",
                column: "SampleAreaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeStatistics_LandscapeId",
                table: "LandscapeStatistics",
                column: "LandscapeId");

            migrationBuilder.CreateIndex(
                name: "IX_Localities_TypeId",
                table: "Localities",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_UfId",
                table: "Municipalities",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_OccurrenceCultures_OccurenceId",
                table: "OccurrenceCultures",
                column: "OccurenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrences_CreatedBy",
                table: "Occurrences",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrences_LocalityId",
                table: "Occurrences",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrences_OccurenceMethodId",
                table: "Occurrences",
                column: "OccurenceMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrences_ReferenceId",
                table: "Occurrences",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrences_SpeciesId",
                table: "Occurrences",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrences_ThreatDegreeId",
                table: "Occurrences",
                column: "ThreatDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClassId",
                table: "Orders",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Phyla_KingdomId",
                table: "Phyla",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_References_ReferenceTypeId",
                table: "References",
                column: "ReferenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_GenusId",
                table: "Species",
                column: "GenusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyCollectMethods_MaterialDestinationId",
                table: "StudyCollectMethods",
                column: "MaterialDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyCollectMethods_ReferenceId",
                table: "StudyCollectMethods",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreatDegrees_CountryId",
                table: "ThreatDegrees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreatDegrees_SpeciesId",
                table: "ThreatDegrees",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreatDegrees_UfId",
                table: "ThreatDegrees",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Ufs_CountryId",
                table: "Ufs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abundances");

            migrationBuilder.DropTable(
                name: "BiomeLandscape");

            migrationBuilder.DropTable(
                name: "LandscapeAreaTypes");

            migrationBuilder.DropTable(
                name: "LandscapeLocality");

            migrationBuilder.DropTable(
                name: "LandscapeStatistics");

            migrationBuilder.DropTable(
                name: "OccurrenceCultures");

            migrationBuilder.DropTable(
                name: "StudyCollectMethods");

            migrationBuilder.DropTable(
                name: "Biomes");

            migrationBuilder.DropTable(
                name: "AreaTypes");

            migrationBuilder.DropTable(
                name: "Cultures");

            migrationBuilder.DropTable(
                name: "Occurrences");

            migrationBuilder.DropTable(
                name: "MaterialDestinations");

            migrationBuilder.DropTable(
                name: "CultureSpecies");

            migrationBuilder.DropTable(
                name: "Landscapes");

            migrationBuilder.DropTable(
                name: "ColetaMethods");

            migrationBuilder.DropTable(
                name: "Localities");

            migrationBuilder.DropTable(
                name: "ThreatDegrees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Anthromes");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "SampleAreaTypes");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Ufs");

            migrationBuilder.DropTable(
                name: "ReferenceTypes");

            migrationBuilder.DropTable(
                name: "Genera");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Phyla");

            migrationBuilder.DropTable(
                name: "Kingdoms");

            migrationBuilder.DropTable(
                name: "Domains");
        }
    }
}
