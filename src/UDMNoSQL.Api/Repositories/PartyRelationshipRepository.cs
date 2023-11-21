using MongoDB.Driver;
using UDMNoSQL.Api.Data.Interfaces;
using UDMNoSQL.Api.Models.Party;
using UDMNoSQL.Api.Repositories.Interfaces;

namespace UDMNoSQL.Api.Repositories
{
    public class PartyRelationshipRepository<T> : IPartyRelationshipRepository<T>
        where T : PartyRelationship
    {
        private readonly IPartyRelationshipContext _context;

        public PartyRelationshipRepository(IPartyRelationshipContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<T>> GetPartyRelationshipList(string ToPartyId)
        {
            return (IEnumerable<T>)await _context
                            .PartyRelationshipCollection
                            .Find(p => p.ToPartyId == ToPartyId)
                            .ToListAsync();
        }

        public async Task<T> GetPartyRelationship(string fromPartyId, string ToPartyId)
        {
            return (T)await _context
                            .PartyRelationshipCollection
                            .Find(p => p.ToPartyId == ToPartyId && p.FromPartyId == fromPartyId)
                            .FirstOrDefaultAsync();
        }

        public async Task CreatePartyRelationship(T partyRelationship)
        {
            await _context.PartyRelationshipCollection.InsertOneAsync(partyRelationship);
        }

        public async Task<bool> DeletePartyRelationship(string fromPartyId, string ToPartyId)
        {
            FilterDefinition<PartyRelationship> filter =
                Builders<PartyRelationship>.Filter.Eq(p => p.ToPartyId, ToPartyId) &
                Builders<PartyRelationship>.Filter.Eq(p => p.FromPartyId, fromPartyId);

            DeleteResult deleteResult = await _context
                                                .PartyRelationshipCollection
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
