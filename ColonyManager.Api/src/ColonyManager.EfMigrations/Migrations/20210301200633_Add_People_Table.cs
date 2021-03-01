using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_People_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConfigGenericGenderGroupId = table.Column<int>(type: "int", nullable: true),
                    ConfigGenericGenderId = table.Column<int>(type: "int", nullable: true),
                    ConfigGenericProfessionGroupId = table.Column<int>(type: "int", nullable: true),
                    ConfigGenericProfessionId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_ConfigGenericItem_Gender",
                        columns: x => new { x.ConfigGenericGenderGroupId, x.ConfigGenericGenderId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_ConfigGenericItem_Profession",
                        columns: x => new { x.ConfigGenericProfessionGroupId, x.ConfigGenericProfessionId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId",
                table: "Peoples",
                columns: new[] { "ConfigGenericGenderGroupId", "ConfigGenericGenderId" },
                unique: true,
                filter: "[ConfigGenericGenderGroupId] IS NOT NULL AND [ConfigGenericGenderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId",
                table: "Peoples",
                columns: new[] { "ConfigGenericProfessionGroupId", "ConfigGenericProfessionId" },
                unique: true,
                filter: "[ConfigGenericProfessionGroupId] IS NOT NULL AND [ConfigGenericProfessionId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peoples");
        }
    }
}
