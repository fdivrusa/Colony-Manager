using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class ConfigGeneric_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigGenericGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedSubject = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 2, 10, 21, 45, 10, 646, DateTimeKind.Local).AddTicks(5258)),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigGenericGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemDataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsList = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 2, 10, 21, 45, 10, 671, DateTimeKind.Local).AddTicks(131)),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemDataTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigGenericItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 2, 10, 21, 45, 10, 663, DateTimeKind.Local).AddTicks(6630)),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigGenericItems", x => new { x.GroupId, x.Id });
                    table.ForeignKey(
                        name: "FK_ConfigGenericItems_ConfigGenericGroups",
                        column: x => x.GroupId,
                        principalTable: "ConfigGenericGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConfigGenericItemExtentions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    SystemDataTypeId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 2, 10, 21, 45, 10, 667, DateTimeKind.Local).AddTicks(4186)),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigGenericItemExtentions", x => new { x.GroupId, x.ItemId, x.Id });
                    table.ForeignKey(
                        name: "FK_ConfigGenericItemExtentions_ConfigGenericItems",
                        columns: x => new { x.GroupId, x.ItemId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfigGenericItemExtentions_SystemDataTypes",
                        column: x => x.SystemDataTypeId,
                        principalTable: "SystemDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfigGenericItemExtentionValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ExtentionId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 2, 10, 21, 45, 10, 669, DateTimeKind.Local).AddTicks(4719)),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigGenericItemExtentionValues", x => new { x.ItemId, x.GroupId, x.ExtentionId, x.Id });
                    table.ForeignKey(
                        name: "FK_ConfigGenericItemExtentionValues_ConfigGenericItemExtentions",
                        columns: x => new { x.ExtentionId, x.GroupId, x.ItemId },
                        principalTable: "ConfigGenericItemExtentions",
                        principalColumns: new[] { "GroupId", "ItemId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigGenericItemExtentions_SystemDataTypeId",
                table: "ConfigGenericItemExtentions",
                column: "SystemDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigGenericItemExtentionValues_ExtentionId_GroupId_ItemId",
                table: "ConfigGenericItemExtentionValues",
                columns: new[] { "ExtentionId", "GroupId", "ItemId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigGenericItemExtentionValues");

            migrationBuilder.DropTable(
                name: "ConfigGenericItemExtentions");

            migrationBuilder.DropTable(
                name: "ConfigGenericItems");

            migrationBuilder.DropTable(
                name: "SystemDataTypes");

            migrationBuilder.DropTable(
                name: "ConfigGenericGroups");
        }
    }
}
