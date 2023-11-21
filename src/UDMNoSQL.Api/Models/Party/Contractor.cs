using System;
using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("contractorClass")]
    public class Contractor : PartyRole
	{
		public Contractor()
		{
			this.Type = RoleType.Contractor;
		}
	}
}

