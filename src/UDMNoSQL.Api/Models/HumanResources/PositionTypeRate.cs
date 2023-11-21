using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PositionTypeRate
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public RateType RateType { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PeriodType PeriodType { get; set; }

        public SalaryStep SalaryStep { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public decimal Rate { get; set; }
    }
}

