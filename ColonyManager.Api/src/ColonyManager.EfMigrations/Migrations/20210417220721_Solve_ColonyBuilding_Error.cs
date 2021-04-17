using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Solve_ColonyBuilding_Error : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColonyBuilding_Colony",
                table: "ColonyBuildings");

            migrationBuilder.DropIndex(
                name: "IX_ColonyBuildings_FK_Colony_ColonyBuilding",
                table: "ColonyBuildings");

            migrationBuilder.DropColumn(
                name: "FK_Colony_ColonyBuilding",
                table: "ColonyBuildings");

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildings_ColonyId",
                table: "ColonyBuildings",
                column: "ColonyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colony_ColonyBuilding",
                table: "ColonyBuildings",
                column: "ColonyId",
                principalTable: "Colonies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colony_ColonyBuilding",
                table: "ColonyBuildings");

            migrationBuilder.DropIndex(
                name: "IX_ColonyBuildings_ColonyId",
                table: "ColonyBuildings");

            migrationBuilder.AddColumn<int>(
                name: "FK_Colony_ColonyBuilding",
                table: "ColonyBuildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildings_FK_Colony_ColonyBuilding",
                table: "ColonyBuildings",
                column: "FK_Colony_ColonyBuilding");

            migrationBuilder.AddForeignKey(
                name: "FK_ColonyBuilding_Colony",
                table: "ColonyBuildings",
                column: "FK_Colony_ColonyBuilding",
                principalTable: "Colonies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
