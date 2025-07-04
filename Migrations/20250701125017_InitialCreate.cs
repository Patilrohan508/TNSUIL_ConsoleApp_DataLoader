using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TNSUIL_ConsoleApp_DataLoader.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtmosphericPressures",
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
                    table.PrimaryKey("PK_AtmosphericPressures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvapoTranspirations",
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
                    table.PrimaryKey("PK_EvapoTranspirations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroundWaterLevels",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_GroundWaterLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RainFalls",
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
                    table.PrimaryKey("PK_RainFalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelativeHumidities",
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
                    table.PrimaryKey("PK_RelativeHumidities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservoirs",
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
                    table.PrimaryKey("PK_Reservoirs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiverWaterDischarges",
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
                    table.PrimaryKey("PK_RiverWaterDischarges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiverWaterLevels",
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
                    table.PrimaryKey("PK_RiverWaterLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoilMoistures",
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
                    table.PrimaryKey("PK_SoilMoistures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolarRadiations",
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
                    table.PrimaryKey("PK_SolarRadiations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suspended_Sediments",
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
                    table.PrimaryKey("PK_Suspended_Sediments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Agency = table.Column<string>(type: "text", nullable: false),
                    Utility = table.Column<string>(type: "text", nullable: false),
                    StateName = table.Column<string>(type: "text", nullable: false),
                    DistrictName = table.Column<string>(type: "text", nullable: false),
                    AgencyName = table.Column<string>(type: "text", nullable: false),
                    download = table.Column<bool>(type: "boolean", nullable: false),
                    page = table.Column<int>(type: "integer", nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temperatures",
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
                    table.PrimaryKey("PK_Temperatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "windDirections",
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
                    table.PrimaryKey("PK_windDirections", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtmosphericPressures");

            migrationBuilder.DropTable(
                name: "EvapoTranspirations");

            migrationBuilder.DropTable(
                name: "GroundWaterLevels");

            migrationBuilder.DropTable(
                name: "RainFalls");

            migrationBuilder.DropTable(
                name: "RelativeHumidities");

            migrationBuilder.DropTable(
                name: "Reservoirs");

            migrationBuilder.DropTable(
                name: "RiverWaterDischarges");

            migrationBuilder.DropTable(
                name: "RiverWaterLevels");

            migrationBuilder.DropTable(
                name: "SoilMoistures");

            migrationBuilder.DropTable(
                name: "SolarRadiations");

            migrationBuilder.DropTable(
                name: "Suspended_Sediments");

            migrationBuilder.DropTable(
                name: "TblStations");

            migrationBuilder.DropTable(
                name: "Temperatures");

            migrationBuilder.DropTable(
                name: "windDirections");
        }
    }
}
