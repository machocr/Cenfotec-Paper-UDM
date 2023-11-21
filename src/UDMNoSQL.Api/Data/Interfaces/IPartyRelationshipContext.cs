using MongoDB.Driver;
using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Data.Interfaces
{
    public interface IPartyRelationshipContext
    {
        IMongoCollection<PartyRelationship> PartyRelationshipCollection { get; }
    }
}

