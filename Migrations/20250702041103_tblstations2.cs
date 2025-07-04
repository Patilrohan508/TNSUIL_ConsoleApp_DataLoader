using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TNSUIL_ConsoleApp_DataLoader.Migrations
{
    /// <inheritdoc />
    public partial class tblstations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgencyName",
                table: "tblstations");

            migrationBuilder.DropColumn(
                name: "DistrictName",
                table: "tblstations");

            migrationBuilder.AlterColumn<string>(
                name: "download",
                table: "tblstations",
                type: "text",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "download",
                table: "tblstations",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "AgencyName",
                table: "tblstations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DistrictName",
                table: "tblstations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
