using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Rename_FK_People_Attribution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Attributions",
                table: "PeopleAttributions");

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAttributions_Peoples",
                table: "PeopleAttributions",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAttributions_Peoples",
                table: "PeopleAttributions");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Attributions",
                table: "PeopleAttributions",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
