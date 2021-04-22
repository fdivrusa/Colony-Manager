using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class People_Nationality_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigGenericItems_ConfigGenericGroups",
                table: "ConfigGenericItems");

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericNationalityGroupId",
                table: "Peoples",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericNationalityId",
                table: "Peoples",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ConfigGenericGroups",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName", "RelatedSubject" },
                values: new object[] { 1, "NATIONALITIES", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group that contains all the known nationalities", null, "SYSTEM", "PEOPLES" });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[] { 1, 0, "UNK", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unknown", null, "SYSTEM" });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericNationalityGroupId_ConfigGenericNationalityId",
                table: "Peoples",
                columns: new[] { "ConfigGenericNationalityGroupId", "ConfigGenericNationalityId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigGenericItems_ConfigGenericGroups",
                table: "ConfigGenericItems",
                column: "GroupId",
                principalTable: "ConfigGenericGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Nationality",
                table: "Peoples",
                columns: new[] { "ConfigGenericNationalityGroupId", "ConfigGenericNationalityId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigGenericItems_ConfigGenericGroups",
                table: "ConfigGenericItems");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Nationality",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericNationalityGroupId_ConfigGenericNationalityId",
                table: "Peoples");

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 0 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ConfigGenericNationalityGroupId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ConfigGenericNationalityId",
                table: "Peoples");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigGenericItems_ConfigGenericGroups",
                table: "ConfigGenericItems",
                column: "GroupId",
                principalTable: "ConfigGenericGroups",
                principalColumn: "Id");
        }
    }
}
