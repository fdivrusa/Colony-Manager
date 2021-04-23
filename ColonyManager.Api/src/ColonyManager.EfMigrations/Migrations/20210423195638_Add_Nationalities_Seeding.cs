using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_Nationalities_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 1, "AFG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afghan", null, "SYSTEM" },
                    { 1, 124, "MOZ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mozambican", null, "SYSTEM" },
                    { 1, 125, "NAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Namibian", null, "SYSTEM" },
                    { 1, 126, "NAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nauruan", null, "SYSTEM" },
                    { 1, 127, "NEP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepalese", null, "SYSTEM" },
                    { 1, 128, "NEW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Zealander", null, "SYSTEM" },
                    { 1, 129, "NI-", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ni-Vanuatu", null, "SYSTEM" },
                    { 1, 130, "NIC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicaraguan", null, "SYSTEM" },
                    { 1, 131, "NIG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigerian", null, "SYSTEM" },
                    { 1, 132, "NIGE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigerien", null, "SYSTEM" },
                    { 1, 123, "MOT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Motswana", null, "SYSTEM" },
                    { 1, 133, "NOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Korean", null, "SYSTEM" },
                    { 1, 135, "NORW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian", null, "SYSTEM" },
                    { 1, 136, "OMA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omani", null, "SYSTEM" },
                    { 1, 137, "PAK", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pakistani", null, "SYSTEM" },
                    { 1, 138, "PAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palauan", null, "SYSTEM" },
                    { 1, 139, "PAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panamanian", null, "SYSTEM" },
                    { 1, 140, "PAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Papua New Guinean", null, "SYSTEM" },
                    { 1, 141, "PAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paraguayan", null, "SYSTEM" },
                    { 1, 142, "PER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peruvian", null, "SYSTEM" },
                    { 1, 143, "POL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", null, "SYSTEM" },
                    { 1, 134, "NORT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Irish", null, "SYSTEM" },
                    { 1, 144, "POR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portuguese", null, "SYSTEM" },
                    { 1, 122, "MOS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mosotho", null, "SYSTEM" },
                    { 1, 120, "MONG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mongolian", null, "SYSTEM" },
                    { 1, 100, "LEB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lebanese", null, "SYSTEM" },
                    { 1, 101, "LIB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liberian", null, "SYSTEM" },
                    { 1, 102, "LIBY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libyan", null, "SYSTEM" },
                    { 1, 103, "LIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liechtensteiner", null, "SYSTEM" },
                    { 1, 104, "LIT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lithuanian", null, "SYSTEM" },
                    { 1, 105, "LUX", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxembourger", null, "SYSTEM" },
                    { 1, 106, "MAC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macedonian", null, "SYSTEM" },
                    { 1, 107, "MAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malagasy", null, "SYSTEM" },
                    { 1, 108, "MALA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malawian", null, "SYSTEM" },
                    { 1, 121, "MOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moroccan", null, "SYSTEM" },
                    { 1, 109, "MALA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malaysian", null, "SYSTEM" },
                    { 1, 111, "MALI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malian", null, "SYSTEM" },
                    { 1, 112, "MALT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maltese", null, "SYSTEM" },
                    { 1, 113, "MAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshallese", null, "SYSTEM" },
                    { 1, 114, "MAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritanian", null, "SYSTEM" },
                    { 1, 115, "MAUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritian", null, "SYSTEM" },
                    { 1, 116, "MEX", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexican", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 117, "MIC", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micronesian", null, "SYSTEM" },
                    { 1, 118, "MOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldovan", null, "SYSTEM" },
                    { 1, 119, "MON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monacan", null, "SYSTEM" },
                    { 1, 110, "MALD", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maldivian", null, "SYSTEM" },
                    { 1, 145, "QAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qatari", null, "SYSTEM" },
                    { 1, 146, "ROM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romanian", null, "SYSTEM" },
                    { 1, 147, "RUS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russian", null, "SYSTEM" },
                    { 1, 173, "SWI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swiss", null, "SYSTEM" },
                    { 1, 174, "SYR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syrian", null, "SYSTEM" },
                    { 1, 175, "TAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taiwanese", null, "SYSTEM" },
                    { 1, 176, "TAJ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tajik", null, "SYSTEM" },
                    { 1, 177, "TAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanzanian", null, "SYSTEM" },
                    { 1, 178, "THA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai", null, "SYSTEM" },
                    { 1, 179, "TOG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Togolese", null, "SYSTEM" },
                    { 1, 180, "TON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tongan", null, "SYSTEM" },
                    { 1, 181, "TRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trinidadian or Tobagonian", null, "SYSTEM" },
                    { 1, 172, "SWE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swedish", null, "SYSTEM" },
                    { 1, 182, "TUN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisian", null, "SYSTEM" },
                    { 1, 184, "TUV", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuvaluan", null, "SYSTEM" },
                    { 1, 185, "UGA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ugandan", null, "SYSTEM" },
                    { 1, 186, "UKR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukrainian", null, "SYSTEM" },
                    { 1, 187, "URUG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uruguayan", null, "SYSTEM" },
                    { 1, 188, "UZB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbekistani", null, "SYSTEM" },
                    { 1, 189, "VEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venezuelan", null, "SYSTEM" },
                    { 1, 190, "VIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vietnamese", null, "SYSTEM" },
                    { 1, 191, "WEL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welsh", null, "SYSTEM" },
                    { 1, 192, "YEM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yemenite", null, "SYSTEM" },
                    { 1, 183, "TUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish", null, "SYSTEM" },
                    { 1, 171, "SWA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swazi", null, "SYSTEM" },
                    { 1, 170, "SUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surinamer", null, "SYSTEM" },
                    { 1, 169, "SUD", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sudanese", null, "SYSTEM" },
                    { 1, 148, "RWA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rwandan", null, "SYSTEM" },
                    { 1, 149, "SAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint Lucian", null, "SYSTEM" },
                    { 1, 150, "SAL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvadoran", null, "SYSTEM" },
                    { 1, 151, "SAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoan", null, "SYSTEM" },
                    { 1, 152, "SAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Marinese", null, "SYSTEM" },
                    { 1, 153, "SAO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sao Tomean", null, "SYSTEM" },
                    { 1, 154, "SAU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saudi", null, "SYSTEM" },
                    { 1, 155, "SCO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scottish", null, "SYSTEM" },
                    { 1, 156, "SEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senegalese", null, "SYSTEM" },
                    { 1, 157, "SER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbian", null, "SYSTEM" },
                    { 1, 158, "SEY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seychellois", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 159, "SIE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sierra Leonean", null, "SYSTEM" },
                    { 1, 160, "SIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singaporean", null, "SYSTEM" },
                    { 1, 161, "SLO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovakian", null, "SYSTEM" },
                    { 1, 162, "SLOV", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenian", null, "SYSTEM" },
                    { 1, 163, "SOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solomon Islander", null, "SYSTEM" },
                    { 1, 164, "SOM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somali", null, "SYSTEM" },
                    { 1, 165, "SOU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "South African", null, "SYSTEM" },
                    { 1, 166, "SOUT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korean", null, "SYSTEM" },
                    { 1, 167, "SPA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish", null, "SYSTEM" },
                    { 1, 168, "SRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sri Lankan", null, "SYSTEM" },
                    { 1, 99, "LAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latvian", null, "SYSTEM" },
                    { 1, 98, "LAO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laotian", null, "SYSTEM" },
                    { 1, 97, "KYR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrgyz", null, "SYSTEM" },
                    { 1, 96, "KUW", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuwaiti", null, "SYSTEM" },
                    { 1, 27, "BRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "British", null, "SYSTEM" },
                    { 1, 28, "BRU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruneian", null, "SYSTEM" },
                    { 1, 29, "BUL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgarian", null, "SYSTEM" },
                    { 1, 30, "BUR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burkinabe", null, "SYSTEM" },
                    { 1, 31, "BURM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burmese", null, "SYSTEM" },
                    { 1, 32, "BURU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burundian", null, "SYSTEM" },
                    { 1, 33, "CAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cambodian", null, "SYSTEM" },
                    { 1, 34, "CAME", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cameroonian", null, "SYSTEM" },
                    { 1, 35, "CAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian", null, "SYSTEM" },
                    { 1, 26, "BRA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazilian", null, "SYSTEM" },
                    { 1, 36, "CAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cape Verdean", null, "SYSTEM" },
                    { 1, 38, "CHA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chadian", null, "SYSTEM" },
                    { 1, 39, "CHI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilean", null, "SYSTEM" },
                    { 1, 40, "CHIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinese", null, "SYSTEM" },
                    { 1, 41, "COL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombian", null, "SYSTEM" },
                    { 1, 42, "COM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comoran", null, "SYSTEM" },
                    { 1, 43, "CON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Congolese", null, "SYSTEM" },
                    { 1, 44, "COS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rican", null, "SYSTEM" },
                    { 1, 45, "CRO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatian", null, "SYSTEM" },
                    { 1, 46, "CUB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuban", null, "SYSTEM" },
                    { 1, 37, "CEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central African", null, "SYSTEM" },
                    { 1, 25, "BOS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosnian", null, "SYSTEM" },
                    { 1, 24, "BOL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolivian", null, "SYSTEM" },
                    { 1, 23, "BHU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bhutanese", null, "SYSTEM" },
                    { 1, 2, "ALB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albanian", null, "SYSTEM" },
                    { 1, 3, "ALG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Algerian", null, "SYSTEM" },
                    { 1, 4, "AME", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "American", null, "SYSTEM" },
                    { 1, 5, "AND", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andorran", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 6, "ANG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angolan", null, "SYSTEM" },
                    { 1, 7, "ANT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antiguans", null, "SYSTEM" },
                    { 1, 8, "ARG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentinean", null, "SYSTEM" },
                    { 1, 9, "ARM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenian", null, "SYSTEM" },
                    { 1, 10, "AUS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian", null, "SYSTEM" },
                    { 1, 11, "AUST", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austrian", null, "SYSTEM" },
                    { 1, 12, "AZE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijani", null, "SYSTEM" },
                    { 1, 13, "BAH", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahamian", null, "SYSTEM" },
                    { 1, 14, "BAHR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahraini", null, "SYSTEM" },
                    { 1, 15, "BAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bangladeshi", null, "SYSTEM" },
                    { 1, 16, "BAR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbadian", null, "SYSTEM" },
                    { 1, 17, "BARB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbudans", null, "SYSTEM" },
                    { 1, 18, "BAT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batswana", null, "SYSTEM" },
                    { 1, 19, "BEL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belarusian", null, "SYSTEM" },
                    { 1, 20, "BELG", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgian", null, "SYSTEM" },
                    { 1, 21, "BELI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belizean", null, "SYSTEM" },
                    { 1, 22, "BEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beninese", null, "SYSTEM" },
                    { 1, 47, "CYP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cypriot", null, "SYSTEM" },
                    { 1, 193, "ZAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zambian", null, "SYSTEM" },
                    { 1, 48, "CZE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech", null, "SYSTEM" },
                    { 1, 50, "DJI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Djibouti", null, "SYSTEM" },
                    { 1, 76, "HAI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haitian", null, "SYSTEM" },
                    { 1, 77, "HER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herzegovinian", null, "SYSTEM" },
                    { 1, 78, "HON", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduran", null, "SYSTEM" },
                    { 1, 79, "HUN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungarian", null, "SYSTEM" },
                    { 1, 80, "I-K", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "I-Kiribati", null, "SYSTEM" },
                    { 1, 81, "ICE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Icelander", null, "SYSTEM" },
                    { 1, 82, "IND", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian", null, "SYSTEM" },
                    { 1, 83, "INDO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indonesian", null, "SYSTEM" },
                    { 1, 84, "IRA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iranian", null, "SYSTEM" },
                    { 1, 75, "GUY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guyanese", null, "SYSTEM" },
                    { 1, 85, "IRAQ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iraqi", null, "SYSTEM" },
                    { 1, 87, "ISR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israeli", null, "SYSTEM" },
                    { 1, 88, "ITA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian", null, "SYSTEM" },
                    { 1, 89, "IVO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivorian", null, "SYSTEM" },
                    { 1, 90, "JAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaican", null, "SYSTEM" },
                    { 1, 91, "JAP", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese", null, "SYSTEM" },
                    { 1, 92, "JOR", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordanian", null, "SYSTEM" },
                    { 1, 93, "KAZ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakhstani", null, "SYSTEM" },
                    { 1, 94, "KEN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenyan", null, "SYSTEM" },
                    { 1, 95, "KIT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kittian and Nevisian", null, "SYSTEM" },
                    { 1, 86, "IRI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irish", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 1, 74, "GUIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinean", null, "SYSTEM" },
                    { 1, 73, "GUI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinea-Bissauan", null, "SYSTEM" },
                    { 1, 72, "GUA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guatemalan", null, "SYSTEM" },
                    { 1, 51, "DOM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominican", null, "SYSTEM" },
                    { 1, 52, "DUT", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dutch", null, "SYSTEM" },
                    { 1, 53, "EAS", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Timorese", null, "SYSTEM" },
                    { 1, 54, "ECU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ecuadorean", null, "SYSTEM" },
                    { 1, 55, "EGY", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egyptian", null, "SYSTEM" },
                    { 1, 56, "EMI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emirian", null, "SYSTEM" },
                    { 1, 57, "EQU", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equatorial Guinean", null, "SYSTEM" },
                    { 1, 58, "ERI", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eritrean", null, "SYSTEM" },
                    { 1, 59, "EST", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estonian", null, "SYSTEM" },
                    { 1, 60, "ETH", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethiopian", null, "SYSTEM" },
                    { 1, 61, "FIJ", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fijian", null, "SYSTEM" },
                    { 1, 62, "FIL", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filipino", null, "SYSTEM" },
                    { 1, 63, "FIN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finnish", null, "SYSTEM" },
                    { 1, 64, "FRE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "French", null, "SYSTEM" },
                    { 1, 65, "GAB", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabonese", null, "SYSTEM" },
                    { 1, 66, "GAM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambian", null, "SYSTEM" },
                    { 1, 67, "GEO", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian", null, "SYSTEM" },
                    { 1, 68, "GER", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "German", null, "SYSTEM" },
                    { 1, 69, "GHA", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghanaian", null, "SYSTEM" },
                    { 1, 70, "GRE", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greek", null, "SYSTEM" },
                    { 1, 71, "GREN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grenadian", null, "SYSTEM" },
                    { 1, 49, "DAN", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", null, "SYSTEM" },
                    { 1, 194, "ZIM", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zimbabwean", null, "SYSTEM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 36 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 43 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 52 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 57 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 59 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 63 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 64 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 65 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 68 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 72 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 75 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 76 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 77 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 78 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 79 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 80 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 81 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 82 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 83 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 84 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 86 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 87 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 88 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 89 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 91 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 92 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 93 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 94 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 95 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 97 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 98 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 99 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 100 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 102 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 103 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 104 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 105 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 106 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 107 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 108 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 109 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 110 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 111 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 112 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 113 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 114 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 115 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 116 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 117 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 118 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 119 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 120 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 121 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 122 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 123 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 124 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 125 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 126 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 127 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 128 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 129 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 130 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 131 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 132 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 133 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 134 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 135 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 136 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 137 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 138 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 139 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 140 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 141 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 142 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 143 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 144 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 145 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 146 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 147 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 148 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 149 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 150 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 151 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 152 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 153 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 154 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 155 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 156 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 157 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 158 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 159 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 160 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 161 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 162 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 163 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 164 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 165 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 166 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 167 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 168 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 169 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 170 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 171 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 172 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 173 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 174 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 175 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 176 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 177 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 178 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 179 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 180 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 181 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 182 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 183 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 184 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 185 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 186 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 187 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 188 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 189 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 190 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 191 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 192 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 193 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 1, 194 });
        }
    }
}
