using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_People_address_country_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlphaCode2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    AlphaCode3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    NumericCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeopleAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleId = table.Column<long>(type: "bigint", nullable: false),
                    ConfigGenericTypeGroupId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericTypeId = table.Column<int>(type: "int", nullable: false),
                    ConfigGenericPlanetGroupId = table.Column<int>(type: "int", nullable: true),
                    ConfigGenericPlanetId = table.Column<int>(type: "int", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    City = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Box = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    FK_PeopleAddress_Country = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeopleAddress_Planet",
                        columns: x => new { x.ConfigGenericPlanetGroupId, x.ConfigGenericPlanetId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeopleAddress_Type",
                        columns: x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId },
                        principalTable: "ConfigGenericItems",
                        principalColumns: new[] { "GroupId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleAddresses_Countries_FK_PeopleAddress_Country",
                        column: x => x.FK_PeopleAddress_Country,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleAddresses_Peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AlphaCode2", "AlphaCode3", "Description", "NumericCode" },
                values: new object[,]
                {
                    { 1, "AF", "AFG", "Afghanistan", "4" },
                    { 158, "NZ", "NZL", "New Zealand", "554" },
                    { 159, "NI", "NIC", "Nicaragua", "558" },
                    { 160, "NE", "NER", "Niger (the)", "562" },
                    { 161, "NG", "NGA", "Nigeria", "566" },
                    { 162, "NU", "NIU", "Niue", "570" },
                    { 163, "NF", "NFK", "Norfolk Island", "574" },
                    { 164, "MP", "MNP", "Northern Mariana Islands (the)", "580" },
                    { 165, "NO", "NOR", "Norway", "578" },
                    { 166, "OM", "OMN", "Oman", "512" },
                    { 167, "PK", "PAK", "Pakistan", "586" },
                    { 168, "PW", "PLW", "Palau", "585" },
                    { 169, "PS", "PSE", "Palestine, State of", "275" },
                    { 170, "PA", "PAN", "Panama", "591" },
                    { 171, "PG", "PNG", "Papua New Guinea", "598" },
                    { 172, "PY", "PRY", "Paraguay", "600" },
                    { 173, "PE", "PER", "Peru", "604" },
                    { 174, "PH", "PHL", "Philippines (the)", "608" },
                    { 175, "PN", "PCN", "Pitcairn", "612" },
                    { 176, "PL", "POL", "Poland", "616" },
                    { 177, "PT", "PRT", "Portugal", "620" },
                    { 178, "PR", "PRI", "Puerto Rico", "630" },
                    { 179, "QA", "QAT", "Qatar", "634" },
                    { 180, "MK", "MKD", "Republic of North Macedonia", "807" },
                    { 181, "RO", "ROU", "Romania", "642" },
                    { 182, "RU", "RUS", "Russian Federation (the)", "643" },
                    { 183, "RW", "RWA", "Rwanda", "646" },
                    { 184, "RE", "REU", "Réunion", "638" },
                    { 157, "NC", "NCL", "New Caledonia", "540" },
                    { 185, "BL", "BLM", "Saint Barthélemy", "652" },
                    { 156, "NL", "NLD", "Netherlands (the)", "528" },
                    { 154, "NR", "NRU", "Nauru", "520" },
                    { 127, "LY", "LBY", "Libya", "434" },
                    { 128, "LI", "LIE", "Liechtenstein", "438" },
                    { 129, "LT", "LTU", "Lithuania", "440" },
                    { 130, "LU", "LUX", "Luxembourg", "442" },
                    { 131, "MO", "MAC", "Macao", "446" },
                    { 132, "MG", "MDG", "Madagascar", "450" },
                    { 133, "MW", "MWI", "Malawi", "454" },
                    { 134, "MY", "MYS", "Malaysia", "458" },
                    { 135, "MV", "MDV", "Maldives", "462" },
                    { 136, "ML", "MLI", "Mali", "466" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AlphaCode2", "AlphaCode3", "Description", "NumericCode" },
                values: new object[,]
                {
                    { 137, "MT", "MLT", "Malta", "470" },
                    { 138, "MH", "MHL", "Marshall Islands (the)", "584" },
                    { 139, "MQ", "MTQ", "Martinique", "474" },
                    { 140, "MR", "MRT", "Mauritania", "478" },
                    { 141, "MU", "MUS", "Mauritius", "480" },
                    { 142, "YT", "MYT", "Mayotte", "175" },
                    { 143, "MX", "MEX", "Mexico", "484" },
                    { 144, "FM", "FSM", "Micronesia (Federated States of)", "583" },
                    { 145, "MD", "MDA", "Moldova (the Republic of)", "498" },
                    { 146, "MC", "MCO", "Monaco", "492" },
                    { 147, "MN", "MNG", "Mongolia", "496" },
                    { 148, "ME", "MNE", "Montenegro", "499" },
                    { 149, "MS", "MSR", "Montserrat", "500" },
                    { 150, "MA", "MAR", "Morocco", "504" },
                    { 151, "MZ", "MOZ", "Mozambique", "508" },
                    { 152, "MM", "MMR", "Myanmar", "104" },
                    { 153, "NA", "NAM", "Namibia", "516" },
                    { 155, "NP", "NPL", "Nepal", "524" },
                    { 186, "SH", "SHN", "Saint Helena, Ascension and Tristan da Cunha", "654" },
                    { 187, "KN", "KNA", "Saint Kitts and Nevis", "659" },
                    { 188, "LC", "LCA", "Saint Lucia", "662" },
                    { 221, "TL", "TLS", "Timor-Leste", "626" },
                    { 222, "TG", "TGO", "Togo", "768" },
                    { 223, "TK", "TKL", "Tokelau", "772" },
                    { 224, "TO", "TON", "Tonga", "776" },
                    { 225, "TT", "TTO", "Trinidad and Tobago", "780" },
                    { 226, "TN", "TUN", "Tunisia", "788" },
                    { 227, "TR", "TUR", "Turkey", "792" },
                    { 228, "TM", "TKM", "Turkmenistan", "795" },
                    { 229, "TC", "TCA", "Turks and Caicos Islands (the)", "796" },
                    { 230, "TV", "TUV", "Tuvalu", "798" },
                    { 231, "UG", "UGA", "Uganda", "800" },
                    { 232, "UA", "UKR", "Ukraine", "804" },
                    { 233, "AE", "ARE", "United Arab Emirates (the)", "784" },
                    { 234, "GB", "GBR", "United Kingdom of Great Britain and Northern Ireland (the)", "826" },
                    { 235, "UM", "UMI", "United States Minor Outlying Islands (the)", "581" },
                    { 236, "US", "USA", "United States of America (the)", "840" },
                    { 237, "UY", "URY", "Uruguay", "858" },
                    { 238, "UZ", "UZB", "Uzbekistan", "860" },
                    { 239, "VU", "VUT", "Vanuatu", "548" },
                    { 240, "VE", "VEN", "Venezuela (Bolivarian Republic of)", "862" },
                    { 241, "VN", "VNM", "Viet Nam", "704" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AlphaCode2", "AlphaCode3", "Description", "NumericCode" },
                values: new object[,]
                {
                    { 242, "VG", "VGB", "Virgin Islands (British)", "92" },
                    { 243, "VI", "VIR", "Virgin Islands (U.S.)", "850" },
                    { 244, "WF", "WLF", "Wallis and Futuna", "876" },
                    { 245, "EH", "ESH", "Western Sahara", "732" },
                    { 246, "YE", "YEM", "Yemen", "887" },
                    { 247, "ZM", "ZMB", "Zambia", "894" },
                    { 220, "TH", "THA", "Thailand", "764" },
                    { 219, "TZ", "TZA", "Tanzania, United Republic of", "834" },
                    { 218, "TJ", "TJK", "Tajikistan", "762" },
                    { 217, "TW", "TWN", "Taiwan (Province of China)", "158" },
                    { 189, "MF", "MAF", "Saint Martin (French part)", "663" },
                    { 190, "PM", "SPM", "Saint Pierre and Miquelon", "666" },
                    { 191, "VC", "VCT", "Saint Vincent and the Grenadines", "670" },
                    { 192, "WS", "WSM", "Samoa", "882" },
                    { 193, "SM", "SMR", "San Marino", "674" },
                    { 194, "ST", "STP", "Sao Tome and Principe", "678" },
                    { 195, "SA", "SAU", "Saudi Arabia", "682" },
                    { 196, "SN", "SEN", "Senegal", "686" },
                    { 197, "RS", "SRB", "Serbia", "688" },
                    { 198, "SC", "SYC", "Seychelles", "690" },
                    { 199, "SL", "SLE", "Sierra Leone", "694" },
                    { 200, "SG", "SGP", "Singapore", "702" },
                    { 201, "SX", "SXM", "Sint Maarten (Dutch part)", "534" },
                    { 126, "LR", "LBR", "Liberia", "430" },
                    { 202, "SK", "SVK", "Slovakia", "703" },
                    { 204, "SB", "SLB", "Solomon Islands", "90" },
                    { 205, "SO", "SOM", "Somalia", "706" },
                    { 206, "ZA", "ZAF", "South Africa", "710" },
                    { 207, "GS", "SGS", "South Georgia and the South Sandwich Islands", "239" },
                    { 208, "SS", "SSD", "South Sudan", "728" },
                    { 209, "ES", "ESP", "Spain", "724" },
                    { 210, "LK", "LKA", "Sri Lanka", "144" },
                    { 211, "SD", "SDN", "Sudan (the)", "729" },
                    { 212, "SR", "SUR", "Suriname", "740" },
                    { 213, "SJ", "SJM", "Svalbard and Jan Mayen", "744" },
                    { 214, "SE", "SWE", "Sweden", "752" },
                    { 215, "CH", "CHE", "Switzerland", "756" },
                    { 216, "SY", "SYR", "Syrian Arab Republic", "760" },
                    { 203, "SI", "SVN", "Slovenia", "705" },
                    { 248, "ZW", "ZWE", "Zimbabwe", "716" },
                    { 125, "LS", "LSO", "Lesotho", "426" },
                    { 123, "LV", "LVA", "Latvia", "428" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AlphaCode2", "AlphaCode3", "Description", "NumericCode" },
                values: new object[,]
                {
                    { 33, "BN", "BRN", "Brunei Darussalam", "96" },
                    { 34, "BG", "BGR", "Bulgaria", "100" },
                    { 35, "BF", "BFA", "Burkina Faso", "854" },
                    { 36, "BI", "BDI", "Burundi", "108" },
                    { 37, "CV", "CPV", "Cabo Verde", "132" },
                    { 38, "KH", "KHM", "Cambodia", "116" },
                    { 39, "CM", "CMR", "Cameroon", "120" },
                    { 40, "CA", "CAN", "Canada", "124" },
                    { 41, "KY", "CYM", "Cayman Islands (the)", "136" },
                    { 42, "CF", "CAF", "Central African Republic (the)", "140" },
                    { 43, "TD", "TCD", "Chad", "148" },
                    { 44, "CL", "CHL", "Chile", "152" },
                    { 45, "CN", "CHN", "China", "156" },
                    { 46, "CX", "CXR", "Christmas Island", "162" },
                    { 47, "CC", "CCK", "Cocos (Keeling) Islands (the)", "166" },
                    { 48, "CO", "COL", "Colombia", "170" },
                    { 49, "KM", "COM", "Comoros (the)", "174" },
                    { 50, "CD", "COD", "Congo (the Democratic Republic of the)", "180" },
                    { 51, "CG", "COG", "Congo (the)", "178" },
                    { 52, "CK", "COK", "Cook Islands (the)", "184" },
                    { 53, "CR", "CRI", "Costa Rica", "188" },
                    { 54, "HR", "HRV", "Croatia", "191" },
                    { 55, "CU", "CUB", "Cuba", "192" },
                    { 56, "CW", "CUW", "Curaçao", "531" },
                    { 57, "CY", "CYP", "Cyprus", "196" },
                    { 58, "CZ", "CZE", "Czechia", "203" },
                    { 59, "CI", "CIV", "Côte d'Ivoire", "384" },
                    { 32, "IO", "IOT", "British Indian Ocean Territory (the)", "86" },
                    { 60, "DK", "DNK", "Denmark", "208" },
                    { 31, "BR", "BRA", "Brazil", "76" },
                    { 29, "BW", "BWA", "Botswana", "72" },
                    { 2, "AL", "ALB", "Albania", "8" },
                    { 3, "DZ", "DZA", "Algeria", "12" },
                    { 4, "AS", "ASM", "American Samoa", "16" },
                    { 5, "AD", "AND", "Andorra", "20" },
                    { 6, "AO", "AGO", "Angola", "24" },
                    { 7, "AI", "AIA", "Anguilla", "660" },
                    { 8, "AQ", "ATA", "Antarctica", "10" },
                    { 9, "AG", "ATG", "Antigua and Barbuda", "28" },
                    { 10, "AR", "ARG", "Argentina", "32" },
                    { 11, "AM", "ARM", "Armenia", "51" },
                    { 12, "AW", "ABW", "Aruba", "533" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AlphaCode2", "AlphaCode3", "Description", "NumericCode" },
                values: new object[,]
                {
                    { 13, "AU", "AUS", "Australia", "36" },
                    { 14, "AT", "AUT", "Austria", "40" },
                    { 15, "AZ", "AZE", "Azerbaijan", "31" },
                    { 16, "BS", "BHS", "Bahamas (the)", "44" },
                    { 17, "BH", "BHR", "Bahrain", "48" },
                    { 18, "BD", "BGD", "Bangladesh", "50" },
                    { 19, "BB", "BRB", "Barbados", "52" },
                    { 20, "BY", "BLR", "Belarus", "112" },
                    { 21, "BE", "BEL", "Belgium", "56" },
                    { 22, "BZ", "BLZ", "Belize", "84" },
                    { 23, "BJ", "BEN", "Benin", "204" },
                    { 24, "BM", "BMU", "Bermuda", "60" },
                    { 25, "BT", "BTN", "Bhutan", "64" },
                    { 26, "BO", "BOL", "Bolivia (Plurinational State of)", "68" },
                    { 27, "BQ", "BES", "Bonaire, Sint Eustatius and Saba", "535" },
                    { 28, "BA", "BIH", "Bosnia and Herzegovina", "70" },
                    { 30, "BV", "BVT", "Bouvet Island", "74" },
                    { 61, "DJ", "DJI", "Djibouti", "262" },
                    { 62, "DM", "DMA", "Dominica", "212" },
                    { 63, "DO", "DOM", "Dominican Republic (the)", "214" },
                    { 96, "HT", "HTI", "Haiti", "332" },
                    { 97, "HM", "HMD", "Heard Island and McDonald Islands", "334" },
                    { 98, "VA", "VAT", "Holy See (the)", "336" },
                    { 99, "HN", "HND", "Honduras", "340" },
                    { 100, "HK", "HKG", "Hong Kong", "344" },
                    { 101, "HU", "HUN", "Hungary", "348" },
                    { 102, "IS", "ISL", "Iceland", "352" },
                    { 103, "IN", "IND", "India", "356" },
                    { 104, "ID", "IDN", "Indonesia", "360" },
                    { 105, "IR", "IRN", "Iran (Islamic Republic of)", "364" },
                    { 106, "IQ", "IRQ", "Iraq", "368" },
                    { 107, "IE", "IRL", "Ireland", "372" },
                    { 108, "IM", "IMN", "Isle of Man", "833" },
                    { 109, "IL", "ISR", "Israel", "376" },
                    { 110, "IT", "ITA", "Italy", "380" },
                    { 111, "JM", "JAM", "Jamaica", "388" },
                    { 112, "JP", "JPN", "Japan", "392" },
                    { 113, "JE", "JEY", "Jersey", "832" },
                    { 114, "JO", "JOR", "Jordan", "400" },
                    { 115, "KZ", "KAZ", "Kazakhstan", "398" },
                    { 116, "KE", "KEN", "Kenya", "404" },
                    { 117, "KI", "KIR", "Kiribati", "296" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AlphaCode2", "AlphaCode3", "Description", "NumericCode" },
                values: new object[,]
                {
                    { 118, "KP", "PRK", "Korea (the Democratic People's Republic of)", "408" },
                    { 119, "KR", "KOR", "Korea (the Republic of)", "410" },
                    { 120, "KW", "KWT", "Kuwait", "414" },
                    { 121, "KG", "KGZ", "Kyrgyzstan", "417" },
                    { 122, "LA", "LAO", "Lao People's Democratic Republic (the)", "418" },
                    { 95, "GY", "GUY", "Guyana", "328" },
                    { 94, "GW", "GNB", "Guinea-Bissau", "624" },
                    { 93, "GN", "GIN", "Guinea", "324" },
                    { 92, "GG", "GGY", "Guernsey", "831" },
                    { 64, "EC", "ECU", "Ecuador", "218" },
                    { 65, "EG", "EGY", "Egypt", "818" },
                    { 66, "SV", "SLV", "El Salvador", "222" },
                    { 67, "GQ", "GNQ", "Equatorial Guinea", "226" },
                    { 68, "ER", "ERI", "Eritrea", "232" },
                    { 69, "EE", "EST", "Estonia", "233" },
                    { 70, "SZ", "SWZ", "Eswatini", "748" },
                    { 71, "ET", "ETH", "Ethiopia", "231" },
                    { 72, "FK", "FLK", "Falkland Islands (the) [Malvinas]", "238" },
                    { 73, "FO", "FRO", "Faroe Islands (the)", "234" },
                    { 74, "FJ", "FJI", "Fiji", "242" },
                    { 75, "FI", "FIN", "Finland", "246" },
                    { 76, "FR", "FRA", "France", "250" },
                    { 124, "LB", "LBN", "Lebanon", "422" },
                    { 77, "GF", "GUF", "French Guiana", "254" },
                    { 79, "TF", "ATF", "French Southern Territories (the)", "260" },
                    { 80, "GA", "GAB", "Gabon", "266" },
                    { 81, "GM", "GMB", "Gambia (the)", "270" },
                    { 82, "GE", "GEO", "Georgia", "268" },
                    { 83, "DE", "DEU", "Germany", "276" },
                    { 84, "GH", "GHA", "Ghana", "288" },
                    { 85, "GI", "GIB", "Gibraltar", "292" },
                    { 86, "GR", "GRC", "Greece", "300" },
                    { 87, "GL", "GRL", "Greenland", "304" },
                    { 88, "GD", "GRD", "Grenada", "308" },
                    { 89, "GP", "GLP", "Guadeloupe", "312" },
                    { 90, "GU", "GUM", "Guam", "316" },
                    { 91, "GT", "GTM", "Guatemala", "320" },
                    { 78, "PF", "PYF", "French Polynesia", "258" },
                    { 249, "AX", "ALA", "Åland Islands", "248" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_ConfigGenericPlanetGroupId_ConfigGenericPlanetId",
                table: "PeopleAddresses",
                columns: new[] { "ConfigGenericPlanetGroupId", "ConfigGenericPlanetId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_ConfigGenericTypeGroupId_ConfigGenericTypeId",
                table: "PeopleAddresses",
                columns: new[] { "ConfigGenericTypeGroupId", "ConfigGenericTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_FK_PeopleAddress_Country",
                table: "PeopleAddresses",
                column: "FK_PeopleAddress_Country");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAddresses_PeopleId",
                table: "PeopleAddresses",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleAddresses");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
