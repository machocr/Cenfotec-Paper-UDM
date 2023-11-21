using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Models.HumanResources
{
	public class EmploymentApplication
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ApplicationId { get; set; }

        public DateTime ApplicationDate { get; set; }

        public EmploymentApplicationSourceType Source { get; set; }

        public EmploymentApplicationStatusType Status { get; set; }

        [BsonIgnore]
        public Person ReferredByParty { get; internal set; }
        public string ReferredByPartyId { get; set; }

        [BsonIgnore]
        public Person AppliyingParty { get; internal set; }
        public string AppliyingPartyId { get; set; }
    }
}
