﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PayHistory
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PeriodType PeriodType { get; set; }

        public SalaryStep SalaryStep { get; set; }

        public decimal Amount { get; set; }

        public string Comment { get; set; }
    }
}

