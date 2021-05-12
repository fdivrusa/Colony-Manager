CREATE DATABASE COLONY_MANAGER;
GO;


IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory]
    (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Accounts]
(
    [Id] bigint NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [PasswordHash] nvarchar(max) NULL,
    [AcceptTerms] bit NOT NULL,
    [Role] int NOT NULL,
    [VerificationToken] nvarchar(max) NULL,
    [Verified] datetime2 NULL,
    [ResetToken] nvarchar(max) NULL,
    [ResetTokenExpires] datetime2 NULL,
    [PasswordReset] datetime2 NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ConfigGenericGroups]
(
    [Id] int NOT NULL IDENTITY,
    [RelatedSubject] nvarchar(64) NULL,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_ConfigGenericGroups] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Countries]
(
    [Id] int NOT NULL IDENTITY,
    [AlphaCode2] nvarchar(2) NULL,
    [AlphaCode3] nvarchar(3) NULL,
    [Description] nvarchar(64) NULL,
    [NumericCode] nvarchar(3) NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [SystemDataTypes]
(
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [IsList] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_SystemDataTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [RefreshToken]
(
    [Id] bigint NOT NULL IDENTITY,
    [Token] nvarchar(max) NULL,
    [ExpirationDate] datetime2 NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [CreatedByIpv4] nvarchar(max) NULL,
    [CreatedByIpv6] nvarchar(max) NULL,
    [Revoked] datetime2 NULL,
    [RevokedByIpv4] nvarchar(max) NULL,
    [RevokedByIpv6] nvarchar(max) NULL,
    [ReplacedByToken] nvarchar(max) NULL,
    [AccountId] bigint NULL,
    CONSTRAINT [PK_RefreshToken] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RefreshToken_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ConfigGenericItems]
(
    [Id] int NOT NULL,
    [GroupId] int NOT NULL,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_ConfigGenericItems] PRIMARY KEY ([GroupId], [Id]),
    CONSTRAINT [FK_ConfigGenericItems_ConfigGenericGroups] FOREIGN KEY ([GroupId]) REFERENCES [ConfigGenericGroups] ([Id])
);
GO

CREATE TABLE [ConfigGenericItemExtentions]
(
    [Id] int NOT NULL,
    [ItemId] int NOT NULL,
    [GroupId] int NOT NULL,
    [SystemDataTypeId] int NOT NULL,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_ConfigGenericItemExtentions] PRIMARY KEY ([GroupId], [ItemId], [Id]),
    CONSTRAINT [FK_ConfigGenericItemExtentions_ConfigGenericItems] FOREIGN KEY ([GroupId], [ItemId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ConfigGenericItemExtentions_SystemDataTypes] FOREIGN KEY ([SystemDataTypeId]) REFERENCES [SystemDataTypes] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Peoples]
(
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(64) NULL,
    [LastName] nvarchar(64) NULL,
    [BirthDate] datetime2 NOT NULL,
    [ConfigGenericGenderGroupId] int NULL,
    [ConfigGenericGenderId] int NULL,
    [ConfigGenericProfessionGroupId] int NULL,
    [ConfigGenericProfessionId] int NULL,
    [IsActive] bit NOT NULL,
    [Deceased] bit NOT NULL,
    [DateOfDeath] datetime2 NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_Peoples] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_People_ConfigGenericItem_Gender] FOREIGN KEY ([ConfigGenericGenderGroupId], [ConfigGenericGenderId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_People_ConfigGenericItem_Profession] FOREIGN KEY ([ConfigGenericProfessionGroupId], [ConfigGenericProfessionId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ConfigGenericItemExtentionValues]
(
    [Id] int NOT NULL,
    [GroupId] int NOT NULL,
    [ItemId] int NOT NULL,
    [ExtentionId] int NOT NULL,
    [Value] nvarchar(256) NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_ConfigGenericItemExtentionValues] PRIMARY KEY ([ItemId], [GroupId], [ExtentionId], [Id]),
    CONSTRAINT [FK_ConfigGenericItemExtentionValues_ConfigGenericItemExtentions] FOREIGN KEY ([ExtentionId], [GroupId], [ItemId]) REFERENCES [ConfigGenericItemExtentions] ([GroupId], [ItemId], [Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [PeopleAddresses]
(
    [Id] int NOT NULL IDENTITY,
    [PeopleId] int NOT NULL,
    [ConfigGenericTypeGroupId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [StreetName] nvarchar(64) NULL,
    [City] nvarchar(64) NULL,
    [Area] nvarchar(64) NULL,
    [Box] int NULL,
    [Number] int NOT NULL,
    [CountryId] int NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_PeopleAddresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PeopleAddress_Country] FOREIGN KEY ([CountryId]) REFERENCES [Countries] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PeopleAddress_Type] FOREIGN KEY ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PeopleAddresses_Peoples_PeopleId] FOREIGN KEY ([PeopleId]) REFERENCES [Peoples] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PeoplesInternetInformations]
(
    [Id] int NOT NULL IDENTITY,
    [PeopleId] int NOT NULL,
    [ConfigGenericTypeGroupId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [Value] nvarchar(256) NULL,
    [IsObsolete] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_PeoplesInternetInformations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PeopleInternetInformation_People] FOREIGN KEY ([PeopleId]) REFERENCES [Peoples] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PeoplesPhoneInformations]
(
    [Id] int NOT NULL IDENTITY,
    [PeopleId] int NOT NULL,
    [ConfigGenericTypeGroupId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [Value] nvarchar(256) NULL,
    [IsObsolete] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_PeoplesPhoneInformations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PeoplePhoneInformation_People] FOREIGN KEY ([PeopleId]) REFERENCES [Peoples] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries]
    ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES
    (1, N'AF', N'AFG', N'Afghanistan', N'4'),
    (158, N'NZ', N'NZL', N'New Zealand', N'554'),
    (159, N'NI', N'NIC', N'Nicaragua', N'558'),
    (160, N'NE', N'NER', N'Niger (the)', N'562'),
    (161, N'NG', N'NGA', N'Nigeria', N'566'),
    (162, N'NU', N'NIU', N'Niue', N'570'),
    (163, N'NF', N'NFK', N'Norfolk Island', N'574'),
    (164, N'MP', N'MNP', N'Northern Mariana Islands (the)', N'580'),
    (165, N'NO', N'NOR', N'Norway', N'578'),
    (166, N'OM', N'OMN', N'Oman', N'512'),
    (167, N'PK', N'PAK', N'Pakistan', N'586'),
    (168, N'PW', N'PLW', N'Palau', N'585'),
    (169, N'PS', N'PSE', N'Palestine, State of', N'275'),
    (170, N'PA', N'PAN', N'Panama', N'591'),
    (171, N'PG', N'PNG', N'Papua New Guinea', N'598'),
    (172, N'PY', N'PRY', N'Paraguay', N'600'),
    (173, N'PE', N'PER', N'Peru', N'604'),
    (174, N'PH', N'PHL', N'Philippines (the)', N'608'),
    (175, N'PN', N'PCN', N'Pitcairn', N'612'),
    (176, N'PL', N'POL', N'Poland', N'616'),
    (177, N'PT', N'PRT', N'Portugal', N'620'),
    (178, N'PR', N'PRI', N'Puerto Rico', N'630'),
    (179, N'QA', N'QAT', N'Qatar', N'634'),
    (180, N'MK', N'MKD', N'Republic of North Macedonia', N'807'),
    (181, N'RO', N'ROU', N'Romania', N'642'),
    (182, N'RU', N'RUS', N'Russian Federation (the)', N'643'),
    (183, N'RW', N'RWA', N'Rwanda', N'646'),
    (184, N'RE', N'REU', N'Réunion', N'638'),
    (157, N'NC', N'NCL', N'New Caledonia', N'540'),
    (185, N'BL', N'BLM', N'Saint Barthélemy', N'652'),
    (156, N'NL', N'NLD', N'Netherlands (the)', N'528'),
    (154, N'NR', N'NRU', N'Nauru', N'520'),
    (127, N'LY', N'LBY', N'Libya', N'434'),
    (128, N'LI', N'LIE', N'Liechtenstein', N'438'),
    (129, N'LT', N'LTU', N'Lithuania', N'440'),
    (130, N'LU', N'LUX', N'Luxembourg', N'442'),
    (131, N'MO', N'MAC', N'Macao', N'446'),
    (132, N'MG', N'MDG', N'Madagascar', N'450'),
    (133, N'MW', N'MWI', N'Malawi', N'454'),
    (134, N'MY', N'MYS', N'Malaysia', N'458'),
    (135, N'MV', N'MDV', N'Maldives', N'462'),
    (136, N'ML', N'MLI', N'Mali', N'466');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries]
    ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES
    (137, N'MT', N'MLT', N'Malta', N'470'),
    (138, N'MH', N'MHL', N'Marshall Islands (the)', N'584'),
    (139, N'MQ', N'MTQ', N'Martinique', N'474'),
    (140, N'MR', N'MRT', N'Mauritania', N'478'),
    (141, N'MU', N'MUS', N'Mauritius', N'480'),
    (142, N'YT', N'MYT', N'Mayotte', N'175'),
    (143, N'MX', N'MEX', N'Mexico', N'484'),
    (144, N'FM', N'FSM', N'Micronesia (Federated States of)', N'583'),
    (145, N'MD', N'MDA', N'Moldova (the Republic of)', N'498'),
    (146, N'MC', N'MCO', N'Monaco', N'492'),
    (147, N'MN', N'MNG', N'Mongolia', N'496'),
    (148, N'ME', N'MNE', N'Montenegro', N'499'),
    (149, N'MS', N'MSR', N'Montserrat', N'500'),
    (150, N'MA', N'MAR', N'Morocco', N'504'),
    (151, N'MZ', N'MOZ', N'Mozambique', N'508'),
    (152, N'MM', N'MMR', N'Myanmar', N'104'),
    (153, N'NA', N'NAM', N'Namibia', N'516'),
    (155, N'NP', N'NPL', N'Nepal', N'524'),
    (186, N'SH', N'SHN', N'Saint Helena, Ascension and Tristan da Cunha', N'654'),
    (187, N'KN', N'KNA', N'Saint Kitts and Nevis', N'659'),
    (188, N'LC', N'LCA', N'Saint Lucia', N'662'),
    (221, N'TL', N'TLS', N'Timor-Leste', N'626'),
    (222, N'TG', N'TGO', N'Togo', N'768'),
    (223, N'TK', N'TKL', N'Tokelau', N'772'),
    (224, N'TO', N'TON', N'Tonga', N'776'),
    (225, N'TT', N'TTO', N'Trinidad and Tobago', N'780'),
    (226, N'TN', N'TUN', N'Tunisia', N'788'),
    (227, N'TR', N'TUR', N'Turkey', N'792'),
    (228, N'TM', N'TKM', N'Turkmenistan', N'795'),
    (229, N'TC', N'TCA', N'Turks and Caicos Islands (the)', N'796'),
    (230, N'TV', N'TUV', N'Tuvalu', N'798'),
    (231, N'UG', N'UGA', N'Uganda', N'800'),
    (232, N'UA', N'UKR', N'Ukraine', N'804'),
    (233, N'AE', N'ARE', N'United Arab Emirates (the)', N'784'),
    (234, N'GB', N'GBR', N'United Kingdom of Great Britain and Northern Ireland (the)', N'826'),
    (235, N'UM', N'UMI', N'United States Minor Outlying Islands (the)', N'581'),
    (236, N'US', N'USA', N'United States of America (the)', N'840'),
    (237, N'UY', N'URY', N'Uruguay', N'858'),
    (238, N'UZ', N'UZB', N'Uzbekistan', N'860'),
    (239, N'VU', N'VUT', N'Vanuatu', N'548'),
    (240, N'VE', N'VEN', N'Venezuela (Bolivarian Republic of)', N'862'),
    (241, N'VN', N'VNM', N'Viet Nam', N'704');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries]
    ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES
    (242, N'VG', N'VGB', N'Virgin Islands (British)', N'92'),
    (243, N'VI', N'VIR', N'Virgin Islands (U.S.)', N'850'),
    (244, N'WF', N'WLF', N'Wallis and Futuna', N'876'),
    (245, N'EH', N'ESH', N'Western Sahara', N'732'),
    (246, N'YE', N'YEM', N'Yemen', N'887'),
    (247, N'ZM', N'ZMB', N'Zambia', N'894'),
    (220, N'TH', N'THA', N'Thailand', N'764'),
    (219, N'TZ', N'TZA', N'Tanzania, United Republic of', N'834'),
    (218, N'TJ', N'TJK', N'Tajikistan', N'762'),
    (217, N'TW', N'TWN', N'Taiwan (Province of China)', N'158'),
    (189, N'MF', N'MAF', N'Saint Martin (French part)', N'663'),
    (190, N'PM', N'SPM', N'Saint Pierre and Miquelon', N'666'),
    (191, N'VC', N'VCT', N'Saint Vincent and the Grenadines', N'670'),
    (192, N'WS', N'WSM', N'Samoa', N'882'),
    (193, N'SM', N'SMR', N'San Marino', N'674'),
    (194, N'ST', N'STP', N'Sao Tome and Principe', N'678'),
    (195, N'SA', N'SAU', N'Saudi Arabia', N'682'),
    (196, N'SN', N'SEN', N'Senegal', N'686'),
    (197, N'RS', N'SRB', N'Serbia', N'688'),
    (198, N'SC', N'SYC', N'Seychelles', N'690'),
    (199, N'SL', N'SLE', N'Sierra Leone', N'694'),
    (200, N'SG', N'SGP', N'Singapore', N'702'),
    (201, N'SX', N'SXM', N'Sint Maarten (Dutch part)', N'534'),
    (126, N'LR', N'LBR', N'Liberia', N'430'),
    (202, N'SK', N'SVK', N'Slovakia', N'703'),
    (204, N'SB', N'SLB', N'Solomon Islands', N'90'),
    (205, N'SO', N'SOM', N'Somalia', N'706'),
    (206, N'ZA', N'ZAF', N'South Africa', N'710'),
    (207, N'GS', N'SGS', N'South Georgia and the South Sandwich Islands', N'239'),
    (208, N'SS', N'SSD', N'South Sudan', N'728'),
    (209, N'ES', N'ESP', N'Spain', N'724'),
    (210, N'LK', N'LKA', N'Sri Lanka', N'144'),
    (211, N'SD', N'SDN', N'Sudan (the)', N'729'),
    (212, N'SR', N'SUR', N'Suriname', N'740'),
    (213, N'SJ', N'SJM', N'Svalbard and Jan Mayen', N'744'),
    (214, N'SE', N'SWE', N'Sweden', N'752'),
    (215, N'CH', N'CHE', N'Switzerland', N'756'),
    (216, N'SY', N'SYR', N'Syrian Arab Republic', N'760'),
    (203, N'SI', N'SVN', N'Slovenia', N'705'),
    (248, N'ZW', N'ZWE', N'Zimbabwe', N'716'),
    (125, N'LS', N'LSO', N'Lesotho', N'426'),
    (123, N'LV', N'LVA', N'Latvia', N'428');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries]
    ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES
    (33, N'BN', N'BRN', N'Brunei Darussalam', N'96'),
    (34, N'BG', N'BGR', N'Bulgaria', N'100'),
    (35, N'BF', N'BFA', N'Burkina Faso', N'854'),
    (36, N'BI', N'BDI', N'Burundi', N'108'),
    (37, N'CV', N'CPV', N'Cabo Verde', N'132'),
    (38, N'KH', N'KHM', N'Cambodia', N'116'),
    (39, N'CM', N'CMR', N'Cameroon', N'120'),
    (40, N'CA', N'CAN', N'Canada', N'124'),
    (41, N'KY', N'CYM', N'Cayman Islands (the)', N'136'),
    (42, N'CF', N'CAF', N'Central African Republic (the)', N'140'),
    (43, N'TD', N'TCD', N'Chad', N'148'),
    (44, N'CL', N'CHL', N'Chile', N'152'),
    (45, N'CN', N'CHN', N'China', N'156'),
    (46, N'CX', N'CXR', N'Christmas Island', N'162'),
    (47, N'CC', N'CCK', N'Cocos (Keeling) Islands (the)', N'166'),
    (48, N'CO', N'COL', N'Colombia', N'170'),
    (49, N'KM', N'COM', N'Comoros (the)', N'174'),
    (50, N'CD', N'COD', N'Congo (the Democratic Republic of the)', N'180'),
    (51, N'CG', N'COG', N'Congo (the)', N'178'),
    (52, N'CK', N'COK', N'Cook Islands (the)', N'184'),
    (53, N'CR', N'CRI', N'Costa Rica', N'188'),
    (54, N'HR', N'HRV', N'Croatia', N'191'),
    (55, N'CU', N'CUB', N'Cuba', N'192'),
    (56, N'CW', N'CUW', N'Curaçao', N'531'),
    (57, N'CY', N'CYP', N'Cyprus', N'196'),
    (58, N'CZ', N'CZE', N'Czechia', N'203'),
    (59, N'CI', N'CIV', N'Côte d''Ivoire', N'384'),
    (32, N'IO', N'IOT', N'British Indian Ocean Territory (the)', N'86'),
    (60, N'DK', N'DNK', N'Denmark', N'208'),
    (31, N'BR', N'BRA', N'Brazil', N'76'),
    (29, N'BW', N'BWA', N'Botswana', N'72'),
    (2, N'AL', N'ALB', N'Albania', N'8'),
    (3, N'DZ', N'DZA', N'Algeria', N'12'),
    (4, N'AS', N'ASM', N'American Samoa', N'16'),
    (5, N'AD', N'AND', N'Andorra', N'20'),
    (6, N'AO', N'AGO', N'Angola', N'24'),
    (7, N'AI', N'AIA', N'Anguilla', N'660'),
    (8, N'AQ', N'ATA', N'Antarctica', N'10'),
    (9, N'AG', N'ATG', N'Antigua and Barbuda', N'28'),
    (10, N'AR', N'ARG', N'Argentina', N'32'),
    (11, N'AM', N'ARM', N'Armenia', N'51'),
    (12, N'AW', N'ABW', N'Aruba', N'533');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries]
    ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES
    (13, N'AU', N'AUS', N'Australia', N'36'),
    (14, N'AT', N'AUT', N'Austria', N'40'),
    (15, N'AZ', N'AZE', N'Azerbaijan', N'31'),
    (16, N'BS', N'BHS', N'Bahamas (the)', N'44'),
    (17, N'BH', N'BHR', N'Bahrain', N'48'),
    (18, N'BD', N'BGD', N'Bangladesh', N'50'),
    (19, N'BB', N'BRB', N'Barbados', N'52'),
    (20, N'BY', N'BLR', N'Belarus', N'112'),
    (21, N'BE', N'BEL', N'Belgium', N'56'),
    (22, N'BZ', N'BLZ', N'Belize', N'84'),
    (23, N'BJ', N'BEN', N'Benin', N'204'),
    (24, N'BM', N'BMU', N'Bermuda', N'60'),
    (25, N'BT', N'BTN', N'Bhutan', N'64'),
    (26, N'BO', N'BOL', N'Bolivia (Plurinational State of)', N'68'),
    (27, N'BQ', N'BES', N'Bonaire, Sint Eustatius and Saba', N'535'),
    (28, N'BA', N'BIH', N'Bosnia and Herzegovina', N'70'),
    (30, N'BV', N'BVT', N'Bouvet Island', N'74'),
    (61, N'DJ', N'DJI', N'Djibouti', N'262'),
    (62, N'DM', N'DMA', N'Dominica', N'212'),
    (63, N'DO', N'DOM', N'Dominican Republic (the)', N'214'),
    (96, N'HT', N'HTI', N'Haiti', N'332'),
    (97, N'HM', N'HMD', N'Heard Island and McDonald Islands', N'334'),
    (98, N'VA', N'VAT', N'Holy See (the)', N'336'),
    (99, N'HN', N'HND', N'Honduras', N'340'),
    (100, N'HK', N'HKG', N'Hong Kong', N'344'),
    (101, N'HU', N'HUN', N'Hungary', N'348'),
    (102, N'IS', N'ISL', N'Iceland', N'352'),
    (103, N'IN', N'IND', N'India', N'356'),
    (104, N'ID', N'IDN', N'Indonesia', N'360'),
    (105, N'IR', N'IRN', N'Iran (Islamic Republic of)', N'364'),
    (106, N'IQ', N'IRQ', N'Iraq', N'368'),
    (107, N'IE', N'IRL', N'Ireland', N'372'),
    (108, N'IM', N'IMN', N'Isle of Man', N'833'),
    (109, N'IL', N'ISR', N'Israel', N'376'),
    (110, N'IT', N'ITA', N'Italy', N'380'),
    (111, N'JM', N'JAM', N'Jamaica', N'388'),
    (112, N'JP', N'JPN', N'Japan', N'392'),
    (113, N'JE', N'JEY', N'Jersey', N'832'),
    (114, N'JO', N'JOR', N'Jordan', N'400'),
    (115, N'KZ', N'KAZ', N'Kazakhstan', N'398'),
    (116, N'KE', N'KEN', N'Kenya', N'404'),
    (117, N'KI', N'KIR', N'Kiribati', N'296');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries]
    ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES
    (118, N'KP', N'PRK', N'Korea (the Democratic People''s Republic of)', N'408'),
    (119, N'KR', N'KOR', N'Korea (the Republic of)', N'410'),
    (120, N'KW', N'KWT', N'Kuwait', N'414'),
    (121, N'KG', N'KGZ', N'Kyrgyzstan', N'417'),
    (122, N'LA', N'LAO', N'Lao People''s Democratic Republic (the)', N'418'),
    (95, N'GY', N'GUY', N'Guyana', N'328'),
    (94, N'GW', N'GNB', N'Guinea-Bissau', N'624'),
    (93, N'GN', N'GIN', N'Guinea', N'324'),
    (92, N'GG', N'GGY', N'Guernsey', N'831'),
    (64, N'EC', N'ECU', N'Ecuador', N'218'),
    (65, N'EG', N'EGY', N'Egypt', N'818'),
    (66, N'SV', N'SLV', N'El Salvador', N'222'),
    (67, N'GQ', N'GNQ', N'Equatorial Guinea', N'226'),
    (68, N'ER', N'ERI', N'Eritrea', N'232'),
    (69, N'EE', N'EST', N'Estonia', N'233'),
    (70, N'SZ', N'SWZ', N'Eswatini', N'748'),
    (71, N'ET', N'ETH', N'Ethiopia', N'231'),
    (72, N'FK', N'FLK', N'Falkland Islands (the) [Malvinas]', N'238'),
    (73, N'FO', N'FRO', N'Faroe Islands (the)', N'234'),
    (74, N'FJ', N'FJI', N'Fiji', N'242'),
    (75, N'FI', N'FIN', N'Finland', N'246'),
    (76, N'FR', N'FRA', N'France', N'250'),
    (124, N'LB', N'LBN', N'Lebanon', N'422'),
    (77, N'GF', N'GUF', N'French Guiana', N'254'),
    (79, N'TF', N'ATF', N'French Southern Territories (the)', N'260'),
    (80, N'GA', N'GAB', N'Gabon', N'266'),
    (81, N'GM', N'GMB', N'Gambia (the)', N'270'),
    (82, N'GE', N'GEO', N'Georgia', N'268'),
    (83, N'DE', N'DEU', N'Germany', N'276'),
    (84, N'GH', N'GHA', N'Ghana', N'288'),
    (85, N'GI', N'GIB', N'Gibraltar', N'292'),
    (86, N'GR', N'GRC', N'Greece', N'300'),
    (87, N'GL', N'GRL', N'Greenland', N'304'),
    (88, N'GD', N'GRD', N'Grenada', N'308'),
    (89, N'GP', N'GLP', N'Guadeloupe', N'312'),
    (90, N'GU', N'GUM', N'Guam', N'316'),
    (91, N'GT', N'GTM', N'Guatemala', N'320'),
    (78, N'PF', N'PYF', N'French Polynesia', N'258'),
    (249, N'AX', N'ALA', N'Åland Islands', N'248');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

CREATE INDEX [IX_ConfigGenericItemExtentions_SystemDataTypeId] ON [ConfigGenericItemExtentions] ([SystemDataTypeId]);
GO

CREATE INDEX [IX_ConfigGenericItemExtentionValues_ExtentionId_GroupId_ItemId] ON [ConfigGenericItemExtentionValues] ([ExtentionId], [GroupId], [ItemId]);
GO

CREATE INDEX [IX_PeopleAddresses_ConfigGenericTypeGroupId_ConfigGenericTypeId] ON [PeopleAddresses] ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]);
GO

CREATE INDEX [IX_PeopleAddresses_CountryId] ON [PeopleAddresses] ([CountryId]);
GO

CREATE INDEX [IX_PeopleAddresses_PeopleId] ON [PeopleAddresses] ([PeopleId]);
GO

CREATE UNIQUE INDEX [IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId] ON [Peoples] ([ConfigGenericGenderGroupId], [ConfigGenericGenderId]) WHERE [ConfigGenericGenderGroupId] IS NOT NULL AND [ConfigGenericGenderId] IS NOT NULL;
GO

CREATE UNIQUE INDEX [IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId] ON [Peoples] ([ConfigGenericProfessionGroupId], [ConfigGenericProfessionId]) WHERE [ConfigGenericProfessionGroupId] IS NOT NULL AND [ConfigGenericProfessionId] IS NOT NULL;
GO

CREATE INDEX [IX_PeoplesInternetInformations_PeopleId] ON [PeoplesInternetInformations] ([PeopleId]);
GO

CREATE INDEX [IX_PeoplesPhoneInformations_PeopleId] ON [PeoplesPhoneInformations] ([PeopleId]);
GO

CREATE INDEX [IX_RefreshToken_AccountId] ON [RefreshToken] ([AccountId]);
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210331190735_Initial_Creation', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE INDEX [IX_PeoplesPhoneInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId] ON [PeoplesPhoneInformations] ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]);
GO

CREATE INDEX [IX_PeoplesInternetInformations_ConfigGenericTypeGroupId_ConfigGenericTypeId] ON [PeoplesInternetInformations] ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]);
GO

ALTER TABLE [PeoplesInternetInformations] ADD CONSTRAINT [FK_PeopleInternetInformation_ConfigGenericType] FOREIGN KEY ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE CASCADE;
GO

ALTER TABLE [PeoplesPhoneInformations] ADD CONSTRAINT [FK_PeoplePhoneInformation_ConfigGenericType] FOREIGN KEY ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210401191032_Add_Type_PhoneAndInternetInformation', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Peoples] DROP CONSTRAINT [FK_People_ConfigGenericItem_Gender];
GO

ALTER TABLE [Peoples] DROP CONSTRAINT [FK_People_ConfigGenericItem_Profession];
GO

DROP INDEX [IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId] ON [Peoples];
GO

DROP INDEX [IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId] ON [Peoples];
GO

CREATE TABLE [PeopleAttributions]
(
    [Id] int NOT NULL IDENTITY,
    [PeopleId] int NOT NULL,
    [ConfigGenericTypeGroupId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [BeginDate] datetime2 NOT NULL,
    [EndDate] datetime2 NULL,
    [Remarks] nvarchar(2048) NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_PeopleAttributions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_People_Attributions] FOREIGN KEY ([PeopleId]) REFERENCES [Peoples] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_PeopleAttribution_ConfigGenericType] FOREIGN KEY ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Peoples_ConfigGenericGenderGroupId_ConfigGenericGenderId] ON [Peoples] ([ConfigGenericGenderGroupId], [ConfigGenericGenderId]);
GO

CREATE INDEX [IX_Peoples_ConfigGenericProfessionGroupId_ConfigGenericProfessionId] ON [Peoples] ([ConfigGenericProfessionGroupId], [ConfigGenericProfessionId]);
GO

CREATE INDEX [IX_PeopleAttributions_ConfigGenericTypeGroupId_ConfigGenericTypeId] ON [PeopleAttributions] ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]);
GO

CREATE INDEX [IX_PeopleAttributions_PeopleId] ON [PeopleAttributions] ([PeopleId]);
GO

ALTER TABLE [Peoples] ADD CONSTRAINT [FK_People_ConfigGenericItem_Genders] FOREIGN KEY ([ConfigGenericGenderGroupId], [ConfigGenericGenderId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [Peoples] ADD CONSTRAINT [FK_People_ConfigGenericItem_Professions] FOREIGN KEY ([ConfigGenericProfessionGroupId], [ConfigGenericProfessionId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210417154945_Add_People_Attributions', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [PeopleAttributions] DROP CONSTRAINT [FK_People_Attributions];
GO

ALTER TABLE [PeopleAttributions] ADD CONSTRAINT [FK_PeopleAttributions_Peoples] FOREIGN KEY ([PeopleId]) REFERENCES [Peoples] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210417204045_Rename_FK_People_Attribution', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Colonies]
(
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [ConfigGenericTypeGroupId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [MaxPopulation] int NOT NULL,
    [ActualPopulation] int NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_Colonies] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Colony_ConfigGenericItem] FOREIGN KEY ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ColonyBuildings]
(
    [Id] int NOT NULL IDENTITY,
    [ColonyId] int NOT NULL,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [ConfigGenericTypeGroupId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [FK_Colony_ColonyBuilding] int NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_ColonyBuildings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ColonyBuilding_Colony] FOREIGN KEY ([FK_Colony_ColonyBuilding]) REFERENCES [Colonies] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ColonyBuilding_ConfigGenericItem] FOREIGN KEY ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ColonyBuildingRooms]
(
    [Id] int NOT NULL IDENTITY,
    [ColonyBuildingId] int NOT NULL,
    [Code] nvarchar(64) NULL,
    [Description] nvarchar(512) NULL,
    [ConfigGenericGroupTypeId] int NOT NULL,
    [ConfigGenericTypeId] int NOT NULL,
    [Floor] int NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastUpdatedDate] datetime2 NULL,
    [LastUpdatedUserName] nvarchar(128) NULL,
    [Comment] nvarchar(512) NULL,
    CONSTRAINT [PK_ColonyBuildingRooms] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ColonyBuildingRoom_ColonyBuilding] FOREIGN KEY ([ColonyBuildingId]) REFERENCES [ColonyBuildings] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ColonyBuildingRoom_ConfigGenericItem] FOREIGN KEY ([ConfigGenericGroupTypeId], [ConfigGenericTypeId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Colonies_ConfigGenericTypeGroupId_ConfigGenericTypeId] ON [Colonies] ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]);
GO

CREATE INDEX [IX_ColonyBuildingRooms_ColonyBuildingId] ON [ColonyBuildingRooms] ([ColonyBuildingId]);
GO

CREATE INDEX [IX_ColonyBuildingRooms_ConfigGenericGroupTypeId_ConfigGenericTypeId] ON [ColonyBuildingRooms] ([ConfigGenericGroupTypeId], [ConfigGenericTypeId]);
GO

CREATE INDEX [IX_ColonyBuildings_ConfigGenericTypeGroupId_ConfigGenericTypeId] ON [ColonyBuildings] ([ConfigGenericTypeGroupId], [ConfigGenericTypeId]);
GO

CREATE INDEX [IX_ColonyBuildings_FK_Colony_ColonyBuilding] ON [ColonyBuildings] ([FK_Colony_ColonyBuilding]);
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210417220007_Add_Colony_tables', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [ColonyBuildings] DROP CONSTRAINT [FK_ColonyBuilding_Colony];
GO

DROP INDEX [IX_ColonyBuildings_FK_Colony_ColonyBuilding] ON [ColonyBuildings];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ColonyBuildings]') AND [c].[name] = N'FK_Colony_ColonyBuilding');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [ColonyBuildings] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [ColonyBuildings] DROP COLUMN [FK_Colony_ColonyBuilding];
GO

CREATE INDEX [IX_ColonyBuildings_ColonyId] ON [ColonyBuildings] ([ColonyId]);
GO

ALTER TABLE [ColonyBuildings] ADD CONSTRAINT [FK_Colony_ColonyBuilding] FOREIGN KEY ([ColonyId]) REFERENCES [Colonies] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210417220721_Solve_ColonyBuilding_Error', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ColonyBuildings]') AND [c].[name] = N'Code');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [ColonyBuildings] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [ColonyBuildings] ALTER COLUMN [Code] nvarchar(64) NOT NULL;
ALTER TABLE [ColonyBuildings] ADD DEFAULT N'' FOR [Code];
GO

ALTER TABLE [ColonyBuildings] ADD [Location] geography NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ColonyBuildingRooms]') AND [c].[name] = N'Code');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [ColonyBuildingRooms] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [ColonyBuildingRooms] ALTER COLUMN [Code] nvarchar(64) NOT NULL;
ALTER TABLE [ColonyBuildingRooms] ADD DEFAULT N'' FOR [Code];
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Colonies]') AND [c].[name] = N'Code');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Colonies] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Colonies] ALTER COLUMN [Code] nvarchar(64) NOT NULL;
ALTER TABLE [Colonies] ADD DEFAULT N'' FOR [Code];
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210421200806_Buildings_Locations', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Colonies] ADD [Border] geography NULL;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210421201329_Colonies_Border', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [ConfigGenericItems] DROP CONSTRAINT [FK_ConfigGenericItems_ConfigGenericGroups];
GO

ALTER TABLE [Peoples] ADD [ConfigGenericNationalityGroupId] int NULL;
GO

ALTER TABLE [Peoples] ADD [ConfigGenericNationalityId] int NULL;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName', N'RelatedSubject') AND [object_id] = OBJECT_ID(N'[ConfigGenericGroups]'))
    SET IDENTITY_INSERT [ConfigGenericGroups] ON;
INSERT INTO [ConfigGenericGroups]
    ([Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName], [RelatedSubject])
VALUES
    (1, N'NATIONALITIES', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Group that contains all the known nationalities', NULL, N'SYSTEM', N'PEOPLES');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName', N'RelatedSubject') AND [object_id] = OBJECT_ID(N'[ConfigGenericGroups]'))
    SET IDENTITY_INSERT [ConfigGenericGroups] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] ON;
INSERT INTO [ConfigGenericItems]
    ([GroupId], [Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName])
VALUES
    (1, 0, N'UNK', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Unknown', NULL, N'SYSTEM');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] OFF;
GO

CREATE INDEX [IX_Peoples_ConfigGenericNationalityGroupId_ConfigGenericNationalityId] ON [Peoples] ([ConfigGenericNationalityGroupId], [ConfigGenericNationalityId]);
GO

ALTER TABLE [ConfigGenericItems] ADD CONSTRAINT [FK_ConfigGenericItems_ConfigGenericGroups] FOREIGN KEY ([GroupId]) REFERENCES [ConfigGenericGroups] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [Peoples] ADD CONSTRAINT [FK_People_ConfigGenericItem_Nationality] FOREIGN KEY ([ConfigGenericNationalityGroupId], [ConfigGenericNationalityId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210422201158_People_Nationality_fields', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Peoples] DROP CONSTRAINT [FK_People_ConfigGenericItem_Nationality];
GO

ALTER TABLE [Peoples] ADD CONSTRAINT [FK_People_ConfigGenericItem_Nationalities] FOREIGN KEY ([ConfigGenericNationalityGroupId], [ConfigGenericNationalityId]) REFERENCES [ConfigGenericItems] ([GroupId], [Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210422201422_People_Nationality_FKName', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] ON;
INSERT INTO [ConfigGenericItems]
    ([GroupId], [Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName])
VALUES
    (1, 1, N'AFG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Afghan', NULL, N'SYSTEM'),
    (1, 124, N'MOZ', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Mozambican', NULL, N'SYSTEM'),
    (1, 125, N'NAM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Namibian', NULL, N'SYSTEM'),
    (1, 126, N'NAU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Nauruan', NULL, N'SYSTEM'),
    (1, 127, N'NEP', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Nepalese', NULL, N'SYSTEM'),
    (1, 128, N'NEW', N'Initial seed', '2021-12-31T00:00:00.0000000', N'New Zealander', NULL, N'SYSTEM'),
    (1, 129, N'NI-', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ni-Vanuatu', NULL, N'SYSTEM'),
    (1, 130, N'NIC', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Nicaraguan', NULL, N'SYSTEM'),
    (1, 131, N'NIG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Nigerian', NULL, N'SYSTEM'),
    (1, 132, N'NIGE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Nigerien', NULL, N'SYSTEM'),
    (1, 123, N'MOT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Motswana', NULL, N'SYSTEM'),
    (1, 133, N'NOR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'North Korean', NULL, N'SYSTEM'),
    (1, 135, N'NORW', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Norwegian', NULL, N'SYSTEM'),
    (1, 136, N'OMA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Omani', NULL, N'SYSTEM'),
    (1, 137, N'PAK', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Pakistani', NULL, N'SYSTEM'),
    (1, 138, N'PAL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Palauan', NULL, N'SYSTEM'),
    (1, 139, N'PAN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Panamanian', NULL, N'SYSTEM'),
    (1, 140, N'PAP', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Papua New Guinean', NULL, N'SYSTEM'),
    (1, 141, N'PAR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Paraguayan', NULL, N'SYSTEM'),
    (1, 142, N'PER', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Peruvian', NULL, N'SYSTEM'),
    (1, 143, N'POL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Polish', NULL, N'SYSTEM'),
    (1, 134, N'NORT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Northern Irish', NULL, N'SYSTEM'),
    (1, 144, N'POR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Portuguese', NULL, N'SYSTEM'),
    (1, 122, N'MOS', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Mosotho', NULL, N'SYSTEM'),
    (1, 120, N'MONG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Mongolian', NULL, N'SYSTEM'),
    (1, 100, N'LEB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Lebanese', NULL, N'SYSTEM'),
    (1, 101, N'LIB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Liberian', NULL, N'SYSTEM'),
    (1, 102, N'LIBY', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Libyan', NULL, N'SYSTEM'),
    (1, 103, N'LIE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Liechtensteiner', NULL, N'SYSTEM'),
    (1, 104, N'LIT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Lithuanian', NULL, N'SYSTEM'),
    (1, 105, N'LUX', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Luxembourger', NULL, N'SYSTEM'),
    (1, 106, N'MAC', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Macedonian', NULL, N'SYSTEM'),
    (1, 107, N'MAL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Malagasy', NULL, N'SYSTEM'),
    (1, 108, N'MALA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Malawian', NULL, N'SYSTEM'),
    (1, 121, N'MOR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Moroccan', NULL, N'SYSTEM'),
    (1, 109, N'MALA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Malaysian', NULL, N'SYSTEM'),
    (1, 111, N'MALI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Malian', NULL, N'SYSTEM'),
    (1, 112, N'MALT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Maltese', NULL, N'SYSTEM'),
    (1, 113, N'MAR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Marshallese', NULL, N'SYSTEM'),
    (1, 114, N'MAU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Mauritanian', NULL, N'SYSTEM'),
    (1, 115, N'MAUR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Mauritian', NULL, N'SYSTEM'),
    (1, 116, N'MEX', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Mexican', NULL, N'SYSTEM');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] ON;
INSERT INTO [ConfigGenericItems]
    ([GroupId], [Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName])
VALUES
    (1, 117, N'MIC', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Micronesian', NULL, N'SYSTEM'),
    (1, 118, N'MOL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Moldovan', NULL, N'SYSTEM'),
    (1, 119, N'MON', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Monacan', NULL, N'SYSTEM'),
    (1, 110, N'MALD', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Maldivian', NULL, N'SYSTEM'),
    (1, 145, N'QAT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Qatari', NULL, N'SYSTEM'),
    (1, 146, N'ROM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Romanian', NULL, N'SYSTEM'),
    (1, 147, N'RUS', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Russian', NULL, N'SYSTEM'),
    (1, 173, N'SWI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Swiss', NULL, N'SYSTEM'),
    (1, 174, N'SYR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Syrian', NULL, N'SYSTEM'),
    (1, 175, N'TAI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Taiwanese', NULL, N'SYSTEM'),
    (1, 176, N'TAJ', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Tajik', NULL, N'SYSTEM'),
    (1, 177, N'TAN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Tanzanian', NULL, N'SYSTEM'),
    (1, 178, N'THA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Thai', NULL, N'SYSTEM'),
    (1, 179, N'TOG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Togolese', NULL, N'SYSTEM'),
    (1, 180, N'TON', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Tongan', NULL, N'SYSTEM'),
    (1, 181, N'TRI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Trinidadian or Tobagonian', NULL, N'SYSTEM'),
    (1, 172, N'SWE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Swedish', NULL, N'SYSTEM'),
    (1, 182, N'TUN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Tunisian', NULL, N'SYSTEM'),
    (1, 184, N'TUV', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Tuvaluan', NULL, N'SYSTEM'),
    (1, 185, N'UGA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ugandan', NULL, N'SYSTEM'),
    (1, 186, N'UKR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ukrainian', NULL, N'SYSTEM'),
    (1, 187, N'URUG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Uruguayan', NULL, N'SYSTEM'),
    (1, 188, N'UZB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Uzbekistani', NULL, N'SYSTEM'),
    (1, 189, N'VEN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Venezuelan', NULL, N'SYSTEM'),
    (1, 190, N'VIE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Vietnamese', NULL, N'SYSTEM'),
    (1, 191, N'WEL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Welsh', NULL, N'SYSTEM'),
    (1, 192, N'YEM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Yemenite', NULL, N'SYSTEM'),
    (1, 183, N'TUR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Turkish', NULL, N'SYSTEM'),
    (1, 171, N'SWA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Swazi', NULL, N'SYSTEM'),
    (1, 170, N'SUR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Surinamer', NULL, N'SYSTEM'),
    (1, 169, N'SUD', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Sudanese', NULL, N'SYSTEM'),
    (1, 148, N'RWA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Rwandan', NULL, N'SYSTEM'),
    (1, 149, N'SAI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Saint Lucian', NULL, N'SYSTEM'),
    (1, 150, N'SAL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Salvadoran', NULL, N'SYSTEM'),
    (1, 151, N'SAM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Samoan', NULL, N'SYSTEM'),
    (1, 152, N'SAN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'San Marinese', NULL, N'SYSTEM'),
    (1, 153, N'SAO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Sao Tomean', NULL, N'SYSTEM'),
    (1, 154, N'SAU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Saudi', NULL, N'SYSTEM'),
    (1, 155, N'SCO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Scottish', NULL, N'SYSTEM'),
    (1, 156, N'SEN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Senegalese', NULL, N'SYSTEM'),
    (1, 157, N'SER', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Serbian', NULL, N'SYSTEM'),
    (1, 158, N'SEY', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Seychellois', NULL, N'SYSTEM');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] ON;
INSERT INTO [ConfigGenericItems]
    ([GroupId], [Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName])
VALUES
    (1, 159, N'SIE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Sierra Leonean', NULL, N'SYSTEM'),
    (1, 160, N'SIN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Singaporean', NULL, N'SYSTEM'),
    (1, 161, N'SLO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Slovakian', NULL, N'SYSTEM'),
    (1, 162, N'SLOV', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Slovenian', NULL, N'SYSTEM'),
    (1, 163, N'SOL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Solomon Islander', NULL, N'SYSTEM'),
    (1, 164, N'SOM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Somali', NULL, N'SYSTEM'),
    (1, 165, N'SOU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'South African', NULL, N'SYSTEM'),
    (1, 166, N'SOUT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'South Korean', NULL, N'SYSTEM'),
    (1, 167, N'SPA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Spanish', NULL, N'SYSTEM'),
    (1, 168, N'SRI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Sri Lankan', NULL, N'SYSTEM'),
    (1, 99, N'LAT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Latvian', NULL, N'SYSTEM'),
    (1, 98, N'LAO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Laotian', NULL, N'SYSTEM'),
    (1, 97, N'KYR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Kyrgyz', NULL, N'SYSTEM'),
    (1, 96, N'KUW', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Kuwaiti', NULL, N'SYSTEM'),
    (1, 27, N'BRI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'British', NULL, N'SYSTEM'),
    (1, 28, N'BRU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bruneian', NULL, N'SYSTEM'),
    (1, 29, N'BUL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bulgarian', NULL, N'SYSTEM'),
    (1, 30, N'BUR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Burkinabe', NULL, N'SYSTEM'),
    (1, 31, N'BURM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Burmese', NULL, N'SYSTEM'),
    (1, 32, N'BURU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Burundian', NULL, N'SYSTEM'),
    (1, 33, N'CAM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Cambodian', NULL, N'SYSTEM'),
    (1, 34, N'CAME', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Cameroonian', NULL, N'SYSTEM'),
    (1, 35, N'CAN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Canadian', NULL, N'SYSTEM'),
    (1, 26, N'BRA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Brazilian', NULL, N'SYSTEM'),
    (1, 36, N'CAP', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Cape Verdean', NULL, N'SYSTEM'),
    (1, 38, N'CHA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Chadian', NULL, N'SYSTEM'),
    (1, 39, N'CHI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Chilean', NULL, N'SYSTEM'),
    (1, 40, N'CHIN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Chinese', NULL, N'SYSTEM'),
    (1, 41, N'COL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Colombian', NULL, N'SYSTEM'),
    (1, 42, N'COM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Comoran', NULL, N'SYSTEM'),
    (1, 43, N'CON', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Congolese', NULL, N'SYSTEM'),
    (1, 44, N'COS', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Costa Rican', NULL, N'SYSTEM'),
    (1, 45, N'CRO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Croatian', NULL, N'SYSTEM'),
    (1, 46, N'CUB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Cuban', NULL, N'SYSTEM'),
    (1, 37, N'CEN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Central African', NULL, N'SYSTEM'),
    (1, 25, N'BOS', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bosnian', NULL, N'SYSTEM'),
    (1, 24, N'BOL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bolivian', NULL, N'SYSTEM'),
    (1, 23, N'BHU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bhutanese', NULL, N'SYSTEM'),
    (1, 2, N'ALB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Albanian', NULL, N'SYSTEM'),
    (1, 3, N'ALG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Algerian', NULL, N'SYSTEM'),
    (1, 4, N'AME', N'Initial seed', '2021-12-31T00:00:00.0000000', N'American', NULL, N'SYSTEM'),
    (1, 5, N'AND', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Andorran', NULL, N'SYSTEM');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] ON;
INSERT INTO [ConfigGenericItems]
    ([GroupId], [Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName])
VALUES
    (1, 6, N'ANG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Angolan', NULL, N'SYSTEM'),
    (1, 7, N'ANT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Antiguans', NULL, N'SYSTEM'),
    (1, 8, N'ARG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Argentinean', NULL, N'SYSTEM'),
    (1, 9, N'ARM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Armenian', NULL, N'SYSTEM'),
    (1, 10, N'AUS', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Australian', NULL, N'SYSTEM'),
    (1, 11, N'AUST', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Austrian', NULL, N'SYSTEM'),
    (1, 12, N'AZE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Azerbaijani', NULL, N'SYSTEM'),
    (1, 13, N'BAH', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bahamian', NULL, N'SYSTEM'),
    (1, 14, N'BAHR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bahraini', NULL, N'SYSTEM'),
    (1, 15, N'BAN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Bangladeshi', NULL, N'SYSTEM'),
    (1, 16, N'BAR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Barbadian', NULL, N'SYSTEM'),
    (1, 17, N'BARB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Barbudans', NULL, N'SYSTEM'),
    (1, 18, N'BAT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Batswana', NULL, N'SYSTEM'),
    (1, 19, N'BEL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Belarusian', NULL, N'SYSTEM'),
    (1, 20, N'BELG', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Belgian', NULL, N'SYSTEM'),
    (1, 21, N'BELI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Belizean', NULL, N'SYSTEM'),
    (1, 22, N'BEN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Beninese', NULL, N'SYSTEM'),
    (1, 47, N'CYP', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Cypriot', NULL, N'SYSTEM'),
    (1, 193, N'ZAM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Zambian', NULL, N'SYSTEM'),
    (1, 48, N'CZE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Czech', NULL, N'SYSTEM'),
    (1, 50, N'DJI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Djibouti', NULL, N'SYSTEM'),
    (1, 76, N'HAI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Haitian', NULL, N'SYSTEM'),
    (1, 77, N'HER', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Herzegovinian', NULL, N'SYSTEM'),
    (1, 78, N'HON', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Honduran', NULL, N'SYSTEM'),
    (1, 79, N'HUN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Hungarian', NULL, N'SYSTEM'),
    (1, 80, N'I-K', N'Initial seed', '2021-12-31T00:00:00.0000000', N'I-Kiribati', NULL, N'SYSTEM'),
    (1, 81, N'ICE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Icelander', NULL, N'SYSTEM'),
    (1, 82, N'IND', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Indian', NULL, N'SYSTEM'),
    (1, 83, N'INDO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Indonesian', NULL, N'SYSTEM'),
    (1, 84, N'IRA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Iranian', NULL, N'SYSTEM'),
    (1, 75, N'GUY', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Guyanese', NULL, N'SYSTEM'),
    (1, 85, N'IRAQ', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Iraqi', NULL, N'SYSTEM'),
    (1, 87, N'ISR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Israeli', NULL, N'SYSTEM'),
    (1, 88, N'ITA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Italian', NULL, N'SYSTEM'),
    (1, 89, N'IVO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ivorian', NULL, N'SYSTEM'),
    (1, 90, N'JAM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Jamaican', NULL, N'SYSTEM'),
    (1, 91, N'JAP', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Japanese', NULL, N'SYSTEM'),
    (1, 92, N'JOR', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Jordanian', NULL, N'SYSTEM'),
    (1, 93, N'KAZ', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Kazakhstani', NULL, N'SYSTEM'),
    (1, 94, N'KEN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Kenyan', NULL, N'SYSTEM'),
    (1, 95, N'KIT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Kittian and Nevisian', NULL, N'SYSTEM'),
    (1, 86, N'IRI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Irish', NULL, N'SYSTEM');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] OFF;
GO

IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] ON;
INSERT INTO [ConfigGenericItems]
    ([GroupId], [Id], [Code], [Comment], [CreatedDate], [Description], [LastUpdatedDate], [LastUpdatedUserName])
VALUES
    (1, 74, N'GUIN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Guinean', NULL, N'SYSTEM'),
    (1, 73, N'GUI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Guinea-Bissauan', NULL, N'SYSTEM'),
    (1, 72, N'GUA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Guatemalan', NULL, N'SYSTEM'),
    (1, 51, N'DOM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Dominican', NULL, N'SYSTEM'),
    (1, 52, N'DUT', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Dutch', NULL, N'SYSTEM'),
    (1, 53, N'EAS', N'Initial seed', '2021-12-31T00:00:00.0000000', N'East Timorese', NULL, N'SYSTEM'),
    (1, 54, N'ECU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ecuadorean', NULL, N'SYSTEM'),
    (1, 55, N'EGY', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Egyptian', NULL, N'SYSTEM'),
    (1, 56, N'EMI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Emirian', NULL, N'SYSTEM'),
    (1, 57, N'EQU', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Equatorial Guinean', NULL, N'SYSTEM'),
    (1, 58, N'ERI', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Eritrean', NULL, N'SYSTEM'),
    (1, 59, N'EST', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Estonian', NULL, N'SYSTEM'),
    (1, 60, N'ETH', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ethiopian', NULL, N'SYSTEM'),
    (1, 61, N'FIJ', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Fijian', NULL, N'SYSTEM'),
    (1, 62, N'FIL', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Filipino', NULL, N'SYSTEM'),
    (1, 63, N'FIN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Finnish', NULL, N'SYSTEM'),
    (1, 64, N'FRE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'French', NULL, N'SYSTEM'),
    (1, 65, N'GAB', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Gabonese', NULL, N'SYSTEM'),
    (1, 66, N'GAM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Gambian', NULL, N'SYSTEM'),
    (1, 67, N'GEO', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Georgian', NULL, N'SYSTEM'),
    (1, 68, N'GER', N'Initial seed', '2021-12-31T00:00:00.0000000', N'German', NULL, N'SYSTEM'),
    (1, 69, N'GHA', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Ghanaian', NULL, N'SYSTEM'),
    (1, 70, N'GRE', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Greek', NULL, N'SYSTEM'),
    (1, 71, N'GREN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Grenadian', NULL, N'SYSTEM'),
    (1, 49, N'DAN', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Danish', NULL, N'SYSTEM'),
    (1, 194, N'ZIM', N'Initial seed', '2021-12-31T00:00:00.0000000', N'Zimbabwean', NULL, N'SYSTEM');
IF EXISTS (SELECT *
FROM [sys].[identity_columns]
WHERE [name] IN (N'GroupId', N'Id', N'Code', N'Comment', N'CreatedDate', N'Description', N'LastUpdatedDate', N'LastUpdatedUserName') AND [object_id] = OBJECT_ID(N'[ConfigGenericItems]'))
    SET IDENTITY_INSERT [ConfigGenericItems] OFF;
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210423195638_Add_Nationalities_Seeding', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [ConfigGenericItems] SET [Code] = N'MALAW'
WHERE [GroupId] = 1 AND [Id] = 108;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210423200057_Update_Malawyan', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [SystemDataTypes] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [PeoplesPhoneInformations] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [PeoplesInternetInformations] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Peoples] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [PeopleAttributions] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [PeopleAddresses] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ConfigGenericItems] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ConfigGenericItemExtentionValues] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ConfigGenericItemExtentions] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ConfigGenericGroups] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ColonyBuildings] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ColonyBuildingRooms] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Colonies] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

INSERT INTO [__EFMigrationsHistory]
    ([MigrationId], [ProductVersion])
VALUES
    (N'20210424145247_Add_IsDeleted_BaseEntity', N'5.0.5');
GO

COMMIT;
GO

