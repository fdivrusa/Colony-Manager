IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Accounts] (
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

CREATE TABLE [ConfigGenericGroups] (
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

CREATE TABLE [Countries] (
    [Id] int NOT NULL IDENTITY,
    [AlphaCode2] nvarchar(2) NULL,
    [AlphaCode3] nvarchar(3) NULL,
    [Description] nvarchar(64) NULL,
    [NumericCode] nvarchar(3) NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [SystemDataTypes] (
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

CREATE TABLE [RefreshToken] (
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

CREATE TABLE [ConfigGenericItems] (
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

CREATE TABLE [ConfigGenericItemExtentions] (
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

CREATE TABLE [Peoples] (
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

CREATE TABLE [ConfigGenericItemExtentionValues] (
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

CREATE TABLE [PeopleAddresses] (
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

CREATE TABLE [PeoplesInternetInformations] (
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

CREATE TABLE [PeoplesPhoneInformations] (
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

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES (1, N'AF', N'AFG', N'Afghanistan', N'4'),
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
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES (137, N'MT', N'MLT', N'Malta', N'470'),
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
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES (242, N'VG', N'VGB', N'Virgin Islands (British)', N'92'),
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
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES (33, N'BN', N'BRN', N'Brunei Darussalam', N'96'),
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
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES (13, N'AU', N'AUS', N'Australia', N'36'),
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
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [AlphaCode2], [AlphaCode3], [Description], [NumericCode])
VALUES (118, N'KP', N'PRK', N'Korea (the Democratic People''s Republic of)', N'408'),
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
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AlphaCode2', N'AlphaCode3', N'Description', N'NumericCode') AND [object_id] = OBJECT_ID(N'[Countries]'))
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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210331190735_Initial_Creation', N'5.0.1');
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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210401191032_Add_Type_PhoneAndInternetInformation', N'5.0.1');
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

CREATE TABLE [PeopleAttributions] (
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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210417154945_Add_People_Attributions', N'5.0.1');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [PeopleAttributions] DROP CONSTRAINT [FK_People_Attributions];
GO

ALTER TABLE [PeopleAttributions] ADD CONSTRAINT [FK_PeopleAttributions_Peoples] FOREIGN KEY ([PeopleId]) REFERENCES [Peoples] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210417204045_Rename_FK_People_Attribution', N'5.0.1');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Colonies] (
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

CREATE TABLE [ColonyBuildings] (
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

CREATE TABLE [ColonyBuildingRooms] (
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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210417220007_Add_Colony_tables', N'5.0.1');
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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210417220721_Solve_ColonyBuilding_Error', N'5.0.1');
GO

COMMIT;
GO

