using System;
using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [JsonDerivedType(typeof(Employee), typeDiscriminator: "employeeClass")]
    [JsonDerivedType(typeof(Contractor), typeDiscriminator: "contractorClass")]
    [JsonDerivedType(typeof(InternalOrganization), typeDiscriminator: "internalOrganizationClass")]
    [BsonKnownTypes(typeof(Employee), typeof(Contractor), typeof(InternalOrganization))]
    public abstract class PartyRole : Role
	{
		public PartyRole()
		{
		}
	}
}

