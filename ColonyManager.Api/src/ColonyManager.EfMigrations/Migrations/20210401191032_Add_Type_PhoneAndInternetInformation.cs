using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_Type_PhoneAndInternetInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PeoplesPhoneInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesPhoneInformations",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeoplesInternetInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesInternetInformations",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleInternetInformation_ConfigGenericType",
                table: "PeoplesInternetInformations",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeoplePhoneInformation_ConfigGenericType",
                table: "PeoplesPhoneInformations",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleInternetInformation_ConfigGenericType",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PeoplePhoneInformation_ConfigGenericType",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropIndex(
                name: "IX_PeoplesPhoneInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropIndex(
                name: "IX_PeoplesInternetInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesInternetInformations");
        }
    }
}
