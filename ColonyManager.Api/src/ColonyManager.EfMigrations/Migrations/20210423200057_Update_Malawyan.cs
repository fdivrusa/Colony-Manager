using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Update_Malawyan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 108 },
                column: "Code",
                value: "MALAW");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 108 },
                column: "Code",
                value: "MALA");
        }
    }
}
