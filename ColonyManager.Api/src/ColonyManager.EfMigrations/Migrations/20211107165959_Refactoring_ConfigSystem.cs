using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Refactoring_ConfigSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colony_ConfigGenericItem",
                table: "Colonies");

            migrationBuilder.DropForeignKey(
                name: "FK_ColonyBuildingRoom_ConfigGenericItem",
                table: "ColonyBuildingRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ColonyBuilding_ConfigGenericItem",
                table: "ColonyBuildings");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAddress_Type",
                table: "PeopleAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAttribution_ConfigGenericType",
                table: "PeopleAttributions");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Genders",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Nationalities",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ConfigGenericItem_Professions",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleInternetInformation_ConfigGenericType",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PeoplePhoneInformation_ConfigGenericType",
                table: "PeoplesPhoneInformations");

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

            migrationBuilder.DropIndex(
                name: "IX_PeoplesPhoneInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropIndex(
                name: "IX_PeoplesInternetInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericNationalityGroupId_ConfigGenericNationalityId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_PeopleAttributions_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeopleAttributions");

            migrationBuilder.DropIndex(
                name: "IX_PeopleAddresses_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeopleAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ColonyBuildings_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "ColonyBuildings");

            migrationBuilder.DropIndex(
                name: "IX_ColonyBuildingRooms_ConfigGenericGroupTypeId_ConfigGenericTypeId",
                table: "ColonyBuildingRooms");

            migrationBuilder.DropIndex(
                name: "IX_Colonies_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "Colonies");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeGroupId",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeGroupId",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropColumn(
                name: "ConfigGenericGenderGroupId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ConfigGenericGenderId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ConfigGenericNationalityGroupId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ConfigGenericNationalityId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ConfigGenericProfessionGroupId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeGroupId",
                table: "PeopleAttributions");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeId",
                table: "PeopleAttributions");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeGroupId",
                table: "PeopleAddresses");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeGroupId",
                table: "ColonyBuildings");

            migrationBuilder.DropColumn(
                name: "ConfigGenericGroupTypeId",
                table: "ColonyBuildingRooms");

            migrationBuilder.DropColumn(
                name: "ConfigGenericTypeGroupId",
                table: "Colonies");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericTypeId",
                table: "PeoplesPhoneInformations",
                newName: "PhoneInformationTypeId");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericTypeId",
                table: "PeoplesInternetInformations",
                newName: "InternetInformationTypeId");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericProfessionId",
                table: "Peoples",
                newName: "ProfessionTypeId");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericTypeId",
                table: "PeopleAddresses",
                newName: "AddressTypeId");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericTypeId",
                table: "ColonyBuildings",
                newName: "BuildingTypeId");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericTypeId",
                table: "ColonyBuildingRooms",
                newName: "RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "ConfigGenericTypeId",
                table: "Colonies",
                newName: "ColonyTypeId");

            migrationBuilder.AddColumn<int>(
                name: "GenderTypeId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributionTypeId",
                table: "PeopleAttributions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColonyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InternetInformationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetInformationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneInformationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneInformationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 195, "UNK", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unknown", null, "SYSTEM" },
                    { 124, "MOZ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mozambican", null, "SYSTEM" },
                    { 125, "NAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Namibian", null, "SYSTEM" },
                    { 126, "NAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nauruan", null, "SYSTEM" },
                    { 127, "NEP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepalese", null, "SYSTEM" },
                    { 128, "NEW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Zealander", null, "SYSTEM" },
                    { 129, "NI-", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ni-Vanuatu", null, "SYSTEM" },
                    { 130, "NIC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicaraguan", null, "SYSTEM" },
                    { 131, "NIG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigerian", null, "SYSTEM" },
                    { 132, "NIGE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigerien", null, "SYSTEM" },
                    { 123, "MOT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Motswana", null, "SYSTEM" },
                    { 133, "NOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Korean", null, "SYSTEM" },
                    { 135, "NORW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian", null, "SYSTEM" },
                    { 136, "OMA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omani", null, "SYSTEM" },
                    { 137, "PAK", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pakistani", null, "SYSTEM" },
                    { 138, "PAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palauan", null, "SYSTEM" },
                    { 139, "PAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panamanian", null, "SYSTEM" },
                    { 140, "PAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Papua New Guinean", null, "SYSTEM" },
                    { 141, "PAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paraguayan", null, "SYSTEM" },
                    { 142, "PER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peruvian", null, "SYSTEM" },
                    { 143, "POL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", null, "SYSTEM" },
                    { 134, "NORT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Irish", null, "SYSTEM" },
                    { 122, "MOS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mosotho", null, "SYSTEM" },
                    { 121, "MOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moroccan", null, "SYSTEM" },
                    { 120, "MONG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mongolian", null, "SYSTEM" },
                    { 99, "LAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latvian", null, "SYSTEM" },
                    { 100, "LEB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lebanese", null, "SYSTEM" },
                    { 101, "LIB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liberian", null, "SYSTEM" },
                    { 102, "LIBY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libyan", null, "SYSTEM" },
                    { 103, "LIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liechtensteiner", null, "SYSTEM" },
                    { 104, "LIT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lithuanian", null, "SYSTEM" },
                    { 105, "LUX", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxembourger", null, "SYSTEM" },
                    { 106, "MAC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macedonian", null, "SYSTEM" },
                    { 107, "MAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malagasy", null, "SYSTEM" },
                    { 108, "MALAW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malawian", null, "SYSTEM" },
                    { 109, "MALA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malaysian", null, "SYSTEM" },
                    { 110, "MALD", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maldivian", null, "SYSTEM" },
                    { 111, "MALI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malian", null, "SYSTEM" },
                    { 112, "MALT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maltese", null, "SYSTEM" },
                    { 113, "MAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshallese", null, "SYSTEM" },
                    { 114, "MAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritanian", null, "SYSTEM" },
                    { 115, "MAUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritian", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 116, "MEX", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexican", null, "SYSTEM" },
                    { 117, "MIC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micronesian", null, "SYSTEM" },
                    { 118, "MOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldovan", null, "SYSTEM" },
                    { 119, "MON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monacan", null, "SYSTEM" },
                    { 144, "POR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portuguese", null, "SYSTEM" },
                    { 98, "LAO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laotian", null, "SYSTEM" },
                    { 145, "QAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qatari", null, "SYSTEM" },
                    { 147, "RUS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russian", null, "SYSTEM" },
                    { 173, "SWI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swiss", null, "SYSTEM" },
                    { 174, "SYR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syrian", null, "SYSTEM" },
                    { 175, "TAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taiwanese", null, "SYSTEM" },
                    { 176, "TAJ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tajik", null, "SYSTEM" },
                    { 177, "TAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanzanian", null, "SYSTEM" },
                    { 178, "THA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai", null, "SYSTEM" },
                    { 179, "TOG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Togolese", null, "SYSTEM" },
                    { 180, "TON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tongan", null, "SYSTEM" },
                    { 181, "TRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trinidadian or Tobagonian", null, "SYSTEM" },
                    { 172, "SWE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swedish", null, "SYSTEM" },
                    { 182, "TUN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisian", null, "SYSTEM" },
                    { 184, "TUV", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuvaluan", null, "SYSTEM" },
                    { 185, "UGA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ugandan", null, "SYSTEM" },
                    { 186, "UKR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukrainian", null, "SYSTEM" },
                    { 187, "URUG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uruguayan", null, "SYSTEM" },
                    { 188, "UZB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbekistani", null, "SYSTEM" },
                    { 189, "VEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venezuelan", null, "SYSTEM" },
                    { 190, "VIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vietnamese", null, "SYSTEM" },
                    { 191, "WEL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welsh", null, "SYSTEM" },
                    { 192, "YEM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yemenite", null, "SYSTEM" },
                    { 183, "TUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish", null, "SYSTEM" },
                    { 171, "SWA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swazi", null, "SYSTEM" },
                    { 170, "SUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surinamer", null, "SYSTEM" },
                    { 169, "SUD", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sudanese", null, "SYSTEM" },
                    { 148, "RWA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rwandan", null, "SYSTEM" },
                    { 149, "SAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint Lucian", null, "SYSTEM" },
                    { 150, "SAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvadoran", null, "SYSTEM" },
                    { 151, "SAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoan", null, "SYSTEM" },
                    { 152, "SAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Marinese", null, "SYSTEM" },
                    { 153, "SAO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sao Tomean", null, "SYSTEM" },
                    { 154, "SAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saudi", null, "SYSTEM" },
                    { 155, "SCO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scottish", null, "SYSTEM" },
                    { 156, "SEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senegalese", null, "SYSTEM" },
                    { 157, "SER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbian", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 158, "SEY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seychellois", null, "SYSTEM" },
                    { 159, "SIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sierra Leonean", null, "SYSTEM" },
                    { 160, "SIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singaporean", null, "SYSTEM" },
                    { 161, "SLO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovakian", null, "SYSTEM" },
                    { 162, "SLOV", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenian", null, "SYSTEM" },
                    { 163, "SOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solomon Islander", null, "SYSTEM" },
                    { 164, "SOM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somali", null, "SYSTEM" },
                    { 165, "SOU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "South African", null, "SYSTEM" },
                    { 166, "SOUT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korean", null, "SYSTEM" },
                    { 167, "SPA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish", null, "SYSTEM" },
                    { 168, "SRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sri Lankan", null, "SYSTEM" },
                    { 146, "ROM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romanian", null, "SYSTEM" },
                    { 193, "ZAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zambian", null, "SYSTEM" },
                    { 97, "KYR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrgyz", null, "SYSTEM" },
                    { 95, "KIT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kittian and Nevisian", null, "SYSTEM" },
                    { 26, "BRA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazilian", null, "SYSTEM" },
                    { 27, "BRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "British", null, "SYSTEM" },
                    { 28, "BRU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruneian", null, "SYSTEM" },
                    { 29, "BUL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgarian", null, "SYSTEM" },
                    { 30, "BUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burkinabe", null, "SYSTEM" },
                    { 31, "BURM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burmese", null, "SYSTEM" },
                    { 32, "BURU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burundian", null, "SYSTEM" },
                    { 33, "CAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cambodian", null, "SYSTEM" },
                    { 34, "CAME", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cameroonian", null, "SYSTEM" },
                    { 25, "BOS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosnian", null, "SYSTEM" },
                    { 35, "CAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian", null, "SYSTEM" },
                    { 37, "CEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central African", null, "SYSTEM" },
                    { 38, "CHA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chadian", null, "SYSTEM" },
                    { 39, "CHI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilean", null, "SYSTEM" },
                    { 40, "CHIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinese", null, "SYSTEM" },
                    { 41, "COL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombian", null, "SYSTEM" },
                    { 42, "COM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comoran", null, "SYSTEM" },
                    { 43, "CON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Congolese", null, "SYSTEM" },
                    { 44, "COS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rican", null, "SYSTEM" },
                    { 45, "CRO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatian", null, "SYSTEM" },
                    { 36, "CAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cape Verdean", null, "SYSTEM" },
                    { 24, "BOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolivian", null, "SYSTEM" },
                    { 23, "BHU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bhutanese", null, "SYSTEM" },
                    { 22, "BEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beninese", null, "SYSTEM" },
                    { 1, "AFG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afghan", null, "SYSTEM" },
                    { 2, "ALB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albanian", null, "SYSTEM" },
                    { 3, "ALG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Algerian", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 4, "AME", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "American", null, "SYSTEM" },
                    { 5, "AND", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andorran", null, "SYSTEM" },
                    { 6, "ANG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angolan", null, "SYSTEM" },
                    { 7, "ANT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antiguans", null, "SYSTEM" },
                    { 8, "ARG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentinean", null, "SYSTEM" },
                    { 9, "ARM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenian", null, "SYSTEM" },
                    { 10, "AUS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian", null, "SYSTEM" },
                    { 11, "AUST", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austrian", null, "SYSTEM" },
                    { 12, "AZE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijani", null, "SYSTEM" },
                    { 13, "BAH", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahamian", null, "SYSTEM" },
                    { 14, "BAHR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahraini", null, "SYSTEM" },
                    { 15, "BAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bangladeshi", null, "SYSTEM" },
                    { 16, "BAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbadian", null, "SYSTEM" },
                    { 17, "BARB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbudans", null, "SYSTEM" },
                    { 18, "BAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batswana", null, "SYSTEM" },
                    { 19, "BEL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belarusian", null, "SYSTEM" },
                    { 20, "BELG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgian", null, "SYSTEM" },
                    { 21, "BELI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belizean", null, "SYSTEM" },
                    { 46, "CUB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuban", null, "SYSTEM" },
                    { 96, "KUW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuwaiti", null, "SYSTEM" },
                    { 47, "CYP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cypriot", null, "SYSTEM" },
                    { 49, "DAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", null, "SYSTEM" },
                    { 75, "GUY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guyanese", null, "SYSTEM" },
                    { 76, "HAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haitian", null, "SYSTEM" },
                    { 77, "HER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herzegovinian", null, "SYSTEM" },
                    { 78, "HON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduran", null, "SYSTEM" },
                    { 79, "HUN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungarian", null, "SYSTEM" },
                    { 80, "I-K", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "I-Kiribati", null, "SYSTEM" },
                    { 81, "ICE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Icelander", null, "SYSTEM" },
                    { 82, "IND", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian", null, "SYSTEM" },
                    { 83, "INDO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indonesian", null, "SYSTEM" },
                    { 74, "GUIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinean", null, "SYSTEM" },
                    { 84, "IRA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iranian", null, "SYSTEM" },
                    { 86, "IRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irish", null, "SYSTEM" },
                    { 87, "ISR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israeli", null, "SYSTEM" },
                    { 88, "ITA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian", null, "SYSTEM" },
                    { 89, "IVO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivorian", null, "SYSTEM" },
                    { 90, "JAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaican", null, "SYSTEM" },
                    { 91, "JAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese", null, "SYSTEM" },
                    { 92, "JOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordanian", null, "SYSTEM" },
                    { 93, "KAZ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakhstani", null, "SYSTEM" },
                    { 94, "KEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenyan", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 85, "IRAQ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iraqi", null, "SYSTEM" },
                    { 73, "GUI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinea-Bissauan", null, "SYSTEM" },
                    { 72, "GUA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guatemalan", null, "SYSTEM" },
                    { 71, "GREN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grenadian", null, "SYSTEM" },
                    { 50, "DJI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Djibouti", null, "SYSTEM" },
                    { 51, "DOM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominican", null, "SYSTEM" },
                    { 52, "DUT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dutch", null, "SYSTEM" },
                    { 53, "EAS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Timorese", null, "SYSTEM" },
                    { 54, "ECU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ecuadorean", null, "SYSTEM" },
                    { 55, "EGY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egyptian", null, "SYSTEM" },
                    { 56, "EMI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emirian", null, "SYSTEM" },
                    { 57, "EQU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equatorial Guinean", null, "SYSTEM" },
                    { 58, "ERI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eritrean", null, "SYSTEM" },
                    { 59, "EST", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estonian", null, "SYSTEM" },
                    { 60, "ETH", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethiopian", null, "SYSTEM" },
                    { 61, "FIJ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fijian", null, "SYSTEM" },
                    { 62, "FIL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filipino", null, "SYSTEM" },
                    { 63, "FIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finnish", null, "SYSTEM" },
                    { 64, "FRE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "French", null, "SYSTEM" },
                    { 65, "GAB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabonese", null, "SYSTEM" },
                    { 66, "GAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambian", null, "SYSTEM" },
                    { 67, "GEO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian", null, "SYSTEM" },
                    { 68, "GER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "German", null, "SYSTEM" },
                    { 69, "GHA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghanaian", null, "SYSTEM" },
                    { 70, "GRE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greek", null, "SYSTEM" },
                    { 48, "CZE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech", null, "SYSTEM" },
                    { 194, "ZIM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zimbabwean", null, "SYSTEM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeoplesPhoneInformations_PhoneInformationTypeId",
                table: "PeoplesPhoneInformations",
                column: "PhoneInformationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeoplesInternetInformations_InternetInformationTypeId",
                table: "PeoplesInternetInformations",
                column: "InternetInformationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_GenderTypeId",
                table: "Peoples",
                column: "GenderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_NationalityId",
                table: "Peoples",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ProfessionTypeId",
                table: "Peoples",
                column: "ProfessionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAttributions_AttributionTypeId",
                table: "PeopleAttributions",
                column: "AttributionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_AddressTypeId",
                table: "PeopleAddresses",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildings_BuildingTypeId",
                table: "ColonyBuildings",
                column: "BuildingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ColonyTypeId",
                table: "Colonies",
                column: "ColonyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colony_ColonyType",
                table: "Colonies",
                column: "ColonyTypeId",
                principalTable: "ColonyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ColonyBuildingRoom_RoomType",
                table: "ColonyBuildingRooms",
                column: "ColonyBuildingId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColonyBuilding_BuildingType",
                table: "ColonyBuildings",
                column: "BuildingTypeId",
                principalTable: "BuildingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAddress_AddressType",
                table: "PeopleAddresses",
                column: "AddressTypeId",
                principalTable: "AddressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAttribution_AttributionType",
                table: "PeopleAttributions",
                column: "AttributionTypeId",
                principalTable: "AttributionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_GenderType",
                table: "Peoples",
                column: "GenderTypeId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Nationality",
                table: "Peoples",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ProfessionType",
                table: "Peoples",
                column: "ProfessionTypeId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleInternetInformation_InternetInformationType",
                table: "PeoplesInternetInformations",
                column: "InternetInformationTypeId",
                principalTable: "InternetInformationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeoplePhoneInformation_PhoneInformationType",
                table: "PeoplesPhoneInformations",
                column: "PhoneInformationTypeId",
                principalTable: "PhoneInformationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colony_ColonyType",
                table: "Colonies");

            migrationBuilder.DropForeignKey(
                name: "FK_ColonyBuildingRoom_RoomType",
                table: "ColonyBuildingRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ColonyBuilding_BuildingType",
                table: "ColonyBuildings");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAddress_AddressType",
                table: "PeopleAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAttribution_AttributionType",
                table: "PeopleAttributions");

            migrationBuilder.DropForeignKey(
                name: "FK_People_GenderType",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Nationality",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ProfessionType",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleInternetInformation_InternetInformationType",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PeoplePhoneInformation_PhoneInformationType",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "AttributionTypes");

            migrationBuilder.DropTable(
                name: "BuildingTypes");

            migrationBuilder.DropTable(
                name: "ColonyTypes");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "InternetInformationTypes");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "PhoneInformationTypes");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropIndex(
                name: "IX_PeoplesPhoneInformations_PhoneInformationTypeId",
                table: "PeoplesPhoneInformations");

            migrationBuilder.DropIndex(
                name: "IX_PeoplesInternetInformations_InternetInformationTypeId",
                table: "PeoplesInternetInformations");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_GenderTypeId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_NationalityId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ProfessionTypeId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_PeopleAttributions_AttributionTypeId",
                table: "PeopleAttributions");

            migrationBuilder.DropIndex(
                name: "IX_PeopleAddresses_AddressTypeId",
                table: "PeopleAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ColonyBuildings_BuildingTypeId",
                table: "ColonyBuildings");

            migrationBuilder.DropIndex(
                name: "IX_Colonies_ColonyTypeId",
                table: "Colonies");

            migrationBuilder.DropColumn(
                name: "GenderTypeId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "AttributionTypeId",
                table: "PeopleAttributions");

            migrationBuilder.RenameColumn(
                name: "PhoneInformationTypeId",
                table: "PeoplesPhoneInformations",
                newName: "ConfigGenericTypeId");

            migrationBuilder.RenameColumn(
                name: "InternetInformationTypeId",
                table: "PeoplesInternetInformations",
                newName: "ConfigGenericTypeId");

            migrationBuilder.RenameColumn(
                name: "ProfessionTypeId",
                table: "Peoples",
                newName: "ConfigGenericProfessionId");

            migrationBuilder.RenameColumn(
                name: "AddressTypeId",
                table: "PeopleAddresses",
                newName: "ConfigGenericTypeId");

            migrationBuilder.RenameColumn(
                name: "BuildingTypeId",
                table: "ColonyBuildings",
                newName: "ConfigGenericTypeId");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "ColonyBuildingRooms",
                newName: "ConfigGenericTypeId");

            migrationBuilder.RenameColumn(
                name: "ColonyTypeId",
                table: "Colonies",
                newName: "ConfigGenericTypeId");

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeGroupId",
                table: "PeoplesPhoneInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeGroupId",
                table: "PeoplesInternetInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericGenderGroupId",
                table: "Peoples",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericGenderId",
                table: "Peoples",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericProfessionGroupId",
                table: "Peoples",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeGroupId",
                table: "PeopleAttributions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeId",
                table: "PeopleAttributions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeGroupId",
                table: "PeopleAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeGroupId",
                table: "ColonyBuildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericGroupTypeId",
                table: "ColonyBuildingRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfigGenericTypeGroupId",
                table: "Colonies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConfigGenericGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    RelatedSubject = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
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
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsList = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemDataTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigGenericItems",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigGenericItems", x => new { x.GroupId, x.Id });
                    table.ForeignKey(
                        name: "FK_ConfigGenericItems_ConfigGenericGroups",
                        column: x => x.GroupId,
                        principalTable: "ConfigGenericGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfigGenericItemExtentions",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SystemDataTypeId = table.Column<int>(type: "int", nullable: false)
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
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    ExtentionId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
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

            migrationBuilder.InsertData(
                table: "ConfigGenericGroups",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName", "RelatedSubject" },
                values: new object[] { 1, "NATIONALITIES", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group that contains all the known nationalities", null, "SYSTEM", "PEOPLES" });

            migrationBuilder.InsertData(
                table: "ConfigGenericGroups",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName", "RelatedSubject" },
                values: new object[] { 2, "COUNTRIES", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group that contains all the known countries", null, "SYSTEM", "PEOPLES" });

            migrationBuilder.InsertData(
                table: "ConfigGenericGroups",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName", "RelatedSubject" },
                values: new object[] { 3, "LANGUAGES", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group that contains all the known Languages", null, "SYSTEM", "PEOPLES" });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 0, "UNK", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unknown", null, "SYSTEM" },
                    { 2, 221, "Thailand", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TH", null, "SYSTEM" },
                    { 2, 222, "Timor-Leste", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TL", null, "SYSTEM" },
                    { 2, 223, "Togo", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TG", null, "SYSTEM" },
                    { 2, 224, "Tokelau", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TK", null, "SYSTEM" },
                    { 2, 225, "Tonga", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TO", null, "SYSTEM" },
                    { 2, 226, "Trinidad and Tobago", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TT", null, "SYSTEM" },
                    { 2, 227, "Tunisia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TN", null, "SYSTEM" },
                    { 2, 228, "Turkey", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TR", null, "SYSTEM" },
                    { 2, 229, "Turkmenistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TM", null, "SYSTEM" },
                    { 2, 230, "Turks and Caicos Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TC", null, "SYSTEM" },
                    { 2, 231, "Tuvalu", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TV", null, "SYSTEM" },
                    { 2, 232, "Uganda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UG", null, "SYSTEM" },
                    { 2, 233, "Ukraine", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UA", null, "SYSTEM" },
                    { 2, 234, "United Arab Emirates", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AE", null, "SYSTEM" },
                    { 2, 235, "United Kingdom", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GB", null, "SYSTEM" },
                    { 2, 220, "Tanzania, United Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TZ", null, "SYSTEM" },
                    { 2, 219, "Tajikistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TJ", null, "SYSTEM" },
                    { 2, 218, "Taiwan, Province of China", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TW", null, "SYSTEM" },
                    { 2, 217, "Syrian Arab Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SY", null, "SYSTEM" },
                    { 2, 201, "Sint Maarten (Dutch part)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SX", null, "SYSTEM" },
                    { 2, 202, "Slovakia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SK", null, "SYSTEM" },
                    { 2, 203, "Slovenia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SI", null, "SYSTEM" },
                    { 2, 204, "Solomon Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SB", null, "SYSTEM" },
                    { 2, 205, "Somalia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SO", null, "SYSTEM" },
                    { 2, 206, "South Africa", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZA", null, "SYSTEM" },
                    { 2, 207, "South Georgia and the South Sandwich Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GS", null, "SYSTEM" },
                    { 2, 236, "United States", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "US", null, "SYSTEM" },
                    { 2, 208, "South Sudan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SS", null, "SYSTEM" },
                    { 2, 210, "Sri Lanka", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LK", null, "SYSTEM" },
                    { 2, 211, "Sudan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SD", null, "SYSTEM" },
                    { 2, 212, "Suriname", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SR", null, "SYSTEM" },
                    { 2, 213, "Svalbard and Jan Mayen", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SJ", null, "SYSTEM" },
                    { 2, 214, "Swaziland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SZ", null, "SYSTEM" },
                    { 2, 215, "Sweden", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SE", null, "SYSTEM" },
                    { 2, 216, "Switzerland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CH", null, "SYSTEM" },
                    { 2, 209, "Spain", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ES", null, "SYSTEM" },
                    { 2, 200, "Singapore", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SG", null, "SYSTEM" },
                    { 2, 237, "United States Minor Outlying Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UM", null, "SYSTEM" },
                    { 2, 239, "Uzbekistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UZ", null, "SYSTEM" },
                    { 3, 10, "AV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avaric", null, "SYSTEM" },
                    { 3, 11, "AY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aymara", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 12, "AZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijani", null, "SYSTEM" },
                    { 3, 13, "BA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bashkir", null, "SYSTEM" },
                    { 3, 14, "BE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belarusian", null, "SYSTEM" },
                    { 3, 15, "BG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgarian", null, "SYSTEM" },
                    { 3, 16, "BH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bihari languages", null, "SYSTEM" },
                    { 3, 17, "BM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bambara", null, "SYSTEM" },
                    { 3, 18, "BI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bislama", null, "SYSTEM" },
                    { 3, 19, "BN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bengali", null, "SYSTEM" },
                    { 3, 20, "BO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tibetan", null, "SYSTEM" },
                    { 3, 21, "BR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breton", null, "SYSTEM" },
                    { 3, 22, "BS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosnian", null, "SYSTEM" },
                    { 3, 23, "CA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catalan; Valencian", null, "SYSTEM" },
                    { 3, 24, "CE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chechen", null, "SYSTEM" },
                    { 3, 9, "AS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assamese", null, "SYSTEM" },
                    { 3, 8, "AR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arabic", null, "SYSTEM" },
                    { 3, 7, "AN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aragonese", null, "SYSTEM" },
                    { 3, 6, "AM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amharic", null, "SYSTEM" },
                    { 2, 240, "Vanuatu", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VU", null, "SYSTEM" },
                    { 2, 241, "Venezuela, Bolivarian Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VE", null, "SYSTEM" },
                    { 2, 242, "Viet Nam", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VN", null, "SYSTEM" },
                    { 2, 243, "Virgin Islands, British", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VG", null, "SYSTEM" },
                    { 2, 244, "Virgin Islands, U.S.", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VI", null, "SYSTEM" },
                    { 2, 245, "Wallis and Futuna", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "WF", null, "SYSTEM" },
                    { 2, 246, "Western Sahara", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EH", null, "SYSTEM" },
                    { 2, 238, "Uruguay", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UY", null, "SYSTEM" },
                    { 2, 247, "Yemen", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "YE", null, "SYSTEM" },
                    { 2, 249, "Zimbabwe", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZW", null, "SYSTEM" },
                    { 3, 0, "UNK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unknown", null, "SYSTEM" },
                    { 3, 1, "AA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afar", null, "SYSTEM" },
                    { 3, 2, "AB", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abkhazian", null, "SYSTEM" },
                    { 3, 3, "AE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avestan", null, "SYSTEM" },
                    { 3, 4, "AF", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afrikaans", null, "SYSTEM" },
                    { 3, 5, "AK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akan", null, "SYSTEM" },
                    { 2, 248, "Zambia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZM", null, "SYSTEM" },
                    { 2, 199, "Sierra Leone", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SL", null, "SYSTEM" },
                    { 2, 198, "Seychelles", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SC", null, "SYSTEM" },
                    { 2, 197, "Serbia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RS", null, "SYSTEM" },
                    { 2, 142, "Mauritius", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MU", null, "SYSTEM" },
                    { 2, 143, "Mayotte", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "YT", null, "SYSTEM" },
                    { 2, 144, "Mexico", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MX", null, "SYSTEM" },
                    { 2, 145, "Micronesia, Federated States of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FM", null, "SYSTEM" },
                    { 2, 146, "Moldova, Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 147, "Monaco", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MC", null, "SYSTEM" },
                    { 2, 148, "Mongolia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MN", null, "SYSTEM" },
                    { 2, 149, "Montenegro", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ME", null, "SYSTEM" },
                    { 2, 150, "Montserrat", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MS", null, "SYSTEM" },
                    { 2, 151, "Morocco", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MA", null, "SYSTEM" },
                    { 2, 152, "Mozambique", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MZ", null, "SYSTEM" },
                    { 2, 153, "Myanmar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM", null, "SYSTEM" },
                    { 2, 154, "Namibia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NA", null, "SYSTEM" },
                    { 2, 155, "Nauru", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NR", null, "SYSTEM" },
                    { 2, 156, "Nepal", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NP", null, "SYSTEM" },
                    { 2, 141, "Mauritania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MR", null, "SYSTEM" },
                    { 2, 140, "Martinique", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MQ", null, "SYSTEM" },
                    { 2, 139, "Marshall Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MH", null, "SYSTEM" },
                    { 2, 138, "Malta", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MT", null, "SYSTEM" },
                    { 2, 122, "Lao People's Democratic Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LA", null, "SYSTEM" },
                    { 2, 123, "Latvia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LV", null, "SYSTEM" },
                    { 2, 124, "Lebanon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LB", null, "SYSTEM" },
                    { 2, 125, "Lesotho", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LS", null, "SYSTEM" },
                    { 2, 126, "Liberia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LR", null, "SYSTEM" },
                    { 2, 127, "Libya", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LY", null, "SYSTEM" },
                    { 2, 128, "Liechtenstein", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LI", null, "SYSTEM" },
                    { 2, 157, "Netherlands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NL", null, "SYSTEM" },
                    { 2, 129, "Lithuania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LT", null, "SYSTEM" },
                    { 2, 131, "Macao", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MO", null, "SYSTEM" },
                    { 2, 132, "Macedonia, the Former Yugoslav Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MK", null, "SYSTEM" },
                    { 2, 133, "Madagascar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MG", null, "SYSTEM" },
                    { 2, 134, "Malawi", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MW", null, "SYSTEM" },
                    { 2, 135, "Malaysia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MY", null, "SYSTEM" },
                    { 2, 136, "Maldives", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MV", null, "SYSTEM" },
                    { 2, 137, "Mali", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ML", null, "SYSTEM" },
                    { 2, 130, "Luxembourg", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LU", null, "SYSTEM" },
                    { 2, 158, "New Caledonia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NC", null, "SYSTEM" },
                    { 2, 159, "New Zealand", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NZ", null, "SYSTEM" },
                    { 2, 160, "Nicaragua", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NI", null, "SYSTEM" },
                    { 2, 181, "Réunion", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RE", null, "SYSTEM" },
                    { 2, 182, "Romania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RO", null, "SYSTEM" },
                    { 2, 183, "Russian Federation", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RU", null, "SYSTEM" },
                    { 2, 184, "Rwanda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RW", null, "SYSTEM" },
                    { 2, 185, "Saint Barthélemy", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BL", null, "SYSTEM" },
                    { 2, 186, "Saint Helena, Ascension and Tristan da Cunha", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SH", null, "SYSTEM" },
                    { 2, 187, "Saint Kitts and Nevis", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KN", null, "SYSTEM" },
                    { 2, 180, "Qatar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "QA", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 188, "Saint Lucia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LC", null, "SYSTEM" },
                    { 2, 190, "Saint Pierre and Miquelon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM", null, "SYSTEM" },
                    { 2, 191, "Saint Vincent and the Grenadines", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VC", null, "SYSTEM" },
                    { 2, 192, "Samoa", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "WS", null, "SYSTEM" },
                    { 2, 193, "San Marino", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SM", null, "SYSTEM" },
                    { 2, 194, "Sao Tome and Principe", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ST", null, "SYSTEM" },
                    { 2, 195, "Saudi Arabia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SA", null, "SYSTEM" },
                    { 2, 196, "Senegal", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SN", null, "SYSTEM" },
                    { 2, 189, "Saint Martin (French part)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MF", null, "SYSTEM" },
                    { 3, 25, "CH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chamorro", null, "SYSTEM" },
                    { 2, 179, "Puerto Rico", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PR", null, "SYSTEM" },
                    { 2, 177, "Poland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PL", null, "SYSTEM" },
                    { 2, 161, "Niger", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NE", null, "SYSTEM" },
                    { 2, 162, "Nigeria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NG", null, "SYSTEM" },
                    { 2, 163, "Niue", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NU", null, "SYSTEM" },
                    { 2, 164, "Norfolk Island", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NF", null, "SYSTEM" },
                    { 2, 165, "Northern Mariana Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MP", null, "SYSTEM" },
                    { 2, 166, "Norway", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NO", null, "SYSTEM" },
                    { 2, 167, "Oman", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OM", null, "SYSTEM" },
                    { 2, 178, "Portugal", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PT", null, "SYSTEM" },
                    { 2, 168, "Pakistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PK", null, "SYSTEM" },
                    { 2, 170, "Palestine, State of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PS", null, "SYSTEM" },
                    { 2, 171, "Panama", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PA", null, "SYSTEM" },
                    { 2, 172, "Papua New Guinea", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PG", null, "SYSTEM" },
                    { 2, 173, "Paraguay", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PY", null, "SYSTEM" },
                    { 2, 174, "Peru", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PE", null, "SYSTEM" },
                    { 2, 175, "Philippines", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PH", null, "SYSTEM" },
                    { 2, 176, "Pitcairn", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PN", null, "SYSTEM" },
                    { 2, 169, "Palau", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PW", null, "SYSTEM" },
                    { 3, 26, "CO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corsican", null, "SYSTEM" },
                    { 3, 27, "CR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cree", null, "SYSTEM" },
                    { 3, 28, "CS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech", null, "SYSTEM" },
                    { 3, 128, "PI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pali", null, "SYSTEM" },
                    { 3, 129, "PL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", null, "SYSTEM" },
                    { 3, 130, "PS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pushto; Pashto", null, "SYSTEM" },
                    { 3, 131, "PT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portuguese", null, "SYSTEM" },
                    { 3, 132, "QU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quechua", null, "SYSTEM" },
                    { 3, 133, "RM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romansh", null, "SYSTEM" },
                    { 3, 134, "RN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rundi", null, "SYSTEM" },
                    { 3, 135, "RO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romanian; Moldavian; Moldovan", null, "SYSTEM" },
                    { 3, 136, "RU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russian", null, "SYSTEM" },
                    { 3, 137, "RW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kinyarwanda", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 138, "SA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanskrit", null, "SYSTEM" },
                    { 3, 139, "SC", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sardinian", null, "SYSTEM" },
                    { 3, 140, "SD", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sindhi", null, "SYSTEM" },
                    { 3, 141, "SE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Sami", null, "SYSTEM" },
                    { 3, 142, "SG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sango", null, "SYSTEM" },
                    { 3, 127, "PA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panjabi; Punjabi", null, "SYSTEM" },
                    { 3, 126, "OS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ossetian; Ossetic", null, "SYSTEM" },
                    { 3, 125, "OR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oriya", null, "SYSTEM" },
                    { 3, 124, "OM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oromo", null, "SYSTEM" },
                    { 3, 108, "MS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malay", null, "SYSTEM" },
                    { 3, 109, "MT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maltese", null, "SYSTEM" },
                    { 3, 110, "MY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burmese", null, "SYSTEM" },
                    { 3, 111, "NA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nauru", null, "SYSTEM" },
                    { 3, 112, "NB", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian Bokm�l", null, "SYSTEM" },
                    { 3, 113, "ND", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Ndebele", null, "SYSTEM" },
                    { 3, 114, "NE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepali", null, "SYSTEM" },
                    { 3, 143, "SI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinhala; Sinhalese", null, "SYSTEM" },
                    { 3, 115, "NG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ndonga", null, "SYSTEM" },
                    { 3, 117, "NN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian Nynorsk; Nynorsk,Norwegian", null, "SYSTEM" },
                    { 3, 118, "NO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian", null, "SYSTEM" },
                    { 3, 119, "NR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ndebele,South; South Ndebele", null, "SYSTEM" },
                    { 3, 120, "NV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navajo; Navaho", null, "SYSTEM" },
                    { 3, 121, "NY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chichewa; Chewa; Nyanja", null, "SYSTEM" },
                    { 3, 122, "OC", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occitan (post 1500)", null, "SYSTEM" },
                    { 3, 123, "OJ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ojibwa", null, "SYSTEM" },
                    { 3, 116, "NL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dutch; Flemish", null, "SYSTEM" },
                    { 3, 144, "SK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovak", null, "SYSTEM" },
                    { 3, 145, "SL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenian", null, "SYSTEM" },
                    { 3, 146, "SM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoan", null, "SYSTEM" },
                    { 3, 167, "TT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tatar", null, "SYSTEM" },
                    { 3, 168, "TW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twi", null, "SYSTEM" },
                    { 3, 169, "TY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tahitian", null, "SYSTEM" },
                    { 3, 170, "UG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uighur; Uyghur", null, "SYSTEM" },
                    { 3, 171, "UK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukrainian", null, "SYSTEM" },
                    { 3, 172, "UR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urdu", null, "SYSTEM" },
                    { 3, 173, "UZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbek", null, "SYSTEM" },
                    { 3, 166, "TS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tsonga", null, "SYSTEM" },
                    { 3, 174, "VE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venda", null, "SYSTEM" },
                    { 3, 176, "VO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volap�k", null, "SYSTEM" },
                    { 3, 177, "WA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walloon", null, "SYSTEM" },
                    { 3, 178, "WO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wolof", null, "SYSTEM" },
                    { 3, 179, "XH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xhosa", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 180, "YI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yiddish", null, "SYSTEM" },
                    { 3, 181, "YO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoruba", null, "SYSTEM" },
                    { 3, 182, "ZA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zhuang; Chuang", null, "SYSTEM" },
                    { 3, 175, "VI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vietnamese", null, "SYSTEM" },
                    { 3, 107, "MR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marathi", null, "SYSTEM" },
                    { 3, 165, "TR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish", null, "SYSTEM" },
                    { 3, 163, "TN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tswana", null, "SYSTEM" },
                    { 3, 147, "SN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shona", null, "SYSTEM" },
                    { 3, 148, "SO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somali", null, "SYSTEM" },
                    { 3, 149, "SQ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albanian", null, "SYSTEM" },
                    { 3, 150, "SR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbian", null, "SYSTEM" },
                    { 3, 151, "SS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swati", null, "SYSTEM" },
                    { 3, 152, "ST", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sotho, Southern", null, "SYSTEM" },
                    { 3, 153, "SU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundanese", null, "SYSTEM" },
                    { 3, 164, "TO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tonga (Tonga Islands)", null, "SYSTEM" },
                    { 3, 154, "SV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swedish", null, "SYSTEM" },
                    { 3, 156, "TA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamil", null, "SYSTEM" },
                    { 3, 157, "TE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telugu", null, "SYSTEM" },
                    { 3, 158, "TG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tajik", null, "SYSTEM" },
                    { 3, 159, "TH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai", null, "SYSTEM" },
                    { 3, 160, "TI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tigrinya", null, "SYSTEM" },
                    { 3, 161, "TK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkmen", null, "SYSTEM" },
                    { 3, 162, "TL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tagalog", null, "SYSTEM" },
                    { 3, 155, "SW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swahili", null, "SYSTEM" },
                    { 2, 121, "Kyrgyzstan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KG", null, "SYSTEM" },
                    { 3, 106, "MN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mongolian", null, "SYSTEM" },
                    { 3, 104, "MK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macedonian", null, "SYSTEM" },
                    { 3, 49, "FY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Frisian", null, "SYSTEM" },
                    { 3, 50, "GA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irish", null, "SYSTEM" },
                    { 3, 51, "GD", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaelic; Scottish Gaelic", null, "SYSTEM" },
                    { 3, 52, "GL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galician", null, "SYSTEM" },
                    { 3, 53, "GN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guarani", null, "SYSTEM" },
                    { 3, 54, "GU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gujarati", null, "SYSTEM" },
                    { 3, 55, "GV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manx", null, "SYSTEM" },
                    { 3, 56, "HA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hausa", null, "SYSTEM" },
                    { 3, 57, "HE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hebrew", null, "SYSTEM" },
                    { 3, 58, "HI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hindi", null, "SYSTEM" },
                    { 3, 59, "HO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hiri Motu", null, "SYSTEM" },
                    { 3, 60, "HR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatian", null, "SYSTEM" },
                    { 3, 61, "HT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haitian; Haitian Creole", null, "SYSTEM" },
                    { 3, 62, "HU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungarian", null, "SYSTEM" },
                    { 3, 63, "HY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenian", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 48, "FR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "French", null, "SYSTEM" },
                    { 3, 47, "FO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faroese", null, "SYSTEM" },
                    { 3, 46, "FJ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fijian", null, "SYSTEM" },
                    { 3, 45, "FI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finnish", null, "SYSTEM" },
                    { 3, 29, "CU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic", null, "SYSTEM" },
                    { 3, 30, "CV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chuvash", null, "SYSTEM" },
                    { 3, 31, "CY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welsh", null, "SYSTEM" },
                    { 3, 32, "DA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", null, "SYSTEM" },
                    { 3, 33, "DE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "German", null, "SYSTEM" },
                    { 3, 34, "DV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Divehi; Dhivehi; Maldivian", null, "SYSTEM" },
                    { 3, 35, "DZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dzongkha", null, "SYSTEM" },
                    { 3, 64, "HZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herero", null, "SYSTEM" },
                    { 3, 36, "EE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ewe", null, "SYSTEM" },
                    { 3, 38, "EN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", null, "SYSTEM" },
                    { 3, 39, "EO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esperanto", null, "SYSTEM" },
                    { 3, 40, "ES", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish; Castilian", null, "SYSTEM" },
                    { 3, 41, "ET", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estonian", null, "SYSTEM" },
                    { 3, 42, "EU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basque", null, "SYSTEM" },
                    { 3, 43, "FA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persian", null, "SYSTEM" },
                    { 3, 44, "FF", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fulah", null, "SYSTEM" },
                    { 3, 37, "EL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greek, Modern (1453-)", null, "SYSTEM" },
                    { 3, 65, "IA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interlingua (International Auxiliary Language Association)", null, "SYSTEM" },
                    { 3, 66, "ID", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indonesian", null, "SYSTEM" },
                    { 3, 67, "IE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interlingue; Occidental", null, "SYSTEM" },
                    { 3, 88, "KU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurdish", null, "SYSTEM" },
                    { 3, 89, "KV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komi", null, "SYSTEM" },
                    { 3, 90, "KW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cornish", null, "SYSTEM" },
                    { 3, 91, "KY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kirghiz; Kyrgyz", null, "SYSTEM" },
                    { 3, 92, "LA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latin", null, "SYSTEM" },
                    { 3, 93, "LB", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxembourgish; Letzeburgesch", null, "SYSTEM" },
                    { 3, 94, "LG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ganda", null, "SYSTEM" },
                    { 3, 87, "KS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kashmiri", null, "SYSTEM" },
                    { 3, 95, "LI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limburgan; Limburger; Limburgish", null, "SYSTEM" },
                    { 3, 97, "LO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lao", null, "SYSTEM" },
                    { 3, 98, "LT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lithuanian", null, "SYSTEM" },
                    { 3, 99, "LU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luba-Katanga", null, "SYSTEM" },
                    { 3, 100, "LV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latvian", null, "SYSTEM" },
                    { 3, 101, "MG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malagasy", null, "SYSTEM" },
                    { 3, 102, "MH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshallese", null, "SYSTEM" },
                    { 3, 103, "MI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maori", null, "SYSTEM" },
                    { 3, 96, "LN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lingala", null, "SYSTEM" },
                    { 3, 105, "ML", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malayalam", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 86, "KR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kanuri", null, "SYSTEM" },
                    { 3, 84, "KN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kannada", null, "SYSTEM" },
                    { 3, 68, "IG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igbo", null, "SYSTEM" },
                    { 3, 69, "II", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sichuan Yi; Nuosu", null, "SYSTEM" },
                    { 3, 70, "IK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inupiaq", null, "SYSTEM" },
                    { 3, 71, "IO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ido", null, "SYSTEM" },
                    { 3, 72, "IS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Icelandic", null, "SYSTEM" },
                    { 3, 73, "IT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian", null, "SYSTEM" },
                    { 3, 74, "IU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inuktitut", null, "SYSTEM" },
                    { 3, 85, "KO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Korean", null, "SYSTEM" },
                    { 3, 75, "JA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese", null, "SYSTEM" },
                    { 3, 77, "KA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian", null, "SYSTEM" },
                    { 3, 78, "KG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kongo", null, "SYSTEM" },
                    { 3, 79, "KI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kikuyu; Gikuyu", null, "SYSTEM" },
                    { 3, 80, "KJ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuanyama; Kwanyama", null, "SYSTEM" },
                    { 3, 81, "KK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakh", null, "SYSTEM" },
                    { 3, 82, "KL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalaallisut; Greenlandic", null, "SYSTEM" },
                    { 3, 83, "KM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Khmer", null, "SYSTEM" },
                    { 3, 76, "JV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javanese", null, "SYSTEM" },
                    { 2, 120, "Kuwait", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KW", null, "SYSTEM" },
                    { 2, 119, "Korea, Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KR", null, "SYSTEM" },
                    { 2, 118, "Korea, Democratic People's Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KP", null, "SYSTEM" },
                    { 1, 100, "LEB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lebanese", null, "SYSTEM" },
                    { 1, 101, "LIB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liberian", null, "SYSTEM" },
                    { 1, 102, "LIBY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libyan", null, "SYSTEM" },
                    { 1, 103, "LIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liechtensteiner", null, "SYSTEM" },
                    { 1, 104, "LIT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lithuanian", null, "SYSTEM" },
                    { 1, 105, "LUX", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxembourger", null, "SYSTEM" },
                    { 1, 106, "MAC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macedonian", null, "SYSTEM" },
                    { 1, 107, "MAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malagasy", null, "SYSTEM" },
                    { 1, 108, "MALAW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malawian", null, "SYSTEM" },
                    { 1, 109, "MALA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malaysian", null, "SYSTEM" },
                    { 1, 110, "MALD", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maldivian", null, "SYSTEM" },
                    { 1, 111, "MALI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malian", null, "SYSTEM" },
                    { 1, 112, "MALT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maltese", null, "SYSTEM" },
                    { 1, 113, "MAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshallese", null, "SYSTEM" },
                    { 1, 114, "MAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritanian", null, "SYSTEM" },
                    { 1, 99, "LAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latvian", null, "SYSTEM" },
                    { 1, 98, "LAO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laotian", null, "SYSTEM" },
                    { 1, 97, "KYR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrgyz", null, "SYSTEM" },
                    { 1, 96, "KUW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuwaiti", null, "SYSTEM" },
                    { 1, 80, "I-K", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "I-Kiribati", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 81, "ICE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Icelander", null, "SYSTEM" },
                    { 1, 82, "IND", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian", null, "SYSTEM" },
                    { 1, 83, "INDO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indonesian", null, "SYSTEM" },
                    { 1, 84, "IRA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iranian", null, "SYSTEM" },
                    { 1, 85, "IRAQ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iraqi", null, "SYSTEM" },
                    { 1, 86, "IRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irish", null, "SYSTEM" },
                    { 1, 115, "MAUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritian", null, "SYSTEM" },
                    { 1, 87, "ISR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israeli", null, "SYSTEM" },
                    { 1, 89, "IVO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivorian", null, "SYSTEM" },
                    { 1, 90, "JAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaican", null, "SYSTEM" },
                    { 1, 91, "JAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese", null, "SYSTEM" },
                    { 1, 92, "JOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordanian", null, "SYSTEM" },
                    { 1, 93, "KAZ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakhstani", null, "SYSTEM" },
                    { 1, 94, "KEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenyan", null, "SYSTEM" },
                    { 1, 95, "KIT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kittian and Nevisian", null, "SYSTEM" },
                    { 1, 88, "ITA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian", null, "SYSTEM" },
                    { 1, 116, "MEX", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexican", null, "SYSTEM" },
                    { 1, 117, "MIC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micronesian", null, "SYSTEM" },
                    { 1, 118, "MOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldovan", null, "SYSTEM" },
                    { 1, 139, "PAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panamanian", null, "SYSTEM" },
                    { 1, 140, "PAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Papua New Guinean", null, "SYSTEM" },
                    { 1, 141, "PAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paraguayan", null, "SYSTEM" },
                    { 1, 142, "PER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peruvian", null, "SYSTEM" },
                    { 1, 143, "POL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", null, "SYSTEM" },
                    { 1, 144, "POR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portuguese", null, "SYSTEM" },
                    { 1, 145, "QAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qatari", null, "SYSTEM" },
                    { 1, 138, "PAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palauan", null, "SYSTEM" },
                    { 1, 146, "ROM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romanian", null, "SYSTEM" },
                    { 1, 148, "RWA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rwandan", null, "SYSTEM" },
                    { 1, 149, "SAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint Lucian", null, "SYSTEM" },
                    { 1, 150, "SAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvadoran", null, "SYSTEM" },
                    { 1, 151, "SAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoan", null, "SYSTEM" },
                    { 1, 152, "SAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Marinese", null, "SYSTEM" },
                    { 1, 153, "SAO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sao Tomean", null, "SYSTEM" },
                    { 1, 154, "SAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saudi", null, "SYSTEM" },
                    { 1, 147, "RUS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russian", null, "SYSTEM" },
                    { 1, 79, "HUN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungarian", null, "SYSTEM" },
                    { 1, 137, "PAK", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pakistani", null, "SYSTEM" },
                    { 1, 135, "NORW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian", null, "SYSTEM" },
                    { 1, 119, "MON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monacan", null, "SYSTEM" },
                    { 1, 120, "MONG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mongolian", null, "SYSTEM" },
                    { 1, 121, "MOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moroccan", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 122, "MOS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mosotho", null, "SYSTEM" },
                    { 1, 123, "MOT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Motswana", null, "SYSTEM" },
                    { 1, 124, "MOZ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mozambican", null, "SYSTEM" },
                    { 1, 125, "NAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Namibian", null, "SYSTEM" },
                    { 1, 136, "OMA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omani", null, "SYSTEM" },
                    { 1, 126, "NAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nauruan", null, "SYSTEM" },
                    { 1, 128, "NEW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Zealander", null, "SYSTEM" },
                    { 1, 129, "NI-", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ni-Vanuatu", null, "SYSTEM" },
                    { 1, 130, "NIC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicaraguan", null, "SYSTEM" },
                    { 1, 131, "NIG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigerian", null, "SYSTEM" },
                    { 1, 132, "NIGE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigerien", null, "SYSTEM" },
                    { 1, 133, "NOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Korean", null, "SYSTEM" },
                    { 1, 134, "NORT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Irish", null, "SYSTEM" },
                    { 1, 127, "NEP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepalese", null, "SYSTEM" },
                    { 1, 155, "SCO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scottish", null, "SYSTEM" },
                    { 1, 78, "HON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduran", null, "SYSTEM" },
                    { 1, 76, "HAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haitian", null, "SYSTEM" },
                    { 1, 21, "BELI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belizean", null, "SYSTEM" },
                    { 1, 22, "BEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beninese", null, "SYSTEM" },
                    { 1, 23, "BHU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bhutanese", null, "SYSTEM" },
                    { 1, 24, "BOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolivian", null, "SYSTEM" },
                    { 1, 25, "BOS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosnian", null, "SYSTEM" },
                    { 1, 26, "BRA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazilian", null, "SYSTEM" },
                    { 1, 27, "BRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "British", null, "SYSTEM" },
                    { 1, 28, "BRU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruneian", null, "SYSTEM" },
                    { 1, 29, "BUL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgarian", null, "SYSTEM" },
                    { 1, 30, "BUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burkinabe", null, "SYSTEM" },
                    { 1, 31, "BURM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burmese", null, "SYSTEM" },
                    { 1, 32, "BURU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burundian", null, "SYSTEM" },
                    { 1, 33, "CAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cambodian", null, "SYSTEM" },
                    { 1, 34, "CAME", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cameroonian", null, "SYSTEM" },
                    { 1, 35, "CAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian", null, "SYSTEM" },
                    { 1, 20, "BELG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgian", null, "SYSTEM" },
                    { 1, 19, "BEL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belarusian", null, "SYSTEM" },
                    { 1, 18, "BAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batswana", null, "SYSTEM" },
                    { 1, 17, "BARB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbudans", null, "SYSTEM" },
                    { 1, 1, "AFG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afghan", null, "SYSTEM" },
                    { 1, 2, "ALB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albanian", null, "SYSTEM" },
                    { 1, 3, "ALG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Algerian", null, "SYSTEM" },
                    { 1, 4, "AME", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "American", null, "SYSTEM" },
                    { 1, 5, "AND", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andorran", null, "SYSTEM" },
                    { 1, 6, "ANG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angolan", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 7, "ANT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antiguans", null, "SYSTEM" },
                    { 1, 36, "CAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cape Verdean", null, "SYSTEM" },
                    { 1, 8, "ARG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentinean", null, "SYSTEM" },
                    { 1, 10, "AUS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian", null, "SYSTEM" },
                    { 1, 11, "AUST", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austrian", null, "SYSTEM" },
                    { 1, 12, "AZE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijani", null, "SYSTEM" },
                    { 1, 13, "BAH", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahamian", null, "SYSTEM" },
                    { 1, 14, "BAHR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahraini", null, "SYSTEM" },
                    { 1, 15, "BAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bangladeshi", null, "SYSTEM" },
                    { 1, 16, "BAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbadian", null, "SYSTEM" },
                    { 1, 9, "ARM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenian", null, "SYSTEM" },
                    { 1, 37, "CEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central African", null, "SYSTEM" },
                    { 1, 38, "CHA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chadian", null, "SYSTEM" },
                    { 1, 39, "CHI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilean", null, "SYSTEM" },
                    { 1, 60, "ETH", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethiopian", null, "SYSTEM" },
                    { 1, 61, "FIJ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fijian", null, "SYSTEM" },
                    { 1, 62, "FIL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filipino", null, "SYSTEM" },
                    { 1, 63, "FIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finnish", null, "SYSTEM" },
                    { 1, 64, "FRE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "French", null, "SYSTEM" },
                    { 1, 65, "GAB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabonese", null, "SYSTEM" },
                    { 1, 66, "GAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambian", null, "SYSTEM" },
                    { 1, 59, "EST", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estonian", null, "SYSTEM" },
                    { 1, 67, "GEO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian", null, "SYSTEM" },
                    { 1, 69, "GHA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghanaian", null, "SYSTEM" },
                    { 1, 70, "GRE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greek", null, "SYSTEM" },
                    { 1, 71, "GREN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grenadian", null, "SYSTEM" },
                    { 1, 72, "GUA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guatemalan", null, "SYSTEM" },
                    { 1, 73, "GUI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinea-Bissauan", null, "SYSTEM" },
                    { 1, 74, "GUIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinean", null, "SYSTEM" },
                    { 1, 75, "GUY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guyanese", null, "SYSTEM" },
                    { 1, 68, "GER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "German", null, "SYSTEM" },
                    { 1, 77, "HER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herzegovinian", null, "SYSTEM" },
                    { 1, 58, "ERI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eritrean", null, "SYSTEM" },
                    { 1, 56, "EMI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emirian", null, "SYSTEM" },
                    { 1, 40, "CHIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinese", null, "SYSTEM" },
                    { 1, 41, "COL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombian", null, "SYSTEM" },
                    { 1, 42, "COM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comoran", null, "SYSTEM" },
                    { 1, 43, "CON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Congolese", null, "SYSTEM" },
                    { 1, 44, "COS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rican", null, "SYSTEM" },
                    { 1, 45, "CRO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatian", null, "SYSTEM" },
                    { 1, 46, "CUB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuban", null, "SYSTEM" },
                    { 1, 57, "EQU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equatorial Guinean", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 47, "CYP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cypriot", null, "SYSTEM" },
                    { 1, 49, "DAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", null, "SYSTEM" },
                    { 1, 50, "DJI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Djibouti", null, "SYSTEM" },
                    { 1, 51, "DOM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominican", null, "SYSTEM" },
                    { 1, 52, "DUT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dutch", null, "SYSTEM" },
                    { 1, 53, "EAS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Timorese", null, "SYSTEM" },
                    { 1, 54, "ECU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ecuadorean", null, "SYSTEM" },
                    { 1, 55, "EGY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egyptian", null, "SYSTEM" },
                    { 1, 48, "CZE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech", null, "SYSTEM" },
                    { 3, 183, "ZH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinese", null, "SYSTEM" },
                    { 1, 156, "SEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senegalese", null, "SYSTEM" },
                    { 1, 158, "SEY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seychellois", null, "SYSTEM" },
                    { 2, 63, "Dominica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DM", null, "SYSTEM" },
                    { 2, 64, "Dominican Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DO", null, "SYSTEM" },
                    { 2, 65, "Ecuador", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EC", null, "SYSTEM" },
                    { 2, 66, "Egypt", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EG", null, "SYSTEM" },
                    { 2, 67, "El Salvador", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SV", null, "SYSTEM" },
                    { 2, 68, "Equatorial Guinea", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GQ", null, "SYSTEM" },
                    { 2, 69, "Eritrea", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ER", null, "SYSTEM" },
                    { 2, 70, "Estonia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE", null, "SYSTEM" },
                    { 2, 71, "Ethiopia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ET", null, "SYSTEM" },
                    { 2, 72, "Falkland Islands (Malvinas)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FK", null, "SYSTEM" },
                    { 2, 73, "Faroe Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FO", null, "SYSTEM" },
                    { 2, 74, "Fiji", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FJ", null, "SYSTEM" },
                    { 2, 75, "Finland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FI", null, "SYSTEM" },
                    { 2, 76, "France", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FR", null, "SYSTEM" },
                    { 2, 77, "French Guiana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GF", null, "SYSTEM" },
                    { 2, 62, "Djibouti", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ", null, "SYSTEM" },
                    { 2, 61, "Denmark", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DK", null, "SYSTEM" },
                    { 2, 60, "Czech Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CZ", null, "SYSTEM" },
                    { 2, 59, "Cyprus", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CY", null, "SYSTEM" },
                    { 2, 43, "Central African Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CF", null, "SYSTEM" },
                    { 2, 44, "Chad", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TD", null, "SYSTEM" },
                    { 2, 45, "Chile", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CL", null, "SYSTEM" },
                    { 2, 46, "China", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CN", null, "SYSTEM" },
                    { 2, 47, "Christmas Island", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CX", null, "SYSTEM" },
                    { 2, 48, "Cocos (Keeling) Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC", null, "SYSTEM" },
                    { 2, 49, "Colombia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CO", null, "SYSTEM" },
                    { 2, 78, "French Polynesia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PF", null, "SYSTEM" },
                    { 2, 50, "Comoros", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KM", null, "SYSTEM" },
                    { 2, 52, "Congo, the Democratic Republic of the", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CD", null, "SYSTEM" },
                    { 2, 53, "Cook Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CK", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 54, "Costa Rica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CR", null, "SYSTEM" },
                    { 2, 55, "Côte d'Ivoire", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CI", null, "SYSTEM" },
                    { 2, 56, "Croatia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", null, "SYSTEM" },
                    { 2, 57, "Cuba", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CU", null, "SYSTEM" },
                    { 2, 58, "Curaçao", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CW", null, "SYSTEM" },
                    { 2, 51, "Congo", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CG", null, "SYSTEM" },
                    { 2, 79, "French Southern Territories", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TF", null, "SYSTEM" },
                    { 2, 80, "Gabon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GA", null, "SYSTEM" },
                    { 2, 81, "Gambia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GM", null, "SYSTEM" },
                    { 2, 102, "Iceland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IS", null, "SYSTEM" },
                    { 2, 103, "India", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IN", null, "SYSTEM" },
                    { 2, 104, "Indonesia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ID", null, "SYSTEM" },
                    { 2, 105, "Iran, Islamic Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IR", null, "SYSTEM" },
                    { 2, 106, "Iraq", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IQ", null, "SYSTEM" },
                    { 2, 107, "Ireland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IE", null, "SYSTEM" },
                    { 2, 108, "Isle of Man", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IM", null, "SYSTEM" },
                    { 2, 101, "Hungary", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HU", null, "SYSTEM" },
                    { 2, 109, "Israel", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IL", null, "SYSTEM" },
                    { 2, 111, "Jamaica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JM", null, "SYSTEM" },
                    { 2, 112, "Japan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JP", null, "SYSTEM" },
                    { 2, 113, "Jersey", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JE", null, "SYSTEM" },
                    { 2, 114, "Jordan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JO", null, "SYSTEM" },
                    { 2, 115, "Kazakhstan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KZ", null, "SYSTEM" },
                    { 2, 116, "Kenya", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KE", null, "SYSTEM" },
                    { 2, 117, "Kiribati", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KI", null, "SYSTEM" },
                    { 2, 110, "Italy", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", null, "SYSTEM" },
                    { 2, 42, "Cayman Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KY", null, "SYSTEM" },
                    { 2, 100, "Hong Kong", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HK", null, "SYSTEM" },
                    { 2, 98, "Holy See (Vatican City State)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VA", null, "SYSTEM" },
                    { 2, 82, "Georgia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GE", null, "SYSTEM" },
                    { 2, 83, "Germany", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE", null, "SYSTEM" },
                    { 2, 84, "Ghana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GH", null, "SYSTEM" },
                    { 2, 85, "Gibraltar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GI", null, "SYSTEM" },
                    { 2, 86, "Greece", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR", null, "SYSTEM" },
                    { 2, 87, "Greenland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GL", null, "SYSTEM" },
                    { 2, 88, "Grenada", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GD", null, "SYSTEM" },
                    { 2, 99, "Honduras", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HN", null, "SYSTEM" },
                    { 2, 89, "Guadeloupe", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GP", null, "SYSTEM" },
                    { 2, 91, "Guatemala", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GT", null, "SYSTEM" },
                    { 2, 92, "Guernsey", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GG", null, "SYSTEM" },
                    { 2, 93, "Guinea", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GN", null, "SYSTEM" },
                    { 2, 94, "Guinea-Bissau", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GW", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 95, "Guyana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GY", null, "SYSTEM" },
                    { 2, 96, "Haiti", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HT", null, "SYSTEM" },
                    { 2, 97, "Heard Island and McDonald Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HM", null, "SYSTEM" },
                    { 2, 90, "Guam", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GU", null, "SYSTEM" },
                    { 1, 157, "SER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbian", null, "SYSTEM" },
                    { 2, 41, "Cape Verde", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CV", null, "SYSTEM" },
                    { 2, 39, "Cameroon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CM", null, "SYSTEM" },
                    { 1, 179, "TOG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Togolese", null, "SYSTEM" },
                    { 1, 180, "TON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tongan", null, "SYSTEM" },
                    { 1, 181, "TRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trinidadian or Tobagonian", null, "SYSTEM" },
                    { 1, 182, "TUN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisian", null, "SYSTEM" },
                    { 1, 183, "TUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish", null, "SYSTEM" },
                    { 1, 184, "TUV", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuvaluan", null, "SYSTEM" },
                    { 1, 185, "UGA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ugandan", null, "SYSTEM" },
                    { 1, 186, "UKR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukrainian", null, "SYSTEM" },
                    { 1, 187, "URUG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uruguayan", null, "SYSTEM" },
                    { 1, 188, "UZB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbekistani", null, "SYSTEM" },
                    { 1, 189, "VEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venezuelan", null, "SYSTEM" },
                    { 1, 190, "VIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vietnamese", null, "SYSTEM" },
                    { 1, 191, "WEL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welsh", null, "SYSTEM" },
                    { 1, 192, "YEM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yemenite", null, "SYSTEM" },
                    { 1, 193, "ZAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zambian", null, "SYSTEM" },
                    { 1, 178, "THA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai", null, "SYSTEM" },
                    { 1, 177, "TAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanzanian", null, "SYSTEM" },
                    { 1, 176, "TAJ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tajik", null, "SYSTEM" },
                    { 1, 175, "TAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taiwanese", null, "SYSTEM" },
                    { 1, 159, "SIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sierra Leonean", null, "SYSTEM" },
                    { 1, 160, "SIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singaporean", null, "SYSTEM" },
                    { 1, 161, "SLO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovakian", null, "SYSTEM" },
                    { 1, 162, "SLOV", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenian", null, "SYSTEM" },
                    { 1, 163, "SOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solomon Islander", null, "SYSTEM" },
                    { 1, 164, "SOM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somali", null, "SYSTEM" },
                    { 1, 165, "SOU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "South African", null, "SYSTEM" },
                    { 1, 194, "ZIM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zimbabwean", null, "SYSTEM" },
                    { 1, 166, "SOUT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korean", null, "SYSTEM" },
                    { 1, 168, "SRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sri Lankan", null, "SYSTEM" },
                    { 1, 169, "SUD", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sudanese", null, "SYSTEM" },
                    { 1, 170, "SUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surinamer", null, "SYSTEM" },
                    { 1, 171, "SWA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swazi", null, "SYSTEM" },
                    { 1, 172, "SWE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swedish", null, "SYSTEM" },
                    { 1, 173, "SWI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swiss", null, "SYSTEM" },
                    { 1, 174, "SYR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syrian", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 167, "SPA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish", null, "SYSTEM" },
                    { 2, 0, "Unknown", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNK", null, "SYSTEM" },
                    { 2, 1, "Afghanistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AF", null, "SYSTEM" },
                    { 2, 2, "Åland Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AX", null, "SYSTEM" },
                    { 2, 23, "Belize", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BZ", null, "SYSTEM" },
                    { 2, 24, "Benin", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJ", null, "SYSTEM" },
                    { 2, 25, "Bermuda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BM", null, "SYSTEM" },
                    { 2, 26, "Bhutan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BT", null, "SYSTEM" },
                    { 2, 27, "Bolivia, Plurinational State of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BO", null, "SYSTEM" },
                    { 2, 28, "Bonaire, Sint Eustatius and Saba", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BQ", null, "SYSTEM" },
                    { 2, 29, "Bosnia and Herzegovina", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BA", null, "SYSTEM" },
                    { 2, 22, "Belgium", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE", null, "SYSTEM" },
                    { 2, 30, "Botswana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BW", null, "SYSTEM" },
                    { 2, 32, "Brazil", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BR", null, "SYSTEM" },
                    { 2, 33, "British Indian Ocean Territory", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IO", null, "SYSTEM" },
                    { 2, 34, "Brunei Darussalam", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BN", null, "SYSTEM" },
                    { 2, 35, "Bulgaria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BG", null, "SYSTEM" },
                    { 2, 36, "Burkina Faso", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BF", null, "SYSTEM" },
                    { 2, 37, "Burundi", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BI", null, "SYSTEM" },
                    { 2, 38, "Cambodia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KH", null, "SYSTEM" },
                    { 2, 31, "Bouvet Island", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BV", null, "SYSTEM" },
                    { 2, 40, "Canada", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CA", null, "SYSTEM" },
                    { 2, 21, "Belarus", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BY", null, "SYSTEM" },
                    { 2, 19, "Bangladesh", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BD", null, "SYSTEM" },
                    { 2, 3, "Albania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AL", null, "SYSTEM" },
                    { 2, 4, "Algeria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DZ", null, "SYSTEM" },
                    { 2, 5, "American Samoa", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS", null, "SYSTEM" },
                    { 2, 6, "Andorra", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD", null, "SYSTEM" },
                    { 2, 7, "Angola", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AO", null, "SYSTEM" },
                    { 2, 8, "Anguilla", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI", null, "SYSTEM" },
                    { 2, 9, "Antarctica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQ", null, "SYSTEM" },
                    { 2, 20, "Barbados", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB", null, "SYSTEM" },
                    { 2, 10, "Antigua and Barbuda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AG", null, "SYSTEM" },
                    { 2, 12, "Armenia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AM", null, "SYSTEM" },
                    { 2, 13, "Aruba", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AW", null, "SYSTEM" },
                    { 2, 14, "Australia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AU", null, "SYSTEM" },
                    { 2, 15, "Austria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT", null, "SYSTEM" },
                    { 2, 16, "Azerbaijan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZ", null, "SYSTEM" },
                    { 2, 17, "Bahrain", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BH", null, "SYSTEM" },
                    { 2, 18, "Bahamas", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BS", null, "SYSTEM" },
                    { 2, 11, "Argentina", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AR", null, "SYSTEM" },
                    { 3, 184, "ZU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zulu", null, "SYSTEM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeoplesPhoneInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesPhoneInformations",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeoplesInternetInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeoplesInternetInformations",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId",
                table: "Peoples",
                columns: new[] { "ConfigGenericGenderGroupId", "ConfigGenericGenderId" });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericNationalityGroupId_ConfigGenericNationalityId",
                table: "Peoples",
                columns: new[] { "ConfigGenericNationalityGroupId", "ConfigGenericNationalityId" });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId",
                table: "Peoples",
                columns: new[] { "ConfigGenericProfessionGroupId", "ConfigGenericProfessionId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAttributions_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeopleAttributions",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeopleAddresses",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildings_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "ColonyBuildings",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ColonyBuildingRooms_ConfigGenericGroupTypeId_ConfigGenericTypeId",
                table: "ColonyBuildingRooms",
                columns: new[] { "ConfigGenericGroupTypeId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "Colonies",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigGenericItemExtentions_SystemDataTypeId",
                table: "ConfigGenericItemExtentions",
                column: "SystemDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigGenericItemExtentionValues_ExtentionId_GroupId_ItemId",
                table: "ConfigGenericItemExtentionValues",
                columns: new[] { "ExtentionId", "GroupId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Colony_ConfigGenericItem",
                table: "Colonies",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ColonyBuildingRoom_ConfigGenericItem",
                table: "ColonyBuildingRooms",
                columns: new[] { "ConfigGenericGroupTypeId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColonyBuilding_ConfigGenericItem",
                table: "ColonyBuildings",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAddress_Type",
                table: "PeopleAddresses",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAttribution_ConfigGenericType",
                table: "PeopleAttributions",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Genders",
                table: "Peoples",
                columns: new[] { "ConfigGenericGenderGroupId", "ConfigGenericGenderId" },
                principalTable: "ConfigGenericItems",
                principalColumns: new[] { "GroupId", "Id" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ConfigGenericItem_Nationalities",
                table: "Peoples",
                columns: new[] { "ConfigGenericNationalityGroupId", "ConfigGenericNationalityId" },
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
    }
}
