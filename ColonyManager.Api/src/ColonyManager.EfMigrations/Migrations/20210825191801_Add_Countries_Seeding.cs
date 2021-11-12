using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ColonyManager.EfMigrations.Migrations
{
    public partial class Add_Countries_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ConfigGenericGroups",
                columns: new[] { "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName", "RelatedSubject" },
                values: new object[] { 2, "COUNTRIES", "Initial seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group that contains all the known countries", null, "SYSTEM", "PEOPLES" });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 0, "Unknown", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNK", null, "SYSTEM" },
                    { 2, 158, "New Caledonia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NC", null, "SYSTEM" },
                    { 2, 159, "New Zealand", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NZ", null, "SYSTEM" },
                    { 2, 160, "Nicaragua", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NI", null, "SYSTEM" },
                    { 2, 161, "Niger", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NE", null, "SYSTEM" },
                    { 2, 162, "Nigeria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NG", null, "SYSTEM" },
                    { 2, 163, "Niue", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NU", null, "SYSTEM" },
                    { 2, 164, "Norfolk Island", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NF", null, "SYSTEM" },
                    { 2, 165, "Northern Mariana Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MP", null, "SYSTEM" },
                    { 2, 166, "Norway", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NO", null, "SYSTEM" },
                    { 2, 167, "Oman", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OM", null, "SYSTEM" },
                    { 2, 168, "Pakistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PK", null, "SYSTEM" },
                    { 2, 169, "Palau", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PW", null, "SYSTEM" },
                    { 2, 170, "Palestine, State of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PS", null, "SYSTEM" },
                    { 2, 171, "Panama", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PA", null, "SYSTEM" },
                    { 2, 172, "Papua New Guinea", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PG", null, "SYSTEM" },
                    { 2, 173, "Paraguay", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PY", null, "SYSTEM" },
                    { 2, 174, "Peru", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PE", null, "SYSTEM" },
                    { 2, 175, "Philippines", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PH", null, "SYSTEM" },
                    { 2, 176, "Pitcairn", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PN", null, "SYSTEM" },
                    { 2, 177, "Poland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PL", null, "SYSTEM" },
                    { 2, 178, "Portugal", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PT", null, "SYSTEM" },
                    { 2, 179, "Puerto Rico", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PR", null, "SYSTEM" },
                    { 2, 180, "Qatar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "QA", null, "SYSTEM" },
                    { 2, 181, "Réunion", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RE", null, "SYSTEM" },
                    { 2, 182, "Romania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RO", null, "SYSTEM" },
                    { 2, 183, "Russian Federation", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RU", null, "SYSTEM" },
                    { 2, 184, "Rwanda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RW", null, "SYSTEM" },
                    { 2, 157, "Netherlands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NL", null, "SYSTEM" },
                    { 2, 185, "Saint Barthélemy", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BL", null, "SYSTEM" },
                    { 2, 156, "Nepal", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NP", null, "SYSTEM" },
                    { 2, 154, "Namibia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NA", null, "SYSTEM" },
                    { 2, 127, "Libya", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LY", null, "SYSTEM" },
                    { 2, 128, "Liechtenstein", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LI", null, "SYSTEM" },
                    { 2, 129, "Lithuania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LT", null, "SYSTEM" },
                    { 2, 130, "Luxembourg", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LU", null, "SYSTEM" },
                    { 2, 131, "Macao", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MO", null, "SYSTEM" },
                    { 2, 132, "Macedonia, the Former Yugoslav Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MK", null, "SYSTEM" },
                    { 2, 133, "Madagascar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MG", null, "SYSTEM" },
                    { 2, 134, "Malawi", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MW", null, "SYSTEM" },
                    { 2, 135, "Malaysia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MY", null, "SYSTEM" },
                    { 2, 136, "Maldives", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MV", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 137, "Mali", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ML", null, "SYSTEM" },
                    { 2, 138, "Malta", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MT", null, "SYSTEM" },
                    { 2, 139, "Marshall Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MH", null, "SYSTEM" },
                    { 2, 140, "Martinique", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MQ", null, "SYSTEM" },
                    { 2, 141, "Mauritania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MR", null, "SYSTEM" },
                    { 2, 142, "Mauritius", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MU", null, "SYSTEM" },
                    { 2, 143, "Mayotte", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "YT", null, "SYSTEM" },
                    { 2, 144, "Mexico", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MX", null, "SYSTEM" },
                    { 2, 145, "Micronesia, Federated States of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FM", null, "SYSTEM" },
                    { 2, 146, "Moldova, Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD", null, "SYSTEM" },
                    { 2, 147, "Monaco", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MC", null, "SYSTEM" },
                    { 2, 148, "Mongolia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MN", null, "SYSTEM" },
                    { 2, 149, "Montenegro", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ME", null, "SYSTEM" },
                    { 2, 150, "Montserrat", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MS", null, "SYSTEM" },
                    { 2, 151, "Morocco", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MA", null, "SYSTEM" },
                    { 2, 152, "Mozambique", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MZ", null, "SYSTEM" },
                    { 2, 153, "Myanmar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM", null, "SYSTEM" },
                    { 2, 155, "Nauru", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NR", null, "SYSTEM" },
                    { 2, 186, "Saint Helena, Ascension and Tristan da Cunha", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SH", null, "SYSTEM" },
                    { 2, 187, "Saint Kitts and Nevis", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KN", null, "SYSTEM" },
                    { 2, 188, "Saint Lucia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LC", null, "SYSTEM" },
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
                    { 2, 236, "United States", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "US", null, "SYSTEM" },
                    { 2, 237, "United States Minor Outlying Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UM", null, "SYSTEM" },
                    { 2, 238, "Uruguay", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UY", null, "SYSTEM" },
                    { 2, 239, "Uzbekistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "UZ", null, "SYSTEM" },
                    { 2, 240, "Vanuatu", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VU", null, "SYSTEM" },
                    { 2, 241, "Venezuela, Bolivarian Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VE", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 242, "Viet Nam", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VN", null, "SYSTEM" },
                    { 2, 243, "Virgin Islands, British", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VG", null, "SYSTEM" },
                    { 2, 244, "Virgin Islands, U.S.", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VI", null, "SYSTEM" },
                    { 2, 245, "Wallis and Futuna", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "WF", null, "SYSTEM" },
                    { 2, 246, "Western Sahara", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EH", null, "SYSTEM" },
                    { 2, 247, "Yemen", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "YE", null, "SYSTEM" },
                    { 2, 220, "Tanzania, United Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TZ", null, "SYSTEM" },
                    { 2, 219, "Tajikistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TJ", null, "SYSTEM" },
                    { 2, 218, "Taiwan, Province of China", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TW", null, "SYSTEM" },
                    { 2, 217, "Syrian Arab Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SY", null, "SYSTEM" },
                    { 2, 189, "Saint Martin (French part)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MF", null, "SYSTEM" },
                    { 2, 190, "Saint Pierre and Miquelon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM", null, "SYSTEM" },
                    { 2, 191, "Saint Vincent and the Grenadines", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VC", null, "SYSTEM" },
                    { 2, 192, "Samoa", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "WS", null, "SYSTEM" },
                    { 2, 193, "San Marino", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SM", null, "SYSTEM" },
                    { 2, 194, "Sao Tome and Principe", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ST", null, "SYSTEM" },
                    { 2, 195, "Saudi Arabia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SA", null, "SYSTEM" },
                    { 2, 196, "Senegal", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SN", null, "SYSTEM" },
                    { 2, 197, "Serbia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "RS", null, "SYSTEM" },
                    { 2, 198, "Seychelles", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SC", null, "SYSTEM" },
                    { 2, 199, "Sierra Leone", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SL", null, "SYSTEM" },
                    { 2, 200, "Singapore", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SG", null, "SYSTEM" },
                    { 2, 201, "Sint Maarten (Dutch part)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SX", null, "SYSTEM" },
                    { 2, 126, "Liberia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LR", null, "SYSTEM" },
                    { 2, 202, "Slovakia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SK", null, "SYSTEM" },
                    { 2, 204, "Solomon Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SB", null, "SYSTEM" },
                    { 2, 205, "Somalia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SO", null, "SYSTEM" },
                    { 2, 206, "South Africa", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZA", null, "SYSTEM" },
                    { 2, 207, "South Georgia and the South Sandwich Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GS", null, "SYSTEM" },
                    { 2, 208, "South Sudan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SS", null, "SYSTEM" },
                    { 2, 209, "Spain", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ES", null, "SYSTEM" },
                    { 2, 210, "Sri Lanka", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LK", null, "SYSTEM" },
                    { 2, 211, "Sudan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SD", null, "SYSTEM" },
                    { 2, 212, "Suriname", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SR", null, "SYSTEM" },
                    { 2, 213, "Svalbard and Jan Mayen", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SJ", null, "SYSTEM" },
                    { 2, 214, "Swaziland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SZ", null, "SYSTEM" },
                    { 2, 215, "Sweden", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SE", null, "SYSTEM" },
                    { 2, 216, "Switzerland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CH", null, "SYSTEM" },
                    { 2, 203, "Slovenia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SI", null, "SYSTEM" },
                    { 2, 125, "Lesotho", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LS", null, "SYSTEM" },
                    { 2, 124, "Lebanon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LB", null, "SYSTEM" },
                    { 2, 123, "Latvia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LV", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 33, "British Indian Ocean Territory", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IO", null, "SYSTEM" },
                    { 2, 34, "Brunei Darussalam", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BN", null, "SYSTEM" },
                    { 2, 35, "Bulgaria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BG", null, "SYSTEM" },
                    { 2, 36, "Burkina Faso", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BF", null, "SYSTEM" },
                    { 2, 37, "Burundi", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BI", null, "SYSTEM" },
                    { 2, 38, "Cambodia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KH", null, "SYSTEM" },
                    { 2, 39, "Cameroon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CM", null, "SYSTEM" },
                    { 2, 40, "Canada", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CA", null, "SYSTEM" },
                    { 2, 41, "Cape Verde", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CV", null, "SYSTEM" },
                    { 2, 42, "Cayman Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KY", null, "SYSTEM" },
                    { 2, 43, "Central African Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CF", null, "SYSTEM" },
                    { 2, 44, "Chad", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TD", null, "SYSTEM" },
                    { 2, 45, "Chile", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CL", null, "SYSTEM" },
                    { 2, 46, "China", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CN", null, "SYSTEM" },
                    { 2, 47, "Christmas Island", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CX", null, "SYSTEM" },
                    { 2, 48, "Cocos (Keeling) Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC", null, "SYSTEM" },
                    { 2, 49, "Colombia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CO", null, "SYSTEM" },
                    { 2, 50, "Comoros", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KM", null, "SYSTEM" },
                    { 2, 51, "Congo", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CG", null, "SYSTEM" },
                    { 2, 52, "Congo, the Democratic Republic of the", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CD", null, "SYSTEM" },
                    { 2, 53, "Cook Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CK", null, "SYSTEM" },
                    { 2, 54, "Costa Rica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CR", null, "SYSTEM" },
                    { 2, 55, "Côte d'Ivoire", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CI", null, "SYSTEM" },
                    { 2, 56, "Croatia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", null, "SYSTEM" },
                    { 2, 57, "Cuba", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CU", null, "SYSTEM" },
                    { 2, 58, "Curaçao", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CW", null, "SYSTEM" },
                    { 2, 59, "Cyprus", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CY", null, "SYSTEM" },
                    { 2, 32, "Brazil", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BR", null, "SYSTEM" },
                    { 2, 31, "Bouvet Island", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BV", null, "SYSTEM" },
                    { 2, 30, "Botswana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BW", null, "SYSTEM" },
                    { 2, 29, "Bosnia and Herzegovina", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BA", null, "SYSTEM" },
                    { 2, 1, "Afghanistan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AF", null, "SYSTEM" },
                    { 2, 2, "Åland Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AX", null, "SYSTEM" },
                    { 2, 3, "Albania", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AL", null, "SYSTEM" },
                    { 2, 4, "Algeria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DZ", null, "SYSTEM" },
                    { 2, 5, "American Samoa", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS", null, "SYSTEM" },
                    { 2, 6, "Andorra", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD", null, "SYSTEM" },
                    { 2, 7, "Angola", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AO", null, "SYSTEM" },
                    { 2, 8, "Anguilla", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI", null, "SYSTEM" },
                    { 2, 9, "Antarctica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQ", null, "SYSTEM" },
                    { 2, 10, "Antigua and Barbuda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AG", null, "SYSTEM" },
                    { 2, 11, "Argentina", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AR", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 12, "Armenia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AM", null, "SYSTEM" },
                    { 2, 13, "Aruba", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AW", null, "SYSTEM" },
                    { 2, 60, "Czech Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CZ", null, "SYSTEM" },
                    { 2, 14, "Australia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AU", null, "SYSTEM" },
                    { 2, 16, "Azerbaijan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZ", null, "SYSTEM" },
                    { 2, 17, "Bahrain", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BH", null, "SYSTEM" },
                    { 2, 18, "Bahamas", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BS", null, "SYSTEM" },
                    { 2, 19, "Bangladesh", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BD", null, "SYSTEM" },
                    { 2, 20, "Barbados", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB", null, "SYSTEM" },
                    { 2, 21, "Belarus", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BY", null, "SYSTEM" },
                    { 2, 22, "Belgium", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE", null, "SYSTEM" },
                    { 2, 23, "Belize", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BZ", null, "SYSTEM" },
                    { 2, 24, "Benin", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJ", null, "SYSTEM" },
                    { 2, 25, "Bermuda", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BM", null, "SYSTEM" },
                    { 2, 26, "Bhutan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BT", null, "SYSTEM" },
                    { 2, 27, "Bolivia, Plurinational State of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BO", null, "SYSTEM" },
                    { 2, 28, "Bonaire, Sint Eustatius and Saba", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BQ", null, "SYSTEM" },
                    { 2, 15, "Austria", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT", null, "SYSTEM" },
                    { 2, 248, "Zambia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZM", null, "SYSTEM" },
                    { 2, 61, "Denmark", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DK", null, "SYSTEM" },
                    { 2, 63, "Dominica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DM", null, "SYSTEM" },
                    { 2, 96, "Haiti", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HT", null, "SYSTEM" },
                    { 2, 97, "Heard Island and McDonald Islands", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HM", null, "SYSTEM" },
                    { 2, 98, "Holy See (Vatican City State)", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VA", null, "SYSTEM" },
                    { 2, 99, "Honduras", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HN", null, "SYSTEM" },
                    { 2, 100, "Hong Kong", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HK", null, "SYSTEM" },
                    { 2, 101, "Hungary", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HU", null, "SYSTEM" },
                    { 2, 102, "Iceland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IS", null, "SYSTEM" },
                    { 2, 103, "India", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IN", null, "SYSTEM" },
                    { 2, 104, "Indonesia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ID", null, "SYSTEM" },
                    { 2, 105, "Iran, Islamic Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IR", null, "SYSTEM" },
                    { 2, 106, "Iraq", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IQ", null, "SYSTEM" },
                    { 2, 107, "Ireland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IE", null, "SYSTEM" },
                    { 2, 108, "Isle of Man", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IM", null, "SYSTEM" },
                    { 2, 109, "Israel", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IL", null, "SYSTEM" },
                    { 2, 110, "Italy", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", null, "SYSTEM" },
                    { 2, 111, "Jamaica", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JM", null, "SYSTEM" },
                    { 2, 112, "Japan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JP", null, "SYSTEM" },
                    { 2, 113, "Jersey", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JE", null, "SYSTEM" },
                    { 2, 114, "Jordan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JO", null, "SYSTEM" },
                    { 2, 115, "Kazakhstan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KZ", null, "SYSTEM" },
                    { 2, 116, "Kenya", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KE", null, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ConfigGenericItems",
                columns: new[] { "GroupId", "Id", "Code", "Comment", "CreatedDate", "Description", "LastUpdatedDate", "LastUpdatedUserName" },
                values: new object[,]
                {
                    { 2, 117, "Kiribati", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KI", null, "SYSTEM" },
                    { 2, 118, "Korea, Democratic People's Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KP", null, "SYSTEM" },
                    { 2, 119, "Korea, Republic of", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KR", null, "SYSTEM" },
                    { 2, 120, "Kuwait", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KW", null, "SYSTEM" },
                    { 2, 121, "Kyrgyzstan", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KG", null, "SYSTEM" },
                    { 2, 122, "Lao People's Democratic Republic", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LA", null, "SYSTEM" },
                    { 2, 95, "Guyana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GY", null, "SYSTEM" },
                    { 2, 94, "Guinea-Bissau", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GW", null, "SYSTEM" },
                    { 2, 93, "Guinea", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GN", null, "SYSTEM" },
                    { 2, 92, "Guernsey", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GG", null, "SYSTEM" },
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
                    { 2, 62, "Djibouti", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ", null, "SYSTEM" },
                    { 2, 77, "French Guiana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GF", null, "SYSTEM" },
                    { 2, 79, "French Southern Territories", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TF", null, "SYSTEM" },
                    { 2, 80, "Gabon", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GA", null, "SYSTEM" },
                    { 2, 81, "Gambia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GM", null, "SYSTEM" },
                    { 2, 82, "Georgia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GE", null, "SYSTEM" },
                    { 2, 83, "Germany", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE", null, "SYSTEM" },
                    { 2, 84, "Ghana", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GH", null, "SYSTEM" },
                    { 2, 85, "Gibraltar", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GI", null, "SYSTEM" },
                    { 2, 86, "Greece", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR", null, "SYSTEM" },
                    { 2, 87, "Greenland", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GL", null, "SYSTEM" },
                    { 2, 88, "Grenada", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GD", null, "SYSTEM" },
                    { 2, 89, "Guadeloupe", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GP", null, "SYSTEM" },
                    { 2, 90, "Guam", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GU", null, "SYSTEM" },
                    { 2, 91, "Guatemala", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GT", null, "SYSTEM" },
                    { 2, 78, "French Polynesia", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PF", null, "SYSTEM" },
                    { 2, 249, "Zimbabwe", "Initial Seed", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZW", null, "SYSTEM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 0 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 27 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 28 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 30 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 32 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 33 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 36 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 38 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 39 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 42 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 45 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 46 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 47 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 48 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 50 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 51 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 52 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 53 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 54 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 55 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 56 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 57 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 58 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 60 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 62 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 63 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 64 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 65 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 66 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 67 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 68 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 69 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 70 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 71 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 72 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 73 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 74 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 75 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 76 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 77 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 78 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 79 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 80 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 81 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 82 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 83 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 84 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 85 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 86 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 87 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 88 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 89 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 90 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 91 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 92 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 93 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 94 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 95 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 96 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 97 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 98 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 99 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 100 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 101 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 102 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 103 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 104 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 105 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 106 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 107 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 108 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 109 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 110 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 111 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 112 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 113 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 114 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 115 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 116 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 117 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 118 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 119 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 120 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 121 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 122 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 123 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 124 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 125 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 126 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 127 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 128 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 129 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 130 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 131 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 132 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 133 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 134 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 135 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 136 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 137 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 138 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 139 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 140 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 141 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 142 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 143 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 144 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 145 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 146 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 147 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 148 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 149 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 150 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 151 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 152 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 153 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 154 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 155 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 156 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 157 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 158 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 159 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 160 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 161 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 162 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 163 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 164 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 165 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 166 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 167 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 168 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 169 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 170 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 171 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 172 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 173 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 174 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 175 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 176 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 177 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 178 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 179 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 180 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 181 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 182 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 183 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 184 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 185 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 186 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 187 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 188 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 189 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 190 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 191 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 192 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 193 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 194 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 195 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 196 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 197 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 198 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 199 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 200 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 201 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 202 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 203 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 204 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 205 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 206 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 207 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 208 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 209 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 210 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 211 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 212 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 213 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 214 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 215 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 216 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 217 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 218 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 219 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 220 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 221 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 222 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 223 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 224 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 225 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 226 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 227 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 228 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 229 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 230 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 231 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 232 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 233 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 234 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 235 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 236 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 237 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 238 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 239 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 240 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 241 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 242 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 243 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 244 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 245 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 246 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 247 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 248 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericItems",
                keyColumns: new[] { "GroupId", "Id" },
                keyValues: new object[] { 2, 249 });

            migrationBuilder.DeleteData(
                table: "ConfigGenericGroups",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
