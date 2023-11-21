using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Repositories.Interfaces
{
    public interface IPartyRelationshipRepository<T>
        where T : PartyRelationship
    {
        Task<IEnumerable<T>> GetPartyRelationshipList(string ToPartyId);
        Task<T> GetPartyRelationship(string fromPartyId, string ToPartyId);
        Task CreatePartyRelationship(T partyRelationship);
        Task<bool> DeletePartyRelationship(string fromPartyId, string ToPartyId);
    }
}

