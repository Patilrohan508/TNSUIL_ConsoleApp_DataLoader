using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TNSUIL_ConsoleApp_DataLoader.Migrations
{
    /// <inheritdoc />
    public partial class InitialMainDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "atmospheric_pressure",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atmospheric_pressure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "evapo_transpiration",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evapo_transpiration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ground_water_level",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: false),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: true),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ground_water_level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rainfall",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rainfall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "relative_humidity",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relative_humidity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reservoirs",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservoirs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "river_water_discharge",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_river_water_discharge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "river_water_level",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_river_water_level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "soil_moisture",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_soil_moisture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "solar_radiation",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_solar_radiation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suspended_sediment",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suspended_sediment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblstations",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Agency = table.Column<string>(type: "text", nullable: false),
                    Utility = table.Column<string>(type: "text", nullable: false),
                    StateName = table.Column<string>(type: "text", nullable: false),
                    download = table.Column<string>(type: "text", nullable: false),
                    page = table.Column<int>(type: "integer", nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblstations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "temperature",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temperature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wind_direction",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StationCode = table.Column<string>(type: "text", nullable: false),
                    StationName = table.Column<string>(type: "text", nullable: false),
                    StationType = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    AgencyName = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    MajorBasin = table.Column<string>(type: "text", nullable: true),
                    Tributary = table.Column<string>(type: "text", nullable: true),
                    DataAcquisitionMode = table.Column<string>(type: "text", nullable: true),
                    StationStatus = table.Column<string>(type: "text", nullable: true),
                    Tehsil = table.Column<string>(type: "text", nullable: true),
                    DatatypeCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DataValue = table.Column<double>(type: "double precision", nullable: false),
                    DataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<string>(type: "text", nullable: true),
                    Village = table.Column<string>(type: "text", nullable: true),
                    WellType = table.Column<string>(type: "text", nullable: true),
                    WellDepth = table.Column<double>(type: "double precision", nullable: true),
                    WellAquiferType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wind_direction", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atmospheric_pressure",
                schema: "public");

            migrationBuilder.DropTable(
                name: "evapo_transpiration",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ground_water_level",
                schema: "public");

            migrationBuilder.DropTable(
                name: "rainfall",
                schema: "public");

            migrationBuilder.DropTable(
                name: "relative_humidity",
                schema: "public");

            migrationBuilder.DropTable(
                name: "reservoirs",
                schema: "public");

            migrationBuilder.DropTable(
                name: "river_water_discharge",
                schema: "public");

            migrationBuilder.DropTable(
                name: "river_water_level",
                schema: "public");

            migrationBuilder.DropTable(
                name: "soil_moisture",
                schema: "public");

            migrationBuilder.DropTable(
                name: "solar_radiation",
                schema: "public");

            migrationBuilder.DropTable(
                name: "suspended_sediment",
                schema: "public");

            migrationBuilder.DropTable(
                name: "tblstations",
                schema: "public");

            migrationBuilder.DropTable(
                name: "temperature",
                schema: "public");

            migrationBuilder.DropTable(
                name: "wind_direction",
                schema: "public");
        }
    }
}
