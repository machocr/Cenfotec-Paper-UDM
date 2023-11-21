using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class BenefitType : Type
	{
        public int EmployerPaidPercentage { get; set; }
    }
}

