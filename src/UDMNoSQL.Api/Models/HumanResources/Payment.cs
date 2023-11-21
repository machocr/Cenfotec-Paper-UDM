using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class Payment
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PaymentMethodType PaymentMethodType { get; set; }

        public List<Deduction> DeductionList { get; set; } = new List<Deduction>();

        public DateTime EffectiveDate { get; set; }

        public string PaymentRefNum { get; set; }

        public decimal Amount { get; set; }

        public string Comment { get; set; }
    }
}

