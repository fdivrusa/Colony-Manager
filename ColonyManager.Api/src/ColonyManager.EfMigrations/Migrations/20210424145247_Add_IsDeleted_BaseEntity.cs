using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_IsDeleted_BaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SystemDataTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PeoplesPhoneInformations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PeoplesInternetInformations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Peoples",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PeopleAttributions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PeopleAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigGenericItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigGenericItemExtentionValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigGenericItemExtentions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigGenericGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ColonyBuildings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ColonyBuildingRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Colonies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SystemDataTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PeopleAttributions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PeopleAddresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigGenericItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigGenericItemExtentionValues");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigGenericItemExtentions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigGenericGroups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ColonyBuildings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ColonyBuildingRooms");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Colonies");
        }
    }
}
