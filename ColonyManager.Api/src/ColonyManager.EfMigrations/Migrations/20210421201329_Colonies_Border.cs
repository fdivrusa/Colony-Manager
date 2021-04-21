using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Colonies_Border : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Geometry>(
                name: "Border",
                table: "Colonies",
                type: "geography",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Border",
                table: "Colonies");
        }
    }
}
