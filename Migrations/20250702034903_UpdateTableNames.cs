using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TNSUIL_ConsoleApp_DataLoader.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TblStations",
                table: "TblStations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservoirs",
                table: "Reservoirs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_windDirections",
                table: "windDirections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Temperatures",
                table: "Temperatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suspended_Sediments",
                table: "Suspended_Sediments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolarRadiations",
                table: "SolarRadiations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoilMoistures",
                table: "SoilMoistures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RiverWaterLevels",
                table: "RiverWaterLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RiverWaterDischarges",
                table: "RiverWaterDischarges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelativeHumidities",
                table: "RelativeHumidities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RainFalls",
                table: "RainFalls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroundWaterLevels",
                table: "GroundWaterLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvapoTranspirations",
                table: "EvapoTranspirations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmosphericPressures",
                table: "AtmosphericPressures");

            migrationBuilder.RenameTable(
                name: "TblStations",
                newName: "tblstations");

            migrationBuilder.RenameTable(
                name: "Reservoirs",
                newName: "reservoirs");

            migrationBuilder.RenameTable(
                name: "windDirections",
                newName: "wind_direction");

            migrationBuilder.RenameTable(
                name: "Temperatures",
                newName: "temperature");

            migrationBuilder.RenameTable(
                name: "Suspended_Sediments",
                newName: "suspended_sediment");

            migrationBuilder.RenameTable(
                name: "SolarRadiations",
                newName: "solar_radiation");

            migrationBuilder.RenameTable(
                name: "SoilMoistures",
                newName: "soil_moisture");

            migrationBuilder.RenameTable(
                name: "RiverWaterLevels",
                newName: "river_water_level");

            migrationBuilder.RenameTable(
                name: "RiverWaterDischarges",
                newName: "river_water_discharge");

            migrationBuilder.RenameTable(
                name: "RelativeHumidities",
                newName: "relative_humidity");

            migrationBuilder.RenameTable(
                name: "RainFalls",
                newName: "rainfall");

            migrationBuilder.RenameTable(
                name: "GroundWaterLevels",
                newName: "ground_water_level");

            migrationBuilder.RenameTable(
                name: "EvapoTranspirations",
                newName: "evapo_transpiration");

            migrationBuilder.RenameTable(
                name: "AtmosphericPressures",
                newName: "atmospheric_pressure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblstations",
                table: "tblstations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_reservoirs",
                table: "reservoirs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wind_direction",
                table: "wind_direction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_temperature",
                table: "temperature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_suspended_sediment",
                table: "suspended_sediment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_solar_radiation",
                table: "solar_radiation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_soil_moisture",
                table: "soil_moisture",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_river_water_level",
                table: "river_water_level",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_river_water_discharge",
                table: "river_water_discharge",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_relative_humidity",
                table: "relative_humidity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rainfall",
                table: "rainfall",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ground_water_level",
                table: "ground_water_level",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_evapo_transpiration",
                table: "evapo_transpiration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_atmospheric_pressure",
                table: "atmospheric_pressure",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblstations",
                table: "tblstations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reservoirs",
                table: "reservoirs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wind_direction",
                table: "wind_direction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_temperature",
                table: "temperature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_suspended_sediment",
                table: "suspended_sediment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_solar_radiation",
                table: "solar_radiation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_soil_moisture",
                table: "soil_moisture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_river_water_level",
                table: "river_water_level");

            migrationBuilder.DropPrimaryKey(
                name: "PK_river_water_discharge",
                table: "river_water_discharge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_relative_humidity",
                table: "relative_humidity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rainfall",
                table: "rainfall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ground_water_level",
                table: "ground_water_level");

            migrationBuilder.DropPrimaryKey(
                name: "PK_evapo_transpiration",
                table: "evapo_transpiration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_atmospheric_pressure",
                table: "atmospheric_pressure");

            migrationBuilder.RenameTable(
                name: "tblstations",
                newName: "TblStations");

            migrationBuilder.RenameTable(
                name: "reservoirs",
                newName: "Reservoirs");

            migrationBuilder.RenameTable(
                name: "wind_direction",
                newName: "windDirections");

            migrationBuilder.RenameTable(
                name: "temperature",
                newName: "Temperatures");

            migrationBuilder.RenameTable(
                name: "suspended_sediment",
                newName: "Suspended_Sediments");

            migrationBuilder.RenameTable(
                name: "solar_radiation",
                newName: "SolarRadiations");

            migrationBuilder.RenameTable(
                name: "soil_moisture",
                newName: "SoilMoistures");

            migrationBuilder.RenameTable(
                name: "river_water_level",
                newName: "RiverWaterLevels");

            migrationBuilder.RenameTable(
                name: "river_water_discharge",
                newName: "RiverWaterDischarges");

            migrationBuilder.RenameTable(
                name: "relative_humidity",
                newName: "RelativeHumidities");

            migrationBuilder.RenameTable(
                name: "rainfall",
                newName: "RainFalls");

            migrationBuilder.RenameTable(
                name: "ground_water_level",
                newName: "GroundWaterLevels");

            migrationBuilder.RenameTable(
                name: "evapo_transpiration",
                newName: "EvapoTranspirations");

            migrationBuilder.RenameTable(
                name: "atmospheric_pressure",
                newName: "AtmosphericPressures");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblStations",
                table: "TblStations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservoirs",
                table: "Reservoirs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_windDirections",
                table: "windDirections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Temperatures",
                table: "Temperatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suspended_Sediments",
                table: "Suspended_Sediments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolarRadiations",
                table: "SolarRadiations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoilMoistures",
                table: "SoilMoistures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RiverWaterLevels",
                table: "RiverWaterLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RiverWaterDischarges",
                table: "RiverWaterDischarges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelativeHumidities",
                table: "RelativeHumidities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RainFalls",
                table: "RainFalls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroundWaterLevels",
                table: "GroundWaterLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvapoTranspirations",
                table: "EvapoTranspirations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmosphericPressures",
                table: "AtmosphericPressures",
                column: "Id");
        }
    }
}
