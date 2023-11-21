using System;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("internalOrganizationClass")]
    public class InternalOrganization : PartyRole
    {
		public InternalOrganization()
		{
			this.Type = RoleType.InternalOrganization;
		}
	}
}

