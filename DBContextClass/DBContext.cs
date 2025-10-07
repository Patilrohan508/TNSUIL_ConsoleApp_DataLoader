using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TNSUIL_ConsoleApp_DataLoader.DBContextClass
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Models.TblStations> TblStations { get; set; }
        public DbSet<Models.AtmosphericPressure> AtmosphericPressures { get; set; }
        public DbSet<Models.EvapoTranspiration> EvapoTranspirations { get; set; }
        public DbSet<Models.GroundWaterLevel> GroundWaterLevels { get; set; }
        public DbSet<Models.RainFall> RainFalls { get; set; }
        public DbSet<Models.RelativeHumidity> RelativeHumidities { get; set; }
        public DbSet<Models.Reservoir> Reservoirs { get; set; }
        public DbSet<Models.RiverWaterDischarge> RiverWaterDischarges { get; set; }
        public DbSet<Models.RiverWaterLevel> RiverWaterLevels { get; set; }
        public DbSet<Models.SoilMoisture> SoilMoistures { get; set; }
        public DbSet<Models.SolarRadiation> SolarRadiations { get; set; }
        public DbSet<Models.Suspended_Sediment> Suspended_Sediments { get; set; }
        public DbSet<Models.Temperature> Temperatures { get; set; }
        public DbSet<Models.WindDirection> windDirections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //For filtering out Schema.
            modelBuilder.HasDefaultSchema("public");

            // Optional: define table names explicitly
            modelBuilder.Entity<Models.TblStations>().ToTable("tblstations", schema: "public");
            modelBuilder.Entity<Models.AtmosphericPressure>().ToTable("atmospheric_pressure", schema: "public");
            modelBuilder.Entity<Models.EvapoTranspiration>().ToTable("evapo_transpiration", schema: "public");
            modelBuilder.Entity<Models.GroundWaterLevel>().ToTable("ground_water_level", schema: "public");
            modelBuilder.Entity<Models.RainFall>().ToTable("rainfall", schema: "public");
            modelBuilder.Entity<Models.RelativeHumidity>().ToTable("relative_humidity", schema: "public");
            modelBuilder.Entity<Models.Reservoir>().ToTable("reservoirs", schema: "public");
            modelBuilder.Entity<Models.RiverWaterDischarge>().ToTable("river_water_discharge", schema: "public");
            modelBuilder.Entity<Models.RiverWaterLevel>().ToTable("river_water_level", schema: "public");
            modelBuilder.Entity<Models.SoilMoisture>().ToTable("soil_moisture", schema: "public");
            modelBuilder.Entity<Models.SolarRadiation>().ToTable("solar_radiation", schema: "public");
            modelBuilder.Entity<Models.Suspended_Sediment>().ToTable("suspended_sediment", schema: "public");
            modelBuilder.Entity<Models.Temperature>().ToTable("temperature", schema: "public");
            modelBuilder.Entity<Models.WindDirection>().ToTable("wind_direction", schema: "public");

            // Optional: define any primary key or constraints explicitly
            // Example:
            // modelBuilder.Entity<Models.TblStations>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("public");

        //    modelBuilder.Entity<Models.TblStations>().ToTable("tblstations", schema: "public");

        //    modelBuilder.Entity<Models.AtmosphericPressure>()
        //        .ToTable("atmospheric_pressure", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.EvapoTranspiration>()
        //        .ToTable("evapo_transpiration", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.GroundWaterLevel>()
        //        .ToTable("ground_water_level", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.RainFall>()
        //        .ToTable("rainfall", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.RelativeHumidity>()
        //        .ToTable("relative_humidity", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.Reservoir>()
        //        .ToTable("reservoirs", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.RiverWaterDischarge>()
        //        .ToTable("river_water_discharge", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.RiverWaterLevel>()
        //        .ToTable("river_water_level", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.SoilMoisture>()
        //        .ToTable("soil_moisture", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.SolarRadiation>()
        //        .ToTable("solar_radiation", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.Suspended_Sediment>()
        //        .ToTable("suspended_sediment", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.Temperature>()
        //        .ToTable("temperature", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    modelBuilder.Entity<Models.WindDirection>()
        //        .ToTable("wind_direction", schema: "public")
        //        .HasIndex(e => new { e.StationCode, e.DataTime }).IsUnique();

        //    base.OnModelCreating(modelBuilder);
        //}



    }
}
