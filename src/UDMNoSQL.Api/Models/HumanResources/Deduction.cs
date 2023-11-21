using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class Deduction
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public DeductionType Type { get; set; }

		public decimal Amount { get; set; }
    }
}

