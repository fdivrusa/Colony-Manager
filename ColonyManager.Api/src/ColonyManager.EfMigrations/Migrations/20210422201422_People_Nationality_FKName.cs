using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class People_Nationality_FKName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Nationality",
                table: "Peoples");

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Nationalities",
                table: "Peoples",
                columns: new[] { "ConfigGenericNationalityGroupId", "ConfigGenericNationalityId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Nationalities",
                table: "Peoples");

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Nationality",
                table: "Peoples",
                columns: new[] { "ConfigGenericNationalityGroupId", "ConfigGenericNationalityId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
