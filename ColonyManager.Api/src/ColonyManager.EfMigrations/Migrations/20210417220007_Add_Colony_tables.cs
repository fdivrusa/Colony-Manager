using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_Colony_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colonies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ConfigGenericTypeGroupId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericTypeId = table.Column<int>(type: "int", nullable: false),
                    MaxPopulation = table.Column<int>(type: "int", nullable: false),
                    ActualPopulation = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colonies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colony_ConfigGenericItem",
                        columns: x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ColonyBuildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColonyId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ConfigGenericTypeGroupId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericTypeId = table.Column<int>(type: "int", nullable: false),
                    FK_Colony_ColonyBuilding = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyBuildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColonyBuilding_Colony",
                        column: x => x.FK_Colony_ColonyBuilding,
                        principalTable: "Colonies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColonyBuilding_ConfigGenericItem",
                        columns: x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColonyBuildingRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColonyBuildingId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ConfigGenericGroupTypeId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericTypeId = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyBuildingRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColonyBuildingRoom_ColonyBuilding",
                        column: x => x.ColonyBuildingId,
                        principalTable: "ColonyBuildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColonyBuildingRoom_ConfigGenericItem",
                        columns: x => new { x.ConfigGenericGroupTypeId, x.ConfigGenericTypeId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "Colonies",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildingRooms_ColonyBuildingId",
                table: "ColonyBuildingRooms",
                column: "ColonyBuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildingRooms_ConfigGenericGroupTypeId_ConfigGenericTypeId",
                table: "ColonyBuildingRooms",
                columns: new[] { "ConfigGenericGroupTypeId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildings_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "ColonyBuildings",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildings_FK_Colony_ColonyBuilding",
                table: "ColonyBuildings",
                column: "FK_Colony_ColonyBuilding");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColonyBuildingRooms");

            migrationBuilder.DropTable(
                name: "ColonyBuildings");

            migrationBuilder.DropTable(
                name: "Colonies");
        }
    }
}
