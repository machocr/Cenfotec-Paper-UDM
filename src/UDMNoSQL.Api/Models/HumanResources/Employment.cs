using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;
using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Models.HumanResources
{
    [BsonDiscriminator("employmentClass")]
    public class Employment : PartyRelationship
	{
        public Employment()
        {
            FromRoleType = RoleType.InternalOrganization;
            ToRoleType = RoleType.Employee;
        }

        public Organization FromParty { get; internal set; }

        public Person ToParty { get; internal set; }

        public List<PositionFulfillment> PositionFulfillmentList { get; set; } = new List<PositionFulfillment>();

        public List<PayHistory> PayHistoryList { get; set; } = new List<PayHistory>();

        public List<Paycheck> PaycheckList { get; set; } = new List<Paycheck>();

        public List<PayrollReference> PayrollReferenceList { get; set; } = new List<PayrollReference>();

        public List<UnemploymentClaim> UnemploymentClaimList { get; set; } = new List<UnemploymentClaim>();

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public TerminationType TerminationType { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public TerminationReason TerminationReason { get; set; }

        public List<PerformanceNote> PerformanceNoteList { get; set; } = new List<PerformanceNote>();

        public List<PerformanceReview> PerformanceReviewList { get; set; } = new List<PerformanceReview>();
    }
}

