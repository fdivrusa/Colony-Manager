using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Update_People_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfDeath",
                table: "Peoples",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deceased",
                table: "Peoples",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Peoples",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfDeath",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "Deceased",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Peoples");
        }
    }
}
