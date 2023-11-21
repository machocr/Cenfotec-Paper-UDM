using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PartyBenefit
	{
        
        [BsonIgnore]
        public BenefitType BenefitType { get;  internal set; }
        public string BenefitTypeId { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PeriodType PeriodType { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public decimal Cost { get; set; }

        public int ActualEmployeerPaidPercent { get; set; }

        public int AvailableTime { get; set; }

    }
}

