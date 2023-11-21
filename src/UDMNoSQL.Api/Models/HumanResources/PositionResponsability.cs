using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PositionResponsability
	{
        public string TypeId { get; set;  }

        public ResponsabilityType Type { get; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public string Comment { get; set; }
    }
}

