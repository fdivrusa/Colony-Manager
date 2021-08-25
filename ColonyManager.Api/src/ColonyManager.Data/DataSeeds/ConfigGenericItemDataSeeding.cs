using ColonyManager.Data.Entities;
using System;

namespace ColonyManager.Data.DataSeeds
{
    public static class ConfigGenericItemDataSeeding
    {
        public static ConfigGenericItem[] GetData()
        {
            return new ConfigGenericItem[]
            {

                #region Nationalities
                new ConfigGenericItem
                {
                    Id = 0,
                    GroupId = 1,
                    Code = "UNK",
                    Description = "Unknown",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 1,
                    GroupId = 1,
                    Code = "AFG",
                    Description = "Afghan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 2,
                    GroupId = 1,
                    Code = "ALB",
                    Description = "Albanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 3,
                    GroupId = 1,
                    Code = "ALG",
                    Description = "Algerian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 4,
                    GroupId = 1,
                    Code = "AME",
                    Description = "American",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 5,
                    GroupId = 1,
                    Code = "AND",
                    Description = "Andorran",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 6,
                    GroupId = 1,
                    Code = "ANG",
                    Description = "Angolan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 7,
                    GroupId = 1,
                    Code = "ANT",
                    Description = "Antiguans",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 8,
                    GroupId = 1,
                    Code = "ARG",
                    Description = "Argentinean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 9,
                    GroupId = 1,
                    Code = "ARM",
                    Description = "Armenian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 10,
                    GroupId = 1,
                    Code = "AUS",
                    Description = "Australian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 11,
                    GroupId = 1,
                    Code = "AUST",
                    Description = "Austrian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 12,
                    GroupId = 1,
                    Code = "AZE",
                    Description = "Azerbaijani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 13,
                    GroupId = 1,
                    Code = "BAH",
                    Description = "Bahamian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 14,
                    GroupId = 1,
                    Code = "BAHR",
                    Description = "Bahraini",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 15,
                    GroupId = 1,
                    Code = "BAN",
                    Description = "Bangladeshi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 16,
                    GroupId = 1,
                    Code = "BAR",
                    Description = "Barbadian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 17,
                    GroupId = 1,
                    Code = "BARB",
                    Description = "Barbudans",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 18,
                    GroupId = 1,
                    Code = "BAT",
                    Description = "Batswana",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 19,
                    GroupId = 1,
                    Code = "BEL",
                    Description = "Belarusian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 20,
                    GroupId = 1,
                    Code = "BELG",
                    Description = "Belgian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 21,
                    GroupId = 1,
                    Code = "BELI",
                    Description = "Belizean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 22,
                    GroupId = 1,
                    Code = "BEN",
                    Description = "Beninese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 23,
                    GroupId = 1,
                    Code = "BHU",
                    Description = "Bhutanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 24,
                    GroupId = 1,
                    Code = "BOL",
                    Description = "Bolivian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 25,
                    GroupId = 1,
                    Code = "BOS",
                    Description = "Bosnian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 26,
                    GroupId = 1,
                    Code = "BRA",
                    Description = "Brazilian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 27,
                    GroupId = 1,
                    Code = "BRI",
                    Description = "British",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 28,
                    GroupId = 1,
                    Code = "BRU",
                    Description = "Bruneian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 29,
                    GroupId = 1,
                    Code = "BUL",
                    Description = "Bulgarian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 30,
                    GroupId = 1,
                    Code = "BUR",
                    Description = "Burkinabe",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 31,
                    GroupId = 1,
                    Code = "BURM",
                    Description = "Burmese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 32,
                    GroupId = 1,
                    Code = "BURU",
                    Description = "Burundian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 33,
                    GroupId = 1,
                    Code = "CAM",
                    Description = "Cambodian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 34,
                    GroupId = 1,
                    Code = "CAME",
                    Description = "Cameroonian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 35,
                    GroupId = 1,
                    Code = "CAN",
                    Description = "Canadian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 36,
                    GroupId = 1,
                    Code = "CAP",
                    Description = "Cape Verdean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 37,
                    GroupId = 1,
                    Code = "CEN",
                    Description = "Central African",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 38,
                    GroupId = 1,
                    Code = "CHA",
                    Description = "Chadian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 39,
                    GroupId = 1,
                    Code = "CHI",
                    Description = "Chilean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 40,
                    GroupId = 1,
                    Code = "CHIN",
                    Description = "Chinese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 41,
                    GroupId = 1,
                    Code = "COL",
                    Description = "Colombian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 42,
                    GroupId = 1,
                    Code = "COM",
                    Description = "Comoran",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 43,
                    GroupId = 1,
                    Code = "CON",
                    Description = "Congolese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 44,
                    GroupId = 1,
                    Code = "COS",
                    Description = "Costa Rican",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 45,
                    GroupId = 1,
                    Code = "CRO",
                    Description = "Croatian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 46,
                    GroupId = 1,
                    Code = "CUB",
                    Description = "Cuban",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 47,
                    GroupId = 1,
                    Code = "CYP",
                    Description = "Cypriot",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 48,
                    GroupId = 1,
                    Code = "CZE",
                    Description = "Czech",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 49,
                    GroupId = 1,
                    Code = "DAN",
                    Description = "Danish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 50,
                    GroupId = 1,
                    Code = "DJI",
                    Description = "Djibouti",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 51,
                    GroupId = 1,
                    Code = "DOM",
                    Description = "Dominican",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 52,
                    GroupId = 1,
                    Code = "DUT",
                    Description = "Dutch",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 53,
                    GroupId = 1,
                    Code = "EAS",
                    Description = "East Timorese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 54,
                    GroupId = 1,
                    Code = "ECU",
                    Description = "Ecuadorean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 55,
                    GroupId = 1,
                    Code = "EGY",
                    Description = "Egyptian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 56,
                    GroupId = 1,
                    Code = "EMI",
                    Description = "Emirian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 57,
                    GroupId = 1,
                    Code = "EQU",
                    Description = "Equatorial Guinean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 58,
                    GroupId = 1,
                    Code = "ERI",
                    Description = "Eritrean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 59,
                    GroupId = 1,
                    Code = "EST",
                    Description = "Estonian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 60,
                    GroupId = 1,
                    Code = "ETH",
                    Description = "Ethiopian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 61,
                    GroupId = 1,
                    Code = "FIJ",
                    Description = "Fijian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 62,
                    GroupId = 1,
                    Code = "FIL",
                    Description = "Filipino",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 63,
                    GroupId = 1,
                    Code = "FIN",
                    Description = "Finnish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 64,
                    GroupId = 1,
                    Code = "FRE",
                    Description = "French",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 65,
                    GroupId = 1,
                    Code = "GAB",
                    Description = "Gabonese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 66,
                    GroupId = 1,
                    Code = "GAM",
                    Description = "Gambian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 67,
                    GroupId = 1,
                    Code = "GEO",
                    Description = "Georgian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 68,
                    GroupId = 1,
                    Code = "GER",
                    Description = "German",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 69,
                    GroupId = 1,
                    Code = "GHA",
                    Description = "Ghanaian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 70,
                    GroupId = 1,
                    Code = "GRE",
                    Description = "Greek",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 71,
                    GroupId = 1,
                    Code = "GREN",
                    Description = "Grenadian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 72,
                    GroupId = 1,
                    Code = "GUA",
                    Description = "Guatemalan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 73,
                    GroupId = 1,
                    Code = "GUI",
                    Description = "Guinea-Bissauan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 74,
                    GroupId = 1,
                    Code = "GUIN",
                    Description = "Guinean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 75,
                    GroupId = 1,
                    Code = "GUY",
                    Description = "Guyanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 76,
                    GroupId = 1,
                    Code = "HAI",
                    Description = "Haitian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 77,
                    GroupId = 1,
                    Code = "HER",
                    Description = "Herzegovinian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 78,
                    GroupId = 1,
                    Code = "HON",
                    Description = "Honduran",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 79,
                    GroupId = 1,
                    Code = "HUN",
                    Description = "Hungarian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 80,
                    GroupId = 1,
                    Code = "I-K",
                    Description = "I-Kiribati",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 81,
                    GroupId = 1,
                    Code = "ICE",
                    Description = "Icelander",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 82,
                    GroupId = 1,
                    Code = "IND",
                    Description = "Indian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 83,
                    GroupId = 1,
                    Code = "INDO",
                    Description = "Indonesian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 84,
                    GroupId = 1,
                    Code = "IRA",
                    Description = "Iranian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 85,
                    GroupId = 1,
                    Code = "IRAQ",
                    Description = "Iraqi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 86,
                    GroupId = 1,
                    Code = "IRI",
                    Description = "Irish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 87,
                    GroupId = 1,
                    Code = "ISR",
                    Description = "Israeli",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 88,
                    GroupId = 1,
                    Code = "ITA",
                    Description = "Italian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 89,
                    GroupId = 1,
                    Code = "IVO",
                    Description = "Ivorian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 90,
                    GroupId = 1,
                    Code = "JAM",
                    Description = "Jamaican",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 91,
                    GroupId = 1,
                    Code = "JAP",
                    Description = "Japanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 92,
                    GroupId = 1,
                    Code = "JOR",
                    Description = "Jordanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 93,
                    GroupId = 1,
                    Code = "KAZ",
                    Description = "Kazakhstani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 94,
                    GroupId = 1,
                    Code = "KEN",
                    Description = "Kenyan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 95,
                    GroupId = 1,
                    Code = "KIT",
                    Description = "Kittian and Nevisian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 96,
                    GroupId = 1,
                    Code = "KUW",
                    Description = "Kuwaiti",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 97,
                    GroupId = 1,
                    Code = "KYR",
                    Description = "Kyrgyz",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 98,
                    GroupId = 1,
                    Code = "LAO",
                    Description = "Laotian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 99,
                    GroupId = 1,
                    Code = "LAT",
                    Description = "Latvian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 100,
                    GroupId = 1,
                    Code = "LEB",
                    Description = "Lebanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 101,
                    GroupId = 1,
                    Code = "LIB",
                    Description = "Liberian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 102,
                    GroupId = 1,
                    Code = "LIBY",
                    Description = "Libyan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 103,
                    GroupId = 1,
                    Code = "LIE",
                    Description = "Liechtensteiner",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 104,
                    GroupId = 1,
                    Code = "LIT",
                    Description = "Lithuanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 105,
                    GroupId = 1,
                    Code = "LUX",
                    Description = "Luxembourger",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 106,
                    GroupId = 1,
                    Code = "MAC",
                    Description = "Macedonian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 107,
                    GroupId = 1,
                    Code = "MAL",
                    Description = "Malagasy",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 108,
                    GroupId = 1,
                    Code = "MALAW",
                    Description = "Malawian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 109,
                    GroupId = 1,
                    Code = "MALA",
                    Description = "Malaysian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 110,
                    GroupId = 1,
                    Code = "MALD",
                    Description = "Maldivian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 111,
                    GroupId = 1,
                    Code = "MALI",
                    Description = "Malian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 112,
                    GroupId = 1,
                    Code = "MALT",
                    Description = "Maltese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 113,
                    GroupId = 1,
                    Code = "MAR",
                    Description = "Marshallese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 114,
                    GroupId = 1,
                    Code = "MAU",
                    Description = "Mauritanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 115,
                    GroupId = 1,
                    Code = "MAUR",
                    Description = "Mauritian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 116,
                    GroupId = 1,
                    Code = "MEX",
                    Description = "Mexican",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 117,
                    GroupId = 1,
                    Code = "MIC",
                    Description = "Micronesian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 118,
                    GroupId = 1,
                    Code = "MOL",
                    Description = "Moldovan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 119,
                    GroupId = 1,
                    Code = "MON",
                    Description = "Monacan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 120,
                    GroupId = 1,
                    Code = "MONG",
                    Description = "Mongolian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 121,
                    GroupId = 1,
                    Code = "MOR",
                    Description = "Moroccan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 122,
                    GroupId = 1,
                    Code = "MOS",
                    Description = "Mosotho",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 123,
                    GroupId = 1,
                    Code = "MOT",
                    Description = "Motswana",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 124,
                    GroupId = 1,
                    Code = "MOZ",
                    Description = "Mozambican",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 125,
                    GroupId = 1,
                    Code = "NAM",
                    Description = "Namibian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 126,
                    GroupId = 1,
                    Code = "NAU",
                    Description = "Nauruan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 127,
                    GroupId = 1,
                    Code = "NEP",
                    Description = "Nepalese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 128,
                    GroupId = 1,
                    Code = "NEW",
                    Description = "New Zealander",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 129,
                    GroupId = 1,
                    Code = "NI-",
                    Description = "Ni-Vanuatu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 130,
                    GroupId = 1,
                    Code = "NIC",
                    Description = "Nicaraguan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 131,
                    GroupId = 1,
                    Code = "NIG",
                    Description = "Nigerian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 132,
                    GroupId = 1,
                    Code = "NIGE",
                    Description = "Nigerien",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 133,
                    GroupId = 1,
                    Code = "NOR",
                    Description = "North Korean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 134,
                    GroupId = 1,
                    Code = "NORT",
                    Description = "Northern Irish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 135,
                    GroupId = 1,
                    Code = "NORW",
                    Description = "Norwegian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 136,
                    GroupId = 1,
                    Code = "OMA",
                    Description = "Omani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 137,
                    GroupId = 1,
                    Code = "PAK",
                    Description = "Pakistani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 138,
                    GroupId = 1,
                    Code = "PAL",
                    Description = "Palauan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 139,
                    GroupId = 1,
                    Code = "PAN",
                    Description = "Panamanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 140,
                    GroupId = 1,
                    Code = "PAP",
                    Description = "Papua New Guinean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 141,
                    GroupId = 1,
                    Code = "PAR",
                    Description = "Paraguayan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 142,
                    GroupId = 1,
                    Code = "PER",
                    Description = "Peruvian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 143,
                    GroupId = 1,
                    Code = "POL",
                    Description = "Polish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 144,
                    GroupId = 1,
                    Code = "POR",
                    Description = "Portuguese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 145,
                    GroupId = 1,
                    Code = "QAT",
                    Description = "Qatari",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 146,
                    GroupId = 1,
                    Code = "ROM",
                    Description = "Romanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 147,
                    GroupId = 1,
                    Code = "RUS",
                    Description = "Russian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 148,
                    GroupId = 1,
                    Code = "RWA",
                    Description = "Rwandan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 149,
                    GroupId = 1,
                    Code = "SAI",
                    Description = "Saint Lucian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 150,
                    GroupId = 1,
                    Code = "SAL",
                    Description = "Salvadoran",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 151,
                    GroupId = 1,
                    Code = "SAM",
                    Description = "Samoan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 152,
                    GroupId = 1,
                    Code = "SAN",
                    Description = "San Marinese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 153,
                    GroupId = 1,
                    Code = "SAO",
                    Description = "Sao Tomean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 154,
                    GroupId = 1,
                    Code = "SAU",
                    Description = "Saudi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 155,
                    GroupId = 1,
                    Code = "SCO",
                    Description = "Scottish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 156,
                    GroupId = 1,
                    Code = "SEN",
                    Description = "Senegalese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 157,
                    GroupId = 1,
                    Code = "SER",
                    Description = "Serbian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 158,
                    GroupId = 1,
                    Code = "SEY",
                    Description = "Seychellois",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 159,
                    GroupId = 1,
                    Code = "SIE",
                    Description = "Sierra Leonean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 160,
                    GroupId = 1,
                    Code = "SIN",
                    Description = "Singaporean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 161,
                    GroupId = 1,
                    Code = "SLO",
                    Description = "Slovakian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 162,
                    GroupId = 1,
                    Code = "SLOV",
                    Description = "Slovenian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 163,
                    GroupId = 1,
                    Code = "SOL",
                    Description = "Solomon Islander",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 164,
                    GroupId = 1,
                    Code = "SOM",
                    Description = "Somali",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 165,
                    GroupId = 1,
                    Code = "SOU",
                    Description = "South African",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 166,
                    GroupId = 1,
                    Code = "SOUT",
                    Description = "South Korean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 167,
                    GroupId = 1,
                    Code = "SPA",
                    Description = "Spanish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 168,
                    GroupId = 1,
                    Code = "SRI",
                    Description = "Sri Lankan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 169,
                    GroupId = 1,
                    Code = "SUD",
                    Description = "Sudanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 170,
                    GroupId = 1,
                    Code = "SUR",
                    Description = "Surinamer",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 171,
                    GroupId = 1,
                    Code = "SWA",
                    Description = "Swazi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 172,
                    GroupId = 1,
                    Code = "SWE",
                    Description = "Swedish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 173,
                    GroupId = 1,
                    Code = "SWI",
                    Description = "Swiss",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 174,
                    GroupId = 1,
                    Code = "SYR",
                    Description = "Syrian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 175,
                    GroupId = 1,
                    Code = "TAI",
                    Description = "Taiwanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 176,
                    GroupId = 1,
                    Code = "TAJ",
                    Description = "Tajik",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 177,
                    GroupId = 1,
                    Code = "TAN",
                    Description = "Tanzanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 178,
                    GroupId = 1,
                    Code = "THA",
                    Description = "Thai",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 179,
                    GroupId = 1,
                    Code = "TOG",
                    Description = "Togolese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 180,
                    GroupId = 1,
                    Code = "TON",
                    Description = "Tongan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 181,
                    GroupId = 1,
                    Code = "TRI",
                    Description = "Trinidadian or Tobagonian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 182,
                    GroupId = 1,
                    Code = "TUN",
                    Description = "Tunisian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 183,
                    GroupId = 1,
                    Code = "TUR",
                    Description = "Turkish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 184,
                    GroupId = 1,
                    Code = "TUV",
                    Description = "Tuvaluan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 185,
                    GroupId = 1,
                    Code = "UGA",
                    Description = "Ugandan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 186,
                    GroupId = 1,
                    Code = "UKR",
                    Description = "Ukrainian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 187,
                    GroupId = 1,
                    Code = "URUG",
                    Description = "Uruguayan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 188,
                    GroupId = 1,
                    Code = "UZB",
                    Description = "Uzbekistani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 189,
                    GroupId = 1,
                    Code = "VEN",
                    Description = "Venezuelan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 190,
                    GroupId = 1,
                    Code = "VIE",
                    Description = "Vietnamese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 191,
                    GroupId = 1,
                    Code = "WEL",
                    Description = "Welsh",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 192,
                    GroupId = 1,
                    Code = "YEM",
                    Description = "Yemenite",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 193,
                    GroupId = 1,
                    Code = "ZAM",
                    Description = "Zambian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                new ConfigGenericItem
                {
                    Id = 194,
                    GroupId = 1,
                    Code = "ZIM",
                    Description = "Zimbabwean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                },
                #endregion
                #region Countries
                new ConfigGenericItem
                {
                    Id = 0,
                    GroupId = 2,
                    Code = "Unknown",
                    Description = "UNK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 1,
                    GroupId = 2,
                    Code = "Afghanistan",
                    Description = "AF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 2,
                    GroupId = 2,
                    Code = "Åland Islands",
                    Description = "AX",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 3,
                    GroupId = 2,
                    Code = "Albania",
                    Description = "AL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 4,
                    GroupId = 2,
                    Code = "Algeria",
                    Description = "DZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 5,
                    GroupId = 2,
                    Code = "American Samoa",
                    Description = "AS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 6,
                    GroupId = 2,
                    Code = "Andorra",
                    Description = "AD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 7,
                    GroupId = 2,
                    Code = "Angola",
                    Description = "AO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 8,
                    GroupId = 2,
                    Code = "Anguilla",
                    Description = "AI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 9,
                    GroupId = 2,
                    Code = "Antarctica",
                    Description = "AQ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 10,
                    GroupId = 2,
                    Code = "Antigua and Barbuda",
                    Description = "AG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 11,
                    GroupId = 2,
                    Code = "Argentina",
                    Description = "AR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 12,
                    GroupId = 2,
                    Code = "Armenia",
                    Description = "AM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 13,
                    GroupId = 2,
                    Code = "Aruba",
                    Description = "AW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 14,
                    GroupId = 2,
                    Code = "Australia",
                    Description = "AU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 15,
                    GroupId = 2,
                    Code = "Austria",
                    Description = "AT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 16,
                    GroupId = 2,
                    Code = "Azerbaijan",
                    Description = "AZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 17,
                    GroupId = 2,
                    Code = "Bahrain",
                    Description = "BH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 18,
                    GroupId = 2,
                    Code = "Bahamas",
                    Description = "BS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 19,
                    GroupId = 2,
                    Code = "Bangladesh",
                    Description = "BD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 20,
                    GroupId = 2,
                    Code = "Barbados",
                    Description = "BB",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 21,
                    GroupId = 2,
                    Code = "Belarus",
                    Description = "BY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 22,
                    GroupId = 2,
                    Code = "Belgium",
                    Description = "BE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 23,
                    GroupId = 2,
                    Code = "Belize",
                    Description = "BZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 24,
                    GroupId = 2,
                    Code = "Benin",
                    Description = "BJ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 25,
                    GroupId = 2,
                    Code = "Bermuda",
                    Description = "BM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 26,
                    GroupId = 2,
                    Code = "Bhutan",
                    Description = "BT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 27,
                    GroupId = 2,
                    Code = "Bolivia, Plurinational State of",
                    Description = "BO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 28,
                    GroupId = 2,
                    Code = "Bonaire, Sint Eustatius and Saba",
                    Description = "BQ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 29,
                    GroupId = 2,
                    Code = "Bosnia and Herzegovina",
                    Description = "BA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 30,
                    GroupId = 2,
                    Code = "Botswana",
                    Description = "BW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 31,
                    GroupId = 2,
                    Code = "Bouvet Island",
                    Description = "BV",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 32,
                    GroupId = 2,
                    Code = "Brazil",
                    Description = "BR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 33,
                    GroupId = 2,
                    Code = "British Indian Ocean Territory",
                    Description = "IO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 34,
                    GroupId = 2,
                    Code = "Brunei Darussalam",
                    Description = "BN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 35,
                    GroupId = 2,
                    Code = "Bulgaria",
                    Description = "BG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 36,
                    GroupId = 2,
                    Code = "Burkina Faso",
                    Description = "BF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 37,
                    GroupId = 2,
                    Code = "Burundi",
                    Description = "BI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 38,
                    GroupId = 2,
                    Code = "Cambodia",
                    Description = "KH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 39,
                    GroupId = 2,
                    Code = "Cameroon",
                    Description = "CM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 40,
                    GroupId = 2,
                    Code = "Canada",
                    Description = "CA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 41,
                    GroupId = 2,
                    Code = "Cape Verde",
                    Description = "CV",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 42,
                    GroupId = 2,
                    Code = "Cayman Islands",
                    Description = "KY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 43,
                    GroupId = 2,
                    Code = "Central African Republic",
                    Description = "CF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 44,
                    GroupId = 2,
                    Code = "Chad",
                    Description = "TD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 45,
                    GroupId = 2,
                    Code = "Chile",
                    Description = "CL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 46,
                    GroupId = 2,
                    Code = "China",
                    Description = "CN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 47,
                    GroupId = 2,
                    Code = "Christmas Island",
                    Description = "CX",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 48,
                    GroupId = 2,
                    Code = "Cocos (Keeling) Islands",
                    Description = "CC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 49,
                    GroupId = 2,
                    Code = "Colombia",
                    Description = "CO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 50,
                    GroupId = 2,
                    Code = "Comoros",
                    Description = "KM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 51,
                    GroupId = 2,
                    Code = "Congo",
                    Description = "CG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 52,
                    GroupId = 2,
                    Code = "Congo, the Democratic Republic of the",
                    Description = "CD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 53,
                    GroupId = 2,
                    Code = "Cook Islands",
                    Description = "CK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 54,
                    GroupId = 2,
                    Code = "Costa Rica",
                    Description = "CR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 55,
                    GroupId = 2,
                    Code = "Côte d'Ivoire",
                    Description = "CI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 56,
                    GroupId = 2,
                    Code = "Croatia",
                    Description = "HR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 57,
                    GroupId = 2,
                    Code = "Cuba",
                    Description = "CU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 58,
                    GroupId = 2,
                    Code = "Curaçao",
                    Description = "CW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 59,
                    GroupId = 2,
                    Code = "Cyprus",
                    Description = "CY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 60,
                    GroupId = 2,
                    Code = "Czech Republic",
                    Description = "CZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 61,
                    GroupId = 2,
                    Code = "Denmark",
                    Description = "DK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 62,
                    GroupId = 2,
                    Code = "Djibouti",
                    Description = "DJ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 63,
                    GroupId = 2,
                    Code = "Dominica",
                    Description = "DM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 64,
                    GroupId = 2,
                    Code = "Dominican Republic",
                    Description = "DO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 65,
                    GroupId = 2,
                    Code = "Ecuador",
                    Description = "EC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 66,
                    GroupId = 2,
                    Code = "Egypt",
                    Description = "EG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 67,
                    GroupId = 2,
                    Code = "El Salvador",
                    Description = "SV",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 68,
                    GroupId = 2,
                    Code = "Equatorial Guinea",
                    Description = "GQ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 69,
                    GroupId = 2,
                    Code = "Eritrea",
                    Description = "ER",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 70,
                    GroupId = 2,
                    Code = "Estonia",
                    Description = "EE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 71,
                    GroupId = 2,
                    Code = "Ethiopia",
                    Description = "ET",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 72,
                    GroupId = 2,
                    Code = "Falkland Islands (Malvinas)",
                    Description = "FK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 73,
                    GroupId = 2,
                    Code = "Faroe Islands",
                    Description = "FO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 74,
                    GroupId = 2,
                    Code = "Fiji",
                    Description = "FJ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 75,
                    GroupId = 2,
                    Code = "Finland",
                    Description = "FI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 76,
                    GroupId = 2,
                    Code = "France",
                    Description = "FR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 77,
                    GroupId = 2,
                    Code = "French Guiana",
                    Description = "GF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 78,
                    GroupId = 2,
                    Code = "French Polynesia",
                    Description = "PF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 79,
                    GroupId = 2,
                    Code = "French Southern Territories",
                    Description = "TF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 80,
                    GroupId = 2,
                    Code = "Gabon",
                    Description = "GA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 81,
                    GroupId = 2,
                    Code = "Gambia",
                    Description = "GM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 82,
                    GroupId = 2,
                    Code = "Georgia",
                    Description = "GE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 83,
                    GroupId = 2,
                    Code = "Germany",
                    Description = "DE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 84,
                    GroupId = 2,
                    Code = "Ghana",
                    Description = "GH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 85,
                    GroupId = 2,
                    Code = "Gibraltar",
                    Description = "GI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 86,
                    GroupId = 2,
                    Code = "Greece",
                    Description = "GR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 87,
                    GroupId = 2,
                    Code = "Greenland",
                    Description = "GL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 88,
                    GroupId = 2,
                    Code = "Grenada",
                    Description = "GD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 89,
                    GroupId = 2,
                    Code = "Guadeloupe",
                    Description = "GP",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 90,
                    GroupId = 2,
                    Code = "Guam",
                    Description = "GU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 91,
                    GroupId = 2,
                    Code = "Guatemala",
                    Description = "GT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 92,
                    GroupId = 2,
                    Code = "Guernsey",
                    Description = "GG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 93,
                    GroupId = 2,
                    Code = "Guinea",
                    Description = "GN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 94,
                    GroupId = 2,
                    Code = "Guinea-Bissau",
                    Description = "GW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 95,
                    GroupId = 2,
                    Code = "Guyana",
                    Description = "GY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 96,
                    GroupId = 2,
                    Code = "Haiti",
                    Description = "HT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 97,
                    GroupId = 2,
                    Code = "Heard Island and McDonald Islands",
                    Description = "HM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 98,
                    GroupId = 2,
                    Code = "Holy See (Vatican City State)",
                    Description = "VA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 99,
                    GroupId = 2,
                    Code = "Honduras",
                    Description = "HN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 100,
                    GroupId = 2,
                    Code = "Hong Kong",
                    Description = "HK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 101,
                    GroupId = 2,
                    Code = "Hungary",
                    Description = "HU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 102,
                    GroupId = 2,
                    Code = "Iceland",
                    Description = "IS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 103,
                    GroupId = 2,
                    Code = "India",
                    Description = "IN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 104,
                    GroupId = 2,
                    Code = "Indonesia",
                    Description = "ID",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 105,
                    GroupId = 2,
                    Code = "Iran, Islamic Republic of",
                    Description = "IR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 106,
                    GroupId = 2,
                    Code = "Iraq",
                    Description = "IQ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 107,
                    GroupId = 2,
                    Code = "Ireland",
                    Description = "IE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 108,
                    GroupId = 2,
                    Code = "Isle of Man",
                    Description = "IM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 109,
                    GroupId = 2,
                    Code = "Israel",
                    Description = "IL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 110,
                    GroupId = 2,
                    Code = "Italy",
                    Description = "IT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 111,
                    GroupId = 2,
                    Code = "Jamaica",
                    Description = "JM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 112,
                    GroupId = 2,
                    Code = "Japan",
                    Description = "JP",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 113,
                    GroupId = 2,
                    Code = "Jersey",
                    Description = "JE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 114,
                    GroupId = 2,
                    Code = "Jordan",
                    Description = "JO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 115,
                    GroupId = 2,
                    Code = "Kazakhstan",
                    Description = "KZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 116,
                    GroupId = 2,
                    Code = "Kenya",
                    Description = "KE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 117,
                    GroupId = 2,
                    Code = "Kiribati",
                    Description = "KI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 118,
                    GroupId = 2,
                    Code = "Korea, Democratic People's Republic of",
                    Description = "KP",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 119,
                    GroupId = 2,
                    Code = "Korea, Republic of",
                    Description = "KR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 120,
                    GroupId = 2,
                    Code = "Kuwait",
                    Description = "KW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 121,
                    GroupId = 2,
                    Code = "Kyrgyzstan",
                    Description = "KG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 122,
                    GroupId = 2,
                    Code = "Lao People's Democratic Republic",
                    Description = "LA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 123,
                    GroupId = 2,
                    Code = "Latvia",
                    Description = "LV",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 124,
                    GroupId = 2,
                    Code = "Lebanon",
                    Description = "LB",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 125,
                    GroupId = 2,
                    Code = "Lesotho",
                    Description = "LS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 126,
                    GroupId = 2,
                    Code = "Liberia",
                    Description = "LR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 127,
                    GroupId = 2,
                    Code = "Libya",
                    Description = "LY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 128,
                    GroupId = 2,
                    Code = "Liechtenstein",
                    Description = "LI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 129,
                    GroupId = 2,
                    Code = "Lithuania",
                    Description = "LT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 130,
                    GroupId = 2,
                    Code = "Luxembourg",
                    Description = "LU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 131,
                    GroupId = 2,
                    Code = "Macao",
                    Description = "MO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 132,
                    GroupId = 2,
                    Code = "Macedonia, the Former Yugoslav Republic of",
                    Description = "MK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 133,
                    GroupId = 2,
                    Code = "Madagascar",
                    Description = "MG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 134,
                    GroupId = 2,
                    Code = "Malawi",
                    Description = "MW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 135,
                    GroupId = 2,
                    Code = "Malaysia",
                    Description = "MY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 136,
                    GroupId = 2,
                    Code = "Maldives",
                    Description = "MV",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 137,
                    GroupId = 2,
                    Code = "Mali",
                    Description = "ML",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 138,
                    GroupId = 2,
                    Code = "Malta",
                    Description = "MT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 139,
                    GroupId = 2,
                    Code = "Marshall Islands",
                    Description = "MH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 140,
                    GroupId = 2,
                    Code = "Martinique",
                    Description = "MQ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 141,
                    GroupId = 2,
                    Code = "Mauritania",
                    Description = "MR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 142,
                    GroupId = 2,
                    Code = "Mauritius",
                    Description = "MU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 143,
                    GroupId = 2,
                    Code = "Mayotte",
                    Description = "YT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 144,
                    GroupId = 2,
                    Code = "Mexico",
                    Description = "MX",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 145,
                    GroupId = 2,
                    Code = "Micronesia, Federated States of",
                    Description = "FM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 146,
                    GroupId = 2,
                    Code = "Moldova, Republic of",
                    Description = "MD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 147,
                    GroupId = 2,
                    Code = "Monaco",
                    Description = "MC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 148,
                    GroupId = 2,
                    Code = "Mongolia",
                    Description = "MN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 149,
                    GroupId = 2,
                    Code = "Montenegro",
                    Description = "ME",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 150,
                    GroupId = 2,
                    Code = "Montserrat",
                    Description = "MS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 151,
                    GroupId = 2,
                    Code = "Morocco",
                    Description = "MA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 152,
                    GroupId = 2,
                    Code = "Mozambique",
                    Description = "MZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 153,
                    GroupId = 2,
                    Code = "Myanmar",
                    Description = "MM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 154,
                    GroupId = 2,
                    Code = "Namibia",
                    Description = "NA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 155,
                    GroupId = 2,
                    Code = "Nauru",
                    Description = "NR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 156,
                    GroupId = 2,
                    Code = "Nepal",
                    Description = "NP",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 157,
                    GroupId = 2,
                    Code = "Netherlands",
                    Description = "NL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 158,
                    GroupId = 2,
                    Code = "New Caledonia",
                    Description = "NC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 159,
                    GroupId = 2,
                    Code = "New Zealand",
                    Description = "NZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 160,
                    GroupId = 2,
                    Code = "Nicaragua",
                    Description = "NI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 161,
                    GroupId = 2,
                    Code = "Niger",
                    Description = "NE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 162,
                    GroupId = 2,
                    Code = "Nigeria",
                    Description = "NG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 163,
                    GroupId = 2,
                    Code = "Niue",
                    Description = "NU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 164,
                    GroupId = 2,
                    Code = "Norfolk Island",
                    Description = "NF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 165,
                    GroupId = 2,
                    Code = "Northern Mariana Islands",
                    Description = "MP",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 166,
                    GroupId = 2,
                    Code = "Norway",
                    Description = "NO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 167,
                    GroupId = 2,
                    Code = "Oman",
                    Description = "OM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 168,
                    GroupId = 2,
                    Code = "Pakistan",
                    Description = "PK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 169,
                    GroupId = 2,
                    Code = "Palau",
                    Description = "PW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 170,
                    GroupId = 2,
                    Code = "Palestine, State of",
                    Description = "PS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 171,
                    GroupId = 2,
                    Code = "Panama",
                    Description = "PA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 172,
                    GroupId = 2,
                    Code = "Papua New Guinea",
                    Description = "PG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 173,
                    GroupId = 2,
                    Code = "Paraguay",
                    Description = "PY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 174,
                    GroupId = 2,
                    Code = "Peru",
                    Description = "PE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 175,
                    GroupId = 2,
                    Code = "Philippines",
                    Description = "PH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 176,
                    GroupId = 2,
                    Code = "Pitcairn",
                    Description = "PN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 177,
                    GroupId = 2,
                    Code = "Poland",
                    Description = "PL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 178,
                    GroupId = 2,
                    Code = "Portugal",
                    Description = "PT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 179,
                    GroupId = 2,
                    Code = "Puerto Rico",
                    Description = "PR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 180,
                    GroupId = 2,
                    Code = "Qatar",
                    Description = "QA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 181,
                    GroupId = 2,
                    Code = "Réunion",
                    Description = "RE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 182,
                    GroupId = 2,
                    Code = "Romania",
                    Description = "RO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 183,
                    GroupId = 2,
                    Code = "Russian Federation",
                    Description = "RU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 184,
                    GroupId = 2,
                    Code = "Rwanda",
                    Description = "RW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 185,
                    GroupId = 2,
                    Code = "Saint Barthélemy",
                    Description = "BL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 186,
                    GroupId = 2,
                    Code = "Saint Helena, Ascension and Tristan da Cunha",
                    Description = "SH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 187,
                    GroupId = 2,
                    Code = "Saint Kitts and Nevis",
                    Description = "KN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 188,
                    GroupId = 2,
                    Code = "Saint Lucia",
                    Description = "LC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 189,
                    GroupId = 2,
                    Code = "Saint Martin (French part)",
                    Description = "MF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 190,
                    GroupId = 2,
                    Code = "Saint Pierre and Miquelon",
                    Description = "PM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 191,
                    GroupId = 2,
                    Code = "Saint Vincent and the Grenadines",
                    Description = "VC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 192,
                    GroupId = 2,
                    Code = "Samoa",
                    Description = "WS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 193,
                    GroupId = 2,
                    Code = "San Marino",
                    Description = "SM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 194,
                    GroupId = 2,
                    Code = "Sao Tome and Principe",
                    Description = "ST",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 195,
                    GroupId = 2,
                    Code = "Saudi Arabia",
                    Description = "SA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 196,
                    GroupId = 2,
                    Code = "Senegal",
                    Description = "SN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 197,
                    GroupId = 2,
                    Code = "Serbia",
                    Description = "RS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 198,
                    GroupId = 2,
                    Code = "Seychelles",
                    Description = "SC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 199,
                    GroupId = 2,
                    Code = "Sierra Leone",
                    Description = "SL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 200,
                    GroupId = 2,
                    Code = "Singapore",
                    Description = "SG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 201,
                    GroupId = 2,
                    Code = "Sint Maarten (Dutch part)",
                    Description = "SX",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 202,
                    GroupId = 2,
                    Code = "Slovakia",
                    Description = "SK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 203,
                    GroupId = 2,
                    Code = "Slovenia",
                    Description = "SI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 204,
                    GroupId = 2,
                    Code = "Solomon Islands",
                    Description = "SB",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 205,
                    GroupId = 2,
                    Code = "Somalia",
                    Description = "SO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 206,
                    GroupId = 2,
                    Code = "South Africa",
                    Description = "ZA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 207,
                    GroupId = 2,
                    Code = "South Georgia and the South Sandwich Islands",
                    Description = "GS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 208,
                    GroupId = 2,
                    Code = "South Sudan",
                    Description = "SS",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 209,
                    GroupId = 2,
                    Code = "Spain",
                    Description = "ES",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 210,
                    GroupId = 2,
                    Code = "Sri Lanka",
                    Description = "LK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 211,
                    GroupId = 2,
                    Code = "Sudan",
                    Description = "SD",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 212,
                    GroupId = 2,
                    Code = "Suriname",
                    Description = "SR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 213,
                    GroupId = 2,
                    Code = "Svalbard and Jan Mayen",
                    Description = "SJ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 214,
                    GroupId = 2,
                    Code = "Swaziland",
                    Description = "SZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 215,
                    GroupId = 2,
                    Code = "Sweden",
                    Description = "SE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 216,
                    GroupId = 2,
                    Code = "Switzerland",
                    Description = "CH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 217,
                    GroupId = 2,
                    Code = "Syrian Arab Republic",
                    Description = "SY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 218,
                    GroupId = 2,
                    Code = "Taiwan, Province of China",
                    Description = "TW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 219,
                    GroupId = 2,
                    Code = "Tajikistan",
                    Description = "TJ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 220,
                    GroupId = 2,
                    Code = "Tanzania, United Republic of",
                    Description = "TZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 221,
                    GroupId = 2,
                    Code = "Thailand",
                    Description = "TH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 222,
                    GroupId = 2,
                    Code = "Timor-Leste",
                    Description = "TL",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 223,
                    GroupId = 2,
                    Code = "Togo",
                    Description = "TG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 224,
                    GroupId = 2,
                    Code = "Tokelau",
                    Description = "TK",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 225,
                    GroupId = 2,
                    Code = "Tonga",
                    Description = "TO",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 226,
                    GroupId = 2,
                    Code = "Trinidad and Tobago",
                    Description = "TT",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 227,
                    GroupId = 2,
                    Code = "Tunisia",
                    Description = "TN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 228,
                    GroupId = 2,
                    Code = "Turkey",
                    Description = "TR",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 229,
                    GroupId = 2,
                    Code = "Turkmenistan",
                    Description = "TM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 230,
                    GroupId = 2,
                    Code = "Turks and Caicos Islands",
                    Description = "TC",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 231,
                    GroupId = 2,
                    Code = "Tuvalu",
                    Description = "TV",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 232,
                    GroupId = 2,
                    Code = "Uganda",
                    Description = "UG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 233,
                    GroupId = 2,
                    Code = "Ukraine",
                    Description = "UA",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 234,
                    GroupId = 2,
                    Code = "United Arab Emirates",
                    Description = "AE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 235,
                    GroupId = 2,
                    Code = "United Kingdom",
                    Description = "GB",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 236,
                    GroupId = 2,
                    Code = "United States",
                    Description = "US",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 237,
                    GroupId = 2,
                    Code = "United States Minor Outlying Islands",
                    Description = "UM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 238,
                    GroupId = 2,
                    Code = "Uruguay",
                    Description = "UY",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 239,
                    GroupId = 2,
                    Code = "Uzbekistan",
                    Description = "UZ",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 240,
                    GroupId = 2,
                    Code = "Vanuatu",
                    Description = "VU",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 241,
                    GroupId = 2,
                    Code = "Venezuela, Bolivarian Republic of",
                    Description = "VE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 242,
                    GroupId = 2,
                    Code = "Viet Nam",
                    Description = "VN",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 243,
                    GroupId = 2,
                    Code = "Virgin Islands, British",
                    Description = "VG",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 244,
                    GroupId = 2,
                    Code = "Virgin Islands, U.S.",
                    Description = "VI",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 245,
                    GroupId = 2,
                    Code = "Wallis and Futuna",
                    Description = "WF",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 246,
                    GroupId = 2,
                    Code = "Western Sahara",
                    Description = "EH",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 247,
                    GroupId = 2,
                    Code = "Yemen",
                    Description = "YE",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 248,
                    GroupId = 2,
                    Code = "Zambia",
                    Description = "ZM",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 249,
                    GroupId = 2,
                    Code = "Zimbabwe",
                    Description = "ZW",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                #endregion
                #region Languages
                                new ConfigGenericItem
                {
                    Id = 0,
                    GroupId = 3,
                    Code = "UNK",
                    Description = "Unknown",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 1,
                    GroupId = 3,
                    Code = "AA",
                    Description = "Afar",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 2,
                    GroupId = 3,
                    Code = "AB",
                    Description = "Abkhazian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 3,
                    GroupId = 3,
                    Code = "AE",
                    Description = "Avestan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 4,
                    GroupId = 3,
                    Code = "AF",
                    Description = "Afrikaans",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 5,
                    GroupId = 3,
                    Code = "AK",
                    Description = "Akan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 6,
                    GroupId = 3,
                    Code = "AM",
                    Description = "Amharic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 7,
                    GroupId = 3,
                    Code = "AN",
                    Description = "Aragonese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 8,
                    GroupId = 3,
                    Code = "AR",
                    Description = "Arabic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 9,
                    GroupId = 3,
                    Code = "AS",
                    Description = "Assamese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 10,
                    GroupId = 3,
                    Code = "AV",
                    Description = "Avaric",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 11,
                    GroupId = 3,
                    Code = "AY",
                    Description = "Aymara",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 12,
                    GroupId = 3,
                    Code = "AZ",
                    Description = "Azerbaijani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 13,
                    GroupId = 3,
                    Code = "BA",
                    Description = "Bashkir",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 14,
                    GroupId = 3,
                    Code = "BE",
                    Description = "Belarusian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 15,
                    GroupId = 3,
                    Code = "BG",
                    Description = "Bulgarian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 16,
                    GroupId = 3,
                    Code = "BH",
                    Description = "Bihari languages",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 17,
                    GroupId = 3,
                    Code = "BM",
                    Description = "Bambara",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 18,
                    GroupId = 3,
                    Code = "BI",
                    Description = "Bislama",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 19,
                    GroupId = 3,
                    Code = "BN",
                    Description = "Bengali",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 20,
                    GroupId = 3,
                    Code = "BO",
                    Description = "Tibetan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 21,
                    GroupId = 3,
                    Code = "BR",
                    Description = "Breton",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 22,
                    GroupId = 3,
                    Code = "BS",
                    Description = "Bosnian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 23,
                    GroupId = 3,
                    Code = "CA",
                    Description = "Catalan; Valencian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 24,
                    GroupId = 3,
                    Code = "CE",
                    Description = "Chechen",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 25,
                    GroupId = 3,
                    Code = "CH",
                    Description = "Chamorro",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 26,
                    GroupId = 3,
                    Code = "CO",
                    Description = "Corsican",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 27,
                    GroupId = 3,
                    Code = "CR",
                    Description = "Cree",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 28,
                    GroupId = 3,
                    Code = "CS",
                    Description = "Czech",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 29,
                    GroupId = 3,
                    Code = "CU",
                    Description = "Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 30,
                    GroupId = 3,
                    Code = "CV",
                    Description = "Chuvash",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 31,
                    GroupId = 3,
                    Code = "CY",
                    Description = "Welsh",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 32,
                    GroupId = 3,
                    Code = "DA",
                    Description = "Danish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 33,
                    GroupId = 3,
                    Code = "DE",
                    Description = "German",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 34,
                    GroupId = 3,
                    Code = "DV",
                    Description = "Divehi; Dhivehi; Maldivian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 35,
                    GroupId = 3,
                    Code = "DZ",
                    Description = "Dzongkha",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 36,
                    GroupId = 3,
                    Code = "EE",
                    Description = "Ewe",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 37,
                    GroupId = 3,
                    Code = "EL",
                    Description = "Greek, Modern (1453-)",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 38,
                    GroupId = 3,
                    Code = "EN",
                    Description = "English",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 39,
                    GroupId = 3,
                    Code = "EO",
                    Description = "Esperanto",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 40,
                    GroupId = 3,
                    Code = "ES",
                    Description = "Spanish; Castilian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 41,
                    GroupId = 3,
                    Code = "ET",
                    Description = "Estonian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 42,
                    GroupId = 3,
                    Code = "EU",
                    Description = "Basque",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 43,
                    GroupId = 3,
                    Code = "FA",
                    Description = "Persian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 44,
                    GroupId = 3,
                    Code = "FF",
                    Description = "Fulah",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 45,
                    GroupId = 3,
                    Code = "FI",
                    Description = "Finnish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 46,
                    GroupId = 3,
                    Code = "FJ",
                    Description = "Fijian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 47,
                    GroupId = 3,
                    Code = "FO",
                    Description = "Faroese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 48,
                    GroupId = 3,
                    Code = "FR",
                    Description = "French",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 49,
                    GroupId = 3,
                    Code = "FY",
                    Description = "Western Frisian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 50,
                    GroupId = 3,
                    Code = "GA",
                    Description = "Irish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 51,
                    GroupId = 3,
                    Code = "GD",
                    Description = "Gaelic; Scottish Gaelic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 52,
                    GroupId = 3,
                    Code = "GL",
                    Description = "Galician",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 53,
                    GroupId = 3,
                    Code = "GN",
                    Description = "Guarani",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 54,
                    GroupId = 3,
                    Code = "GU",
                    Description = "Gujarati",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 55,
                    GroupId = 3,
                    Code = "GV",
                    Description = "Manx",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 56,
                    GroupId = 3,
                    Code = "HA",
                    Description = "Hausa",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 57,
                    GroupId = 3,
                    Code = "HE",
                    Description = "Hebrew",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 58,
                    GroupId = 3,
                    Code = "HI",
                    Description = "Hindi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 59,
                    GroupId = 3,
                    Code = "HO",
                    Description = "Hiri Motu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 60,
                    GroupId = 3,
                    Code = "HR",
                    Description = "Croatian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 61,
                    GroupId = 3,
                    Code = "HT",
                    Description = "Haitian; Haitian Creole",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 62,
                    GroupId = 3,
                    Code = "HU",
                    Description = "Hungarian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 63,
                    GroupId = 3,
                    Code = "HY",
                    Description = "Armenian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 64,
                    GroupId = 3,
                    Code = "HZ",
                    Description = "Herero",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 65,
                    GroupId = 3,
                    Code = "IA",
                    Description = "Interlingua (International Auxiliary Language Association)",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 66,
                    GroupId = 3,
                    Code = "ID",
                    Description = "Indonesian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 67,
                    GroupId = 3,
                    Code = "IE",
                    Description = "Interlingue; Occidental",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 68,
                    GroupId = 3,
                    Code = "IG",
                    Description = "Igbo",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 69,
                    GroupId = 3,
                    Code = "II",
                    Description = "Sichuan Yi; Nuosu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 70,
                    GroupId = 3,
                    Code = "IK",
                    Description = "Inupiaq",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 71,
                    GroupId = 3,
                    Code = "IO",
                    Description = "Ido",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 72,
                    GroupId = 3,
                    Code = "IS",
                    Description = "Icelandic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 73,
                    GroupId = 3,
                    Code = "IT",
                    Description = "Italian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 74,
                    GroupId = 3,
                    Code = "IU",
                    Description = "Inuktitut",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 75,
                    GroupId = 3,
                    Code = "JA",
                    Description = "Japanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 76,
                    GroupId = 3,
                    Code = "JV",
                    Description = "Javanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 77,
                    GroupId = 3,
                    Code = "KA",
                    Description = "Georgian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 78,
                    GroupId = 3,
                    Code = "KG",
                    Description = "Kongo",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 79,
                    GroupId = 3,
                    Code = "KI",
                    Description = "Kikuyu; Gikuyu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 80,
                    GroupId = 3,
                    Code = "KJ",
                    Description = "Kuanyama; Kwanyama",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 81,
                    GroupId = 3,
                    Code = "KK",
                    Description = "Kazakh",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 82,
                    GroupId = 3,
                    Code = "KL",
                    Description = "Kalaallisut; Greenlandic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 83,
                    GroupId = 3,
                    Code = "KM",
                    Description = "Central Khmer",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 84,
                    GroupId = 3,
                    Code = "KN",
                    Description = "Kannada",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 85,
                    GroupId = 3,
                    Code = "KO",
                    Description = "Korean",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 86,
                    GroupId = 3,
                    Code = "KR",
                    Description = "Kanuri",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 87,
                    GroupId = 3,
                    Code = "KS",
                    Description = "Kashmiri",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 88,
                    GroupId = 3,
                    Code = "KU",
                    Description = "Kurdish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 89,
                    GroupId = 3,
                    Code = "KV",
                    Description = "Komi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 90,
                    GroupId = 3,
                    Code = "KW",
                    Description = "Cornish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 91,
                    GroupId = 3,
                    Code = "KY",
                    Description = "Kirghiz; Kyrgyz",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 92,
                    GroupId = 3,
                    Code = "LA",
                    Description = "Latin",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 93,
                    GroupId = 3,
                    Code = "LB",
                    Description = "Luxembourgish; Letzeburgesch",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 94,
                    GroupId = 3,
                    Code = "LG",
                    Description = "Ganda",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 95,
                    GroupId = 3,
                    Code = "LI",
                    Description = "Limburgan; Limburger; Limburgish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 96,
                    GroupId = 3,
                    Code = "LN",
                    Description = "Lingala",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 97,
                    GroupId = 3,
                    Code = "LO",
                    Description = "Lao",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 98,
                    GroupId = 3,
                    Code = "LT",
                    Description = "Lithuanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 99,
                    GroupId = 3,
                    Code = "LU",
                    Description = "Luba-Katanga",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 100,
                    GroupId = 3,
                    Code = "LV",
                    Description = "Latvian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 101,
                    GroupId = 3,
                    Code = "MG",
                    Description = "Malagasy",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 102,
                    GroupId = 3,
                    Code = "MH",
                    Description = "Marshallese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 103,
                    GroupId = 3,
                    Code = "MI",
                    Description = "Maori",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 104,
                    GroupId = 3,
                    Code = "MK",
                    Description = "Macedonian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 105,
                    GroupId = 3,
                    Code = "ML",
                    Description = "Malayalam",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 106,
                    GroupId = 3,
                    Code = "MN",
                    Description = "Mongolian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 107,
                    GroupId = 3,
                    Code = "MR",
                    Description = "Marathi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 108,
                    GroupId = 3,
                    Code = "MS",
                    Description = "Malay",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 109,
                    GroupId = 3,
                    Code = "MT",
                    Description = "Maltese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 110,
                    GroupId = 3,
                    Code = "MY",
                    Description = "Burmese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 111,
                    GroupId = 3,
                    Code = "NA",
                    Description = "Nauru",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 112,
                    GroupId = 3,
                    Code = "NB",
                    Description = "Norwegian Bokm�l",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 113,
                    GroupId = 3,
                    Code = "ND",
                    Description = "North Ndebele",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 114,
                    GroupId = 3,
                    Code = "NE",
                    Description = "Nepali",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 115,
                    GroupId = 3,
                    Code = "NG",
                    Description = "Ndonga",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 116,
                    GroupId = 3,
                    Code = "NL",
                    Description = "Dutch; Flemish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 117,
                    GroupId = 3,
                    Code = "NN",
                    Description = "Norwegian Nynorsk; Nynorsk,Norwegian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 118,
                    GroupId = 3,
                    Code = "NO",
                    Description = "Norwegian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 119,
                    GroupId = 3,
                    Code = "NR",
                    Description = "Ndebele,South; South Ndebele",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 120,
                    GroupId = 3,
                    Code = "NV",
                    Description = "Navajo; Navaho",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 121,
                    GroupId = 3,
                    Code = "NY",
                    Description = "Chichewa; Chewa; Nyanja",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 122,
                    GroupId = 3,
                    Code = "OC",
                    Description = "Occitan (post 1500)",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 123,
                    GroupId = 3,
                    Code = "OJ",
                    Description = "Ojibwa",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 124,
                    GroupId = 3,
                    Code = "OM",
                    Description = "Oromo",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 125,
                    GroupId = 3,
                    Code = "OR",
                    Description = "Oriya",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 126,
                    GroupId = 3,
                    Code = "OS",
                    Description = "Ossetian; Ossetic",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 127,
                    GroupId = 3,
                    Code = "PA",
                    Description = "Panjabi; Punjabi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 128,
                    GroupId = 3,
                    Code = "PI",
                    Description = "Pali",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 129,
                    GroupId = 3,
                    Code = "PL",
                    Description = "Polish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 130,
                    GroupId = 3,
                    Code = "PS",
                    Description = "Pushto; Pashto",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 131,
                    GroupId = 3,
                    Code = "PT",
                    Description = "Portuguese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 132,
                    GroupId = 3,
                    Code = "QU",
                    Description = "Quechua",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 133,
                    GroupId = 3,
                    Code = "RM",
                    Description = "Romansh",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 134,
                    GroupId = 3,
                    Code = "RN",
                    Description = "Rundi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 135,
                    GroupId = 3,
                    Code = "RO",
                    Description = "Romanian; Moldavian; Moldovan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 136,
                    GroupId = 3,
                    Code = "RU",
                    Description = "Russian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 137,
                    GroupId = 3,
                    Code = "RW",
                    Description = "Kinyarwanda",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 138,
                    GroupId = 3,
                    Code = "SA",
                    Description = "Sanskrit",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 139,
                    GroupId = 3,
                    Code = "SC",
                    Description = "Sardinian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 140,
                    GroupId = 3,
                    Code = "SD",
                    Description = "Sindhi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 141,
                    GroupId = 3,
                    Code = "SE",
                    Description = "Northern Sami",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 142,
                    GroupId = 3,
                    Code = "SG",
                    Description = "Sango",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 143,
                    GroupId = 3,
                    Code = "SI",
                    Description = "Sinhala; Sinhalese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 144,
                    GroupId = 3,
                    Code = "SK",
                    Description = "Slovak",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 145,
                    GroupId = 3,
                    Code = "SL",
                    Description = "Slovenian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 146,
                    GroupId = 3,
                    Code = "SM",
                    Description = "Samoan",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 147,
                    GroupId = 3,
                    Code = "SN",
                    Description = "Shona",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 148,
                    GroupId = 3,
                    Code = "SO",
                    Description = "Somali",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 149,
                    GroupId = 3,
                    Code = "SQ",
                    Description = "Albanian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 150,
                    GroupId = 3,
                    Code = "SR",
                    Description = "Serbian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 151,
                    GroupId = 3,
                    Code = "SS",
                    Description = "Swati",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 152,
                    GroupId = 3,
                    Code = "ST",
                    Description = "Sotho, Southern",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 153,
                    GroupId = 3,
                    Code = "SU",
                    Description = "Sundanese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 154,
                    GroupId = 3,
                    Code = "SV",
                    Description = "Swedish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 155,
                    GroupId = 3,
                    Code = "SW",
                    Description = "Swahili",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 156,
                    GroupId = 3,
                    Code = "TA",
                    Description = "Tamil",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 157,
                    GroupId = 3,
                    Code = "TE",
                    Description = "Telugu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 158,
                    GroupId = 3,
                    Code = "TG",
                    Description = "Tajik",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 159,
                    GroupId = 3,
                    Code = "TH",
                    Description = "Thai",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 160,
                    GroupId = 3,
                    Code = "TI",
                    Description = "Tigrinya",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 161,
                    GroupId = 3,
                    Code = "TK",
                    Description = "Turkmen",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 162,
                    GroupId = 3,
                    Code = "TL",
                    Description = "Tagalog",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 163,
                    GroupId = 3,
                    Code = "TN",
                    Description = "Tswana",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 164,
                    GroupId = 3,
                    Code = "TO",
                    Description = "Tonga (Tonga Islands)",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 165,
                    GroupId = 3,
                    Code = "TR",
                    Description = "Turkish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 166,
                    GroupId = 3,
                    Code = "TS",
                    Description = "Tsonga",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 167,
                    GroupId = 3,
                    Code = "TT",
                    Description = "Tatar",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 168,
                    GroupId = 3,
                    Code = "TW",
                    Description = "Twi",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 169,
                    GroupId = 3,
                    Code = "TY",
                    Description = "Tahitian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 170,
                    GroupId = 3,
                    Code = "UG",
                    Description = "Uighur; Uyghur",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 171,
                    GroupId = 3,
                    Code = "UK",
                    Description = "Ukrainian",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 172,
                    GroupId = 3,
                    Code = "UR",
                    Description = "Urdu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 173,
                    GroupId = 3,
                    Code = "UZ",
                    Description = "Uzbek",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 174,
                    GroupId = 3,
                    Code = "VE",
                    Description = "Venda",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 175,
                    GroupId = 3,
                    Code = "VI",
                    Description = "Vietnamese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 176,
                    GroupId = 3,
                    Code = "VO",
                    Description = "Volap�k",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 177,
                    GroupId = 3,
                    Code = "WA",
                    Description = "Walloon",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 178,
                    GroupId = 3,
                    Code = "WO",
                    Description = "Wolof",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 179,
                    GroupId = 3,
                    Code = "XH",
                    Description = "Xhosa",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 180,
                    GroupId = 3,
                    Code = "YI",
                    Description = "Yiddish",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 181,
                    GroupId = 3,
                    Code = "YO",
                    Description = "Yoruba",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 182,
                    GroupId = 3,
                    Code = "ZA",
                    Description = "Zhuang; Chuang",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 183,
                    GroupId = 3,
                    Code = "ZH",
                    Description = "Chinese",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },
                new ConfigGenericItem
                {
                    Id = 184,
                    GroupId = 3,
                    Code = "ZU",
                    Description = "Zulu",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial Seed"
                },

                #endregion
            };
        }
    }
}
