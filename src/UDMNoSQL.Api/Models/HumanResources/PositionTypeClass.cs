using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PositionTypeClass
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PositionClassificationType Type { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int StandardHoursPerWeek { get; set; }
    }
}

