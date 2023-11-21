using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("organizationClass")]
    public class Organization : Party
	{
        public Organization()
		{
			Type = PartyType.Organization;
		}

        public string Name { get; set; }

        public string FederalTaxIdNum { get; set; }

        //Classification

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public MinorityClassificationType MinorityClassification { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public IndustrylassificationType Industrylassification { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public SizeClassificationType SizeClassification { get; set; }
    }
}

