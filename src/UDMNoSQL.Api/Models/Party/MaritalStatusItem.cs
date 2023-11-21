using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.Party
{
	public class MaritalStatusItem
	{
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public MaritalStatusType Type { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }
    }
}

