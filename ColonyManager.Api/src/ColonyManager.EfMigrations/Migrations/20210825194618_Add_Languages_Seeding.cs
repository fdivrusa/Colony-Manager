using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_Languages_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ConfigGenericGroups",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName", "RelatedSubject" },
                values: new object[] { 3, "LANGUAGES", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group that contains all the known Languages", null, "SYSTEM", "PEOPLES" });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 0, "UNK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unknown", null, "SYSTEM" },
                    { 3, 117, "NN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian Nynorsk; Nynorsk,Norwegian", null, "SYSTEM" },
                    { 3, 118, "NO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian", null, "SYSTEM" },
                    { 3, 119, "NR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ndebele,South; South Ndebele", null, "SYSTEM" },
                    { 3, 120, "NV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navajo; Navaho", null, "SYSTEM" },
                    { 3, 121, "NY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chichewa; Chewa; Nyanja", null, "SYSTEM" },
                    { 3, 122, "OC", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occitan (post 1500)", null, "SYSTEM" },
                    { 3, 123, "OJ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ojibwa", null, "SYSTEM" },
                    { 3, 124, "OM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oromo", null, "SYSTEM" },
                    { 3, 125, "OR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oriya", null, "SYSTEM" },
                    { 3, 126, "OS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ossetian; Ossetic", null, "SYSTEM" },
                    { 3, 127, "PA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panjabi; Punjabi", null, "SYSTEM" },
                    { 3, 128, "PI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pali", null, "SYSTEM" },
                    { 3, 129, "PL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", null, "SYSTEM" },
                    { 3, 130, "PS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pushto; Pashto", null, "SYSTEM" },
                    { 3, 131, "PT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portuguese", null, "SYSTEM" },
                    { 3, 132, "QU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quechua", null, "SYSTEM" },
                    { 3, 133, "RM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romansh", null, "SYSTEM" },
                    { 3, 134, "RN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rundi", null, "SYSTEM" },
                    { 3, 135, "RO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romanian; Moldavian; Moldovan", null, "SYSTEM" },
                    { 3, 116, "NL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dutch; Flemish", null, "SYSTEM" },
                    { 3, 136, "RU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russian", null, "SYSTEM" },
                    { 3, 115, "NG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ndonga", null, "SYSTEM" },
                    { 3, 113, "ND", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Ndebele", null, "SYSTEM" },
                    { 3, 94, "LG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ganda", null, "SYSTEM" },
                    { 3, 95, "LI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limburgan; Limburger; Limburgish", null, "SYSTEM" },
                    { 3, 96, "LN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lingala", null, "SYSTEM" },
                    { 3, 97, "LO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lao", null, "SYSTEM" },
                    { 3, 98, "LT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lithuanian", null, "SYSTEM" },
                    { 3, 99, "LU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luba-Katanga", null, "SYSTEM" },
                    { 3, 100, "LV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latvian", null, "SYSTEM" },
                    { 3, 101, "MG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malagasy", null, "SYSTEM" },
                    { 3, 102, "MH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshallese", null, "SYSTEM" },
                    { 3, 103, "MI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maori", null, "SYSTEM" },
                    { 3, 104, "MK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macedonian", null, "SYSTEM" },
                    { 3, 105, "ML", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malayalam", null, "SYSTEM" },
                    { 3, 106, "MN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mongolian", null, "SYSTEM" },
                    { 3, 107, "MR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marathi", null, "SYSTEM" },
                    { 3, 108, "MS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malay", null, "SYSTEM" },
                    { 3, 109, "MT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maltese", null, "SYSTEM" },
                    { 3, 110, "MY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burmese", null, "SYSTEM" },
                    { 3, 111, "NA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nauru", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 112, "NB", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian Bokm�l", null, "SYSTEM" },
                    { 3, 114, "NE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepali", null, "SYSTEM" },
                    { 3, 137, "RW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kinyarwanda", null, "SYSTEM" },
                    { 3, 138, "SA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanskrit", null, "SYSTEM" },
                    { 3, 139, "SC", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sardinian", null, "SYSTEM" },
                    { 3, 164, "TO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tonga (Tonga Islands)", null, "SYSTEM" },
                    { 3, 165, "TR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish", null, "SYSTEM" },
                    { 3, 166, "TS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tsonga", null, "SYSTEM" },
                    { 3, 167, "TT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tatar", null, "SYSTEM" },
                    { 3, 168, "TW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twi", null, "SYSTEM" },
                    { 3, 169, "TY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tahitian", null, "SYSTEM" },
                    { 3, 170, "UG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uighur; Uyghur", null, "SYSTEM" },
                    { 3, 171, "UK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukrainian", null, "SYSTEM" },
                    { 3, 172, "UR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urdu", null, "SYSTEM" },
                    { 3, 173, "UZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbek", null, "SYSTEM" },
                    { 3, 174, "VE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venda", null, "SYSTEM" },
                    { 3, 175, "VI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vietnamese", null, "SYSTEM" },
                    { 3, 176, "VO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volap�k", null, "SYSTEM" },
                    { 3, 177, "WA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walloon", null, "SYSTEM" },
                    { 3, 178, "WO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wolof", null, "SYSTEM" },
                    { 3, 179, "XH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xhosa", null, "SYSTEM" },
                    { 3, 180, "YI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yiddish", null, "SYSTEM" },
                    { 3, 181, "YO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoruba", null, "SYSTEM" },
                    { 3, 182, "ZA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zhuang; Chuang", null, "SYSTEM" },
                    { 3, 163, "TN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tswana", null, "SYSTEM" },
                    { 3, 162, "TL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tagalog", null, "SYSTEM" },
                    { 3, 161, "TK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkmen", null, "SYSTEM" },
                    { 3, 160, "TI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tigrinya", null, "SYSTEM" },
                    { 3, 140, "SD", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sindhi", null, "SYSTEM" },
                    { 3, 141, "SE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Sami", null, "SYSTEM" },
                    { 3, 142, "SG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sango", null, "SYSTEM" },
                    { 3, 143, "SI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinhala; Sinhalese", null, "SYSTEM" },
                    { 3, 144, "SK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovak", null, "SYSTEM" },
                    { 3, 145, "SL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenian", null, "SYSTEM" },
                    { 3, 146, "SM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoan", null, "SYSTEM" },
                    { 3, 147, "SN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shona", null, "SYSTEM" },
                    { 3, 148, "SO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somali", null, "SYSTEM" },
                    { 3, 93, "LB", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxembourgish; Letzeburgesch", null, "SYSTEM" },
                    { 3, 149, "SQ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albanian", null, "SYSTEM" },
                    { 3, 151, "SS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swati", null, "SYSTEM" },
                    { 3, 152, "ST", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sotho, Southern", null, "SYSTEM" },
                    { 3, 153, "SU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundanese", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 154, "SV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swedish", null, "SYSTEM" },
                    { 3, 155, "SW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swahili", null, "SYSTEM" },
                    { 3, 156, "TA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamil", null, "SYSTEM" },
                    { 3, 157, "TE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telugu", null, "SYSTEM" },
                    { 3, 158, "TG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tajik", null, "SYSTEM" },
                    { 3, 159, "TH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai", null, "SYSTEM" },
                    { 3, 150, "SR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbian", null, "SYSTEM" },
                    { 3, 183, "ZH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinese", null, "SYSTEM" },
                    { 3, 92, "LA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latin", null, "SYSTEM" },
                    { 3, 90, "KW", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cornish", null, "SYSTEM" },
                    { 3, 24, "CE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chechen", null, "SYSTEM" },
                    { 3, 25, "CH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chamorro", null, "SYSTEM" },
                    { 3, 26, "CO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corsican", null, "SYSTEM" },
                    { 3, 27, "CR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cree", null, "SYSTEM" },
                    { 3, 28, "CS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech", null, "SYSTEM" },
                    { 3, 29, "CU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic", null, "SYSTEM" },
                    { 3, 30, "CV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chuvash", null, "SYSTEM" },
                    { 3, 31, "CY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welsh", null, "SYSTEM" },
                    { 3, 32, "DA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", null, "SYSTEM" },
                    { 3, 33, "DE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "German", null, "SYSTEM" },
                    { 3, 34, "DV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Divehi; Dhivehi; Maldivian", null, "SYSTEM" },
                    { 3, 35, "DZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dzongkha", null, "SYSTEM" },
                    { 3, 36, "EE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ewe", null, "SYSTEM" },
                    { 3, 37, "EL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greek, Modern (1453-)", null, "SYSTEM" },
                    { 3, 38, "EN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", null, "SYSTEM" },
                    { 3, 39, "EO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esperanto", null, "SYSTEM" },
                    { 3, 40, "ES", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish; Castilian", null, "SYSTEM" },
                    { 3, 41, "ET", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estonian", null, "SYSTEM" },
                    { 3, 42, "EU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basque", null, "SYSTEM" },
                    { 3, 23, "CA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catalan; Valencian", null, "SYSTEM" },
                    { 3, 43, "FA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persian", null, "SYSTEM" },
                    { 3, 22, "BS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosnian", null, "SYSTEM" },
                    { 3, 20, "BO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tibetan", null, "SYSTEM" },
                    { 3, 1, "AA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afar", null, "SYSTEM" },
                    { 3, 2, "AB", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abkhazian", null, "SYSTEM" },
                    { 3, 3, "AE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avestan", null, "SYSTEM" },
                    { 3, 4, "AF", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afrikaans", null, "SYSTEM" },
                    { 3, 5, "AK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akan", null, "SYSTEM" },
                    { 3, 6, "AM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amharic", null, "SYSTEM" },
                    { 3, 7, "AN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aragonese", null, "SYSTEM" },
                    { 3, 8, "AR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arabic", null, "SYSTEM" },
                    { 3, 9, "AS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assamese", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 10, "AV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avaric", null, "SYSTEM" },
                    { 3, 11, "AY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aymara", null, "SYSTEM" },
                    { 3, 12, "AZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijani", null, "SYSTEM" },
                    { 3, 13, "BA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bashkir", null, "SYSTEM" },
                    { 3, 14, "BE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belarusian", null, "SYSTEM" },
                    { 3, 15, "BG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgarian", null, "SYSTEM" },
                    { 3, 16, "BH", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bihari languages", null, "SYSTEM" },
                    { 3, 17, "BM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bambara", null, "SYSTEM" },
                    { 3, 18, "BI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bislama", null, "SYSTEM" },
                    { 3, 19, "BN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bengali", null, "SYSTEM" },
                    { 3, 21, "BR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breton", null, "SYSTEM" },
                    { 3, 44, "FF", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fulah", null, "SYSTEM" },
                    { 3, 45, "FI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finnish", null, "SYSTEM" },
                    { 3, 46, "FJ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fijian", null, "SYSTEM" },
                    { 3, 71, "IO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ido", null, "SYSTEM" },
                    { 3, 72, "IS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Icelandic", null, "SYSTEM" },
                    { 3, 73, "IT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian", null, "SYSTEM" },
                    { 3, 74, "IU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inuktitut", null, "SYSTEM" },
                    { 3, 75, "JA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese", null, "SYSTEM" },
                    { 3, 76, "JV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javanese", null, "SYSTEM" },
                    { 3, 77, "KA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian", null, "SYSTEM" },
                    { 3, 78, "KG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kongo", null, "SYSTEM" },
                    { 3, 79, "KI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kikuyu; Gikuyu", null, "SYSTEM" },
                    { 3, 80, "KJ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuanyama; Kwanyama", null, "SYSTEM" },
                    { 3, 81, "KK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakh", null, "SYSTEM" },
                    { 3, 82, "KL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalaallisut; Greenlandic", null, "SYSTEM" },
                    { 3, 83, "KM", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Khmer", null, "SYSTEM" },
                    { 3, 84, "KN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kannada", null, "SYSTEM" },
                    { 3, 85, "KO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Korean", null, "SYSTEM" },
                    { 3, 86, "KR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kanuri", null, "SYSTEM" },
                    { 3, 87, "KS", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kashmiri", null, "SYSTEM" },
                    { 3, 88, "KU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurdish", null, "SYSTEM" },
                    { 3, 89, "KV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komi", null, "SYSTEM" },
                    { 3, 70, "IK", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inupiaq", null, "SYSTEM" },
                    { 3, 69, "II", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sichuan Yi; Nuosu", null, "SYSTEM" },
                    { 3, 68, "IG", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igbo", null, "SYSTEM" },
                    { 3, 67, "IE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interlingue; Occidental", null, "SYSTEM" },
                    { 3, 47, "FO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faroese", null, "SYSTEM" },
                    { 3, 48, "FR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "French", null, "SYSTEM" },
                    { 3, 49, "FY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Frisian", null, "SYSTEM" },
                    { 3, 50, "GA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irish", null, "SYSTEM" },
                    { 3, 51, "GD", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaelic; Scottish Gaelic", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 3, 52, "GL", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galician", null, "SYSTEM" },
                    { 3, 53, "GN", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guarani", null, "SYSTEM" },
                    { 3, 54, "GU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gujarati", null, "SYSTEM" },
                    { 3, 55, "GV", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manx", null, "SYSTEM" },
                    { 3, 91, "KY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kirghiz; Kyrgyz", null, "SYSTEM" },
                    { 3, 56, "HA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hausa", null, "SYSTEM" },
                    { 3, 58, "HI", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hindi", null, "SYSTEM" },
                    { 3, 59, "HO", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hiri Motu", null, "SYSTEM" },
                    { 3, 60, "HR", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatian", null, "SYSTEM" },
                    { 3, 61, "HT", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haitian; Haitian Creole", null, "SYSTEM" },
                    { 3, 62, "HU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungarian", null, "SYSTEM" },
                    { 3, 63, "HY", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenian", null, "SYSTEM" },
                    { 3, 64, "HZ", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herero", null, "SYSTEM" },
                    { 3, 65, "IA", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interlingua (International Auxiliary Language Association)", null, "SYSTEM" },
                    { 3, 66, "ID", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indonesian", null, "SYSTEM" },
                    { 3, 57, "HE", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hebrew", null, "SYSTEM" },
                    { 3, 184, "ZU", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zulu", null, "SYSTEM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 0 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 31 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 32 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 35 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 36 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 37 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 40 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 42 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 44 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 45 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 46 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 47 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 48 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 49 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 50 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 51 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 52 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 53 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 54 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 55 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 56 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 57 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 58 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 59 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 60 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 61 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 62 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 63 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 64 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 65 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 66 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 67 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 68 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 69 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 70 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 71 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 72 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 73 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 74 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 75 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 76 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 77 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 78 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 79 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 80 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 81 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 82 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 83 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 84 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 85 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 86 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 87 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 88 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 89 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 90 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 91 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 92 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 93 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 94 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 95 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 96 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 97 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 98 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 99 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 100 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 101 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 102 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 103 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 104 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 105 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 106 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 107 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 108 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 109 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 110 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 111 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 112 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 113 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 114 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 115 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 116 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 117 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 118 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 119 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 120 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 121 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 122 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 123 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 124 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 125 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 126 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 127 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 128 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 129 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 130 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 131 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 132 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 133 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 134 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 135 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 136 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 137 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 138 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 139 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 140 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 141 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 142 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 143 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 144 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 145 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 146 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 147 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 148 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 149 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 150 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 151 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 152 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 153 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 154 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 155 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 156 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 157 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 158 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 159 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 160 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 161 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 162 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 163 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 164 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 165 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 166 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 167 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 168 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 169 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 170 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 171 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 172 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 173 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 174 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 175 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 176 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 177 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 178 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 179 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 180 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 181 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 182 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 183 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 3, 184 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericGroups",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
