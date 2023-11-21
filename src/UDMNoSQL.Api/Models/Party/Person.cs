using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("personClass")]
    public class Person : Party
    {
        public Person()
        {
            Type = PartyType.Person;
        }

        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public string MiddletName { get; set; }

        public string MothersMaidenName { get; set; }

        public string PersonalTitle { get; set; }

        public string Sufux { get; set; }

        public string Nickname { get; set; }

        public DateTime BirthDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public GenderType Gender { get; set; }

        public double? Heigh { get; set; }

        public double? Weigh { get; set; }

        public string SocialSecurityNo { get; set; }

        public string PassportNo { get; set; }

        public DateTime PassportExpireDate { get; set; }

        public int TotalYearsWorkExperience { get; set; }

        public string Comment { get; set; }

        public List<MaritalStatusItem> MaritalStatusList { get; set; } = new List<MaritalStatusItem>();

        //Classification

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EEOCClassificationType EEOCClassification { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public IncomeClassificationType IncomeClassification { get; set; }

    }
}

