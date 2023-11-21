using System;
namespace UDMNoSQL.Api.Models.Party
{
	public abstract class PartyRelationship : Relationship
	{
        public string FromPartyId { get; set; }

        public string ToPartyId { get; set; }

        public PartyRelationshipStatusType Status { get; set; } = PartyRelationshipStatusType.Active;

    }
}

