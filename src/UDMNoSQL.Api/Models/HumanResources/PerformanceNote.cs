using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PerformanceNote
	{
        public string ManagerPartyId { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PerformanceNoteType Type { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public DateTime CommunicationDate { get; set; }
    }
}

