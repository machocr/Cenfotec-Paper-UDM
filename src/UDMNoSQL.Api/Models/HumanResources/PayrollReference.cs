using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PayrollReference
	{
		public int PayrollPreferenceSeqId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int Percentage { get; set; }

        public decimal FlstAmount { get; set; }

        public string RoutingNumber { get; set; }

        public string AccountNumber { get; set; }

        public string BankName { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public DeductionType DeductionType { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PeriodType PeriodType { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PaymentMethodType PaymentMethodType { get; set; }
    }
}

