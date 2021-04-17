using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_People_Attributions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Gender",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Profession",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId",
                table: "Peoples");

            migrationBuilder.CreateTable(
                name: "PeopleAttributions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericTypeGroupId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericTypeId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleAttributions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Attributions",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeopleAttribution_ConfigGenericType",
                        columns: x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId",
                table: "Peoples",
                columns: new[] { "ConfigGenericGenderGroupId", "ConfigGenericGenderId" });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId",
                table: "Peoples",
                columns: new[] { "ConfigGenericProfessionGroupId", "ConfigGenericProfessionId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAttributions_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeopleAttributions",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAttributions_PeopleId",
                table: "PeopleAttributions",
                column: "PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Genders",
                table: "Peoples",
                columns: new[] { "ConfigGenericGenderGroupId", "ConfigGenericGenderId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Professions",
                table: "Peoples",
                columns: new[] { "ConfigGenericProfessionGroupId", "ConfigGenericProfessionId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Genders",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Professions",
                table: "Peoples");

            migrationBuilder.DropTable(
                name: "PeopleAttributions");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId",
                table: "Peoples");

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

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Gender",
                table: "Peoples",
                columns: new[] { "ConfigGenericGenderGroupId", "ConfigGenericGenderId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Profession",
                table: "Peoples",
                columns: new[] { "ConfigGenericProfessionGroupId", "ConfigGenericProfessionId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
