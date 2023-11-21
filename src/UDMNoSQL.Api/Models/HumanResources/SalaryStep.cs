using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class SalaryStep
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PayGrade PayGrade { get; set; }

        public string SalaryStepSeqId { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateModified { get; set; }
    }
}

